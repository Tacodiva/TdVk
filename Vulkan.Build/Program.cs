using Cake.Common.IO;
using Cake.Common.Tools.DotNet;
using Cake.Core;
using Cake.Core.Diagnostics;
using Cake.Frosting;

namespace Vulkan.Build;

public static class Program
{
    public static int Main(string[] args)
    {
        return new CakeHost()
            .UseContext<VulkanFrostingContext>()
            .Run(args);
    }
}

[TaskName("Default")]
[IsDependentOn(typeof(PublishTask))]
public class DefaultTask : FrostingTask
{
    public override void Run(ICakeContext context)
    {
        context.Log.Information("");
    }
}

[TaskName("Clean")]
public class CleanTask : FrostingTask<VulkanFrostingContext>
{
    public override void Run(VulkanFrostingContext context)
    {
        context.DeleteDirectory(context.PublishOutputDirectory, new() {
            Recursive = true,
            Force = true
        });
        context.DotNetClean(context.ProjectSolution);
    }
}
