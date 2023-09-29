using System;
using System.Linq;
using System.Xml.Linq;

namespace Vulkan.Build.Codegen
{
    public class CommandDefinition
    {
        private static readonly string[] DeviceLevelCommandParameters = new string[] {
            "VkDevice",
            "VkQueue",
            "VkCommandBuffer"
        };

        public string Name { get; }
        public TypeSpec ReturnType { get; }
        public ParameterDefinition[] Parameters { get; }
        public string API { get; }
        public string[] SuccessCodes { get; }
        public string[] ErrorCodes { get; }
        public bool IsVariant { get; }
        public ExtensionDefinition Extension { get; set; }

        public CommandDefinition(string name, TypeSpec returnType, ParameterDefinition[] parameters, string api, string[] successCodes, string[] errorCodes, bool isVariant, ExtensionDefinition ext = null)
        {
            Require.NotNull(parameters);
            Require.NotNull(successCodes);
            Require.NotNull(errorCodes);

            Name = name;
            ReturnType = returnType;
            Parameters = parameters;
            API = api;
            SuccessCodes = successCodes;
            ErrorCodes = errorCodes;
            IsVariant = isVariant;
            Extension = ext;
        }

        public static CommandDefinition CreateFromXml(XElement xe)
        {
            Require.Equal("command", xe.Name);

            var proto = xe.Element("proto");
            string name = proto.Element("name").Value;
            string returnTypeName = proto.Element("type").Value;
            TypeSpec returnType = new TypeSpec(returnTypeName);

            string api = xe.Attribute("api")?.Value;

            var successAttr = xe.Attribute("successcodes");
            string[] successCodes = successAttr != null
                ? successAttr.Value.Split(',').ToArray()
                : Array.Empty<string>();

            var errorAttr = xe.Attribute("errorcodes");
            string[] errorCodes = errorAttr != null
                ? errorAttr.Value.Split(',').ToArray()
                : Array.Empty<string>();

            ParameterDefinition[] parameters = xe.Elements("param")
                .Select(paramXml => ParameterDefinition.CreateFromXml(paramXml)).ToArray();

            return new CommandDefinition(name, returnType, parameters, api, successCodes, errorCodes, false);
        }

        public string GetParametersSignature(TypeNameMappings tnm, string api = "vulkan")
        {
            return string.Join(", ", Parameters.Where(pd => pd.API == null || pd.API == api).Select(pd => pd.GetMappedAndNormalizedString(tnm)));
        }

        public string GetParametersSignature(string api = "vulkan")
        {
            return string.Join(", ", Parameters.Where(pd => pd.API == null || pd.API == api).Select(pd => pd.ToString()));
        }

        public bool IsDeviceLevel()
        {
            if (Parameters.Length == 0) return false;
            return DeviceLevelCommandParameters.Contains(Parameters[0].Type.Name);
        }

        public override string ToString()
        {
            string paramSig = GetParametersSignature();
            return $"{ReturnType} {Name}({paramSig})";
        }
    }
}
