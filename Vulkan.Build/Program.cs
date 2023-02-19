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