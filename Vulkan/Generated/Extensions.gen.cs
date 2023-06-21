// This file is generated.

using System;

namespace Vulkan
{
    public unsafe sealed class VulkanKHRSurface : IVulkanInstanceExtGeneric<VulkanKHRSurface>
    {
        public static string Name => "VK_KHR_surface";
        string IVulkanExt.GetName() => Name;

        public static VulkanKHRSurface Create(VkInstance instance)
        {
            return new VulkanKHRSurface(instance);
        }

        private IntPtr vkDestroySurfaceKHR_ptr;
        private IntPtr vkGetPhysicalDeviceSurfaceCapabilitiesKHR_ptr;
        private IntPtr vkGetPhysicalDeviceSurfaceFormatsKHR_ptr;
        private IntPtr vkGetPhysicalDeviceSurfacePresentModesKHR_ptr;
        private IntPtr vkGetPhysicalDeviceSurfaceSupportKHR_ptr;

        [Generator.CalliRewrite]
        public unsafe void vkDestroySurfaceKHR(VkInstance instance, VkSurfaceKHR surface, VkAllocationCallbacks* pAllocator)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkDestroySurfaceKHR(VkInstance instance, VkSurfaceKHR surface, ref VkAllocationCallbacks pAllocator)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkDestroySurfaceKHR(VkInstance instance, VkSurfaceKHR surface, IntPtr pAllocator)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSurfaceCapabilitiesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, VkSurfaceCapabilitiesKHR* pSurfaceCapabilities)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSurfaceCapabilitiesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, out VkSurfaceCapabilitiesKHR pSurfaceCapabilities)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSurfaceFormatsKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pSurfaceFormatCount, VkSurfaceFormatKHR* pSurfaceFormats)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSurfaceFormatsKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pSurfaceFormatCount, out VkSurfaceFormatKHR pSurfaceFormats)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSurfaceFormatsKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, ref uint pSurfaceFormatCount, VkSurfaceFormatKHR* pSurfaceFormats)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSurfaceFormatsKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, ref uint pSurfaceFormatCount, out VkSurfaceFormatKHR pSurfaceFormats)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSurfaceFormatsKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, IntPtr pSurfaceFormatCount, VkSurfaceFormatKHR* pSurfaceFormats)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSurfaceFormatsKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, IntPtr pSurfaceFormatCount, out VkSurfaceFormatKHR pSurfaceFormats)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSurfacePresentModesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pPresentModeCount, VkPresentModeKHR* pPresentModes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSurfacePresentModesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pPresentModeCount, out VkPresentModeKHR pPresentModes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSurfacePresentModesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, ref uint pPresentModeCount, VkPresentModeKHR* pPresentModes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSurfacePresentModesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, ref uint pPresentModeCount, out VkPresentModeKHR pPresentModes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSurfacePresentModesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, IntPtr pPresentModeCount, VkPresentModeKHR* pPresentModes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSurfacePresentModesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, IntPtr pPresentModeCount, out VkPresentModeKHR pPresentModes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSurfaceSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, VkSurfaceKHR surface, VkBool32* pSupported)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSurfaceSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, VkSurfaceKHR surface, out VkBool32 pSupported)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanKHRSurface(VkInstance instance)
        {
            vkDestroySurfaceKHR_ptr = VulkanNative.LoadInstanceProcAddr(instance, "vkDestroySurfaceKHR", true);
            vkGetPhysicalDeviceSurfaceCapabilitiesKHR_ptr = VulkanNative.LoadInstanceProcAddr(instance, "vkGetPhysicalDeviceSurfaceCapabilitiesKHR", true);
            vkGetPhysicalDeviceSurfaceFormatsKHR_ptr = VulkanNative.LoadInstanceProcAddr(instance, "vkGetPhysicalDeviceSurfaceFormatsKHR", true);
            vkGetPhysicalDeviceSurfacePresentModesKHR_ptr = VulkanNative.LoadInstanceProcAddr(instance, "vkGetPhysicalDeviceSurfacePresentModesKHR", true);
            vkGetPhysicalDeviceSurfaceSupportKHR_ptr = VulkanNative.LoadInstanceProcAddr(instance, "vkGetPhysicalDeviceSurfaceSupportKHR", true);
        }
    }

    public unsafe sealed class VulkanKHRSwapchain : IVulkanDeviceExtGeneric<VulkanKHRSwapchain>
    {
        public static string Name => "VK_KHR_swapchain";
        string IVulkanExt.GetName() => Name;

        public static VulkanKHRSwapchain Create(VkDevice device)
        {
            return new VulkanKHRSwapchain(device);
        }

        private IntPtr vkAcquireNextImageKHR_ptr;
        private IntPtr vkCreateSwapchainKHR_ptr;
        private IntPtr vkDestroySwapchainKHR_ptr;
        private IntPtr vkGetSwapchainImagesKHR_ptr;
        private IntPtr vkQueuePresentKHR_ptr;

        ///<remarks>Success codes:VK_SUCCESS, VK_TIMEOUT, VK_NOT_READY, VK_SUBOPTIMAL_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_OUT_OF_DATE_KHR, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_FULL_SCREEN_EXCLUSIVE_MODE_LOST_EXT</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkAcquireNextImageKHR(VkDevice device, VkSwapchainKHR swapchain, ulong timeout, VkSemaphore semaphore, VkFence fence, uint* pImageIndex)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_TIMEOUT, VK_NOT_READY, VK_SUBOPTIMAL_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_OUT_OF_DATE_KHR, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_FULL_SCREEN_EXCLUSIVE_MODE_LOST_EXT</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkAcquireNextImageKHR(VkDevice device, VkSwapchainKHR swapchain, ulong timeout, VkSemaphore semaphore, VkFence fence, ref uint pImageIndex)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_TIMEOUT, VK_NOT_READY, VK_SUBOPTIMAL_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_OUT_OF_DATE_KHR, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_FULL_SCREEN_EXCLUSIVE_MODE_LOST_EXT</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkAcquireNextImageKHR(VkDevice device, VkSwapchainKHR swapchain, ulong timeout, VkSemaphore semaphore, VkFence fence, IntPtr pImageIndex)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_COMPRESSION_EXHAUSTED_EXT</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateSwapchainKHR(VkDevice device, VkSwapchainCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSwapchainKHR* pSwapchain)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_COMPRESSION_EXHAUSTED_EXT</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateSwapchainKHR(VkDevice device, VkSwapchainCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSwapchainKHR pSwapchain)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_COMPRESSION_EXHAUSTED_EXT</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateSwapchainKHR(VkDevice device, VkSwapchainCreateInfoKHR* pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSwapchainKHR* pSwapchain)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_COMPRESSION_EXHAUSTED_EXT</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateSwapchainKHR(VkDevice device, VkSwapchainCreateInfoKHR* pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSwapchainKHR pSwapchain)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_COMPRESSION_EXHAUSTED_EXT</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateSwapchainKHR(VkDevice device, VkSwapchainCreateInfoKHR* pCreateInfo, IntPtr pAllocator, VkSwapchainKHR* pSwapchain)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_COMPRESSION_EXHAUSTED_EXT</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateSwapchainKHR(VkDevice device, VkSwapchainCreateInfoKHR* pCreateInfo, IntPtr pAllocator, out VkSwapchainKHR pSwapchain)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_COMPRESSION_EXHAUSTED_EXT</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateSwapchainKHR(VkDevice device, ref VkSwapchainCreateInfoKHR pCreateInfo, VkAllocationCallbacks* pAllocator, VkSwapchainKHR* pSwapchain)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_COMPRESSION_EXHAUSTED_EXT</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateSwapchainKHR(VkDevice device, ref VkSwapchainCreateInfoKHR pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSwapchainKHR pSwapchain)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_COMPRESSION_EXHAUSTED_EXT</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateSwapchainKHR(VkDevice device, ref VkSwapchainCreateInfoKHR pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSwapchainKHR* pSwapchain)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_COMPRESSION_EXHAUSTED_EXT</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateSwapchainKHR(VkDevice device, ref VkSwapchainCreateInfoKHR pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSwapchainKHR pSwapchain)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_COMPRESSION_EXHAUSTED_EXT</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateSwapchainKHR(VkDevice device, ref VkSwapchainCreateInfoKHR pCreateInfo, IntPtr pAllocator, VkSwapchainKHR* pSwapchain)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_COMPRESSION_EXHAUSTED_EXT</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateSwapchainKHR(VkDevice device, ref VkSwapchainCreateInfoKHR pCreateInfo, IntPtr pAllocator, out VkSwapchainKHR pSwapchain)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_COMPRESSION_EXHAUSTED_EXT</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateSwapchainKHR(VkDevice device, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, VkSwapchainKHR* pSwapchain)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_COMPRESSION_EXHAUSTED_EXT</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateSwapchainKHR(VkDevice device, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSwapchainKHR pSwapchain)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_COMPRESSION_EXHAUSTED_EXT</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateSwapchainKHR(VkDevice device, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSwapchainKHR* pSwapchain)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_COMPRESSION_EXHAUSTED_EXT</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateSwapchainKHR(VkDevice device, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSwapchainKHR pSwapchain)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_COMPRESSION_EXHAUSTED_EXT</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateSwapchainKHR(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, VkSwapchainKHR* pSwapchain)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_COMPRESSION_EXHAUSTED_EXT</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateSwapchainKHR(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, out VkSwapchainKHR pSwapchain)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkDestroySwapchainKHR(VkDevice device, VkSwapchainKHR swapchain, VkAllocationCallbacks* pAllocator)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkDestroySwapchainKHR(VkDevice device, VkSwapchainKHR swapchain, ref VkAllocationCallbacks pAllocator)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkDestroySwapchainKHR(VkDevice device, VkSwapchainKHR swapchain, IntPtr pAllocator)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetSwapchainImagesKHR(VkDevice device, VkSwapchainKHR swapchain, uint* pSwapchainImageCount, VkImage* pSwapchainImages)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetSwapchainImagesKHR(VkDevice device, VkSwapchainKHR swapchain, uint* pSwapchainImageCount, out VkImage pSwapchainImages)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetSwapchainImagesKHR(VkDevice device, VkSwapchainKHR swapchain, ref uint pSwapchainImageCount, VkImage* pSwapchainImages)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetSwapchainImagesKHR(VkDevice device, VkSwapchainKHR swapchain, ref uint pSwapchainImageCount, out VkImage pSwapchainImages)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetSwapchainImagesKHR(VkDevice device, VkSwapchainKHR swapchain, IntPtr pSwapchainImageCount, VkImage* pSwapchainImages)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetSwapchainImagesKHR(VkDevice device, VkSwapchainKHR swapchain, IntPtr pSwapchainImageCount, out VkImage pSwapchainImages)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_SUBOPTIMAL_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_OUT_OF_DATE_KHR, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_FULL_SCREEN_EXCLUSIVE_MODE_LOST_EXT</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkQueuePresentKHR(VkQueue queue, VkPresentInfoKHR* pPresentInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_SUBOPTIMAL_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_OUT_OF_DATE_KHR, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_FULL_SCREEN_EXCLUSIVE_MODE_LOST_EXT</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkQueuePresentKHR(VkQueue queue, ref VkPresentInfoKHR pPresentInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_SUBOPTIMAL_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_OUT_OF_DATE_KHR, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_FULL_SCREEN_EXCLUSIVE_MODE_LOST_EXT</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkQueuePresentKHR(VkQueue queue, IntPtr pPresentInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanKHRSwapchain(VkDevice device)
        {
            vkAcquireNextImageKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkAcquireNextImageKHR", true);
            vkCreateSwapchainKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCreateSwapchainKHR", true);
            vkDestroySwapchainKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkDestroySwapchainKHR", true);
            vkGetSwapchainImagesKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetSwapchainImagesKHR", true);
            vkQueuePresentKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkQueuePresentKHR", true);
        }
    }

    public unsafe sealed class VulkanKHRDisplay : IVulkanInstanceExtGeneric<VulkanKHRDisplay>
    {
        public static string Name => "VK_KHR_display";
        string IVulkanExt.GetName() => Name;

        public static VulkanKHRDisplay Create(VkInstance instance)
        {
            return new VulkanKHRDisplay(instance);
        }

        private IntPtr vkCreateDisplayModeKHR_ptr;
        private IntPtr vkCreateDisplayPlaneSurfaceKHR_ptr;
        private IntPtr vkGetDisplayModePropertiesKHR_ptr;
        private IntPtr vkGetDisplayPlaneCapabilitiesKHR_ptr;
        private IntPtr vkGetDisplayPlaneSupportedDisplaysKHR_ptr;
        private IntPtr vkGetPhysicalDeviceDisplayPlanePropertiesKHR_ptr;
        private IntPtr vkGetPhysicalDeviceDisplayPropertiesKHR_ptr;

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, VkDisplayModeCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDisplayModeKHR* pMode)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, VkDisplayModeCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkDisplayModeKHR pMode)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, VkDisplayModeCreateInfoKHR* pCreateInfo, ref VkAllocationCallbacks pAllocator, VkDisplayModeKHR* pMode)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, VkDisplayModeCreateInfoKHR* pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkDisplayModeKHR pMode)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, VkDisplayModeCreateInfoKHR* pCreateInfo, IntPtr pAllocator, VkDisplayModeKHR* pMode)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, VkDisplayModeCreateInfoKHR* pCreateInfo, IntPtr pAllocator, out VkDisplayModeKHR pMode)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, ref VkDisplayModeCreateInfoKHR pCreateInfo, VkAllocationCallbacks* pAllocator, VkDisplayModeKHR* pMode)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, ref VkDisplayModeCreateInfoKHR pCreateInfo, VkAllocationCallbacks* pAllocator, out VkDisplayModeKHR pMode)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, ref VkDisplayModeCreateInfoKHR pCreateInfo, ref VkAllocationCallbacks pAllocator, VkDisplayModeKHR* pMode)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, ref VkDisplayModeCreateInfoKHR pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkDisplayModeKHR pMode)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, ref VkDisplayModeCreateInfoKHR pCreateInfo, IntPtr pAllocator, VkDisplayModeKHR* pMode)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, ref VkDisplayModeCreateInfoKHR pCreateInfo, IntPtr pAllocator, out VkDisplayModeKHR pMode)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, VkDisplayModeKHR* pMode)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, out VkDisplayModeKHR pMode)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, VkDisplayModeKHR* pMode)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkDisplayModeKHR pMode)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, IntPtr pCreateInfo, IntPtr pAllocator, VkDisplayModeKHR* pMode)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, IntPtr pCreateInfo, IntPtr pAllocator, out VkDisplayModeKHR pMode)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDisplayPlaneSurfaceKHR(VkInstance instance, VkDisplaySurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDisplayPlaneSurfaceKHR(VkInstance instance, VkDisplaySurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDisplayPlaneSurfaceKHR(VkInstance instance, VkDisplaySurfaceCreateInfoKHR* pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDisplayPlaneSurfaceKHR(VkInstance instance, VkDisplaySurfaceCreateInfoKHR* pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDisplayPlaneSurfaceKHR(VkInstance instance, VkDisplaySurfaceCreateInfoKHR* pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDisplayPlaneSurfaceKHR(VkInstance instance, VkDisplaySurfaceCreateInfoKHR* pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDisplayPlaneSurfaceKHR(VkInstance instance, ref VkDisplaySurfaceCreateInfoKHR pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDisplayPlaneSurfaceKHR(VkInstance instance, ref VkDisplaySurfaceCreateInfoKHR pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDisplayPlaneSurfaceKHR(VkInstance instance, ref VkDisplaySurfaceCreateInfoKHR pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDisplayPlaneSurfaceKHR(VkInstance instance, ref VkDisplaySurfaceCreateInfoKHR pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDisplayPlaneSurfaceKHR(VkInstance instance, ref VkDisplaySurfaceCreateInfoKHR pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDisplayPlaneSurfaceKHR(VkInstance instance, ref VkDisplaySurfaceCreateInfoKHR pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDisplayPlaneSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDisplayPlaneSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDisplayPlaneSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDisplayPlaneSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDisplayPlaneSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDisplayPlaneSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetDisplayModePropertiesKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, uint* pPropertyCount, VkDisplayModePropertiesKHR* pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetDisplayModePropertiesKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, uint* pPropertyCount, out VkDisplayModePropertiesKHR pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetDisplayModePropertiesKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, ref uint pPropertyCount, VkDisplayModePropertiesKHR* pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetDisplayModePropertiesKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, ref uint pPropertyCount, out VkDisplayModePropertiesKHR pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetDisplayModePropertiesKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, IntPtr pPropertyCount, VkDisplayModePropertiesKHR* pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetDisplayModePropertiesKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, IntPtr pPropertyCount, out VkDisplayModePropertiesKHR pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetDisplayPlaneCapabilitiesKHR(VkPhysicalDevice physicalDevice, VkDisplayModeKHR mode, uint planeIndex, VkDisplayPlaneCapabilitiesKHR* pCapabilities)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetDisplayPlaneCapabilitiesKHR(VkPhysicalDevice physicalDevice, VkDisplayModeKHR mode, uint planeIndex, out VkDisplayPlaneCapabilitiesKHR pCapabilities)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetDisplayPlaneSupportedDisplaysKHR(VkPhysicalDevice physicalDevice, uint planeIndex, uint* pDisplayCount, VkDisplayKHR* pDisplays)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetDisplayPlaneSupportedDisplaysKHR(VkPhysicalDevice physicalDevice, uint planeIndex, uint* pDisplayCount, out VkDisplayKHR pDisplays)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetDisplayPlaneSupportedDisplaysKHR(VkPhysicalDevice physicalDevice, uint planeIndex, ref uint pDisplayCount, VkDisplayKHR* pDisplays)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetDisplayPlaneSupportedDisplaysKHR(VkPhysicalDevice physicalDevice, uint planeIndex, ref uint pDisplayCount, out VkDisplayKHR pDisplays)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetDisplayPlaneSupportedDisplaysKHR(VkPhysicalDevice physicalDevice, uint planeIndex, IntPtr pDisplayCount, VkDisplayKHR* pDisplays)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetDisplayPlaneSupportedDisplaysKHR(VkPhysicalDevice physicalDevice, uint planeIndex, IntPtr pDisplayCount, out VkDisplayKHR pDisplays)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceDisplayPlanePropertiesKHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayPlanePropertiesKHR* pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceDisplayPlanePropertiesKHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, out VkDisplayPlanePropertiesKHR pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceDisplayPlanePropertiesKHR(VkPhysicalDevice physicalDevice, ref uint pPropertyCount, VkDisplayPlanePropertiesKHR* pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceDisplayPlanePropertiesKHR(VkPhysicalDevice physicalDevice, ref uint pPropertyCount, out VkDisplayPlanePropertiesKHR pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceDisplayPlanePropertiesKHR(VkPhysicalDevice physicalDevice, IntPtr pPropertyCount, VkDisplayPlanePropertiesKHR* pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceDisplayPlanePropertiesKHR(VkPhysicalDevice physicalDevice, IntPtr pPropertyCount, out VkDisplayPlanePropertiesKHR pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceDisplayPropertiesKHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayPropertiesKHR* pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceDisplayPropertiesKHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, out VkDisplayPropertiesKHR pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceDisplayPropertiesKHR(VkPhysicalDevice physicalDevice, ref uint pPropertyCount, VkDisplayPropertiesKHR* pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceDisplayPropertiesKHR(VkPhysicalDevice physicalDevice, ref uint pPropertyCount, out VkDisplayPropertiesKHR pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceDisplayPropertiesKHR(VkPhysicalDevice physicalDevice, IntPtr pPropertyCount, VkDisplayPropertiesKHR* pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceDisplayPropertiesKHR(VkPhysicalDevice physicalDevice, IntPtr pPropertyCount, out VkDisplayPropertiesKHR pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanKHRDisplay(VkInstance instance)
        {
            vkCreateDisplayModeKHR_ptr = VulkanNative.LoadInstanceProcAddr(instance, "vkCreateDisplayModeKHR", true);
            vkCreateDisplayPlaneSurfaceKHR_ptr = VulkanNative.LoadInstanceProcAddr(instance, "vkCreateDisplayPlaneSurfaceKHR", true);
            vkGetDisplayModePropertiesKHR_ptr = VulkanNative.LoadInstanceProcAddr(instance, "vkGetDisplayModePropertiesKHR", true);
            vkGetDisplayPlaneCapabilitiesKHR_ptr = VulkanNative.LoadInstanceProcAddr(instance, "vkGetDisplayPlaneCapabilitiesKHR", true);
            vkGetDisplayPlaneSupportedDisplaysKHR_ptr = VulkanNative.LoadInstanceProcAddr(instance, "vkGetDisplayPlaneSupportedDisplaysKHR", true);
            vkGetPhysicalDeviceDisplayPlanePropertiesKHR_ptr = VulkanNative.LoadInstanceProcAddr(instance, "vkGetPhysicalDeviceDisplayPlanePropertiesKHR", true);
            vkGetPhysicalDeviceDisplayPropertiesKHR_ptr = VulkanNative.LoadInstanceProcAddr(instance, "vkGetPhysicalDeviceDisplayPropertiesKHR", true);
        }
    }

    public unsafe sealed class VulkanKHRDisplaySwapchain : IVulkanDeviceExtGeneric<VulkanKHRDisplaySwapchain>
    {
        public static string Name => "VK_KHR_display_swapchain";
        string IVulkanExt.GetName() => Name;

        public static VulkanKHRDisplaySwapchain Create(VkDevice device)
        {
            return new VulkanKHRDisplaySwapchain(device);
        }

        private IntPtr vkCreateSharedSwapchainsKHR_ptr;

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INCOMPATIBLE_DISPLAY_KHR, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, VkSwapchainCreateInfoKHR* pCreateInfos, VkAllocationCallbacks* pAllocator, VkSwapchainKHR* pSwapchains)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INCOMPATIBLE_DISPLAY_KHR, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, VkSwapchainCreateInfoKHR* pCreateInfos, VkAllocationCallbacks* pAllocator, out VkSwapchainKHR pSwapchains)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INCOMPATIBLE_DISPLAY_KHR, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, VkSwapchainCreateInfoKHR* pCreateInfos, ref VkAllocationCallbacks pAllocator, VkSwapchainKHR* pSwapchains)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INCOMPATIBLE_DISPLAY_KHR, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, VkSwapchainCreateInfoKHR* pCreateInfos, ref VkAllocationCallbacks pAllocator, out VkSwapchainKHR pSwapchains)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INCOMPATIBLE_DISPLAY_KHR, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, VkSwapchainCreateInfoKHR* pCreateInfos, IntPtr pAllocator, VkSwapchainKHR* pSwapchains)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INCOMPATIBLE_DISPLAY_KHR, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, VkSwapchainCreateInfoKHR* pCreateInfos, IntPtr pAllocator, out VkSwapchainKHR pSwapchains)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INCOMPATIBLE_DISPLAY_KHR, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, ref VkSwapchainCreateInfoKHR pCreateInfos, VkAllocationCallbacks* pAllocator, VkSwapchainKHR* pSwapchains)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INCOMPATIBLE_DISPLAY_KHR, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, ref VkSwapchainCreateInfoKHR pCreateInfos, VkAllocationCallbacks* pAllocator, out VkSwapchainKHR pSwapchains)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INCOMPATIBLE_DISPLAY_KHR, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, ref VkSwapchainCreateInfoKHR pCreateInfos, ref VkAllocationCallbacks pAllocator, VkSwapchainKHR* pSwapchains)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INCOMPATIBLE_DISPLAY_KHR, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, ref VkSwapchainCreateInfoKHR pCreateInfos, ref VkAllocationCallbacks pAllocator, out VkSwapchainKHR pSwapchains)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INCOMPATIBLE_DISPLAY_KHR, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, ref VkSwapchainCreateInfoKHR pCreateInfos, IntPtr pAllocator, VkSwapchainKHR* pSwapchains)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INCOMPATIBLE_DISPLAY_KHR, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, ref VkSwapchainCreateInfoKHR pCreateInfos, IntPtr pAllocator, out VkSwapchainKHR pSwapchains)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INCOMPATIBLE_DISPLAY_KHR, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, IntPtr pCreateInfos, VkAllocationCallbacks* pAllocator, VkSwapchainKHR* pSwapchains)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INCOMPATIBLE_DISPLAY_KHR, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, IntPtr pCreateInfos, VkAllocationCallbacks* pAllocator, out VkSwapchainKHR pSwapchains)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INCOMPATIBLE_DISPLAY_KHR, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, IntPtr pCreateInfos, ref VkAllocationCallbacks pAllocator, VkSwapchainKHR* pSwapchains)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INCOMPATIBLE_DISPLAY_KHR, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, IntPtr pCreateInfos, ref VkAllocationCallbacks pAllocator, out VkSwapchainKHR pSwapchains)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INCOMPATIBLE_DISPLAY_KHR, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, IntPtr pCreateInfos, IntPtr pAllocator, VkSwapchainKHR* pSwapchains)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INCOMPATIBLE_DISPLAY_KHR, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, IntPtr pCreateInfos, IntPtr pAllocator, out VkSwapchainKHR pSwapchains)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INCOMPATIBLE_DISPLAY_KHR, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, VkSwapchainCreateInfoKHR[] pCreateInfos, VkAllocationCallbacks* pAllocator, VkSwapchainKHR* pSwapchains)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INCOMPATIBLE_DISPLAY_KHR, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, VkSwapchainCreateInfoKHR[] pCreateInfos, VkAllocationCallbacks* pAllocator, out VkSwapchainKHR pSwapchains)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INCOMPATIBLE_DISPLAY_KHR, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, VkSwapchainCreateInfoKHR[] pCreateInfos, ref VkAllocationCallbacks pAllocator, VkSwapchainKHR* pSwapchains)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INCOMPATIBLE_DISPLAY_KHR, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, VkSwapchainCreateInfoKHR[] pCreateInfos, ref VkAllocationCallbacks pAllocator, out VkSwapchainKHR pSwapchains)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INCOMPATIBLE_DISPLAY_KHR, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, VkSwapchainCreateInfoKHR[] pCreateInfos, IntPtr pAllocator, VkSwapchainKHR* pSwapchains)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INCOMPATIBLE_DISPLAY_KHR, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, VkSwapchainCreateInfoKHR[] pCreateInfos, IntPtr pAllocator, out VkSwapchainKHR pSwapchains)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanKHRDisplaySwapchain(VkDevice device)
        {
            vkCreateSharedSwapchainsKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCreateSharedSwapchainsKHR", true);
        }
    }

    public unsafe sealed class VulkanKHRXlibSurface : IVulkanInstanceExtGeneric<VulkanKHRXlibSurface>
    {
        public static string Name => "VK_KHR_xlib_surface";
        string IVulkanExt.GetName() => Name;

        public static VulkanKHRXlibSurface Create(VkInstance instance)
        {
            return new VulkanKHRXlibSurface(instance);
        }

        private IntPtr vkCreateXlibSurfaceKHR_ptr;
        private IntPtr vkGetPhysicalDeviceXlibPresentationSupportKHR_ptr;

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateXlibSurfaceKHR(VkInstance instance, VkXlibSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateXlibSurfaceKHR(VkInstance instance, VkXlibSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateXlibSurfaceKHR(VkInstance instance, VkXlibSurfaceCreateInfoKHR* pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateXlibSurfaceKHR(VkInstance instance, VkXlibSurfaceCreateInfoKHR* pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateXlibSurfaceKHR(VkInstance instance, VkXlibSurfaceCreateInfoKHR* pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateXlibSurfaceKHR(VkInstance instance, VkXlibSurfaceCreateInfoKHR* pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateXlibSurfaceKHR(VkInstance instance, ref VkXlibSurfaceCreateInfoKHR pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateXlibSurfaceKHR(VkInstance instance, ref VkXlibSurfaceCreateInfoKHR pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateXlibSurfaceKHR(VkInstance instance, ref VkXlibSurfaceCreateInfoKHR pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateXlibSurfaceKHR(VkInstance instance, ref VkXlibSurfaceCreateInfoKHR pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateXlibSurfaceKHR(VkInstance instance, ref VkXlibSurfaceCreateInfoKHR pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateXlibSurfaceKHR(VkInstance instance, ref VkXlibSurfaceCreateInfoKHR pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateXlibSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateXlibSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateXlibSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateXlibSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateXlibSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateXlibSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe VkBool32 vkGetPhysicalDeviceXlibPresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, Xlib.Display* dpy, Xlib.VisualID visualID)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe VkBool32 vkGetPhysicalDeviceXlibPresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, ref Xlib.Display dpy, Xlib.VisualID visualID)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe VkBool32 vkGetPhysicalDeviceXlibPresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr dpy, Xlib.VisualID visualID)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanKHRXlibSurface(VkInstance instance)
        {
            vkCreateXlibSurfaceKHR_ptr = VulkanNative.LoadInstanceProcAddr(instance, "vkCreateXlibSurfaceKHR", true);
            vkGetPhysicalDeviceXlibPresentationSupportKHR_ptr = VulkanNative.LoadInstanceProcAddr(instance, "vkGetPhysicalDeviceXlibPresentationSupportKHR", true);
        }
    }

    public unsafe sealed class VulkanKHRXcbSurface : IVulkanInstanceExtGeneric<VulkanKHRXcbSurface>
    {
        public static string Name => "VK_KHR_xcb_surface";
        string IVulkanExt.GetName() => Name;

        public static VulkanKHRXcbSurface Create(VkInstance instance)
        {
            return new VulkanKHRXcbSurface(instance);
        }

        private IntPtr vkCreateXcbSurfaceKHR_ptr;
        private IntPtr vkGetPhysicalDeviceXcbPresentationSupportKHR_ptr;

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateXcbSurfaceKHR(VkInstance instance, VkXcbSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateXcbSurfaceKHR(VkInstance instance, VkXcbSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateXcbSurfaceKHR(VkInstance instance, VkXcbSurfaceCreateInfoKHR* pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateXcbSurfaceKHR(VkInstance instance, VkXcbSurfaceCreateInfoKHR* pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateXcbSurfaceKHR(VkInstance instance, VkXcbSurfaceCreateInfoKHR* pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateXcbSurfaceKHR(VkInstance instance, VkXcbSurfaceCreateInfoKHR* pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateXcbSurfaceKHR(VkInstance instance, ref VkXcbSurfaceCreateInfoKHR pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateXcbSurfaceKHR(VkInstance instance, ref VkXcbSurfaceCreateInfoKHR pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateXcbSurfaceKHR(VkInstance instance, ref VkXcbSurfaceCreateInfoKHR pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateXcbSurfaceKHR(VkInstance instance, ref VkXcbSurfaceCreateInfoKHR pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateXcbSurfaceKHR(VkInstance instance, ref VkXcbSurfaceCreateInfoKHR pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateXcbSurfaceKHR(VkInstance instance, ref VkXcbSurfaceCreateInfoKHR pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateXcbSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateXcbSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateXcbSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateXcbSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateXcbSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateXcbSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe VkBool32 vkGetPhysicalDeviceXcbPresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, Xcb.xcb_connection_t* connection, Xcb.xcb_visualid_t visual_id)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe VkBool32 vkGetPhysicalDeviceXcbPresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, ref Xcb.xcb_connection_t connection, Xcb.xcb_visualid_t visual_id)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe VkBool32 vkGetPhysicalDeviceXcbPresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr connection, Xcb.xcb_visualid_t visual_id)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanKHRXcbSurface(VkInstance instance)
        {
            vkCreateXcbSurfaceKHR_ptr = VulkanNative.LoadInstanceProcAddr(instance, "vkCreateXcbSurfaceKHR", true);
            vkGetPhysicalDeviceXcbPresentationSupportKHR_ptr = VulkanNative.LoadInstanceProcAddr(instance, "vkGetPhysicalDeviceXcbPresentationSupportKHR", true);
        }
    }

    public unsafe sealed class VulkanKHRWaylandSurface : IVulkanInstanceExtGeneric<VulkanKHRWaylandSurface>
    {
        public static string Name => "VK_KHR_wayland_surface";
        string IVulkanExt.GetName() => Name;

        public static VulkanKHRWaylandSurface Create(VkInstance instance)
        {
            return new VulkanKHRWaylandSurface(instance);
        }

        private IntPtr vkCreateWaylandSurfaceKHR_ptr;
        private IntPtr vkGetPhysicalDeviceWaylandPresentationSupportKHR_ptr;

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateWaylandSurfaceKHR(VkInstance instance, VkWaylandSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateWaylandSurfaceKHR(VkInstance instance, VkWaylandSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateWaylandSurfaceKHR(VkInstance instance, VkWaylandSurfaceCreateInfoKHR* pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateWaylandSurfaceKHR(VkInstance instance, VkWaylandSurfaceCreateInfoKHR* pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateWaylandSurfaceKHR(VkInstance instance, VkWaylandSurfaceCreateInfoKHR* pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateWaylandSurfaceKHR(VkInstance instance, VkWaylandSurfaceCreateInfoKHR* pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateWaylandSurfaceKHR(VkInstance instance, ref VkWaylandSurfaceCreateInfoKHR pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateWaylandSurfaceKHR(VkInstance instance, ref VkWaylandSurfaceCreateInfoKHR pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateWaylandSurfaceKHR(VkInstance instance, ref VkWaylandSurfaceCreateInfoKHR pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateWaylandSurfaceKHR(VkInstance instance, ref VkWaylandSurfaceCreateInfoKHR pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateWaylandSurfaceKHR(VkInstance instance, ref VkWaylandSurfaceCreateInfoKHR pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateWaylandSurfaceKHR(VkInstance instance, ref VkWaylandSurfaceCreateInfoKHR pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateWaylandSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateWaylandSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateWaylandSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateWaylandSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateWaylandSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateWaylandSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe VkBool32 vkGetPhysicalDeviceWaylandPresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, Wayland.wl_display* display)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe VkBool32 vkGetPhysicalDeviceWaylandPresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, out Wayland.wl_display display)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanKHRWaylandSurface(VkInstance instance)
        {
            vkCreateWaylandSurfaceKHR_ptr = VulkanNative.LoadInstanceProcAddr(instance, "vkCreateWaylandSurfaceKHR", true);
            vkGetPhysicalDeviceWaylandPresentationSupportKHR_ptr = VulkanNative.LoadInstanceProcAddr(instance, "vkGetPhysicalDeviceWaylandPresentationSupportKHR", true);
        }
    }

    public unsafe sealed class VulkanKHRAndroidSurface : IVulkanInstanceExtGeneric<VulkanKHRAndroidSurface>
    {
        public static string Name => "VK_KHR_android_surface";
        string IVulkanExt.GetName() => Name;

        public static VulkanKHRAndroidSurface Create(VkInstance instance)
        {
            return new VulkanKHRAndroidSurface(instance);
        }

        private IntPtr vkCreateAndroidSurfaceKHR_ptr;

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateAndroidSurfaceKHR(VkInstance instance, VkAndroidSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateAndroidSurfaceKHR(VkInstance instance, VkAndroidSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateAndroidSurfaceKHR(VkInstance instance, VkAndroidSurfaceCreateInfoKHR* pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateAndroidSurfaceKHR(VkInstance instance, VkAndroidSurfaceCreateInfoKHR* pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateAndroidSurfaceKHR(VkInstance instance, VkAndroidSurfaceCreateInfoKHR* pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateAndroidSurfaceKHR(VkInstance instance, VkAndroidSurfaceCreateInfoKHR* pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateAndroidSurfaceKHR(VkInstance instance, ref VkAndroidSurfaceCreateInfoKHR pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateAndroidSurfaceKHR(VkInstance instance, ref VkAndroidSurfaceCreateInfoKHR pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateAndroidSurfaceKHR(VkInstance instance, ref VkAndroidSurfaceCreateInfoKHR pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateAndroidSurfaceKHR(VkInstance instance, ref VkAndroidSurfaceCreateInfoKHR pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateAndroidSurfaceKHR(VkInstance instance, ref VkAndroidSurfaceCreateInfoKHR pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateAndroidSurfaceKHR(VkInstance instance, ref VkAndroidSurfaceCreateInfoKHR pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateAndroidSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateAndroidSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateAndroidSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateAndroidSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateAndroidSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateAndroidSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanKHRAndroidSurface(VkInstance instance)
        {
            vkCreateAndroidSurfaceKHR_ptr = VulkanNative.LoadInstanceProcAddr(instance, "vkCreateAndroidSurfaceKHR", true);
        }
    }

    public unsafe sealed class VulkanKHRWin32Surface : IVulkanInstanceExtGeneric<VulkanKHRWin32Surface>
    {
        public static string Name => "VK_KHR_win32_surface";
        string IVulkanExt.GetName() => Name;

        public static VulkanKHRWin32Surface Create(VkInstance instance)
        {
            return new VulkanKHRWin32Surface(instance);
        }

        private IntPtr vkCreateWin32SurfaceKHR_ptr;
        private IntPtr vkGetPhysicalDeviceWin32PresentationSupportKHR_ptr;

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateWin32SurfaceKHR(VkInstance instance, VkWin32SurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateWin32SurfaceKHR(VkInstance instance, VkWin32SurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateWin32SurfaceKHR(VkInstance instance, VkWin32SurfaceCreateInfoKHR* pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateWin32SurfaceKHR(VkInstance instance, VkWin32SurfaceCreateInfoKHR* pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateWin32SurfaceKHR(VkInstance instance, VkWin32SurfaceCreateInfoKHR* pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateWin32SurfaceKHR(VkInstance instance, VkWin32SurfaceCreateInfoKHR* pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateWin32SurfaceKHR(VkInstance instance, ref VkWin32SurfaceCreateInfoKHR pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateWin32SurfaceKHR(VkInstance instance, ref VkWin32SurfaceCreateInfoKHR pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateWin32SurfaceKHR(VkInstance instance, ref VkWin32SurfaceCreateInfoKHR pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateWin32SurfaceKHR(VkInstance instance, ref VkWin32SurfaceCreateInfoKHR pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateWin32SurfaceKHR(VkInstance instance, ref VkWin32SurfaceCreateInfoKHR pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateWin32SurfaceKHR(VkInstance instance, ref VkWin32SurfaceCreateInfoKHR pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateWin32SurfaceKHR(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateWin32SurfaceKHR(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateWin32SurfaceKHR(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateWin32SurfaceKHR(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateWin32SurfaceKHR(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateWin32SurfaceKHR(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe VkBool32 vkGetPhysicalDeviceWin32PresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanKHRWin32Surface(VkInstance instance)
        {
            vkCreateWin32SurfaceKHR_ptr = VulkanNative.LoadInstanceProcAddr(instance, "vkCreateWin32SurfaceKHR", true);
            vkGetPhysicalDeviceWin32PresentationSupportKHR_ptr = VulkanNative.LoadInstanceProcAddr(instance, "vkGetPhysicalDeviceWin32PresentationSupportKHR", true);
        }
    }

    public unsafe sealed class VulkanAndroidNativeBuffer : IVulkanDeviceExtGeneric<VulkanAndroidNativeBuffer>
    {
        public static string Name => "VK_ANDROID_native_buffer";
        string IVulkanExt.GetName() => Name;

        public static VulkanAndroidNativeBuffer Create(VkDevice device)
        {
            return new VulkanAndroidNativeBuffer(device);
        }

        private IntPtr vkAcquireImageANDROID_ptr;
        private IntPtr vkGetSwapchainGrallocUsage2ANDROID_ptr;
        private IntPtr vkGetSwapchainGrallocUsageANDROID_ptr;
        private IntPtr vkQueueSignalReleaseImageANDROID_ptr;

        [Generator.CalliRewrite]
        public unsafe VkResult vkAcquireImageANDROID(VkDevice device, VkImage image, int nativeFenceFd, VkSemaphore semaphore, VkFence fence)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe VkResult vkGetSwapchainGrallocUsage2ANDROID(VkDevice device, VkFormat format, VkImageUsageFlags imageUsage, VkSwapchainImageUsageFlagsANDROID swapchainImageUsage, ulong* grallocConsumerUsage, ulong* grallocProducerUsage)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe VkResult vkGetSwapchainGrallocUsage2ANDROID(VkDevice device, VkFormat format, VkImageUsageFlags imageUsage, VkSwapchainImageUsageFlagsANDROID swapchainImageUsage, ulong* grallocConsumerUsage, out ulong grallocProducerUsage)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe VkResult vkGetSwapchainGrallocUsage2ANDROID(VkDevice device, VkFormat format, VkImageUsageFlags imageUsage, VkSwapchainImageUsageFlagsANDROID swapchainImageUsage, ref ulong grallocConsumerUsage, ulong* grallocProducerUsage)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe VkResult vkGetSwapchainGrallocUsage2ANDROID(VkDevice device, VkFormat format, VkImageUsageFlags imageUsage, VkSwapchainImageUsageFlagsANDROID swapchainImageUsage, ref ulong grallocConsumerUsage, out ulong grallocProducerUsage)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe VkResult vkGetSwapchainGrallocUsage2ANDROID(VkDevice device, VkFormat format, VkImageUsageFlags imageUsage, VkSwapchainImageUsageFlagsANDROID swapchainImageUsage, IntPtr grallocConsumerUsage, ulong* grallocProducerUsage)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe VkResult vkGetSwapchainGrallocUsage2ANDROID(VkDevice device, VkFormat format, VkImageUsageFlags imageUsage, VkSwapchainImageUsageFlagsANDROID swapchainImageUsage, IntPtr grallocConsumerUsage, out ulong grallocProducerUsage)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe VkResult vkGetSwapchainGrallocUsageANDROID(VkDevice device, VkFormat format, VkImageUsageFlags imageUsage, int* grallocUsage)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe VkResult vkGetSwapchainGrallocUsageANDROID(VkDevice device, VkFormat format, VkImageUsageFlags imageUsage, out int grallocUsage)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe VkResult vkQueueSignalReleaseImageANDROID(VkQueue queue, uint waitSemaphoreCount, VkSemaphore* pWaitSemaphores, VkImage image, int* pNativeFenceFd)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe VkResult vkQueueSignalReleaseImageANDROID(VkQueue queue, uint waitSemaphoreCount, VkSemaphore* pWaitSemaphores, VkImage image, ref int pNativeFenceFd)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe VkResult vkQueueSignalReleaseImageANDROID(VkQueue queue, uint waitSemaphoreCount, VkSemaphore* pWaitSemaphores, VkImage image, IntPtr pNativeFenceFd)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe VkResult vkQueueSignalReleaseImageANDROID(VkQueue queue, uint waitSemaphoreCount, ref VkSemaphore pWaitSemaphores, VkImage image, int* pNativeFenceFd)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe VkResult vkQueueSignalReleaseImageANDROID(VkQueue queue, uint waitSemaphoreCount, ref VkSemaphore pWaitSemaphores, VkImage image, ref int pNativeFenceFd)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe VkResult vkQueueSignalReleaseImageANDROID(VkQueue queue, uint waitSemaphoreCount, ref VkSemaphore pWaitSemaphores, VkImage image, IntPtr pNativeFenceFd)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe VkResult vkQueueSignalReleaseImageANDROID(VkQueue queue, uint waitSemaphoreCount, IntPtr pWaitSemaphores, VkImage image, int* pNativeFenceFd)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe VkResult vkQueueSignalReleaseImageANDROID(VkQueue queue, uint waitSemaphoreCount, IntPtr pWaitSemaphores, VkImage image, ref int pNativeFenceFd)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe VkResult vkQueueSignalReleaseImageANDROID(VkQueue queue, uint waitSemaphoreCount, IntPtr pWaitSemaphores, VkImage image, IntPtr pNativeFenceFd)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanAndroidNativeBuffer(VkDevice device)
        {
            vkAcquireImageANDROID_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkAcquireImageANDROID", true);
            vkGetSwapchainGrallocUsage2ANDROID_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetSwapchainGrallocUsage2ANDROID", true);
            vkGetSwapchainGrallocUsageANDROID_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetSwapchainGrallocUsageANDROID", true);
            vkQueueSignalReleaseImageANDROID_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkQueueSignalReleaseImageANDROID", true);
        }
    }

    public unsafe sealed class VulkanEXTDebugReport : IVulkanInstanceExtGeneric<VulkanEXTDebugReport>
    {
        public static string Name => "VK_EXT_debug_report";
        string IVulkanExt.GetName() => Name;

        public static VulkanEXTDebugReport Create(VkInstance instance)
        {
            return new VulkanEXTDebugReport(instance);
        }

        private IntPtr vkCreateDebugReportCallbackEXT_ptr;
        private IntPtr vkDebugReportMessageEXT_ptr;
        private IntPtr vkDestroyDebugReportCallbackEXT_ptr;

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDebugReportCallbackEXT(VkInstance instance, VkDebugReportCallbackCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDebugReportCallbackEXT* pCallback)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDebugReportCallbackEXT(VkInstance instance, VkDebugReportCallbackCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkDebugReportCallbackEXT pCallback)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDebugReportCallbackEXT(VkInstance instance, VkDebugReportCallbackCreateInfoEXT* pCreateInfo, ref VkAllocationCallbacks pAllocator, VkDebugReportCallbackEXT* pCallback)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDebugReportCallbackEXT(VkInstance instance, VkDebugReportCallbackCreateInfoEXT* pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkDebugReportCallbackEXT pCallback)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDebugReportCallbackEXT(VkInstance instance, VkDebugReportCallbackCreateInfoEXT* pCreateInfo, IntPtr pAllocator, VkDebugReportCallbackEXT* pCallback)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDebugReportCallbackEXT(VkInstance instance, VkDebugReportCallbackCreateInfoEXT* pCreateInfo, IntPtr pAllocator, out VkDebugReportCallbackEXT pCallback)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDebugReportCallbackEXT(VkInstance instance, ref VkDebugReportCallbackCreateInfoEXT pCreateInfo, VkAllocationCallbacks* pAllocator, VkDebugReportCallbackEXT* pCallback)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDebugReportCallbackEXT(VkInstance instance, ref VkDebugReportCallbackCreateInfoEXT pCreateInfo, VkAllocationCallbacks* pAllocator, out VkDebugReportCallbackEXT pCallback)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDebugReportCallbackEXT(VkInstance instance, ref VkDebugReportCallbackCreateInfoEXT pCreateInfo, ref VkAllocationCallbacks pAllocator, VkDebugReportCallbackEXT* pCallback)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDebugReportCallbackEXT(VkInstance instance, ref VkDebugReportCallbackCreateInfoEXT pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkDebugReportCallbackEXT pCallback)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDebugReportCallbackEXT(VkInstance instance, ref VkDebugReportCallbackCreateInfoEXT pCreateInfo, IntPtr pAllocator, VkDebugReportCallbackEXT* pCallback)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDebugReportCallbackEXT(VkInstance instance, ref VkDebugReportCallbackCreateInfoEXT pCreateInfo, IntPtr pAllocator, out VkDebugReportCallbackEXT pCallback)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDebugReportCallbackEXT(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, VkDebugReportCallbackEXT* pCallback)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDebugReportCallbackEXT(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, out VkDebugReportCallbackEXT pCallback)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDebugReportCallbackEXT(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, VkDebugReportCallbackEXT* pCallback)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDebugReportCallbackEXT(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkDebugReportCallbackEXT pCallback)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDebugReportCallbackEXT(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, VkDebugReportCallbackEXT* pCallback)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDebugReportCallbackEXT(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, out VkDebugReportCallbackEXT pCallback)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkDebugReportMessageEXT(VkInstance instance, VkDebugReportFlagsEXT flags, VkDebugReportObjectTypeEXT objectType, ulong @object, UIntPtr location, int messageCode, byte* pLayerPrefix, byte* pMessage)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkDebugReportMessageEXT(VkInstance instance, VkDebugReportFlagsEXT flags, VkDebugReportObjectTypeEXT objectType, ulong @object, UIntPtr location, int messageCode, byte* pLayerPrefix, string pMessage)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkDebugReportMessageEXT(VkInstance instance, VkDebugReportFlagsEXT flags, VkDebugReportObjectTypeEXT objectType, ulong @object, UIntPtr location, int messageCode, string pLayerPrefix, byte* pMessage)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkDebugReportMessageEXT(VkInstance instance, VkDebugReportFlagsEXT flags, VkDebugReportObjectTypeEXT objectType, ulong @object, UIntPtr location, int messageCode, string pLayerPrefix, string pMessage)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkDestroyDebugReportCallbackEXT(VkInstance instance, VkDebugReportCallbackEXT callback, VkAllocationCallbacks* pAllocator)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkDestroyDebugReportCallbackEXT(VkInstance instance, VkDebugReportCallbackEXT callback, ref VkAllocationCallbacks pAllocator)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkDestroyDebugReportCallbackEXT(VkInstance instance, VkDebugReportCallbackEXT callback, IntPtr pAllocator)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanEXTDebugReport(VkInstance instance)
        {
            vkCreateDebugReportCallbackEXT_ptr = VulkanNative.LoadInstanceProcAddr(instance, "vkCreateDebugReportCallbackEXT", true);
            vkDebugReportMessageEXT_ptr = VulkanNative.LoadInstanceProcAddr(instance, "vkDebugReportMessageEXT", true);
            vkDestroyDebugReportCallbackEXT_ptr = VulkanNative.LoadInstanceProcAddr(instance, "vkDestroyDebugReportCallbackEXT", true);
        }
    }

    public unsafe sealed class VulkanEXTDebugMarker : IVulkanDeviceExtGeneric<VulkanEXTDebugMarker>
    {
        public static string Name => "VK_EXT_debug_marker";
        string IVulkanExt.GetName() => Name;

        public static VulkanEXTDebugMarker Create(VkDevice device)
        {
            return new VulkanEXTDebugMarker(device);
        }

        private IntPtr vkCmdDebugMarkerBeginEXT_ptr;
        private IntPtr vkCmdDebugMarkerEndEXT_ptr;
        private IntPtr vkCmdDebugMarkerInsertEXT_ptr;
        private IntPtr vkDebugMarkerSetObjectNameEXT_ptr;
        private IntPtr vkDebugMarkerSetObjectTagEXT_ptr;

        [Generator.CalliRewrite]
        public unsafe void vkCmdDebugMarkerBeginEXT(VkCommandBuffer commandBuffer, VkDebugMarkerMarkerInfoEXT* pMarkerInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdDebugMarkerBeginEXT(VkCommandBuffer commandBuffer, ref VkDebugMarkerMarkerInfoEXT pMarkerInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdDebugMarkerBeginEXT(VkCommandBuffer commandBuffer, IntPtr pMarkerInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdDebugMarkerEndEXT(VkCommandBuffer commandBuffer)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdDebugMarkerInsertEXT(VkCommandBuffer commandBuffer, VkDebugMarkerMarkerInfoEXT* pMarkerInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdDebugMarkerInsertEXT(VkCommandBuffer commandBuffer, ref VkDebugMarkerMarkerInfoEXT pMarkerInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdDebugMarkerInsertEXT(VkCommandBuffer commandBuffer, IntPtr pMarkerInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkDebugMarkerSetObjectNameEXT(VkDevice device, VkDebugMarkerObjectNameInfoEXT* pNameInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkDebugMarkerSetObjectNameEXT(VkDevice device, ref VkDebugMarkerObjectNameInfoEXT pNameInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkDebugMarkerSetObjectNameEXT(VkDevice device, IntPtr pNameInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkDebugMarkerSetObjectTagEXT(VkDevice device, VkDebugMarkerObjectTagInfoEXT* pTagInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkDebugMarkerSetObjectTagEXT(VkDevice device, ref VkDebugMarkerObjectTagInfoEXT pTagInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkDebugMarkerSetObjectTagEXT(VkDevice device, IntPtr pTagInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanEXTDebugMarker(VkDevice device)
        {
            vkCmdDebugMarkerBeginEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdDebugMarkerBeginEXT", true);
            vkCmdDebugMarkerEndEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdDebugMarkerEndEXT", true);
            vkCmdDebugMarkerInsertEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdDebugMarkerInsertEXT", true);
            vkDebugMarkerSetObjectNameEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkDebugMarkerSetObjectNameEXT", true);
            vkDebugMarkerSetObjectTagEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkDebugMarkerSetObjectTagEXT", true);
        }
    }

    public unsafe sealed class VulkanKHRVideoQueue : IVulkanDeviceExtGeneric<VulkanKHRVideoQueue>
    {
        public static string Name => "VK_KHR_video_queue";
        string IVulkanExt.GetName() => Name;

        public static VulkanKHRVideoQueue Create(VkDevice device)
        {
            return new VulkanKHRVideoQueue(device);
        }

        private IntPtr vkBindVideoSessionMemoryKHR_ptr;
        private IntPtr vkCmdBeginVideoCodingKHR_ptr;
        private IntPtr vkCmdControlVideoCodingKHR_ptr;
        private IntPtr vkCmdEndVideoCodingKHR_ptr;
        private IntPtr vkCreateVideoSessionKHR_ptr;
        private IntPtr vkCreateVideoSessionParametersKHR_ptr;
        private IntPtr vkDestroyVideoSessionKHR_ptr;
        private IntPtr vkDestroyVideoSessionParametersKHR_ptr;
        private IntPtr vkGetPhysicalDeviceVideoCapabilitiesKHR_ptr;
        private IntPtr vkGetPhysicalDeviceVideoFormatPropertiesKHR_ptr;
        private IntPtr vkGetVideoSessionMemoryRequirementsKHR_ptr;
        private IntPtr vkUpdateVideoSessionParametersKHR_ptr;

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkBindVideoSessionMemoryKHR(VkDevice device, VkVideoSessionKHR videoSession, uint bindSessionMemoryInfoCount, VkBindVideoSessionMemoryInfoKHR* pBindSessionMemoryInfos)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkBindVideoSessionMemoryKHR(VkDevice device, VkVideoSessionKHR videoSession, uint bindSessionMemoryInfoCount, ref VkBindVideoSessionMemoryInfoKHR pBindSessionMemoryInfos)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkBindVideoSessionMemoryKHR(VkDevice device, VkVideoSessionKHR videoSession, uint bindSessionMemoryInfoCount, IntPtr pBindSessionMemoryInfos)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkBindVideoSessionMemoryKHR(VkDevice device, VkVideoSessionKHR videoSession, uint bindSessionMemoryInfoCount, VkBindVideoSessionMemoryInfoKHR[] pBindSessionMemoryInfos)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBeginVideoCodingKHR(VkCommandBuffer commandBuffer, VkVideoBeginCodingInfoKHR* pBeginInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBeginVideoCodingKHR(VkCommandBuffer commandBuffer, ref VkVideoBeginCodingInfoKHR pBeginInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBeginVideoCodingKHR(VkCommandBuffer commandBuffer, IntPtr pBeginInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdControlVideoCodingKHR(VkCommandBuffer commandBuffer, VkVideoCodingControlInfoKHR* pCodingControlInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdControlVideoCodingKHR(VkCommandBuffer commandBuffer, ref VkVideoCodingControlInfoKHR pCodingControlInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdControlVideoCodingKHR(VkCommandBuffer commandBuffer, IntPtr pCodingControlInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdEndVideoCodingKHR(VkCommandBuffer commandBuffer, VkVideoEndCodingInfoKHR* pEndCodingInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdEndVideoCodingKHR(VkCommandBuffer commandBuffer, ref VkVideoEndCodingInfoKHR pEndCodingInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdEndVideoCodingKHR(VkCommandBuffer commandBuffer, IntPtr pEndCodingInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_VIDEO_STD_VERSION_NOT_SUPPORTED_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateVideoSessionKHR(VkDevice device, VkVideoSessionCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkVideoSessionKHR* pVideoSession)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_VIDEO_STD_VERSION_NOT_SUPPORTED_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateVideoSessionKHR(VkDevice device, VkVideoSessionCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkVideoSessionKHR pVideoSession)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_VIDEO_STD_VERSION_NOT_SUPPORTED_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateVideoSessionKHR(VkDevice device, VkVideoSessionCreateInfoKHR* pCreateInfo, ref VkAllocationCallbacks pAllocator, VkVideoSessionKHR* pVideoSession)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_VIDEO_STD_VERSION_NOT_SUPPORTED_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateVideoSessionKHR(VkDevice device, VkVideoSessionCreateInfoKHR* pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkVideoSessionKHR pVideoSession)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_VIDEO_STD_VERSION_NOT_SUPPORTED_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateVideoSessionKHR(VkDevice device, VkVideoSessionCreateInfoKHR* pCreateInfo, IntPtr pAllocator, VkVideoSessionKHR* pVideoSession)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_VIDEO_STD_VERSION_NOT_SUPPORTED_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateVideoSessionKHR(VkDevice device, VkVideoSessionCreateInfoKHR* pCreateInfo, IntPtr pAllocator, out VkVideoSessionKHR pVideoSession)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_VIDEO_STD_VERSION_NOT_SUPPORTED_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateVideoSessionKHR(VkDevice device, ref VkVideoSessionCreateInfoKHR pCreateInfo, VkAllocationCallbacks* pAllocator, VkVideoSessionKHR* pVideoSession)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_VIDEO_STD_VERSION_NOT_SUPPORTED_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateVideoSessionKHR(VkDevice device, ref VkVideoSessionCreateInfoKHR pCreateInfo, VkAllocationCallbacks* pAllocator, out VkVideoSessionKHR pVideoSession)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_VIDEO_STD_VERSION_NOT_SUPPORTED_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateVideoSessionKHR(VkDevice device, ref VkVideoSessionCreateInfoKHR pCreateInfo, ref VkAllocationCallbacks pAllocator, VkVideoSessionKHR* pVideoSession)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_VIDEO_STD_VERSION_NOT_SUPPORTED_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateVideoSessionKHR(VkDevice device, ref VkVideoSessionCreateInfoKHR pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkVideoSessionKHR pVideoSession)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_VIDEO_STD_VERSION_NOT_SUPPORTED_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateVideoSessionKHR(VkDevice device, ref VkVideoSessionCreateInfoKHR pCreateInfo, IntPtr pAllocator, VkVideoSessionKHR* pVideoSession)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_VIDEO_STD_VERSION_NOT_SUPPORTED_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateVideoSessionKHR(VkDevice device, ref VkVideoSessionCreateInfoKHR pCreateInfo, IntPtr pAllocator, out VkVideoSessionKHR pVideoSession)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_VIDEO_STD_VERSION_NOT_SUPPORTED_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateVideoSessionKHR(VkDevice device, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, VkVideoSessionKHR* pVideoSession)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_VIDEO_STD_VERSION_NOT_SUPPORTED_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateVideoSessionKHR(VkDevice device, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, out VkVideoSessionKHR pVideoSession)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_VIDEO_STD_VERSION_NOT_SUPPORTED_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateVideoSessionKHR(VkDevice device, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, VkVideoSessionKHR* pVideoSession)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_VIDEO_STD_VERSION_NOT_SUPPORTED_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateVideoSessionKHR(VkDevice device, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkVideoSessionKHR pVideoSession)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_VIDEO_STD_VERSION_NOT_SUPPORTED_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateVideoSessionKHR(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, VkVideoSessionKHR* pVideoSession)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_VIDEO_STD_VERSION_NOT_SUPPORTED_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateVideoSessionKHR(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, out VkVideoSessionKHR pVideoSession)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateVideoSessionParametersKHR(VkDevice device, VkVideoSessionParametersCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkVideoSessionParametersKHR* pVideoSessionParameters)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateVideoSessionParametersKHR(VkDevice device, VkVideoSessionParametersCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkVideoSessionParametersKHR pVideoSessionParameters)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateVideoSessionParametersKHR(VkDevice device, VkVideoSessionParametersCreateInfoKHR* pCreateInfo, ref VkAllocationCallbacks pAllocator, VkVideoSessionParametersKHR* pVideoSessionParameters)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateVideoSessionParametersKHR(VkDevice device, VkVideoSessionParametersCreateInfoKHR* pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkVideoSessionParametersKHR pVideoSessionParameters)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateVideoSessionParametersKHR(VkDevice device, VkVideoSessionParametersCreateInfoKHR* pCreateInfo, IntPtr pAllocator, VkVideoSessionParametersKHR* pVideoSessionParameters)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateVideoSessionParametersKHR(VkDevice device, VkVideoSessionParametersCreateInfoKHR* pCreateInfo, IntPtr pAllocator, out VkVideoSessionParametersKHR pVideoSessionParameters)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateVideoSessionParametersKHR(VkDevice device, ref VkVideoSessionParametersCreateInfoKHR pCreateInfo, VkAllocationCallbacks* pAllocator, VkVideoSessionParametersKHR* pVideoSessionParameters)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateVideoSessionParametersKHR(VkDevice device, ref VkVideoSessionParametersCreateInfoKHR pCreateInfo, VkAllocationCallbacks* pAllocator, out VkVideoSessionParametersKHR pVideoSessionParameters)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateVideoSessionParametersKHR(VkDevice device, ref VkVideoSessionParametersCreateInfoKHR pCreateInfo, ref VkAllocationCallbacks pAllocator, VkVideoSessionParametersKHR* pVideoSessionParameters)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateVideoSessionParametersKHR(VkDevice device, ref VkVideoSessionParametersCreateInfoKHR pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkVideoSessionParametersKHR pVideoSessionParameters)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateVideoSessionParametersKHR(VkDevice device, ref VkVideoSessionParametersCreateInfoKHR pCreateInfo, IntPtr pAllocator, VkVideoSessionParametersKHR* pVideoSessionParameters)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateVideoSessionParametersKHR(VkDevice device, ref VkVideoSessionParametersCreateInfoKHR pCreateInfo, IntPtr pAllocator, out VkVideoSessionParametersKHR pVideoSessionParameters)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateVideoSessionParametersKHR(VkDevice device, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, VkVideoSessionParametersKHR* pVideoSessionParameters)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateVideoSessionParametersKHR(VkDevice device, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, out VkVideoSessionParametersKHR pVideoSessionParameters)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateVideoSessionParametersKHR(VkDevice device, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, VkVideoSessionParametersKHR* pVideoSessionParameters)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateVideoSessionParametersKHR(VkDevice device, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkVideoSessionParametersKHR pVideoSessionParameters)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateVideoSessionParametersKHR(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, VkVideoSessionParametersKHR* pVideoSessionParameters)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateVideoSessionParametersKHR(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, out VkVideoSessionParametersKHR pVideoSessionParameters)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkDestroyVideoSessionKHR(VkDevice device, VkVideoSessionKHR videoSession, VkAllocationCallbacks* pAllocator)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkDestroyVideoSessionKHR(VkDevice device, VkVideoSessionKHR videoSession, ref VkAllocationCallbacks pAllocator)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkDestroyVideoSessionKHR(VkDevice device, VkVideoSessionKHR videoSession, IntPtr pAllocator)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkDestroyVideoSessionParametersKHR(VkDevice device, VkVideoSessionParametersKHR videoSessionParameters, VkAllocationCallbacks* pAllocator)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkDestroyVideoSessionParametersKHR(VkDevice device, VkVideoSessionParametersKHR videoSessionParameters, ref VkAllocationCallbacks pAllocator)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkDestroyVideoSessionParametersKHR(VkDevice device, VkVideoSessionParametersKHR videoSessionParameters, IntPtr pAllocator)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_VIDEO_PROFILE_OPERATION_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_FORMAT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PICTURE_LAYOUT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_CODEC_NOT_SUPPORTED_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceVideoCapabilitiesKHR(VkPhysicalDevice physicalDevice, VkVideoProfileInfoKHR* pVideoProfile, VkVideoCapabilitiesKHR* pCapabilities)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_VIDEO_PROFILE_OPERATION_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_FORMAT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PICTURE_LAYOUT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_CODEC_NOT_SUPPORTED_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceVideoCapabilitiesKHR(VkPhysicalDevice physicalDevice, VkVideoProfileInfoKHR* pVideoProfile, out VkVideoCapabilitiesKHR pCapabilities)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_VIDEO_PROFILE_OPERATION_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_FORMAT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PICTURE_LAYOUT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_CODEC_NOT_SUPPORTED_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceVideoCapabilitiesKHR(VkPhysicalDevice physicalDevice, ref VkVideoProfileInfoKHR pVideoProfile, VkVideoCapabilitiesKHR* pCapabilities)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_VIDEO_PROFILE_OPERATION_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_FORMAT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PICTURE_LAYOUT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_CODEC_NOT_SUPPORTED_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceVideoCapabilitiesKHR(VkPhysicalDevice physicalDevice, ref VkVideoProfileInfoKHR pVideoProfile, out VkVideoCapabilitiesKHR pCapabilities)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_VIDEO_PROFILE_OPERATION_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_FORMAT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PICTURE_LAYOUT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_CODEC_NOT_SUPPORTED_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceVideoCapabilitiesKHR(VkPhysicalDevice physicalDevice, IntPtr pVideoProfile, VkVideoCapabilitiesKHR* pCapabilities)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_VIDEO_PROFILE_OPERATION_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_FORMAT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PICTURE_LAYOUT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_CODEC_NOT_SUPPORTED_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceVideoCapabilitiesKHR(VkPhysicalDevice physicalDevice, IntPtr pVideoProfile, out VkVideoCapabilitiesKHR pCapabilities)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_IMAGE_USAGE_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_OPERATION_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_FORMAT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PICTURE_LAYOUT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_CODEC_NOT_SUPPORTED_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceVideoFormatPropertiesKHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceVideoFormatInfoKHR* pVideoFormatInfo, uint* pVideoFormatPropertyCount, VkVideoFormatPropertiesKHR* pVideoFormatProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_IMAGE_USAGE_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_OPERATION_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_FORMAT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PICTURE_LAYOUT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_CODEC_NOT_SUPPORTED_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceVideoFormatPropertiesKHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceVideoFormatInfoKHR* pVideoFormatInfo, uint* pVideoFormatPropertyCount, out VkVideoFormatPropertiesKHR pVideoFormatProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_IMAGE_USAGE_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_OPERATION_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_FORMAT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PICTURE_LAYOUT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_CODEC_NOT_SUPPORTED_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceVideoFormatPropertiesKHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceVideoFormatInfoKHR* pVideoFormatInfo, ref uint pVideoFormatPropertyCount, VkVideoFormatPropertiesKHR* pVideoFormatProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_IMAGE_USAGE_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_OPERATION_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_FORMAT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PICTURE_LAYOUT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_CODEC_NOT_SUPPORTED_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceVideoFormatPropertiesKHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceVideoFormatInfoKHR* pVideoFormatInfo, ref uint pVideoFormatPropertyCount, out VkVideoFormatPropertiesKHR pVideoFormatProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_IMAGE_USAGE_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_OPERATION_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_FORMAT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PICTURE_LAYOUT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_CODEC_NOT_SUPPORTED_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceVideoFormatPropertiesKHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceVideoFormatInfoKHR* pVideoFormatInfo, IntPtr pVideoFormatPropertyCount, VkVideoFormatPropertiesKHR* pVideoFormatProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_IMAGE_USAGE_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_OPERATION_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_FORMAT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PICTURE_LAYOUT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_CODEC_NOT_SUPPORTED_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceVideoFormatPropertiesKHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceVideoFormatInfoKHR* pVideoFormatInfo, IntPtr pVideoFormatPropertyCount, out VkVideoFormatPropertiesKHR pVideoFormatProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_IMAGE_USAGE_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_OPERATION_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_FORMAT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PICTURE_LAYOUT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_CODEC_NOT_SUPPORTED_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceVideoFormatPropertiesKHR(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceVideoFormatInfoKHR pVideoFormatInfo, uint* pVideoFormatPropertyCount, VkVideoFormatPropertiesKHR* pVideoFormatProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_IMAGE_USAGE_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_OPERATION_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_FORMAT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PICTURE_LAYOUT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_CODEC_NOT_SUPPORTED_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceVideoFormatPropertiesKHR(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceVideoFormatInfoKHR pVideoFormatInfo, uint* pVideoFormatPropertyCount, out VkVideoFormatPropertiesKHR pVideoFormatProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_IMAGE_USAGE_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_OPERATION_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_FORMAT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PICTURE_LAYOUT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_CODEC_NOT_SUPPORTED_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceVideoFormatPropertiesKHR(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceVideoFormatInfoKHR pVideoFormatInfo, ref uint pVideoFormatPropertyCount, VkVideoFormatPropertiesKHR* pVideoFormatProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_IMAGE_USAGE_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_OPERATION_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_FORMAT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PICTURE_LAYOUT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_CODEC_NOT_SUPPORTED_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceVideoFormatPropertiesKHR(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceVideoFormatInfoKHR pVideoFormatInfo, ref uint pVideoFormatPropertyCount, out VkVideoFormatPropertiesKHR pVideoFormatProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_IMAGE_USAGE_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_OPERATION_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_FORMAT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PICTURE_LAYOUT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_CODEC_NOT_SUPPORTED_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceVideoFormatPropertiesKHR(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceVideoFormatInfoKHR pVideoFormatInfo, IntPtr pVideoFormatPropertyCount, VkVideoFormatPropertiesKHR* pVideoFormatProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_IMAGE_USAGE_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_OPERATION_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_FORMAT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PICTURE_LAYOUT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_CODEC_NOT_SUPPORTED_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceVideoFormatPropertiesKHR(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceVideoFormatInfoKHR pVideoFormatInfo, IntPtr pVideoFormatPropertyCount, out VkVideoFormatPropertiesKHR pVideoFormatProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_IMAGE_USAGE_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_OPERATION_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_FORMAT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PICTURE_LAYOUT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_CODEC_NOT_SUPPORTED_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceVideoFormatPropertiesKHR(VkPhysicalDevice physicalDevice, IntPtr pVideoFormatInfo, uint* pVideoFormatPropertyCount, VkVideoFormatPropertiesKHR* pVideoFormatProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_IMAGE_USAGE_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_OPERATION_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_FORMAT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PICTURE_LAYOUT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_CODEC_NOT_SUPPORTED_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceVideoFormatPropertiesKHR(VkPhysicalDevice physicalDevice, IntPtr pVideoFormatInfo, uint* pVideoFormatPropertyCount, out VkVideoFormatPropertiesKHR pVideoFormatProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_IMAGE_USAGE_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_OPERATION_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_FORMAT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PICTURE_LAYOUT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_CODEC_NOT_SUPPORTED_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceVideoFormatPropertiesKHR(VkPhysicalDevice physicalDevice, IntPtr pVideoFormatInfo, ref uint pVideoFormatPropertyCount, VkVideoFormatPropertiesKHR* pVideoFormatProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_IMAGE_USAGE_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_OPERATION_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_FORMAT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PICTURE_LAYOUT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_CODEC_NOT_SUPPORTED_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceVideoFormatPropertiesKHR(VkPhysicalDevice physicalDevice, IntPtr pVideoFormatInfo, ref uint pVideoFormatPropertyCount, out VkVideoFormatPropertiesKHR pVideoFormatProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_IMAGE_USAGE_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_OPERATION_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_FORMAT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PICTURE_LAYOUT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_CODEC_NOT_SUPPORTED_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceVideoFormatPropertiesKHR(VkPhysicalDevice physicalDevice, IntPtr pVideoFormatInfo, IntPtr pVideoFormatPropertyCount, VkVideoFormatPropertiesKHR* pVideoFormatProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_IMAGE_USAGE_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_OPERATION_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_FORMAT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PICTURE_LAYOUT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_CODEC_NOT_SUPPORTED_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceVideoFormatPropertiesKHR(VkPhysicalDevice physicalDevice, IntPtr pVideoFormatInfo, IntPtr pVideoFormatPropertyCount, out VkVideoFormatPropertiesKHR pVideoFormatProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetVideoSessionMemoryRequirementsKHR(VkDevice device, VkVideoSessionKHR videoSession, uint* pMemoryRequirementsCount, VkVideoSessionMemoryRequirementsKHR* pMemoryRequirements)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetVideoSessionMemoryRequirementsKHR(VkDevice device, VkVideoSessionKHR videoSession, uint* pMemoryRequirementsCount, out VkVideoSessionMemoryRequirementsKHR pMemoryRequirements)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetVideoSessionMemoryRequirementsKHR(VkDevice device, VkVideoSessionKHR videoSession, ref uint pMemoryRequirementsCount, VkVideoSessionMemoryRequirementsKHR* pMemoryRequirements)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetVideoSessionMemoryRequirementsKHR(VkDevice device, VkVideoSessionKHR videoSession, ref uint pMemoryRequirementsCount, out VkVideoSessionMemoryRequirementsKHR pMemoryRequirements)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetVideoSessionMemoryRequirementsKHR(VkDevice device, VkVideoSessionKHR videoSession, IntPtr pMemoryRequirementsCount, VkVideoSessionMemoryRequirementsKHR* pMemoryRequirements)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetVideoSessionMemoryRequirementsKHR(VkDevice device, VkVideoSessionKHR videoSession, IntPtr pMemoryRequirementsCount, out VkVideoSessionMemoryRequirementsKHR pMemoryRequirements)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkUpdateVideoSessionParametersKHR(VkDevice device, VkVideoSessionParametersKHR videoSessionParameters, VkVideoSessionParametersUpdateInfoKHR* pUpdateInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkUpdateVideoSessionParametersKHR(VkDevice device, VkVideoSessionParametersKHR videoSessionParameters, ref VkVideoSessionParametersUpdateInfoKHR pUpdateInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkUpdateVideoSessionParametersKHR(VkDevice device, VkVideoSessionParametersKHR videoSessionParameters, IntPtr pUpdateInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanKHRVideoQueue(VkDevice device)
        {
            vkBindVideoSessionMemoryKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkBindVideoSessionMemoryKHR", true);
            vkCmdBeginVideoCodingKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdBeginVideoCodingKHR", true);
            vkCmdControlVideoCodingKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdControlVideoCodingKHR", true);
            vkCmdEndVideoCodingKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdEndVideoCodingKHR", true);
            vkCreateVideoSessionKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCreateVideoSessionKHR", true);
            vkCreateVideoSessionParametersKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCreateVideoSessionParametersKHR", true);
            vkDestroyVideoSessionKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkDestroyVideoSessionKHR", true);
            vkDestroyVideoSessionParametersKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkDestroyVideoSessionParametersKHR", true);
            vkGetPhysicalDeviceVideoCapabilitiesKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetPhysicalDeviceVideoCapabilitiesKHR", true);
            vkGetPhysicalDeviceVideoFormatPropertiesKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetPhysicalDeviceVideoFormatPropertiesKHR", true);
            vkGetVideoSessionMemoryRequirementsKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetVideoSessionMemoryRequirementsKHR", true);
            vkUpdateVideoSessionParametersKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkUpdateVideoSessionParametersKHR", true);
        }
    }

    public unsafe sealed class VulkanKHRVideoDecodeQueue : IVulkanDeviceExtGeneric<VulkanKHRVideoDecodeQueue>
    {
        public static string Name => "VK_KHR_video_decode_queue";
        string IVulkanExt.GetName() => Name;

        public static VulkanKHRVideoDecodeQueue Create(VkDevice device)
        {
            return new VulkanKHRVideoDecodeQueue(device);
        }

        private IntPtr vkCmdDecodeVideoKHR_ptr;

        [Generator.CalliRewrite]
        public unsafe void vkCmdDecodeVideoKHR(VkCommandBuffer commandBuffer, VkVideoDecodeInfoKHR* pDecodeInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdDecodeVideoKHR(VkCommandBuffer commandBuffer, ref VkVideoDecodeInfoKHR pDecodeInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdDecodeVideoKHR(VkCommandBuffer commandBuffer, IntPtr pDecodeInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanKHRVideoDecodeQueue(VkDevice device)
        {
            vkCmdDecodeVideoKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdDecodeVideoKHR", true);
        }
    }

    public unsafe sealed class VulkanEXTTransformFeedback : IVulkanDeviceExtGeneric<VulkanEXTTransformFeedback>
    {
        public static string Name => "VK_EXT_transform_feedback";
        string IVulkanExt.GetName() => Name;

        public static VulkanEXTTransformFeedback Create(VkDevice device)
        {
            return new VulkanEXTTransformFeedback(device);
        }

        private IntPtr vkCmdBeginQueryIndexedEXT_ptr;
        private IntPtr vkCmdBeginTransformFeedbackEXT_ptr;
        private IntPtr vkCmdBindTransformFeedbackBuffersEXT_ptr;
        private IntPtr vkCmdDrawIndirectByteCountEXT_ptr;
        private IntPtr vkCmdEndQueryIndexedEXT_ptr;
        private IntPtr vkCmdEndTransformFeedbackEXT_ptr;

        [Generator.CalliRewrite]
        public unsafe void vkCmdBeginQueryIndexedEXT(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, VkQueryControlFlags flags, uint index)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBeginTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, VkBuffer* pCounterBuffers, ulong* pCounterBufferOffsets)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBeginTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, VkBuffer* pCounterBuffers, ref ulong pCounterBufferOffsets)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBeginTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, VkBuffer* pCounterBuffers, IntPtr pCounterBufferOffsets)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBeginTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, ref VkBuffer pCounterBuffers, ulong* pCounterBufferOffsets)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBeginTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, ref VkBuffer pCounterBuffers, ref ulong pCounterBufferOffsets)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBeginTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, ref VkBuffer pCounterBuffers, IntPtr pCounterBufferOffsets)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBeginTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, IntPtr pCounterBuffers, ulong* pCounterBufferOffsets)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBeginTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, IntPtr pCounterBuffers, ref ulong pCounterBufferOffsets)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBeginTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, IntPtr pCounterBuffers, IntPtr pCounterBufferOffsets)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* pBuffers, ulong* pOffsets, ulong* pSizes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* pBuffers, ulong* pOffsets, ref ulong pSizes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* pBuffers, ulong* pOffsets, IntPtr pSizes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* pBuffers, ref ulong pOffsets, ulong* pSizes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* pBuffers, ref ulong pOffsets, ref ulong pSizes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* pBuffers, ref ulong pOffsets, IntPtr pSizes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* pBuffers, IntPtr pOffsets, ulong* pSizes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* pBuffers, IntPtr pOffsets, ref ulong pSizes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* pBuffers, IntPtr pOffsets, IntPtr pSizes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer pBuffers, ulong* pOffsets, ulong* pSizes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer pBuffers, ulong* pOffsets, ref ulong pSizes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer pBuffers, ulong* pOffsets, IntPtr pSizes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer pBuffers, ref ulong pOffsets, ulong* pSizes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer pBuffers, ref ulong pOffsets, ref ulong pSizes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer pBuffers, ref ulong pOffsets, IntPtr pSizes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer pBuffers, IntPtr pOffsets, ulong* pSizes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer pBuffers, IntPtr pOffsets, ref ulong pSizes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer pBuffers, IntPtr pOffsets, IntPtr pSizes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, IntPtr pBuffers, ulong* pOffsets, ulong* pSizes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, IntPtr pBuffers, ulong* pOffsets, ref ulong pSizes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, IntPtr pBuffers, ulong* pOffsets, IntPtr pSizes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, IntPtr pBuffers, ref ulong pOffsets, ulong* pSizes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, IntPtr pBuffers, ref ulong pOffsets, ref ulong pSizes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, IntPtr pBuffers, ref ulong pOffsets, IntPtr pSizes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, IntPtr pBuffers, IntPtr pOffsets, ulong* pSizes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, IntPtr pBuffers, IntPtr pOffsets, ref ulong pSizes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, IntPtr pBuffers, IntPtr pOffsets, IntPtr pSizes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdDrawIndirectByteCountEXT(VkCommandBuffer commandBuffer, uint instanceCount, uint firstInstance, VkBuffer counterBuffer, ulong counterBufferOffset, uint counterOffset, uint vertexStride)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdEndQueryIndexedEXT(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, uint index)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdEndTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, VkBuffer* pCounterBuffers, ulong* pCounterBufferOffsets)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdEndTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, VkBuffer* pCounterBuffers, ref ulong pCounterBufferOffsets)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdEndTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, VkBuffer* pCounterBuffers, IntPtr pCounterBufferOffsets)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdEndTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, ref VkBuffer pCounterBuffers, ulong* pCounterBufferOffsets)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdEndTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, ref VkBuffer pCounterBuffers, ref ulong pCounterBufferOffsets)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdEndTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, ref VkBuffer pCounterBuffers, IntPtr pCounterBufferOffsets)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdEndTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, IntPtr pCounterBuffers, ulong* pCounterBufferOffsets)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdEndTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, IntPtr pCounterBuffers, ref ulong pCounterBufferOffsets)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdEndTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, IntPtr pCounterBuffers, IntPtr pCounterBufferOffsets)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanEXTTransformFeedback(VkDevice device)
        {
            vkCmdBeginQueryIndexedEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdBeginQueryIndexedEXT", true);
            vkCmdBeginTransformFeedbackEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdBeginTransformFeedbackEXT", true);
            vkCmdBindTransformFeedbackBuffersEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdBindTransformFeedbackBuffersEXT", true);
            vkCmdDrawIndirectByteCountEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdDrawIndirectByteCountEXT", true);
            vkCmdEndQueryIndexedEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdEndQueryIndexedEXT", true);
            vkCmdEndTransformFeedbackEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdEndTransformFeedbackEXT", true);
        }
    }

    public unsafe sealed class VulkanNVXBinaryImport : IVulkanDeviceExtGeneric<VulkanNVXBinaryImport>
    {
        public static string Name => "VK_NVX_binary_import";
        string IVulkanExt.GetName() => Name;

        public static VulkanNVXBinaryImport Create(VkDevice device)
        {
            return new VulkanNVXBinaryImport(device);
        }

        private IntPtr vkCmdCuLaunchKernelNVX_ptr;
        private IntPtr vkCreateCuFunctionNVX_ptr;
        private IntPtr vkCreateCuModuleNVX_ptr;
        private IntPtr vkDestroyCuFunctionNVX_ptr;
        private IntPtr vkDestroyCuModuleNVX_ptr;

        [Generator.CalliRewrite]
        public unsafe void vkCmdCuLaunchKernelNVX(VkCommandBuffer commandBuffer, VkCuLaunchInfoNVX* pLaunchInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdCuLaunchKernelNVX(VkCommandBuffer commandBuffer, ref VkCuLaunchInfoNVX pLaunchInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdCuLaunchKernelNVX(VkCommandBuffer commandBuffer, IntPtr pLaunchInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateCuFunctionNVX(VkDevice device, VkCuFunctionCreateInfoNVX* pCreateInfo, VkAllocationCallbacks* pAllocator, VkCuFunctionNVX* pFunction)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateCuFunctionNVX(VkDevice device, VkCuFunctionCreateInfoNVX* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkCuFunctionNVX pFunction)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateCuFunctionNVX(VkDevice device, VkCuFunctionCreateInfoNVX* pCreateInfo, ref VkAllocationCallbacks pAllocator, VkCuFunctionNVX* pFunction)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateCuFunctionNVX(VkDevice device, VkCuFunctionCreateInfoNVX* pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkCuFunctionNVX pFunction)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateCuFunctionNVX(VkDevice device, VkCuFunctionCreateInfoNVX* pCreateInfo, IntPtr pAllocator, VkCuFunctionNVX* pFunction)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateCuFunctionNVX(VkDevice device, VkCuFunctionCreateInfoNVX* pCreateInfo, IntPtr pAllocator, out VkCuFunctionNVX pFunction)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateCuFunctionNVX(VkDevice device, ref VkCuFunctionCreateInfoNVX pCreateInfo, VkAllocationCallbacks* pAllocator, VkCuFunctionNVX* pFunction)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateCuFunctionNVX(VkDevice device, ref VkCuFunctionCreateInfoNVX pCreateInfo, VkAllocationCallbacks* pAllocator, out VkCuFunctionNVX pFunction)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateCuFunctionNVX(VkDevice device, ref VkCuFunctionCreateInfoNVX pCreateInfo, ref VkAllocationCallbacks pAllocator, VkCuFunctionNVX* pFunction)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateCuFunctionNVX(VkDevice device, ref VkCuFunctionCreateInfoNVX pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkCuFunctionNVX pFunction)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateCuFunctionNVX(VkDevice device, ref VkCuFunctionCreateInfoNVX pCreateInfo, IntPtr pAllocator, VkCuFunctionNVX* pFunction)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateCuFunctionNVX(VkDevice device, ref VkCuFunctionCreateInfoNVX pCreateInfo, IntPtr pAllocator, out VkCuFunctionNVX pFunction)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateCuFunctionNVX(VkDevice device, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, VkCuFunctionNVX* pFunction)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateCuFunctionNVX(VkDevice device, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, out VkCuFunctionNVX pFunction)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateCuFunctionNVX(VkDevice device, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, VkCuFunctionNVX* pFunction)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateCuFunctionNVX(VkDevice device, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkCuFunctionNVX pFunction)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateCuFunctionNVX(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, VkCuFunctionNVX* pFunction)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateCuFunctionNVX(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, out VkCuFunctionNVX pFunction)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateCuModuleNVX(VkDevice device, VkCuModuleCreateInfoNVX* pCreateInfo, VkAllocationCallbacks* pAllocator, VkCuModuleNVX* pModule)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateCuModuleNVX(VkDevice device, VkCuModuleCreateInfoNVX* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkCuModuleNVX pModule)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateCuModuleNVX(VkDevice device, VkCuModuleCreateInfoNVX* pCreateInfo, ref VkAllocationCallbacks pAllocator, VkCuModuleNVX* pModule)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateCuModuleNVX(VkDevice device, VkCuModuleCreateInfoNVX* pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkCuModuleNVX pModule)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateCuModuleNVX(VkDevice device, VkCuModuleCreateInfoNVX* pCreateInfo, IntPtr pAllocator, VkCuModuleNVX* pModule)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateCuModuleNVX(VkDevice device, VkCuModuleCreateInfoNVX* pCreateInfo, IntPtr pAllocator, out VkCuModuleNVX pModule)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateCuModuleNVX(VkDevice device, ref VkCuModuleCreateInfoNVX pCreateInfo, VkAllocationCallbacks* pAllocator, VkCuModuleNVX* pModule)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateCuModuleNVX(VkDevice device, ref VkCuModuleCreateInfoNVX pCreateInfo, VkAllocationCallbacks* pAllocator, out VkCuModuleNVX pModule)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateCuModuleNVX(VkDevice device, ref VkCuModuleCreateInfoNVX pCreateInfo, ref VkAllocationCallbacks pAllocator, VkCuModuleNVX* pModule)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateCuModuleNVX(VkDevice device, ref VkCuModuleCreateInfoNVX pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkCuModuleNVX pModule)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateCuModuleNVX(VkDevice device, ref VkCuModuleCreateInfoNVX pCreateInfo, IntPtr pAllocator, VkCuModuleNVX* pModule)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateCuModuleNVX(VkDevice device, ref VkCuModuleCreateInfoNVX pCreateInfo, IntPtr pAllocator, out VkCuModuleNVX pModule)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateCuModuleNVX(VkDevice device, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, VkCuModuleNVX* pModule)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateCuModuleNVX(VkDevice device, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, out VkCuModuleNVX pModule)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateCuModuleNVX(VkDevice device, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, VkCuModuleNVX* pModule)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateCuModuleNVX(VkDevice device, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkCuModuleNVX pModule)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateCuModuleNVX(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, VkCuModuleNVX* pModule)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateCuModuleNVX(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, out VkCuModuleNVX pModule)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkDestroyCuFunctionNVX(VkDevice device, VkCuFunctionNVX function, VkAllocationCallbacks* pAllocator)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkDestroyCuFunctionNVX(VkDevice device, VkCuFunctionNVX function, ref VkAllocationCallbacks pAllocator)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkDestroyCuFunctionNVX(VkDevice device, VkCuFunctionNVX function, IntPtr pAllocator)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkDestroyCuModuleNVX(VkDevice device, VkCuModuleNVX module, VkAllocationCallbacks* pAllocator)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkDestroyCuModuleNVX(VkDevice device, VkCuModuleNVX module, ref VkAllocationCallbacks pAllocator)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkDestroyCuModuleNVX(VkDevice device, VkCuModuleNVX module, IntPtr pAllocator)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanNVXBinaryImport(VkDevice device)
        {
            vkCmdCuLaunchKernelNVX_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdCuLaunchKernelNVX", true);
            vkCreateCuFunctionNVX_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCreateCuFunctionNVX", true);
            vkCreateCuModuleNVX_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCreateCuModuleNVX", true);
            vkDestroyCuFunctionNVX_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkDestroyCuFunctionNVX", true);
            vkDestroyCuModuleNVX_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkDestroyCuModuleNVX", true);
        }
    }

    public unsafe sealed class VulkanNVXImageViewHandle : IVulkanDeviceExtGeneric<VulkanNVXImageViewHandle>
    {
        public static string Name => "VK_NVX_image_view_handle";
        string IVulkanExt.GetName() => Name;

        public static VulkanNVXImageViewHandle Create(VkDevice device)
        {
            return new VulkanNVXImageViewHandle(device);
        }

        private IntPtr vkGetImageViewAddressNVX_ptr;
        private IntPtr vkGetImageViewHandleNVX_ptr;

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_UNKNOWN</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetImageViewAddressNVX(VkDevice device, VkImageView imageView, VkImageViewAddressPropertiesNVX* pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_UNKNOWN</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetImageViewAddressNVX(VkDevice device, VkImageView imageView, out VkImageViewAddressPropertiesNVX pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe uint vkGetImageViewHandleNVX(VkDevice device, VkImageViewHandleInfoNVX* pInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe uint vkGetImageViewHandleNVX(VkDevice device, out VkImageViewHandleInfoNVX pInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanNVXImageViewHandle(VkDevice device)
        {
            vkGetImageViewAddressNVX_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetImageViewAddressNVX", true);
            vkGetImageViewHandleNVX_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetImageViewHandleNVX", true);
        }
    }

    public unsafe sealed class VulkanAMDDrawIndirectCount : IVulkanDeviceExtGeneric<VulkanAMDDrawIndirectCount>
    {
        public static string Name => "VK_AMD_draw_indirect_count";
        string IVulkanExt.GetName() => Name;

        public static VulkanAMDDrawIndirectCount Create(VkDevice device)
        {
            return new VulkanAMDDrawIndirectCount(device);
        }



        public VulkanAMDDrawIndirectCount(VkDevice device)
        {
        }
    }

    public unsafe sealed class VulkanAMDShaderInfo : IVulkanDeviceExtGeneric<VulkanAMDShaderInfo>
    {
        public static string Name => "VK_AMD_shader_info";
        string IVulkanExt.GetName() => Name;

        public static VulkanAMDShaderInfo Create(VkDevice device)
        {
            return new VulkanAMDShaderInfo(device);
        }

        private IntPtr vkGetShaderInfoAMD_ptr;

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_FEATURE_NOT_PRESENT, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetShaderInfoAMD(VkDevice device, VkPipeline pipeline, VkShaderStageFlags shaderStage, VkShaderInfoTypeAMD infoType, UIntPtr* pInfoSize, void* pInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_FEATURE_NOT_PRESENT, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetShaderInfoAMD(VkDevice device, VkPipeline pipeline, VkShaderStageFlags shaderStage, VkShaderInfoTypeAMD infoType, ref UIntPtr pInfoSize, void* pInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_FEATURE_NOT_PRESENT, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetShaderInfoAMD(VkDevice device, VkPipeline pipeline, VkShaderStageFlags shaderStage, VkShaderInfoTypeAMD infoType, IntPtr pInfoSize, void* pInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanAMDShaderInfo(VkDevice device)
        {
            vkGetShaderInfoAMD_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetShaderInfoAMD", true);
        }
    }

    public unsafe sealed class VulkanKHRDynamicRendering : IVulkanDeviceExtGeneric<VulkanKHRDynamicRendering>
    {
        public static string Name => "VK_KHR_dynamic_rendering";
        string IVulkanExt.GetName() => Name;

        public static VulkanKHRDynamicRendering Create(VkDevice device)
        {
            return new VulkanKHRDynamicRendering(device);
        }



        public VulkanKHRDynamicRendering(VkDevice device)
        {
        }
    }

    public unsafe sealed class VulkanGgpStreamDescriptorSurface : IVulkanInstanceExtGeneric<VulkanGgpStreamDescriptorSurface>
    {
        public static string Name => "VK_GGP_stream_descriptor_surface";
        string IVulkanExt.GetName() => Name;

        public static VulkanGgpStreamDescriptorSurface Create(VkInstance instance)
        {
            return new VulkanGgpStreamDescriptorSurface(instance);
        }

        private IntPtr vkCreateStreamDescriptorSurfaceGGP_ptr;

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateStreamDescriptorSurfaceGGP(VkInstance instance, VkStreamDescriptorSurfaceCreateInfoGGP* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateStreamDescriptorSurfaceGGP(VkInstance instance, VkStreamDescriptorSurfaceCreateInfoGGP* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateStreamDescriptorSurfaceGGP(VkInstance instance, VkStreamDescriptorSurfaceCreateInfoGGP* pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateStreamDescriptorSurfaceGGP(VkInstance instance, VkStreamDescriptorSurfaceCreateInfoGGP* pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateStreamDescriptorSurfaceGGP(VkInstance instance, VkStreamDescriptorSurfaceCreateInfoGGP* pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateStreamDescriptorSurfaceGGP(VkInstance instance, VkStreamDescriptorSurfaceCreateInfoGGP* pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateStreamDescriptorSurfaceGGP(VkInstance instance, ref VkStreamDescriptorSurfaceCreateInfoGGP pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateStreamDescriptorSurfaceGGP(VkInstance instance, ref VkStreamDescriptorSurfaceCreateInfoGGP pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateStreamDescriptorSurfaceGGP(VkInstance instance, ref VkStreamDescriptorSurfaceCreateInfoGGP pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateStreamDescriptorSurfaceGGP(VkInstance instance, ref VkStreamDescriptorSurfaceCreateInfoGGP pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateStreamDescriptorSurfaceGGP(VkInstance instance, ref VkStreamDescriptorSurfaceCreateInfoGGP pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateStreamDescriptorSurfaceGGP(VkInstance instance, ref VkStreamDescriptorSurfaceCreateInfoGGP pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateStreamDescriptorSurfaceGGP(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateStreamDescriptorSurfaceGGP(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateStreamDescriptorSurfaceGGP(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateStreamDescriptorSurfaceGGP(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateStreamDescriptorSurfaceGGP(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateStreamDescriptorSurfaceGGP(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanGgpStreamDescriptorSurface(VkInstance instance)
        {
            vkCreateStreamDescriptorSurfaceGGP_ptr = VulkanNative.LoadInstanceProcAddr(instance, "vkCreateStreamDescriptorSurfaceGGP", true);
        }
    }

    public unsafe sealed class VulkanNVExternalMemoryCapabilities : IVulkanInstanceExtGeneric<VulkanNVExternalMemoryCapabilities>
    {
        public static string Name => "VK_NV_external_memory_capabilities";
        string IVulkanExt.GetName() => Name;

        public static VulkanNVExternalMemoryCapabilities Create(VkInstance instance)
        {
            return new VulkanNVExternalMemoryCapabilities(instance);
        }

        private IntPtr vkGetPhysicalDeviceExternalImageFormatPropertiesNV_ptr;

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_FORMAT_NOT_SUPPORTED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceExternalImageFormatPropertiesNV(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlags usage, VkImageCreateFlags flags, VkExternalMemoryHandleTypeFlagsNV externalHandleType, VkExternalImageFormatPropertiesNV* pExternalImageFormatProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_FORMAT_NOT_SUPPORTED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceExternalImageFormatPropertiesNV(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlags usage, VkImageCreateFlags flags, VkExternalMemoryHandleTypeFlagsNV externalHandleType, out VkExternalImageFormatPropertiesNV pExternalImageFormatProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanNVExternalMemoryCapabilities(VkInstance instance)
        {
            vkGetPhysicalDeviceExternalImageFormatPropertiesNV_ptr = VulkanNative.LoadInstanceProcAddr(instance, "vkGetPhysicalDeviceExternalImageFormatPropertiesNV", true);
        }
    }

    public unsafe sealed class VulkanNVExternalMemoryWin32 : IVulkanDeviceExtGeneric<VulkanNVExternalMemoryWin32>
    {
        public static string Name => "VK_NV_external_memory_win32";
        string IVulkanExt.GetName() => Name;

        public static VulkanNVExternalMemoryWin32 Create(VkDevice device)
        {
            return new VulkanNVExternalMemoryWin32(device);
        }

        private IntPtr vkGetMemoryWin32HandleNV_ptr;

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetMemoryWin32HandleNV(VkDevice device, VkDeviceMemory memory, VkExternalMemoryHandleTypeFlagsNV handleType, Win32.HANDLE* pHandle)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetMemoryWin32HandleNV(VkDevice device, VkDeviceMemory memory, VkExternalMemoryHandleTypeFlagsNV handleType, out Win32.HANDLE pHandle)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanNVExternalMemoryWin32(VkDevice device)
        {
            vkGetMemoryWin32HandleNV_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetMemoryWin32HandleNV", true);
        }
    }

    public unsafe sealed class VulkanKHRGetPhysicalDeviceProperties2 : IVulkanInstanceExtGeneric<VulkanKHRGetPhysicalDeviceProperties2>
    {
        public static string Name => "VK_KHR_get_physical_device_properties2";
        string IVulkanExt.GetName() => Name;

        public static VulkanKHRGetPhysicalDeviceProperties2 Create(VkInstance instance)
        {
            return new VulkanKHRGetPhysicalDeviceProperties2(instance);
        }



        public VulkanKHRGetPhysicalDeviceProperties2(VkInstance instance)
        {
        }
    }

    public unsafe sealed class VulkanKHRDeviceGroup : IVulkanDeviceExtGeneric<VulkanKHRDeviceGroup>
    {
        public static string Name => "VK_KHR_device_group";
        string IVulkanExt.GetName() => Name;

        public static VulkanKHRDeviceGroup Create(VkDevice device)
        {
            return new VulkanKHRDeviceGroup(device);
        }

        private IntPtr vkAcquireNextImage2KHR_ptr;
        private IntPtr vkGetDeviceGroupPresentCapabilitiesKHR_ptr;
        private IntPtr vkGetDeviceGroupSurfacePresentModesKHR_ptr;
        private IntPtr vkGetPhysicalDevicePresentRectanglesKHR_ptr;

        ///<remarks>Success codes:VK_SUCCESS, VK_TIMEOUT, VK_NOT_READY, VK_SUBOPTIMAL_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_OUT_OF_DATE_KHR, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_FULL_SCREEN_EXCLUSIVE_MODE_LOST_EXT</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkAcquireNextImage2KHR(VkDevice device, VkAcquireNextImageInfoKHR* pAcquireInfo, uint* pImageIndex)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_TIMEOUT, VK_NOT_READY, VK_SUBOPTIMAL_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_OUT_OF_DATE_KHR, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_FULL_SCREEN_EXCLUSIVE_MODE_LOST_EXT</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkAcquireNextImage2KHR(VkDevice device, VkAcquireNextImageInfoKHR* pAcquireInfo, ref uint pImageIndex)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_TIMEOUT, VK_NOT_READY, VK_SUBOPTIMAL_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_OUT_OF_DATE_KHR, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_FULL_SCREEN_EXCLUSIVE_MODE_LOST_EXT</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkAcquireNextImage2KHR(VkDevice device, VkAcquireNextImageInfoKHR* pAcquireInfo, IntPtr pImageIndex)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_TIMEOUT, VK_NOT_READY, VK_SUBOPTIMAL_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_OUT_OF_DATE_KHR, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_FULL_SCREEN_EXCLUSIVE_MODE_LOST_EXT</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkAcquireNextImage2KHR(VkDevice device, ref VkAcquireNextImageInfoKHR pAcquireInfo, uint* pImageIndex)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_TIMEOUT, VK_NOT_READY, VK_SUBOPTIMAL_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_OUT_OF_DATE_KHR, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_FULL_SCREEN_EXCLUSIVE_MODE_LOST_EXT</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkAcquireNextImage2KHR(VkDevice device, ref VkAcquireNextImageInfoKHR pAcquireInfo, ref uint pImageIndex)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_TIMEOUT, VK_NOT_READY, VK_SUBOPTIMAL_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_OUT_OF_DATE_KHR, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_FULL_SCREEN_EXCLUSIVE_MODE_LOST_EXT</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkAcquireNextImage2KHR(VkDevice device, ref VkAcquireNextImageInfoKHR pAcquireInfo, IntPtr pImageIndex)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_TIMEOUT, VK_NOT_READY, VK_SUBOPTIMAL_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_OUT_OF_DATE_KHR, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_FULL_SCREEN_EXCLUSIVE_MODE_LOST_EXT</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkAcquireNextImage2KHR(VkDevice device, IntPtr pAcquireInfo, uint* pImageIndex)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_TIMEOUT, VK_NOT_READY, VK_SUBOPTIMAL_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_OUT_OF_DATE_KHR, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_FULL_SCREEN_EXCLUSIVE_MODE_LOST_EXT</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkAcquireNextImage2KHR(VkDevice device, IntPtr pAcquireInfo, ref uint pImageIndex)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_TIMEOUT, VK_NOT_READY, VK_SUBOPTIMAL_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_OUT_OF_DATE_KHR, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_FULL_SCREEN_EXCLUSIVE_MODE_LOST_EXT</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkAcquireNextImage2KHR(VkDevice device, IntPtr pAcquireInfo, IntPtr pImageIndex)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetDeviceGroupPresentCapabilitiesKHR(VkDevice device, VkDeviceGroupPresentCapabilitiesKHR* pDeviceGroupPresentCapabilities)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetDeviceGroupPresentCapabilitiesKHR(VkDevice device, out VkDeviceGroupPresentCapabilitiesKHR pDeviceGroupPresentCapabilities)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetDeviceGroupSurfacePresentModesKHR(VkDevice device, VkSurfaceKHR surface, VkDeviceGroupPresentModeFlagsKHR* pModes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetDeviceGroupSurfacePresentModesKHR(VkDevice device, VkSurfaceKHR surface, out VkDeviceGroupPresentModeFlagsKHR pModes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDevicePresentRectanglesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pRectCount, VkRect2D* pRects)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDevicePresentRectanglesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pRectCount, out VkRect2D pRects)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDevicePresentRectanglesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, ref uint pRectCount, VkRect2D* pRects)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDevicePresentRectanglesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, ref uint pRectCount, out VkRect2D pRects)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDevicePresentRectanglesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, IntPtr pRectCount, VkRect2D* pRects)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDevicePresentRectanglesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, IntPtr pRectCount, out VkRect2D pRects)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanKHRDeviceGroup(VkDevice device)
        {
            vkAcquireNextImage2KHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkAcquireNextImage2KHR", true);
            vkGetDeviceGroupPresentCapabilitiesKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetDeviceGroupPresentCapabilitiesKHR", true);
            vkGetDeviceGroupSurfacePresentModesKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetDeviceGroupSurfacePresentModesKHR", true);
            vkGetPhysicalDevicePresentRectanglesKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetPhysicalDevicePresentRectanglesKHR", true);
        }
    }

    public unsafe sealed class VulkanNnViSurface : IVulkanInstanceExtGeneric<VulkanNnViSurface>
    {
        public static string Name => "VK_NN_vi_surface";
        string IVulkanExt.GetName() => Name;

        public static VulkanNnViSurface Create(VkInstance instance)
        {
            return new VulkanNnViSurface(instance);
        }

        private IntPtr vkCreateViSurfaceNN_ptr;

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateViSurfaceNN(VkInstance instance, VkViSurfaceCreateInfoNN* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateViSurfaceNN(VkInstance instance, VkViSurfaceCreateInfoNN* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateViSurfaceNN(VkInstance instance, VkViSurfaceCreateInfoNN* pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateViSurfaceNN(VkInstance instance, VkViSurfaceCreateInfoNN* pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateViSurfaceNN(VkInstance instance, VkViSurfaceCreateInfoNN* pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateViSurfaceNN(VkInstance instance, VkViSurfaceCreateInfoNN* pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateViSurfaceNN(VkInstance instance, ref VkViSurfaceCreateInfoNN pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateViSurfaceNN(VkInstance instance, ref VkViSurfaceCreateInfoNN pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateViSurfaceNN(VkInstance instance, ref VkViSurfaceCreateInfoNN pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateViSurfaceNN(VkInstance instance, ref VkViSurfaceCreateInfoNN pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateViSurfaceNN(VkInstance instance, ref VkViSurfaceCreateInfoNN pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateViSurfaceNN(VkInstance instance, ref VkViSurfaceCreateInfoNN pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateViSurfaceNN(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateViSurfaceNN(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateViSurfaceNN(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateViSurfaceNN(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateViSurfaceNN(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateViSurfaceNN(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanNnViSurface(VkInstance instance)
        {
            vkCreateViSurfaceNN_ptr = VulkanNative.LoadInstanceProcAddr(instance, "vkCreateViSurfaceNN", true);
        }
    }

    public unsafe sealed class VulkanKHRMaintenance1 : IVulkanDeviceExtGeneric<VulkanKHRMaintenance1>
    {
        public static string Name => "VK_KHR_maintenance1";
        string IVulkanExt.GetName() => Name;

        public static VulkanKHRMaintenance1 Create(VkDevice device)
        {
            return new VulkanKHRMaintenance1(device);
        }



        public VulkanKHRMaintenance1(VkDevice device)
        {
        }
    }

    public unsafe sealed class VulkanKHRDeviceGroupCreation : IVulkanInstanceExtGeneric<VulkanKHRDeviceGroupCreation>
    {
        public static string Name => "VK_KHR_device_group_creation";
        string IVulkanExt.GetName() => Name;

        public static VulkanKHRDeviceGroupCreation Create(VkInstance instance)
        {
            return new VulkanKHRDeviceGroupCreation(instance);
        }



        public VulkanKHRDeviceGroupCreation(VkInstance instance)
        {
        }
    }

    public unsafe sealed class VulkanKHRExternalMemoryCapabilities : IVulkanInstanceExtGeneric<VulkanKHRExternalMemoryCapabilities>
    {
        public static string Name => "VK_KHR_external_memory_capabilities";
        string IVulkanExt.GetName() => Name;

        public static VulkanKHRExternalMemoryCapabilities Create(VkInstance instance)
        {
            return new VulkanKHRExternalMemoryCapabilities(instance);
        }



        public VulkanKHRExternalMemoryCapabilities(VkInstance instance)
        {
        }
    }

    public unsafe sealed class VulkanKHRExternalMemoryWin32 : IVulkanDeviceExtGeneric<VulkanKHRExternalMemoryWin32>
    {
        public static string Name => "VK_KHR_external_memory_win32";
        string IVulkanExt.GetName() => Name;

        public static VulkanKHRExternalMemoryWin32 Create(VkDevice device)
        {
            return new VulkanKHRExternalMemoryWin32(device);
        }

        private IntPtr vkGetMemoryWin32HandleKHR_ptr;
        private IntPtr vkGetMemoryWin32HandlePropertiesKHR_ptr;

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetMemoryWin32HandleKHR(VkDevice device, VkMemoryGetWin32HandleInfoKHR* pGetWin32HandleInfo, Win32.HANDLE* pHandle)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetMemoryWin32HandleKHR(VkDevice device, VkMemoryGetWin32HandleInfoKHR* pGetWin32HandleInfo, out Win32.HANDLE pHandle)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetMemoryWin32HandleKHR(VkDevice device, ref VkMemoryGetWin32HandleInfoKHR pGetWin32HandleInfo, Win32.HANDLE* pHandle)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetMemoryWin32HandleKHR(VkDevice device, ref VkMemoryGetWin32HandleInfoKHR pGetWin32HandleInfo, out Win32.HANDLE pHandle)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetMemoryWin32HandleKHR(VkDevice device, IntPtr pGetWin32HandleInfo, Win32.HANDLE* pHandle)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetMemoryWin32HandleKHR(VkDevice device, IntPtr pGetWin32HandleInfo, out Win32.HANDLE pHandle)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetMemoryWin32HandlePropertiesKHR(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, Win32.HANDLE handle, VkMemoryWin32HandlePropertiesKHR* pMemoryWin32HandleProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetMemoryWin32HandlePropertiesKHR(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, Win32.HANDLE handle, out VkMemoryWin32HandlePropertiesKHR pMemoryWin32HandleProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanKHRExternalMemoryWin32(VkDevice device)
        {
            vkGetMemoryWin32HandleKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetMemoryWin32HandleKHR", true);
            vkGetMemoryWin32HandlePropertiesKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetMemoryWin32HandlePropertiesKHR", true);
        }
    }

    public unsafe sealed class VulkanKHRExternalMemoryFd : IVulkanDeviceExtGeneric<VulkanKHRExternalMemoryFd>
    {
        public static string Name => "VK_KHR_external_memory_fd";
        string IVulkanExt.GetName() => Name;

        public static VulkanKHRExternalMemoryFd Create(VkDevice device)
        {
            return new VulkanKHRExternalMemoryFd(device);
        }

        private IntPtr vkGetMemoryFdKHR_ptr;
        private IntPtr vkGetMemoryFdPropertiesKHR_ptr;

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetMemoryFdKHR(VkDevice device, VkMemoryGetFdInfoKHR* pGetFdInfo, int* pFd)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetMemoryFdKHR(VkDevice device, VkMemoryGetFdInfoKHR* pGetFdInfo, out int pFd)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetMemoryFdKHR(VkDevice device, ref VkMemoryGetFdInfoKHR pGetFdInfo, int* pFd)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetMemoryFdKHR(VkDevice device, ref VkMemoryGetFdInfoKHR pGetFdInfo, out int pFd)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetMemoryFdKHR(VkDevice device, IntPtr pGetFdInfo, int* pFd)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetMemoryFdKHR(VkDevice device, IntPtr pGetFdInfo, out int pFd)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetMemoryFdPropertiesKHR(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, int fd, VkMemoryFdPropertiesKHR* pMemoryFdProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetMemoryFdPropertiesKHR(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, int fd, out VkMemoryFdPropertiesKHR pMemoryFdProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanKHRExternalMemoryFd(VkDevice device)
        {
            vkGetMemoryFdKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetMemoryFdKHR", true);
            vkGetMemoryFdPropertiesKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetMemoryFdPropertiesKHR", true);
        }
    }

    public unsafe sealed class VulkanKHRExternalSemaphoreCapabilities : IVulkanInstanceExtGeneric<VulkanKHRExternalSemaphoreCapabilities>
    {
        public static string Name => "VK_KHR_external_semaphore_capabilities";
        string IVulkanExt.GetName() => Name;

        public static VulkanKHRExternalSemaphoreCapabilities Create(VkInstance instance)
        {
            return new VulkanKHRExternalSemaphoreCapabilities(instance);
        }



        public VulkanKHRExternalSemaphoreCapabilities(VkInstance instance)
        {
        }
    }

    public unsafe sealed class VulkanKHRExternalSemaphoreWin32 : IVulkanDeviceExtGeneric<VulkanKHRExternalSemaphoreWin32>
    {
        public static string Name => "VK_KHR_external_semaphore_win32";
        string IVulkanExt.GetName() => Name;

        public static VulkanKHRExternalSemaphoreWin32 Create(VkDevice device)
        {
            return new VulkanKHRExternalSemaphoreWin32(device);
        }

        private IntPtr vkGetSemaphoreWin32HandleKHR_ptr;
        private IntPtr vkImportSemaphoreWin32HandleKHR_ptr;

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetSemaphoreWin32HandleKHR(VkDevice device, VkSemaphoreGetWin32HandleInfoKHR* pGetWin32HandleInfo, Win32.HANDLE* pHandle)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetSemaphoreWin32HandleKHR(VkDevice device, VkSemaphoreGetWin32HandleInfoKHR* pGetWin32HandleInfo, out Win32.HANDLE pHandle)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetSemaphoreWin32HandleKHR(VkDevice device, ref VkSemaphoreGetWin32HandleInfoKHR pGetWin32HandleInfo, Win32.HANDLE* pHandle)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetSemaphoreWin32HandleKHR(VkDevice device, ref VkSemaphoreGetWin32HandleInfoKHR pGetWin32HandleInfo, out Win32.HANDLE pHandle)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetSemaphoreWin32HandleKHR(VkDevice device, IntPtr pGetWin32HandleInfo, Win32.HANDLE* pHandle)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetSemaphoreWin32HandleKHR(VkDevice device, IntPtr pGetWin32HandleInfo, out Win32.HANDLE pHandle)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkImportSemaphoreWin32HandleKHR(VkDevice device, VkImportSemaphoreWin32HandleInfoKHR* pImportSemaphoreWin32HandleInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkImportSemaphoreWin32HandleKHR(VkDevice device, ref VkImportSemaphoreWin32HandleInfoKHR pImportSemaphoreWin32HandleInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkImportSemaphoreWin32HandleKHR(VkDevice device, IntPtr pImportSemaphoreWin32HandleInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanKHRExternalSemaphoreWin32(VkDevice device)
        {
            vkGetSemaphoreWin32HandleKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetSemaphoreWin32HandleKHR", true);
            vkImportSemaphoreWin32HandleKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkImportSemaphoreWin32HandleKHR", true);
        }
    }

    public unsafe sealed class VulkanKHRExternalSemaphoreFd : IVulkanDeviceExtGeneric<VulkanKHRExternalSemaphoreFd>
    {
        public static string Name => "VK_KHR_external_semaphore_fd";
        string IVulkanExt.GetName() => Name;

        public static VulkanKHRExternalSemaphoreFd Create(VkDevice device)
        {
            return new VulkanKHRExternalSemaphoreFd(device);
        }

        private IntPtr vkGetSemaphoreFdKHR_ptr;
        private IntPtr vkImportSemaphoreFdKHR_ptr;

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetSemaphoreFdKHR(VkDevice device, VkSemaphoreGetFdInfoKHR* pGetFdInfo, int* pFd)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetSemaphoreFdKHR(VkDevice device, VkSemaphoreGetFdInfoKHR* pGetFdInfo, out int pFd)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetSemaphoreFdKHR(VkDevice device, ref VkSemaphoreGetFdInfoKHR pGetFdInfo, int* pFd)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetSemaphoreFdKHR(VkDevice device, ref VkSemaphoreGetFdInfoKHR pGetFdInfo, out int pFd)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetSemaphoreFdKHR(VkDevice device, IntPtr pGetFdInfo, int* pFd)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetSemaphoreFdKHR(VkDevice device, IntPtr pGetFdInfo, out int pFd)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkImportSemaphoreFdKHR(VkDevice device, VkImportSemaphoreFdInfoKHR* pImportSemaphoreFdInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkImportSemaphoreFdKHR(VkDevice device, ref VkImportSemaphoreFdInfoKHR pImportSemaphoreFdInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkImportSemaphoreFdKHR(VkDevice device, IntPtr pImportSemaphoreFdInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanKHRExternalSemaphoreFd(VkDevice device)
        {
            vkGetSemaphoreFdKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetSemaphoreFdKHR", true);
            vkImportSemaphoreFdKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkImportSemaphoreFdKHR", true);
        }
    }

    public unsafe sealed class VulkanKHRPushDescriptor : IVulkanDeviceExtGeneric<VulkanKHRPushDescriptor>
    {
        public static string Name => "VK_KHR_push_descriptor";
        string IVulkanExt.GetName() => Name;

        public static VulkanKHRPushDescriptor Create(VkDevice device)
        {
            return new VulkanKHRPushDescriptor(device);
        }

        private IntPtr vkCmdPushDescriptorSetKHR_ptr;

        [Generator.CalliRewrite]
        public unsafe void vkCmdPushDescriptorSetKHR(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint set, uint descriptorWriteCount, VkWriteDescriptorSet* pDescriptorWrites)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdPushDescriptorSetKHR(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint set, uint descriptorWriteCount, ref VkWriteDescriptorSet pDescriptorWrites)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdPushDescriptorSetKHR(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint set, uint descriptorWriteCount, IntPtr pDescriptorWrites)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanKHRPushDescriptor(VkDevice device)
        {
            vkCmdPushDescriptorSetKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdPushDescriptorSetKHR", true);
        }
    }

    public unsafe sealed class VulkanEXTConditionalRendering : IVulkanDeviceExtGeneric<VulkanEXTConditionalRendering>
    {
        public static string Name => "VK_EXT_conditional_rendering";
        string IVulkanExt.GetName() => Name;

        public static VulkanEXTConditionalRendering Create(VkDevice device)
        {
            return new VulkanEXTConditionalRendering(device);
        }

        private IntPtr vkCmdBeginConditionalRenderingEXT_ptr;
        private IntPtr vkCmdEndConditionalRenderingEXT_ptr;

        [Generator.CalliRewrite]
        public unsafe void vkCmdBeginConditionalRenderingEXT(VkCommandBuffer commandBuffer, VkConditionalRenderingBeginInfoEXT* pConditionalRenderingBegin)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBeginConditionalRenderingEXT(VkCommandBuffer commandBuffer, ref VkConditionalRenderingBeginInfoEXT pConditionalRenderingBegin)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBeginConditionalRenderingEXT(VkCommandBuffer commandBuffer, IntPtr pConditionalRenderingBegin)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdEndConditionalRenderingEXT(VkCommandBuffer commandBuffer)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanEXTConditionalRendering(VkDevice device)
        {
            vkCmdBeginConditionalRenderingEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdBeginConditionalRenderingEXT", true);
            vkCmdEndConditionalRenderingEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdEndConditionalRenderingEXT", true);
        }
    }

    public unsafe sealed class VulkanKHRDescriptorUpdateTemplate : IVulkanDeviceExtGeneric<VulkanKHRDescriptorUpdateTemplate>
    {
        public static string Name => "VK_KHR_descriptor_update_template";
        string IVulkanExt.GetName() => Name;

        public static VulkanKHRDescriptorUpdateTemplate Create(VkDevice device)
        {
            return new VulkanKHRDescriptorUpdateTemplate(device);
        }

        private IntPtr vkCmdPushDescriptorSetWithTemplateKHR_ptr;

        [Generator.CalliRewrite]
        public unsafe void vkCmdPushDescriptorSetWithTemplateKHR(VkCommandBuffer commandBuffer, VkDescriptorUpdateTemplate descriptorUpdateTemplate, VkPipelineLayout layout, uint set, void* pData)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanKHRDescriptorUpdateTemplate(VkDevice device)
        {
            vkCmdPushDescriptorSetWithTemplateKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdPushDescriptorSetWithTemplateKHR", true);
        }
    }

    public unsafe sealed class VulkanNVClipSpaceWScaling : IVulkanDeviceExtGeneric<VulkanNVClipSpaceWScaling>
    {
        public static string Name => "VK_NV_clip_space_w_scaling";
        string IVulkanExt.GetName() => Name;

        public static VulkanNVClipSpaceWScaling Create(VkDevice device)
        {
            return new VulkanNVClipSpaceWScaling(device);
        }

        private IntPtr vkCmdSetViewportWScalingNV_ptr;

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetViewportWScalingNV(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkViewportWScalingNV* pViewportWScalings)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetViewportWScalingNV(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, ref VkViewportWScalingNV pViewportWScalings)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetViewportWScalingNV(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, IntPtr pViewportWScalings)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanNVClipSpaceWScaling(VkDevice device)
        {
            vkCmdSetViewportWScalingNV_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdSetViewportWScalingNV", true);
        }
    }

    public unsafe sealed class VulkanEXTDirectModeDisplay : IVulkanInstanceExtGeneric<VulkanEXTDirectModeDisplay>
    {
        public static string Name => "VK_EXT_direct_mode_display";
        string IVulkanExt.GetName() => Name;

        public static VulkanEXTDirectModeDisplay Create(VkInstance instance)
        {
            return new VulkanEXTDirectModeDisplay(instance);
        }

        private IntPtr vkReleaseDisplayEXT_ptr;

        ///<remarks>Success codes:VK_SUCCESS. Error codes:</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkReleaseDisplayEXT(VkPhysicalDevice physicalDevice, VkDisplayKHR display)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanEXTDirectModeDisplay(VkInstance instance)
        {
            vkReleaseDisplayEXT_ptr = VulkanNative.LoadInstanceProcAddr(instance, "vkReleaseDisplayEXT", true);
        }
    }

    public unsafe sealed class VulkanEXTAcquireXlibDisplay : IVulkanInstanceExtGeneric<VulkanEXTAcquireXlibDisplay>
    {
        public static string Name => "VK_EXT_acquire_xlib_display";
        string IVulkanExt.GetName() => Name;

        public static VulkanEXTAcquireXlibDisplay Create(VkInstance instance)
        {
            return new VulkanEXTAcquireXlibDisplay(instance);
        }

        private IntPtr vkAcquireXlibDisplayEXT_ptr;
        private IntPtr vkGetRandROutputDisplayEXT_ptr;

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkAcquireXlibDisplayEXT(VkPhysicalDevice physicalDevice, Xlib.Display* dpy, VkDisplayKHR display)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkAcquireXlibDisplayEXT(VkPhysicalDevice physicalDevice, ref Xlib.Display dpy, VkDisplayKHR display)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkAcquireXlibDisplayEXT(VkPhysicalDevice physicalDevice, IntPtr dpy, VkDisplayKHR display)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetRandROutputDisplayEXT(VkPhysicalDevice physicalDevice, Xlib.Display* dpy, IntPtr rrOutput, VkDisplayKHR* pDisplay)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetRandROutputDisplayEXT(VkPhysicalDevice physicalDevice, Xlib.Display* dpy, IntPtr rrOutput, out VkDisplayKHR pDisplay)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetRandROutputDisplayEXT(VkPhysicalDevice physicalDevice, ref Xlib.Display dpy, IntPtr rrOutput, VkDisplayKHR* pDisplay)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetRandROutputDisplayEXT(VkPhysicalDevice physicalDevice, ref Xlib.Display dpy, IntPtr rrOutput, out VkDisplayKHR pDisplay)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetRandROutputDisplayEXT(VkPhysicalDevice physicalDevice, IntPtr dpy, IntPtr rrOutput, VkDisplayKHR* pDisplay)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetRandROutputDisplayEXT(VkPhysicalDevice physicalDevice, IntPtr dpy, IntPtr rrOutput, out VkDisplayKHR pDisplay)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanEXTAcquireXlibDisplay(VkInstance instance)
        {
            vkAcquireXlibDisplayEXT_ptr = VulkanNative.LoadInstanceProcAddr(instance, "vkAcquireXlibDisplayEXT", true);
            vkGetRandROutputDisplayEXT_ptr = VulkanNative.LoadInstanceProcAddr(instance, "vkGetRandROutputDisplayEXT", true);
        }
    }

    public unsafe sealed class VulkanEXTDisplaySurfaceCounter : IVulkanInstanceExtGeneric<VulkanEXTDisplaySurfaceCounter>
    {
        public static string Name => "VK_EXT_display_surface_counter";
        string IVulkanExt.GetName() => Name;

        public static VulkanEXTDisplaySurfaceCounter Create(VkInstance instance)
        {
            return new VulkanEXTDisplaySurfaceCounter(instance);
        }

        private IntPtr vkGetPhysicalDeviceSurfaceCapabilities2EXT_ptr;

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSurfaceCapabilities2EXT(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, VkSurfaceCapabilities2EXT* pSurfaceCapabilities)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSurfaceCapabilities2EXT(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, out VkSurfaceCapabilities2EXT pSurfaceCapabilities)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanEXTDisplaySurfaceCounter(VkInstance instance)
        {
            vkGetPhysicalDeviceSurfaceCapabilities2EXT_ptr = VulkanNative.LoadInstanceProcAddr(instance, "vkGetPhysicalDeviceSurfaceCapabilities2EXT", true);
        }
    }

    public unsafe sealed class VulkanEXTDisplayControl : IVulkanDeviceExtGeneric<VulkanEXTDisplayControl>
    {
        public static string Name => "VK_EXT_display_control";
        string IVulkanExt.GetName() => Name;

        public static VulkanEXTDisplayControl Create(VkDevice device)
        {
            return new VulkanEXTDisplayControl(device);
        }

        private IntPtr vkDisplayPowerControlEXT_ptr;
        private IntPtr vkGetSwapchainCounterEXT_ptr;
        private IntPtr vkRegisterDeviceEventEXT_ptr;
        private IntPtr vkRegisterDisplayEventEXT_ptr;

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkDisplayPowerControlEXT(VkDevice device, VkDisplayKHR display, VkDisplayPowerInfoEXT* pDisplayPowerInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkDisplayPowerControlEXT(VkDevice device, VkDisplayKHR display, ref VkDisplayPowerInfoEXT pDisplayPowerInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkDisplayPowerControlEXT(VkDevice device, VkDisplayKHR display, IntPtr pDisplayPowerInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_OUT_OF_DATE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetSwapchainCounterEXT(VkDevice device, VkSwapchainKHR swapchain, VkSurfaceCounterFlagsEXT counter, ulong* pCounterValue)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_OUT_OF_DATE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetSwapchainCounterEXT(VkDevice device, VkSwapchainKHR swapchain, VkSurfaceCounterFlagsEXT counter, out ulong pCounterValue)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkRegisterDeviceEventEXT(VkDevice device, VkDeviceEventInfoEXT* pDeviceEventInfo, VkAllocationCallbacks* pAllocator, VkFence* pFence)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkRegisterDeviceEventEXT(VkDevice device, VkDeviceEventInfoEXT* pDeviceEventInfo, VkAllocationCallbacks* pAllocator, ref VkFence pFence)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkRegisterDeviceEventEXT(VkDevice device, VkDeviceEventInfoEXT* pDeviceEventInfo, VkAllocationCallbacks* pAllocator, IntPtr pFence)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkRegisterDeviceEventEXT(VkDevice device, VkDeviceEventInfoEXT* pDeviceEventInfo, ref VkAllocationCallbacks pAllocator, VkFence* pFence)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkRegisterDeviceEventEXT(VkDevice device, VkDeviceEventInfoEXT* pDeviceEventInfo, ref VkAllocationCallbacks pAllocator, ref VkFence pFence)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkRegisterDeviceEventEXT(VkDevice device, VkDeviceEventInfoEXT* pDeviceEventInfo, ref VkAllocationCallbacks pAllocator, IntPtr pFence)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkRegisterDeviceEventEXT(VkDevice device, VkDeviceEventInfoEXT* pDeviceEventInfo, IntPtr pAllocator, VkFence* pFence)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkRegisterDeviceEventEXT(VkDevice device, VkDeviceEventInfoEXT* pDeviceEventInfo, IntPtr pAllocator, ref VkFence pFence)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkRegisterDeviceEventEXT(VkDevice device, VkDeviceEventInfoEXT* pDeviceEventInfo, IntPtr pAllocator, IntPtr pFence)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkRegisterDeviceEventEXT(VkDevice device, ref VkDeviceEventInfoEXT pDeviceEventInfo, VkAllocationCallbacks* pAllocator, VkFence* pFence)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkRegisterDeviceEventEXT(VkDevice device, ref VkDeviceEventInfoEXT pDeviceEventInfo, VkAllocationCallbacks* pAllocator, ref VkFence pFence)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkRegisterDeviceEventEXT(VkDevice device, ref VkDeviceEventInfoEXT pDeviceEventInfo, VkAllocationCallbacks* pAllocator, IntPtr pFence)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkRegisterDeviceEventEXT(VkDevice device, ref VkDeviceEventInfoEXT pDeviceEventInfo, ref VkAllocationCallbacks pAllocator, VkFence* pFence)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkRegisterDeviceEventEXT(VkDevice device, ref VkDeviceEventInfoEXT pDeviceEventInfo, ref VkAllocationCallbacks pAllocator, ref VkFence pFence)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkRegisterDeviceEventEXT(VkDevice device, ref VkDeviceEventInfoEXT pDeviceEventInfo, ref VkAllocationCallbacks pAllocator, IntPtr pFence)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkRegisterDeviceEventEXT(VkDevice device, ref VkDeviceEventInfoEXT pDeviceEventInfo, IntPtr pAllocator, VkFence* pFence)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkRegisterDeviceEventEXT(VkDevice device, ref VkDeviceEventInfoEXT pDeviceEventInfo, IntPtr pAllocator, ref VkFence pFence)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkRegisterDeviceEventEXT(VkDevice device, ref VkDeviceEventInfoEXT pDeviceEventInfo, IntPtr pAllocator, IntPtr pFence)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkRegisterDeviceEventEXT(VkDevice device, IntPtr pDeviceEventInfo, VkAllocationCallbacks* pAllocator, VkFence* pFence)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkRegisterDeviceEventEXT(VkDevice device, IntPtr pDeviceEventInfo, VkAllocationCallbacks* pAllocator, ref VkFence pFence)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkRegisterDeviceEventEXT(VkDevice device, IntPtr pDeviceEventInfo, VkAllocationCallbacks* pAllocator, IntPtr pFence)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkRegisterDeviceEventEXT(VkDevice device, IntPtr pDeviceEventInfo, ref VkAllocationCallbacks pAllocator, VkFence* pFence)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkRegisterDeviceEventEXT(VkDevice device, IntPtr pDeviceEventInfo, ref VkAllocationCallbacks pAllocator, ref VkFence pFence)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkRegisterDeviceEventEXT(VkDevice device, IntPtr pDeviceEventInfo, ref VkAllocationCallbacks pAllocator, IntPtr pFence)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkRegisterDeviceEventEXT(VkDevice device, IntPtr pDeviceEventInfo, IntPtr pAllocator, VkFence* pFence)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkRegisterDeviceEventEXT(VkDevice device, IntPtr pDeviceEventInfo, IntPtr pAllocator, ref VkFence pFence)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkRegisterDeviceEventEXT(VkDevice device, IntPtr pDeviceEventInfo, IntPtr pAllocator, IntPtr pFence)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, VkDisplayEventInfoEXT* pDisplayEventInfo, VkAllocationCallbacks* pAllocator, VkFence* pFence)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, VkDisplayEventInfoEXT* pDisplayEventInfo, VkAllocationCallbacks* pAllocator, ref VkFence pFence)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, VkDisplayEventInfoEXT* pDisplayEventInfo, VkAllocationCallbacks* pAllocator, IntPtr pFence)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, VkDisplayEventInfoEXT* pDisplayEventInfo, ref VkAllocationCallbacks pAllocator, VkFence* pFence)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, VkDisplayEventInfoEXT* pDisplayEventInfo, ref VkAllocationCallbacks pAllocator, ref VkFence pFence)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, VkDisplayEventInfoEXT* pDisplayEventInfo, ref VkAllocationCallbacks pAllocator, IntPtr pFence)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, VkDisplayEventInfoEXT* pDisplayEventInfo, IntPtr pAllocator, VkFence* pFence)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, VkDisplayEventInfoEXT* pDisplayEventInfo, IntPtr pAllocator, ref VkFence pFence)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, VkDisplayEventInfoEXT* pDisplayEventInfo, IntPtr pAllocator, IntPtr pFence)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, ref VkDisplayEventInfoEXT pDisplayEventInfo, VkAllocationCallbacks* pAllocator, VkFence* pFence)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, ref VkDisplayEventInfoEXT pDisplayEventInfo, VkAllocationCallbacks* pAllocator, ref VkFence pFence)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, ref VkDisplayEventInfoEXT pDisplayEventInfo, VkAllocationCallbacks* pAllocator, IntPtr pFence)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, ref VkDisplayEventInfoEXT pDisplayEventInfo, ref VkAllocationCallbacks pAllocator, VkFence* pFence)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, ref VkDisplayEventInfoEXT pDisplayEventInfo, ref VkAllocationCallbacks pAllocator, ref VkFence pFence)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, ref VkDisplayEventInfoEXT pDisplayEventInfo, ref VkAllocationCallbacks pAllocator, IntPtr pFence)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, ref VkDisplayEventInfoEXT pDisplayEventInfo, IntPtr pAllocator, VkFence* pFence)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, ref VkDisplayEventInfoEXT pDisplayEventInfo, IntPtr pAllocator, ref VkFence pFence)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, ref VkDisplayEventInfoEXT pDisplayEventInfo, IntPtr pAllocator, IntPtr pFence)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, IntPtr pDisplayEventInfo, VkAllocationCallbacks* pAllocator, VkFence* pFence)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, IntPtr pDisplayEventInfo, VkAllocationCallbacks* pAllocator, ref VkFence pFence)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, IntPtr pDisplayEventInfo, VkAllocationCallbacks* pAllocator, IntPtr pFence)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, IntPtr pDisplayEventInfo, ref VkAllocationCallbacks pAllocator, VkFence* pFence)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, IntPtr pDisplayEventInfo, ref VkAllocationCallbacks pAllocator, ref VkFence pFence)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, IntPtr pDisplayEventInfo, ref VkAllocationCallbacks pAllocator, IntPtr pFence)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, IntPtr pDisplayEventInfo, IntPtr pAllocator, VkFence* pFence)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, IntPtr pDisplayEventInfo, IntPtr pAllocator, ref VkFence pFence)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, IntPtr pDisplayEventInfo, IntPtr pAllocator, IntPtr pFence)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanEXTDisplayControl(VkDevice device)
        {
            vkDisplayPowerControlEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkDisplayPowerControlEXT", true);
            vkGetSwapchainCounterEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetSwapchainCounterEXT", true);
            vkRegisterDeviceEventEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkRegisterDeviceEventEXT", true);
            vkRegisterDisplayEventEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkRegisterDisplayEventEXT", true);
        }
    }

    public unsafe sealed class VulkanGoogleDisplayTiming : IVulkanDeviceExtGeneric<VulkanGoogleDisplayTiming>
    {
        public static string Name => "VK_GOOGLE_display_timing";
        string IVulkanExt.GetName() => Name;

        public static VulkanGoogleDisplayTiming Create(VkDevice device)
        {
            return new VulkanGoogleDisplayTiming(device);
        }

        private IntPtr vkGetPastPresentationTimingGOOGLE_ptr;
        private IntPtr vkGetRefreshCycleDurationGOOGLE_ptr;

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_OUT_OF_DATE_KHR, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPastPresentationTimingGOOGLE(VkDevice device, VkSwapchainKHR swapchain, uint* pPresentationTimingCount, VkPastPresentationTimingGOOGLE* pPresentationTimings)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_OUT_OF_DATE_KHR, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPastPresentationTimingGOOGLE(VkDevice device, VkSwapchainKHR swapchain, uint* pPresentationTimingCount, out VkPastPresentationTimingGOOGLE pPresentationTimings)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_OUT_OF_DATE_KHR, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPastPresentationTimingGOOGLE(VkDevice device, VkSwapchainKHR swapchain, ref uint pPresentationTimingCount, VkPastPresentationTimingGOOGLE* pPresentationTimings)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_OUT_OF_DATE_KHR, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPastPresentationTimingGOOGLE(VkDevice device, VkSwapchainKHR swapchain, ref uint pPresentationTimingCount, out VkPastPresentationTimingGOOGLE pPresentationTimings)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_OUT_OF_DATE_KHR, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPastPresentationTimingGOOGLE(VkDevice device, VkSwapchainKHR swapchain, IntPtr pPresentationTimingCount, VkPastPresentationTimingGOOGLE* pPresentationTimings)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_OUT_OF_DATE_KHR, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPastPresentationTimingGOOGLE(VkDevice device, VkSwapchainKHR swapchain, IntPtr pPresentationTimingCount, out VkPastPresentationTimingGOOGLE pPresentationTimings)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetRefreshCycleDurationGOOGLE(VkDevice device, VkSwapchainKHR swapchain, VkRefreshCycleDurationGOOGLE* pDisplayTimingProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetRefreshCycleDurationGOOGLE(VkDevice device, VkSwapchainKHR swapchain, out VkRefreshCycleDurationGOOGLE pDisplayTimingProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanGoogleDisplayTiming(VkDevice device)
        {
            vkGetPastPresentationTimingGOOGLE_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetPastPresentationTimingGOOGLE", true);
            vkGetRefreshCycleDurationGOOGLE_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetRefreshCycleDurationGOOGLE", true);
        }
    }

    public unsafe sealed class VulkanEXTDiscardRectangles : IVulkanDeviceExtGeneric<VulkanEXTDiscardRectangles>
    {
        public static string Name => "VK_EXT_discard_rectangles";
        string IVulkanExt.GetName() => Name;

        public static VulkanEXTDiscardRectangles Create(VkDevice device)
        {
            return new VulkanEXTDiscardRectangles(device);
        }

        private IntPtr vkCmdSetDiscardRectangleEXT_ptr;

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetDiscardRectangleEXT(VkCommandBuffer commandBuffer, uint firstDiscardRectangle, uint discardRectangleCount, VkRect2D* pDiscardRectangles)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetDiscardRectangleEXT(VkCommandBuffer commandBuffer, uint firstDiscardRectangle, uint discardRectangleCount, ref VkRect2D pDiscardRectangles)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetDiscardRectangleEXT(VkCommandBuffer commandBuffer, uint firstDiscardRectangle, uint discardRectangleCount, IntPtr pDiscardRectangles)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanEXTDiscardRectangles(VkDevice device)
        {
            vkCmdSetDiscardRectangleEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdSetDiscardRectangleEXT", true);
        }
    }

    public unsafe sealed class VulkanEXTHdrMetadata : IVulkanDeviceExtGeneric<VulkanEXTHdrMetadata>
    {
        public static string Name => "VK_EXT_hdr_metadata";
        string IVulkanExt.GetName() => Name;

        public static VulkanEXTHdrMetadata Create(VkDevice device)
        {
            return new VulkanEXTHdrMetadata(device);
        }

        private IntPtr vkSetHdrMetadataEXT_ptr;

        [Generator.CalliRewrite]
        public unsafe void vkSetHdrMetadataEXT(VkDevice device, uint swapchainCount, VkSwapchainKHR* pSwapchains, VkHdrMetadataEXT* pMetadata)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkSetHdrMetadataEXT(VkDevice device, uint swapchainCount, VkSwapchainKHR* pSwapchains, ref VkHdrMetadataEXT pMetadata)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkSetHdrMetadataEXT(VkDevice device, uint swapchainCount, VkSwapchainKHR* pSwapchains, IntPtr pMetadata)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkSetHdrMetadataEXT(VkDevice device, uint swapchainCount, ref VkSwapchainKHR pSwapchains, VkHdrMetadataEXT* pMetadata)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkSetHdrMetadataEXT(VkDevice device, uint swapchainCount, ref VkSwapchainKHR pSwapchains, ref VkHdrMetadataEXT pMetadata)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkSetHdrMetadataEXT(VkDevice device, uint swapchainCount, ref VkSwapchainKHR pSwapchains, IntPtr pMetadata)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkSetHdrMetadataEXT(VkDevice device, uint swapchainCount, IntPtr pSwapchains, VkHdrMetadataEXT* pMetadata)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkSetHdrMetadataEXT(VkDevice device, uint swapchainCount, IntPtr pSwapchains, ref VkHdrMetadataEXT pMetadata)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkSetHdrMetadataEXT(VkDevice device, uint swapchainCount, IntPtr pSwapchains, IntPtr pMetadata)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanEXTHdrMetadata(VkDevice device)
        {
            vkSetHdrMetadataEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkSetHdrMetadataEXT", true);
        }
    }

    public unsafe sealed class VulkanKHRCreateRenderpass2 : IVulkanDeviceExtGeneric<VulkanKHRCreateRenderpass2>
    {
        public static string Name => "VK_KHR_create_renderpass2";
        string IVulkanExt.GetName() => Name;

        public static VulkanKHRCreateRenderpass2 Create(VkDevice device)
        {
            return new VulkanKHRCreateRenderpass2(device);
        }



        public VulkanKHRCreateRenderpass2(VkDevice device)
        {
        }
    }

    public unsafe sealed class VulkanKHRSharedPresentableImage : IVulkanDeviceExtGeneric<VulkanKHRSharedPresentableImage>
    {
        public static string Name => "VK_KHR_shared_presentable_image";
        string IVulkanExt.GetName() => Name;

        public static VulkanKHRSharedPresentableImage Create(VkDevice device)
        {
            return new VulkanKHRSharedPresentableImage(device);
        }

        private IntPtr vkGetSwapchainStatusKHR_ptr;

        ///<remarks>Success codes:VK_SUCCESS, VK_SUBOPTIMAL_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_OUT_OF_DATE_KHR, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_FULL_SCREEN_EXCLUSIVE_MODE_LOST_EXT</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetSwapchainStatusKHR(VkDevice device, VkSwapchainKHR swapchain)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanKHRSharedPresentableImage(VkDevice device)
        {
            vkGetSwapchainStatusKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetSwapchainStatusKHR", true);
        }
    }

    public unsafe sealed class VulkanKHRExternalFenceCapabilities : IVulkanInstanceExtGeneric<VulkanKHRExternalFenceCapabilities>
    {
        public static string Name => "VK_KHR_external_fence_capabilities";
        string IVulkanExt.GetName() => Name;

        public static VulkanKHRExternalFenceCapabilities Create(VkInstance instance)
        {
            return new VulkanKHRExternalFenceCapabilities(instance);
        }



        public VulkanKHRExternalFenceCapabilities(VkInstance instance)
        {
        }
    }

    public unsafe sealed class VulkanKHRExternalFenceWin32 : IVulkanDeviceExtGeneric<VulkanKHRExternalFenceWin32>
    {
        public static string Name => "VK_KHR_external_fence_win32";
        string IVulkanExt.GetName() => Name;

        public static VulkanKHRExternalFenceWin32 Create(VkDevice device)
        {
            return new VulkanKHRExternalFenceWin32(device);
        }

        private IntPtr vkGetFenceWin32HandleKHR_ptr;
        private IntPtr vkImportFenceWin32HandleKHR_ptr;

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetFenceWin32HandleKHR(VkDevice device, VkFenceGetWin32HandleInfoKHR* pGetWin32HandleInfo, Win32.HANDLE* pHandle)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetFenceWin32HandleKHR(VkDevice device, VkFenceGetWin32HandleInfoKHR* pGetWin32HandleInfo, out Win32.HANDLE pHandle)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetFenceWin32HandleKHR(VkDevice device, ref VkFenceGetWin32HandleInfoKHR pGetWin32HandleInfo, Win32.HANDLE* pHandle)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetFenceWin32HandleKHR(VkDevice device, ref VkFenceGetWin32HandleInfoKHR pGetWin32HandleInfo, out Win32.HANDLE pHandle)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetFenceWin32HandleKHR(VkDevice device, IntPtr pGetWin32HandleInfo, Win32.HANDLE* pHandle)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetFenceWin32HandleKHR(VkDevice device, IntPtr pGetWin32HandleInfo, out Win32.HANDLE pHandle)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkImportFenceWin32HandleKHR(VkDevice device, VkImportFenceWin32HandleInfoKHR* pImportFenceWin32HandleInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkImportFenceWin32HandleKHR(VkDevice device, ref VkImportFenceWin32HandleInfoKHR pImportFenceWin32HandleInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkImportFenceWin32HandleKHR(VkDevice device, IntPtr pImportFenceWin32HandleInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanKHRExternalFenceWin32(VkDevice device)
        {
            vkGetFenceWin32HandleKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetFenceWin32HandleKHR", true);
            vkImportFenceWin32HandleKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkImportFenceWin32HandleKHR", true);
        }
    }

    public unsafe sealed class VulkanKHRExternalFenceFd : IVulkanDeviceExtGeneric<VulkanKHRExternalFenceFd>
    {
        public static string Name => "VK_KHR_external_fence_fd";
        string IVulkanExt.GetName() => Name;

        public static VulkanKHRExternalFenceFd Create(VkDevice device)
        {
            return new VulkanKHRExternalFenceFd(device);
        }

        private IntPtr vkGetFenceFdKHR_ptr;
        private IntPtr vkImportFenceFdKHR_ptr;

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetFenceFdKHR(VkDevice device, VkFenceGetFdInfoKHR* pGetFdInfo, int* pFd)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetFenceFdKHR(VkDevice device, VkFenceGetFdInfoKHR* pGetFdInfo, out int pFd)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetFenceFdKHR(VkDevice device, ref VkFenceGetFdInfoKHR pGetFdInfo, int* pFd)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetFenceFdKHR(VkDevice device, ref VkFenceGetFdInfoKHR pGetFdInfo, out int pFd)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetFenceFdKHR(VkDevice device, IntPtr pGetFdInfo, int* pFd)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetFenceFdKHR(VkDevice device, IntPtr pGetFdInfo, out int pFd)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkImportFenceFdKHR(VkDevice device, VkImportFenceFdInfoKHR* pImportFenceFdInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkImportFenceFdKHR(VkDevice device, ref VkImportFenceFdInfoKHR pImportFenceFdInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkImportFenceFdKHR(VkDevice device, IntPtr pImportFenceFdInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanKHRExternalFenceFd(VkDevice device)
        {
            vkGetFenceFdKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetFenceFdKHR", true);
            vkImportFenceFdKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkImportFenceFdKHR", true);
        }
    }

    public unsafe sealed class VulkanKHRPerformanceQuery : IVulkanDeviceExtGeneric<VulkanKHRPerformanceQuery>
    {
        public static string Name => "VK_KHR_performance_query";
        string IVulkanExt.GetName() => Name;

        public static VulkanKHRPerformanceQuery Create(VkDevice device)
        {
            return new VulkanKHRPerformanceQuery(device);
        }

        private IntPtr vkAcquireProfilingLockKHR_ptr;
        private IntPtr vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR_ptr;
        private IntPtr vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR_ptr;
        private IntPtr vkReleaseProfilingLockKHR_ptr;

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_TIMEOUT</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkAcquireProfilingLockKHR(VkDevice device, VkAcquireProfilingLockInfoKHR* pInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_TIMEOUT</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkAcquireProfilingLockKHR(VkDevice device, ref VkAcquireProfilingLockInfoKHR pInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_TIMEOUT</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkAcquireProfilingLockKHR(VkDevice device, IntPtr pInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, uint* pCounterCount, VkPerformanceCounterKHR* pCounters, VkPerformanceCounterDescriptionKHR* pCounterDescriptions)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, uint* pCounterCount, VkPerformanceCounterKHR* pCounters, ref VkPerformanceCounterDescriptionKHR pCounterDescriptions)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, uint* pCounterCount, VkPerformanceCounterKHR* pCounters, IntPtr pCounterDescriptions)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, uint* pCounterCount, ref VkPerformanceCounterKHR pCounters, VkPerformanceCounterDescriptionKHR* pCounterDescriptions)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, uint* pCounterCount, ref VkPerformanceCounterKHR pCounters, ref VkPerformanceCounterDescriptionKHR pCounterDescriptions)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, uint* pCounterCount, ref VkPerformanceCounterKHR pCounters, IntPtr pCounterDescriptions)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, uint* pCounterCount, IntPtr pCounters, VkPerformanceCounterDescriptionKHR* pCounterDescriptions)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, uint* pCounterCount, IntPtr pCounters, ref VkPerformanceCounterDescriptionKHR pCounterDescriptions)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, uint* pCounterCount, IntPtr pCounters, IntPtr pCounterDescriptions)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, ref uint pCounterCount, VkPerformanceCounterKHR* pCounters, VkPerformanceCounterDescriptionKHR* pCounterDescriptions)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, ref uint pCounterCount, VkPerformanceCounterKHR* pCounters, ref VkPerformanceCounterDescriptionKHR pCounterDescriptions)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, ref uint pCounterCount, VkPerformanceCounterKHR* pCounters, IntPtr pCounterDescriptions)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, ref uint pCounterCount, ref VkPerformanceCounterKHR pCounters, VkPerformanceCounterDescriptionKHR* pCounterDescriptions)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, ref uint pCounterCount, ref VkPerformanceCounterKHR pCounters, ref VkPerformanceCounterDescriptionKHR pCounterDescriptions)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, ref uint pCounterCount, ref VkPerformanceCounterKHR pCounters, IntPtr pCounterDescriptions)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, ref uint pCounterCount, IntPtr pCounters, VkPerformanceCounterDescriptionKHR* pCounterDescriptions)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, ref uint pCounterCount, IntPtr pCounters, ref VkPerformanceCounterDescriptionKHR pCounterDescriptions)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, ref uint pCounterCount, IntPtr pCounters, IntPtr pCounterDescriptions)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr pCounterCount, VkPerformanceCounterKHR* pCounters, VkPerformanceCounterDescriptionKHR* pCounterDescriptions)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr pCounterCount, VkPerformanceCounterKHR* pCounters, ref VkPerformanceCounterDescriptionKHR pCounterDescriptions)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr pCounterCount, VkPerformanceCounterKHR* pCounters, IntPtr pCounterDescriptions)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr pCounterCount, ref VkPerformanceCounterKHR pCounters, VkPerformanceCounterDescriptionKHR* pCounterDescriptions)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr pCounterCount, ref VkPerformanceCounterKHR pCounters, ref VkPerformanceCounterDescriptionKHR pCounterDescriptions)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr pCounterCount, ref VkPerformanceCounterKHR pCounters, IntPtr pCounterDescriptions)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr pCounterCount, IntPtr pCounters, VkPerformanceCounterDescriptionKHR* pCounterDescriptions)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr pCounterCount, IntPtr pCounters, ref VkPerformanceCounterDescriptionKHR pCounterDescriptions)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr pCounterCount, IntPtr pCounters, IntPtr pCounterDescriptions)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR(VkPhysicalDevice physicalDevice, VkQueryPoolPerformanceCreateInfoKHR* pPerformanceQueryCreateInfo, uint* pNumPasses)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR(VkPhysicalDevice physicalDevice, VkQueryPoolPerformanceCreateInfoKHR* pPerformanceQueryCreateInfo, out uint pNumPasses)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR(VkPhysicalDevice physicalDevice, ref VkQueryPoolPerformanceCreateInfoKHR pPerformanceQueryCreateInfo, uint* pNumPasses)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR(VkPhysicalDevice physicalDevice, ref VkQueryPoolPerformanceCreateInfoKHR pPerformanceQueryCreateInfo, out uint pNumPasses)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR(VkPhysicalDevice physicalDevice, IntPtr pPerformanceQueryCreateInfo, uint* pNumPasses)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR(VkPhysicalDevice physicalDevice, IntPtr pPerformanceQueryCreateInfo, out uint pNumPasses)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkReleaseProfilingLockKHR(VkDevice device)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanKHRPerformanceQuery(VkDevice device)
        {
            vkAcquireProfilingLockKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkAcquireProfilingLockKHR", true);
            vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR", true);
            vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR", true);
            vkReleaseProfilingLockKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkReleaseProfilingLockKHR", true);
        }
    }

    public unsafe sealed class VulkanKHRGetSurfaceCapabilities2 : IVulkanInstanceExtGeneric<VulkanKHRGetSurfaceCapabilities2>
    {
        public static string Name => "VK_KHR_get_surface_capabilities2";
        string IVulkanExt.GetName() => Name;

        public static VulkanKHRGetSurfaceCapabilities2 Create(VkInstance instance)
        {
            return new VulkanKHRGetSurfaceCapabilities2(instance);
        }

        private IntPtr vkGetPhysicalDeviceSurfaceCapabilities2KHR_ptr;
        private IntPtr vkGetPhysicalDeviceSurfaceFormats2KHR_ptr;

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSurfaceCapabilities2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, VkSurfaceCapabilities2KHR* pSurfaceCapabilities)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSurfaceCapabilities2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, out VkSurfaceCapabilities2KHR pSurfaceCapabilities)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSurfaceCapabilities2KHR(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, VkSurfaceCapabilities2KHR* pSurfaceCapabilities)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSurfaceCapabilities2KHR(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, out VkSurfaceCapabilities2KHR pSurfaceCapabilities)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSurfaceCapabilities2KHR(VkPhysicalDevice physicalDevice, IntPtr pSurfaceInfo, VkSurfaceCapabilities2KHR* pSurfaceCapabilities)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSurfaceCapabilities2KHR(VkPhysicalDevice physicalDevice, IntPtr pSurfaceInfo, out VkSurfaceCapabilities2KHR pSurfaceCapabilities)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, uint* pSurfaceFormatCount, VkSurfaceFormat2KHR* pSurfaceFormats)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, uint* pSurfaceFormatCount, out VkSurfaceFormat2KHR pSurfaceFormats)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, ref uint pSurfaceFormatCount, VkSurfaceFormat2KHR* pSurfaceFormats)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, ref uint pSurfaceFormatCount, out VkSurfaceFormat2KHR pSurfaceFormats)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, IntPtr pSurfaceFormatCount, VkSurfaceFormat2KHR* pSurfaceFormats)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, IntPtr pSurfaceFormatCount, out VkSurfaceFormat2KHR pSurfaceFormats)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, uint* pSurfaceFormatCount, VkSurfaceFormat2KHR* pSurfaceFormats)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, uint* pSurfaceFormatCount, out VkSurfaceFormat2KHR pSurfaceFormats)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, ref uint pSurfaceFormatCount, VkSurfaceFormat2KHR* pSurfaceFormats)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, ref uint pSurfaceFormatCount, out VkSurfaceFormat2KHR pSurfaceFormats)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, IntPtr pSurfaceFormatCount, VkSurfaceFormat2KHR* pSurfaceFormats)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, IntPtr pSurfaceFormatCount, out VkSurfaceFormat2KHR pSurfaceFormats)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, IntPtr pSurfaceInfo, uint* pSurfaceFormatCount, VkSurfaceFormat2KHR* pSurfaceFormats)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, IntPtr pSurfaceInfo, uint* pSurfaceFormatCount, out VkSurfaceFormat2KHR pSurfaceFormats)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, IntPtr pSurfaceInfo, ref uint pSurfaceFormatCount, VkSurfaceFormat2KHR* pSurfaceFormats)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, IntPtr pSurfaceInfo, ref uint pSurfaceFormatCount, out VkSurfaceFormat2KHR pSurfaceFormats)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, IntPtr pSurfaceInfo, IntPtr pSurfaceFormatCount, VkSurfaceFormat2KHR* pSurfaceFormats)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, IntPtr pSurfaceInfo, IntPtr pSurfaceFormatCount, out VkSurfaceFormat2KHR pSurfaceFormats)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanKHRGetSurfaceCapabilities2(VkInstance instance)
        {
            vkGetPhysicalDeviceSurfaceCapabilities2KHR_ptr = VulkanNative.LoadInstanceProcAddr(instance, "vkGetPhysicalDeviceSurfaceCapabilities2KHR", true);
            vkGetPhysicalDeviceSurfaceFormats2KHR_ptr = VulkanNative.LoadInstanceProcAddr(instance, "vkGetPhysicalDeviceSurfaceFormats2KHR", true);
        }
    }

    public unsafe sealed class VulkanKHRGetDisplayProperties2 : IVulkanInstanceExtGeneric<VulkanKHRGetDisplayProperties2>
    {
        public static string Name => "VK_KHR_get_display_properties2";
        string IVulkanExt.GetName() => Name;

        public static VulkanKHRGetDisplayProperties2 Create(VkInstance instance)
        {
            return new VulkanKHRGetDisplayProperties2(instance);
        }

        private IntPtr vkGetDisplayModeProperties2KHR_ptr;
        private IntPtr vkGetDisplayPlaneCapabilities2KHR_ptr;
        private IntPtr vkGetPhysicalDeviceDisplayPlaneProperties2KHR_ptr;
        private IntPtr vkGetPhysicalDeviceDisplayProperties2KHR_ptr;

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetDisplayModeProperties2KHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, uint* pPropertyCount, VkDisplayModeProperties2KHR* pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetDisplayModeProperties2KHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, uint* pPropertyCount, out VkDisplayModeProperties2KHR pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetDisplayModeProperties2KHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, ref uint pPropertyCount, VkDisplayModeProperties2KHR* pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetDisplayModeProperties2KHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, ref uint pPropertyCount, out VkDisplayModeProperties2KHR pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetDisplayModeProperties2KHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, IntPtr pPropertyCount, VkDisplayModeProperties2KHR* pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetDisplayModeProperties2KHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, IntPtr pPropertyCount, out VkDisplayModeProperties2KHR pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetDisplayPlaneCapabilities2KHR(VkPhysicalDevice physicalDevice, VkDisplayPlaneInfo2KHR* pDisplayPlaneInfo, VkDisplayPlaneCapabilities2KHR* pCapabilities)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetDisplayPlaneCapabilities2KHR(VkPhysicalDevice physicalDevice, VkDisplayPlaneInfo2KHR* pDisplayPlaneInfo, out VkDisplayPlaneCapabilities2KHR pCapabilities)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetDisplayPlaneCapabilities2KHR(VkPhysicalDevice physicalDevice, ref VkDisplayPlaneInfo2KHR pDisplayPlaneInfo, VkDisplayPlaneCapabilities2KHR* pCapabilities)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetDisplayPlaneCapabilities2KHR(VkPhysicalDevice physicalDevice, ref VkDisplayPlaneInfo2KHR pDisplayPlaneInfo, out VkDisplayPlaneCapabilities2KHR pCapabilities)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetDisplayPlaneCapabilities2KHR(VkPhysicalDevice physicalDevice, IntPtr pDisplayPlaneInfo, VkDisplayPlaneCapabilities2KHR* pCapabilities)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetDisplayPlaneCapabilities2KHR(VkPhysicalDevice physicalDevice, IntPtr pDisplayPlaneInfo, out VkDisplayPlaneCapabilities2KHR pCapabilities)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceDisplayPlaneProperties2KHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayPlaneProperties2KHR* pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceDisplayPlaneProperties2KHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, out VkDisplayPlaneProperties2KHR pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceDisplayPlaneProperties2KHR(VkPhysicalDevice physicalDevice, ref uint pPropertyCount, VkDisplayPlaneProperties2KHR* pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceDisplayPlaneProperties2KHR(VkPhysicalDevice physicalDevice, ref uint pPropertyCount, out VkDisplayPlaneProperties2KHR pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceDisplayPlaneProperties2KHR(VkPhysicalDevice physicalDevice, IntPtr pPropertyCount, VkDisplayPlaneProperties2KHR* pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceDisplayPlaneProperties2KHR(VkPhysicalDevice physicalDevice, IntPtr pPropertyCount, out VkDisplayPlaneProperties2KHR pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceDisplayProperties2KHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayProperties2KHR* pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceDisplayProperties2KHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, out VkDisplayProperties2KHR pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceDisplayProperties2KHR(VkPhysicalDevice physicalDevice, ref uint pPropertyCount, VkDisplayProperties2KHR* pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceDisplayProperties2KHR(VkPhysicalDevice physicalDevice, ref uint pPropertyCount, out VkDisplayProperties2KHR pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceDisplayProperties2KHR(VkPhysicalDevice physicalDevice, IntPtr pPropertyCount, VkDisplayProperties2KHR* pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceDisplayProperties2KHR(VkPhysicalDevice physicalDevice, IntPtr pPropertyCount, out VkDisplayProperties2KHR pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanKHRGetDisplayProperties2(VkInstance instance)
        {
            vkGetDisplayModeProperties2KHR_ptr = VulkanNative.LoadInstanceProcAddr(instance, "vkGetDisplayModeProperties2KHR", true);
            vkGetDisplayPlaneCapabilities2KHR_ptr = VulkanNative.LoadInstanceProcAddr(instance, "vkGetDisplayPlaneCapabilities2KHR", true);
            vkGetPhysicalDeviceDisplayPlaneProperties2KHR_ptr = VulkanNative.LoadInstanceProcAddr(instance, "vkGetPhysicalDeviceDisplayPlaneProperties2KHR", true);
            vkGetPhysicalDeviceDisplayProperties2KHR_ptr = VulkanNative.LoadInstanceProcAddr(instance, "vkGetPhysicalDeviceDisplayProperties2KHR", true);
        }
    }

    public unsafe sealed class VulkanMvkIosSurface : IVulkanInstanceExtGeneric<VulkanMvkIosSurface>
    {
        public static string Name => "VK_MVK_ios_surface";
        string IVulkanExt.GetName() => Name;

        public static VulkanMvkIosSurface Create(VkInstance instance)
        {
            return new VulkanMvkIosSurface(instance);
        }

        private IntPtr vkCreateIOSSurfaceMVK_ptr;

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateIOSSurfaceMVK(VkInstance instance, VkIOSSurfaceCreateInfoMVK* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateIOSSurfaceMVK(VkInstance instance, VkIOSSurfaceCreateInfoMVK* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateIOSSurfaceMVK(VkInstance instance, VkIOSSurfaceCreateInfoMVK* pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateIOSSurfaceMVK(VkInstance instance, VkIOSSurfaceCreateInfoMVK* pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateIOSSurfaceMVK(VkInstance instance, VkIOSSurfaceCreateInfoMVK* pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateIOSSurfaceMVK(VkInstance instance, VkIOSSurfaceCreateInfoMVK* pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateIOSSurfaceMVK(VkInstance instance, ref VkIOSSurfaceCreateInfoMVK pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateIOSSurfaceMVK(VkInstance instance, ref VkIOSSurfaceCreateInfoMVK pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateIOSSurfaceMVK(VkInstance instance, ref VkIOSSurfaceCreateInfoMVK pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateIOSSurfaceMVK(VkInstance instance, ref VkIOSSurfaceCreateInfoMVK pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateIOSSurfaceMVK(VkInstance instance, ref VkIOSSurfaceCreateInfoMVK pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateIOSSurfaceMVK(VkInstance instance, ref VkIOSSurfaceCreateInfoMVK pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateIOSSurfaceMVK(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateIOSSurfaceMVK(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateIOSSurfaceMVK(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateIOSSurfaceMVK(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateIOSSurfaceMVK(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateIOSSurfaceMVK(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanMvkIosSurface(VkInstance instance)
        {
            vkCreateIOSSurfaceMVK_ptr = VulkanNative.LoadInstanceProcAddr(instance, "vkCreateIOSSurfaceMVK", true);
        }
    }

    public unsafe sealed class VulkanMvkMacosSurface : IVulkanInstanceExtGeneric<VulkanMvkMacosSurface>
    {
        public static string Name => "VK_MVK_macos_surface";
        string IVulkanExt.GetName() => Name;

        public static VulkanMvkMacosSurface Create(VkInstance instance)
        {
            return new VulkanMvkMacosSurface(instance);
        }

        private IntPtr vkCreateMacOSSurfaceMVK_ptr;

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateMacOSSurfaceMVK(VkInstance instance, VkMacOSSurfaceCreateInfoMVK* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateMacOSSurfaceMVK(VkInstance instance, VkMacOSSurfaceCreateInfoMVK* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateMacOSSurfaceMVK(VkInstance instance, VkMacOSSurfaceCreateInfoMVK* pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateMacOSSurfaceMVK(VkInstance instance, VkMacOSSurfaceCreateInfoMVK* pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateMacOSSurfaceMVK(VkInstance instance, VkMacOSSurfaceCreateInfoMVK* pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateMacOSSurfaceMVK(VkInstance instance, VkMacOSSurfaceCreateInfoMVK* pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateMacOSSurfaceMVK(VkInstance instance, ref VkMacOSSurfaceCreateInfoMVK pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateMacOSSurfaceMVK(VkInstance instance, ref VkMacOSSurfaceCreateInfoMVK pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateMacOSSurfaceMVK(VkInstance instance, ref VkMacOSSurfaceCreateInfoMVK pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateMacOSSurfaceMVK(VkInstance instance, ref VkMacOSSurfaceCreateInfoMVK pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateMacOSSurfaceMVK(VkInstance instance, ref VkMacOSSurfaceCreateInfoMVK pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateMacOSSurfaceMVK(VkInstance instance, ref VkMacOSSurfaceCreateInfoMVK pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateMacOSSurfaceMVK(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateMacOSSurfaceMVK(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateMacOSSurfaceMVK(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateMacOSSurfaceMVK(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateMacOSSurfaceMVK(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateMacOSSurfaceMVK(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanMvkMacosSurface(VkInstance instance)
        {
            vkCreateMacOSSurfaceMVK_ptr = VulkanNative.LoadInstanceProcAddr(instance, "vkCreateMacOSSurfaceMVK", true);
        }
    }

    public unsafe sealed class VulkanEXTDebugUtils : IVulkanInstanceExtGeneric<VulkanEXTDebugUtils>
    {
        public static string Name => "VK_EXT_debug_utils";
        string IVulkanExt.GetName() => Name;

        public static VulkanEXTDebugUtils Create(VkInstance instance)
        {
            return new VulkanEXTDebugUtils(instance);
        }

        private IntPtr vkCmdBeginDebugUtilsLabelEXT_ptr;
        private IntPtr vkCmdEndDebugUtilsLabelEXT_ptr;
        private IntPtr vkCmdInsertDebugUtilsLabelEXT_ptr;
        private IntPtr vkCreateDebugUtilsMessengerEXT_ptr;
        private IntPtr vkDestroyDebugUtilsMessengerEXT_ptr;
        private IntPtr vkQueueBeginDebugUtilsLabelEXT_ptr;
        private IntPtr vkQueueEndDebugUtilsLabelEXT_ptr;
        private IntPtr vkQueueInsertDebugUtilsLabelEXT_ptr;
        private IntPtr vkSetDebugUtilsObjectNameEXT_ptr;
        private IntPtr vkSetDebugUtilsObjectTagEXT_ptr;
        private IntPtr vkSubmitDebugUtilsMessageEXT_ptr;

        [Generator.CalliRewrite]
        public unsafe void vkCmdBeginDebugUtilsLabelEXT(VkCommandBuffer commandBuffer, VkDebugUtilsLabelEXT* pLabelInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBeginDebugUtilsLabelEXT(VkCommandBuffer commandBuffer, ref VkDebugUtilsLabelEXT pLabelInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBeginDebugUtilsLabelEXT(VkCommandBuffer commandBuffer, IntPtr pLabelInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdEndDebugUtilsLabelEXT(VkCommandBuffer commandBuffer)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdInsertDebugUtilsLabelEXT(VkCommandBuffer commandBuffer, VkDebugUtilsLabelEXT* pLabelInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdInsertDebugUtilsLabelEXT(VkCommandBuffer commandBuffer, ref VkDebugUtilsLabelEXT pLabelInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdInsertDebugUtilsLabelEXT(VkCommandBuffer commandBuffer, IntPtr pLabelInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDebugUtilsMessengerEXT(VkInstance instance, VkDebugUtilsMessengerCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDebugUtilsMessengerEXT* pMessenger)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDebugUtilsMessengerEXT(VkInstance instance, VkDebugUtilsMessengerCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkDebugUtilsMessengerEXT pMessenger)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDebugUtilsMessengerEXT(VkInstance instance, VkDebugUtilsMessengerCreateInfoEXT* pCreateInfo, ref VkAllocationCallbacks pAllocator, VkDebugUtilsMessengerEXT* pMessenger)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDebugUtilsMessengerEXT(VkInstance instance, VkDebugUtilsMessengerCreateInfoEXT* pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkDebugUtilsMessengerEXT pMessenger)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDebugUtilsMessengerEXT(VkInstance instance, VkDebugUtilsMessengerCreateInfoEXT* pCreateInfo, IntPtr pAllocator, VkDebugUtilsMessengerEXT* pMessenger)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDebugUtilsMessengerEXT(VkInstance instance, VkDebugUtilsMessengerCreateInfoEXT* pCreateInfo, IntPtr pAllocator, out VkDebugUtilsMessengerEXT pMessenger)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDebugUtilsMessengerEXT(VkInstance instance, ref VkDebugUtilsMessengerCreateInfoEXT pCreateInfo, VkAllocationCallbacks* pAllocator, VkDebugUtilsMessengerEXT* pMessenger)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDebugUtilsMessengerEXT(VkInstance instance, ref VkDebugUtilsMessengerCreateInfoEXT pCreateInfo, VkAllocationCallbacks* pAllocator, out VkDebugUtilsMessengerEXT pMessenger)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDebugUtilsMessengerEXT(VkInstance instance, ref VkDebugUtilsMessengerCreateInfoEXT pCreateInfo, ref VkAllocationCallbacks pAllocator, VkDebugUtilsMessengerEXT* pMessenger)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDebugUtilsMessengerEXT(VkInstance instance, ref VkDebugUtilsMessengerCreateInfoEXT pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkDebugUtilsMessengerEXT pMessenger)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDebugUtilsMessengerEXT(VkInstance instance, ref VkDebugUtilsMessengerCreateInfoEXT pCreateInfo, IntPtr pAllocator, VkDebugUtilsMessengerEXT* pMessenger)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDebugUtilsMessengerEXT(VkInstance instance, ref VkDebugUtilsMessengerCreateInfoEXT pCreateInfo, IntPtr pAllocator, out VkDebugUtilsMessengerEXT pMessenger)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDebugUtilsMessengerEXT(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, VkDebugUtilsMessengerEXT* pMessenger)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDebugUtilsMessengerEXT(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, out VkDebugUtilsMessengerEXT pMessenger)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDebugUtilsMessengerEXT(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, VkDebugUtilsMessengerEXT* pMessenger)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDebugUtilsMessengerEXT(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkDebugUtilsMessengerEXT pMessenger)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDebugUtilsMessengerEXT(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, VkDebugUtilsMessengerEXT* pMessenger)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDebugUtilsMessengerEXT(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, out VkDebugUtilsMessengerEXT pMessenger)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkDestroyDebugUtilsMessengerEXT(VkInstance instance, VkDebugUtilsMessengerEXT messenger, VkAllocationCallbacks* pAllocator)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkDestroyDebugUtilsMessengerEXT(VkInstance instance, VkDebugUtilsMessengerEXT messenger, ref VkAllocationCallbacks pAllocator)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkDestroyDebugUtilsMessengerEXT(VkInstance instance, VkDebugUtilsMessengerEXT messenger, IntPtr pAllocator)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkQueueBeginDebugUtilsLabelEXT(VkQueue queue, VkDebugUtilsLabelEXT* pLabelInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkQueueBeginDebugUtilsLabelEXT(VkQueue queue, ref VkDebugUtilsLabelEXT pLabelInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkQueueBeginDebugUtilsLabelEXT(VkQueue queue, IntPtr pLabelInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkQueueEndDebugUtilsLabelEXT(VkQueue queue)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkQueueInsertDebugUtilsLabelEXT(VkQueue queue, VkDebugUtilsLabelEXT* pLabelInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkQueueInsertDebugUtilsLabelEXT(VkQueue queue, ref VkDebugUtilsLabelEXT pLabelInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkQueueInsertDebugUtilsLabelEXT(VkQueue queue, IntPtr pLabelInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkSetDebugUtilsObjectNameEXT(VkDevice device, VkDebugUtilsObjectNameInfoEXT* pNameInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkSetDebugUtilsObjectNameEXT(VkDevice device, ref VkDebugUtilsObjectNameInfoEXT pNameInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkSetDebugUtilsObjectNameEXT(VkDevice device, IntPtr pNameInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkSetDebugUtilsObjectTagEXT(VkDevice device, VkDebugUtilsObjectTagInfoEXT* pTagInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkSetDebugUtilsObjectTagEXT(VkDevice device, ref VkDebugUtilsObjectTagInfoEXT pTagInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkSetDebugUtilsObjectTagEXT(VkDevice device, IntPtr pTagInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkSubmitDebugUtilsMessageEXT(VkInstance instance, VkDebugUtilsMessageSeverityFlagsEXT messageSeverity, VkDebugUtilsMessageTypeFlagsEXT messageTypes, VkDebugUtilsMessengerCallbackDataEXT* pCallbackData)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkSubmitDebugUtilsMessageEXT(VkInstance instance, VkDebugUtilsMessageSeverityFlagsEXT messageSeverity, VkDebugUtilsMessageTypeFlagsEXT messageTypes, ref VkDebugUtilsMessengerCallbackDataEXT pCallbackData)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkSubmitDebugUtilsMessageEXT(VkInstance instance, VkDebugUtilsMessageSeverityFlagsEXT messageSeverity, VkDebugUtilsMessageTypeFlagsEXT messageTypes, IntPtr pCallbackData)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanEXTDebugUtils(VkInstance instance)
        {
            vkCmdBeginDebugUtilsLabelEXT_ptr = VulkanNative.LoadInstanceProcAddr(instance, "vkCmdBeginDebugUtilsLabelEXT", true);
            vkCmdEndDebugUtilsLabelEXT_ptr = VulkanNative.LoadInstanceProcAddr(instance, "vkCmdEndDebugUtilsLabelEXT", true);
            vkCmdInsertDebugUtilsLabelEXT_ptr = VulkanNative.LoadInstanceProcAddr(instance, "vkCmdInsertDebugUtilsLabelEXT", true);
            vkCreateDebugUtilsMessengerEXT_ptr = VulkanNative.LoadInstanceProcAddr(instance, "vkCreateDebugUtilsMessengerEXT", true);
            vkDestroyDebugUtilsMessengerEXT_ptr = VulkanNative.LoadInstanceProcAddr(instance, "vkDestroyDebugUtilsMessengerEXT", true);
            vkQueueBeginDebugUtilsLabelEXT_ptr = VulkanNative.LoadInstanceProcAddr(instance, "vkQueueBeginDebugUtilsLabelEXT", true);
            vkQueueEndDebugUtilsLabelEXT_ptr = VulkanNative.LoadInstanceProcAddr(instance, "vkQueueEndDebugUtilsLabelEXT", true);
            vkQueueInsertDebugUtilsLabelEXT_ptr = VulkanNative.LoadInstanceProcAddr(instance, "vkQueueInsertDebugUtilsLabelEXT", true);
            vkSetDebugUtilsObjectNameEXT_ptr = VulkanNative.LoadInstanceProcAddr(instance, "vkSetDebugUtilsObjectNameEXT", true);
            vkSetDebugUtilsObjectTagEXT_ptr = VulkanNative.LoadInstanceProcAddr(instance, "vkSetDebugUtilsObjectTagEXT", true);
            vkSubmitDebugUtilsMessageEXT_ptr = VulkanNative.LoadInstanceProcAddr(instance, "vkSubmitDebugUtilsMessageEXT", true);
        }
    }

    public unsafe sealed class VulkanAndroidExternalMemoryAndroidHardwareBuffer : IVulkanDeviceExtGeneric<VulkanAndroidExternalMemoryAndroidHardwareBuffer>
    {
        public static string Name => "VK_ANDROID_external_memory_android_hardware_buffer";
        string IVulkanExt.GetName() => Name;

        public static VulkanAndroidExternalMemoryAndroidHardwareBuffer Create(VkDevice device)
        {
            return new VulkanAndroidExternalMemoryAndroidHardwareBuffer(device);
        }

        private IntPtr vkGetAndroidHardwareBufferPropertiesANDROID_ptr;
        private IntPtr vkGetMemoryAndroidHardwareBufferANDROID_ptr;

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetAndroidHardwareBufferPropertiesANDROID(VkDevice device, Android.AHardwareBuffer* buffer, VkAndroidHardwareBufferPropertiesANDROID* pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetAndroidHardwareBufferPropertiesANDROID(VkDevice device, Android.AHardwareBuffer* buffer, out VkAndroidHardwareBufferPropertiesANDROID pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetAndroidHardwareBufferPropertiesANDROID(VkDevice device, ref Android.AHardwareBuffer buffer, VkAndroidHardwareBufferPropertiesANDROID* pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetAndroidHardwareBufferPropertiesANDROID(VkDevice device, ref Android.AHardwareBuffer buffer, out VkAndroidHardwareBufferPropertiesANDROID pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetAndroidHardwareBufferPropertiesANDROID(VkDevice device, IntPtr buffer, VkAndroidHardwareBufferPropertiesANDROID* pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetAndroidHardwareBufferPropertiesANDROID(VkDevice device, IntPtr buffer, out VkAndroidHardwareBufferPropertiesANDROID pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetMemoryAndroidHardwareBufferANDROID(VkDevice device, VkMemoryGetAndroidHardwareBufferInfoANDROID* pInfo, Android.AHardwareBuffer** pBuffer)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetMemoryAndroidHardwareBufferANDROID(VkDevice device, VkMemoryGetAndroidHardwareBufferInfoANDROID* pInfo, out Android.AHardwareBuffer* pBuffer)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetMemoryAndroidHardwareBufferANDROID(VkDevice device, ref VkMemoryGetAndroidHardwareBufferInfoANDROID pInfo, Android.AHardwareBuffer** pBuffer)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetMemoryAndroidHardwareBufferANDROID(VkDevice device, ref VkMemoryGetAndroidHardwareBufferInfoANDROID pInfo, out Android.AHardwareBuffer* pBuffer)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetMemoryAndroidHardwareBufferANDROID(VkDevice device, IntPtr pInfo, Android.AHardwareBuffer** pBuffer)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetMemoryAndroidHardwareBufferANDROID(VkDevice device, IntPtr pInfo, out Android.AHardwareBuffer* pBuffer)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanAndroidExternalMemoryAndroidHardwareBuffer(VkDevice device)
        {
            vkGetAndroidHardwareBufferPropertiesANDROID_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetAndroidHardwareBufferPropertiesANDROID", true);
            vkGetMemoryAndroidHardwareBufferANDROID_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetMemoryAndroidHardwareBufferANDROID", true);
        }
    }

    public unsafe sealed class VulkanEXTSampleLocations : IVulkanDeviceExtGeneric<VulkanEXTSampleLocations>
    {
        public static string Name => "VK_EXT_sample_locations";
        string IVulkanExt.GetName() => Name;

        public static VulkanEXTSampleLocations Create(VkDevice device)
        {
            return new VulkanEXTSampleLocations(device);
        }

        private IntPtr vkCmdSetSampleLocationsEXT_ptr;
        private IntPtr vkGetPhysicalDeviceMultisamplePropertiesEXT_ptr;

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetSampleLocationsEXT(VkCommandBuffer commandBuffer, VkSampleLocationsInfoEXT* pSampleLocationsInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetSampleLocationsEXT(VkCommandBuffer commandBuffer, ref VkSampleLocationsInfoEXT pSampleLocationsInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetSampleLocationsEXT(VkCommandBuffer commandBuffer, IntPtr pSampleLocationsInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetPhysicalDeviceMultisamplePropertiesEXT(VkPhysicalDevice physicalDevice, VkSampleCountFlags samples, VkMultisamplePropertiesEXT* pMultisampleProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetPhysicalDeviceMultisamplePropertiesEXT(VkPhysicalDevice physicalDevice, VkSampleCountFlags samples, out VkMultisamplePropertiesEXT pMultisampleProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanEXTSampleLocations(VkDevice device)
        {
            vkCmdSetSampleLocationsEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdSetSampleLocationsEXT", true);
            vkGetPhysicalDeviceMultisamplePropertiesEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetPhysicalDeviceMultisamplePropertiesEXT", true);
        }
    }

    public unsafe sealed class VulkanKHRGetMemoryRequirements2 : IVulkanDeviceExtGeneric<VulkanKHRGetMemoryRequirements2>
    {
        public static string Name => "VK_KHR_get_memory_requirements2";
        string IVulkanExt.GetName() => Name;

        public static VulkanKHRGetMemoryRequirements2 Create(VkDevice device)
        {
            return new VulkanKHRGetMemoryRequirements2(device);
        }



        public VulkanKHRGetMemoryRequirements2(VkDevice device)
        {
        }
    }

    public unsafe sealed class VulkanKHRAccelerationStructure : IVulkanDeviceExtGeneric<VulkanKHRAccelerationStructure>
    {
        public static string Name => "VK_KHR_acceleration_structure";
        string IVulkanExt.GetName() => Name;

        public static VulkanKHRAccelerationStructure Create(VkDevice device)
        {
            return new VulkanKHRAccelerationStructure(device);
        }

        private IntPtr vkBuildAccelerationStructuresKHR_ptr;
        private IntPtr vkCmdBuildAccelerationStructuresIndirectKHR_ptr;
        private IntPtr vkCmdBuildAccelerationStructuresKHR_ptr;
        private IntPtr vkCmdCopyAccelerationStructureKHR_ptr;
        private IntPtr vkCmdCopyAccelerationStructureToMemoryKHR_ptr;
        private IntPtr vkCmdCopyMemoryToAccelerationStructureKHR_ptr;
        private IntPtr vkCmdWriteAccelerationStructuresPropertiesKHR_ptr;
        private IntPtr vkCopyAccelerationStructureKHR_ptr;
        private IntPtr vkCopyAccelerationStructureToMemoryKHR_ptr;
        private IntPtr vkCopyMemoryToAccelerationStructureKHR_ptr;
        private IntPtr vkCreateAccelerationStructureKHR_ptr;
        private IntPtr vkDestroyAccelerationStructureKHR_ptr;
        private IntPtr vkGetAccelerationStructureBuildSizesKHR_ptr;
        private IntPtr vkGetAccelerationStructureDeviceAddressKHR_ptr;
        private IntPtr vkGetDeviceAccelerationStructureCompatibilityKHR_ptr;
        private IntPtr vkWriteAccelerationStructuresPropertiesKHR_ptr;

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkBuildAccelerationStructuresKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, VkAccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkBuildAccelerationStructuresKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, ref VkAccelerationStructureBuildRangeInfoKHR* ppBuildRangeInfos)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkBuildAccelerationStructuresKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, IntPtr ppBuildRangeInfos)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkBuildAccelerationStructuresKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, VkAccelerationStructureBuildRangeInfoKHR*[] ppBuildRangeInfos)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkBuildAccelerationStructuresKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, VkAccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkBuildAccelerationStructuresKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, ref VkAccelerationStructureBuildRangeInfoKHR* ppBuildRangeInfos)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkBuildAccelerationStructuresKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, IntPtr ppBuildRangeInfos)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkBuildAccelerationStructuresKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, VkAccelerationStructureBuildRangeInfoKHR*[] ppBuildRangeInfos)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkBuildAccelerationStructuresKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, IntPtr pInfos, VkAccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkBuildAccelerationStructuresKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, IntPtr pInfos, ref VkAccelerationStructureBuildRangeInfoKHR* ppBuildRangeInfos)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkBuildAccelerationStructuresKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, IntPtr pInfos, IntPtr ppBuildRangeInfos)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkBuildAccelerationStructuresKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, IntPtr pInfos, VkAccelerationStructureBuildRangeInfoKHR*[] ppBuildRangeInfos)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkBuildAccelerationStructuresKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, VkAccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkBuildAccelerationStructuresKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, ref VkAccelerationStructureBuildRangeInfoKHR* ppBuildRangeInfos)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkBuildAccelerationStructuresKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, IntPtr ppBuildRangeInfos)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkBuildAccelerationStructuresKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, VkAccelerationStructureBuildRangeInfoKHR*[] ppBuildRangeInfos)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, ulong* pIndirectDeviceAddresses, uint* pIndirectStrides, uint** ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, ulong* pIndirectDeviceAddresses, uint* pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, ulong* pIndirectDeviceAddresses, uint* pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, ulong* pIndirectDeviceAddresses, ref uint pIndirectStrides, uint** ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, ulong* pIndirectDeviceAddresses, ref uint pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, ulong* pIndirectDeviceAddresses, ref uint pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, ulong* pIndirectDeviceAddresses, IntPtr pIndirectStrides, uint** ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, ulong* pIndirectDeviceAddresses, IntPtr pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, ulong* pIndirectDeviceAddresses, IntPtr pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, ref ulong pIndirectDeviceAddresses, uint* pIndirectStrides, uint** ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, ref ulong pIndirectDeviceAddresses, uint* pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, ref ulong pIndirectDeviceAddresses, uint* pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, ref ulong pIndirectDeviceAddresses, ref uint pIndirectStrides, uint** ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, ref ulong pIndirectDeviceAddresses, ref uint pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, ref ulong pIndirectDeviceAddresses, ref uint pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, ref ulong pIndirectDeviceAddresses, IntPtr pIndirectStrides, uint** ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, ref ulong pIndirectDeviceAddresses, IntPtr pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, ref ulong pIndirectDeviceAddresses, IntPtr pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, IntPtr pIndirectDeviceAddresses, uint* pIndirectStrides, uint** ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, IntPtr pIndirectDeviceAddresses, uint* pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, IntPtr pIndirectDeviceAddresses, uint* pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, IntPtr pIndirectDeviceAddresses, ref uint pIndirectStrides, uint** ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, IntPtr pIndirectDeviceAddresses, ref uint pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, IntPtr pIndirectDeviceAddresses, ref uint pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, IntPtr pIndirectDeviceAddresses, IntPtr pIndirectStrides, uint** ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, IntPtr pIndirectDeviceAddresses, IntPtr pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, IntPtr pIndirectDeviceAddresses, IntPtr pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, ulong* pIndirectDeviceAddresses, uint* pIndirectStrides, uint** ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, ulong* pIndirectDeviceAddresses, uint* pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, ulong* pIndirectDeviceAddresses, uint* pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, ulong* pIndirectDeviceAddresses, ref uint pIndirectStrides, uint** ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, ulong* pIndirectDeviceAddresses, ref uint pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, ulong* pIndirectDeviceAddresses, ref uint pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, ulong* pIndirectDeviceAddresses, IntPtr pIndirectStrides, uint** ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, ulong* pIndirectDeviceAddresses, IntPtr pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, ulong* pIndirectDeviceAddresses, IntPtr pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, ref ulong pIndirectDeviceAddresses, uint* pIndirectStrides, uint** ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, ref ulong pIndirectDeviceAddresses, uint* pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, ref ulong pIndirectDeviceAddresses, uint* pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, ref ulong pIndirectDeviceAddresses, ref uint pIndirectStrides, uint** ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, ref ulong pIndirectDeviceAddresses, ref uint pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, ref ulong pIndirectDeviceAddresses, ref uint pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, ref ulong pIndirectDeviceAddresses, IntPtr pIndirectStrides, uint** ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, ref ulong pIndirectDeviceAddresses, IntPtr pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, ref ulong pIndirectDeviceAddresses, IntPtr pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, IntPtr pIndirectDeviceAddresses, uint* pIndirectStrides, uint** ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, IntPtr pIndirectDeviceAddresses, uint* pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, IntPtr pIndirectDeviceAddresses, uint* pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, IntPtr pIndirectDeviceAddresses, ref uint pIndirectStrides, uint** ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, IntPtr pIndirectDeviceAddresses, ref uint pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, IntPtr pIndirectDeviceAddresses, ref uint pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, IntPtr pIndirectDeviceAddresses, IntPtr pIndirectStrides, uint** ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, IntPtr pIndirectDeviceAddresses, IntPtr pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, IntPtr pIndirectDeviceAddresses, IntPtr pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, ulong* pIndirectDeviceAddresses, uint* pIndirectStrides, uint** ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, ulong* pIndirectDeviceAddresses, uint* pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, ulong* pIndirectDeviceAddresses, uint* pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, ulong* pIndirectDeviceAddresses, ref uint pIndirectStrides, uint** ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, ulong* pIndirectDeviceAddresses, ref uint pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, ulong* pIndirectDeviceAddresses, ref uint pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, ulong* pIndirectDeviceAddresses, IntPtr pIndirectStrides, uint** ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, ulong* pIndirectDeviceAddresses, IntPtr pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, ulong* pIndirectDeviceAddresses, IntPtr pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, ref ulong pIndirectDeviceAddresses, uint* pIndirectStrides, uint** ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, ref ulong pIndirectDeviceAddresses, uint* pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, ref ulong pIndirectDeviceAddresses, uint* pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, ref ulong pIndirectDeviceAddresses, ref uint pIndirectStrides, uint** ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, ref ulong pIndirectDeviceAddresses, ref uint pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, ref ulong pIndirectDeviceAddresses, ref uint pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, ref ulong pIndirectDeviceAddresses, IntPtr pIndirectStrides, uint** ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, ref ulong pIndirectDeviceAddresses, IntPtr pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, ref ulong pIndirectDeviceAddresses, IntPtr pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, IntPtr pIndirectDeviceAddresses, uint* pIndirectStrides, uint** ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, IntPtr pIndirectDeviceAddresses, uint* pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, IntPtr pIndirectDeviceAddresses, uint* pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, IntPtr pIndirectDeviceAddresses, ref uint pIndirectStrides, uint** ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, IntPtr pIndirectDeviceAddresses, ref uint pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, IntPtr pIndirectDeviceAddresses, ref uint pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, IntPtr pIndirectDeviceAddresses, IntPtr pIndirectStrides, uint** ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, IntPtr pIndirectDeviceAddresses, IntPtr pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, IntPtr pIndirectDeviceAddresses, IntPtr pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, ulong* pIndirectDeviceAddresses, uint* pIndirectStrides, uint** ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, ulong* pIndirectDeviceAddresses, uint* pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, ulong* pIndirectDeviceAddresses, uint* pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, ulong* pIndirectDeviceAddresses, ref uint pIndirectStrides, uint** ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, ulong* pIndirectDeviceAddresses, ref uint pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, ulong* pIndirectDeviceAddresses, ref uint pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, ulong* pIndirectDeviceAddresses, IntPtr pIndirectStrides, uint** ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, ulong* pIndirectDeviceAddresses, IntPtr pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, ulong* pIndirectDeviceAddresses, IntPtr pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, ref ulong pIndirectDeviceAddresses, uint* pIndirectStrides, uint** ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, ref ulong pIndirectDeviceAddresses, uint* pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, ref ulong pIndirectDeviceAddresses, uint* pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, ref ulong pIndirectDeviceAddresses, ref uint pIndirectStrides, uint** ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, ref ulong pIndirectDeviceAddresses, ref uint pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, ref ulong pIndirectDeviceAddresses, ref uint pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, ref ulong pIndirectDeviceAddresses, IntPtr pIndirectStrides, uint** ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, ref ulong pIndirectDeviceAddresses, IntPtr pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, ref ulong pIndirectDeviceAddresses, IntPtr pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, IntPtr pIndirectDeviceAddresses, uint* pIndirectStrides, uint** ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, IntPtr pIndirectDeviceAddresses, uint* pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, IntPtr pIndirectDeviceAddresses, uint* pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, IntPtr pIndirectDeviceAddresses, ref uint pIndirectStrides, uint** ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, IntPtr pIndirectDeviceAddresses, ref uint pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, IntPtr pIndirectDeviceAddresses, ref uint pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, IntPtr pIndirectDeviceAddresses, IntPtr pIndirectStrides, uint** ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, IntPtr pIndirectDeviceAddresses, IntPtr pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, IntPtr pIndirectDeviceAddresses, IntPtr pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, VkAccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, ref VkAccelerationStructureBuildRangeInfoKHR* ppBuildRangeInfos)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, IntPtr ppBuildRangeInfos)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, VkAccelerationStructureBuildRangeInfoKHR*[] ppBuildRangeInfos)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, VkAccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, ref VkAccelerationStructureBuildRangeInfoKHR* ppBuildRangeInfos)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, IntPtr ppBuildRangeInfos)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, VkAccelerationStructureBuildRangeInfoKHR*[] ppBuildRangeInfos)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, VkAccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, ref VkAccelerationStructureBuildRangeInfoKHR* ppBuildRangeInfos)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, IntPtr ppBuildRangeInfos)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, VkAccelerationStructureBuildRangeInfoKHR*[] ppBuildRangeInfos)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, VkAccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, ref VkAccelerationStructureBuildRangeInfoKHR* ppBuildRangeInfos)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, IntPtr ppBuildRangeInfos)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructuresKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, VkAccelerationStructureBuildRangeInfoKHR*[] ppBuildRangeInfos)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdCopyAccelerationStructureKHR(VkCommandBuffer commandBuffer, VkCopyAccelerationStructureInfoKHR* pInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdCopyAccelerationStructureKHR(VkCommandBuffer commandBuffer, ref VkCopyAccelerationStructureInfoKHR pInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdCopyAccelerationStructureKHR(VkCommandBuffer commandBuffer, IntPtr pInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdCopyAccelerationStructureToMemoryKHR(VkCommandBuffer commandBuffer, VkCopyAccelerationStructureToMemoryInfoKHR* pInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdCopyAccelerationStructureToMemoryKHR(VkCommandBuffer commandBuffer, ref VkCopyAccelerationStructureToMemoryInfoKHR pInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdCopyAccelerationStructureToMemoryKHR(VkCommandBuffer commandBuffer, IntPtr pInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdCopyMemoryToAccelerationStructureKHR(VkCommandBuffer commandBuffer, VkCopyMemoryToAccelerationStructureInfoKHR* pInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdCopyMemoryToAccelerationStructureKHR(VkCommandBuffer commandBuffer, ref VkCopyMemoryToAccelerationStructureInfoKHR pInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdCopyMemoryToAccelerationStructureKHR(VkCommandBuffer commandBuffer, IntPtr pInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdWriteAccelerationStructuresPropertiesKHR(VkCommandBuffer commandBuffer, uint accelerationStructureCount, VkAccelerationStructureKHR* pAccelerationStructures, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdWriteAccelerationStructuresPropertiesKHR(VkCommandBuffer commandBuffer, uint accelerationStructureCount, ref VkAccelerationStructureKHR pAccelerationStructures, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdWriteAccelerationStructuresPropertiesKHR(VkCommandBuffer commandBuffer, uint accelerationStructureCount, IntPtr pAccelerationStructures, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCopyAccelerationStructureKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyAccelerationStructureInfoKHR* pInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCopyAccelerationStructureKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, ref VkCopyAccelerationStructureInfoKHR pInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCopyAccelerationStructureKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, IntPtr pInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCopyAccelerationStructureToMemoryKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyAccelerationStructureToMemoryInfoKHR* pInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCopyAccelerationStructureToMemoryKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, ref VkCopyAccelerationStructureToMemoryInfoKHR pInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCopyAccelerationStructureToMemoryKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, IntPtr pInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCopyMemoryToAccelerationStructureKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyMemoryToAccelerationStructureInfoKHR* pInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCopyMemoryToAccelerationStructureKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, ref VkCopyMemoryToAccelerationStructureInfoKHR pInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCopyMemoryToAccelerationStructureKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, IntPtr pInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateAccelerationStructureKHR(VkDevice device, VkAccelerationStructureCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkAccelerationStructureKHR* pAccelerationStructure)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateAccelerationStructureKHR(VkDevice device, VkAccelerationStructureCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkAccelerationStructureKHR pAccelerationStructure)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateAccelerationStructureKHR(VkDevice device, VkAccelerationStructureCreateInfoKHR* pCreateInfo, ref VkAllocationCallbacks pAllocator, VkAccelerationStructureKHR* pAccelerationStructure)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateAccelerationStructureKHR(VkDevice device, VkAccelerationStructureCreateInfoKHR* pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkAccelerationStructureKHR pAccelerationStructure)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateAccelerationStructureKHR(VkDevice device, VkAccelerationStructureCreateInfoKHR* pCreateInfo, IntPtr pAllocator, VkAccelerationStructureKHR* pAccelerationStructure)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateAccelerationStructureKHR(VkDevice device, VkAccelerationStructureCreateInfoKHR* pCreateInfo, IntPtr pAllocator, out VkAccelerationStructureKHR pAccelerationStructure)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateAccelerationStructureKHR(VkDevice device, ref VkAccelerationStructureCreateInfoKHR pCreateInfo, VkAllocationCallbacks* pAllocator, VkAccelerationStructureKHR* pAccelerationStructure)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateAccelerationStructureKHR(VkDevice device, ref VkAccelerationStructureCreateInfoKHR pCreateInfo, VkAllocationCallbacks* pAllocator, out VkAccelerationStructureKHR pAccelerationStructure)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateAccelerationStructureKHR(VkDevice device, ref VkAccelerationStructureCreateInfoKHR pCreateInfo, ref VkAllocationCallbacks pAllocator, VkAccelerationStructureKHR* pAccelerationStructure)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateAccelerationStructureKHR(VkDevice device, ref VkAccelerationStructureCreateInfoKHR pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkAccelerationStructureKHR pAccelerationStructure)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateAccelerationStructureKHR(VkDevice device, ref VkAccelerationStructureCreateInfoKHR pCreateInfo, IntPtr pAllocator, VkAccelerationStructureKHR* pAccelerationStructure)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateAccelerationStructureKHR(VkDevice device, ref VkAccelerationStructureCreateInfoKHR pCreateInfo, IntPtr pAllocator, out VkAccelerationStructureKHR pAccelerationStructure)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateAccelerationStructureKHR(VkDevice device, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, VkAccelerationStructureKHR* pAccelerationStructure)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateAccelerationStructureKHR(VkDevice device, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, out VkAccelerationStructureKHR pAccelerationStructure)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateAccelerationStructureKHR(VkDevice device, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, VkAccelerationStructureKHR* pAccelerationStructure)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateAccelerationStructureKHR(VkDevice device, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkAccelerationStructureKHR pAccelerationStructure)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateAccelerationStructureKHR(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, VkAccelerationStructureKHR* pAccelerationStructure)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateAccelerationStructureKHR(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, out VkAccelerationStructureKHR pAccelerationStructure)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkDestroyAccelerationStructureKHR(VkDevice device, VkAccelerationStructureKHR accelerationStructure, VkAllocationCallbacks* pAllocator)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkDestroyAccelerationStructureKHR(VkDevice device, VkAccelerationStructureKHR accelerationStructure, ref VkAllocationCallbacks pAllocator)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkDestroyAccelerationStructureKHR(VkDevice device, VkAccelerationStructureKHR accelerationStructure, IntPtr pAllocator)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetAccelerationStructureBuildSizesKHR(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, VkAccelerationStructureBuildGeometryInfoKHR* pBuildInfo, uint* pMaxPrimitiveCounts, VkAccelerationStructureBuildSizesInfoKHR* pSizeInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetAccelerationStructureBuildSizesKHR(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, VkAccelerationStructureBuildGeometryInfoKHR* pBuildInfo, uint* pMaxPrimitiveCounts, out VkAccelerationStructureBuildSizesInfoKHR pSizeInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetAccelerationStructureBuildSizesKHR(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, VkAccelerationStructureBuildGeometryInfoKHR* pBuildInfo, ref uint pMaxPrimitiveCounts, VkAccelerationStructureBuildSizesInfoKHR* pSizeInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetAccelerationStructureBuildSizesKHR(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, VkAccelerationStructureBuildGeometryInfoKHR* pBuildInfo, ref uint pMaxPrimitiveCounts, out VkAccelerationStructureBuildSizesInfoKHR pSizeInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetAccelerationStructureBuildSizesKHR(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, VkAccelerationStructureBuildGeometryInfoKHR* pBuildInfo, IntPtr pMaxPrimitiveCounts, VkAccelerationStructureBuildSizesInfoKHR* pSizeInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetAccelerationStructureBuildSizesKHR(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, VkAccelerationStructureBuildGeometryInfoKHR* pBuildInfo, IntPtr pMaxPrimitiveCounts, out VkAccelerationStructureBuildSizesInfoKHR pSizeInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetAccelerationStructureBuildSizesKHR(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, ref VkAccelerationStructureBuildGeometryInfoKHR pBuildInfo, uint* pMaxPrimitiveCounts, VkAccelerationStructureBuildSizesInfoKHR* pSizeInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetAccelerationStructureBuildSizesKHR(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, ref VkAccelerationStructureBuildGeometryInfoKHR pBuildInfo, uint* pMaxPrimitiveCounts, out VkAccelerationStructureBuildSizesInfoKHR pSizeInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetAccelerationStructureBuildSizesKHR(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, ref VkAccelerationStructureBuildGeometryInfoKHR pBuildInfo, ref uint pMaxPrimitiveCounts, VkAccelerationStructureBuildSizesInfoKHR* pSizeInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetAccelerationStructureBuildSizesKHR(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, ref VkAccelerationStructureBuildGeometryInfoKHR pBuildInfo, ref uint pMaxPrimitiveCounts, out VkAccelerationStructureBuildSizesInfoKHR pSizeInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetAccelerationStructureBuildSizesKHR(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, ref VkAccelerationStructureBuildGeometryInfoKHR pBuildInfo, IntPtr pMaxPrimitiveCounts, VkAccelerationStructureBuildSizesInfoKHR* pSizeInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetAccelerationStructureBuildSizesKHR(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, ref VkAccelerationStructureBuildGeometryInfoKHR pBuildInfo, IntPtr pMaxPrimitiveCounts, out VkAccelerationStructureBuildSizesInfoKHR pSizeInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetAccelerationStructureBuildSizesKHR(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, IntPtr pBuildInfo, uint* pMaxPrimitiveCounts, VkAccelerationStructureBuildSizesInfoKHR* pSizeInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetAccelerationStructureBuildSizesKHR(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, IntPtr pBuildInfo, uint* pMaxPrimitiveCounts, out VkAccelerationStructureBuildSizesInfoKHR pSizeInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetAccelerationStructureBuildSizesKHR(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, IntPtr pBuildInfo, ref uint pMaxPrimitiveCounts, VkAccelerationStructureBuildSizesInfoKHR* pSizeInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetAccelerationStructureBuildSizesKHR(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, IntPtr pBuildInfo, ref uint pMaxPrimitiveCounts, out VkAccelerationStructureBuildSizesInfoKHR pSizeInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetAccelerationStructureBuildSizesKHR(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, IntPtr pBuildInfo, IntPtr pMaxPrimitiveCounts, VkAccelerationStructureBuildSizesInfoKHR* pSizeInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetAccelerationStructureBuildSizesKHR(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, IntPtr pBuildInfo, IntPtr pMaxPrimitiveCounts, out VkAccelerationStructureBuildSizesInfoKHR pSizeInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe ulong vkGetAccelerationStructureDeviceAddressKHR(VkDevice device, VkAccelerationStructureDeviceAddressInfoKHR* pInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe ulong vkGetAccelerationStructureDeviceAddressKHR(VkDevice device, out VkAccelerationStructureDeviceAddressInfoKHR pInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetDeviceAccelerationStructureCompatibilityKHR(VkDevice device, VkAccelerationStructureVersionInfoKHR* pVersionInfo, VkAccelerationStructureCompatibilityKHR* pCompatibility)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetDeviceAccelerationStructureCompatibilityKHR(VkDevice device, VkAccelerationStructureVersionInfoKHR* pVersionInfo, out VkAccelerationStructureCompatibilityKHR pCompatibility)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetDeviceAccelerationStructureCompatibilityKHR(VkDevice device, ref VkAccelerationStructureVersionInfoKHR pVersionInfo, VkAccelerationStructureCompatibilityKHR* pCompatibility)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetDeviceAccelerationStructureCompatibilityKHR(VkDevice device, ref VkAccelerationStructureVersionInfoKHR pVersionInfo, out VkAccelerationStructureCompatibilityKHR pCompatibility)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetDeviceAccelerationStructureCompatibilityKHR(VkDevice device, IntPtr pVersionInfo, VkAccelerationStructureCompatibilityKHR* pCompatibility)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetDeviceAccelerationStructureCompatibilityKHR(VkDevice device, IntPtr pVersionInfo, out VkAccelerationStructureCompatibilityKHR pCompatibility)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkWriteAccelerationStructuresPropertiesKHR(VkDevice device, uint accelerationStructureCount, VkAccelerationStructureKHR* pAccelerationStructures, VkQueryType queryType, UIntPtr dataSize, void* pData, UIntPtr stride)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkWriteAccelerationStructuresPropertiesKHR(VkDevice device, uint accelerationStructureCount, ref VkAccelerationStructureKHR pAccelerationStructures, VkQueryType queryType, UIntPtr dataSize, void* pData, UIntPtr stride)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkWriteAccelerationStructuresPropertiesKHR(VkDevice device, uint accelerationStructureCount, IntPtr pAccelerationStructures, VkQueryType queryType, UIntPtr dataSize, void* pData, UIntPtr stride)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanKHRAccelerationStructure(VkDevice device)
        {
            vkBuildAccelerationStructuresKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkBuildAccelerationStructuresKHR", true);
            vkCmdBuildAccelerationStructuresIndirectKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdBuildAccelerationStructuresIndirectKHR", true);
            vkCmdBuildAccelerationStructuresKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdBuildAccelerationStructuresKHR", true);
            vkCmdCopyAccelerationStructureKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdCopyAccelerationStructureKHR", true);
            vkCmdCopyAccelerationStructureToMemoryKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdCopyAccelerationStructureToMemoryKHR", true);
            vkCmdCopyMemoryToAccelerationStructureKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdCopyMemoryToAccelerationStructureKHR", true);
            vkCmdWriteAccelerationStructuresPropertiesKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdWriteAccelerationStructuresPropertiesKHR", true);
            vkCopyAccelerationStructureKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCopyAccelerationStructureKHR", true);
            vkCopyAccelerationStructureToMemoryKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCopyAccelerationStructureToMemoryKHR", true);
            vkCopyMemoryToAccelerationStructureKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCopyMemoryToAccelerationStructureKHR", true);
            vkCreateAccelerationStructureKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCreateAccelerationStructureKHR", true);
            vkDestroyAccelerationStructureKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkDestroyAccelerationStructureKHR", true);
            vkGetAccelerationStructureBuildSizesKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetAccelerationStructureBuildSizesKHR", true);
            vkGetAccelerationStructureDeviceAddressKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetAccelerationStructureDeviceAddressKHR", true);
            vkGetDeviceAccelerationStructureCompatibilityKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetDeviceAccelerationStructureCompatibilityKHR", true);
            vkWriteAccelerationStructuresPropertiesKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkWriteAccelerationStructuresPropertiesKHR", true);
        }
    }

    public unsafe sealed class VulkanKHRRayTracingPipeline : IVulkanDeviceExtGeneric<VulkanKHRRayTracingPipeline>
    {
        public static string Name => "VK_KHR_ray_tracing_pipeline";
        string IVulkanExt.GetName() => Name;

        public static VulkanKHRRayTracingPipeline Create(VkDevice device)
        {
            return new VulkanKHRRayTracingPipeline(device);
        }

        private IntPtr vkCmdSetRayTracingPipelineStackSizeKHR_ptr;
        private IntPtr vkCmdTraceRaysIndirectKHR_ptr;
        private IntPtr vkCmdTraceRaysKHR_ptr;
        private IntPtr vkCreateRayTracingPipelinesKHR_ptr;
        private IntPtr vkGetRayTracingCaptureReplayShaderGroupHandlesKHR_ptr;
        private IntPtr vkGetRayTracingShaderGroupHandlesKHR_ptr;
        private IntPtr vkGetRayTracingShaderGroupStackSizeKHR_ptr;

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetRayTracingPipelineStackSizeKHR(VkCommandBuffer commandBuffer, uint pipelineStackSize)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, IntPtr pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, IntPtr pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, IntPtr pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, IntPtr pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, IntPtr pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, IntPtr pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, IntPtr pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, IntPtr pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, IntPtr pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, IntPtr pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, IntPtr pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, IntPtr pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, IntPtr pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, IntPtr pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, IntPtr pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, IntPtr pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, IntPtr pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, IntPtr pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, IntPtr pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, IntPtr pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, IntPtr pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, IntPtr pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, IntPtr pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, IntPtr pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, IntPtr pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, IntPtr pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, IntPtr pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, IntPtr pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, IntPtr pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, IntPtr pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, IntPtr pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, IntPtr pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, IntPtr pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, IntPtr pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, IntPtr pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, IntPtr pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, IntPtr pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, IntPtr pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, IntPtr pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, IntPtr pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, IntPtr pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, IntPtr pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, IntPtr pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, IntPtr pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, IntPtr pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, IntPtr pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, IntPtr pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, IntPtr pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, IntPtr pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, IntPtr pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, IntPtr pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, IntPtr pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, IntPtr pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, IntPtr pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoKHR* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoKHR* pCreateInfos, VkAllocationCallbacks* pAllocator, out VkPipeline pPipelines)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoKHR* pCreateInfos, ref VkAllocationCallbacks pAllocator, VkPipeline* pPipelines)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoKHR* pCreateInfos, ref VkAllocationCallbacks pAllocator, out VkPipeline pPipelines)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoKHR* pCreateInfos, IntPtr pAllocator, VkPipeline* pPipelines)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoKHR* pCreateInfos, IntPtr pAllocator, out VkPipeline pPipelines)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, ref VkRayTracingPipelineCreateInfoKHR pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, ref VkRayTracingPipelineCreateInfoKHR pCreateInfos, VkAllocationCallbacks* pAllocator, out VkPipeline pPipelines)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, ref VkRayTracingPipelineCreateInfoKHR pCreateInfos, ref VkAllocationCallbacks pAllocator, VkPipeline* pPipelines)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, ref VkRayTracingPipelineCreateInfoKHR pCreateInfos, ref VkAllocationCallbacks pAllocator, out VkPipeline pPipelines)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, ref VkRayTracingPipelineCreateInfoKHR pCreateInfos, IntPtr pAllocator, VkPipeline* pPipelines)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, ref VkRayTracingPipelineCreateInfoKHR pCreateInfos, IntPtr pAllocator, out VkPipeline pPipelines)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, IntPtr pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, IntPtr pCreateInfos, VkAllocationCallbacks* pAllocator, out VkPipeline pPipelines)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, IntPtr pCreateInfos, ref VkAllocationCallbacks pAllocator, VkPipeline* pPipelines)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, IntPtr pCreateInfos, ref VkAllocationCallbacks pAllocator, out VkPipeline pPipelines)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, IntPtr pCreateInfos, IntPtr pAllocator, VkPipeline* pPipelines)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, IntPtr pCreateInfos, IntPtr pAllocator, out VkPipeline pPipelines)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoKHR[] pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoKHR[] pCreateInfos, VkAllocationCallbacks* pAllocator, out VkPipeline pPipelines)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoKHR[] pCreateInfos, ref VkAllocationCallbacks pAllocator, VkPipeline* pPipelines)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoKHR[] pCreateInfos, ref VkAllocationCallbacks pAllocator, out VkPipeline pPipelines)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoKHR[] pCreateInfos, IntPtr pAllocator, VkPipeline* pPipelines)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoKHR[] pCreateInfos, IntPtr pAllocator, out VkPipeline pPipelines)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetRayTracingCaptureReplayShaderGroupHandlesKHR(VkDevice device, VkPipeline pipeline, uint firstGroup, uint groupCount, UIntPtr dataSize, void* pData)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetRayTracingShaderGroupHandlesKHR(VkDevice device, VkPipeline pipeline, uint firstGroup, uint groupCount, UIntPtr dataSize, void* pData)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe ulong vkGetRayTracingShaderGroupStackSizeKHR(VkDevice device, VkPipeline pipeline, uint group, VkShaderGroupShaderKHR groupShader)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanKHRRayTracingPipeline(VkDevice device)
        {
            vkCmdSetRayTracingPipelineStackSizeKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdSetRayTracingPipelineStackSizeKHR", true);
            vkCmdTraceRaysIndirectKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdTraceRaysIndirectKHR", true);
            vkCmdTraceRaysKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdTraceRaysKHR", true);
            vkCreateRayTracingPipelinesKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCreateRayTracingPipelinesKHR", true);
            vkGetRayTracingCaptureReplayShaderGroupHandlesKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetRayTracingCaptureReplayShaderGroupHandlesKHR", true);
            vkGetRayTracingShaderGroupHandlesKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetRayTracingShaderGroupHandlesKHR", true);
            vkGetRayTracingShaderGroupStackSizeKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetRayTracingShaderGroupStackSizeKHR", true);
        }
    }

    public unsafe sealed class VulkanKHRSamplerYcbcrConversion : IVulkanDeviceExtGeneric<VulkanKHRSamplerYcbcrConversion>
    {
        public static string Name => "VK_KHR_sampler_ycbcr_conversion";
        string IVulkanExt.GetName() => Name;

        public static VulkanKHRSamplerYcbcrConversion Create(VkDevice device)
        {
            return new VulkanKHRSamplerYcbcrConversion(device);
        }



        public VulkanKHRSamplerYcbcrConversion(VkDevice device)
        {
        }
    }

    public unsafe sealed class VulkanKHRBindMemory2 : IVulkanDeviceExtGeneric<VulkanKHRBindMemory2>
    {
        public static string Name => "VK_KHR_bind_memory2";
        string IVulkanExt.GetName() => Name;

        public static VulkanKHRBindMemory2 Create(VkDevice device)
        {
            return new VulkanKHRBindMemory2(device);
        }



        public VulkanKHRBindMemory2(VkDevice device)
        {
        }
    }

    public unsafe sealed class VulkanEXTImageDrmFormatModifier : IVulkanDeviceExtGeneric<VulkanEXTImageDrmFormatModifier>
    {
        public static string Name => "VK_EXT_image_drm_format_modifier";
        string IVulkanExt.GetName() => Name;

        public static VulkanEXTImageDrmFormatModifier Create(VkDevice device)
        {
            return new VulkanEXTImageDrmFormatModifier(device);
        }

        private IntPtr vkGetImageDrmFormatModifierPropertiesEXT_ptr;

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetImageDrmFormatModifierPropertiesEXT(VkDevice device, VkImage image, VkImageDrmFormatModifierPropertiesEXT* pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetImageDrmFormatModifierPropertiesEXT(VkDevice device, VkImage image, out VkImageDrmFormatModifierPropertiesEXT pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanEXTImageDrmFormatModifier(VkDevice device)
        {
            vkGetImageDrmFormatModifierPropertiesEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetImageDrmFormatModifierPropertiesEXT", true);
        }
    }

    public unsafe sealed class VulkanEXTValidationCache : IVulkanDeviceExtGeneric<VulkanEXTValidationCache>
    {
        public static string Name => "VK_EXT_validation_cache";
        string IVulkanExt.GetName() => Name;

        public static VulkanEXTValidationCache Create(VkDevice device)
        {
            return new VulkanEXTValidationCache(device);
        }

        private IntPtr vkCreateValidationCacheEXT_ptr;
        private IntPtr vkDestroyValidationCacheEXT_ptr;
        private IntPtr vkGetValidationCacheDataEXT_ptr;
        private IntPtr vkMergeValidationCachesEXT_ptr;

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateValidationCacheEXT(VkDevice device, VkValidationCacheCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkValidationCacheEXT* pValidationCache)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateValidationCacheEXT(VkDevice device, VkValidationCacheCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkValidationCacheEXT pValidationCache)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateValidationCacheEXT(VkDevice device, VkValidationCacheCreateInfoEXT* pCreateInfo, ref VkAllocationCallbacks pAllocator, VkValidationCacheEXT* pValidationCache)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateValidationCacheEXT(VkDevice device, VkValidationCacheCreateInfoEXT* pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkValidationCacheEXT pValidationCache)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateValidationCacheEXT(VkDevice device, VkValidationCacheCreateInfoEXT* pCreateInfo, IntPtr pAllocator, VkValidationCacheEXT* pValidationCache)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateValidationCacheEXT(VkDevice device, VkValidationCacheCreateInfoEXT* pCreateInfo, IntPtr pAllocator, out VkValidationCacheEXT pValidationCache)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateValidationCacheEXT(VkDevice device, ref VkValidationCacheCreateInfoEXT pCreateInfo, VkAllocationCallbacks* pAllocator, VkValidationCacheEXT* pValidationCache)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateValidationCacheEXT(VkDevice device, ref VkValidationCacheCreateInfoEXT pCreateInfo, VkAllocationCallbacks* pAllocator, out VkValidationCacheEXT pValidationCache)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateValidationCacheEXT(VkDevice device, ref VkValidationCacheCreateInfoEXT pCreateInfo, ref VkAllocationCallbacks pAllocator, VkValidationCacheEXT* pValidationCache)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateValidationCacheEXT(VkDevice device, ref VkValidationCacheCreateInfoEXT pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkValidationCacheEXT pValidationCache)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateValidationCacheEXT(VkDevice device, ref VkValidationCacheCreateInfoEXT pCreateInfo, IntPtr pAllocator, VkValidationCacheEXT* pValidationCache)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateValidationCacheEXT(VkDevice device, ref VkValidationCacheCreateInfoEXT pCreateInfo, IntPtr pAllocator, out VkValidationCacheEXT pValidationCache)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateValidationCacheEXT(VkDevice device, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, VkValidationCacheEXT* pValidationCache)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateValidationCacheEXT(VkDevice device, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, out VkValidationCacheEXT pValidationCache)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateValidationCacheEXT(VkDevice device, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, VkValidationCacheEXT* pValidationCache)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateValidationCacheEXT(VkDevice device, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkValidationCacheEXT pValidationCache)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateValidationCacheEXT(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, VkValidationCacheEXT* pValidationCache)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateValidationCacheEXT(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, out VkValidationCacheEXT pValidationCache)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkDestroyValidationCacheEXT(VkDevice device, VkValidationCacheEXT validationCache, VkAllocationCallbacks* pAllocator)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkDestroyValidationCacheEXT(VkDevice device, VkValidationCacheEXT validationCache, ref VkAllocationCallbacks pAllocator)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkDestroyValidationCacheEXT(VkDevice device, VkValidationCacheEXT validationCache, IntPtr pAllocator)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetValidationCacheDataEXT(VkDevice device, VkValidationCacheEXT validationCache, UIntPtr* pDataSize, void* pData)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetValidationCacheDataEXT(VkDevice device, VkValidationCacheEXT validationCache, ref UIntPtr pDataSize, void* pData)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetValidationCacheDataEXT(VkDevice device, VkValidationCacheEXT validationCache, IntPtr pDataSize, void* pData)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkMergeValidationCachesEXT(VkDevice device, VkValidationCacheEXT dstCache, uint srcCacheCount, VkValidationCacheEXT* pSrcCaches)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkMergeValidationCachesEXT(VkDevice device, VkValidationCacheEXT dstCache, uint srcCacheCount, ref VkValidationCacheEXT pSrcCaches)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkMergeValidationCachesEXT(VkDevice device, VkValidationCacheEXT dstCache, uint srcCacheCount, IntPtr pSrcCaches)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanEXTValidationCache(VkDevice device)
        {
            vkCreateValidationCacheEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCreateValidationCacheEXT", true);
            vkDestroyValidationCacheEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkDestroyValidationCacheEXT", true);
            vkGetValidationCacheDataEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetValidationCacheDataEXT", true);
            vkMergeValidationCachesEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkMergeValidationCachesEXT", true);
        }
    }

    public unsafe sealed class VulkanNVShadingRateImage : IVulkanDeviceExtGeneric<VulkanNVShadingRateImage>
    {
        public static string Name => "VK_NV_shading_rate_image";
        string IVulkanExt.GetName() => Name;

        public static VulkanNVShadingRateImage Create(VkDevice device)
        {
            return new VulkanNVShadingRateImage(device);
        }

        private IntPtr vkCmdBindShadingRateImageNV_ptr;
        private IntPtr vkCmdSetCoarseSampleOrderNV_ptr;
        private IntPtr vkCmdSetViewportShadingRatePaletteNV_ptr;

        [Generator.CalliRewrite]
        public unsafe void vkCmdBindShadingRateImageNV(VkCommandBuffer commandBuffer, VkImageView imageView, VkImageLayout imageLayout)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetCoarseSampleOrderNV(VkCommandBuffer commandBuffer, VkCoarseSampleOrderTypeNV sampleOrderType, uint customSampleOrderCount, VkCoarseSampleOrderCustomNV* pCustomSampleOrders)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetCoarseSampleOrderNV(VkCommandBuffer commandBuffer, VkCoarseSampleOrderTypeNV sampleOrderType, uint customSampleOrderCount, ref VkCoarseSampleOrderCustomNV pCustomSampleOrders)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetCoarseSampleOrderNV(VkCommandBuffer commandBuffer, VkCoarseSampleOrderTypeNV sampleOrderType, uint customSampleOrderCount, IntPtr pCustomSampleOrders)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetViewportShadingRatePaletteNV(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkShadingRatePaletteNV* pShadingRatePalettes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetViewportShadingRatePaletteNV(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, ref VkShadingRatePaletteNV pShadingRatePalettes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetViewportShadingRatePaletteNV(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, IntPtr pShadingRatePalettes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanNVShadingRateImage(VkDevice device)
        {
            vkCmdBindShadingRateImageNV_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdBindShadingRateImageNV", true);
            vkCmdSetCoarseSampleOrderNV_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdSetCoarseSampleOrderNV", true);
            vkCmdSetViewportShadingRatePaletteNV_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdSetViewportShadingRatePaletteNV", true);
        }
    }

    public unsafe sealed class VulkanNVRayTracing : IVulkanDeviceExtGeneric<VulkanNVRayTracing>
    {
        public static string Name => "VK_NV_ray_tracing";
        string IVulkanExt.GetName() => Name;

        public static VulkanNVRayTracing Create(VkDevice device)
        {
            return new VulkanNVRayTracing(device);
        }

        private IntPtr vkBindAccelerationStructureMemoryNV_ptr;
        private IntPtr vkCmdBuildAccelerationStructureNV_ptr;
        private IntPtr vkCmdCopyAccelerationStructureNV_ptr;
        private IntPtr vkCmdTraceRaysNV_ptr;
        private IntPtr vkCmdWriteAccelerationStructuresPropertiesNV_ptr;
        private IntPtr vkCompileDeferredNV_ptr;
        private IntPtr vkCreateAccelerationStructureNV_ptr;
        private IntPtr vkCreateRayTracingPipelinesNV_ptr;
        private IntPtr vkDestroyAccelerationStructureNV_ptr;
        private IntPtr vkGetAccelerationStructureHandleNV_ptr;
        private IntPtr vkGetAccelerationStructureMemoryRequirementsNV_ptr;

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkBindAccelerationStructureMemoryNV(VkDevice device, uint bindInfoCount, VkBindAccelerationStructureMemoryInfoNV* pBindInfos)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkBindAccelerationStructureMemoryNV(VkDevice device, uint bindInfoCount, ref VkBindAccelerationStructureMemoryInfoNV pBindInfos)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkBindAccelerationStructureMemoryNV(VkDevice device, uint bindInfoCount, IntPtr pBindInfos)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkBindAccelerationStructureMemoryNV(VkDevice device, uint bindInfoCount, VkBindAccelerationStructureMemoryInfoNV[] pBindInfos)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructureNV(VkCommandBuffer commandBuffer, VkAccelerationStructureInfoNV* pInfo, VkBuffer instanceData, ulong instanceOffset, VkBool32 update, VkAccelerationStructureNV dst, VkAccelerationStructureNV src, VkBuffer scratch, ulong scratchOffset)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructureNV(VkCommandBuffer commandBuffer, ref VkAccelerationStructureInfoNV pInfo, VkBuffer instanceData, ulong instanceOffset, VkBool32 update, VkAccelerationStructureNV dst, VkAccelerationStructureNV src, VkBuffer scratch, ulong scratchOffset)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildAccelerationStructureNV(VkCommandBuffer commandBuffer, IntPtr pInfo, VkBuffer instanceData, ulong instanceOffset, VkBool32 update, VkAccelerationStructureNV dst, VkAccelerationStructureNV src, VkBuffer scratch, ulong scratchOffset)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdCopyAccelerationStructureNV(VkCommandBuffer commandBuffer, VkAccelerationStructureNV dst, VkAccelerationStructureNV src, VkCopyAccelerationStructureModeKHR mode)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysNV(VkCommandBuffer commandBuffer, VkBuffer raygenShaderBindingTableBuffer, ulong raygenShaderBindingOffset, VkBuffer missShaderBindingTableBuffer, ulong missShaderBindingOffset, ulong missShaderBindingStride, VkBuffer hitShaderBindingTableBuffer, ulong hitShaderBindingOffset, ulong hitShaderBindingStride, VkBuffer callableShaderBindingTableBuffer, ulong callableShaderBindingOffset, ulong callableShaderBindingStride, uint width, uint height, uint depth)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdWriteAccelerationStructuresPropertiesNV(VkCommandBuffer commandBuffer, uint accelerationStructureCount, VkAccelerationStructureNV* pAccelerationStructures, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdWriteAccelerationStructuresPropertiesNV(VkCommandBuffer commandBuffer, uint accelerationStructureCount, ref VkAccelerationStructureNV pAccelerationStructures, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdWriteAccelerationStructuresPropertiesNV(VkCommandBuffer commandBuffer, uint accelerationStructureCount, IntPtr pAccelerationStructures, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCompileDeferredNV(VkDevice device, VkPipeline pipeline, uint shader)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateAccelerationStructureNV(VkDevice device, VkAccelerationStructureCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, VkAccelerationStructureNV* pAccelerationStructure)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateAccelerationStructureNV(VkDevice device, VkAccelerationStructureCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkAccelerationStructureNV pAccelerationStructure)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateAccelerationStructureNV(VkDevice device, VkAccelerationStructureCreateInfoNV* pCreateInfo, ref VkAllocationCallbacks pAllocator, VkAccelerationStructureNV* pAccelerationStructure)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateAccelerationStructureNV(VkDevice device, VkAccelerationStructureCreateInfoNV* pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkAccelerationStructureNV pAccelerationStructure)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateAccelerationStructureNV(VkDevice device, VkAccelerationStructureCreateInfoNV* pCreateInfo, IntPtr pAllocator, VkAccelerationStructureNV* pAccelerationStructure)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateAccelerationStructureNV(VkDevice device, VkAccelerationStructureCreateInfoNV* pCreateInfo, IntPtr pAllocator, out VkAccelerationStructureNV pAccelerationStructure)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateAccelerationStructureNV(VkDevice device, ref VkAccelerationStructureCreateInfoNV pCreateInfo, VkAllocationCallbacks* pAllocator, VkAccelerationStructureNV* pAccelerationStructure)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateAccelerationStructureNV(VkDevice device, ref VkAccelerationStructureCreateInfoNV pCreateInfo, VkAllocationCallbacks* pAllocator, out VkAccelerationStructureNV pAccelerationStructure)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateAccelerationStructureNV(VkDevice device, ref VkAccelerationStructureCreateInfoNV pCreateInfo, ref VkAllocationCallbacks pAllocator, VkAccelerationStructureNV* pAccelerationStructure)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateAccelerationStructureNV(VkDevice device, ref VkAccelerationStructureCreateInfoNV pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkAccelerationStructureNV pAccelerationStructure)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateAccelerationStructureNV(VkDevice device, ref VkAccelerationStructureCreateInfoNV pCreateInfo, IntPtr pAllocator, VkAccelerationStructureNV* pAccelerationStructure)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateAccelerationStructureNV(VkDevice device, ref VkAccelerationStructureCreateInfoNV pCreateInfo, IntPtr pAllocator, out VkAccelerationStructureNV pAccelerationStructure)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateAccelerationStructureNV(VkDevice device, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, VkAccelerationStructureNV* pAccelerationStructure)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateAccelerationStructureNV(VkDevice device, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, out VkAccelerationStructureNV pAccelerationStructure)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateAccelerationStructureNV(VkDevice device, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, VkAccelerationStructureNV* pAccelerationStructure)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateAccelerationStructureNV(VkDevice device, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkAccelerationStructureNV pAccelerationStructure)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateAccelerationStructureNV(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, VkAccelerationStructureNV* pAccelerationStructure)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateAccelerationStructureNV(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, out VkAccelerationStructureNV pAccelerationStructure)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_SHADER_NV</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoNV* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_SHADER_NV</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoNV* pCreateInfos, VkAllocationCallbacks* pAllocator, out VkPipeline pPipelines)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_SHADER_NV</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoNV* pCreateInfos, ref VkAllocationCallbacks pAllocator, VkPipeline* pPipelines)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_SHADER_NV</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoNV* pCreateInfos, ref VkAllocationCallbacks pAllocator, out VkPipeline pPipelines)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_SHADER_NV</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoNV* pCreateInfos, IntPtr pAllocator, VkPipeline* pPipelines)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_SHADER_NV</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoNV* pCreateInfos, IntPtr pAllocator, out VkPipeline pPipelines)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_SHADER_NV</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, ref VkRayTracingPipelineCreateInfoNV pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_SHADER_NV</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, ref VkRayTracingPipelineCreateInfoNV pCreateInfos, VkAllocationCallbacks* pAllocator, out VkPipeline pPipelines)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_SHADER_NV</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, ref VkRayTracingPipelineCreateInfoNV pCreateInfos, ref VkAllocationCallbacks pAllocator, VkPipeline* pPipelines)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_SHADER_NV</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, ref VkRayTracingPipelineCreateInfoNV pCreateInfos, ref VkAllocationCallbacks pAllocator, out VkPipeline pPipelines)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_SHADER_NV</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, ref VkRayTracingPipelineCreateInfoNV pCreateInfos, IntPtr pAllocator, VkPipeline* pPipelines)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_SHADER_NV</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, ref VkRayTracingPipelineCreateInfoNV pCreateInfos, IntPtr pAllocator, out VkPipeline pPipelines)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_SHADER_NV</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, IntPtr pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_SHADER_NV</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, IntPtr pCreateInfos, VkAllocationCallbacks* pAllocator, out VkPipeline pPipelines)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_SHADER_NV</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, IntPtr pCreateInfos, ref VkAllocationCallbacks pAllocator, VkPipeline* pPipelines)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_SHADER_NV</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, IntPtr pCreateInfos, ref VkAllocationCallbacks pAllocator, out VkPipeline pPipelines)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_SHADER_NV</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, IntPtr pCreateInfos, IntPtr pAllocator, VkPipeline* pPipelines)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_SHADER_NV</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, IntPtr pCreateInfos, IntPtr pAllocator, out VkPipeline pPipelines)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_SHADER_NV</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoNV[] pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_SHADER_NV</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoNV[] pCreateInfos, VkAllocationCallbacks* pAllocator, out VkPipeline pPipelines)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_SHADER_NV</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoNV[] pCreateInfos, ref VkAllocationCallbacks pAllocator, VkPipeline* pPipelines)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_SHADER_NV</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoNV[] pCreateInfos, ref VkAllocationCallbacks pAllocator, out VkPipeline pPipelines)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_SHADER_NV</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoNV[] pCreateInfos, IntPtr pAllocator, VkPipeline* pPipelines)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_SHADER_NV</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoNV[] pCreateInfos, IntPtr pAllocator, out VkPipeline pPipelines)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkDestroyAccelerationStructureNV(VkDevice device, VkAccelerationStructureNV accelerationStructure, VkAllocationCallbacks* pAllocator)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkDestroyAccelerationStructureNV(VkDevice device, VkAccelerationStructureNV accelerationStructure, ref VkAllocationCallbacks pAllocator)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkDestroyAccelerationStructureNV(VkDevice device, VkAccelerationStructureNV accelerationStructure, IntPtr pAllocator)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetAccelerationStructureHandleNV(VkDevice device, VkAccelerationStructureNV accelerationStructure, UIntPtr dataSize, void* pData)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetAccelerationStructureMemoryRequirementsNV(VkDevice device, VkAccelerationStructureMemoryRequirementsInfoNV* pInfo, VkMemoryRequirements2* pMemoryRequirements)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetAccelerationStructureMemoryRequirementsNV(VkDevice device, VkAccelerationStructureMemoryRequirementsInfoNV* pInfo, out VkMemoryRequirements2 pMemoryRequirements)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetAccelerationStructureMemoryRequirementsNV(VkDevice device, ref VkAccelerationStructureMemoryRequirementsInfoNV pInfo, VkMemoryRequirements2* pMemoryRequirements)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetAccelerationStructureMemoryRequirementsNV(VkDevice device, ref VkAccelerationStructureMemoryRequirementsInfoNV pInfo, out VkMemoryRequirements2 pMemoryRequirements)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetAccelerationStructureMemoryRequirementsNV(VkDevice device, IntPtr pInfo, VkMemoryRequirements2* pMemoryRequirements)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetAccelerationStructureMemoryRequirementsNV(VkDevice device, IntPtr pInfo, out VkMemoryRequirements2 pMemoryRequirements)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanNVRayTracing(VkDevice device)
        {
            vkBindAccelerationStructureMemoryNV_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkBindAccelerationStructureMemoryNV", true);
            vkCmdBuildAccelerationStructureNV_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdBuildAccelerationStructureNV", true);
            vkCmdCopyAccelerationStructureNV_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdCopyAccelerationStructureNV", true);
            vkCmdTraceRaysNV_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdTraceRaysNV", true);
            vkCmdWriteAccelerationStructuresPropertiesNV_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdWriteAccelerationStructuresPropertiesNV", true);
            vkCompileDeferredNV_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCompileDeferredNV", true);
            vkCreateAccelerationStructureNV_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCreateAccelerationStructureNV", true);
            vkCreateRayTracingPipelinesNV_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCreateRayTracingPipelinesNV", true);
            vkDestroyAccelerationStructureNV_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkDestroyAccelerationStructureNV", true);
            vkGetAccelerationStructureHandleNV_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetAccelerationStructureHandleNV", true);
            vkGetAccelerationStructureMemoryRequirementsNV_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetAccelerationStructureMemoryRequirementsNV", true);
        }
    }

    public unsafe sealed class VulkanKHRMaintenance3 : IVulkanDeviceExtGeneric<VulkanKHRMaintenance3>
    {
        public static string Name => "VK_KHR_maintenance3";
        string IVulkanExt.GetName() => Name;

        public static VulkanKHRMaintenance3 Create(VkDevice device)
        {
            return new VulkanKHRMaintenance3(device);
        }



        public VulkanKHRMaintenance3(VkDevice device)
        {
        }
    }

    public unsafe sealed class VulkanKHRDrawIndirectCount : IVulkanDeviceExtGeneric<VulkanKHRDrawIndirectCount>
    {
        public static string Name => "VK_KHR_draw_indirect_count";
        string IVulkanExt.GetName() => Name;

        public static VulkanKHRDrawIndirectCount Create(VkDevice device)
        {
            return new VulkanKHRDrawIndirectCount(device);
        }



        public VulkanKHRDrawIndirectCount(VkDevice device)
        {
        }
    }

    public unsafe sealed class VulkanEXTExternalMemoryHost : IVulkanDeviceExtGeneric<VulkanEXTExternalMemoryHost>
    {
        public static string Name => "VK_EXT_external_memory_host";
        string IVulkanExt.GetName() => Name;

        public static VulkanEXTExternalMemoryHost Create(VkDevice device)
        {
            return new VulkanEXTExternalMemoryHost(device);
        }

        private IntPtr vkGetMemoryHostPointerPropertiesEXT_ptr;

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetMemoryHostPointerPropertiesEXT(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, void* pHostPointer, VkMemoryHostPointerPropertiesEXT* pMemoryHostPointerProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetMemoryHostPointerPropertiesEXT(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, void* pHostPointer, out VkMemoryHostPointerPropertiesEXT pMemoryHostPointerProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanEXTExternalMemoryHost(VkDevice device)
        {
            vkGetMemoryHostPointerPropertiesEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetMemoryHostPointerPropertiesEXT", true);
        }
    }

    public unsafe sealed class VulkanAMDBufferMarker : IVulkanDeviceExtGeneric<VulkanAMDBufferMarker>
    {
        public static string Name => "VK_AMD_buffer_marker";
        string IVulkanExt.GetName() => Name;

        public static VulkanAMDBufferMarker Create(VkDevice device)
        {
            return new VulkanAMDBufferMarker(device);
        }

        private IntPtr vkCmdWriteBufferMarkerAMD_ptr;

        [Generator.CalliRewrite]
        public unsafe void vkCmdWriteBufferMarkerAMD(VkCommandBuffer commandBuffer, VkPipelineStageFlags pipelineStage, VkBuffer dstBuffer, ulong dstOffset, uint marker)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanAMDBufferMarker(VkDevice device)
        {
            vkCmdWriteBufferMarkerAMD_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdWriteBufferMarkerAMD", true);
        }
    }

    public unsafe sealed class VulkanEXTCalibratedTimestamps : IVulkanDeviceExtGeneric<VulkanEXTCalibratedTimestamps>
    {
        public static string Name => "VK_EXT_calibrated_timestamps";
        string IVulkanExt.GetName() => Name;

        public static VulkanEXTCalibratedTimestamps Create(VkDevice device)
        {
            return new VulkanEXTCalibratedTimestamps(device);
        }

        private IntPtr vkGetCalibratedTimestampsEXT_ptr;
        private IntPtr vkGetPhysicalDeviceCalibrateableTimeDomainsEXT_ptr;

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, VkCalibratedTimestampInfoEXT* pTimestampInfos, ulong* pTimestamps, ulong* pMaxDeviation)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, VkCalibratedTimestampInfoEXT* pTimestampInfos, ulong* pTimestamps, out ulong pMaxDeviation)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, VkCalibratedTimestampInfoEXT* pTimestampInfos, ref ulong pTimestamps, ulong* pMaxDeviation)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, VkCalibratedTimestampInfoEXT* pTimestampInfos, ref ulong pTimestamps, out ulong pMaxDeviation)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, VkCalibratedTimestampInfoEXT* pTimestampInfos, IntPtr pTimestamps, ulong* pMaxDeviation)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, VkCalibratedTimestampInfoEXT* pTimestampInfos, IntPtr pTimestamps, out ulong pMaxDeviation)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, ref VkCalibratedTimestampInfoEXT pTimestampInfos, ulong* pTimestamps, ulong* pMaxDeviation)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, ref VkCalibratedTimestampInfoEXT pTimestampInfos, ulong* pTimestamps, out ulong pMaxDeviation)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, ref VkCalibratedTimestampInfoEXT pTimestampInfos, ref ulong pTimestamps, ulong* pMaxDeviation)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, ref VkCalibratedTimestampInfoEXT pTimestampInfos, ref ulong pTimestamps, out ulong pMaxDeviation)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, ref VkCalibratedTimestampInfoEXT pTimestampInfos, IntPtr pTimestamps, ulong* pMaxDeviation)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, ref VkCalibratedTimestampInfoEXT pTimestampInfos, IntPtr pTimestamps, out ulong pMaxDeviation)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, IntPtr pTimestampInfos, ulong* pTimestamps, ulong* pMaxDeviation)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, IntPtr pTimestampInfos, ulong* pTimestamps, out ulong pMaxDeviation)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, IntPtr pTimestampInfos, ref ulong pTimestamps, ulong* pMaxDeviation)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, IntPtr pTimestampInfos, ref ulong pTimestamps, out ulong pMaxDeviation)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, IntPtr pTimestampInfos, IntPtr pTimestamps, ulong* pMaxDeviation)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, IntPtr pTimestampInfos, IntPtr pTimestamps, out ulong pMaxDeviation)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, VkCalibratedTimestampInfoEXT[] pTimestampInfos, ulong* pTimestamps, ulong* pMaxDeviation)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, VkCalibratedTimestampInfoEXT[] pTimestampInfos, ulong* pTimestamps, out ulong pMaxDeviation)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, VkCalibratedTimestampInfoEXT[] pTimestampInfos, ref ulong pTimestamps, ulong* pMaxDeviation)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, VkCalibratedTimestampInfoEXT[] pTimestampInfos, ref ulong pTimestamps, out ulong pMaxDeviation)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, VkCalibratedTimestampInfoEXT[] pTimestampInfos, IntPtr pTimestamps, ulong* pMaxDeviation)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, VkCalibratedTimestampInfoEXT[] pTimestampInfos, IntPtr pTimestamps, out ulong pMaxDeviation)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceCalibrateableTimeDomainsEXT(VkPhysicalDevice physicalDevice, uint* pTimeDomainCount, VkTimeDomainEXT* pTimeDomains)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceCalibrateableTimeDomainsEXT(VkPhysicalDevice physicalDevice, uint* pTimeDomainCount, out VkTimeDomainEXT pTimeDomains)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceCalibrateableTimeDomainsEXT(VkPhysicalDevice physicalDevice, ref uint pTimeDomainCount, VkTimeDomainEXT* pTimeDomains)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceCalibrateableTimeDomainsEXT(VkPhysicalDevice physicalDevice, ref uint pTimeDomainCount, out VkTimeDomainEXT pTimeDomains)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceCalibrateableTimeDomainsEXT(VkPhysicalDevice physicalDevice, IntPtr pTimeDomainCount, VkTimeDomainEXT* pTimeDomains)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceCalibrateableTimeDomainsEXT(VkPhysicalDevice physicalDevice, IntPtr pTimeDomainCount, out VkTimeDomainEXT pTimeDomains)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanEXTCalibratedTimestamps(VkDevice device)
        {
            vkGetCalibratedTimestampsEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetCalibratedTimestampsEXT", true);
            vkGetPhysicalDeviceCalibrateableTimeDomainsEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetPhysicalDeviceCalibrateableTimeDomainsEXT", true);
        }
    }

    public unsafe sealed class VulkanNVMeshShader : IVulkanDeviceExtGeneric<VulkanNVMeshShader>
    {
        public static string Name => "VK_NV_mesh_shader";
        string IVulkanExt.GetName() => Name;

        public static VulkanNVMeshShader Create(VkDevice device)
        {
            return new VulkanNVMeshShader(device);
        }

        private IntPtr vkCmdDrawMeshTasksIndirectCountNV_ptr;
        private IntPtr vkCmdDrawMeshTasksIndirectNV_ptr;
        private IntPtr vkCmdDrawMeshTasksNV_ptr;

        [Generator.CalliRewrite]
        public unsafe void vkCmdDrawMeshTasksIndirectCountNV(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdDrawMeshTasksIndirectNV(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, uint drawCount, uint stride)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdDrawMeshTasksNV(VkCommandBuffer commandBuffer, uint taskCount, uint firstTask)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanNVMeshShader(VkDevice device)
        {
            vkCmdDrawMeshTasksIndirectCountNV_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdDrawMeshTasksIndirectCountNV", true);
            vkCmdDrawMeshTasksIndirectNV_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdDrawMeshTasksIndirectNV", true);
            vkCmdDrawMeshTasksNV_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdDrawMeshTasksNV", true);
        }
    }

    public unsafe sealed class VulkanNVScissorExclusive : IVulkanDeviceExtGeneric<VulkanNVScissorExclusive>
    {
        public static string Name => "VK_NV_scissor_exclusive";
        string IVulkanExt.GetName() => Name;

        public static VulkanNVScissorExclusive Create(VkDevice device)
        {
            return new VulkanNVScissorExclusive(device);
        }

        private IntPtr vkCmdSetExclusiveScissorNV_ptr;

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetExclusiveScissorNV(VkCommandBuffer commandBuffer, uint firstExclusiveScissor, uint exclusiveScissorCount, VkRect2D* pExclusiveScissors)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetExclusiveScissorNV(VkCommandBuffer commandBuffer, uint firstExclusiveScissor, uint exclusiveScissorCount, ref VkRect2D pExclusiveScissors)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetExclusiveScissorNV(VkCommandBuffer commandBuffer, uint firstExclusiveScissor, uint exclusiveScissorCount, IntPtr pExclusiveScissors)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanNVScissorExclusive(VkDevice device)
        {
            vkCmdSetExclusiveScissorNV_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdSetExclusiveScissorNV", true);
        }
    }

    public unsafe sealed class VulkanNVDeviceDiagnosticCheckpoints : IVulkanDeviceExtGeneric<VulkanNVDeviceDiagnosticCheckpoints>
    {
        public static string Name => "VK_NV_device_diagnostic_checkpoints";
        string IVulkanExt.GetName() => Name;

        public static VulkanNVDeviceDiagnosticCheckpoints Create(VkDevice device)
        {
            return new VulkanNVDeviceDiagnosticCheckpoints(device);
        }

        private IntPtr vkCmdSetCheckpointNV_ptr;
        private IntPtr vkGetQueueCheckpointDataNV_ptr;

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetCheckpointNV(VkCommandBuffer commandBuffer, void* pCheckpointMarker)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetQueueCheckpointDataNV(VkQueue queue, uint* pCheckpointDataCount, VkCheckpointDataNV* pCheckpointData)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetQueueCheckpointDataNV(VkQueue queue, uint* pCheckpointDataCount, out VkCheckpointDataNV pCheckpointData)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetQueueCheckpointDataNV(VkQueue queue, ref uint pCheckpointDataCount, VkCheckpointDataNV* pCheckpointData)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetQueueCheckpointDataNV(VkQueue queue, ref uint pCheckpointDataCount, out VkCheckpointDataNV pCheckpointData)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetQueueCheckpointDataNV(VkQueue queue, IntPtr pCheckpointDataCount, VkCheckpointDataNV* pCheckpointData)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetQueueCheckpointDataNV(VkQueue queue, IntPtr pCheckpointDataCount, out VkCheckpointDataNV pCheckpointData)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanNVDeviceDiagnosticCheckpoints(VkDevice device)
        {
            vkCmdSetCheckpointNV_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdSetCheckpointNV", true);
            vkGetQueueCheckpointDataNV_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetQueueCheckpointDataNV", true);
        }
    }

    public unsafe sealed class VulkanKHRTimelineSemaphore : IVulkanDeviceExtGeneric<VulkanKHRTimelineSemaphore>
    {
        public static string Name => "VK_KHR_timeline_semaphore";
        string IVulkanExt.GetName() => Name;

        public static VulkanKHRTimelineSemaphore Create(VkDevice device)
        {
            return new VulkanKHRTimelineSemaphore(device);
        }



        public VulkanKHRTimelineSemaphore(VkDevice device)
        {
        }
    }

    public unsafe sealed class VulkanIntelPerformanceQuery : IVulkanDeviceExtGeneric<VulkanIntelPerformanceQuery>
    {
        public static string Name => "VK_INTEL_performance_query";
        string IVulkanExt.GetName() => Name;

        public static VulkanIntelPerformanceQuery Create(VkDevice device)
        {
            return new VulkanIntelPerformanceQuery(device);
        }

        private IntPtr vkAcquirePerformanceConfigurationINTEL_ptr;
        private IntPtr vkCmdSetPerformanceMarkerINTEL_ptr;
        private IntPtr vkCmdSetPerformanceOverrideINTEL_ptr;
        private IntPtr vkCmdSetPerformanceStreamMarkerINTEL_ptr;
        private IntPtr vkGetPerformanceParameterINTEL_ptr;
        private IntPtr vkInitializePerformanceApiINTEL_ptr;
        private IntPtr vkQueueSetPerformanceConfigurationINTEL_ptr;
        private IntPtr vkReleasePerformanceConfigurationINTEL_ptr;
        private IntPtr vkUninitializePerformanceApiINTEL_ptr;

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkAcquirePerformanceConfigurationINTEL(VkDevice device, VkPerformanceConfigurationAcquireInfoINTEL* pAcquireInfo, VkPerformanceConfigurationINTEL* pConfiguration)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkAcquirePerformanceConfigurationINTEL(VkDevice device, VkPerformanceConfigurationAcquireInfoINTEL* pAcquireInfo, ref VkPerformanceConfigurationINTEL pConfiguration)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkAcquirePerformanceConfigurationINTEL(VkDevice device, VkPerformanceConfigurationAcquireInfoINTEL* pAcquireInfo, IntPtr pConfiguration)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkAcquirePerformanceConfigurationINTEL(VkDevice device, ref VkPerformanceConfigurationAcquireInfoINTEL pAcquireInfo, VkPerformanceConfigurationINTEL* pConfiguration)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkAcquirePerformanceConfigurationINTEL(VkDevice device, ref VkPerformanceConfigurationAcquireInfoINTEL pAcquireInfo, ref VkPerformanceConfigurationINTEL pConfiguration)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkAcquirePerformanceConfigurationINTEL(VkDevice device, ref VkPerformanceConfigurationAcquireInfoINTEL pAcquireInfo, IntPtr pConfiguration)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkAcquirePerformanceConfigurationINTEL(VkDevice device, IntPtr pAcquireInfo, VkPerformanceConfigurationINTEL* pConfiguration)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkAcquirePerformanceConfigurationINTEL(VkDevice device, IntPtr pAcquireInfo, ref VkPerformanceConfigurationINTEL pConfiguration)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkAcquirePerformanceConfigurationINTEL(VkDevice device, IntPtr pAcquireInfo, IntPtr pConfiguration)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCmdSetPerformanceMarkerINTEL(VkCommandBuffer commandBuffer, VkPerformanceMarkerInfoINTEL* pMarkerInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCmdSetPerformanceMarkerINTEL(VkCommandBuffer commandBuffer, ref VkPerformanceMarkerInfoINTEL pMarkerInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCmdSetPerformanceMarkerINTEL(VkCommandBuffer commandBuffer, IntPtr pMarkerInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCmdSetPerformanceOverrideINTEL(VkCommandBuffer commandBuffer, VkPerformanceOverrideInfoINTEL* pOverrideInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCmdSetPerformanceOverrideINTEL(VkCommandBuffer commandBuffer, ref VkPerformanceOverrideInfoINTEL pOverrideInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCmdSetPerformanceOverrideINTEL(VkCommandBuffer commandBuffer, IntPtr pOverrideInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCmdSetPerformanceStreamMarkerINTEL(VkCommandBuffer commandBuffer, VkPerformanceStreamMarkerInfoINTEL* pMarkerInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCmdSetPerformanceStreamMarkerINTEL(VkCommandBuffer commandBuffer, ref VkPerformanceStreamMarkerInfoINTEL pMarkerInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCmdSetPerformanceStreamMarkerINTEL(VkCommandBuffer commandBuffer, IntPtr pMarkerInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPerformanceParameterINTEL(VkDevice device, VkPerformanceParameterTypeINTEL parameter, VkPerformanceValueINTEL* pValue)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPerformanceParameterINTEL(VkDevice device, VkPerformanceParameterTypeINTEL parameter, out VkPerformanceValueINTEL pValue)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkInitializePerformanceApiINTEL(VkDevice device, VkInitializePerformanceApiInfoINTEL* pInitializeInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkInitializePerformanceApiINTEL(VkDevice device, ref VkInitializePerformanceApiInfoINTEL pInitializeInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkInitializePerformanceApiINTEL(VkDevice device, IntPtr pInitializeInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkQueueSetPerformanceConfigurationINTEL(VkQueue queue, VkPerformanceConfigurationINTEL configuration)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkReleasePerformanceConfigurationINTEL(VkDevice device, VkPerformanceConfigurationINTEL configuration)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkUninitializePerformanceApiINTEL(VkDevice device)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanIntelPerformanceQuery(VkDevice device)
        {
            vkAcquirePerformanceConfigurationINTEL_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkAcquirePerformanceConfigurationINTEL", true);
            vkCmdSetPerformanceMarkerINTEL_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdSetPerformanceMarkerINTEL", true);
            vkCmdSetPerformanceOverrideINTEL_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdSetPerformanceOverrideINTEL", true);
            vkCmdSetPerformanceStreamMarkerINTEL_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdSetPerformanceStreamMarkerINTEL", true);
            vkGetPerformanceParameterINTEL_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetPerformanceParameterINTEL", true);
            vkInitializePerformanceApiINTEL_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkInitializePerformanceApiINTEL", true);
            vkQueueSetPerformanceConfigurationINTEL_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkQueueSetPerformanceConfigurationINTEL", true);
            vkReleasePerformanceConfigurationINTEL_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkReleasePerformanceConfigurationINTEL", true);
            vkUninitializePerformanceApiINTEL_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkUninitializePerformanceApiINTEL", true);
        }
    }

    public unsafe sealed class VulkanAMDDisplayNativeHdr : IVulkanDeviceExtGeneric<VulkanAMDDisplayNativeHdr>
    {
        public static string Name => "VK_AMD_display_native_hdr";
        string IVulkanExt.GetName() => Name;

        public static VulkanAMDDisplayNativeHdr Create(VkDevice device)
        {
            return new VulkanAMDDisplayNativeHdr(device);
        }

        private IntPtr vkSetLocalDimmingAMD_ptr;

        [Generator.CalliRewrite]
        public unsafe void vkSetLocalDimmingAMD(VkDevice device, VkSwapchainKHR swapChain, VkBool32 localDimmingEnable)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanAMDDisplayNativeHdr(VkDevice device)
        {
            vkSetLocalDimmingAMD_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkSetLocalDimmingAMD", true);
        }
    }

    public unsafe sealed class VulkanFuchsiaImagepipeSurface : IVulkanInstanceExtGeneric<VulkanFuchsiaImagepipeSurface>
    {
        public static string Name => "VK_FUCHSIA_imagepipe_surface";
        string IVulkanExt.GetName() => Name;

        public static VulkanFuchsiaImagepipeSurface Create(VkInstance instance)
        {
            return new VulkanFuchsiaImagepipeSurface(instance);
        }

        private IntPtr vkCreateImagePipeSurfaceFUCHSIA_ptr;

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateImagePipeSurfaceFUCHSIA(VkInstance instance, VkImagePipeSurfaceCreateInfoFUCHSIA* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateImagePipeSurfaceFUCHSIA(VkInstance instance, VkImagePipeSurfaceCreateInfoFUCHSIA* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateImagePipeSurfaceFUCHSIA(VkInstance instance, VkImagePipeSurfaceCreateInfoFUCHSIA* pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateImagePipeSurfaceFUCHSIA(VkInstance instance, VkImagePipeSurfaceCreateInfoFUCHSIA* pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateImagePipeSurfaceFUCHSIA(VkInstance instance, VkImagePipeSurfaceCreateInfoFUCHSIA* pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateImagePipeSurfaceFUCHSIA(VkInstance instance, VkImagePipeSurfaceCreateInfoFUCHSIA* pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateImagePipeSurfaceFUCHSIA(VkInstance instance, ref VkImagePipeSurfaceCreateInfoFUCHSIA pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateImagePipeSurfaceFUCHSIA(VkInstance instance, ref VkImagePipeSurfaceCreateInfoFUCHSIA pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateImagePipeSurfaceFUCHSIA(VkInstance instance, ref VkImagePipeSurfaceCreateInfoFUCHSIA pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateImagePipeSurfaceFUCHSIA(VkInstance instance, ref VkImagePipeSurfaceCreateInfoFUCHSIA pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateImagePipeSurfaceFUCHSIA(VkInstance instance, ref VkImagePipeSurfaceCreateInfoFUCHSIA pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateImagePipeSurfaceFUCHSIA(VkInstance instance, ref VkImagePipeSurfaceCreateInfoFUCHSIA pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateImagePipeSurfaceFUCHSIA(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateImagePipeSurfaceFUCHSIA(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateImagePipeSurfaceFUCHSIA(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateImagePipeSurfaceFUCHSIA(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateImagePipeSurfaceFUCHSIA(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateImagePipeSurfaceFUCHSIA(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanFuchsiaImagepipeSurface(VkInstance instance)
        {
            vkCreateImagePipeSurfaceFUCHSIA_ptr = VulkanNative.LoadInstanceProcAddr(instance, "vkCreateImagePipeSurfaceFUCHSIA", true);
        }
    }

    public unsafe sealed class VulkanEXTMetalSurface : IVulkanInstanceExtGeneric<VulkanEXTMetalSurface>
    {
        public static string Name => "VK_EXT_metal_surface";
        string IVulkanExt.GetName() => Name;

        public static VulkanEXTMetalSurface Create(VkInstance instance)
        {
            return new VulkanEXTMetalSurface(instance);
        }

        private IntPtr vkCreateMetalSurfaceEXT_ptr;

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateMetalSurfaceEXT(VkInstance instance, VkMetalSurfaceCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateMetalSurfaceEXT(VkInstance instance, VkMetalSurfaceCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateMetalSurfaceEXT(VkInstance instance, VkMetalSurfaceCreateInfoEXT* pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateMetalSurfaceEXT(VkInstance instance, VkMetalSurfaceCreateInfoEXT* pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateMetalSurfaceEXT(VkInstance instance, VkMetalSurfaceCreateInfoEXT* pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateMetalSurfaceEXT(VkInstance instance, VkMetalSurfaceCreateInfoEXT* pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateMetalSurfaceEXT(VkInstance instance, ref VkMetalSurfaceCreateInfoEXT pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateMetalSurfaceEXT(VkInstance instance, ref VkMetalSurfaceCreateInfoEXT pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateMetalSurfaceEXT(VkInstance instance, ref VkMetalSurfaceCreateInfoEXT pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateMetalSurfaceEXT(VkInstance instance, ref VkMetalSurfaceCreateInfoEXT pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateMetalSurfaceEXT(VkInstance instance, ref VkMetalSurfaceCreateInfoEXT pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateMetalSurfaceEXT(VkInstance instance, ref VkMetalSurfaceCreateInfoEXT pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateMetalSurfaceEXT(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateMetalSurfaceEXT(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateMetalSurfaceEXT(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateMetalSurfaceEXT(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateMetalSurfaceEXT(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateMetalSurfaceEXT(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanEXTMetalSurface(VkInstance instance)
        {
            vkCreateMetalSurfaceEXT_ptr = VulkanNative.LoadInstanceProcAddr(instance, "vkCreateMetalSurfaceEXT", true);
        }
    }

    public unsafe sealed class VulkanKHRFragmentShadingRate : IVulkanDeviceExtGeneric<VulkanKHRFragmentShadingRate>
    {
        public static string Name => "VK_KHR_fragment_shading_rate";
        string IVulkanExt.GetName() => Name;

        public static VulkanKHRFragmentShadingRate Create(VkDevice device)
        {
            return new VulkanKHRFragmentShadingRate(device);
        }

        private IntPtr vkCmdSetFragmentShadingRateKHR_ptr;
        private IntPtr vkGetPhysicalDeviceFragmentShadingRatesKHR_ptr;

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetFragmentShadingRateKHR(VkCommandBuffer commandBuffer, VkExtent2D* pFragmentSize, VkFragmentShadingRateCombinerOpKHR combinerOps)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetFragmentShadingRateKHR(VkCommandBuffer commandBuffer, ref VkExtent2D pFragmentSize, VkFragmentShadingRateCombinerOpKHR combinerOps)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetFragmentShadingRateKHR(VkCommandBuffer commandBuffer, IntPtr pFragmentSize, VkFragmentShadingRateCombinerOpKHR combinerOps)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceFragmentShadingRatesKHR(VkPhysicalDevice physicalDevice, uint* pFragmentShadingRateCount, VkPhysicalDeviceFragmentShadingRateKHR* pFragmentShadingRates)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceFragmentShadingRatesKHR(VkPhysicalDevice physicalDevice, uint* pFragmentShadingRateCount, out VkPhysicalDeviceFragmentShadingRateKHR pFragmentShadingRates)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceFragmentShadingRatesKHR(VkPhysicalDevice physicalDevice, ref uint pFragmentShadingRateCount, VkPhysicalDeviceFragmentShadingRateKHR* pFragmentShadingRates)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceFragmentShadingRatesKHR(VkPhysicalDevice physicalDevice, ref uint pFragmentShadingRateCount, out VkPhysicalDeviceFragmentShadingRateKHR pFragmentShadingRates)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceFragmentShadingRatesKHR(VkPhysicalDevice physicalDevice, IntPtr pFragmentShadingRateCount, VkPhysicalDeviceFragmentShadingRateKHR* pFragmentShadingRates)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceFragmentShadingRatesKHR(VkPhysicalDevice physicalDevice, IntPtr pFragmentShadingRateCount, out VkPhysicalDeviceFragmentShadingRateKHR pFragmentShadingRates)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanKHRFragmentShadingRate(VkDevice device)
        {
            vkCmdSetFragmentShadingRateKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdSetFragmentShadingRateKHR", true);
            vkGetPhysicalDeviceFragmentShadingRatesKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetPhysicalDeviceFragmentShadingRatesKHR", true);
        }
    }

    public unsafe sealed class VulkanEXTBufferDeviceAddress : IVulkanDeviceExtGeneric<VulkanEXTBufferDeviceAddress>
    {
        public static string Name => "VK_EXT_buffer_device_address";
        string IVulkanExt.GetName() => Name;

        public static VulkanEXTBufferDeviceAddress Create(VkDevice device)
        {
            return new VulkanEXTBufferDeviceAddress(device);
        }



        public VulkanEXTBufferDeviceAddress(VkDevice device)
        {
        }
    }

    public unsafe sealed class VulkanEXTToolingInfo : IVulkanDeviceExtGeneric<VulkanEXTToolingInfo>
    {
        public static string Name => "VK_EXT_tooling_info";
        string IVulkanExt.GetName() => Name;

        public static VulkanEXTToolingInfo Create(VkDevice device)
        {
            return new VulkanEXTToolingInfo(device);
        }



        public VulkanEXTToolingInfo(VkDevice device)
        {
        }
    }

    public unsafe sealed class VulkanKHRPresentWait : IVulkanDeviceExtGeneric<VulkanKHRPresentWait>
    {
        public static string Name => "VK_KHR_present_wait";
        string IVulkanExt.GetName() => Name;

        public static VulkanKHRPresentWait Create(VkDevice device)
        {
            return new VulkanKHRPresentWait(device);
        }

        private IntPtr vkWaitForPresentKHR_ptr;

        ///<remarks>Success codes:VK_SUCCESS, VK_TIMEOUT, VK_SUBOPTIMAL_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_OUT_OF_DATE_KHR, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_FULL_SCREEN_EXCLUSIVE_MODE_LOST_EXT</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkWaitForPresentKHR(VkDevice device, VkSwapchainKHR swapchain, ulong presentId, ulong timeout)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanKHRPresentWait(VkDevice device)
        {
            vkWaitForPresentKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkWaitForPresentKHR", true);
        }
    }

    public unsafe sealed class VulkanNVCooperativeMatrix : IVulkanDeviceExtGeneric<VulkanNVCooperativeMatrix>
    {
        public static string Name => "VK_NV_cooperative_matrix";
        string IVulkanExt.GetName() => Name;

        public static VulkanNVCooperativeMatrix Create(VkDevice device)
        {
            return new VulkanNVCooperativeMatrix(device);
        }

        private IntPtr vkGetPhysicalDeviceCooperativeMatrixPropertiesNV_ptr;

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceCooperativeMatrixPropertiesNV(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkCooperativeMatrixPropertiesNV* pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceCooperativeMatrixPropertiesNV(VkPhysicalDevice physicalDevice, uint* pPropertyCount, out VkCooperativeMatrixPropertiesNV pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceCooperativeMatrixPropertiesNV(VkPhysicalDevice physicalDevice, ref uint pPropertyCount, VkCooperativeMatrixPropertiesNV* pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceCooperativeMatrixPropertiesNV(VkPhysicalDevice physicalDevice, ref uint pPropertyCount, out VkCooperativeMatrixPropertiesNV pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceCooperativeMatrixPropertiesNV(VkPhysicalDevice physicalDevice, IntPtr pPropertyCount, VkCooperativeMatrixPropertiesNV* pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceCooperativeMatrixPropertiesNV(VkPhysicalDevice physicalDevice, IntPtr pPropertyCount, out VkCooperativeMatrixPropertiesNV pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanNVCooperativeMatrix(VkDevice device)
        {
            vkGetPhysicalDeviceCooperativeMatrixPropertiesNV_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetPhysicalDeviceCooperativeMatrixPropertiesNV", true);
        }
    }

    public unsafe sealed class VulkanNVCoverageReductionMode : IVulkanDeviceExtGeneric<VulkanNVCoverageReductionMode>
    {
        public static string Name => "VK_NV_coverage_reduction_mode";
        string IVulkanExt.GetName() => Name;

        public static VulkanNVCoverageReductionMode Create(VkDevice device)
        {
            return new VulkanNVCoverageReductionMode(device);
        }

        private IntPtr vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV_ptr;

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV(VkPhysicalDevice physicalDevice, uint* pCombinationCount, VkFramebufferMixedSamplesCombinationNV* pCombinations)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV(VkPhysicalDevice physicalDevice, uint* pCombinationCount, out VkFramebufferMixedSamplesCombinationNV pCombinations)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV(VkPhysicalDevice physicalDevice, ref uint pCombinationCount, VkFramebufferMixedSamplesCombinationNV* pCombinations)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV(VkPhysicalDevice physicalDevice, ref uint pCombinationCount, out VkFramebufferMixedSamplesCombinationNV pCombinations)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV(VkPhysicalDevice physicalDevice, IntPtr pCombinationCount, VkFramebufferMixedSamplesCombinationNV* pCombinations)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV(VkPhysicalDevice physicalDevice, IntPtr pCombinationCount, out VkFramebufferMixedSamplesCombinationNV pCombinations)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanNVCoverageReductionMode(VkDevice device)
        {
            vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV", true);
        }
    }

    public unsafe sealed class VulkanEXTFullScreenExclusive : IVulkanDeviceExtGeneric<VulkanEXTFullScreenExclusive>
    {
        public static string Name => "VK_EXT_full_screen_exclusive";
        string IVulkanExt.GetName() => Name;

        public static VulkanEXTFullScreenExclusive Create(VkDevice device)
        {
            return new VulkanEXTFullScreenExclusive(device);
        }

        private IntPtr vkAcquireFullScreenExclusiveModeEXT_ptr;
        private IntPtr vkGetDeviceGroupSurfacePresentModes2EXT_ptr;
        private IntPtr vkGetPhysicalDeviceSurfacePresentModes2EXT_ptr;
        private IntPtr vkReleaseFullScreenExclusiveModeEXT_ptr;

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkAcquireFullScreenExclusiveModeEXT(VkDevice device, VkSwapchainKHR swapchain)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetDeviceGroupSurfacePresentModes2EXT(VkDevice device, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, VkDeviceGroupPresentModeFlagsKHR* pModes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetDeviceGroupSurfacePresentModes2EXT(VkDevice device, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, out VkDeviceGroupPresentModeFlagsKHR pModes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetDeviceGroupSurfacePresentModes2EXT(VkDevice device, ref VkPhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, VkDeviceGroupPresentModeFlagsKHR* pModes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetDeviceGroupSurfacePresentModes2EXT(VkDevice device, ref VkPhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, out VkDeviceGroupPresentModeFlagsKHR pModes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetDeviceGroupSurfacePresentModes2EXT(VkDevice device, IntPtr pSurfaceInfo, VkDeviceGroupPresentModeFlagsKHR* pModes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetDeviceGroupSurfacePresentModes2EXT(VkDevice device, IntPtr pSurfaceInfo, out VkDeviceGroupPresentModeFlagsKHR pModes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSurfacePresentModes2EXT(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, uint* pPresentModeCount, VkPresentModeKHR* pPresentModes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSurfacePresentModes2EXT(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, uint* pPresentModeCount, out VkPresentModeKHR pPresentModes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSurfacePresentModes2EXT(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, ref uint pPresentModeCount, VkPresentModeKHR* pPresentModes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSurfacePresentModes2EXT(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, ref uint pPresentModeCount, out VkPresentModeKHR pPresentModes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSurfacePresentModes2EXT(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, IntPtr pPresentModeCount, VkPresentModeKHR* pPresentModes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSurfacePresentModes2EXT(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, IntPtr pPresentModeCount, out VkPresentModeKHR pPresentModes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSurfacePresentModes2EXT(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, uint* pPresentModeCount, VkPresentModeKHR* pPresentModes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSurfacePresentModes2EXT(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, uint* pPresentModeCount, out VkPresentModeKHR pPresentModes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSurfacePresentModes2EXT(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, ref uint pPresentModeCount, VkPresentModeKHR* pPresentModes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSurfacePresentModes2EXT(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, ref uint pPresentModeCount, out VkPresentModeKHR pPresentModes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSurfacePresentModes2EXT(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, IntPtr pPresentModeCount, VkPresentModeKHR* pPresentModes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSurfacePresentModes2EXT(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, IntPtr pPresentModeCount, out VkPresentModeKHR pPresentModes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSurfacePresentModes2EXT(VkPhysicalDevice physicalDevice, IntPtr pSurfaceInfo, uint* pPresentModeCount, VkPresentModeKHR* pPresentModes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSurfacePresentModes2EXT(VkPhysicalDevice physicalDevice, IntPtr pSurfaceInfo, uint* pPresentModeCount, out VkPresentModeKHR pPresentModes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSurfacePresentModes2EXT(VkPhysicalDevice physicalDevice, IntPtr pSurfaceInfo, ref uint pPresentModeCount, VkPresentModeKHR* pPresentModes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSurfacePresentModes2EXT(VkPhysicalDevice physicalDevice, IntPtr pSurfaceInfo, ref uint pPresentModeCount, out VkPresentModeKHR pPresentModes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSurfacePresentModes2EXT(VkPhysicalDevice physicalDevice, IntPtr pSurfaceInfo, IntPtr pPresentModeCount, VkPresentModeKHR* pPresentModes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceSurfacePresentModes2EXT(VkPhysicalDevice physicalDevice, IntPtr pSurfaceInfo, IntPtr pPresentModeCount, out VkPresentModeKHR pPresentModes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkReleaseFullScreenExclusiveModeEXT(VkDevice device, VkSwapchainKHR swapchain)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanEXTFullScreenExclusive(VkDevice device)
        {
            vkAcquireFullScreenExclusiveModeEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkAcquireFullScreenExclusiveModeEXT", true);
            vkGetDeviceGroupSurfacePresentModes2EXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetDeviceGroupSurfacePresentModes2EXT", true);
            vkGetPhysicalDeviceSurfacePresentModes2EXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetPhysicalDeviceSurfacePresentModes2EXT", true);
            vkReleaseFullScreenExclusiveModeEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkReleaseFullScreenExclusiveModeEXT", true);
        }
    }

    public unsafe sealed class VulkanEXTHeadlessSurface : IVulkanInstanceExtGeneric<VulkanEXTHeadlessSurface>
    {
        public static string Name => "VK_EXT_headless_surface";
        string IVulkanExt.GetName() => Name;

        public static VulkanEXTHeadlessSurface Create(VkInstance instance)
        {
            return new VulkanEXTHeadlessSurface(instance);
        }

        private IntPtr vkCreateHeadlessSurfaceEXT_ptr;

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateHeadlessSurfaceEXT(VkInstance instance, VkHeadlessSurfaceCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateHeadlessSurfaceEXT(VkInstance instance, VkHeadlessSurfaceCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateHeadlessSurfaceEXT(VkInstance instance, VkHeadlessSurfaceCreateInfoEXT* pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateHeadlessSurfaceEXT(VkInstance instance, VkHeadlessSurfaceCreateInfoEXT* pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateHeadlessSurfaceEXT(VkInstance instance, VkHeadlessSurfaceCreateInfoEXT* pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateHeadlessSurfaceEXT(VkInstance instance, VkHeadlessSurfaceCreateInfoEXT* pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateHeadlessSurfaceEXT(VkInstance instance, ref VkHeadlessSurfaceCreateInfoEXT pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateHeadlessSurfaceEXT(VkInstance instance, ref VkHeadlessSurfaceCreateInfoEXT pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateHeadlessSurfaceEXT(VkInstance instance, ref VkHeadlessSurfaceCreateInfoEXT pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateHeadlessSurfaceEXT(VkInstance instance, ref VkHeadlessSurfaceCreateInfoEXT pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateHeadlessSurfaceEXT(VkInstance instance, ref VkHeadlessSurfaceCreateInfoEXT pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateHeadlessSurfaceEXT(VkInstance instance, ref VkHeadlessSurfaceCreateInfoEXT pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateHeadlessSurfaceEXT(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateHeadlessSurfaceEXT(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateHeadlessSurfaceEXT(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateHeadlessSurfaceEXT(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateHeadlessSurfaceEXT(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateHeadlessSurfaceEXT(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanEXTHeadlessSurface(VkInstance instance)
        {
            vkCreateHeadlessSurfaceEXT_ptr = VulkanNative.LoadInstanceProcAddr(instance, "vkCreateHeadlessSurfaceEXT", true);
        }
    }

    public unsafe sealed class VulkanKHRBufferDeviceAddress : IVulkanDeviceExtGeneric<VulkanKHRBufferDeviceAddress>
    {
        public static string Name => "VK_KHR_buffer_device_address";
        string IVulkanExt.GetName() => Name;

        public static VulkanKHRBufferDeviceAddress Create(VkDevice device)
        {
            return new VulkanKHRBufferDeviceAddress(device);
        }



        public VulkanKHRBufferDeviceAddress(VkDevice device)
        {
        }
    }

    public unsafe sealed class VulkanEXTLineRasterization : IVulkanDeviceExtGeneric<VulkanEXTLineRasterization>
    {
        public static string Name => "VK_EXT_line_rasterization";
        string IVulkanExt.GetName() => Name;

        public static VulkanEXTLineRasterization Create(VkDevice device)
        {
            return new VulkanEXTLineRasterization(device);
        }

        private IntPtr vkCmdSetLineStippleEXT_ptr;

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetLineStippleEXT(VkCommandBuffer commandBuffer, uint lineStippleFactor, ushort lineStipplePattern)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanEXTLineRasterization(VkDevice device)
        {
            vkCmdSetLineStippleEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdSetLineStippleEXT", true);
        }
    }

    public unsafe sealed class VulkanEXTHostQueryReset : IVulkanDeviceExtGeneric<VulkanEXTHostQueryReset>
    {
        public static string Name => "VK_EXT_host_query_reset";
        string IVulkanExt.GetName() => Name;

        public static VulkanEXTHostQueryReset Create(VkDevice device)
        {
            return new VulkanEXTHostQueryReset(device);
        }



        public VulkanEXTHostQueryReset(VkDevice device)
        {
        }
    }

    public unsafe sealed class VulkanEXTExtendedDynamicState : IVulkanDeviceExtGeneric<VulkanEXTExtendedDynamicState>
    {
        public static string Name => "VK_EXT_extended_dynamic_state";
        string IVulkanExt.GetName() => Name;

        public static VulkanEXTExtendedDynamicState Create(VkDevice device)
        {
            return new VulkanEXTExtendedDynamicState(device);
        }



        public VulkanEXTExtendedDynamicState(VkDevice device)
        {
        }
    }

    public unsafe sealed class VulkanKHRDeferredHostOperations : IVulkanDeviceExtGeneric<VulkanKHRDeferredHostOperations>
    {
        public static string Name => "VK_KHR_deferred_host_operations";
        string IVulkanExt.GetName() => Name;

        public static VulkanKHRDeferredHostOperations Create(VkDevice device)
        {
            return new VulkanKHRDeferredHostOperations(device);
        }

        private IntPtr vkCreateDeferredOperationKHR_ptr;
        private IntPtr vkDeferredOperationJoinKHR_ptr;
        private IntPtr vkDestroyDeferredOperationKHR_ptr;
        private IntPtr vkGetDeferredOperationMaxConcurrencyKHR_ptr;
        private IntPtr vkGetDeferredOperationResultKHR_ptr;

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDeferredOperationKHR(VkDevice device, VkAllocationCallbacks* pAllocator, VkDeferredOperationKHR* pDeferredOperation)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDeferredOperationKHR(VkDevice device, VkAllocationCallbacks* pAllocator, out VkDeferredOperationKHR pDeferredOperation)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDeferredOperationKHR(VkDevice device, ref VkAllocationCallbacks pAllocator, VkDeferredOperationKHR* pDeferredOperation)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDeferredOperationKHR(VkDevice device, ref VkAllocationCallbacks pAllocator, out VkDeferredOperationKHR pDeferredOperation)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDeferredOperationKHR(VkDevice device, IntPtr pAllocator, VkDeferredOperationKHR* pDeferredOperation)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDeferredOperationKHR(VkDevice device, IntPtr pAllocator, out VkDeferredOperationKHR pDeferredOperation)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_THREAD_DONE_KHR, VK_THREAD_IDLE_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkDeferredOperationJoinKHR(VkDevice device, VkDeferredOperationKHR operation)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkDestroyDeferredOperationKHR(VkDevice device, VkDeferredOperationKHR operation, VkAllocationCallbacks* pAllocator)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkDestroyDeferredOperationKHR(VkDevice device, VkDeferredOperationKHR operation, ref VkAllocationCallbacks pAllocator)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkDestroyDeferredOperationKHR(VkDevice device, VkDeferredOperationKHR operation, IntPtr pAllocator)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe uint vkGetDeferredOperationMaxConcurrencyKHR(VkDevice device, VkDeferredOperationKHR operation)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_NOT_READY. Error codes:</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetDeferredOperationResultKHR(VkDevice device, VkDeferredOperationKHR operation)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanKHRDeferredHostOperations(VkDevice device)
        {
            vkCreateDeferredOperationKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCreateDeferredOperationKHR", true);
            vkDeferredOperationJoinKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkDeferredOperationJoinKHR", true);
            vkDestroyDeferredOperationKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkDestroyDeferredOperationKHR", true);
            vkGetDeferredOperationMaxConcurrencyKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetDeferredOperationMaxConcurrencyKHR", true);
            vkGetDeferredOperationResultKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetDeferredOperationResultKHR", true);
        }
    }

    public unsafe sealed class VulkanKHRPipelineExecutableProperties : IVulkanDeviceExtGeneric<VulkanKHRPipelineExecutableProperties>
    {
        public static string Name => "VK_KHR_pipeline_executable_properties";
        string IVulkanExt.GetName() => Name;

        public static VulkanKHRPipelineExecutableProperties Create(VkDevice device)
        {
            return new VulkanKHRPipelineExecutableProperties(device);
        }

        private IntPtr vkGetPipelineExecutableInternalRepresentationsKHR_ptr;
        private IntPtr vkGetPipelineExecutablePropertiesKHR_ptr;
        private IntPtr vkGetPipelineExecutableStatisticsKHR_ptr;

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPipelineExecutableInternalRepresentationsKHR(VkDevice device, VkPipelineExecutableInfoKHR* pExecutableInfo, uint* pInternalRepresentationCount, VkPipelineExecutableInternalRepresentationKHR* pInternalRepresentations)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPipelineExecutableInternalRepresentationsKHR(VkDevice device, VkPipelineExecutableInfoKHR* pExecutableInfo, uint* pInternalRepresentationCount, out VkPipelineExecutableInternalRepresentationKHR pInternalRepresentations)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPipelineExecutableInternalRepresentationsKHR(VkDevice device, VkPipelineExecutableInfoKHR* pExecutableInfo, ref uint pInternalRepresentationCount, VkPipelineExecutableInternalRepresentationKHR* pInternalRepresentations)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPipelineExecutableInternalRepresentationsKHR(VkDevice device, VkPipelineExecutableInfoKHR* pExecutableInfo, ref uint pInternalRepresentationCount, out VkPipelineExecutableInternalRepresentationKHR pInternalRepresentations)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPipelineExecutableInternalRepresentationsKHR(VkDevice device, VkPipelineExecutableInfoKHR* pExecutableInfo, IntPtr pInternalRepresentationCount, VkPipelineExecutableInternalRepresentationKHR* pInternalRepresentations)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPipelineExecutableInternalRepresentationsKHR(VkDevice device, VkPipelineExecutableInfoKHR* pExecutableInfo, IntPtr pInternalRepresentationCount, out VkPipelineExecutableInternalRepresentationKHR pInternalRepresentations)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPipelineExecutableInternalRepresentationsKHR(VkDevice device, ref VkPipelineExecutableInfoKHR pExecutableInfo, uint* pInternalRepresentationCount, VkPipelineExecutableInternalRepresentationKHR* pInternalRepresentations)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPipelineExecutableInternalRepresentationsKHR(VkDevice device, ref VkPipelineExecutableInfoKHR pExecutableInfo, uint* pInternalRepresentationCount, out VkPipelineExecutableInternalRepresentationKHR pInternalRepresentations)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPipelineExecutableInternalRepresentationsKHR(VkDevice device, ref VkPipelineExecutableInfoKHR pExecutableInfo, ref uint pInternalRepresentationCount, VkPipelineExecutableInternalRepresentationKHR* pInternalRepresentations)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPipelineExecutableInternalRepresentationsKHR(VkDevice device, ref VkPipelineExecutableInfoKHR pExecutableInfo, ref uint pInternalRepresentationCount, out VkPipelineExecutableInternalRepresentationKHR pInternalRepresentations)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPipelineExecutableInternalRepresentationsKHR(VkDevice device, ref VkPipelineExecutableInfoKHR pExecutableInfo, IntPtr pInternalRepresentationCount, VkPipelineExecutableInternalRepresentationKHR* pInternalRepresentations)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPipelineExecutableInternalRepresentationsKHR(VkDevice device, ref VkPipelineExecutableInfoKHR pExecutableInfo, IntPtr pInternalRepresentationCount, out VkPipelineExecutableInternalRepresentationKHR pInternalRepresentations)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPipelineExecutableInternalRepresentationsKHR(VkDevice device, IntPtr pExecutableInfo, uint* pInternalRepresentationCount, VkPipelineExecutableInternalRepresentationKHR* pInternalRepresentations)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPipelineExecutableInternalRepresentationsKHR(VkDevice device, IntPtr pExecutableInfo, uint* pInternalRepresentationCount, out VkPipelineExecutableInternalRepresentationKHR pInternalRepresentations)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPipelineExecutableInternalRepresentationsKHR(VkDevice device, IntPtr pExecutableInfo, ref uint pInternalRepresentationCount, VkPipelineExecutableInternalRepresentationKHR* pInternalRepresentations)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPipelineExecutableInternalRepresentationsKHR(VkDevice device, IntPtr pExecutableInfo, ref uint pInternalRepresentationCount, out VkPipelineExecutableInternalRepresentationKHR pInternalRepresentations)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPipelineExecutableInternalRepresentationsKHR(VkDevice device, IntPtr pExecutableInfo, IntPtr pInternalRepresentationCount, VkPipelineExecutableInternalRepresentationKHR* pInternalRepresentations)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPipelineExecutableInternalRepresentationsKHR(VkDevice device, IntPtr pExecutableInfo, IntPtr pInternalRepresentationCount, out VkPipelineExecutableInternalRepresentationKHR pInternalRepresentations)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPipelineExecutablePropertiesKHR(VkDevice device, VkPipelineInfoKHR* pPipelineInfo, uint* pExecutableCount, VkPipelineExecutablePropertiesKHR* pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPipelineExecutablePropertiesKHR(VkDevice device, VkPipelineInfoKHR* pPipelineInfo, uint* pExecutableCount, out VkPipelineExecutablePropertiesKHR pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPipelineExecutablePropertiesKHR(VkDevice device, VkPipelineInfoKHR* pPipelineInfo, ref uint pExecutableCount, VkPipelineExecutablePropertiesKHR* pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPipelineExecutablePropertiesKHR(VkDevice device, VkPipelineInfoKHR* pPipelineInfo, ref uint pExecutableCount, out VkPipelineExecutablePropertiesKHR pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPipelineExecutablePropertiesKHR(VkDevice device, VkPipelineInfoKHR* pPipelineInfo, IntPtr pExecutableCount, VkPipelineExecutablePropertiesKHR* pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPipelineExecutablePropertiesKHR(VkDevice device, VkPipelineInfoKHR* pPipelineInfo, IntPtr pExecutableCount, out VkPipelineExecutablePropertiesKHR pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPipelineExecutablePropertiesKHR(VkDevice device, ref VkPipelineInfoKHR pPipelineInfo, uint* pExecutableCount, VkPipelineExecutablePropertiesKHR* pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPipelineExecutablePropertiesKHR(VkDevice device, ref VkPipelineInfoKHR pPipelineInfo, uint* pExecutableCount, out VkPipelineExecutablePropertiesKHR pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPipelineExecutablePropertiesKHR(VkDevice device, ref VkPipelineInfoKHR pPipelineInfo, ref uint pExecutableCount, VkPipelineExecutablePropertiesKHR* pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPipelineExecutablePropertiesKHR(VkDevice device, ref VkPipelineInfoKHR pPipelineInfo, ref uint pExecutableCount, out VkPipelineExecutablePropertiesKHR pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPipelineExecutablePropertiesKHR(VkDevice device, ref VkPipelineInfoKHR pPipelineInfo, IntPtr pExecutableCount, VkPipelineExecutablePropertiesKHR* pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPipelineExecutablePropertiesKHR(VkDevice device, ref VkPipelineInfoKHR pPipelineInfo, IntPtr pExecutableCount, out VkPipelineExecutablePropertiesKHR pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPipelineExecutablePropertiesKHR(VkDevice device, IntPtr pPipelineInfo, uint* pExecutableCount, VkPipelineExecutablePropertiesKHR* pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPipelineExecutablePropertiesKHR(VkDevice device, IntPtr pPipelineInfo, uint* pExecutableCount, out VkPipelineExecutablePropertiesKHR pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPipelineExecutablePropertiesKHR(VkDevice device, IntPtr pPipelineInfo, ref uint pExecutableCount, VkPipelineExecutablePropertiesKHR* pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPipelineExecutablePropertiesKHR(VkDevice device, IntPtr pPipelineInfo, ref uint pExecutableCount, out VkPipelineExecutablePropertiesKHR pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPipelineExecutablePropertiesKHR(VkDevice device, IntPtr pPipelineInfo, IntPtr pExecutableCount, VkPipelineExecutablePropertiesKHR* pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPipelineExecutablePropertiesKHR(VkDevice device, IntPtr pPipelineInfo, IntPtr pExecutableCount, out VkPipelineExecutablePropertiesKHR pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPipelineExecutableStatisticsKHR(VkDevice device, VkPipelineExecutableInfoKHR* pExecutableInfo, uint* pStatisticCount, VkPipelineExecutableStatisticKHR* pStatistics)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPipelineExecutableStatisticsKHR(VkDevice device, VkPipelineExecutableInfoKHR* pExecutableInfo, uint* pStatisticCount, out VkPipelineExecutableStatisticKHR pStatistics)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPipelineExecutableStatisticsKHR(VkDevice device, VkPipelineExecutableInfoKHR* pExecutableInfo, ref uint pStatisticCount, VkPipelineExecutableStatisticKHR* pStatistics)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPipelineExecutableStatisticsKHR(VkDevice device, VkPipelineExecutableInfoKHR* pExecutableInfo, ref uint pStatisticCount, out VkPipelineExecutableStatisticKHR pStatistics)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPipelineExecutableStatisticsKHR(VkDevice device, VkPipelineExecutableInfoKHR* pExecutableInfo, IntPtr pStatisticCount, VkPipelineExecutableStatisticKHR* pStatistics)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPipelineExecutableStatisticsKHR(VkDevice device, VkPipelineExecutableInfoKHR* pExecutableInfo, IntPtr pStatisticCount, out VkPipelineExecutableStatisticKHR pStatistics)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPipelineExecutableStatisticsKHR(VkDevice device, ref VkPipelineExecutableInfoKHR pExecutableInfo, uint* pStatisticCount, VkPipelineExecutableStatisticKHR* pStatistics)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPipelineExecutableStatisticsKHR(VkDevice device, ref VkPipelineExecutableInfoKHR pExecutableInfo, uint* pStatisticCount, out VkPipelineExecutableStatisticKHR pStatistics)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPipelineExecutableStatisticsKHR(VkDevice device, ref VkPipelineExecutableInfoKHR pExecutableInfo, ref uint pStatisticCount, VkPipelineExecutableStatisticKHR* pStatistics)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPipelineExecutableStatisticsKHR(VkDevice device, ref VkPipelineExecutableInfoKHR pExecutableInfo, ref uint pStatisticCount, out VkPipelineExecutableStatisticKHR pStatistics)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPipelineExecutableStatisticsKHR(VkDevice device, ref VkPipelineExecutableInfoKHR pExecutableInfo, IntPtr pStatisticCount, VkPipelineExecutableStatisticKHR* pStatistics)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPipelineExecutableStatisticsKHR(VkDevice device, ref VkPipelineExecutableInfoKHR pExecutableInfo, IntPtr pStatisticCount, out VkPipelineExecutableStatisticKHR pStatistics)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPipelineExecutableStatisticsKHR(VkDevice device, IntPtr pExecutableInfo, uint* pStatisticCount, VkPipelineExecutableStatisticKHR* pStatistics)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPipelineExecutableStatisticsKHR(VkDevice device, IntPtr pExecutableInfo, uint* pStatisticCount, out VkPipelineExecutableStatisticKHR pStatistics)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPipelineExecutableStatisticsKHR(VkDevice device, IntPtr pExecutableInfo, ref uint pStatisticCount, VkPipelineExecutableStatisticKHR* pStatistics)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPipelineExecutableStatisticsKHR(VkDevice device, IntPtr pExecutableInfo, ref uint pStatisticCount, out VkPipelineExecutableStatisticKHR pStatistics)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPipelineExecutableStatisticsKHR(VkDevice device, IntPtr pExecutableInfo, IntPtr pStatisticCount, VkPipelineExecutableStatisticKHR* pStatistics)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPipelineExecutableStatisticsKHR(VkDevice device, IntPtr pExecutableInfo, IntPtr pStatisticCount, out VkPipelineExecutableStatisticKHR pStatistics)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanKHRPipelineExecutableProperties(VkDevice device)
        {
            vkGetPipelineExecutableInternalRepresentationsKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetPipelineExecutableInternalRepresentationsKHR", true);
            vkGetPipelineExecutablePropertiesKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetPipelineExecutablePropertiesKHR", true);
            vkGetPipelineExecutableStatisticsKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetPipelineExecutableStatisticsKHR", true);
        }
    }

    public unsafe sealed class VulkanEXTSwapchainMaintenance1 : IVulkanDeviceExtGeneric<VulkanEXTSwapchainMaintenance1>
    {
        public static string Name => "VK_EXT_swapchain_maintenance1";
        string IVulkanExt.GetName() => Name;

        public static VulkanEXTSwapchainMaintenance1 Create(VkDevice device)
        {
            return new VulkanEXTSwapchainMaintenance1(device);
        }

        private IntPtr vkReleaseSwapchainImagesEXT_ptr;

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkReleaseSwapchainImagesEXT(VkDevice device, VkReleaseSwapchainImagesInfoEXT* pReleaseInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkReleaseSwapchainImagesEXT(VkDevice device, ref VkReleaseSwapchainImagesInfoEXT pReleaseInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkReleaseSwapchainImagesEXT(VkDevice device, IntPtr pReleaseInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanEXTSwapchainMaintenance1(VkDevice device)
        {
            vkReleaseSwapchainImagesEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkReleaseSwapchainImagesEXT", true);
        }
    }

    public unsafe sealed class VulkanNVDeviceGeneratedCommands : IVulkanDeviceExtGeneric<VulkanNVDeviceGeneratedCommands>
    {
        public static string Name => "VK_NV_device_generated_commands";
        string IVulkanExt.GetName() => Name;

        public static VulkanNVDeviceGeneratedCommands Create(VkDevice device)
        {
            return new VulkanNVDeviceGeneratedCommands(device);
        }

        private IntPtr vkCmdBindPipelineShaderGroupNV_ptr;
        private IntPtr vkCmdExecuteGeneratedCommandsNV_ptr;
        private IntPtr vkCmdPreprocessGeneratedCommandsNV_ptr;
        private IntPtr vkCreateIndirectCommandsLayoutNV_ptr;
        private IntPtr vkDestroyIndirectCommandsLayoutNV_ptr;
        private IntPtr vkGetGeneratedCommandsMemoryRequirementsNV_ptr;

        [Generator.CalliRewrite]
        public unsafe void vkCmdBindPipelineShaderGroupNV(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline, uint groupIndex)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdExecuteGeneratedCommandsNV(VkCommandBuffer commandBuffer, VkBool32 isPreprocessed, VkGeneratedCommandsInfoNV* pGeneratedCommandsInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdExecuteGeneratedCommandsNV(VkCommandBuffer commandBuffer, VkBool32 isPreprocessed, ref VkGeneratedCommandsInfoNV pGeneratedCommandsInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdExecuteGeneratedCommandsNV(VkCommandBuffer commandBuffer, VkBool32 isPreprocessed, IntPtr pGeneratedCommandsInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdPreprocessGeneratedCommandsNV(VkCommandBuffer commandBuffer, VkGeneratedCommandsInfoNV* pGeneratedCommandsInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdPreprocessGeneratedCommandsNV(VkCommandBuffer commandBuffer, ref VkGeneratedCommandsInfoNV pGeneratedCommandsInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdPreprocessGeneratedCommandsNV(VkCommandBuffer commandBuffer, IntPtr pGeneratedCommandsInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateIndirectCommandsLayoutNV(VkDevice device, VkIndirectCommandsLayoutCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, VkIndirectCommandsLayoutNV* pIndirectCommandsLayout)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateIndirectCommandsLayoutNV(VkDevice device, VkIndirectCommandsLayoutCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkIndirectCommandsLayoutNV pIndirectCommandsLayout)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateIndirectCommandsLayoutNV(VkDevice device, VkIndirectCommandsLayoutCreateInfoNV* pCreateInfo, ref VkAllocationCallbacks pAllocator, VkIndirectCommandsLayoutNV* pIndirectCommandsLayout)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateIndirectCommandsLayoutNV(VkDevice device, VkIndirectCommandsLayoutCreateInfoNV* pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkIndirectCommandsLayoutNV pIndirectCommandsLayout)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateIndirectCommandsLayoutNV(VkDevice device, VkIndirectCommandsLayoutCreateInfoNV* pCreateInfo, IntPtr pAllocator, VkIndirectCommandsLayoutNV* pIndirectCommandsLayout)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateIndirectCommandsLayoutNV(VkDevice device, VkIndirectCommandsLayoutCreateInfoNV* pCreateInfo, IntPtr pAllocator, out VkIndirectCommandsLayoutNV pIndirectCommandsLayout)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateIndirectCommandsLayoutNV(VkDevice device, ref VkIndirectCommandsLayoutCreateInfoNV pCreateInfo, VkAllocationCallbacks* pAllocator, VkIndirectCommandsLayoutNV* pIndirectCommandsLayout)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateIndirectCommandsLayoutNV(VkDevice device, ref VkIndirectCommandsLayoutCreateInfoNV pCreateInfo, VkAllocationCallbacks* pAllocator, out VkIndirectCommandsLayoutNV pIndirectCommandsLayout)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateIndirectCommandsLayoutNV(VkDevice device, ref VkIndirectCommandsLayoutCreateInfoNV pCreateInfo, ref VkAllocationCallbacks pAllocator, VkIndirectCommandsLayoutNV* pIndirectCommandsLayout)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateIndirectCommandsLayoutNV(VkDevice device, ref VkIndirectCommandsLayoutCreateInfoNV pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkIndirectCommandsLayoutNV pIndirectCommandsLayout)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateIndirectCommandsLayoutNV(VkDevice device, ref VkIndirectCommandsLayoutCreateInfoNV pCreateInfo, IntPtr pAllocator, VkIndirectCommandsLayoutNV* pIndirectCommandsLayout)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateIndirectCommandsLayoutNV(VkDevice device, ref VkIndirectCommandsLayoutCreateInfoNV pCreateInfo, IntPtr pAllocator, out VkIndirectCommandsLayoutNV pIndirectCommandsLayout)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateIndirectCommandsLayoutNV(VkDevice device, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, VkIndirectCommandsLayoutNV* pIndirectCommandsLayout)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateIndirectCommandsLayoutNV(VkDevice device, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, out VkIndirectCommandsLayoutNV pIndirectCommandsLayout)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateIndirectCommandsLayoutNV(VkDevice device, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, VkIndirectCommandsLayoutNV* pIndirectCommandsLayout)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateIndirectCommandsLayoutNV(VkDevice device, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkIndirectCommandsLayoutNV pIndirectCommandsLayout)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateIndirectCommandsLayoutNV(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, VkIndirectCommandsLayoutNV* pIndirectCommandsLayout)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateIndirectCommandsLayoutNV(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, out VkIndirectCommandsLayoutNV pIndirectCommandsLayout)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkDestroyIndirectCommandsLayoutNV(VkDevice device, VkIndirectCommandsLayoutNV indirectCommandsLayout, VkAllocationCallbacks* pAllocator)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkDestroyIndirectCommandsLayoutNV(VkDevice device, VkIndirectCommandsLayoutNV indirectCommandsLayout, ref VkAllocationCallbacks pAllocator)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkDestroyIndirectCommandsLayoutNV(VkDevice device, VkIndirectCommandsLayoutNV indirectCommandsLayout, IntPtr pAllocator)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetGeneratedCommandsMemoryRequirementsNV(VkDevice device, VkGeneratedCommandsMemoryRequirementsInfoNV* pInfo, VkMemoryRequirements2* pMemoryRequirements)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetGeneratedCommandsMemoryRequirementsNV(VkDevice device, VkGeneratedCommandsMemoryRequirementsInfoNV* pInfo, out VkMemoryRequirements2 pMemoryRequirements)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetGeneratedCommandsMemoryRequirementsNV(VkDevice device, ref VkGeneratedCommandsMemoryRequirementsInfoNV pInfo, VkMemoryRequirements2* pMemoryRequirements)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetGeneratedCommandsMemoryRequirementsNV(VkDevice device, ref VkGeneratedCommandsMemoryRequirementsInfoNV pInfo, out VkMemoryRequirements2 pMemoryRequirements)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetGeneratedCommandsMemoryRequirementsNV(VkDevice device, IntPtr pInfo, VkMemoryRequirements2* pMemoryRequirements)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetGeneratedCommandsMemoryRequirementsNV(VkDevice device, IntPtr pInfo, out VkMemoryRequirements2 pMemoryRequirements)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanNVDeviceGeneratedCommands(VkDevice device)
        {
            vkCmdBindPipelineShaderGroupNV_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdBindPipelineShaderGroupNV", true);
            vkCmdExecuteGeneratedCommandsNV_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdExecuteGeneratedCommandsNV", true);
            vkCmdPreprocessGeneratedCommandsNV_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdPreprocessGeneratedCommandsNV", true);
            vkCreateIndirectCommandsLayoutNV_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCreateIndirectCommandsLayoutNV", true);
            vkDestroyIndirectCommandsLayoutNV_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkDestroyIndirectCommandsLayoutNV", true);
            vkGetGeneratedCommandsMemoryRequirementsNV_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetGeneratedCommandsMemoryRequirementsNV", true);
        }
    }

    public unsafe sealed class VulkanEXTAcquireDrmDisplay : IVulkanInstanceExtGeneric<VulkanEXTAcquireDrmDisplay>
    {
        public static string Name => "VK_EXT_acquire_drm_display";
        string IVulkanExt.GetName() => Name;

        public static VulkanEXTAcquireDrmDisplay Create(VkInstance instance)
        {
            return new VulkanEXTAcquireDrmDisplay(instance);
        }

        private IntPtr vkAcquireDrmDisplayEXT_ptr;
        private IntPtr vkGetDrmDisplayEXT_ptr;

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkAcquireDrmDisplayEXT(VkPhysicalDevice physicalDevice, int drmFd, VkDisplayKHR display)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetDrmDisplayEXT(VkPhysicalDevice physicalDevice, int drmFd, uint connectorId, VkDisplayKHR* display)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetDrmDisplayEXT(VkPhysicalDevice physicalDevice, int drmFd, uint connectorId, out VkDisplayKHR display)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanEXTAcquireDrmDisplay(VkInstance instance)
        {
            vkAcquireDrmDisplayEXT_ptr = VulkanNative.LoadInstanceProcAddr(instance, "vkAcquireDrmDisplayEXT", true);
            vkGetDrmDisplayEXT_ptr = VulkanNative.LoadInstanceProcAddr(instance, "vkGetDrmDisplayEXT", true);
        }
    }

    public unsafe sealed class VulkanEXTPrivateData : IVulkanDeviceExtGeneric<VulkanEXTPrivateData>
    {
        public static string Name => "VK_EXT_private_data";
        string IVulkanExt.GetName() => Name;

        public static VulkanEXTPrivateData Create(VkDevice device)
        {
            return new VulkanEXTPrivateData(device);
        }



        public VulkanEXTPrivateData(VkDevice device)
        {
        }
    }

    public unsafe sealed class VulkanKHRVideoEncodeQueue : IVulkanDeviceExtGeneric<VulkanKHRVideoEncodeQueue>
    {
        public static string Name => "VK_KHR_video_encode_queue";
        string IVulkanExt.GetName() => Name;

        public static VulkanKHRVideoEncodeQueue Create(VkDevice device)
        {
            return new VulkanKHRVideoEncodeQueue(device);
        }

        private IntPtr vkCmdEncodeVideoKHR_ptr;

        [Generator.CalliRewrite]
        public unsafe void vkCmdEncodeVideoKHR(VkCommandBuffer commandBuffer, VkVideoEncodeInfoKHR* pEncodeInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdEncodeVideoKHR(VkCommandBuffer commandBuffer, ref VkVideoEncodeInfoKHR pEncodeInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdEncodeVideoKHR(VkCommandBuffer commandBuffer, IntPtr pEncodeInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanKHRVideoEncodeQueue(VkDevice device)
        {
            vkCmdEncodeVideoKHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdEncodeVideoKHR", true);
        }
    }

    public unsafe sealed class VulkanEXTMetalObjects : IVulkanDeviceExtGeneric<VulkanEXTMetalObjects>
    {
        public static string Name => "VK_EXT_metal_objects";
        string IVulkanExt.GetName() => Name;

        public static VulkanEXTMetalObjects Create(VkDevice device)
        {
            return new VulkanEXTMetalObjects(device);
        }

        private IntPtr vkExportMetalObjectsEXT_ptr;

        [Generator.CalliRewrite]
        public unsafe void vkExportMetalObjectsEXT(VkDevice device, VkExportMetalObjectsInfoEXT* pMetalObjectsInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkExportMetalObjectsEXT(VkDevice device, ref VkExportMetalObjectsInfoEXT pMetalObjectsInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkExportMetalObjectsEXT(VkDevice device, IntPtr pMetalObjectsInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanEXTMetalObjects(VkDevice device)
        {
            vkExportMetalObjectsEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkExportMetalObjectsEXT", true);
        }
    }

    public unsafe sealed class VulkanKHRSynchronization2 : IVulkanDeviceExtGeneric<VulkanKHRSynchronization2>
    {
        public static string Name => "VK_KHR_synchronization2";
        string IVulkanExt.GetName() => Name;

        public static VulkanKHRSynchronization2 Create(VkDevice device)
        {
            return new VulkanKHRSynchronization2(device);
        }

        private IntPtr vkCmdWriteBufferMarker2AMD_ptr;
        private IntPtr vkGetQueueCheckpointData2NV_ptr;

        [Generator.CalliRewrite]
        public unsafe void vkCmdWriteBufferMarker2AMD(VkCommandBuffer commandBuffer, uint stage, VkBuffer dstBuffer, ulong dstOffset, uint marker)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetQueueCheckpointData2NV(VkQueue queue, uint* pCheckpointDataCount, VkCheckpointData2NV* pCheckpointData)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetQueueCheckpointData2NV(VkQueue queue, uint* pCheckpointDataCount, out VkCheckpointData2NV pCheckpointData)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetQueueCheckpointData2NV(VkQueue queue, ref uint pCheckpointDataCount, VkCheckpointData2NV* pCheckpointData)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetQueueCheckpointData2NV(VkQueue queue, ref uint pCheckpointDataCount, out VkCheckpointData2NV pCheckpointData)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetQueueCheckpointData2NV(VkQueue queue, IntPtr pCheckpointDataCount, VkCheckpointData2NV* pCheckpointData)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetQueueCheckpointData2NV(VkQueue queue, IntPtr pCheckpointDataCount, out VkCheckpointData2NV pCheckpointData)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanKHRSynchronization2(VkDevice device)
        {
            vkCmdWriteBufferMarker2AMD_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdWriteBufferMarker2AMD", true);
            vkGetQueueCheckpointData2NV_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetQueueCheckpointData2NV", true);
        }
    }

    public unsafe sealed class VulkanEXTDescriptorBuffer : IVulkanDeviceExtGeneric<VulkanEXTDescriptorBuffer>
    {
        public static string Name => "VK_EXT_descriptor_buffer";
        string IVulkanExt.GetName() => Name;

        public static VulkanEXTDescriptorBuffer Create(VkDevice device)
        {
            return new VulkanEXTDescriptorBuffer(device);
        }

        private IntPtr vkCmdBindDescriptorBufferEmbeddedSamplersEXT_ptr;
        private IntPtr vkCmdBindDescriptorBuffersEXT_ptr;
        private IntPtr vkCmdSetDescriptorBufferOffsetsEXT_ptr;
        private IntPtr vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT_ptr;
        private IntPtr vkGetBufferOpaqueCaptureDescriptorDataEXT_ptr;
        private IntPtr vkGetDescriptorEXT_ptr;
        private IntPtr vkGetDescriptorSetLayoutBindingOffsetEXT_ptr;
        private IntPtr vkGetDescriptorSetLayoutSizeEXT_ptr;
        private IntPtr vkGetImageOpaqueCaptureDescriptorDataEXT_ptr;
        private IntPtr vkGetImageViewOpaqueCaptureDescriptorDataEXT_ptr;
        private IntPtr vkGetSamplerOpaqueCaptureDescriptorDataEXT_ptr;

        [Generator.CalliRewrite]
        public unsafe void vkCmdBindDescriptorBufferEmbeddedSamplersEXT(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint set)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBindDescriptorBuffersEXT(VkCommandBuffer commandBuffer, uint bufferCount, VkDescriptorBufferBindingInfoEXT* pBindingInfos)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBindDescriptorBuffersEXT(VkCommandBuffer commandBuffer, uint bufferCount, ref VkDescriptorBufferBindingInfoEXT pBindingInfos)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBindDescriptorBuffersEXT(VkCommandBuffer commandBuffer, uint bufferCount, IntPtr pBindingInfos)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBindDescriptorBuffersEXT(VkCommandBuffer commandBuffer, uint bufferCount, VkDescriptorBufferBindingInfoEXT[] pBindingInfos)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetDescriptorBufferOffsetsEXT(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint firstSet, uint setCount, uint* pBufferIndices, ulong* pOffsets)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetDescriptorBufferOffsetsEXT(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint firstSet, uint setCount, uint* pBufferIndices, ref ulong pOffsets)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetDescriptorBufferOffsetsEXT(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint firstSet, uint setCount, uint* pBufferIndices, IntPtr pOffsets)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetDescriptorBufferOffsetsEXT(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint firstSet, uint setCount, ref uint pBufferIndices, ulong* pOffsets)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetDescriptorBufferOffsetsEXT(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint firstSet, uint setCount, ref uint pBufferIndices, ref ulong pOffsets)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetDescriptorBufferOffsetsEXT(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint firstSet, uint setCount, ref uint pBufferIndices, IntPtr pOffsets)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetDescriptorBufferOffsetsEXT(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint firstSet, uint setCount, IntPtr pBufferIndices, ulong* pOffsets)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetDescriptorBufferOffsetsEXT(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint firstSet, uint setCount, IntPtr pBufferIndices, ref ulong pOffsets)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetDescriptorBufferOffsetsEXT(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint firstSet, uint setCount, IntPtr pBufferIndices, IntPtr pOffsets)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT(VkDevice device, VkAccelerationStructureCaptureDescriptorDataInfoEXT* pInfo, void* pData)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT(VkDevice device, ref VkAccelerationStructureCaptureDescriptorDataInfoEXT pInfo, void* pData)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT(VkDevice device, IntPtr pInfo, void* pData)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetBufferOpaqueCaptureDescriptorDataEXT(VkDevice device, VkBufferCaptureDescriptorDataInfoEXT* pInfo, void* pData)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetBufferOpaqueCaptureDescriptorDataEXT(VkDevice device, ref VkBufferCaptureDescriptorDataInfoEXT pInfo, void* pData)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetBufferOpaqueCaptureDescriptorDataEXT(VkDevice device, IntPtr pInfo, void* pData)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetDescriptorEXT(VkDevice device, VkDescriptorGetInfoEXT* pDescriptorInfo, UIntPtr dataSize, void* pDescriptor)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetDescriptorEXT(VkDevice device, ref VkDescriptorGetInfoEXT pDescriptorInfo, UIntPtr dataSize, void* pDescriptor)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetDescriptorEXT(VkDevice device, IntPtr pDescriptorInfo, UIntPtr dataSize, void* pDescriptor)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetDescriptorSetLayoutBindingOffsetEXT(VkDevice device, VkDescriptorSetLayout layout, uint binding, ulong* pOffset)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetDescriptorSetLayoutBindingOffsetEXT(VkDevice device, VkDescriptorSetLayout layout, uint binding, out ulong pOffset)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetDescriptorSetLayoutSizeEXT(VkDevice device, VkDescriptorSetLayout layout, ulong* pLayoutSizeInBytes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetDescriptorSetLayoutSizeEXT(VkDevice device, VkDescriptorSetLayout layout, out ulong pLayoutSizeInBytes)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetImageOpaqueCaptureDescriptorDataEXT(VkDevice device, VkImageCaptureDescriptorDataInfoEXT* pInfo, void* pData)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetImageOpaqueCaptureDescriptorDataEXT(VkDevice device, ref VkImageCaptureDescriptorDataInfoEXT pInfo, void* pData)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetImageOpaqueCaptureDescriptorDataEXT(VkDevice device, IntPtr pInfo, void* pData)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetImageViewOpaqueCaptureDescriptorDataEXT(VkDevice device, VkImageViewCaptureDescriptorDataInfoEXT* pInfo, void* pData)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetImageViewOpaqueCaptureDescriptorDataEXT(VkDevice device, ref VkImageViewCaptureDescriptorDataInfoEXT pInfo, void* pData)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetImageViewOpaqueCaptureDescriptorDataEXT(VkDevice device, IntPtr pInfo, void* pData)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetSamplerOpaqueCaptureDescriptorDataEXT(VkDevice device, VkSamplerCaptureDescriptorDataInfoEXT* pInfo, void* pData)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetSamplerOpaqueCaptureDescriptorDataEXT(VkDevice device, ref VkSamplerCaptureDescriptorDataInfoEXT pInfo, void* pData)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetSamplerOpaqueCaptureDescriptorDataEXT(VkDevice device, IntPtr pInfo, void* pData)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanEXTDescriptorBuffer(VkDevice device)
        {
            vkCmdBindDescriptorBufferEmbeddedSamplersEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdBindDescriptorBufferEmbeddedSamplersEXT", true);
            vkCmdBindDescriptorBuffersEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdBindDescriptorBuffersEXT", true);
            vkCmdSetDescriptorBufferOffsetsEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdSetDescriptorBufferOffsetsEXT", true);
            vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT", true);
            vkGetBufferOpaqueCaptureDescriptorDataEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetBufferOpaqueCaptureDescriptorDataEXT", true);
            vkGetDescriptorEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetDescriptorEXT", true);
            vkGetDescriptorSetLayoutBindingOffsetEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetDescriptorSetLayoutBindingOffsetEXT", true);
            vkGetDescriptorSetLayoutSizeEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetDescriptorSetLayoutSizeEXT", true);
            vkGetImageOpaqueCaptureDescriptorDataEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetImageOpaqueCaptureDescriptorDataEXT", true);
            vkGetImageViewOpaqueCaptureDescriptorDataEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetImageViewOpaqueCaptureDescriptorDataEXT", true);
            vkGetSamplerOpaqueCaptureDescriptorDataEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetSamplerOpaqueCaptureDescriptorDataEXT", true);
        }
    }

    public unsafe sealed class VulkanNVFragmentShadingRateEnums : IVulkanDeviceExtGeneric<VulkanNVFragmentShadingRateEnums>
    {
        public static string Name => "VK_NV_fragment_shading_rate_enums";
        string IVulkanExt.GetName() => Name;

        public static VulkanNVFragmentShadingRateEnums Create(VkDevice device)
        {
            return new VulkanNVFragmentShadingRateEnums(device);
        }

        private IntPtr vkCmdSetFragmentShadingRateEnumNV_ptr;

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetFragmentShadingRateEnumNV(VkCommandBuffer commandBuffer, VkFragmentShadingRateNV shadingRate, VkFragmentShadingRateCombinerOpKHR combinerOps)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanNVFragmentShadingRateEnums(VkDevice device)
        {
            vkCmdSetFragmentShadingRateEnumNV_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdSetFragmentShadingRateEnumNV", true);
        }
    }

    public unsafe sealed class VulkanEXTMeshShader : IVulkanDeviceExtGeneric<VulkanEXTMeshShader>
    {
        public static string Name => "VK_EXT_mesh_shader";
        string IVulkanExt.GetName() => Name;

        public static VulkanEXTMeshShader Create(VkDevice device)
        {
            return new VulkanEXTMeshShader(device);
        }

        private IntPtr vkCmdDrawMeshTasksEXT_ptr;
        private IntPtr vkCmdDrawMeshTasksIndirectCountEXT_ptr;
        private IntPtr vkCmdDrawMeshTasksIndirectEXT_ptr;

        [Generator.CalliRewrite]
        public unsafe void vkCmdDrawMeshTasksEXT(VkCommandBuffer commandBuffer, uint groupCountX, uint groupCountY, uint groupCountZ)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdDrawMeshTasksIndirectCountEXT(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdDrawMeshTasksIndirectEXT(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, uint drawCount, uint stride)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanEXTMeshShader(VkDevice device)
        {
            vkCmdDrawMeshTasksEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdDrawMeshTasksEXT", true);
            vkCmdDrawMeshTasksIndirectCountEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdDrawMeshTasksIndirectCountEXT", true);
            vkCmdDrawMeshTasksIndirectEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdDrawMeshTasksIndirectEXT", true);
        }
    }

    public unsafe sealed class VulkanKHRCopyCommands2 : IVulkanDeviceExtGeneric<VulkanKHRCopyCommands2>
    {
        public static string Name => "VK_KHR_copy_commands2";
        string IVulkanExt.GetName() => Name;

        public static VulkanKHRCopyCommands2 Create(VkDevice device)
        {
            return new VulkanKHRCopyCommands2(device);
        }



        public VulkanKHRCopyCommands2(VkDevice device)
        {
        }
    }

    public unsafe sealed class VulkanEXTImageCompressionControl : IVulkanDeviceExtGeneric<VulkanEXTImageCompressionControl>
    {
        public static string Name => "VK_EXT_image_compression_control";
        string IVulkanExt.GetName() => Name;

        public static VulkanEXTImageCompressionControl Create(VkDevice device)
        {
            return new VulkanEXTImageCompressionControl(device);
        }

        private IntPtr vkGetImageSubresourceLayout2EXT_ptr;

        [Generator.CalliRewrite]
        public unsafe void vkGetImageSubresourceLayout2EXT(VkDevice device, VkImage image, VkImageSubresource2EXT* pSubresource, VkSubresourceLayout2EXT* pLayout)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetImageSubresourceLayout2EXT(VkDevice device, VkImage image, VkImageSubresource2EXT* pSubresource, out VkSubresourceLayout2EXT pLayout)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetImageSubresourceLayout2EXT(VkDevice device, VkImage image, ref VkImageSubresource2EXT pSubresource, VkSubresourceLayout2EXT* pLayout)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetImageSubresourceLayout2EXT(VkDevice device, VkImage image, ref VkImageSubresource2EXT pSubresource, out VkSubresourceLayout2EXT pLayout)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetImageSubresourceLayout2EXT(VkDevice device, VkImage image, IntPtr pSubresource, VkSubresourceLayout2EXT* pLayout)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetImageSubresourceLayout2EXT(VkDevice device, VkImage image, IntPtr pSubresource, out VkSubresourceLayout2EXT pLayout)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanEXTImageCompressionControl(VkDevice device)
        {
            vkGetImageSubresourceLayout2EXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetImageSubresourceLayout2EXT", true);
        }
    }

    public unsafe sealed class VulkanEXTDeviceFault : IVulkanDeviceExtGeneric<VulkanEXTDeviceFault>
    {
        public static string Name => "VK_EXT_device_fault";
        string IVulkanExt.GetName() => Name;

        public static VulkanEXTDeviceFault Create(VkDevice device)
        {
            return new VulkanEXTDeviceFault(device);
        }

        private IntPtr vkGetDeviceFaultInfoEXT_ptr;

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetDeviceFaultInfoEXT(VkDevice device, VkDeviceFaultCountsEXT* pFaultCounts, VkDeviceFaultInfoEXT* pFaultInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetDeviceFaultInfoEXT(VkDevice device, VkDeviceFaultCountsEXT* pFaultCounts, out VkDeviceFaultInfoEXT pFaultInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetDeviceFaultInfoEXT(VkDevice device, ref VkDeviceFaultCountsEXT pFaultCounts, VkDeviceFaultInfoEXT* pFaultInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetDeviceFaultInfoEXT(VkDevice device, ref VkDeviceFaultCountsEXT pFaultCounts, out VkDeviceFaultInfoEXT pFaultInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetDeviceFaultInfoEXT(VkDevice device, IntPtr pFaultCounts, VkDeviceFaultInfoEXT* pFaultInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetDeviceFaultInfoEXT(VkDevice device, IntPtr pFaultCounts, out VkDeviceFaultInfoEXT pFaultInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanEXTDeviceFault(VkDevice device)
        {
            vkGetDeviceFaultInfoEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetDeviceFaultInfoEXT", true);
        }
    }

    public unsafe sealed class VulkanNVAcquireWinrtDisplay : IVulkanDeviceExtGeneric<VulkanNVAcquireWinrtDisplay>
    {
        public static string Name => "VK_NV_acquire_winrt_display";
        string IVulkanExt.GetName() => Name;

        public static VulkanNVAcquireWinrtDisplay Create(VkDevice device)
        {
            return new VulkanNVAcquireWinrtDisplay(device);
        }

        private IntPtr vkAcquireWinrtDisplayNV_ptr;
        private IntPtr vkGetWinrtDisplayNV_ptr;

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkAcquireWinrtDisplayNV(VkPhysicalDevice physicalDevice, VkDisplayKHR display)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetWinrtDisplayNV(VkPhysicalDevice physicalDevice, uint deviceRelativeId, VkDisplayKHR* pDisplay)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetWinrtDisplayNV(VkPhysicalDevice physicalDevice, uint deviceRelativeId, out VkDisplayKHR pDisplay)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanNVAcquireWinrtDisplay(VkDevice device)
        {
            vkAcquireWinrtDisplayNV_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkAcquireWinrtDisplayNV", true);
            vkGetWinrtDisplayNV_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetWinrtDisplayNV", true);
        }
    }

    public unsafe sealed class VulkanEXTDirectfbSurface : IVulkanInstanceExtGeneric<VulkanEXTDirectfbSurface>
    {
        public static string Name => "VK_EXT_directfb_surface";
        string IVulkanExt.GetName() => Name;

        public static VulkanEXTDirectfbSurface Create(VkInstance instance)
        {
            return new VulkanEXTDirectfbSurface(instance);
        }

        private IntPtr vkCreateDirectFBSurfaceEXT_ptr;
        private IntPtr vkGetPhysicalDeviceDirectFBPresentationSupportEXT_ptr;

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDirectFBSurfaceEXT(VkInstance instance, VkDirectFBSurfaceCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDirectFBSurfaceEXT(VkInstance instance, VkDirectFBSurfaceCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDirectFBSurfaceEXT(VkInstance instance, VkDirectFBSurfaceCreateInfoEXT* pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDirectFBSurfaceEXT(VkInstance instance, VkDirectFBSurfaceCreateInfoEXT* pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDirectFBSurfaceEXT(VkInstance instance, VkDirectFBSurfaceCreateInfoEXT* pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDirectFBSurfaceEXT(VkInstance instance, VkDirectFBSurfaceCreateInfoEXT* pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDirectFBSurfaceEXT(VkInstance instance, ref VkDirectFBSurfaceCreateInfoEXT pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDirectFBSurfaceEXT(VkInstance instance, ref VkDirectFBSurfaceCreateInfoEXT pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDirectFBSurfaceEXT(VkInstance instance, ref VkDirectFBSurfaceCreateInfoEXT pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDirectFBSurfaceEXT(VkInstance instance, ref VkDirectFBSurfaceCreateInfoEXT pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDirectFBSurfaceEXT(VkInstance instance, ref VkDirectFBSurfaceCreateInfoEXT pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDirectFBSurfaceEXT(VkInstance instance, ref VkDirectFBSurfaceCreateInfoEXT pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDirectFBSurfaceEXT(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDirectFBSurfaceEXT(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDirectFBSurfaceEXT(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDirectFBSurfaceEXT(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDirectFBSurfaceEXT(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateDirectFBSurfaceEXT(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe VkBool32 vkGetPhysicalDeviceDirectFBPresentationSupportEXT(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, DirectFB.IDirectFB* dfb)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe VkBool32 vkGetPhysicalDeviceDirectFBPresentationSupportEXT(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, out DirectFB.IDirectFB dfb)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanEXTDirectfbSurface(VkInstance instance)
        {
            vkCreateDirectFBSurfaceEXT_ptr = VulkanNative.LoadInstanceProcAddr(instance, "vkCreateDirectFBSurfaceEXT", true);
            vkGetPhysicalDeviceDirectFBPresentationSupportEXT_ptr = VulkanNative.LoadInstanceProcAddr(instance, "vkGetPhysicalDeviceDirectFBPresentationSupportEXT", true);
        }
    }

    public unsafe sealed class VulkanEXTVertexInputDynamicState : IVulkanDeviceExtGeneric<VulkanEXTVertexInputDynamicState>
    {
        public static string Name => "VK_EXT_vertex_input_dynamic_state";
        string IVulkanExt.GetName() => Name;

        public static VulkanEXTVertexInputDynamicState Create(VkDevice device)
        {
            return new VulkanEXTVertexInputDynamicState(device);
        }

        private IntPtr vkCmdSetVertexInputEXT_ptr;

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetVertexInputEXT(VkCommandBuffer commandBuffer, uint vertexBindingDescriptionCount, VkVertexInputBindingDescription2EXT* pVertexBindingDescriptions, uint vertexAttributeDescriptionCount, VkVertexInputAttributeDescription2EXT* pVertexAttributeDescriptions)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetVertexInputEXT(VkCommandBuffer commandBuffer, uint vertexBindingDescriptionCount, VkVertexInputBindingDescription2EXT* pVertexBindingDescriptions, uint vertexAttributeDescriptionCount, ref VkVertexInputAttributeDescription2EXT pVertexAttributeDescriptions)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetVertexInputEXT(VkCommandBuffer commandBuffer, uint vertexBindingDescriptionCount, VkVertexInputBindingDescription2EXT* pVertexBindingDescriptions, uint vertexAttributeDescriptionCount, IntPtr pVertexAttributeDescriptions)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetVertexInputEXT(VkCommandBuffer commandBuffer, uint vertexBindingDescriptionCount, ref VkVertexInputBindingDescription2EXT pVertexBindingDescriptions, uint vertexAttributeDescriptionCount, VkVertexInputAttributeDescription2EXT* pVertexAttributeDescriptions)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetVertexInputEXT(VkCommandBuffer commandBuffer, uint vertexBindingDescriptionCount, ref VkVertexInputBindingDescription2EXT pVertexBindingDescriptions, uint vertexAttributeDescriptionCount, ref VkVertexInputAttributeDescription2EXT pVertexAttributeDescriptions)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetVertexInputEXT(VkCommandBuffer commandBuffer, uint vertexBindingDescriptionCount, ref VkVertexInputBindingDescription2EXT pVertexBindingDescriptions, uint vertexAttributeDescriptionCount, IntPtr pVertexAttributeDescriptions)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetVertexInputEXT(VkCommandBuffer commandBuffer, uint vertexBindingDescriptionCount, IntPtr pVertexBindingDescriptions, uint vertexAttributeDescriptionCount, VkVertexInputAttributeDescription2EXT* pVertexAttributeDescriptions)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetVertexInputEXT(VkCommandBuffer commandBuffer, uint vertexBindingDescriptionCount, IntPtr pVertexBindingDescriptions, uint vertexAttributeDescriptionCount, ref VkVertexInputAttributeDescription2EXT pVertexAttributeDescriptions)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetVertexInputEXT(VkCommandBuffer commandBuffer, uint vertexBindingDescriptionCount, IntPtr pVertexBindingDescriptions, uint vertexAttributeDescriptionCount, IntPtr pVertexAttributeDescriptions)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanEXTVertexInputDynamicState(VkDevice device)
        {
            vkCmdSetVertexInputEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdSetVertexInputEXT", true);
        }
    }

    public unsafe sealed class VulkanFuchsiaExternalMemory : IVulkanDeviceExtGeneric<VulkanFuchsiaExternalMemory>
    {
        public static string Name => "VK_FUCHSIA_external_memory";
        string IVulkanExt.GetName() => Name;

        public static VulkanFuchsiaExternalMemory Create(VkDevice device)
        {
            return new VulkanFuchsiaExternalMemory(device);
        }

        private IntPtr vkGetMemoryZirconHandleFUCHSIA_ptr;
        private IntPtr vkGetMemoryZirconHandlePropertiesFUCHSIA_ptr;

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetMemoryZirconHandleFUCHSIA(VkDevice device, VkMemoryGetZirconHandleInfoFUCHSIA* pGetZirconHandleInfo, Zircon.ZXHandle* pZirconHandle)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetMemoryZirconHandleFUCHSIA(VkDevice device, VkMemoryGetZirconHandleInfoFUCHSIA* pGetZirconHandleInfo, out Zircon.ZXHandle pZirconHandle)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetMemoryZirconHandleFUCHSIA(VkDevice device, ref VkMemoryGetZirconHandleInfoFUCHSIA pGetZirconHandleInfo, Zircon.ZXHandle* pZirconHandle)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetMemoryZirconHandleFUCHSIA(VkDevice device, ref VkMemoryGetZirconHandleInfoFUCHSIA pGetZirconHandleInfo, out Zircon.ZXHandle pZirconHandle)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetMemoryZirconHandleFUCHSIA(VkDevice device, IntPtr pGetZirconHandleInfo, Zircon.ZXHandle* pZirconHandle)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetMemoryZirconHandleFUCHSIA(VkDevice device, IntPtr pGetZirconHandleInfo, out Zircon.ZXHandle pZirconHandle)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_INVALID_EXTERNAL_HANDLE</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetMemoryZirconHandlePropertiesFUCHSIA(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, Zircon.ZXHandle zirconHandle, VkMemoryZirconHandlePropertiesFUCHSIA* pMemoryZirconHandleProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_INVALID_EXTERNAL_HANDLE</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetMemoryZirconHandlePropertiesFUCHSIA(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, Zircon.ZXHandle zirconHandle, out VkMemoryZirconHandlePropertiesFUCHSIA pMemoryZirconHandleProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanFuchsiaExternalMemory(VkDevice device)
        {
            vkGetMemoryZirconHandleFUCHSIA_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetMemoryZirconHandleFUCHSIA", true);
            vkGetMemoryZirconHandlePropertiesFUCHSIA_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetMemoryZirconHandlePropertiesFUCHSIA", true);
        }
    }

    public unsafe sealed class VulkanFuchsiaExternalSemaphore : IVulkanDeviceExtGeneric<VulkanFuchsiaExternalSemaphore>
    {
        public static string Name => "VK_FUCHSIA_external_semaphore";
        string IVulkanExt.GetName() => Name;

        public static VulkanFuchsiaExternalSemaphore Create(VkDevice device)
        {
            return new VulkanFuchsiaExternalSemaphore(device);
        }

        private IntPtr vkGetSemaphoreZirconHandleFUCHSIA_ptr;
        private IntPtr vkImportSemaphoreZirconHandleFUCHSIA_ptr;

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetSemaphoreZirconHandleFUCHSIA(VkDevice device, VkSemaphoreGetZirconHandleInfoFUCHSIA* pGetZirconHandleInfo, Zircon.ZXHandle* pZirconHandle)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetSemaphoreZirconHandleFUCHSIA(VkDevice device, VkSemaphoreGetZirconHandleInfoFUCHSIA* pGetZirconHandleInfo, out Zircon.ZXHandle pZirconHandle)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetSemaphoreZirconHandleFUCHSIA(VkDevice device, ref VkSemaphoreGetZirconHandleInfoFUCHSIA pGetZirconHandleInfo, Zircon.ZXHandle* pZirconHandle)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetSemaphoreZirconHandleFUCHSIA(VkDevice device, ref VkSemaphoreGetZirconHandleInfoFUCHSIA pGetZirconHandleInfo, out Zircon.ZXHandle pZirconHandle)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetSemaphoreZirconHandleFUCHSIA(VkDevice device, IntPtr pGetZirconHandleInfo, Zircon.ZXHandle* pZirconHandle)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetSemaphoreZirconHandleFUCHSIA(VkDevice device, IntPtr pGetZirconHandleInfo, out Zircon.ZXHandle pZirconHandle)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkImportSemaphoreZirconHandleFUCHSIA(VkDevice device, VkImportSemaphoreZirconHandleInfoFUCHSIA* pImportSemaphoreZirconHandleInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkImportSemaphoreZirconHandleFUCHSIA(VkDevice device, ref VkImportSemaphoreZirconHandleInfoFUCHSIA pImportSemaphoreZirconHandleInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkImportSemaphoreZirconHandleFUCHSIA(VkDevice device, IntPtr pImportSemaphoreZirconHandleInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanFuchsiaExternalSemaphore(VkDevice device)
        {
            vkGetSemaphoreZirconHandleFUCHSIA_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetSemaphoreZirconHandleFUCHSIA", true);
            vkImportSemaphoreZirconHandleFUCHSIA_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkImportSemaphoreZirconHandleFUCHSIA", true);
        }
    }

    public unsafe sealed class VulkanFuchsiaBufferCollection : IVulkanDeviceExtGeneric<VulkanFuchsiaBufferCollection>
    {
        public static string Name => "VK_FUCHSIA_buffer_collection";
        string IVulkanExt.GetName() => Name;

        public static VulkanFuchsiaBufferCollection Create(VkDevice device)
        {
            return new VulkanFuchsiaBufferCollection(device);
        }

        private IntPtr vkCreateBufferCollectionFUCHSIA_ptr;
        private IntPtr vkDestroyBufferCollectionFUCHSIA_ptr;
        private IntPtr vkGetBufferCollectionPropertiesFUCHSIA_ptr;
        private IntPtr vkSetBufferCollectionBufferConstraintsFUCHSIA_ptr;
        private IntPtr vkSetBufferCollectionImageConstraintsFUCHSIA_ptr;

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateBufferCollectionFUCHSIA(VkDevice device, VkBufferCollectionCreateInfoFUCHSIA* pCreateInfo, VkAllocationCallbacks* pAllocator, VkBufferCollectionFUCHSIA* pCollection)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateBufferCollectionFUCHSIA(VkDevice device, VkBufferCollectionCreateInfoFUCHSIA* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkBufferCollectionFUCHSIA pCollection)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateBufferCollectionFUCHSIA(VkDevice device, VkBufferCollectionCreateInfoFUCHSIA* pCreateInfo, ref VkAllocationCallbacks pAllocator, VkBufferCollectionFUCHSIA* pCollection)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateBufferCollectionFUCHSIA(VkDevice device, VkBufferCollectionCreateInfoFUCHSIA* pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkBufferCollectionFUCHSIA pCollection)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateBufferCollectionFUCHSIA(VkDevice device, VkBufferCollectionCreateInfoFUCHSIA* pCreateInfo, IntPtr pAllocator, VkBufferCollectionFUCHSIA* pCollection)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateBufferCollectionFUCHSIA(VkDevice device, VkBufferCollectionCreateInfoFUCHSIA* pCreateInfo, IntPtr pAllocator, out VkBufferCollectionFUCHSIA pCollection)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateBufferCollectionFUCHSIA(VkDevice device, ref VkBufferCollectionCreateInfoFUCHSIA pCreateInfo, VkAllocationCallbacks* pAllocator, VkBufferCollectionFUCHSIA* pCollection)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateBufferCollectionFUCHSIA(VkDevice device, ref VkBufferCollectionCreateInfoFUCHSIA pCreateInfo, VkAllocationCallbacks* pAllocator, out VkBufferCollectionFUCHSIA pCollection)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateBufferCollectionFUCHSIA(VkDevice device, ref VkBufferCollectionCreateInfoFUCHSIA pCreateInfo, ref VkAllocationCallbacks pAllocator, VkBufferCollectionFUCHSIA* pCollection)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateBufferCollectionFUCHSIA(VkDevice device, ref VkBufferCollectionCreateInfoFUCHSIA pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkBufferCollectionFUCHSIA pCollection)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateBufferCollectionFUCHSIA(VkDevice device, ref VkBufferCollectionCreateInfoFUCHSIA pCreateInfo, IntPtr pAllocator, VkBufferCollectionFUCHSIA* pCollection)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateBufferCollectionFUCHSIA(VkDevice device, ref VkBufferCollectionCreateInfoFUCHSIA pCreateInfo, IntPtr pAllocator, out VkBufferCollectionFUCHSIA pCollection)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateBufferCollectionFUCHSIA(VkDevice device, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, VkBufferCollectionFUCHSIA* pCollection)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateBufferCollectionFUCHSIA(VkDevice device, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, out VkBufferCollectionFUCHSIA pCollection)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateBufferCollectionFUCHSIA(VkDevice device, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, VkBufferCollectionFUCHSIA* pCollection)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateBufferCollectionFUCHSIA(VkDevice device, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkBufferCollectionFUCHSIA pCollection)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateBufferCollectionFUCHSIA(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, VkBufferCollectionFUCHSIA* pCollection)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateBufferCollectionFUCHSIA(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, out VkBufferCollectionFUCHSIA pCollection)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkDestroyBufferCollectionFUCHSIA(VkDevice device, VkBufferCollectionFUCHSIA collection, VkAllocationCallbacks* pAllocator)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkDestroyBufferCollectionFUCHSIA(VkDevice device, VkBufferCollectionFUCHSIA collection, ref VkAllocationCallbacks pAllocator)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkDestroyBufferCollectionFUCHSIA(VkDevice device, VkBufferCollectionFUCHSIA collection, IntPtr pAllocator)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetBufferCollectionPropertiesFUCHSIA(VkDevice device, VkBufferCollectionFUCHSIA collection, VkBufferCollectionPropertiesFUCHSIA* pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetBufferCollectionPropertiesFUCHSIA(VkDevice device, VkBufferCollectionFUCHSIA collection, out VkBufferCollectionPropertiesFUCHSIA pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_FORMAT_NOT_SUPPORTED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkSetBufferCollectionBufferConstraintsFUCHSIA(VkDevice device, VkBufferCollectionFUCHSIA collection, VkBufferConstraintsInfoFUCHSIA* pBufferConstraintsInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_FORMAT_NOT_SUPPORTED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkSetBufferCollectionBufferConstraintsFUCHSIA(VkDevice device, VkBufferCollectionFUCHSIA collection, ref VkBufferConstraintsInfoFUCHSIA pBufferConstraintsInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_FORMAT_NOT_SUPPORTED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkSetBufferCollectionBufferConstraintsFUCHSIA(VkDevice device, VkBufferCollectionFUCHSIA collection, IntPtr pBufferConstraintsInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_FORMAT_NOT_SUPPORTED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkSetBufferCollectionImageConstraintsFUCHSIA(VkDevice device, VkBufferCollectionFUCHSIA collection, VkImageConstraintsInfoFUCHSIA* pImageConstraintsInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_FORMAT_NOT_SUPPORTED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkSetBufferCollectionImageConstraintsFUCHSIA(VkDevice device, VkBufferCollectionFUCHSIA collection, ref VkImageConstraintsInfoFUCHSIA pImageConstraintsInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_FORMAT_NOT_SUPPORTED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkSetBufferCollectionImageConstraintsFUCHSIA(VkDevice device, VkBufferCollectionFUCHSIA collection, IntPtr pImageConstraintsInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanFuchsiaBufferCollection(VkDevice device)
        {
            vkCreateBufferCollectionFUCHSIA_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCreateBufferCollectionFUCHSIA", true);
            vkDestroyBufferCollectionFUCHSIA_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkDestroyBufferCollectionFUCHSIA", true);
            vkGetBufferCollectionPropertiesFUCHSIA_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetBufferCollectionPropertiesFUCHSIA", true);
            vkSetBufferCollectionBufferConstraintsFUCHSIA_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkSetBufferCollectionBufferConstraintsFUCHSIA", true);
            vkSetBufferCollectionImageConstraintsFUCHSIA_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkSetBufferCollectionImageConstraintsFUCHSIA", true);
        }
    }

    public unsafe sealed class VulkanHuaweiSubpassShading : IVulkanDeviceExtGeneric<VulkanHuaweiSubpassShading>
    {
        public static string Name => "VK_HUAWEI_subpass_shading";
        string IVulkanExt.GetName() => Name;

        public static VulkanHuaweiSubpassShading Create(VkDevice device)
        {
            return new VulkanHuaweiSubpassShading(device);
        }

        private IntPtr vkCmdSubpassShadingHUAWEI_ptr;
        private IntPtr vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI_ptr;

        [Generator.CalliRewrite]
        public unsafe void vkCmdSubpassShadingHUAWEI(VkCommandBuffer commandBuffer)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI(VkDevice device, VkRenderPass renderpass, VkExtent2D* pMaxWorkgroupSize)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI(VkDevice device, VkRenderPass renderpass, out VkExtent2D pMaxWorkgroupSize)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanHuaweiSubpassShading(VkDevice device)
        {
            vkCmdSubpassShadingHUAWEI_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdSubpassShadingHUAWEI", true);
            vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI", true);
        }
    }

    public unsafe sealed class VulkanHuaweiInvocationMask : IVulkanDeviceExtGeneric<VulkanHuaweiInvocationMask>
    {
        public static string Name => "VK_HUAWEI_invocation_mask";
        string IVulkanExt.GetName() => Name;

        public static VulkanHuaweiInvocationMask Create(VkDevice device)
        {
            return new VulkanHuaweiInvocationMask(device);
        }

        private IntPtr vkCmdBindInvocationMaskHUAWEI_ptr;

        [Generator.CalliRewrite]
        public unsafe void vkCmdBindInvocationMaskHUAWEI(VkCommandBuffer commandBuffer, VkImageView imageView, VkImageLayout imageLayout)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanHuaweiInvocationMask(VkDevice device)
        {
            vkCmdBindInvocationMaskHUAWEI_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdBindInvocationMaskHUAWEI", true);
        }
    }

    public unsafe sealed class VulkanNVExternalMemoryRdma : IVulkanDeviceExtGeneric<VulkanNVExternalMemoryRdma>
    {
        public static string Name => "VK_NV_external_memory_rdma";
        string IVulkanExt.GetName() => Name;

        public static VulkanNVExternalMemoryRdma Create(VkDevice device)
        {
            return new VulkanNVExternalMemoryRdma(device);
        }

        private IntPtr vkGetMemoryRemoteAddressNV_ptr;

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_INVALID_EXTERNAL_HANDLE</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetMemoryRemoteAddressNV(VkDevice device, VkMemoryGetRemoteAddressInfoNV* pMemoryGetRemoteAddressInfo, void* pAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_INVALID_EXTERNAL_HANDLE</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetMemoryRemoteAddressNV(VkDevice device, ref VkMemoryGetRemoteAddressInfoNV pMemoryGetRemoteAddressInfo, void* pAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_INVALID_EXTERNAL_HANDLE</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetMemoryRemoteAddressNV(VkDevice device, IntPtr pMemoryGetRemoteAddressInfo, void* pAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanNVExternalMemoryRdma(VkDevice device)
        {
            vkGetMemoryRemoteAddressNV_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetMemoryRemoteAddressNV", true);
        }
    }

    public unsafe sealed class VulkanEXTPipelineProperties : IVulkanDeviceExtGeneric<VulkanEXTPipelineProperties>
    {
        public static string Name => "VK_EXT_pipeline_properties";
        string IVulkanExt.GetName() => Name;

        public static VulkanEXTPipelineProperties Create(VkDevice device)
        {
            return new VulkanEXTPipelineProperties(device);
        }

        private IntPtr vkGetPipelinePropertiesEXT_ptr;

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPipelinePropertiesEXT(VkDevice device, VkPipelineInfoKHR* pPipelineInfo, VkBaseOutStructure* pPipelineProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPipelinePropertiesEXT(VkDevice device, VkPipelineInfoKHR* pPipelineInfo, out VkBaseOutStructure pPipelineProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPipelinePropertiesEXT(VkDevice device, ref VkPipelineInfoKHR pPipelineInfo, VkBaseOutStructure* pPipelineProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPipelinePropertiesEXT(VkDevice device, ref VkPipelineInfoKHR pPipelineInfo, out VkBaseOutStructure pPipelineProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPipelinePropertiesEXT(VkDevice device, IntPtr pPipelineInfo, VkBaseOutStructure* pPipelineProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPipelinePropertiesEXT(VkDevice device, IntPtr pPipelineInfo, out VkBaseOutStructure pPipelineProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanEXTPipelineProperties(VkDevice device)
        {
            vkGetPipelinePropertiesEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetPipelinePropertiesEXT", true);
        }
    }

    public unsafe sealed class VulkanEXTExtendedDynamicState2 : IVulkanDeviceExtGeneric<VulkanEXTExtendedDynamicState2>
    {
        public static string Name => "VK_EXT_extended_dynamic_state2";
        string IVulkanExt.GetName() => Name;

        public static VulkanEXTExtendedDynamicState2 Create(VkDevice device)
        {
            return new VulkanEXTExtendedDynamicState2(device);
        }

        private IntPtr vkCmdSetLogicOpEXT_ptr;
        private IntPtr vkCmdSetPatchControlPointsEXT_ptr;

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetLogicOpEXT(VkCommandBuffer commandBuffer, VkLogicOp logicOp)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetPatchControlPointsEXT(VkCommandBuffer commandBuffer, uint patchControlPoints)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanEXTExtendedDynamicState2(VkDevice device)
        {
            vkCmdSetLogicOpEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdSetLogicOpEXT", true);
            vkCmdSetPatchControlPointsEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdSetPatchControlPointsEXT", true);
        }
    }

    public unsafe sealed class VulkanQnxScreenSurface : IVulkanInstanceExtGeneric<VulkanQnxScreenSurface>
    {
        public static string Name => "VK_QNX_screen_surface";
        string IVulkanExt.GetName() => Name;

        public static VulkanQnxScreenSurface Create(VkInstance instance)
        {
            return new VulkanQnxScreenSurface(instance);
        }

        private IntPtr vkCreateScreenSurfaceQNX_ptr;
        private IntPtr vkGetPhysicalDeviceScreenPresentationSupportQNX_ptr;

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateScreenSurfaceQNX(VkInstance instance, VkScreenSurfaceCreateInfoQNX* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateScreenSurfaceQNX(VkInstance instance, VkScreenSurfaceCreateInfoQNX* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateScreenSurfaceQNX(VkInstance instance, VkScreenSurfaceCreateInfoQNX* pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateScreenSurfaceQNX(VkInstance instance, VkScreenSurfaceCreateInfoQNX* pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateScreenSurfaceQNX(VkInstance instance, VkScreenSurfaceCreateInfoQNX* pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateScreenSurfaceQNX(VkInstance instance, VkScreenSurfaceCreateInfoQNX* pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateScreenSurfaceQNX(VkInstance instance, ref VkScreenSurfaceCreateInfoQNX pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateScreenSurfaceQNX(VkInstance instance, ref VkScreenSurfaceCreateInfoQNX pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateScreenSurfaceQNX(VkInstance instance, ref VkScreenSurfaceCreateInfoQNX pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateScreenSurfaceQNX(VkInstance instance, ref VkScreenSurfaceCreateInfoQNX pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateScreenSurfaceQNX(VkInstance instance, ref VkScreenSurfaceCreateInfoQNX pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateScreenSurfaceQNX(VkInstance instance, ref VkScreenSurfaceCreateInfoQNX pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateScreenSurfaceQNX(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateScreenSurfaceQNX(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateScreenSurfaceQNX(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateScreenSurfaceQNX(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateScreenSurfaceQNX(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateScreenSurfaceQNX(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe VkBool32 vkGetPhysicalDeviceScreenPresentationSupportQNX(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, Screen.ScreenWindow* window)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe VkBool32 vkGetPhysicalDeviceScreenPresentationSupportQNX(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, out Screen.ScreenWindow window)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanQnxScreenSurface(VkInstance instance)
        {
            vkCreateScreenSurfaceQNX_ptr = VulkanNative.LoadInstanceProcAddr(instance, "vkCreateScreenSurfaceQNX", true);
            vkGetPhysicalDeviceScreenPresentationSupportQNX_ptr = VulkanNative.LoadInstanceProcAddr(instance, "vkGetPhysicalDeviceScreenPresentationSupportQNX", true);
        }
    }

    public unsafe sealed class VulkanEXTColorWriteEnable : IVulkanDeviceExtGeneric<VulkanEXTColorWriteEnable>
    {
        public static string Name => "VK_EXT_color_write_enable";
        string IVulkanExt.GetName() => Name;

        public static VulkanEXTColorWriteEnable Create(VkDevice device)
        {
            return new VulkanEXTColorWriteEnable(device);
        }

        private IntPtr vkCmdSetColorWriteEnableEXT_ptr;

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetColorWriteEnableEXT(VkCommandBuffer commandBuffer, uint attachmentCount, VkBool32* pColorWriteEnables)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetColorWriteEnableEXT(VkCommandBuffer commandBuffer, uint attachmentCount, ref VkBool32 pColorWriteEnables)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetColorWriteEnableEXT(VkCommandBuffer commandBuffer, uint attachmentCount, IntPtr pColorWriteEnables)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanEXTColorWriteEnable(VkDevice device)
        {
            vkCmdSetColorWriteEnableEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdSetColorWriteEnableEXT", true);
        }
    }

    public unsafe sealed class VulkanKHRRayTracingMaintenance1 : IVulkanDeviceExtGeneric<VulkanKHRRayTracingMaintenance1>
    {
        public static string Name => "VK_KHR_ray_tracing_maintenance1";
        string IVulkanExt.GetName() => Name;

        public static VulkanKHRRayTracingMaintenance1 Create(VkDevice device)
        {
            return new VulkanKHRRayTracingMaintenance1(device);
        }

        private IntPtr vkCmdTraceRaysIndirect2KHR_ptr;

        [Generator.CalliRewrite]
        public unsafe void vkCmdTraceRaysIndirect2KHR(VkCommandBuffer commandBuffer, ulong indirectDeviceAddress)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanKHRRayTracingMaintenance1(VkDevice device)
        {
            vkCmdTraceRaysIndirect2KHR_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdTraceRaysIndirect2KHR", true);
        }
    }

    public unsafe sealed class VulkanEXTMultiDraw : IVulkanDeviceExtGeneric<VulkanEXTMultiDraw>
    {
        public static string Name => "VK_EXT_multi_draw";
        string IVulkanExt.GetName() => Name;

        public static VulkanEXTMultiDraw Create(VkDevice device)
        {
            return new VulkanEXTMultiDraw(device);
        }

        private IntPtr vkCmdDrawMultiEXT_ptr;
        private IntPtr vkCmdDrawMultiIndexedEXT_ptr;

        [Generator.CalliRewrite]
        public unsafe void vkCmdDrawMultiEXT(VkCommandBuffer commandBuffer, uint drawCount, VkMultiDrawInfoEXT* pVertexInfo, uint instanceCount, uint firstInstance, uint stride)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdDrawMultiEXT(VkCommandBuffer commandBuffer, uint drawCount, ref VkMultiDrawInfoEXT pVertexInfo, uint instanceCount, uint firstInstance, uint stride)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdDrawMultiEXT(VkCommandBuffer commandBuffer, uint drawCount, IntPtr pVertexInfo, uint instanceCount, uint firstInstance, uint stride)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdDrawMultiIndexedEXT(VkCommandBuffer commandBuffer, uint drawCount, VkMultiDrawIndexedInfoEXT* pIndexInfo, uint instanceCount, uint firstInstance, uint stride, int* pVertexOffset)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdDrawMultiIndexedEXT(VkCommandBuffer commandBuffer, uint drawCount, VkMultiDrawIndexedInfoEXT* pIndexInfo, uint instanceCount, uint firstInstance, uint stride, ref int pVertexOffset)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdDrawMultiIndexedEXT(VkCommandBuffer commandBuffer, uint drawCount, VkMultiDrawIndexedInfoEXT* pIndexInfo, uint instanceCount, uint firstInstance, uint stride, IntPtr pVertexOffset)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdDrawMultiIndexedEXT(VkCommandBuffer commandBuffer, uint drawCount, ref VkMultiDrawIndexedInfoEXT pIndexInfo, uint instanceCount, uint firstInstance, uint stride, int* pVertexOffset)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdDrawMultiIndexedEXT(VkCommandBuffer commandBuffer, uint drawCount, ref VkMultiDrawIndexedInfoEXT pIndexInfo, uint instanceCount, uint firstInstance, uint stride, ref int pVertexOffset)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdDrawMultiIndexedEXT(VkCommandBuffer commandBuffer, uint drawCount, ref VkMultiDrawIndexedInfoEXT pIndexInfo, uint instanceCount, uint firstInstance, uint stride, IntPtr pVertexOffset)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdDrawMultiIndexedEXT(VkCommandBuffer commandBuffer, uint drawCount, IntPtr pIndexInfo, uint instanceCount, uint firstInstance, uint stride, int* pVertexOffset)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdDrawMultiIndexedEXT(VkCommandBuffer commandBuffer, uint drawCount, IntPtr pIndexInfo, uint instanceCount, uint firstInstance, uint stride, ref int pVertexOffset)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdDrawMultiIndexedEXT(VkCommandBuffer commandBuffer, uint drawCount, IntPtr pIndexInfo, uint instanceCount, uint firstInstance, uint stride, IntPtr pVertexOffset)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanEXTMultiDraw(VkDevice device)
        {
            vkCmdDrawMultiEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdDrawMultiEXT", true);
            vkCmdDrawMultiIndexedEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdDrawMultiIndexedEXT", true);
        }
    }

    public unsafe sealed class VulkanEXTOpacityMicromap : IVulkanDeviceExtGeneric<VulkanEXTOpacityMicromap>
    {
        public static string Name => "VK_EXT_opacity_micromap";
        string IVulkanExt.GetName() => Name;

        public static VulkanEXTOpacityMicromap Create(VkDevice device)
        {
            return new VulkanEXTOpacityMicromap(device);
        }

        private IntPtr vkBuildMicromapsEXT_ptr;
        private IntPtr vkCmdBuildMicromapsEXT_ptr;
        private IntPtr vkCmdCopyMemoryToMicromapEXT_ptr;
        private IntPtr vkCmdCopyMicromapEXT_ptr;
        private IntPtr vkCmdCopyMicromapToMemoryEXT_ptr;
        private IntPtr vkCmdWriteMicromapsPropertiesEXT_ptr;
        private IntPtr vkCopyMemoryToMicromapEXT_ptr;
        private IntPtr vkCopyMicromapEXT_ptr;
        private IntPtr vkCopyMicromapToMemoryEXT_ptr;
        private IntPtr vkCreateMicromapEXT_ptr;
        private IntPtr vkDestroyMicromapEXT_ptr;
        private IntPtr vkGetDeviceMicromapCompatibilityEXT_ptr;
        private IntPtr vkGetMicromapBuildSizesEXT_ptr;
        private IntPtr vkWriteMicromapsPropertiesEXT_ptr;

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkBuildMicromapsEXT(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, VkMicromapBuildInfoEXT* pInfos)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkBuildMicromapsEXT(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, ref VkMicromapBuildInfoEXT pInfos)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkBuildMicromapsEXT(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, IntPtr pInfos)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkBuildMicromapsEXT(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, VkMicromapBuildInfoEXT[] pInfos)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildMicromapsEXT(VkCommandBuffer commandBuffer, uint infoCount, VkMicromapBuildInfoEXT* pInfos)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildMicromapsEXT(VkCommandBuffer commandBuffer, uint infoCount, ref VkMicromapBuildInfoEXT pInfos)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildMicromapsEXT(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdBuildMicromapsEXT(VkCommandBuffer commandBuffer, uint infoCount, VkMicromapBuildInfoEXT[] pInfos)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdCopyMemoryToMicromapEXT(VkCommandBuffer commandBuffer, VkCopyMemoryToMicromapInfoEXT* pInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdCopyMemoryToMicromapEXT(VkCommandBuffer commandBuffer, ref VkCopyMemoryToMicromapInfoEXT pInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdCopyMemoryToMicromapEXT(VkCommandBuffer commandBuffer, IntPtr pInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdCopyMicromapEXT(VkCommandBuffer commandBuffer, VkCopyMicromapInfoEXT* pInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdCopyMicromapEXT(VkCommandBuffer commandBuffer, ref VkCopyMicromapInfoEXT pInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdCopyMicromapEXT(VkCommandBuffer commandBuffer, IntPtr pInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdCopyMicromapToMemoryEXT(VkCommandBuffer commandBuffer, VkCopyMicromapToMemoryInfoEXT* pInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdCopyMicromapToMemoryEXT(VkCommandBuffer commandBuffer, ref VkCopyMicromapToMemoryInfoEXT pInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdCopyMicromapToMemoryEXT(VkCommandBuffer commandBuffer, IntPtr pInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdWriteMicromapsPropertiesEXT(VkCommandBuffer commandBuffer, uint micromapCount, VkMicromapEXT* pMicromaps, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdWriteMicromapsPropertiesEXT(VkCommandBuffer commandBuffer, uint micromapCount, ref VkMicromapEXT pMicromaps, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdWriteMicromapsPropertiesEXT(VkCommandBuffer commandBuffer, uint micromapCount, IntPtr pMicromaps, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCopyMemoryToMicromapEXT(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyMemoryToMicromapInfoEXT* pInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCopyMemoryToMicromapEXT(VkDevice device, VkDeferredOperationKHR deferredOperation, ref VkCopyMemoryToMicromapInfoEXT pInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCopyMemoryToMicromapEXT(VkDevice device, VkDeferredOperationKHR deferredOperation, IntPtr pInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCopyMicromapEXT(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyMicromapInfoEXT* pInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCopyMicromapEXT(VkDevice device, VkDeferredOperationKHR deferredOperation, ref VkCopyMicromapInfoEXT pInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCopyMicromapEXT(VkDevice device, VkDeferredOperationKHR deferredOperation, IntPtr pInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCopyMicromapToMemoryEXT(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyMicromapToMemoryInfoEXT* pInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCopyMicromapToMemoryEXT(VkDevice device, VkDeferredOperationKHR deferredOperation, ref VkCopyMicromapToMemoryInfoEXT pInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCopyMicromapToMemoryEXT(VkDevice device, VkDeferredOperationKHR deferredOperation, IntPtr pInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateMicromapEXT(VkDevice device, VkMicromapCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkMicromapEXT* pMicromap)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateMicromapEXT(VkDevice device, VkMicromapCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkMicromapEXT pMicromap)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateMicromapEXT(VkDevice device, VkMicromapCreateInfoEXT* pCreateInfo, ref VkAllocationCallbacks pAllocator, VkMicromapEXT* pMicromap)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateMicromapEXT(VkDevice device, VkMicromapCreateInfoEXT* pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkMicromapEXT pMicromap)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateMicromapEXT(VkDevice device, VkMicromapCreateInfoEXT* pCreateInfo, IntPtr pAllocator, VkMicromapEXT* pMicromap)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateMicromapEXT(VkDevice device, VkMicromapCreateInfoEXT* pCreateInfo, IntPtr pAllocator, out VkMicromapEXT pMicromap)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateMicromapEXT(VkDevice device, ref VkMicromapCreateInfoEXT pCreateInfo, VkAllocationCallbacks* pAllocator, VkMicromapEXT* pMicromap)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateMicromapEXT(VkDevice device, ref VkMicromapCreateInfoEXT pCreateInfo, VkAllocationCallbacks* pAllocator, out VkMicromapEXT pMicromap)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateMicromapEXT(VkDevice device, ref VkMicromapCreateInfoEXT pCreateInfo, ref VkAllocationCallbacks pAllocator, VkMicromapEXT* pMicromap)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateMicromapEXT(VkDevice device, ref VkMicromapCreateInfoEXT pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkMicromapEXT pMicromap)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateMicromapEXT(VkDevice device, ref VkMicromapCreateInfoEXT pCreateInfo, IntPtr pAllocator, VkMicromapEXT* pMicromap)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateMicromapEXT(VkDevice device, ref VkMicromapCreateInfoEXT pCreateInfo, IntPtr pAllocator, out VkMicromapEXT pMicromap)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateMicromapEXT(VkDevice device, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, VkMicromapEXT* pMicromap)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateMicromapEXT(VkDevice device, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, out VkMicromapEXT pMicromap)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateMicromapEXT(VkDevice device, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, VkMicromapEXT* pMicromap)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateMicromapEXT(VkDevice device, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkMicromapEXT pMicromap)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateMicromapEXT(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, VkMicromapEXT* pMicromap)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateMicromapEXT(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, out VkMicromapEXT pMicromap)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkDestroyMicromapEXT(VkDevice device, VkMicromapEXT micromap, VkAllocationCallbacks* pAllocator)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkDestroyMicromapEXT(VkDevice device, VkMicromapEXT micromap, ref VkAllocationCallbacks pAllocator)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkDestroyMicromapEXT(VkDevice device, VkMicromapEXT micromap, IntPtr pAllocator)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetDeviceMicromapCompatibilityEXT(VkDevice device, VkMicromapVersionInfoEXT* pVersionInfo, VkAccelerationStructureCompatibilityKHR* pCompatibility)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetDeviceMicromapCompatibilityEXT(VkDevice device, VkMicromapVersionInfoEXT* pVersionInfo, out VkAccelerationStructureCompatibilityKHR pCompatibility)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetDeviceMicromapCompatibilityEXT(VkDevice device, ref VkMicromapVersionInfoEXT pVersionInfo, VkAccelerationStructureCompatibilityKHR* pCompatibility)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetDeviceMicromapCompatibilityEXT(VkDevice device, ref VkMicromapVersionInfoEXT pVersionInfo, out VkAccelerationStructureCompatibilityKHR pCompatibility)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetDeviceMicromapCompatibilityEXT(VkDevice device, IntPtr pVersionInfo, VkAccelerationStructureCompatibilityKHR* pCompatibility)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetDeviceMicromapCompatibilityEXT(VkDevice device, IntPtr pVersionInfo, out VkAccelerationStructureCompatibilityKHR pCompatibility)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetMicromapBuildSizesEXT(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, VkMicromapBuildInfoEXT* pBuildInfo, VkMicromapBuildSizesInfoEXT* pSizeInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetMicromapBuildSizesEXT(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, VkMicromapBuildInfoEXT* pBuildInfo, out VkMicromapBuildSizesInfoEXT pSizeInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetMicromapBuildSizesEXT(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, ref VkMicromapBuildInfoEXT pBuildInfo, VkMicromapBuildSizesInfoEXT* pSizeInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetMicromapBuildSizesEXT(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, ref VkMicromapBuildInfoEXT pBuildInfo, out VkMicromapBuildSizesInfoEXT pSizeInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetMicromapBuildSizesEXT(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, IntPtr pBuildInfo, VkMicromapBuildSizesInfoEXT* pSizeInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetMicromapBuildSizesEXT(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, IntPtr pBuildInfo, out VkMicromapBuildSizesInfoEXT pSizeInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkWriteMicromapsPropertiesEXT(VkDevice device, uint micromapCount, VkMicromapEXT* pMicromaps, VkQueryType queryType, UIntPtr dataSize, void* pData, UIntPtr stride)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkWriteMicromapsPropertiesEXT(VkDevice device, uint micromapCount, ref VkMicromapEXT pMicromaps, VkQueryType queryType, UIntPtr dataSize, void* pData, UIntPtr stride)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkWriteMicromapsPropertiesEXT(VkDevice device, uint micromapCount, IntPtr pMicromaps, VkQueryType queryType, UIntPtr dataSize, void* pData, UIntPtr stride)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanEXTOpacityMicromap(VkDevice device)
        {
            vkBuildMicromapsEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkBuildMicromapsEXT", true);
            vkCmdBuildMicromapsEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdBuildMicromapsEXT", true);
            vkCmdCopyMemoryToMicromapEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdCopyMemoryToMicromapEXT", true);
            vkCmdCopyMicromapEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdCopyMicromapEXT", true);
            vkCmdCopyMicromapToMemoryEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdCopyMicromapToMemoryEXT", true);
            vkCmdWriteMicromapsPropertiesEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdWriteMicromapsPropertiesEXT", true);
            vkCopyMemoryToMicromapEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCopyMemoryToMicromapEXT", true);
            vkCopyMicromapEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCopyMicromapEXT", true);
            vkCopyMicromapToMemoryEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCopyMicromapToMemoryEXT", true);
            vkCreateMicromapEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCreateMicromapEXT", true);
            vkDestroyMicromapEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkDestroyMicromapEXT", true);
            vkGetDeviceMicromapCompatibilityEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetDeviceMicromapCompatibilityEXT", true);
            vkGetMicromapBuildSizesEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetMicromapBuildSizesEXT", true);
            vkWriteMicromapsPropertiesEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkWriteMicromapsPropertiesEXT", true);
        }
    }

    public unsafe sealed class VulkanEXTPageableDeviceLocalMemory : IVulkanDeviceExtGeneric<VulkanEXTPageableDeviceLocalMemory>
    {
        public static string Name => "VK_EXT_pageable_device_local_memory";
        string IVulkanExt.GetName() => Name;

        public static VulkanEXTPageableDeviceLocalMemory Create(VkDevice device)
        {
            return new VulkanEXTPageableDeviceLocalMemory(device);
        }

        private IntPtr vkSetDeviceMemoryPriorityEXT_ptr;

        [Generator.CalliRewrite]
        public unsafe void vkSetDeviceMemoryPriorityEXT(VkDevice device, VkDeviceMemory memory, float priority)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanEXTPageableDeviceLocalMemory(VkDevice device)
        {
            vkSetDeviceMemoryPriorityEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkSetDeviceMemoryPriorityEXT", true);
        }
    }

    public unsafe sealed class VulkanKHRMaintenance4 : IVulkanDeviceExtGeneric<VulkanKHRMaintenance4>
    {
        public static string Name => "VK_KHR_maintenance4";
        string IVulkanExt.GetName() => Name;

        public static VulkanKHRMaintenance4 Create(VkDevice device)
        {
            return new VulkanKHRMaintenance4(device);
        }



        public VulkanKHRMaintenance4(VkDevice device)
        {
        }
    }

    public unsafe sealed class VulkanValveDescriptorSetHostMapping : IVulkanDeviceExtGeneric<VulkanValveDescriptorSetHostMapping>
    {
        public static string Name => "VK_VALVE_descriptor_set_host_mapping";
        string IVulkanExt.GetName() => Name;

        public static VulkanValveDescriptorSetHostMapping Create(VkDevice device)
        {
            return new VulkanValveDescriptorSetHostMapping(device);
        }

        private IntPtr vkGetDescriptorSetHostMappingVALVE_ptr;
        private IntPtr vkGetDescriptorSetLayoutHostMappingInfoVALVE_ptr;

        [Generator.CalliRewrite]
        public unsafe void vkGetDescriptorSetHostMappingVALVE(VkDevice device, VkDescriptorSet descriptorSet, void** ppData)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetDescriptorSetLayoutHostMappingInfoVALVE(VkDevice device, VkDescriptorSetBindingReferenceVALVE* pBindingReference, VkDescriptorSetLayoutHostMappingInfoVALVE* pHostMapping)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetDescriptorSetLayoutHostMappingInfoVALVE(VkDevice device, VkDescriptorSetBindingReferenceVALVE* pBindingReference, out VkDescriptorSetLayoutHostMappingInfoVALVE pHostMapping)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetDescriptorSetLayoutHostMappingInfoVALVE(VkDevice device, ref VkDescriptorSetBindingReferenceVALVE pBindingReference, VkDescriptorSetLayoutHostMappingInfoVALVE* pHostMapping)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetDescriptorSetLayoutHostMappingInfoVALVE(VkDevice device, ref VkDescriptorSetBindingReferenceVALVE pBindingReference, out VkDescriptorSetLayoutHostMappingInfoVALVE pHostMapping)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetDescriptorSetLayoutHostMappingInfoVALVE(VkDevice device, IntPtr pBindingReference, VkDescriptorSetLayoutHostMappingInfoVALVE* pHostMapping)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetDescriptorSetLayoutHostMappingInfoVALVE(VkDevice device, IntPtr pBindingReference, out VkDescriptorSetLayoutHostMappingInfoVALVE pHostMapping)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanValveDescriptorSetHostMapping(VkDevice device)
        {
            vkGetDescriptorSetHostMappingVALVE_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetDescriptorSetHostMappingVALVE", true);
            vkGetDescriptorSetLayoutHostMappingInfoVALVE_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetDescriptorSetLayoutHostMappingInfoVALVE", true);
        }
    }

    public unsafe sealed class VulkanNVCopyMemoryIndirect : IVulkanDeviceExtGeneric<VulkanNVCopyMemoryIndirect>
    {
        public static string Name => "VK_NV_copy_memory_indirect";
        string IVulkanExt.GetName() => Name;

        public static VulkanNVCopyMemoryIndirect Create(VkDevice device)
        {
            return new VulkanNVCopyMemoryIndirect(device);
        }

        private IntPtr vkCmdCopyMemoryIndirectNV_ptr;
        private IntPtr vkCmdCopyMemoryToImageIndirectNV_ptr;

        [Generator.CalliRewrite]
        public unsafe void vkCmdCopyMemoryIndirectNV(VkCommandBuffer commandBuffer, ulong copyBufferAddress, uint copyCount, uint stride)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdCopyMemoryToImageIndirectNV(VkCommandBuffer commandBuffer, ulong copyBufferAddress, uint copyCount, uint stride, VkImage dstImage, VkImageLayout dstImageLayout, VkImageSubresourceLayers* pImageSubresources)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdCopyMemoryToImageIndirectNV(VkCommandBuffer commandBuffer, ulong copyBufferAddress, uint copyCount, uint stride, VkImage dstImage, VkImageLayout dstImageLayout, ref VkImageSubresourceLayers pImageSubresources)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdCopyMemoryToImageIndirectNV(VkCommandBuffer commandBuffer, ulong copyBufferAddress, uint copyCount, uint stride, VkImage dstImage, VkImageLayout dstImageLayout, IntPtr pImageSubresources)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanNVCopyMemoryIndirect(VkDevice device)
        {
            vkCmdCopyMemoryIndirectNV_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdCopyMemoryIndirectNV", true);
            vkCmdCopyMemoryToImageIndirectNV_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdCopyMemoryToImageIndirectNV", true);
        }
    }

    public unsafe sealed class VulkanNVMemoryDecompression : IVulkanDeviceExtGeneric<VulkanNVMemoryDecompression>
    {
        public static string Name => "VK_NV_memory_decompression";
        string IVulkanExt.GetName() => Name;

        public static VulkanNVMemoryDecompression Create(VkDevice device)
        {
            return new VulkanNVMemoryDecompression(device);
        }

        private IntPtr vkCmdDecompressMemoryIndirectCountNV_ptr;
        private IntPtr vkCmdDecompressMemoryNV_ptr;

        [Generator.CalliRewrite]
        public unsafe void vkCmdDecompressMemoryIndirectCountNV(VkCommandBuffer commandBuffer, ulong indirectCommandsAddress, ulong indirectCommandsCountAddress, uint stride)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdDecompressMemoryNV(VkCommandBuffer commandBuffer, uint decompressRegionCount, VkDecompressMemoryRegionNV* pDecompressMemoryRegions)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdDecompressMemoryNV(VkCommandBuffer commandBuffer, uint decompressRegionCount, ref VkDecompressMemoryRegionNV pDecompressMemoryRegions)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdDecompressMemoryNV(VkCommandBuffer commandBuffer, uint decompressRegionCount, IntPtr pDecompressMemoryRegions)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanNVMemoryDecompression(VkDevice device)
        {
            vkCmdDecompressMemoryIndirectCountNV_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdDecompressMemoryIndirectCountNV", true);
            vkCmdDecompressMemoryNV_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdDecompressMemoryNV", true);
        }
    }

    public unsafe sealed class VulkanEXTExtendedDynamicState3 : IVulkanDeviceExtGeneric<VulkanEXTExtendedDynamicState3>
    {
        public static string Name => "VK_EXT_extended_dynamic_state3";
        string IVulkanExt.GetName() => Name;

        public static VulkanEXTExtendedDynamicState3 Create(VkDevice device)
        {
            return new VulkanEXTExtendedDynamicState3(device);
        }

        private IntPtr vkCmdSetAlphaToCoverageEnableEXT_ptr;
        private IntPtr vkCmdSetAlphaToOneEnableEXT_ptr;
        private IntPtr vkCmdSetColorBlendAdvancedEXT_ptr;
        private IntPtr vkCmdSetColorBlendEnableEXT_ptr;
        private IntPtr vkCmdSetColorBlendEquationEXT_ptr;
        private IntPtr vkCmdSetColorWriteMaskEXT_ptr;
        private IntPtr vkCmdSetConservativeRasterizationModeEXT_ptr;
        private IntPtr vkCmdSetCoverageModulationModeNV_ptr;
        private IntPtr vkCmdSetCoverageModulationTableEnableNV_ptr;
        private IntPtr vkCmdSetCoverageModulationTableNV_ptr;
        private IntPtr vkCmdSetCoverageReductionModeNV_ptr;
        private IntPtr vkCmdSetCoverageToColorEnableNV_ptr;
        private IntPtr vkCmdSetCoverageToColorLocationNV_ptr;
        private IntPtr vkCmdSetDepthClampEnableEXT_ptr;
        private IntPtr vkCmdSetDepthClipEnableEXT_ptr;
        private IntPtr vkCmdSetDepthClipNegativeOneToOneEXT_ptr;
        private IntPtr vkCmdSetExtraPrimitiveOverestimationSizeEXT_ptr;
        private IntPtr vkCmdSetLineRasterizationModeEXT_ptr;
        private IntPtr vkCmdSetLineStippleEnableEXT_ptr;
        private IntPtr vkCmdSetLogicOpEnableEXT_ptr;
        private IntPtr vkCmdSetPolygonModeEXT_ptr;
        private IntPtr vkCmdSetProvokingVertexModeEXT_ptr;
        private IntPtr vkCmdSetRasterizationSamplesEXT_ptr;
        private IntPtr vkCmdSetRasterizationStreamEXT_ptr;
        private IntPtr vkCmdSetRepresentativeFragmentTestEnableNV_ptr;
        private IntPtr vkCmdSetSampleLocationsEnableEXT_ptr;
        private IntPtr vkCmdSetSampleMaskEXT_ptr;
        private IntPtr vkCmdSetShadingRateImageEnableNV_ptr;
        private IntPtr vkCmdSetTessellationDomainOriginEXT_ptr;
        private IntPtr vkCmdSetViewportSwizzleNV_ptr;
        private IntPtr vkCmdSetViewportWScalingEnableNV_ptr;

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetAlphaToCoverageEnableEXT(VkCommandBuffer commandBuffer, VkBool32 alphaToCoverageEnable)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetAlphaToOneEnableEXT(VkCommandBuffer commandBuffer, VkBool32 alphaToOneEnable)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetColorBlendAdvancedEXT(VkCommandBuffer commandBuffer, uint firstAttachment, uint attachmentCount, VkColorBlendAdvancedEXT* pColorBlendAdvanced)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetColorBlendAdvancedEXT(VkCommandBuffer commandBuffer, uint firstAttachment, uint attachmentCount, ref VkColorBlendAdvancedEXT pColorBlendAdvanced)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetColorBlendAdvancedEXT(VkCommandBuffer commandBuffer, uint firstAttachment, uint attachmentCount, IntPtr pColorBlendAdvanced)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetColorBlendEnableEXT(VkCommandBuffer commandBuffer, uint firstAttachment, uint attachmentCount, VkBool32* pColorBlendEnables)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetColorBlendEnableEXT(VkCommandBuffer commandBuffer, uint firstAttachment, uint attachmentCount, ref VkBool32 pColorBlendEnables)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetColorBlendEnableEXT(VkCommandBuffer commandBuffer, uint firstAttachment, uint attachmentCount, IntPtr pColorBlendEnables)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetColorBlendEquationEXT(VkCommandBuffer commandBuffer, uint firstAttachment, uint attachmentCount, VkColorBlendEquationEXT* pColorBlendEquations)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetColorBlendEquationEXT(VkCommandBuffer commandBuffer, uint firstAttachment, uint attachmentCount, ref VkColorBlendEquationEXT pColorBlendEquations)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetColorBlendEquationEXT(VkCommandBuffer commandBuffer, uint firstAttachment, uint attachmentCount, IntPtr pColorBlendEquations)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetColorWriteMaskEXT(VkCommandBuffer commandBuffer, uint firstAttachment, uint attachmentCount, VkColorComponentFlags* pColorWriteMasks)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetColorWriteMaskEXT(VkCommandBuffer commandBuffer, uint firstAttachment, uint attachmentCount, ref VkColorComponentFlags pColorWriteMasks)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetColorWriteMaskEXT(VkCommandBuffer commandBuffer, uint firstAttachment, uint attachmentCount, IntPtr pColorWriteMasks)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetConservativeRasterizationModeEXT(VkCommandBuffer commandBuffer, VkConservativeRasterizationModeEXT conservativeRasterizationMode)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetCoverageModulationModeNV(VkCommandBuffer commandBuffer, VkCoverageModulationModeNV coverageModulationMode)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetCoverageModulationTableEnableNV(VkCommandBuffer commandBuffer, VkBool32 coverageModulationTableEnable)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetCoverageModulationTableNV(VkCommandBuffer commandBuffer, uint coverageModulationTableCount, float* pCoverageModulationTable)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetCoverageModulationTableNV(VkCommandBuffer commandBuffer, uint coverageModulationTableCount, ref float pCoverageModulationTable)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetCoverageModulationTableNV(VkCommandBuffer commandBuffer, uint coverageModulationTableCount, IntPtr pCoverageModulationTable)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetCoverageReductionModeNV(VkCommandBuffer commandBuffer, VkCoverageReductionModeNV coverageReductionMode)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetCoverageToColorEnableNV(VkCommandBuffer commandBuffer, VkBool32 coverageToColorEnable)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetCoverageToColorLocationNV(VkCommandBuffer commandBuffer, uint coverageToColorLocation)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetDepthClampEnableEXT(VkCommandBuffer commandBuffer, VkBool32 depthClampEnable)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetDepthClipEnableEXT(VkCommandBuffer commandBuffer, VkBool32 depthClipEnable)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetDepthClipNegativeOneToOneEXT(VkCommandBuffer commandBuffer, VkBool32 negativeOneToOne)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetExtraPrimitiveOverestimationSizeEXT(VkCommandBuffer commandBuffer, float extraPrimitiveOverestimationSize)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetLineRasterizationModeEXT(VkCommandBuffer commandBuffer, VkLineRasterizationModeEXT lineRasterizationMode)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetLineStippleEnableEXT(VkCommandBuffer commandBuffer, VkBool32 stippledLineEnable)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetLogicOpEnableEXT(VkCommandBuffer commandBuffer, VkBool32 logicOpEnable)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetPolygonModeEXT(VkCommandBuffer commandBuffer, VkPolygonMode polygonMode)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetProvokingVertexModeEXT(VkCommandBuffer commandBuffer, VkProvokingVertexModeEXT provokingVertexMode)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetRasterizationSamplesEXT(VkCommandBuffer commandBuffer, VkSampleCountFlags rasterizationSamples)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetRasterizationStreamEXT(VkCommandBuffer commandBuffer, uint rasterizationStream)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetRepresentativeFragmentTestEnableNV(VkCommandBuffer commandBuffer, VkBool32 representativeFragmentTestEnable)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetSampleLocationsEnableEXT(VkCommandBuffer commandBuffer, VkBool32 sampleLocationsEnable)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetSampleMaskEXT(VkCommandBuffer commandBuffer, VkSampleCountFlags samples, uint* pSampleMask)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetSampleMaskEXT(VkCommandBuffer commandBuffer, VkSampleCountFlags samples, ref uint pSampleMask)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetSampleMaskEXT(VkCommandBuffer commandBuffer, VkSampleCountFlags samples, IntPtr pSampleMask)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetShadingRateImageEnableNV(VkCommandBuffer commandBuffer, VkBool32 shadingRateImageEnable)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetTessellationDomainOriginEXT(VkCommandBuffer commandBuffer, VkTessellationDomainOrigin domainOrigin)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetViewportSwizzleNV(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkViewportSwizzleNV* pViewportSwizzles)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetViewportSwizzleNV(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, ref VkViewportSwizzleNV pViewportSwizzles)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetViewportSwizzleNV(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, IntPtr pViewportSwizzles)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdSetViewportWScalingEnableNV(VkCommandBuffer commandBuffer, VkBool32 viewportWScalingEnable)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanEXTExtendedDynamicState3(VkDevice device)
        {
            vkCmdSetAlphaToCoverageEnableEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdSetAlphaToCoverageEnableEXT", true);
            vkCmdSetAlphaToOneEnableEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdSetAlphaToOneEnableEXT", true);
            vkCmdSetColorBlendAdvancedEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdSetColorBlendAdvancedEXT", true);
            vkCmdSetColorBlendEnableEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdSetColorBlendEnableEXT", true);
            vkCmdSetColorBlendEquationEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdSetColorBlendEquationEXT", true);
            vkCmdSetColorWriteMaskEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdSetColorWriteMaskEXT", true);
            vkCmdSetConservativeRasterizationModeEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdSetConservativeRasterizationModeEXT", true);
            vkCmdSetCoverageModulationModeNV_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdSetCoverageModulationModeNV", true);
            vkCmdSetCoverageModulationTableEnableNV_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdSetCoverageModulationTableEnableNV", true);
            vkCmdSetCoverageModulationTableNV_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdSetCoverageModulationTableNV", true);
            vkCmdSetCoverageReductionModeNV_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdSetCoverageReductionModeNV", true);
            vkCmdSetCoverageToColorEnableNV_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdSetCoverageToColorEnableNV", true);
            vkCmdSetCoverageToColorLocationNV_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdSetCoverageToColorLocationNV", true);
            vkCmdSetDepthClampEnableEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdSetDepthClampEnableEXT", true);
            vkCmdSetDepthClipEnableEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdSetDepthClipEnableEXT", true);
            vkCmdSetDepthClipNegativeOneToOneEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdSetDepthClipNegativeOneToOneEXT", true);
            vkCmdSetExtraPrimitiveOverestimationSizeEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdSetExtraPrimitiveOverestimationSizeEXT", true);
            vkCmdSetLineRasterizationModeEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdSetLineRasterizationModeEXT", true);
            vkCmdSetLineStippleEnableEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdSetLineStippleEnableEXT", true);
            vkCmdSetLogicOpEnableEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdSetLogicOpEnableEXT", true);
            vkCmdSetPolygonModeEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdSetPolygonModeEXT", true);
            vkCmdSetProvokingVertexModeEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdSetProvokingVertexModeEXT", true);
            vkCmdSetRasterizationSamplesEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdSetRasterizationSamplesEXT", true);
            vkCmdSetRasterizationStreamEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdSetRasterizationStreamEXT", true);
            vkCmdSetRepresentativeFragmentTestEnableNV_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdSetRepresentativeFragmentTestEnableNV", true);
            vkCmdSetSampleLocationsEnableEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdSetSampleLocationsEnableEXT", true);
            vkCmdSetSampleMaskEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdSetSampleMaskEXT", true);
            vkCmdSetShadingRateImageEnableNV_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdSetShadingRateImageEnableNV", true);
            vkCmdSetTessellationDomainOriginEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdSetTessellationDomainOriginEXT", true);
            vkCmdSetViewportSwizzleNV_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdSetViewportSwizzleNV", true);
            vkCmdSetViewportWScalingEnableNV_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdSetViewportWScalingEnableNV", true);
        }
    }

    public unsafe sealed class VulkanEXTShaderModuleIdentifier : IVulkanDeviceExtGeneric<VulkanEXTShaderModuleIdentifier>
    {
        public static string Name => "VK_EXT_shader_module_identifier";
        string IVulkanExt.GetName() => Name;

        public static VulkanEXTShaderModuleIdentifier Create(VkDevice device)
        {
            return new VulkanEXTShaderModuleIdentifier(device);
        }

        private IntPtr vkGetShaderModuleCreateInfoIdentifierEXT_ptr;
        private IntPtr vkGetShaderModuleIdentifierEXT_ptr;

        [Generator.CalliRewrite]
        public unsafe void vkGetShaderModuleCreateInfoIdentifierEXT(VkDevice device, VkShaderModuleCreateInfo* pCreateInfo, VkShaderModuleIdentifierEXT* pIdentifier)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetShaderModuleCreateInfoIdentifierEXT(VkDevice device, VkShaderModuleCreateInfo* pCreateInfo, out VkShaderModuleIdentifierEXT pIdentifier)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetShaderModuleCreateInfoIdentifierEXT(VkDevice device, ref VkShaderModuleCreateInfo pCreateInfo, VkShaderModuleIdentifierEXT* pIdentifier)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetShaderModuleCreateInfoIdentifierEXT(VkDevice device, ref VkShaderModuleCreateInfo pCreateInfo, out VkShaderModuleIdentifierEXT pIdentifier)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetShaderModuleCreateInfoIdentifierEXT(VkDevice device, IntPtr pCreateInfo, VkShaderModuleIdentifierEXT* pIdentifier)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetShaderModuleCreateInfoIdentifierEXT(VkDevice device, IntPtr pCreateInfo, out VkShaderModuleIdentifierEXT pIdentifier)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetShaderModuleIdentifierEXT(VkDevice device, VkShaderModule shaderModule, VkShaderModuleIdentifierEXT* pIdentifier)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkGetShaderModuleIdentifierEXT(VkDevice device, VkShaderModule shaderModule, out VkShaderModuleIdentifierEXT pIdentifier)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanEXTShaderModuleIdentifier(VkDevice device)
        {
            vkGetShaderModuleCreateInfoIdentifierEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetShaderModuleCreateInfoIdentifierEXT", true);
            vkGetShaderModuleIdentifierEXT_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetShaderModuleIdentifierEXT", true);
        }
    }

    public unsafe sealed class VulkanNVOpticalFlow : IVulkanDeviceExtGeneric<VulkanNVOpticalFlow>
    {
        public static string Name => "VK_NV_optical_flow";
        string IVulkanExt.GetName() => Name;

        public static VulkanNVOpticalFlow Create(VkDevice device)
        {
            return new VulkanNVOpticalFlow(device);
        }

        private IntPtr vkBindOpticalFlowSessionImageNV_ptr;
        private IntPtr vkCmdOpticalFlowExecuteNV_ptr;
        private IntPtr vkCreateOpticalFlowSessionNV_ptr;
        private IntPtr vkDestroyOpticalFlowSessionNV_ptr;
        private IntPtr vkGetPhysicalDeviceOpticalFlowImageFormatsNV_ptr;

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkBindOpticalFlowSessionImageNV(VkDevice device, VkOpticalFlowSessionNV session, VkOpticalFlowSessionBindingPointNV bindingPoint, VkImageView view, VkImageLayout layout)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdOpticalFlowExecuteNV(VkCommandBuffer commandBuffer, VkOpticalFlowSessionNV session, VkOpticalFlowExecuteInfoNV* pExecuteInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdOpticalFlowExecuteNV(VkCommandBuffer commandBuffer, VkOpticalFlowSessionNV session, ref VkOpticalFlowExecuteInfoNV pExecuteInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkCmdOpticalFlowExecuteNV(VkCommandBuffer commandBuffer, VkOpticalFlowSessionNV session, IntPtr pExecuteInfo)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateOpticalFlowSessionNV(VkDevice device, VkOpticalFlowSessionCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, VkOpticalFlowSessionNV* pSession)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateOpticalFlowSessionNV(VkDevice device, VkOpticalFlowSessionCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkOpticalFlowSessionNV pSession)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateOpticalFlowSessionNV(VkDevice device, VkOpticalFlowSessionCreateInfoNV* pCreateInfo, ref VkAllocationCallbacks pAllocator, VkOpticalFlowSessionNV* pSession)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateOpticalFlowSessionNV(VkDevice device, VkOpticalFlowSessionCreateInfoNV* pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkOpticalFlowSessionNV pSession)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateOpticalFlowSessionNV(VkDevice device, VkOpticalFlowSessionCreateInfoNV* pCreateInfo, IntPtr pAllocator, VkOpticalFlowSessionNV* pSession)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateOpticalFlowSessionNV(VkDevice device, VkOpticalFlowSessionCreateInfoNV* pCreateInfo, IntPtr pAllocator, out VkOpticalFlowSessionNV pSession)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateOpticalFlowSessionNV(VkDevice device, ref VkOpticalFlowSessionCreateInfoNV pCreateInfo, VkAllocationCallbacks* pAllocator, VkOpticalFlowSessionNV* pSession)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateOpticalFlowSessionNV(VkDevice device, ref VkOpticalFlowSessionCreateInfoNV pCreateInfo, VkAllocationCallbacks* pAllocator, out VkOpticalFlowSessionNV pSession)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateOpticalFlowSessionNV(VkDevice device, ref VkOpticalFlowSessionCreateInfoNV pCreateInfo, ref VkAllocationCallbacks pAllocator, VkOpticalFlowSessionNV* pSession)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateOpticalFlowSessionNV(VkDevice device, ref VkOpticalFlowSessionCreateInfoNV pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkOpticalFlowSessionNV pSession)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateOpticalFlowSessionNV(VkDevice device, ref VkOpticalFlowSessionCreateInfoNV pCreateInfo, IntPtr pAllocator, VkOpticalFlowSessionNV* pSession)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateOpticalFlowSessionNV(VkDevice device, ref VkOpticalFlowSessionCreateInfoNV pCreateInfo, IntPtr pAllocator, out VkOpticalFlowSessionNV pSession)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateOpticalFlowSessionNV(VkDevice device, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, VkOpticalFlowSessionNV* pSession)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateOpticalFlowSessionNV(VkDevice device, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, out VkOpticalFlowSessionNV pSession)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateOpticalFlowSessionNV(VkDevice device, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, VkOpticalFlowSessionNV* pSession)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateOpticalFlowSessionNV(VkDevice device, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkOpticalFlowSessionNV pSession)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateOpticalFlowSessionNV(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, VkOpticalFlowSessionNV* pSession)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkCreateOpticalFlowSessionNV(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, out VkOpticalFlowSessionNV pSession)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkDestroyOpticalFlowSessionNV(VkDevice device, VkOpticalFlowSessionNV session, VkAllocationCallbacks* pAllocator)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkDestroyOpticalFlowSessionNV(VkDevice device, VkOpticalFlowSessionNV session, ref VkAllocationCallbacks pAllocator)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        [Generator.CalliRewrite]
        public unsafe void vkDestroyOpticalFlowSessionNV(VkDevice device, VkOpticalFlowSessionNV session, IntPtr pAllocator)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_EXTENSION_NOT_PRESENT, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_FORMAT_NOT_SUPPORTED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceOpticalFlowImageFormatsNV(VkPhysicalDevice physicalDevice, VkOpticalFlowImageFormatInfoNV* pOpticalFlowImageFormatInfo, uint* pFormatCount, VkOpticalFlowImageFormatPropertiesNV* pImageFormatProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_EXTENSION_NOT_PRESENT, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_FORMAT_NOT_SUPPORTED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceOpticalFlowImageFormatsNV(VkPhysicalDevice physicalDevice, VkOpticalFlowImageFormatInfoNV* pOpticalFlowImageFormatInfo, uint* pFormatCount, out VkOpticalFlowImageFormatPropertiesNV pImageFormatProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_EXTENSION_NOT_PRESENT, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_FORMAT_NOT_SUPPORTED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceOpticalFlowImageFormatsNV(VkPhysicalDevice physicalDevice, VkOpticalFlowImageFormatInfoNV* pOpticalFlowImageFormatInfo, ref uint pFormatCount, VkOpticalFlowImageFormatPropertiesNV* pImageFormatProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_EXTENSION_NOT_PRESENT, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_FORMAT_NOT_SUPPORTED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceOpticalFlowImageFormatsNV(VkPhysicalDevice physicalDevice, VkOpticalFlowImageFormatInfoNV* pOpticalFlowImageFormatInfo, ref uint pFormatCount, out VkOpticalFlowImageFormatPropertiesNV pImageFormatProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_EXTENSION_NOT_PRESENT, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_FORMAT_NOT_SUPPORTED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceOpticalFlowImageFormatsNV(VkPhysicalDevice physicalDevice, VkOpticalFlowImageFormatInfoNV* pOpticalFlowImageFormatInfo, IntPtr pFormatCount, VkOpticalFlowImageFormatPropertiesNV* pImageFormatProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_EXTENSION_NOT_PRESENT, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_FORMAT_NOT_SUPPORTED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceOpticalFlowImageFormatsNV(VkPhysicalDevice physicalDevice, VkOpticalFlowImageFormatInfoNV* pOpticalFlowImageFormatInfo, IntPtr pFormatCount, out VkOpticalFlowImageFormatPropertiesNV pImageFormatProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_EXTENSION_NOT_PRESENT, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_FORMAT_NOT_SUPPORTED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceOpticalFlowImageFormatsNV(VkPhysicalDevice physicalDevice, ref VkOpticalFlowImageFormatInfoNV pOpticalFlowImageFormatInfo, uint* pFormatCount, VkOpticalFlowImageFormatPropertiesNV* pImageFormatProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_EXTENSION_NOT_PRESENT, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_FORMAT_NOT_SUPPORTED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceOpticalFlowImageFormatsNV(VkPhysicalDevice physicalDevice, ref VkOpticalFlowImageFormatInfoNV pOpticalFlowImageFormatInfo, uint* pFormatCount, out VkOpticalFlowImageFormatPropertiesNV pImageFormatProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_EXTENSION_NOT_PRESENT, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_FORMAT_NOT_SUPPORTED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceOpticalFlowImageFormatsNV(VkPhysicalDevice physicalDevice, ref VkOpticalFlowImageFormatInfoNV pOpticalFlowImageFormatInfo, ref uint pFormatCount, VkOpticalFlowImageFormatPropertiesNV* pImageFormatProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_EXTENSION_NOT_PRESENT, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_FORMAT_NOT_SUPPORTED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceOpticalFlowImageFormatsNV(VkPhysicalDevice physicalDevice, ref VkOpticalFlowImageFormatInfoNV pOpticalFlowImageFormatInfo, ref uint pFormatCount, out VkOpticalFlowImageFormatPropertiesNV pImageFormatProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_EXTENSION_NOT_PRESENT, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_FORMAT_NOT_SUPPORTED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceOpticalFlowImageFormatsNV(VkPhysicalDevice physicalDevice, ref VkOpticalFlowImageFormatInfoNV pOpticalFlowImageFormatInfo, IntPtr pFormatCount, VkOpticalFlowImageFormatPropertiesNV* pImageFormatProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_EXTENSION_NOT_PRESENT, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_FORMAT_NOT_SUPPORTED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceOpticalFlowImageFormatsNV(VkPhysicalDevice physicalDevice, ref VkOpticalFlowImageFormatInfoNV pOpticalFlowImageFormatInfo, IntPtr pFormatCount, out VkOpticalFlowImageFormatPropertiesNV pImageFormatProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_EXTENSION_NOT_PRESENT, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_FORMAT_NOT_SUPPORTED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceOpticalFlowImageFormatsNV(VkPhysicalDevice physicalDevice, IntPtr pOpticalFlowImageFormatInfo, uint* pFormatCount, VkOpticalFlowImageFormatPropertiesNV* pImageFormatProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_EXTENSION_NOT_PRESENT, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_FORMAT_NOT_SUPPORTED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceOpticalFlowImageFormatsNV(VkPhysicalDevice physicalDevice, IntPtr pOpticalFlowImageFormatInfo, uint* pFormatCount, out VkOpticalFlowImageFormatPropertiesNV pImageFormatProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_EXTENSION_NOT_PRESENT, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_FORMAT_NOT_SUPPORTED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceOpticalFlowImageFormatsNV(VkPhysicalDevice physicalDevice, IntPtr pOpticalFlowImageFormatInfo, ref uint pFormatCount, VkOpticalFlowImageFormatPropertiesNV* pImageFormatProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_EXTENSION_NOT_PRESENT, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_FORMAT_NOT_SUPPORTED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceOpticalFlowImageFormatsNV(VkPhysicalDevice physicalDevice, IntPtr pOpticalFlowImageFormatInfo, ref uint pFormatCount, out VkOpticalFlowImageFormatPropertiesNV pImageFormatProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_EXTENSION_NOT_PRESENT, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_FORMAT_NOT_SUPPORTED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceOpticalFlowImageFormatsNV(VkPhysicalDevice physicalDevice, IntPtr pOpticalFlowImageFormatInfo, IntPtr pFormatCount, VkOpticalFlowImageFormatPropertiesNV* pImageFormatProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_EXTENSION_NOT_PRESENT, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_FORMAT_NOT_SUPPORTED</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetPhysicalDeviceOpticalFlowImageFormatsNV(VkPhysicalDevice physicalDevice, IntPtr pOpticalFlowImageFormatInfo, IntPtr pFormatCount, out VkOpticalFlowImageFormatPropertiesNV pImageFormatProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanNVOpticalFlow(VkDevice device)
        {
            vkBindOpticalFlowSessionImageNV_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkBindOpticalFlowSessionImageNV", true);
            vkCmdOpticalFlowExecuteNV_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCmdOpticalFlowExecuteNV", true);
            vkCreateOpticalFlowSessionNV_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkCreateOpticalFlowSessionNV", true);
            vkDestroyOpticalFlowSessionNV_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkDestroyOpticalFlowSessionNV", true);
            vkGetPhysicalDeviceOpticalFlowImageFormatsNV_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetPhysicalDeviceOpticalFlowImageFormatsNV", true);
        }
    }

    public unsafe sealed class VulkanQcomTileProperties : IVulkanDeviceExtGeneric<VulkanQcomTileProperties>
    {
        public static string Name => "VK_QCOM_tile_properties";
        string IVulkanExt.GetName() => Name;

        public static VulkanQcomTileProperties Create(VkDevice device)
        {
            return new VulkanQcomTileProperties(device);
        }

        private IntPtr vkGetDynamicRenderingTilePropertiesQCOM_ptr;
        private IntPtr vkGetFramebufferTilePropertiesQCOM_ptr;

        ///<remarks>Success codes:VK_SUCCESS. Error codes:</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetDynamicRenderingTilePropertiesQCOM(VkDevice device, VkRenderingInfo* pRenderingInfo, VkTilePropertiesQCOM* pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetDynamicRenderingTilePropertiesQCOM(VkDevice device, VkRenderingInfo* pRenderingInfo, out VkTilePropertiesQCOM pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetDynamicRenderingTilePropertiesQCOM(VkDevice device, ref VkRenderingInfo pRenderingInfo, VkTilePropertiesQCOM* pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetDynamicRenderingTilePropertiesQCOM(VkDevice device, ref VkRenderingInfo pRenderingInfo, out VkTilePropertiesQCOM pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetDynamicRenderingTilePropertiesQCOM(VkDevice device, IntPtr pRenderingInfo, VkTilePropertiesQCOM* pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS. Error codes:</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetDynamicRenderingTilePropertiesQCOM(VkDevice device, IntPtr pRenderingInfo, out VkTilePropertiesQCOM pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetFramebufferTilePropertiesQCOM(VkDevice device, VkFramebuffer framebuffer, uint* pPropertiesCount, VkTilePropertiesQCOM* pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetFramebufferTilePropertiesQCOM(VkDevice device, VkFramebuffer framebuffer, uint* pPropertiesCount, out VkTilePropertiesQCOM pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetFramebufferTilePropertiesQCOM(VkDevice device, VkFramebuffer framebuffer, ref uint pPropertiesCount, VkTilePropertiesQCOM* pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetFramebufferTilePropertiesQCOM(VkDevice device, VkFramebuffer framebuffer, ref uint pPropertiesCount, out VkTilePropertiesQCOM pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetFramebufferTilePropertiesQCOM(VkDevice device, VkFramebuffer framebuffer, IntPtr pPropertiesCount, VkTilePropertiesQCOM* pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:</remarks>
        [Generator.CalliRewrite]
        public unsafe VkResult vkGetFramebufferTilePropertiesQCOM(VkDevice device, VkFramebuffer framebuffer, IntPtr pPropertiesCount, out VkTilePropertiesQCOM pProperties)
        {
            throw VulkanNative.CreateUnpatchedException();
        }

        public VulkanQcomTileProperties(VkDevice device)
        {
            vkGetDynamicRenderingTilePropertiesQCOM_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetDynamicRenderingTilePropertiesQCOM", true);
            vkGetFramebufferTilePropertiesQCOM_ptr = VulkanNative.LoadDeviceProcAddr(device, "vkGetFramebufferTilePropertiesQCOM", true);
        }
    }

}
