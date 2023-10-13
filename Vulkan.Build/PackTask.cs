using Cake.Frosting;
using Cake.Common.Tools.DotNet;
using Cake.Common.Tools.DotNet.Publish;
using System.IO;
using Cake.Core.Diagnostics;

namespace Vulkan.Build;

[TaskName("Pack")]
[IsDependentOn(typeof(CodegenTask))]
public class PackTask : FrostingTask<VulkanFrostingContext>
{
    public static readonly string[] TargetFrameworks = {
        "net6.0",
        "net7.0",
        "net8.0"
    };

    public override void Run(VulkanFrostingContext context)
    {
        context.DotNetRestore(context.ProjectSolution);

        foreach (string framework in TargetFrameworks)
        {
            context.Log.Information("Publishing " + framework);
            string outDir = Path.Join(context.PackOutputDirectory, "lib", framework);
            context.DotNetPublish(context.ProjectSolution, new DotNetPublishSettings
            {
                Configuration = context.ProjectConfiguration,
                OutputDirectory = outDir,
                Framework = framework,
                NoRestore = true
            });
            context.Log.Information("Patching " + framework + "...");
            Patcher.Run(context, outDir);
        }
        context.Log.Information("Done");
    }
}
