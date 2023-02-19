using Cake.Frosting;
using Vulkan.Build;
using Cake.Common.Tools.DotNet;
using Cake.Common.Tools.DotNet.Publish;
using Cake.Common.Tools.DotNet.NuGet;
using Cake.Common.Tools.DotNet.Pack;
using System.IO;
using System;

namespace Vulkan.Build;

[TaskName("Publish")]
[IsDependentOn(typeof(CodegenTask))]
public class PublishTask : FrostingTask<VulkanFrostingContext>
{
    public override void Run(VulkanFrostingContext context)
    {
        context.DotNetPublish(context.ProjectSolution, new DotNetPublishSettings
        {
            Configuration = context.ProjectConfiguration,
            OutputDirectory = context.PublishOutputDirectory,
            Framework = context.PublishFramework
        });
        Patcher.Run(context, context.PublishOutputDirectory);
    }
}