using Cake.Common;
using Cake.Core;
using Cake.Frosting;
using System.IO;

namespace Vulkan.Build;

public class VulkanFrostingContext : FrostingContext
{
    public string ProjectDirectory { get; set; }
    public string ProjectName { get; set; }
    public string ProjectSolution { get; set; }

    public string[] CodegenSpecificationXMLs { get; set; }
    public bool CodegenMapBaseTypes { get; set; }
    public string CodegenOutputDirectory { get; set; }

    public string ProjectConfiguration { get; set; }
    public string PublishOutputDirectory { get; set; }
    public string PublishFramework { get; set; }

    public string PackOutputDirectory { get; set; }

    public VulkanFrostingContext(ICakeContext context)
        : base(context)
    {
        ProjectDirectory = context.Argument("project_dir", "Vulkan");
        ProjectName = context.Argument("project_name", "Vulkan");
        ProjectConfiguration = context.Argument("project_configuration", "Release");
        ProjectSolution = context.Argument("project_solution", Path.Join(ProjectDirectory, ProjectName + ".csproj"));

        PublishOutputDirectory = context.Argument("publish_out", "bin");
        PublishFramework = context.Argument("publish_framework", "net7.0");

        PackOutputDirectory = context.Argument("pack_out", "package");

        CodegenSpecificationXMLs = context.Argument("codegen_specs", "vk.xml,video.xml").Split(",");
        CodegenOutputDirectory = context.Argument("codegen_out", "Generated");
        CodegenMapBaseTypes = context.Argument("codegen_map_base_types", true);
    }
}