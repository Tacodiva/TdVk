
using System;
using System.Collections.Generic;
using System.IO;
using Cake.Frosting;
using Cake.Common.IO;
using Vulkan.Build.Codegen;

namespace Vulkan.Build;

[TaskName("Codegen")]
public sealed class CodegenTask : FrostingTask<VulkanFrostingContext>
{
    public override void Run(VulkanFrostingContext context)
    {
        VulkanSpecification vs;

        using (var fs = File.OpenRead(context.CodegenSpecificationXMLs[0]))
        {
            vs = VulkanSpecification.LoadFromXmlStream(fs);
        }
        for (int i = 1; i < context.CodegenSpecificationXMLs.Length; i++)
        {
            using (var fs = File.OpenRead(context.CodegenSpecificationXMLs[i]))
            {
                vs.Merge(VulkanSpecification.LoadFromXmlStream(fs));
            }
        }

        TypeNameMappings tnm = new TypeNameMappings();

        foreach (var typedef in vs.Typedefs)
        {
            if (typedef.API != null && typedef.API != "vulkansc")
                continue;
            if (typedef.Requires != null)
            {
                tnm.AddMapping(typedef.Requires, typedef.Name);
            }
            else if (typedef.BitValues != null)
            {
                tnm.AddMapping(typedef.BitValues, typedef.Name);
            }
            else if (typedef.Type == "VkFlags")
            {
                tnm.AddMapping(typedef.Name, "uint");
            }
            else
            {
                throw new Exception($"Unknown typedef mapping {typedef.Name} -> {typedef.Type}");
            }
        }

        HashSet<string> definedBaseTypes = new HashSet<string>
                {
                    "VkBool32"
                };

        if (context.CodegenMapBaseTypes)
        {
            foreach (var baseType in vs.BaseTypes)
            {
                if (!definedBaseTypes.Contains(baseType.Key))
                {
                    tnm.AddMapping(baseType.Key, baseType.Value);
                }
            }
        }

        string path = Path.Join(context.ProjectDirectory, context.CodegenOutputDirectory);
        context.CleanDirectory(path);
        CodeGenerator.GenerateCodeFiles(vs, tnm, path);
    }
}
