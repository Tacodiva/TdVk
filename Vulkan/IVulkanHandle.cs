
namespace Vulkan
{
    public interface IVulkanHandle
    {
#if NET7_0_OR_GREATER
        public static abstract VkObjectType VkObjectType { get; }
#endif
        VkObjectType GetVkObjectType();
        ulong GetHandle();
    }
}
