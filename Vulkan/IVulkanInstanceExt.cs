
namespace Vulkan
{

    public interface IVulkanInstanceExt : IVulkanExt
    {
#if NET7_0_OR_GREATER
        public static abstract IVulkanInstanceExt Create(VkInstance instance);
#endif
    }

    public interface IVulkanInstanceExtGeneric<TSelf> : IVulkanInstanceExt where TSelf : IVulkanInstanceExtGeneric<TSelf>
    {
#if NET7_0_OR_GREATER
        public static abstract new TSelf Create(VkInstance instance);

        static IVulkanInstanceExt IVulkanInstanceExt.Create(VkInstance instance)
        {
            return TSelf.Create(instance);
        }
#endif
    }
}