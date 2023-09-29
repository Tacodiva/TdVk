using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Vulkan.Build.Codegen
{
    public class VulkanSpecification
    {
        public CommandDefinition[] Commands { private set; get; }
        public ConstantDefinition[] Constants { private set; get; }
        public TypedefDefinition[] Typedefs { private set; get; }
        public EnumDefinition[] Enums { private set; get; }
        public StructureDefinition[] Structures { private set; get; }
        public StructureDefinition[] Unions { private set; get; }
        public HandleDefinition[] Handles { private set; get; }
        public string[] BitmaskTypes { private set; get; }
        public Dictionary<string, string> BaseTypes { private set; get; }
        public ExtensionDefinition[] Extensions { private set; get; }

        public VulkanSpecification(
            CommandDefinition[] commands,
            ConstantDefinition[] constants,
            TypedefDefinition[] typedefs,
            EnumDefinition[] enums,
            StructureDefinition[] structures,
            StructureDefinition[] unions,
            HandleDefinition[] handles,
            string[] bitmaskTypes,
            Dictionary<string, string> baseTypes,
            ExtensionDefinition[] extensions)
        {
            Commands = commands ?? new CommandDefinition[0];
            Constants = constants;
            Typedefs = typedefs;
            Enums = enums;
            Structures = structures;
            Unions = unions;
            Handles = handles;
            BitmaskTypes = bitmaskTypes;
            BaseTypes = baseTypes;
            Extensions = extensions;
            AddExtensionEnums(Enums, Extensions);
        }

        public void Merge(VulkanSpecification other)
        {
            Commands = Commands.Concat(other.Commands).ToArray();
            Constants = Constants.Concat(other.Constants).ToArray();
            Typedefs = Typedefs.Concat(other.Typedefs).ToArray();
            Enums = Enums.Concat(other.Enums).ToArray();
            Structures = Structures.Concat(other.Structures).ToArray();
            Unions = Unions.Concat(other.Unions).ToArray();
            Handles = Handles.Concat(other.Handles).ToArray();
            BitmaskTypes = BitmaskTypes.Concat(other.BitmaskTypes).ToArray();
            other.BaseTypes.ToList().ForEach(x => BaseTypes.Add(x.Key, x.Value));
            Extensions = Extensions.Concat(other.Extensions).ToArray();
        }

        public static VulkanSpecification LoadFromXmlStream(Stream specFileStream)
        {
            var spec = XDocument.Load(specFileStream);
            var registry = spec.Element("registry");
            var commands = registry.Element("commands");
            CommandDefinition[] commandDefinitions = commands?.Elements("command")
                .Where(xe => xe.Attribute("alias") == null)
                .Select(commandx => CommandDefinition.CreateFromXml(commandx))
                .Where(cd => cd != null).ToArray();

            var types = registry.Elements("types");
            TypedefDefinition[] typedefDefinitions = types.Elements("type").Where(xe => xe.Value.Contains("typedef") && xe.HasCategoryAttribute("bitmask"))
                .Select(xe2 => TypedefDefinition.CreateFromXml(xe2)).ToArray();

            EnumDefinition[] enumDefinitions = registry.Elements("enums")
                .Where(enumx => enumx.GetTypeAttributeOrNull() == "enum" || enumx.GetTypeAttributeOrNull() == "bitmask")
                .Where(enumx => enumx.Attribute("alias") == null)
                .Select(enumx => EnumDefinition.CreateFromXml(enumx)).ToArray();

            StructureDefinition[] structures = types.Elements("type").Where(typex => typex.HasCategoryAttribute("struct"))
                .Select(typex => StructureDefinition.CreateFromXml(typex)).ToArray();

            StructureDefinition[] unions =
                types.Elements("type")
                .Where(typex => typex.HasCategoryAttribute("union"))
                .Select(typex => StructureDefinition.CreateFromXml(typex)).ToArray();

            HandleDefinition[] handles = types.Elements("type").Where(typex => typex.HasCategoryAttribute("handle"))
                .Where(typex => typex.Attribute("alias") == null)
                .Select(typex => HandleDefinition.CreateFromXml(typex)).ToArray();

            string[] bitmaskTypes = types.Elements("type").Where(typex => typex.HasCategoryAttribute("bitmask"))
                .Where(typex => typex.Attribute("alias") == null)
                .Select(typex => typex.GetNameElement()).ToArray();

            Dictionary<string, string> baseTypes = types.Elements("type").Where(typex => typex.HasCategoryAttribute("basetype"))
                .Where(typex => typex.Attribute("alias") == null)
                .Where(typex => typex.Element("type") != null)
                .ToDictionary(
                    typex => typex.GetNameElement(),
                    typex => typex.Element("type")?.Value);

            types.Elements("type")
                .Where(typex => typex.Attribute("alias") != null && typex.Attribute("name") != null)
                .ToList()
                .ForEach(type => baseTypes.Add(type.GetNameAttribute(), (string)type.Attribute("alias")));

            ExtensionDefinition[] featureExtensions = registry.Elements("feature")
                .Select(xe => ExtensionDefinition.CreateFromXml(xe, 0)).ToArray();

            ExtensionDefinition[] extensionExtensions = registry.Element("extensions").Elements("extension")
                .Select(xe =>
                {
                    string numberString = xe.Attribute("number")?.Value ?? "0";
                    int number = int.Parse(numberString);
                    return ExtensionDefinition.CreateFromXml(xe, number);
                }).ToArray();

            ExtensionDefinition[] extensions = featureExtensions.Concat(extensionExtensions).ToArray();

            foreach (ExtensionDefinition ext in extensions)
            {
                foreach (string extCmd in ext.CommandNames)
                {
                    CommandDefinition extCmdDef = commandDefinitions.Where(cmd => cmd.Name == extCmd).FirstOrDefault();
                    if (extCmdDef != null) extCmdDef.Extension = ext;
                }
            }

            ConstantDefinition[] constantDefinitions = registry.Elements("enums")
                .Where(enumx => enumx.Attribute("name").Value == "API Constants")
                .SelectMany(enumx => enumx.Elements("enum"))
                .Where(enumx => enumx.Attribute("alias") == null)
                .Select(enumxx => ConstantDefinition.CreateFromXml(enumxx))
                .Concat(
                    extensions.SelectMany(
                        ext => ext.Constants.Select(
                            cnst => new ConstantDefinition(cnst.Name, cnst.Value, null)
                        // This is a special version type we don't support
                        ).Where(cnst => !(cnst.Value.StartsWith("VK_STD_VULKAN_VIDEO_CODEC_") && cnst.Value.Contains("VERSION")))
                    )
                )
                .ToArray();

            return new VulkanSpecification(
                commandDefinitions,
                constantDefinitions,
                typedefDefinitions,
                enumDefinitions,
                structures,
                unions,
                handles,
                bitmaskTypes,
                baseTypes,
                extensions);
        }

        private void AddExtensionEnums(EnumDefinition[] enums, ExtensionDefinition[] extensions)
        {
            foreach (ExtensionDefinition exDef in extensions)
            {
                foreach (var enumEx in exDef.EnumExtensions)
                {
                    EnumDefinition enumDef = GetEnumDef(enums, enumEx.ExtendedType);
                    var prev = enumDef.Values.FirstOrDefault(val => val.Name == enumEx.Name);
                    int value = int.Parse(enumEx.Value);

                    if (prev != null)
                    {
                        if (prev.ValueOrBitPosition != value)
                        {
                            throw new InvalidOperationException("The same enum cannot have different values");
                        }
                        // Skip duplicates
                        continue;
                    }

                    enumDef.Values = enumDef.Values.Append(new EnumValue(enumEx.Name, value, null)).ToArray();
                }
            }
        }

        private EnumDefinition GetEnumDef(EnumDefinition[] enums, string name)
        {
            return enums.Single(ed => ed.Name == name);
        }
    }
}
