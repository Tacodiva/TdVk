
namespace Vulkan
{
    public interface IVulkanExt
    {
#if NET7_0_OR_GREATER
        public static abstract string Name { get; }
#endif
        string GetName();
    }
}