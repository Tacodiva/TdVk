
namespace Vulkan
{

    public interface IVulkanDeviceExt : IVulkanExt
    {
#if NET7_0_OR_GREATER
        public static abstract IVulkanDeviceExt Create(VkDevice device);
#endif
    }

    public interface IVulkanDeviceExtGeneric<TSelf> : IVulkanDeviceExt where TSelf : IVulkanDeviceExtGeneric<TSelf>
    {
#if NET7_0_OR_GREATER
        public static abstract new TSelf Create(VkDevice device);

        static IVulkanDeviceExt IVulkanDeviceExt.Create(VkDevice device)
        {
            return TSelf.Create(device);
        }
#endif
    }
}