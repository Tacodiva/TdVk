using Cake.Frosting;
using Vulkan.Build;
using Cake.Common.Tools.DotNet;
using Cake.Common.Tools.DotNet.Publish;
using Cake.Common.Solution;
using Cake.Common.Tools.DotNet.NuGet;
using Cake.Common.Tools.DotNet.Pack;
using System.IO;
using Cake.Core.Diagnostics;

namespace Vulkan.Build;

[TaskName("Pack")]
[IsDependentOn(typeof(CodegenTask))]
public class PackTask : FrostingTask<VulkanFrostingContext>
{
    public static readonly string[] TargetFrameworks = {
        "netstandard1.4",
        "netstandard2.1",
        "netcoreapp3.1",
        "net471",
        "net5.0",
        "net6.0",
        "net7.0"
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