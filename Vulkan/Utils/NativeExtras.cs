
using System;

namespace Vulkan
{
    public static partial class VulkanNative
    {
        public static uint VK_MAKE_VERSION(int major, int minor, int patch)
        {
            return (uint)(((major) << 22) | ((minor) << 12) | patch);
        }

        public static uint VK_MAKE_VERSION(Version v)
        {
            return VK_MAKE_VERSION(v.Major, v.Minor, v.Build);
        }
    }
}