// This file is generated.

using System;

namespace Vulkan
{
    public static unsafe partial class VulkanNative
    {
        public unsafe sealed class VulkanKHRSurface
        {
            private IntPtr vkDestroySurfaceKHR_ptr;
            private IntPtr vkGetPhysicalDeviceSurfaceCapabilitiesKHR_ptr;
            private IntPtr vkGetPhysicalDeviceSurfaceFormatsKHR_ptr;
            private IntPtr vkGetPhysicalDeviceSurfacePresentModesKHR_ptr;
            private IntPtr vkGetPhysicalDeviceSurfaceSupportKHR_ptr;

            public VulkanKHRSurface(VkInstance instance)
            {
                vkDestroySurfaceKHR_ptr = LoadInstanceProcAddr(instance, "vkDestroySurfaceKHR");
                vkGetPhysicalDeviceSurfaceCapabilitiesKHR_ptr = LoadInstanceProcAddr(instance, "vkGetPhysicalDeviceSurfaceCapabilitiesKHR");
                vkGetPhysicalDeviceSurfaceFormatsKHR_ptr = LoadInstanceProcAddr(instance, "vkGetPhysicalDeviceSurfaceFormatsKHR");
                vkGetPhysicalDeviceSurfacePresentModesKHR_ptr = LoadInstanceProcAddr(instance, "vkGetPhysicalDeviceSurfacePresentModesKHR");
                vkGetPhysicalDeviceSurfaceSupportKHR_ptr = LoadInstanceProcAddr(instance, "vkGetPhysicalDeviceSurfaceSupportKHR");
            }

            [Generator.CalliRewrite]
            public unsafe void vkDestroySurfaceKHR(VkInstance instance, VkSurfaceKHR surface, VkAllocationCallbacks* pAllocator)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkDestroySurfaceKHR(VkInstance instance, VkSurfaceKHR surface, ref VkAllocationCallbacks pAllocator)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkDestroySurfaceKHR(VkInstance instance, VkSurfaceKHR surface, IntPtr pAllocator)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSurfaceCapabilitiesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, VkSurfaceCapabilitiesKHR* pSurfaceCapabilities)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSurfaceCapabilitiesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, out VkSurfaceCapabilitiesKHR pSurfaceCapabilities)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSurfaceFormatsKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pSurfaceFormatCount, VkSurfaceFormatKHR* pSurfaceFormats)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSurfaceFormatsKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pSurfaceFormatCount, out VkSurfaceFormatKHR pSurfaceFormats)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSurfaceFormatsKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, ref uint pSurfaceFormatCount, VkSurfaceFormatKHR* pSurfaceFormats)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSurfaceFormatsKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, ref uint pSurfaceFormatCount, out VkSurfaceFormatKHR pSurfaceFormats)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSurfaceFormatsKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, IntPtr pSurfaceFormatCount, VkSurfaceFormatKHR* pSurfaceFormats)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSurfaceFormatsKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, IntPtr pSurfaceFormatCount, out VkSurfaceFormatKHR pSurfaceFormats)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSurfacePresentModesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pPresentModeCount, VkPresentModeKHR* pPresentModes)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSurfacePresentModesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pPresentModeCount, out VkPresentModeKHR pPresentModes)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSurfacePresentModesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, ref uint pPresentModeCount, VkPresentModeKHR* pPresentModes)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSurfacePresentModesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, ref uint pPresentModeCount, out VkPresentModeKHR pPresentModes)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSurfacePresentModesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, IntPtr pPresentModeCount, VkPresentModeKHR* pPresentModes)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSurfacePresentModesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, IntPtr pPresentModeCount, out VkPresentModeKHR pPresentModes)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSurfaceSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, VkSurfaceKHR surface, VkBool32* pSupported)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSurfaceSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, VkSurfaceKHR surface, out VkBool32 pSupported)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanKHRSwapchain
        {
            private IntPtr vkAcquireNextImageKHR_ptr;
            private IntPtr vkCreateSwapchainKHR_ptr;
            private IntPtr vkDestroySwapchainKHR_ptr;
            private IntPtr vkGetSwapchainImagesKHR_ptr;
            private IntPtr vkQueuePresentKHR_ptr;

            public VulkanKHRSwapchain(VkDevice device)
            {
                vkAcquireNextImageKHR_ptr = LoadDeviceProcAddr(device, "vkAcquireNextImageKHR");
                vkCreateSwapchainKHR_ptr = LoadDeviceProcAddr(device, "vkCreateSwapchainKHR");
                vkDestroySwapchainKHR_ptr = LoadDeviceProcAddr(device, "vkDestroySwapchainKHR");
                vkGetSwapchainImagesKHR_ptr = LoadDeviceProcAddr(device, "vkGetSwapchainImagesKHR");
                vkQueuePresentKHR_ptr = LoadDeviceProcAddr(device, "vkQueuePresentKHR");
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_TIMEOUT, VK_NOT_READY, VK_SUBOPTIMAL_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_OUT_OF_DATE_KHR, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_FULL_SCREEN_EXCLUSIVE_MODE_LOST_EXT</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkAcquireNextImageKHR(VkDevice device, VkSwapchainKHR swapchain, ulong timeout, VkSemaphore semaphore, VkFence fence, uint* pImageIndex)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_TIMEOUT, VK_NOT_READY, VK_SUBOPTIMAL_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_OUT_OF_DATE_KHR, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_FULL_SCREEN_EXCLUSIVE_MODE_LOST_EXT</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkAcquireNextImageKHR(VkDevice device, VkSwapchainKHR swapchain, ulong timeout, VkSemaphore semaphore, VkFence fence, ref uint pImageIndex)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_TIMEOUT, VK_NOT_READY, VK_SUBOPTIMAL_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_OUT_OF_DATE_KHR, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_FULL_SCREEN_EXCLUSIVE_MODE_LOST_EXT</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkAcquireNextImageKHR(VkDevice device, VkSwapchainKHR swapchain, ulong timeout, VkSemaphore semaphore, VkFence fence, IntPtr pImageIndex)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_COMPRESSION_EXHAUSTED_EXT</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateSwapchainKHR(VkDevice device, VkSwapchainCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSwapchainKHR* pSwapchain)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_COMPRESSION_EXHAUSTED_EXT</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateSwapchainKHR(VkDevice device, VkSwapchainCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSwapchainKHR pSwapchain)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_COMPRESSION_EXHAUSTED_EXT</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateSwapchainKHR(VkDevice device, VkSwapchainCreateInfoKHR* pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSwapchainKHR* pSwapchain)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_COMPRESSION_EXHAUSTED_EXT</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateSwapchainKHR(VkDevice device, VkSwapchainCreateInfoKHR* pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSwapchainKHR pSwapchain)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_COMPRESSION_EXHAUSTED_EXT</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateSwapchainKHR(VkDevice device, VkSwapchainCreateInfoKHR* pCreateInfo, IntPtr pAllocator, VkSwapchainKHR* pSwapchain)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_COMPRESSION_EXHAUSTED_EXT</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateSwapchainKHR(VkDevice device, VkSwapchainCreateInfoKHR* pCreateInfo, IntPtr pAllocator, out VkSwapchainKHR pSwapchain)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_COMPRESSION_EXHAUSTED_EXT</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateSwapchainKHR(VkDevice device, ref VkSwapchainCreateInfoKHR pCreateInfo, VkAllocationCallbacks* pAllocator, VkSwapchainKHR* pSwapchain)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_COMPRESSION_EXHAUSTED_EXT</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateSwapchainKHR(VkDevice device, ref VkSwapchainCreateInfoKHR pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSwapchainKHR pSwapchain)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_COMPRESSION_EXHAUSTED_EXT</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateSwapchainKHR(VkDevice device, ref VkSwapchainCreateInfoKHR pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSwapchainKHR* pSwapchain)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_COMPRESSION_EXHAUSTED_EXT</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateSwapchainKHR(VkDevice device, ref VkSwapchainCreateInfoKHR pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSwapchainKHR pSwapchain)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_COMPRESSION_EXHAUSTED_EXT</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateSwapchainKHR(VkDevice device, ref VkSwapchainCreateInfoKHR pCreateInfo, IntPtr pAllocator, VkSwapchainKHR* pSwapchain)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_COMPRESSION_EXHAUSTED_EXT</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateSwapchainKHR(VkDevice device, ref VkSwapchainCreateInfoKHR pCreateInfo, IntPtr pAllocator, out VkSwapchainKHR pSwapchain)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_COMPRESSION_EXHAUSTED_EXT</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateSwapchainKHR(VkDevice device, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, VkSwapchainKHR* pSwapchain)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_COMPRESSION_EXHAUSTED_EXT</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateSwapchainKHR(VkDevice device, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSwapchainKHR pSwapchain)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_COMPRESSION_EXHAUSTED_EXT</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateSwapchainKHR(VkDevice device, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSwapchainKHR* pSwapchain)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_COMPRESSION_EXHAUSTED_EXT</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateSwapchainKHR(VkDevice device, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSwapchainKHR pSwapchain)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_COMPRESSION_EXHAUSTED_EXT</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateSwapchainKHR(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, VkSwapchainKHR* pSwapchain)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_COMPRESSION_EXHAUSTED_EXT</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateSwapchainKHR(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, out VkSwapchainKHR pSwapchain)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkDestroySwapchainKHR(VkDevice device, VkSwapchainKHR swapchain, VkAllocationCallbacks* pAllocator)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkDestroySwapchainKHR(VkDevice device, VkSwapchainKHR swapchain, ref VkAllocationCallbacks pAllocator)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkDestroySwapchainKHR(VkDevice device, VkSwapchainKHR swapchain, IntPtr pAllocator)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetSwapchainImagesKHR(VkDevice device, VkSwapchainKHR swapchain, uint* pSwapchainImageCount, VkImage* pSwapchainImages)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetSwapchainImagesKHR(VkDevice device, VkSwapchainKHR swapchain, uint* pSwapchainImageCount, out VkImage pSwapchainImages)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetSwapchainImagesKHR(VkDevice device, VkSwapchainKHR swapchain, ref uint pSwapchainImageCount, VkImage* pSwapchainImages)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetSwapchainImagesKHR(VkDevice device, VkSwapchainKHR swapchain, ref uint pSwapchainImageCount, out VkImage pSwapchainImages)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetSwapchainImagesKHR(VkDevice device, VkSwapchainKHR swapchain, IntPtr pSwapchainImageCount, VkImage* pSwapchainImages)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetSwapchainImagesKHR(VkDevice device, VkSwapchainKHR swapchain, IntPtr pSwapchainImageCount, out VkImage pSwapchainImages)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_SUBOPTIMAL_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_OUT_OF_DATE_KHR, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_FULL_SCREEN_EXCLUSIVE_MODE_LOST_EXT</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkQueuePresentKHR(VkQueue queue, VkPresentInfoKHR* pPresentInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_SUBOPTIMAL_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_OUT_OF_DATE_KHR, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_FULL_SCREEN_EXCLUSIVE_MODE_LOST_EXT</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkQueuePresentKHR(VkQueue queue, ref VkPresentInfoKHR pPresentInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_SUBOPTIMAL_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_OUT_OF_DATE_KHR, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_FULL_SCREEN_EXCLUSIVE_MODE_LOST_EXT</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkQueuePresentKHR(VkQueue queue, IntPtr pPresentInfo)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanKHRDisplay
        {
            private IntPtr vkCreateDisplayModeKHR_ptr;
            private IntPtr vkCreateDisplayPlaneSurfaceKHR_ptr;
            private IntPtr vkGetDisplayModePropertiesKHR_ptr;
            private IntPtr vkGetDisplayPlaneCapabilitiesKHR_ptr;
            private IntPtr vkGetDisplayPlaneSupportedDisplaysKHR_ptr;
            private IntPtr vkGetPhysicalDeviceDisplayPlanePropertiesKHR_ptr;
            private IntPtr vkGetPhysicalDeviceDisplayPropertiesKHR_ptr;

            public VulkanKHRDisplay(VkInstance instance)
            {
                vkCreateDisplayModeKHR_ptr = LoadInstanceProcAddr(instance, "vkCreateDisplayModeKHR");
                vkCreateDisplayPlaneSurfaceKHR_ptr = LoadInstanceProcAddr(instance, "vkCreateDisplayPlaneSurfaceKHR");
                vkGetDisplayModePropertiesKHR_ptr = LoadInstanceProcAddr(instance, "vkGetDisplayModePropertiesKHR");
                vkGetDisplayPlaneCapabilitiesKHR_ptr = LoadInstanceProcAddr(instance, "vkGetDisplayPlaneCapabilitiesKHR");
                vkGetDisplayPlaneSupportedDisplaysKHR_ptr = LoadInstanceProcAddr(instance, "vkGetDisplayPlaneSupportedDisplaysKHR");
                vkGetPhysicalDeviceDisplayPlanePropertiesKHR_ptr = LoadInstanceProcAddr(instance, "vkGetPhysicalDeviceDisplayPlanePropertiesKHR");
                vkGetPhysicalDeviceDisplayPropertiesKHR_ptr = LoadInstanceProcAddr(instance, "vkGetPhysicalDeviceDisplayPropertiesKHR");
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, VkDisplayModeCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDisplayModeKHR* pMode)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, VkDisplayModeCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkDisplayModeKHR pMode)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, VkDisplayModeCreateInfoKHR* pCreateInfo, ref VkAllocationCallbacks pAllocator, VkDisplayModeKHR* pMode)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, VkDisplayModeCreateInfoKHR* pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkDisplayModeKHR pMode)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, VkDisplayModeCreateInfoKHR* pCreateInfo, IntPtr pAllocator, VkDisplayModeKHR* pMode)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, VkDisplayModeCreateInfoKHR* pCreateInfo, IntPtr pAllocator, out VkDisplayModeKHR pMode)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, ref VkDisplayModeCreateInfoKHR pCreateInfo, VkAllocationCallbacks* pAllocator, VkDisplayModeKHR* pMode)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, ref VkDisplayModeCreateInfoKHR pCreateInfo, VkAllocationCallbacks* pAllocator, out VkDisplayModeKHR pMode)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, ref VkDisplayModeCreateInfoKHR pCreateInfo, ref VkAllocationCallbacks pAllocator, VkDisplayModeKHR* pMode)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, ref VkDisplayModeCreateInfoKHR pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkDisplayModeKHR pMode)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, ref VkDisplayModeCreateInfoKHR pCreateInfo, IntPtr pAllocator, VkDisplayModeKHR* pMode)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, ref VkDisplayModeCreateInfoKHR pCreateInfo, IntPtr pAllocator, out VkDisplayModeKHR pMode)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, VkDisplayModeKHR* pMode)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, out VkDisplayModeKHR pMode)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, VkDisplayModeKHR* pMode)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkDisplayModeKHR pMode)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, IntPtr pCreateInfo, IntPtr pAllocator, VkDisplayModeKHR* pMode)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, IntPtr pCreateInfo, IntPtr pAllocator, out VkDisplayModeKHR pMode)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDisplayPlaneSurfaceKHR(VkInstance instance, VkDisplaySurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDisplayPlaneSurfaceKHR(VkInstance instance, VkDisplaySurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDisplayPlaneSurfaceKHR(VkInstance instance, VkDisplaySurfaceCreateInfoKHR* pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDisplayPlaneSurfaceKHR(VkInstance instance, VkDisplaySurfaceCreateInfoKHR* pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDisplayPlaneSurfaceKHR(VkInstance instance, VkDisplaySurfaceCreateInfoKHR* pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDisplayPlaneSurfaceKHR(VkInstance instance, VkDisplaySurfaceCreateInfoKHR* pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDisplayPlaneSurfaceKHR(VkInstance instance, ref VkDisplaySurfaceCreateInfoKHR pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDisplayPlaneSurfaceKHR(VkInstance instance, ref VkDisplaySurfaceCreateInfoKHR pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDisplayPlaneSurfaceKHR(VkInstance instance, ref VkDisplaySurfaceCreateInfoKHR pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDisplayPlaneSurfaceKHR(VkInstance instance, ref VkDisplaySurfaceCreateInfoKHR pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDisplayPlaneSurfaceKHR(VkInstance instance, ref VkDisplaySurfaceCreateInfoKHR pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDisplayPlaneSurfaceKHR(VkInstance instance, ref VkDisplaySurfaceCreateInfoKHR pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDisplayPlaneSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDisplayPlaneSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDisplayPlaneSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDisplayPlaneSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDisplayPlaneSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDisplayPlaneSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetDisplayModePropertiesKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, uint* pPropertyCount, VkDisplayModePropertiesKHR* pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetDisplayModePropertiesKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, uint* pPropertyCount, out VkDisplayModePropertiesKHR pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetDisplayModePropertiesKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, ref uint pPropertyCount, VkDisplayModePropertiesKHR* pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetDisplayModePropertiesKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, ref uint pPropertyCount, out VkDisplayModePropertiesKHR pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetDisplayModePropertiesKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, IntPtr pPropertyCount, VkDisplayModePropertiesKHR* pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetDisplayModePropertiesKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, IntPtr pPropertyCount, out VkDisplayModePropertiesKHR pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetDisplayPlaneCapabilitiesKHR(VkPhysicalDevice physicalDevice, VkDisplayModeKHR mode, uint planeIndex, VkDisplayPlaneCapabilitiesKHR* pCapabilities)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetDisplayPlaneCapabilitiesKHR(VkPhysicalDevice physicalDevice, VkDisplayModeKHR mode, uint planeIndex, out VkDisplayPlaneCapabilitiesKHR pCapabilities)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetDisplayPlaneSupportedDisplaysKHR(VkPhysicalDevice physicalDevice, uint planeIndex, uint* pDisplayCount, VkDisplayKHR* pDisplays)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetDisplayPlaneSupportedDisplaysKHR(VkPhysicalDevice physicalDevice, uint planeIndex, uint* pDisplayCount, out VkDisplayKHR pDisplays)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetDisplayPlaneSupportedDisplaysKHR(VkPhysicalDevice physicalDevice, uint planeIndex, ref uint pDisplayCount, VkDisplayKHR* pDisplays)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetDisplayPlaneSupportedDisplaysKHR(VkPhysicalDevice physicalDevice, uint planeIndex, ref uint pDisplayCount, out VkDisplayKHR pDisplays)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetDisplayPlaneSupportedDisplaysKHR(VkPhysicalDevice physicalDevice, uint planeIndex, IntPtr pDisplayCount, VkDisplayKHR* pDisplays)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetDisplayPlaneSupportedDisplaysKHR(VkPhysicalDevice physicalDevice, uint planeIndex, IntPtr pDisplayCount, out VkDisplayKHR pDisplays)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceDisplayPlanePropertiesKHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayPlanePropertiesKHR* pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceDisplayPlanePropertiesKHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, out VkDisplayPlanePropertiesKHR pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceDisplayPlanePropertiesKHR(VkPhysicalDevice physicalDevice, ref uint pPropertyCount, VkDisplayPlanePropertiesKHR* pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceDisplayPlanePropertiesKHR(VkPhysicalDevice physicalDevice, ref uint pPropertyCount, out VkDisplayPlanePropertiesKHR pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceDisplayPlanePropertiesKHR(VkPhysicalDevice physicalDevice, IntPtr pPropertyCount, VkDisplayPlanePropertiesKHR* pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceDisplayPlanePropertiesKHR(VkPhysicalDevice physicalDevice, IntPtr pPropertyCount, out VkDisplayPlanePropertiesKHR pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceDisplayPropertiesKHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayPropertiesKHR* pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceDisplayPropertiesKHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, out VkDisplayPropertiesKHR pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceDisplayPropertiesKHR(VkPhysicalDevice physicalDevice, ref uint pPropertyCount, VkDisplayPropertiesKHR* pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceDisplayPropertiesKHR(VkPhysicalDevice physicalDevice, ref uint pPropertyCount, out VkDisplayPropertiesKHR pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceDisplayPropertiesKHR(VkPhysicalDevice physicalDevice, IntPtr pPropertyCount, VkDisplayPropertiesKHR* pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceDisplayPropertiesKHR(VkPhysicalDevice physicalDevice, IntPtr pPropertyCount, out VkDisplayPropertiesKHR pProperties)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanKHRDisplaySwapchain
        {
            private IntPtr vkCreateSharedSwapchainsKHR_ptr;

            public VulkanKHRDisplaySwapchain(VkDevice device)
            {
                vkCreateSharedSwapchainsKHR_ptr = LoadDeviceProcAddr(device, "vkCreateSharedSwapchainsKHR");
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INCOMPATIBLE_DISPLAY_KHR, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, VkSwapchainCreateInfoKHR* pCreateInfos, VkAllocationCallbacks* pAllocator, VkSwapchainKHR* pSwapchains)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INCOMPATIBLE_DISPLAY_KHR, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, VkSwapchainCreateInfoKHR* pCreateInfos, VkAllocationCallbacks* pAllocator, out VkSwapchainKHR pSwapchains)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INCOMPATIBLE_DISPLAY_KHR, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, VkSwapchainCreateInfoKHR* pCreateInfos, ref VkAllocationCallbacks pAllocator, VkSwapchainKHR* pSwapchains)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INCOMPATIBLE_DISPLAY_KHR, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, VkSwapchainCreateInfoKHR* pCreateInfos, ref VkAllocationCallbacks pAllocator, out VkSwapchainKHR pSwapchains)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INCOMPATIBLE_DISPLAY_KHR, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, VkSwapchainCreateInfoKHR* pCreateInfos, IntPtr pAllocator, VkSwapchainKHR* pSwapchains)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INCOMPATIBLE_DISPLAY_KHR, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, VkSwapchainCreateInfoKHR* pCreateInfos, IntPtr pAllocator, out VkSwapchainKHR pSwapchains)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INCOMPATIBLE_DISPLAY_KHR, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, ref VkSwapchainCreateInfoKHR pCreateInfos, VkAllocationCallbacks* pAllocator, VkSwapchainKHR* pSwapchains)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INCOMPATIBLE_DISPLAY_KHR, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, ref VkSwapchainCreateInfoKHR pCreateInfos, VkAllocationCallbacks* pAllocator, out VkSwapchainKHR pSwapchains)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INCOMPATIBLE_DISPLAY_KHR, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, ref VkSwapchainCreateInfoKHR pCreateInfos, ref VkAllocationCallbacks pAllocator, VkSwapchainKHR* pSwapchains)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INCOMPATIBLE_DISPLAY_KHR, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, ref VkSwapchainCreateInfoKHR pCreateInfos, ref VkAllocationCallbacks pAllocator, out VkSwapchainKHR pSwapchains)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INCOMPATIBLE_DISPLAY_KHR, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, ref VkSwapchainCreateInfoKHR pCreateInfos, IntPtr pAllocator, VkSwapchainKHR* pSwapchains)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INCOMPATIBLE_DISPLAY_KHR, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, ref VkSwapchainCreateInfoKHR pCreateInfos, IntPtr pAllocator, out VkSwapchainKHR pSwapchains)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INCOMPATIBLE_DISPLAY_KHR, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, IntPtr pCreateInfos, VkAllocationCallbacks* pAllocator, VkSwapchainKHR* pSwapchains)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INCOMPATIBLE_DISPLAY_KHR, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, IntPtr pCreateInfos, VkAllocationCallbacks* pAllocator, out VkSwapchainKHR pSwapchains)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INCOMPATIBLE_DISPLAY_KHR, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, IntPtr pCreateInfos, ref VkAllocationCallbacks pAllocator, VkSwapchainKHR* pSwapchains)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INCOMPATIBLE_DISPLAY_KHR, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, IntPtr pCreateInfos, ref VkAllocationCallbacks pAllocator, out VkSwapchainKHR pSwapchains)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INCOMPATIBLE_DISPLAY_KHR, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, IntPtr pCreateInfos, IntPtr pAllocator, VkSwapchainKHR* pSwapchains)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INCOMPATIBLE_DISPLAY_KHR, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, IntPtr pCreateInfos, IntPtr pAllocator, out VkSwapchainKHR pSwapchains)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INCOMPATIBLE_DISPLAY_KHR, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, VkSwapchainCreateInfoKHR[] pCreateInfos, VkAllocationCallbacks* pAllocator, VkSwapchainKHR* pSwapchains)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INCOMPATIBLE_DISPLAY_KHR, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, VkSwapchainCreateInfoKHR[] pCreateInfos, VkAllocationCallbacks* pAllocator, out VkSwapchainKHR pSwapchains)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INCOMPATIBLE_DISPLAY_KHR, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, VkSwapchainCreateInfoKHR[] pCreateInfos, ref VkAllocationCallbacks pAllocator, VkSwapchainKHR* pSwapchains)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INCOMPATIBLE_DISPLAY_KHR, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, VkSwapchainCreateInfoKHR[] pCreateInfos, ref VkAllocationCallbacks pAllocator, out VkSwapchainKHR pSwapchains)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INCOMPATIBLE_DISPLAY_KHR, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, VkSwapchainCreateInfoKHR[] pCreateInfos, IntPtr pAllocator, VkSwapchainKHR* pSwapchains)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INCOMPATIBLE_DISPLAY_KHR, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, VkSwapchainCreateInfoKHR[] pCreateInfos, IntPtr pAllocator, out VkSwapchainKHR pSwapchains)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanKHRXlibSurface
        {
            private IntPtr vkCreateXlibSurfaceKHR_ptr;
            private IntPtr vkGetPhysicalDeviceXlibPresentationSupportKHR_ptr;

            public VulkanKHRXlibSurface(VkInstance instance)
            {
                vkCreateXlibSurfaceKHR_ptr = LoadInstanceProcAddr(instance, "vkCreateXlibSurfaceKHR");
                vkGetPhysicalDeviceXlibPresentationSupportKHR_ptr = LoadInstanceProcAddr(instance, "vkGetPhysicalDeviceXlibPresentationSupportKHR");
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateXlibSurfaceKHR(VkInstance instance, VkXlibSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateXlibSurfaceKHR(VkInstance instance, VkXlibSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateXlibSurfaceKHR(VkInstance instance, VkXlibSurfaceCreateInfoKHR* pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateXlibSurfaceKHR(VkInstance instance, VkXlibSurfaceCreateInfoKHR* pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateXlibSurfaceKHR(VkInstance instance, VkXlibSurfaceCreateInfoKHR* pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateXlibSurfaceKHR(VkInstance instance, VkXlibSurfaceCreateInfoKHR* pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateXlibSurfaceKHR(VkInstance instance, ref VkXlibSurfaceCreateInfoKHR pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateXlibSurfaceKHR(VkInstance instance, ref VkXlibSurfaceCreateInfoKHR pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateXlibSurfaceKHR(VkInstance instance, ref VkXlibSurfaceCreateInfoKHR pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateXlibSurfaceKHR(VkInstance instance, ref VkXlibSurfaceCreateInfoKHR pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateXlibSurfaceKHR(VkInstance instance, ref VkXlibSurfaceCreateInfoKHR pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateXlibSurfaceKHR(VkInstance instance, ref VkXlibSurfaceCreateInfoKHR pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateXlibSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateXlibSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateXlibSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateXlibSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateXlibSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateXlibSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe VkBool32 vkGetPhysicalDeviceXlibPresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, Xlib.Display* dpy, Xlib.VisualID visualID)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe VkBool32 vkGetPhysicalDeviceXlibPresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, ref Xlib.Display dpy, Xlib.VisualID visualID)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe VkBool32 vkGetPhysicalDeviceXlibPresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr dpy, Xlib.VisualID visualID)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanKHRXcbSurface
        {
            private IntPtr vkCreateXcbSurfaceKHR_ptr;
            private IntPtr vkGetPhysicalDeviceXcbPresentationSupportKHR_ptr;

            public VulkanKHRXcbSurface(VkInstance instance)
            {
                vkCreateXcbSurfaceKHR_ptr = LoadInstanceProcAddr(instance, "vkCreateXcbSurfaceKHR");
                vkGetPhysicalDeviceXcbPresentationSupportKHR_ptr = LoadInstanceProcAddr(instance, "vkGetPhysicalDeviceXcbPresentationSupportKHR");
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateXcbSurfaceKHR(VkInstance instance, VkXcbSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateXcbSurfaceKHR(VkInstance instance, VkXcbSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateXcbSurfaceKHR(VkInstance instance, VkXcbSurfaceCreateInfoKHR* pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateXcbSurfaceKHR(VkInstance instance, VkXcbSurfaceCreateInfoKHR* pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateXcbSurfaceKHR(VkInstance instance, VkXcbSurfaceCreateInfoKHR* pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateXcbSurfaceKHR(VkInstance instance, VkXcbSurfaceCreateInfoKHR* pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateXcbSurfaceKHR(VkInstance instance, ref VkXcbSurfaceCreateInfoKHR pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateXcbSurfaceKHR(VkInstance instance, ref VkXcbSurfaceCreateInfoKHR pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateXcbSurfaceKHR(VkInstance instance, ref VkXcbSurfaceCreateInfoKHR pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateXcbSurfaceKHR(VkInstance instance, ref VkXcbSurfaceCreateInfoKHR pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateXcbSurfaceKHR(VkInstance instance, ref VkXcbSurfaceCreateInfoKHR pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateXcbSurfaceKHR(VkInstance instance, ref VkXcbSurfaceCreateInfoKHR pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateXcbSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateXcbSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateXcbSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateXcbSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateXcbSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateXcbSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe VkBool32 vkGetPhysicalDeviceXcbPresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, Xcb.xcb_connection_t* connection, Xcb.xcb_visualid_t visual_id)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe VkBool32 vkGetPhysicalDeviceXcbPresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, ref Xcb.xcb_connection_t connection, Xcb.xcb_visualid_t visual_id)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe VkBool32 vkGetPhysicalDeviceXcbPresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr connection, Xcb.xcb_visualid_t visual_id)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanKHRWaylandSurface
        {
            private IntPtr vkCreateWaylandSurfaceKHR_ptr;
            private IntPtr vkGetPhysicalDeviceWaylandPresentationSupportKHR_ptr;

            public VulkanKHRWaylandSurface(VkInstance instance)
            {
                vkCreateWaylandSurfaceKHR_ptr = LoadInstanceProcAddr(instance, "vkCreateWaylandSurfaceKHR");
                vkGetPhysicalDeviceWaylandPresentationSupportKHR_ptr = LoadInstanceProcAddr(instance, "vkGetPhysicalDeviceWaylandPresentationSupportKHR");
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateWaylandSurfaceKHR(VkInstance instance, VkWaylandSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateWaylandSurfaceKHR(VkInstance instance, VkWaylandSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateWaylandSurfaceKHR(VkInstance instance, VkWaylandSurfaceCreateInfoKHR* pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateWaylandSurfaceKHR(VkInstance instance, VkWaylandSurfaceCreateInfoKHR* pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateWaylandSurfaceKHR(VkInstance instance, VkWaylandSurfaceCreateInfoKHR* pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateWaylandSurfaceKHR(VkInstance instance, VkWaylandSurfaceCreateInfoKHR* pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateWaylandSurfaceKHR(VkInstance instance, ref VkWaylandSurfaceCreateInfoKHR pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateWaylandSurfaceKHR(VkInstance instance, ref VkWaylandSurfaceCreateInfoKHR pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateWaylandSurfaceKHR(VkInstance instance, ref VkWaylandSurfaceCreateInfoKHR pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateWaylandSurfaceKHR(VkInstance instance, ref VkWaylandSurfaceCreateInfoKHR pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateWaylandSurfaceKHR(VkInstance instance, ref VkWaylandSurfaceCreateInfoKHR pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateWaylandSurfaceKHR(VkInstance instance, ref VkWaylandSurfaceCreateInfoKHR pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateWaylandSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateWaylandSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateWaylandSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateWaylandSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateWaylandSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateWaylandSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe VkBool32 vkGetPhysicalDeviceWaylandPresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, Wayland.wl_display* display)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe VkBool32 vkGetPhysicalDeviceWaylandPresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, out Wayland.wl_display display)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanKHRAndroidSurface
        {
            private IntPtr vkCreateAndroidSurfaceKHR_ptr;

            public VulkanKHRAndroidSurface(VkInstance instance)
            {
                vkCreateAndroidSurfaceKHR_ptr = LoadInstanceProcAddr(instance, "vkCreateAndroidSurfaceKHR");
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateAndroidSurfaceKHR(VkInstance instance, VkAndroidSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateAndroidSurfaceKHR(VkInstance instance, VkAndroidSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateAndroidSurfaceKHR(VkInstance instance, VkAndroidSurfaceCreateInfoKHR* pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateAndroidSurfaceKHR(VkInstance instance, VkAndroidSurfaceCreateInfoKHR* pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateAndroidSurfaceKHR(VkInstance instance, VkAndroidSurfaceCreateInfoKHR* pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateAndroidSurfaceKHR(VkInstance instance, VkAndroidSurfaceCreateInfoKHR* pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateAndroidSurfaceKHR(VkInstance instance, ref VkAndroidSurfaceCreateInfoKHR pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateAndroidSurfaceKHR(VkInstance instance, ref VkAndroidSurfaceCreateInfoKHR pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateAndroidSurfaceKHR(VkInstance instance, ref VkAndroidSurfaceCreateInfoKHR pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateAndroidSurfaceKHR(VkInstance instance, ref VkAndroidSurfaceCreateInfoKHR pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateAndroidSurfaceKHR(VkInstance instance, ref VkAndroidSurfaceCreateInfoKHR pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateAndroidSurfaceKHR(VkInstance instance, ref VkAndroidSurfaceCreateInfoKHR pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateAndroidSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateAndroidSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateAndroidSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateAndroidSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateAndroidSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateAndroidSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanKHRWin32Surface
        {
            private IntPtr vkCreateWin32SurfaceKHR_ptr;
            private IntPtr vkGetPhysicalDeviceWin32PresentationSupportKHR_ptr;

            public VulkanKHRWin32Surface(VkInstance instance)
            {
                vkCreateWin32SurfaceKHR_ptr = LoadInstanceProcAddr(instance, "vkCreateWin32SurfaceKHR");
                vkGetPhysicalDeviceWin32PresentationSupportKHR_ptr = LoadInstanceProcAddr(instance, "vkGetPhysicalDeviceWin32PresentationSupportKHR");
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateWin32SurfaceKHR(VkInstance instance, VkWin32SurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateWin32SurfaceKHR(VkInstance instance, VkWin32SurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateWin32SurfaceKHR(VkInstance instance, VkWin32SurfaceCreateInfoKHR* pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateWin32SurfaceKHR(VkInstance instance, VkWin32SurfaceCreateInfoKHR* pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateWin32SurfaceKHR(VkInstance instance, VkWin32SurfaceCreateInfoKHR* pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateWin32SurfaceKHR(VkInstance instance, VkWin32SurfaceCreateInfoKHR* pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateWin32SurfaceKHR(VkInstance instance, ref VkWin32SurfaceCreateInfoKHR pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateWin32SurfaceKHR(VkInstance instance, ref VkWin32SurfaceCreateInfoKHR pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateWin32SurfaceKHR(VkInstance instance, ref VkWin32SurfaceCreateInfoKHR pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateWin32SurfaceKHR(VkInstance instance, ref VkWin32SurfaceCreateInfoKHR pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateWin32SurfaceKHR(VkInstance instance, ref VkWin32SurfaceCreateInfoKHR pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateWin32SurfaceKHR(VkInstance instance, ref VkWin32SurfaceCreateInfoKHR pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateWin32SurfaceKHR(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateWin32SurfaceKHR(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateWin32SurfaceKHR(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateWin32SurfaceKHR(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateWin32SurfaceKHR(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateWin32SurfaceKHR(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe VkBool32 vkGetPhysicalDeviceWin32PresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanAndroidNativeBuffer
        {
            private IntPtr vkAcquireImageANDROID_ptr;
            private IntPtr vkGetSwapchainGrallocUsage2ANDROID_ptr;
            private IntPtr vkGetSwapchainGrallocUsageANDROID_ptr;
            private IntPtr vkQueueSignalReleaseImageANDROID_ptr;

            public VulkanAndroidNativeBuffer(VkDevice device)
            {
                vkAcquireImageANDROID_ptr = LoadDeviceProcAddr(device, "vkAcquireImageANDROID");
                vkGetSwapchainGrallocUsage2ANDROID_ptr = LoadDeviceProcAddr(device, "vkGetSwapchainGrallocUsage2ANDROID");
                vkGetSwapchainGrallocUsageANDROID_ptr = LoadDeviceProcAddr(device, "vkGetSwapchainGrallocUsageANDROID");
                vkQueueSignalReleaseImageANDROID_ptr = LoadDeviceProcAddr(device, "vkQueueSignalReleaseImageANDROID");
            }

            [Generator.CalliRewrite]
            public unsafe VkResult vkAcquireImageANDROID(VkDevice device, VkImage image, int nativeFenceFd, VkSemaphore semaphore, VkFence fence)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe VkResult vkGetSwapchainGrallocUsage2ANDROID(VkDevice device, VkFormat format, VkImageUsageFlags imageUsage, VkSwapchainImageUsageFlagsANDROID swapchainImageUsage, ulong* grallocConsumerUsage, ulong* grallocProducerUsage)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe VkResult vkGetSwapchainGrallocUsage2ANDROID(VkDevice device, VkFormat format, VkImageUsageFlags imageUsage, VkSwapchainImageUsageFlagsANDROID swapchainImageUsage, ulong* grallocConsumerUsage, out ulong grallocProducerUsage)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe VkResult vkGetSwapchainGrallocUsage2ANDROID(VkDevice device, VkFormat format, VkImageUsageFlags imageUsage, VkSwapchainImageUsageFlagsANDROID swapchainImageUsage, ref ulong grallocConsumerUsage, ulong* grallocProducerUsage)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe VkResult vkGetSwapchainGrallocUsage2ANDROID(VkDevice device, VkFormat format, VkImageUsageFlags imageUsage, VkSwapchainImageUsageFlagsANDROID swapchainImageUsage, ref ulong grallocConsumerUsage, out ulong grallocProducerUsage)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe VkResult vkGetSwapchainGrallocUsage2ANDROID(VkDevice device, VkFormat format, VkImageUsageFlags imageUsage, VkSwapchainImageUsageFlagsANDROID swapchainImageUsage, IntPtr grallocConsumerUsage, ulong* grallocProducerUsage)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe VkResult vkGetSwapchainGrallocUsage2ANDROID(VkDevice device, VkFormat format, VkImageUsageFlags imageUsage, VkSwapchainImageUsageFlagsANDROID swapchainImageUsage, IntPtr grallocConsumerUsage, out ulong grallocProducerUsage)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe VkResult vkGetSwapchainGrallocUsageANDROID(VkDevice device, VkFormat format, VkImageUsageFlags imageUsage, int* grallocUsage)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe VkResult vkGetSwapchainGrallocUsageANDROID(VkDevice device, VkFormat format, VkImageUsageFlags imageUsage, out int grallocUsage)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe VkResult vkQueueSignalReleaseImageANDROID(VkQueue queue, uint waitSemaphoreCount, VkSemaphore* pWaitSemaphores, VkImage image, int* pNativeFenceFd)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe VkResult vkQueueSignalReleaseImageANDROID(VkQueue queue, uint waitSemaphoreCount, VkSemaphore* pWaitSemaphores, VkImage image, ref int pNativeFenceFd)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe VkResult vkQueueSignalReleaseImageANDROID(VkQueue queue, uint waitSemaphoreCount, VkSemaphore* pWaitSemaphores, VkImage image, IntPtr pNativeFenceFd)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe VkResult vkQueueSignalReleaseImageANDROID(VkQueue queue, uint waitSemaphoreCount, ref VkSemaphore pWaitSemaphores, VkImage image, int* pNativeFenceFd)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe VkResult vkQueueSignalReleaseImageANDROID(VkQueue queue, uint waitSemaphoreCount, ref VkSemaphore pWaitSemaphores, VkImage image, ref int pNativeFenceFd)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe VkResult vkQueueSignalReleaseImageANDROID(VkQueue queue, uint waitSemaphoreCount, ref VkSemaphore pWaitSemaphores, VkImage image, IntPtr pNativeFenceFd)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe VkResult vkQueueSignalReleaseImageANDROID(VkQueue queue, uint waitSemaphoreCount, IntPtr pWaitSemaphores, VkImage image, int* pNativeFenceFd)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe VkResult vkQueueSignalReleaseImageANDROID(VkQueue queue, uint waitSemaphoreCount, IntPtr pWaitSemaphores, VkImage image, ref int pNativeFenceFd)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe VkResult vkQueueSignalReleaseImageANDROID(VkQueue queue, uint waitSemaphoreCount, IntPtr pWaitSemaphores, VkImage image, IntPtr pNativeFenceFd)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanEXTDebugReport
        {
            private IntPtr vkCreateDebugReportCallbackEXT_ptr;
            private IntPtr vkDebugReportMessageEXT_ptr;
            private IntPtr vkDestroyDebugReportCallbackEXT_ptr;

            public VulkanEXTDebugReport(VkInstance instance)
            {
                vkCreateDebugReportCallbackEXT_ptr = LoadInstanceProcAddr(instance, "vkCreateDebugReportCallbackEXT");
                vkDebugReportMessageEXT_ptr = LoadInstanceProcAddr(instance, "vkDebugReportMessageEXT");
                vkDestroyDebugReportCallbackEXT_ptr = LoadInstanceProcAddr(instance, "vkDestroyDebugReportCallbackEXT");
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDebugReportCallbackEXT(VkInstance instance, VkDebugReportCallbackCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDebugReportCallbackEXT* pCallback)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDebugReportCallbackEXT(VkInstance instance, VkDebugReportCallbackCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkDebugReportCallbackEXT pCallback)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDebugReportCallbackEXT(VkInstance instance, VkDebugReportCallbackCreateInfoEXT* pCreateInfo, ref VkAllocationCallbacks pAllocator, VkDebugReportCallbackEXT* pCallback)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDebugReportCallbackEXT(VkInstance instance, VkDebugReportCallbackCreateInfoEXT* pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkDebugReportCallbackEXT pCallback)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDebugReportCallbackEXT(VkInstance instance, VkDebugReportCallbackCreateInfoEXT* pCreateInfo, IntPtr pAllocator, VkDebugReportCallbackEXT* pCallback)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDebugReportCallbackEXT(VkInstance instance, VkDebugReportCallbackCreateInfoEXT* pCreateInfo, IntPtr pAllocator, out VkDebugReportCallbackEXT pCallback)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDebugReportCallbackEXT(VkInstance instance, ref VkDebugReportCallbackCreateInfoEXT pCreateInfo, VkAllocationCallbacks* pAllocator, VkDebugReportCallbackEXT* pCallback)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDebugReportCallbackEXT(VkInstance instance, ref VkDebugReportCallbackCreateInfoEXT pCreateInfo, VkAllocationCallbacks* pAllocator, out VkDebugReportCallbackEXT pCallback)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDebugReportCallbackEXT(VkInstance instance, ref VkDebugReportCallbackCreateInfoEXT pCreateInfo, ref VkAllocationCallbacks pAllocator, VkDebugReportCallbackEXT* pCallback)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDebugReportCallbackEXT(VkInstance instance, ref VkDebugReportCallbackCreateInfoEXT pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkDebugReportCallbackEXT pCallback)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDebugReportCallbackEXT(VkInstance instance, ref VkDebugReportCallbackCreateInfoEXT pCreateInfo, IntPtr pAllocator, VkDebugReportCallbackEXT* pCallback)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDebugReportCallbackEXT(VkInstance instance, ref VkDebugReportCallbackCreateInfoEXT pCreateInfo, IntPtr pAllocator, out VkDebugReportCallbackEXT pCallback)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDebugReportCallbackEXT(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, VkDebugReportCallbackEXT* pCallback)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDebugReportCallbackEXT(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, out VkDebugReportCallbackEXT pCallback)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDebugReportCallbackEXT(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, VkDebugReportCallbackEXT* pCallback)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDebugReportCallbackEXT(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkDebugReportCallbackEXT pCallback)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDebugReportCallbackEXT(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, VkDebugReportCallbackEXT* pCallback)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDebugReportCallbackEXT(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, out VkDebugReportCallbackEXT pCallback)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkDebugReportMessageEXT(VkInstance instance, VkDebugReportFlagsEXT flags, VkDebugReportObjectTypeEXT objectType, ulong @object, UIntPtr location, int messageCode, byte* pLayerPrefix, byte* pMessage)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkDebugReportMessageEXT(VkInstance instance, VkDebugReportFlagsEXT flags, VkDebugReportObjectTypeEXT objectType, ulong @object, UIntPtr location, int messageCode, byte* pLayerPrefix, string pMessage)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkDebugReportMessageEXT(VkInstance instance, VkDebugReportFlagsEXT flags, VkDebugReportObjectTypeEXT objectType, ulong @object, UIntPtr location, int messageCode, string pLayerPrefix, byte* pMessage)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkDebugReportMessageEXT(VkInstance instance, VkDebugReportFlagsEXT flags, VkDebugReportObjectTypeEXT objectType, ulong @object, UIntPtr location, int messageCode, string pLayerPrefix, string pMessage)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkDestroyDebugReportCallbackEXT(VkInstance instance, VkDebugReportCallbackEXT callback, VkAllocationCallbacks* pAllocator)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkDestroyDebugReportCallbackEXT(VkInstance instance, VkDebugReportCallbackEXT callback, ref VkAllocationCallbacks pAllocator)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkDestroyDebugReportCallbackEXT(VkInstance instance, VkDebugReportCallbackEXT callback, IntPtr pAllocator)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanEXTDebugMarker
        {
            private IntPtr vkCmdDebugMarkerBeginEXT_ptr;
            private IntPtr vkCmdDebugMarkerEndEXT_ptr;
            private IntPtr vkCmdDebugMarkerInsertEXT_ptr;
            private IntPtr vkDebugMarkerSetObjectNameEXT_ptr;
            private IntPtr vkDebugMarkerSetObjectTagEXT_ptr;

            public VulkanEXTDebugMarker(VkDevice device)
            {
                vkCmdDebugMarkerBeginEXT_ptr = LoadDeviceProcAddr(device, "vkCmdDebugMarkerBeginEXT");
                vkCmdDebugMarkerEndEXT_ptr = LoadDeviceProcAddr(device, "vkCmdDebugMarkerEndEXT");
                vkCmdDebugMarkerInsertEXT_ptr = LoadDeviceProcAddr(device, "vkCmdDebugMarkerInsertEXT");
                vkDebugMarkerSetObjectNameEXT_ptr = LoadDeviceProcAddr(device, "vkDebugMarkerSetObjectNameEXT");
                vkDebugMarkerSetObjectTagEXT_ptr = LoadDeviceProcAddr(device, "vkDebugMarkerSetObjectTagEXT");
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdDebugMarkerBeginEXT(VkCommandBuffer commandBuffer, VkDebugMarkerMarkerInfoEXT* pMarkerInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdDebugMarkerBeginEXT(VkCommandBuffer commandBuffer, ref VkDebugMarkerMarkerInfoEXT pMarkerInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdDebugMarkerBeginEXT(VkCommandBuffer commandBuffer, IntPtr pMarkerInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdDebugMarkerEndEXT(VkCommandBuffer commandBuffer)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdDebugMarkerInsertEXT(VkCommandBuffer commandBuffer, VkDebugMarkerMarkerInfoEXT* pMarkerInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdDebugMarkerInsertEXT(VkCommandBuffer commandBuffer, ref VkDebugMarkerMarkerInfoEXT pMarkerInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdDebugMarkerInsertEXT(VkCommandBuffer commandBuffer, IntPtr pMarkerInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkDebugMarkerSetObjectNameEXT(VkDevice device, VkDebugMarkerObjectNameInfoEXT* pNameInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkDebugMarkerSetObjectNameEXT(VkDevice device, ref VkDebugMarkerObjectNameInfoEXT pNameInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkDebugMarkerSetObjectNameEXT(VkDevice device, IntPtr pNameInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkDebugMarkerSetObjectTagEXT(VkDevice device, VkDebugMarkerObjectTagInfoEXT* pTagInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkDebugMarkerSetObjectTagEXT(VkDevice device, ref VkDebugMarkerObjectTagInfoEXT pTagInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkDebugMarkerSetObjectTagEXT(VkDevice device, IntPtr pTagInfo)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanKHRVideoQueue
        {
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

            public VulkanKHRVideoQueue(VkDevice device)
            {
                vkBindVideoSessionMemoryKHR_ptr = LoadDeviceProcAddr(device, "vkBindVideoSessionMemoryKHR");
                vkCmdBeginVideoCodingKHR_ptr = LoadDeviceProcAddr(device, "vkCmdBeginVideoCodingKHR");
                vkCmdControlVideoCodingKHR_ptr = LoadDeviceProcAddr(device, "vkCmdControlVideoCodingKHR");
                vkCmdEndVideoCodingKHR_ptr = LoadDeviceProcAddr(device, "vkCmdEndVideoCodingKHR");
                vkCreateVideoSessionKHR_ptr = LoadDeviceProcAddr(device, "vkCreateVideoSessionKHR");
                vkCreateVideoSessionParametersKHR_ptr = LoadDeviceProcAddr(device, "vkCreateVideoSessionParametersKHR");
                vkDestroyVideoSessionKHR_ptr = LoadDeviceProcAddr(device, "vkDestroyVideoSessionKHR");
                vkDestroyVideoSessionParametersKHR_ptr = LoadDeviceProcAddr(device, "vkDestroyVideoSessionParametersKHR");
                vkGetPhysicalDeviceVideoCapabilitiesKHR_ptr = LoadDeviceProcAddr(device, "vkGetPhysicalDeviceVideoCapabilitiesKHR");
                vkGetPhysicalDeviceVideoFormatPropertiesKHR_ptr = LoadDeviceProcAddr(device, "vkGetPhysicalDeviceVideoFormatPropertiesKHR");
                vkGetVideoSessionMemoryRequirementsKHR_ptr = LoadDeviceProcAddr(device, "vkGetVideoSessionMemoryRequirementsKHR");
                vkUpdateVideoSessionParametersKHR_ptr = LoadDeviceProcAddr(device, "vkUpdateVideoSessionParametersKHR");
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkBindVideoSessionMemoryKHR(VkDevice device, VkVideoSessionKHR videoSession, uint bindSessionMemoryInfoCount, VkBindVideoSessionMemoryInfoKHR* pBindSessionMemoryInfos)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkBindVideoSessionMemoryKHR(VkDevice device, VkVideoSessionKHR videoSession, uint bindSessionMemoryInfoCount, ref VkBindVideoSessionMemoryInfoKHR pBindSessionMemoryInfos)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkBindVideoSessionMemoryKHR(VkDevice device, VkVideoSessionKHR videoSession, uint bindSessionMemoryInfoCount, IntPtr pBindSessionMemoryInfos)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkBindVideoSessionMemoryKHR(VkDevice device, VkVideoSessionKHR videoSession, uint bindSessionMemoryInfoCount, VkBindVideoSessionMemoryInfoKHR[] pBindSessionMemoryInfos)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBeginVideoCodingKHR(VkCommandBuffer commandBuffer, VkVideoBeginCodingInfoKHR* pBeginInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBeginVideoCodingKHR(VkCommandBuffer commandBuffer, ref VkVideoBeginCodingInfoKHR pBeginInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBeginVideoCodingKHR(VkCommandBuffer commandBuffer, IntPtr pBeginInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdControlVideoCodingKHR(VkCommandBuffer commandBuffer, VkVideoCodingControlInfoKHR* pCodingControlInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdControlVideoCodingKHR(VkCommandBuffer commandBuffer, ref VkVideoCodingControlInfoKHR pCodingControlInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdControlVideoCodingKHR(VkCommandBuffer commandBuffer, IntPtr pCodingControlInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdEndVideoCodingKHR(VkCommandBuffer commandBuffer, VkVideoEndCodingInfoKHR* pEndCodingInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdEndVideoCodingKHR(VkCommandBuffer commandBuffer, ref VkVideoEndCodingInfoKHR pEndCodingInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdEndVideoCodingKHR(VkCommandBuffer commandBuffer, IntPtr pEndCodingInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_VIDEO_STD_VERSION_NOT_SUPPORTED_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateVideoSessionKHR(VkDevice device, VkVideoSessionCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkVideoSessionKHR* pVideoSession)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_VIDEO_STD_VERSION_NOT_SUPPORTED_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateVideoSessionKHR(VkDevice device, VkVideoSessionCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkVideoSessionKHR pVideoSession)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_VIDEO_STD_VERSION_NOT_SUPPORTED_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateVideoSessionKHR(VkDevice device, VkVideoSessionCreateInfoKHR* pCreateInfo, ref VkAllocationCallbacks pAllocator, VkVideoSessionKHR* pVideoSession)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_VIDEO_STD_VERSION_NOT_SUPPORTED_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateVideoSessionKHR(VkDevice device, VkVideoSessionCreateInfoKHR* pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkVideoSessionKHR pVideoSession)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_VIDEO_STD_VERSION_NOT_SUPPORTED_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateVideoSessionKHR(VkDevice device, VkVideoSessionCreateInfoKHR* pCreateInfo, IntPtr pAllocator, VkVideoSessionKHR* pVideoSession)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_VIDEO_STD_VERSION_NOT_SUPPORTED_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateVideoSessionKHR(VkDevice device, VkVideoSessionCreateInfoKHR* pCreateInfo, IntPtr pAllocator, out VkVideoSessionKHR pVideoSession)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_VIDEO_STD_VERSION_NOT_SUPPORTED_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateVideoSessionKHR(VkDevice device, ref VkVideoSessionCreateInfoKHR pCreateInfo, VkAllocationCallbacks* pAllocator, VkVideoSessionKHR* pVideoSession)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_VIDEO_STD_VERSION_NOT_SUPPORTED_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateVideoSessionKHR(VkDevice device, ref VkVideoSessionCreateInfoKHR pCreateInfo, VkAllocationCallbacks* pAllocator, out VkVideoSessionKHR pVideoSession)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_VIDEO_STD_VERSION_NOT_SUPPORTED_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateVideoSessionKHR(VkDevice device, ref VkVideoSessionCreateInfoKHR pCreateInfo, ref VkAllocationCallbacks pAllocator, VkVideoSessionKHR* pVideoSession)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_VIDEO_STD_VERSION_NOT_SUPPORTED_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateVideoSessionKHR(VkDevice device, ref VkVideoSessionCreateInfoKHR pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkVideoSessionKHR pVideoSession)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_VIDEO_STD_VERSION_NOT_SUPPORTED_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateVideoSessionKHR(VkDevice device, ref VkVideoSessionCreateInfoKHR pCreateInfo, IntPtr pAllocator, VkVideoSessionKHR* pVideoSession)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_VIDEO_STD_VERSION_NOT_SUPPORTED_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateVideoSessionKHR(VkDevice device, ref VkVideoSessionCreateInfoKHR pCreateInfo, IntPtr pAllocator, out VkVideoSessionKHR pVideoSession)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_VIDEO_STD_VERSION_NOT_SUPPORTED_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateVideoSessionKHR(VkDevice device, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, VkVideoSessionKHR* pVideoSession)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_VIDEO_STD_VERSION_NOT_SUPPORTED_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateVideoSessionKHR(VkDevice device, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, out VkVideoSessionKHR pVideoSession)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_VIDEO_STD_VERSION_NOT_SUPPORTED_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateVideoSessionKHR(VkDevice device, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, VkVideoSessionKHR* pVideoSession)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_VIDEO_STD_VERSION_NOT_SUPPORTED_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateVideoSessionKHR(VkDevice device, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkVideoSessionKHR pVideoSession)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_VIDEO_STD_VERSION_NOT_SUPPORTED_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateVideoSessionKHR(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, VkVideoSessionKHR* pVideoSession)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_VIDEO_STD_VERSION_NOT_SUPPORTED_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateVideoSessionKHR(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, out VkVideoSessionKHR pVideoSession)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateVideoSessionParametersKHR(VkDevice device, VkVideoSessionParametersCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkVideoSessionParametersKHR* pVideoSessionParameters)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateVideoSessionParametersKHR(VkDevice device, VkVideoSessionParametersCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkVideoSessionParametersKHR pVideoSessionParameters)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateVideoSessionParametersKHR(VkDevice device, VkVideoSessionParametersCreateInfoKHR* pCreateInfo, ref VkAllocationCallbacks pAllocator, VkVideoSessionParametersKHR* pVideoSessionParameters)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateVideoSessionParametersKHR(VkDevice device, VkVideoSessionParametersCreateInfoKHR* pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkVideoSessionParametersKHR pVideoSessionParameters)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateVideoSessionParametersKHR(VkDevice device, VkVideoSessionParametersCreateInfoKHR* pCreateInfo, IntPtr pAllocator, VkVideoSessionParametersKHR* pVideoSessionParameters)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateVideoSessionParametersKHR(VkDevice device, VkVideoSessionParametersCreateInfoKHR* pCreateInfo, IntPtr pAllocator, out VkVideoSessionParametersKHR pVideoSessionParameters)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateVideoSessionParametersKHR(VkDevice device, ref VkVideoSessionParametersCreateInfoKHR pCreateInfo, VkAllocationCallbacks* pAllocator, VkVideoSessionParametersKHR* pVideoSessionParameters)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateVideoSessionParametersKHR(VkDevice device, ref VkVideoSessionParametersCreateInfoKHR pCreateInfo, VkAllocationCallbacks* pAllocator, out VkVideoSessionParametersKHR pVideoSessionParameters)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateVideoSessionParametersKHR(VkDevice device, ref VkVideoSessionParametersCreateInfoKHR pCreateInfo, ref VkAllocationCallbacks pAllocator, VkVideoSessionParametersKHR* pVideoSessionParameters)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateVideoSessionParametersKHR(VkDevice device, ref VkVideoSessionParametersCreateInfoKHR pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkVideoSessionParametersKHR pVideoSessionParameters)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateVideoSessionParametersKHR(VkDevice device, ref VkVideoSessionParametersCreateInfoKHR pCreateInfo, IntPtr pAllocator, VkVideoSessionParametersKHR* pVideoSessionParameters)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateVideoSessionParametersKHR(VkDevice device, ref VkVideoSessionParametersCreateInfoKHR pCreateInfo, IntPtr pAllocator, out VkVideoSessionParametersKHR pVideoSessionParameters)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateVideoSessionParametersKHR(VkDevice device, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, VkVideoSessionParametersKHR* pVideoSessionParameters)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateVideoSessionParametersKHR(VkDevice device, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, out VkVideoSessionParametersKHR pVideoSessionParameters)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateVideoSessionParametersKHR(VkDevice device, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, VkVideoSessionParametersKHR* pVideoSessionParameters)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateVideoSessionParametersKHR(VkDevice device, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkVideoSessionParametersKHR pVideoSessionParameters)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateVideoSessionParametersKHR(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, VkVideoSessionParametersKHR* pVideoSessionParameters)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateVideoSessionParametersKHR(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, out VkVideoSessionParametersKHR pVideoSessionParameters)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkDestroyVideoSessionKHR(VkDevice device, VkVideoSessionKHR videoSession, VkAllocationCallbacks* pAllocator)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkDestroyVideoSessionKHR(VkDevice device, VkVideoSessionKHR videoSession, ref VkAllocationCallbacks pAllocator)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkDestroyVideoSessionKHR(VkDevice device, VkVideoSessionKHR videoSession, IntPtr pAllocator)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkDestroyVideoSessionParametersKHR(VkDevice device, VkVideoSessionParametersKHR videoSessionParameters, VkAllocationCallbacks* pAllocator)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkDestroyVideoSessionParametersKHR(VkDevice device, VkVideoSessionParametersKHR videoSessionParameters, ref VkAllocationCallbacks pAllocator)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkDestroyVideoSessionParametersKHR(VkDevice device, VkVideoSessionParametersKHR videoSessionParameters, IntPtr pAllocator)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_VIDEO_PROFILE_OPERATION_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_FORMAT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PICTURE_LAYOUT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_CODEC_NOT_SUPPORTED_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceVideoCapabilitiesKHR(VkPhysicalDevice physicalDevice, VkVideoProfileInfoKHR* pVideoProfile, VkVideoCapabilitiesKHR* pCapabilities)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_VIDEO_PROFILE_OPERATION_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_FORMAT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PICTURE_LAYOUT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_CODEC_NOT_SUPPORTED_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceVideoCapabilitiesKHR(VkPhysicalDevice physicalDevice, VkVideoProfileInfoKHR* pVideoProfile, out VkVideoCapabilitiesKHR pCapabilities)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_VIDEO_PROFILE_OPERATION_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_FORMAT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PICTURE_LAYOUT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_CODEC_NOT_SUPPORTED_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceVideoCapabilitiesKHR(VkPhysicalDevice physicalDevice, ref VkVideoProfileInfoKHR pVideoProfile, VkVideoCapabilitiesKHR* pCapabilities)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_VIDEO_PROFILE_OPERATION_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_FORMAT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PICTURE_LAYOUT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_CODEC_NOT_SUPPORTED_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceVideoCapabilitiesKHR(VkPhysicalDevice physicalDevice, ref VkVideoProfileInfoKHR pVideoProfile, out VkVideoCapabilitiesKHR pCapabilities)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_VIDEO_PROFILE_OPERATION_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_FORMAT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PICTURE_LAYOUT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_CODEC_NOT_SUPPORTED_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceVideoCapabilitiesKHR(VkPhysicalDevice physicalDevice, IntPtr pVideoProfile, VkVideoCapabilitiesKHR* pCapabilities)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_VIDEO_PROFILE_OPERATION_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_FORMAT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PICTURE_LAYOUT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_CODEC_NOT_SUPPORTED_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceVideoCapabilitiesKHR(VkPhysicalDevice physicalDevice, IntPtr pVideoProfile, out VkVideoCapabilitiesKHR pCapabilities)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_IMAGE_USAGE_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_OPERATION_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_FORMAT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PICTURE_LAYOUT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_CODEC_NOT_SUPPORTED_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceVideoFormatPropertiesKHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceVideoFormatInfoKHR* pVideoFormatInfo, uint* pVideoFormatPropertyCount, VkVideoFormatPropertiesKHR* pVideoFormatProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_IMAGE_USAGE_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_OPERATION_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_FORMAT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PICTURE_LAYOUT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_CODEC_NOT_SUPPORTED_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceVideoFormatPropertiesKHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceVideoFormatInfoKHR* pVideoFormatInfo, uint* pVideoFormatPropertyCount, out VkVideoFormatPropertiesKHR pVideoFormatProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_IMAGE_USAGE_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_OPERATION_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_FORMAT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PICTURE_LAYOUT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_CODEC_NOT_SUPPORTED_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceVideoFormatPropertiesKHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceVideoFormatInfoKHR* pVideoFormatInfo, ref uint pVideoFormatPropertyCount, VkVideoFormatPropertiesKHR* pVideoFormatProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_IMAGE_USAGE_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_OPERATION_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_FORMAT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PICTURE_LAYOUT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_CODEC_NOT_SUPPORTED_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceVideoFormatPropertiesKHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceVideoFormatInfoKHR* pVideoFormatInfo, ref uint pVideoFormatPropertyCount, out VkVideoFormatPropertiesKHR pVideoFormatProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_IMAGE_USAGE_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_OPERATION_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_FORMAT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PICTURE_LAYOUT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_CODEC_NOT_SUPPORTED_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceVideoFormatPropertiesKHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceVideoFormatInfoKHR* pVideoFormatInfo, IntPtr pVideoFormatPropertyCount, VkVideoFormatPropertiesKHR* pVideoFormatProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_IMAGE_USAGE_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_OPERATION_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_FORMAT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PICTURE_LAYOUT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_CODEC_NOT_SUPPORTED_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceVideoFormatPropertiesKHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceVideoFormatInfoKHR* pVideoFormatInfo, IntPtr pVideoFormatPropertyCount, out VkVideoFormatPropertiesKHR pVideoFormatProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_IMAGE_USAGE_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_OPERATION_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_FORMAT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PICTURE_LAYOUT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_CODEC_NOT_SUPPORTED_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceVideoFormatPropertiesKHR(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceVideoFormatInfoKHR pVideoFormatInfo, uint* pVideoFormatPropertyCount, VkVideoFormatPropertiesKHR* pVideoFormatProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_IMAGE_USAGE_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_OPERATION_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_FORMAT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PICTURE_LAYOUT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_CODEC_NOT_SUPPORTED_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceVideoFormatPropertiesKHR(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceVideoFormatInfoKHR pVideoFormatInfo, uint* pVideoFormatPropertyCount, out VkVideoFormatPropertiesKHR pVideoFormatProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_IMAGE_USAGE_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_OPERATION_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_FORMAT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PICTURE_LAYOUT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_CODEC_NOT_SUPPORTED_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceVideoFormatPropertiesKHR(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceVideoFormatInfoKHR pVideoFormatInfo, ref uint pVideoFormatPropertyCount, VkVideoFormatPropertiesKHR* pVideoFormatProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_IMAGE_USAGE_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_OPERATION_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_FORMAT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PICTURE_LAYOUT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_CODEC_NOT_SUPPORTED_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceVideoFormatPropertiesKHR(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceVideoFormatInfoKHR pVideoFormatInfo, ref uint pVideoFormatPropertyCount, out VkVideoFormatPropertiesKHR pVideoFormatProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_IMAGE_USAGE_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_OPERATION_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_FORMAT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PICTURE_LAYOUT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_CODEC_NOT_SUPPORTED_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceVideoFormatPropertiesKHR(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceVideoFormatInfoKHR pVideoFormatInfo, IntPtr pVideoFormatPropertyCount, VkVideoFormatPropertiesKHR* pVideoFormatProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_IMAGE_USAGE_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_OPERATION_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_FORMAT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PICTURE_LAYOUT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_CODEC_NOT_SUPPORTED_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceVideoFormatPropertiesKHR(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceVideoFormatInfoKHR pVideoFormatInfo, IntPtr pVideoFormatPropertyCount, out VkVideoFormatPropertiesKHR pVideoFormatProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_IMAGE_USAGE_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_OPERATION_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_FORMAT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PICTURE_LAYOUT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_CODEC_NOT_SUPPORTED_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceVideoFormatPropertiesKHR(VkPhysicalDevice physicalDevice, IntPtr pVideoFormatInfo, uint* pVideoFormatPropertyCount, VkVideoFormatPropertiesKHR* pVideoFormatProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_IMAGE_USAGE_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_OPERATION_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_FORMAT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PICTURE_LAYOUT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_CODEC_NOT_SUPPORTED_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceVideoFormatPropertiesKHR(VkPhysicalDevice physicalDevice, IntPtr pVideoFormatInfo, uint* pVideoFormatPropertyCount, out VkVideoFormatPropertiesKHR pVideoFormatProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_IMAGE_USAGE_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_OPERATION_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_FORMAT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PICTURE_LAYOUT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_CODEC_NOT_SUPPORTED_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceVideoFormatPropertiesKHR(VkPhysicalDevice physicalDevice, IntPtr pVideoFormatInfo, ref uint pVideoFormatPropertyCount, VkVideoFormatPropertiesKHR* pVideoFormatProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_IMAGE_USAGE_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_OPERATION_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_FORMAT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PICTURE_LAYOUT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_CODEC_NOT_SUPPORTED_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceVideoFormatPropertiesKHR(VkPhysicalDevice physicalDevice, IntPtr pVideoFormatInfo, ref uint pVideoFormatPropertyCount, out VkVideoFormatPropertiesKHR pVideoFormatProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_IMAGE_USAGE_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_OPERATION_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_FORMAT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PICTURE_LAYOUT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_CODEC_NOT_SUPPORTED_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceVideoFormatPropertiesKHR(VkPhysicalDevice physicalDevice, IntPtr pVideoFormatInfo, IntPtr pVideoFormatPropertyCount, VkVideoFormatPropertiesKHR* pVideoFormatProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_IMAGE_USAGE_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_OPERATION_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_FORMAT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PICTURE_LAYOUT_NOT_SUPPORTED_KHR, VK_ERROR_VIDEO_PROFILE_CODEC_NOT_SUPPORTED_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceVideoFormatPropertiesKHR(VkPhysicalDevice physicalDevice, IntPtr pVideoFormatInfo, IntPtr pVideoFormatPropertyCount, out VkVideoFormatPropertiesKHR pVideoFormatProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetVideoSessionMemoryRequirementsKHR(VkDevice device, VkVideoSessionKHR videoSession, uint* pMemoryRequirementsCount, VkVideoSessionMemoryRequirementsKHR* pMemoryRequirements)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetVideoSessionMemoryRequirementsKHR(VkDevice device, VkVideoSessionKHR videoSession, uint* pMemoryRequirementsCount, out VkVideoSessionMemoryRequirementsKHR pMemoryRequirements)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetVideoSessionMemoryRequirementsKHR(VkDevice device, VkVideoSessionKHR videoSession, ref uint pMemoryRequirementsCount, VkVideoSessionMemoryRequirementsKHR* pMemoryRequirements)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetVideoSessionMemoryRequirementsKHR(VkDevice device, VkVideoSessionKHR videoSession, ref uint pMemoryRequirementsCount, out VkVideoSessionMemoryRequirementsKHR pMemoryRequirements)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetVideoSessionMemoryRequirementsKHR(VkDevice device, VkVideoSessionKHR videoSession, IntPtr pMemoryRequirementsCount, VkVideoSessionMemoryRequirementsKHR* pMemoryRequirements)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetVideoSessionMemoryRequirementsKHR(VkDevice device, VkVideoSessionKHR videoSession, IntPtr pMemoryRequirementsCount, out VkVideoSessionMemoryRequirementsKHR pMemoryRequirements)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkUpdateVideoSessionParametersKHR(VkDevice device, VkVideoSessionParametersKHR videoSessionParameters, VkVideoSessionParametersUpdateInfoKHR* pUpdateInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkUpdateVideoSessionParametersKHR(VkDevice device, VkVideoSessionParametersKHR videoSessionParameters, ref VkVideoSessionParametersUpdateInfoKHR pUpdateInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkUpdateVideoSessionParametersKHR(VkDevice device, VkVideoSessionParametersKHR videoSessionParameters, IntPtr pUpdateInfo)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanKHRVideoDecodeQueue
        {
            private IntPtr vkCmdDecodeVideoKHR_ptr;

            public VulkanKHRVideoDecodeQueue(VkDevice device)
            {
                vkCmdDecodeVideoKHR_ptr = LoadDeviceProcAddr(device, "vkCmdDecodeVideoKHR");
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdDecodeVideoKHR(VkCommandBuffer commandBuffer, VkVideoDecodeInfoKHR* pDecodeInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdDecodeVideoKHR(VkCommandBuffer commandBuffer, ref VkVideoDecodeInfoKHR pDecodeInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdDecodeVideoKHR(VkCommandBuffer commandBuffer, IntPtr pDecodeInfo)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanEXTTransformFeedback
        {
            private IntPtr vkCmdBeginQueryIndexedEXT_ptr;
            private IntPtr vkCmdBeginTransformFeedbackEXT_ptr;
            private IntPtr vkCmdBindTransformFeedbackBuffersEXT_ptr;
            private IntPtr vkCmdDrawIndirectByteCountEXT_ptr;
            private IntPtr vkCmdEndQueryIndexedEXT_ptr;
            private IntPtr vkCmdEndTransformFeedbackEXT_ptr;

            public VulkanEXTTransformFeedback(VkDevice device)
            {
                vkCmdBeginQueryIndexedEXT_ptr = LoadDeviceProcAddr(device, "vkCmdBeginQueryIndexedEXT");
                vkCmdBeginTransformFeedbackEXT_ptr = LoadDeviceProcAddr(device, "vkCmdBeginTransformFeedbackEXT");
                vkCmdBindTransformFeedbackBuffersEXT_ptr = LoadDeviceProcAddr(device, "vkCmdBindTransformFeedbackBuffersEXT");
                vkCmdDrawIndirectByteCountEXT_ptr = LoadDeviceProcAddr(device, "vkCmdDrawIndirectByteCountEXT");
                vkCmdEndQueryIndexedEXT_ptr = LoadDeviceProcAddr(device, "vkCmdEndQueryIndexedEXT");
                vkCmdEndTransformFeedbackEXT_ptr = LoadDeviceProcAddr(device, "vkCmdEndTransformFeedbackEXT");
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBeginQueryIndexedEXT(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, VkQueryControlFlags flags, uint index)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBeginTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, VkBuffer* pCounterBuffers, ulong* pCounterBufferOffsets)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBeginTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, VkBuffer* pCounterBuffers, ref ulong pCounterBufferOffsets)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBeginTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, VkBuffer* pCounterBuffers, IntPtr pCounterBufferOffsets)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBeginTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, ref VkBuffer pCounterBuffers, ulong* pCounterBufferOffsets)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBeginTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, ref VkBuffer pCounterBuffers, ref ulong pCounterBufferOffsets)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBeginTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, ref VkBuffer pCounterBuffers, IntPtr pCounterBufferOffsets)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBeginTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, IntPtr pCounterBuffers, ulong* pCounterBufferOffsets)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBeginTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, IntPtr pCounterBuffers, ref ulong pCounterBufferOffsets)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBeginTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, IntPtr pCounterBuffers, IntPtr pCounterBufferOffsets)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* pBuffers, ulong* pOffsets, ulong* pSizes)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* pBuffers, ulong* pOffsets, ref ulong pSizes)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* pBuffers, ulong* pOffsets, IntPtr pSizes)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* pBuffers, ref ulong pOffsets, ulong* pSizes)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* pBuffers, ref ulong pOffsets, ref ulong pSizes)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* pBuffers, ref ulong pOffsets, IntPtr pSizes)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* pBuffers, IntPtr pOffsets, ulong* pSizes)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* pBuffers, IntPtr pOffsets, ref ulong pSizes)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* pBuffers, IntPtr pOffsets, IntPtr pSizes)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer pBuffers, ulong* pOffsets, ulong* pSizes)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer pBuffers, ulong* pOffsets, ref ulong pSizes)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer pBuffers, ulong* pOffsets, IntPtr pSizes)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer pBuffers, ref ulong pOffsets, ulong* pSizes)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer pBuffers, ref ulong pOffsets, ref ulong pSizes)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer pBuffers, ref ulong pOffsets, IntPtr pSizes)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer pBuffers, IntPtr pOffsets, ulong* pSizes)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer pBuffers, IntPtr pOffsets, ref ulong pSizes)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, ref VkBuffer pBuffers, IntPtr pOffsets, IntPtr pSizes)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, IntPtr pBuffers, ulong* pOffsets, ulong* pSizes)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, IntPtr pBuffers, ulong* pOffsets, ref ulong pSizes)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, IntPtr pBuffers, ulong* pOffsets, IntPtr pSizes)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, IntPtr pBuffers, ref ulong pOffsets, ulong* pSizes)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, IntPtr pBuffers, ref ulong pOffsets, ref ulong pSizes)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, IntPtr pBuffers, ref ulong pOffsets, IntPtr pSizes)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, IntPtr pBuffers, IntPtr pOffsets, ulong* pSizes)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, IntPtr pBuffers, IntPtr pOffsets, ref ulong pSizes)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, IntPtr pBuffers, IntPtr pOffsets, IntPtr pSizes)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdDrawIndirectByteCountEXT(VkCommandBuffer commandBuffer, uint instanceCount, uint firstInstance, VkBuffer counterBuffer, ulong counterBufferOffset, uint counterOffset, uint vertexStride)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdEndQueryIndexedEXT(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, uint index)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdEndTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, VkBuffer* pCounterBuffers, ulong* pCounterBufferOffsets)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdEndTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, VkBuffer* pCounterBuffers, ref ulong pCounterBufferOffsets)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdEndTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, VkBuffer* pCounterBuffers, IntPtr pCounterBufferOffsets)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdEndTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, ref VkBuffer pCounterBuffers, ulong* pCounterBufferOffsets)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdEndTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, ref VkBuffer pCounterBuffers, ref ulong pCounterBufferOffsets)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdEndTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, ref VkBuffer pCounterBuffers, IntPtr pCounterBufferOffsets)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdEndTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, IntPtr pCounterBuffers, ulong* pCounterBufferOffsets)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdEndTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, IntPtr pCounterBuffers, ref ulong pCounterBufferOffsets)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdEndTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, IntPtr pCounterBuffers, IntPtr pCounterBufferOffsets)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanNVXBinaryImport
        {
            private IntPtr vkCmdCuLaunchKernelNVX_ptr;
            private IntPtr vkCreateCuFunctionNVX_ptr;
            private IntPtr vkCreateCuModuleNVX_ptr;
            private IntPtr vkDestroyCuFunctionNVX_ptr;
            private IntPtr vkDestroyCuModuleNVX_ptr;

            public VulkanNVXBinaryImport(VkDevice device)
            {
                vkCmdCuLaunchKernelNVX_ptr = LoadDeviceProcAddr(device, "vkCmdCuLaunchKernelNVX");
                vkCreateCuFunctionNVX_ptr = LoadDeviceProcAddr(device, "vkCreateCuFunctionNVX");
                vkCreateCuModuleNVX_ptr = LoadDeviceProcAddr(device, "vkCreateCuModuleNVX");
                vkDestroyCuFunctionNVX_ptr = LoadDeviceProcAddr(device, "vkDestroyCuFunctionNVX");
                vkDestroyCuModuleNVX_ptr = LoadDeviceProcAddr(device, "vkDestroyCuModuleNVX");
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdCuLaunchKernelNVX(VkCommandBuffer commandBuffer, VkCuLaunchInfoNVX* pLaunchInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdCuLaunchKernelNVX(VkCommandBuffer commandBuffer, ref VkCuLaunchInfoNVX pLaunchInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdCuLaunchKernelNVX(VkCommandBuffer commandBuffer, IntPtr pLaunchInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateCuFunctionNVX(VkDevice device, VkCuFunctionCreateInfoNVX* pCreateInfo, VkAllocationCallbacks* pAllocator, VkCuFunctionNVX* pFunction)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateCuFunctionNVX(VkDevice device, VkCuFunctionCreateInfoNVX* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkCuFunctionNVX pFunction)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateCuFunctionNVX(VkDevice device, VkCuFunctionCreateInfoNVX* pCreateInfo, ref VkAllocationCallbacks pAllocator, VkCuFunctionNVX* pFunction)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateCuFunctionNVX(VkDevice device, VkCuFunctionCreateInfoNVX* pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkCuFunctionNVX pFunction)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateCuFunctionNVX(VkDevice device, VkCuFunctionCreateInfoNVX* pCreateInfo, IntPtr pAllocator, VkCuFunctionNVX* pFunction)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateCuFunctionNVX(VkDevice device, VkCuFunctionCreateInfoNVX* pCreateInfo, IntPtr pAllocator, out VkCuFunctionNVX pFunction)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateCuFunctionNVX(VkDevice device, ref VkCuFunctionCreateInfoNVX pCreateInfo, VkAllocationCallbacks* pAllocator, VkCuFunctionNVX* pFunction)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateCuFunctionNVX(VkDevice device, ref VkCuFunctionCreateInfoNVX pCreateInfo, VkAllocationCallbacks* pAllocator, out VkCuFunctionNVX pFunction)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateCuFunctionNVX(VkDevice device, ref VkCuFunctionCreateInfoNVX pCreateInfo, ref VkAllocationCallbacks pAllocator, VkCuFunctionNVX* pFunction)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateCuFunctionNVX(VkDevice device, ref VkCuFunctionCreateInfoNVX pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkCuFunctionNVX pFunction)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateCuFunctionNVX(VkDevice device, ref VkCuFunctionCreateInfoNVX pCreateInfo, IntPtr pAllocator, VkCuFunctionNVX* pFunction)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateCuFunctionNVX(VkDevice device, ref VkCuFunctionCreateInfoNVX pCreateInfo, IntPtr pAllocator, out VkCuFunctionNVX pFunction)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateCuFunctionNVX(VkDevice device, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, VkCuFunctionNVX* pFunction)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateCuFunctionNVX(VkDevice device, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, out VkCuFunctionNVX pFunction)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateCuFunctionNVX(VkDevice device, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, VkCuFunctionNVX* pFunction)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateCuFunctionNVX(VkDevice device, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkCuFunctionNVX pFunction)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateCuFunctionNVX(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, VkCuFunctionNVX* pFunction)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateCuFunctionNVX(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, out VkCuFunctionNVX pFunction)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateCuModuleNVX(VkDevice device, VkCuModuleCreateInfoNVX* pCreateInfo, VkAllocationCallbacks* pAllocator, VkCuModuleNVX* pModule)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateCuModuleNVX(VkDevice device, VkCuModuleCreateInfoNVX* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkCuModuleNVX pModule)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateCuModuleNVX(VkDevice device, VkCuModuleCreateInfoNVX* pCreateInfo, ref VkAllocationCallbacks pAllocator, VkCuModuleNVX* pModule)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateCuModuleNVX(VkDevice device, VkCuModuleCreateInfoNVX* pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkCuModuleNVX pModule)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateCuModuleNVX(VkDevice device, VkCuModuleCreateInfoNVX* pCreateInfo, IntPtr pAllocator, VkCuModuleNVX* pModule)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateCuModuleNVX(VkDevice device, VkCuModuleCreateInfoNVX* pCreateInfo, IntPtr pAllocator, out VkCuModuleNVX pModule)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateCuModuleNVX(VkDevice device, ref VkCuModuleCreateInfoNVX pCreateInfo, VkAllocationCallbacks* pAllocator, VkCuModuleNVX* pModule)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateCuModuleNVX(VkDevice device, ref VkCuModuleCreateInfoNVX pCreateInfo, VkAllocationCallbacks* pAllocator, out VkCuModuleNVX pModule)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateCuModuleNVX(VkDevice device, ref VkCuModuleCreateInfoNVX pCreateInfo, ref VkAllocationCallbacks pAllocator, VkCuModuleNVX* pModule)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateCuModuleNVX(VkDevice device, ref VkCuModuleCreateInfoNVX pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkCuModuleNVX pModule)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateCuModuleNVX(VkDevice device, ref VkCuModuleCreateInfoNVX pCreateInfo, IntPtr pAllocator, VkCuModuleNVX* pModule)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateCuModuleNVX(VkDevice device, ref VkCuModuleCreateInfoNVX pCreateInfo, IntPtr pAllocator, out VkCuModuleNVX pModule)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateCuModuleNVX(VkDevice device, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, VkCuModuleNVX* pModule)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateCuModuleNVX(VkDevice device, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, out VkCuModuleNVX pModule)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateCuModuleNVX(VkDevice device, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, VkCuModuleNVX* pModule)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateCuModuleNVX(VkDevice device, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkCuModuleNVX pModule)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateCuModuleNVX(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, VkCuModuleNVX* pModule)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateCuModuleNVX(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, out VkCuModuleNVX pModule)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkDestroyCuFunctionNVX(VkDevice device, VkCuFunctionNVX function, VkAllocationCallbacks* pAllocator)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkDestroyCuFunctionNVX(VkDevice device, VkCuFunctionNVX function, ref VkAllocationCallbacks pAllocator)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkDestroyCuFunctionNVX(VkDevice device, VkCuFunctionNVX function, IntPtr pAllocator)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkDestroyCuModuleNVX(VkDevice device, VkCuModuleNVX module, VkAllocationCallbacks* pAllocator)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkDestroyCuModuleNVX(VkDevice device, VkCuModuleNVX module, ref VkAllocationCallbacks pAllocator)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkDestroyCuModuleNVX(VkDevice device, VkCuModuleNVX module, IntPtr pAllocator)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanNVXImageViewHandle
        {
            private IntPtr vkGetImageViewAddressNVX_ptr;
            private IntPtr vkGetImageViewHandleNVX_ptr;

            public VulkanNVXImageViewHandle(VkDevice device)
            {
                vkGetImageViewAddressNVX_ptr = LoadDeviceProcAddr(device, "vkGetImageViewAddressNVX");
                vkGetImageViewHandleNVX_ptr = LoadDeviceProcAddr(device, "vkGetImageViewHandleNVX");
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_UNKNOWN</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetImageViewAddressNVX(VkDevice device, VkImageView imageView, VkImageViewAddressPropertiesNVX* pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_UNKNOWN</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetImageViewAddressNVX(VkDevice device, VkImageView imageView, out VkImageViewAddressPropertiesNVX pProperties)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe uint vkGetImageViewHandleNVX(VkDevice device, VkImageViewHandleInfoNVX* pInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe uint vkGetImageViewHandleNVX(VkDevice device, out VkImageViewHandleInfoNVX pInfo)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanAMDDrawIndirectCount
        {

            public VulkanAMDDrawIndirectCount(VkDevice device)
            {
            }

        }

        public unsafe sealed class VulkanAMDShaderInfo
        {
            private IntPtr vkGetShaderInfoAMD_ptr;

            public VulkanAMDShaderInfo(VkDevice device)
            {
                vkGetShaderInfoAMD_ptr = LoadDeviceProcAddr(device, "vkGetShaderInfoAMD");
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_FEATURE_NOT_PRESENT, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetShaderInfoAMD(VkDevice device, VkPipeline pipeline, VkShaderStageFlags shaderStage, VkShaderInfoTypeAMD infoType, UIntPtr* pInfoSize, void* pInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_FEATURE_NOT_PRESENT, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetShaderInfoAMD(VkDevice device, VkPipeline pipeline, VkShaderStageFlags shaderStage, VkShaderInfoTypeAMD infoType, ref UIntPtr pInfoSize, void* pInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_FEATURE_NOT_PRESENT, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetShaderInfoAMD(VkDevice device, VkPipeline pipeline, VkShaderStageFlags shaderStage, VkShaderInfoTypeAMD infoType, IntPtr pInfoSize, void* pInfo)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanKHRDynamicRendering
        {

            public VulkanKHRDynamicRendering(VkDevice device)
            {
            }

        }

        public unsafe sealed class VulkanGgpStreamDescriptorSurface
        {
            private IntPtr vkCreateStreamDescriptorSurfaceGGP_ptr;

            public VulkanGgpStreamDescriptorSurface(VkInstance instance)
            {
                vkCreateStreamDescriptorSurfaceGGP_ptr = LoadInstanceProcAddr(instance, "vkCreateStreamDescriptorSurfaceGGP");
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateStreamDescriptorSurfaceGGP(VkInstance instance, VkStreamDescriptorSurfaceCreateInfoGGP* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateStreamDescriptorSurfaceGGP(VkInstance instance, VkStreamDescriptorSurfaceCreateInfoGGP* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateStreamDescriptorSurfaceGGP(VkInstance instance, VkStreamDescriptorSurfaceCreateInfoGGP* pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateStreamDescriptorSurfaceGGP(VkInstance instance, VkStreamDescriptorSurfaceCreateInfoGGP* pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateStreamDescriptorSurfaceGGP(VkInstance instance, VkStreamDescriptorSurfaceCreateInfoGGP* pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateStreamDescriptorSurfaceGGP(VkInstance instance, VkStreamDescriptorSurfaceCreateInfoGGP* pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateStreamDescriptorSurfaceGGP(VkInstance instance, ref VkStreamDescriptorSurfaceCreateInfoGGP pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateStreamDescriptorSurfaceGGP(VkInstance instance, ref VkStreamDescriptorSurfaceCreateInfoGGP pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateStreamDescriptorSurfaceGGP(VkInstance instance, ref VkStreamDescriptorSurfaceCreateInfoGGP pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateStreamDescriptorSurfaceGGP(VkInstance instance, ref VkStreamDescriptorSurfaceCreateInfoGGP pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateStreamDescriptorSurfaceGGP(VkInstance instance, ref VkStreamDescriptorSurfaceCreateInfoGGP pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateStreamDescriptorSurfaceGGP(VkInstance instance, ref VkStreamDescriptorSurfaceCreateInfoGGP pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateStreamDescriptorSurfaceGGP(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateStreamDescriptorSurfaceGGP(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateStreamDescriptorSurfaceGGP(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateStreamDescriptorSurfaceGGP(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateStreamDescriptorSurfaceGGP(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateStreamDescriptorSurfaceGGP(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanNVExternalMemoryCapabilities
        {
            private IntPtr vkGetPhysicalDeviceExternalImageFormatPropertiesNV_ptr;

            public VulkanNVExternalMemoryCapabilities(VkInstance instance)
            {
                vkGetPhysicalDeviceExternalImageFormatPropertiesNV_ptr = LoadInstanceProcAddr(instance, "vkGetPhysicalDeviceExternalImageFormatPropertiesNV");
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_FORMAT_NOT_SUPPORTED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceExternalImageFormatPropertiesNV(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlags usage, VkImageCreateFlags flags, VkExternalMemoryHandleTypeFlagsNV externalHandleType, VkExternalImageFormatPropertiesNV* pExternalImageFormatProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_FORMAT_NOT_SUPPORTED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceExternalImageFormatPropertiesNV(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlags usage, VkImageCreateFlags flags, VkExternalMemoryHandleTypeFlagsNV externalHandleType, out VkExternalImageFormatPropertiesNV pExternalImageFormatProperties)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanNVExternalMemoryWin32
        {
            private IntPtr vkGetMemoryWin32HandleNV_ptr;

            public VulkanNVExternalMemoryWin32(VkDevice device)
            {
                vkGetMemoryWin32HandleNV_ptr = LoadDeviceProcAddr(device, "vkGetMemoryWin32HandleNV");
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetMemoryWin32HandleNV(VkDevice device, VkDeviceMemory memory, VkExternalMemoryHandleTypeFlagsNV handleType, Win32.HANDLE* pHandle)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetMemoryWin32HandleNV(VkDevice device, VkDeviceMemory memory, VkExternalMemoryHandleTypeFlagsNV handleType, out Win32.HANDLE pHandle)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanKHRGetPhysicalDeviceProperties2
        {

            public VulkanKHRGetPhysicalDeviceProperties2(VkInstance instance)
            {
            }

        }

        public unsafe sealed class VulkanKHRDeviceGroup
        {
            private IntPtr vkAcquireNextImage2KHR_ptr;
            private IntPtr vkGetDeviceGroupPresentCapabilitiesKHR_ptr;
            private IntPtr vkGetDeviceGroupSurfacePresentModesKHR_ptr;
            private IntPtr vkGetPhysicalDevicePresentRectanglesKHR_ptr;

            public VulkanKHRDeviceGroup(VkDevice device)
            {
                vkAcquireNextImage2KHR_ptr = LoadDeviceProcAddr(device, "vkAcquireNextImage2KHR");
                vkGetDeviceGroupPresentCapabilitiesKHR_ptr = LoadDeviceProcAddr(device, "vkGetDeviceGroupPresentCapabilitiesKHR");
                vkGetDeviceGroupSurfacePresentModesKHR_ptr = LoadDeviceProcAddr(device, "vkGetDeviceGroupSurfacePresentModesKHR");
                vkGetPhysicalDevicePresentRectanglesKHR_ptr = LoadDeviceProcAddr(device, "vkGetPhysicalDevicePresentRectanglesKHR");
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_TIMEOUT, VK_NOT_READY, VK_SUBOPTIMAL_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_OUT_OF_DATE_KHR, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_FULL_SCREEN_EXCLUSIVE_MODE_LOST_EXT</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkAcquireNextImage2KHR(VkDevice device, VkAcquireNextImageInfoKHR* pAcquireInfo, uint* pImageIndex)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_TIMEOUT, VK_NOT_READY, VK_SUBOPTIMAL_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_OUT_OF_DATE_KHR, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_FULL_SCREEN_EXCLUSIVE_MODE_LOST_EXT</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkAcquireNextImage2KHR(VkDevice device, VkAcquireNextImageInfoKHR* pAcquireInfo, ref uint pImageIndex)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_TIMEOUT, VK_NOT_READY, VK_SUBOPTIMAL_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_OUT_OF_DATE_KHR, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_FULL_SCREEN_EXCLUSIVE_MODE_LOST_EXT</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkAcquireNextImage2KHR(VkDevice device, VkAcquireNextImageInfoKHR* pAcquireInfo, IntPtr pImageIndex)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_TIMEOUT, VK_NOT_READY, VK_SUBOPTIMAL_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_OUT_OF_DATE_KHR, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_FULL_SCREEN_EXCLUSIVE_MODE_LOST_EXT</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkAcquireNextImage2KHR(VkDevice device, ref VkAcquireNextImageInfoKHR pAcquireInfo, uint* pImageIndex)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_TIMEOUT, VK_NOT_READY, VK_SUBOPTIMAL_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_OUT_OF_DATE_KHR, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_FULL_SCREEN_EXCLUSIVE_MODE_LOST_EXT</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkAcquireNextImage2KHR(VkDevice device, ref VkAcquireNextImageInfoKHR pAcquireInfo, ref uint pImageIndex)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_TIMEOUT, VK_NOT_READY, VK_SUBOPTIMAL_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_OUT_OF_DATE_KHR, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_FULL_SCREEN_EXCLUSIVE_MODE_LOST_EXT</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkAcquireNextImage2KHR(VkDevice device, ref VkAcquireNextImageInfoKHR pAcquireInfo, IntPtr pImageIndex)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_TIMEOUT, VK_NOT_READY, VK_SUBOPTIMAL_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_OUT_OF_DATE_KHR, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_FULL_SCREEN_EXCLUSIVE_MODE_LOST_EXT</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkAcquireNextImage2KHR(VkDevice device, IntPtr pAcquireInfo, uint* pImageIndex)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_TIMEOUT, VK_NOT_READY, VK_SUBOPTIMAL_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_OUT_OF_DATE_KHR, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_FULL_SCREEN_EXCLUSIVE_MODE_LOST_EXT</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkAcquireNextImage2KHR(VkDevice device, IntPtr pAcquireInfo, ref uint pImageIndex)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_TIMEOUT, VK_NOT_READY, VK_SUBOPTIMAL_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_OUT_OF_DATE_KHR, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_FULL_SCREEN_EXCLUSIVE_MODE_LOST_EXT</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkAcquireNextImage2KHR(VkDevice device, IntPtr pAcquireInfo, IntPtr pImageIndex)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetDeviceGroupPresentCapabilitiesKHR(VkDevice device, VkDeviceGroupPresentCapabilitiesKHR* pDeviceGroupPresentCapabilities)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetDeviceGroupPresentCapabilitiesKHR(VkDevice device, out VkDeviceGroupPresentCapabilitiesKHR pDeviceGroupPresentCapabilities)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetDeviceGroupSurfacePresentModesKHR(VkDevice device, VkSurfaceKHR surface, VkDeviceGroupPresentModeFlagsKHR* pModes)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetDeviceGroupSurfacePresentModesKHR(VkDevice device, VkSurfaceKHR surface, out VkDeviceGroupPresentModeFlagsKHR pModes)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDevicePresentRectanglesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pRectCount, VkRect2D* pRects)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDevicePresentRectanglesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pRectCount, out VkRect2D pRects)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDevicePresentRectanglesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, ref uint pRectCount, VkRect2D* pRects)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDevicePresentRectanglesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, ref uint pRectCount, out VkRect2D pRects)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDevicePresentRectanglesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, IntPtr pRectCount, VkRect2D* pRects)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDevicePresentRectanglesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, IntPtr pRectCount, out VkRect2D pRects)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanNnViSurface
        {
            private IntPtr vkCreateViSurfaceNN_ptr;

            public VulkanNnViSurface(VkInstance instance)
            {
                vkCreateViSurfaceNN_ptr = LoadInstanceProcAddr(instance, "vkCreateViSurfaceNN");
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateViSurfaceNN(VkInstance instance, VkViSurfaceCreateInfoNN* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateViSurfaceNN(VkInstance instance, VkViSurfaceCreateInfoNN* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateViSurfaceNN(VkInstance instance, VkViSurfaceCreateInfoNN* pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateViSurfaceNN(VkInstance instance, VkViSurfaceCreateInfoNN* pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateViSurfaceNN(VkInstance instance, VkViSurfaceCreateInfoNN* pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateViSurfaceNN(VkInstance instance, VkViSurfaceCreateInfoNN* pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateViSurfaceNN(VkInstance instance, ref VkViSurfaceCreateInfoNN pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateViSurfaceNN(VkInstance instance, ref VkViSurfaceCreateInfoNN pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateViSurfaceNN(VkInstance instance, ref VkViSurfaceCreateInfoNN pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateViSurfaceNN(VkInstance instance, ref VkViSurfaceCreateInfoNN pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateViSurfaceNN(VkInstance instance, ref VkViSurfaceCreateInfoNN pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateViSurfaceNN(VkInstance instance, ref VkViSurfaceCreateInfoNN pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateViSurfaceNN(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateViSurfaceNN(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateViSurfaceNN(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateViSurfaceNN(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateViSurfaceNN(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateViSurfaceNN(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanKHRMaintenance1
        {

            public VulkanKHRMaintenance1(VkDevice device)
            {
            }

        }

        public unsafe sealed class VulkanKHRDeviceGroupCreation
        {

            public VulkanKHRDeviceGroupCreation(VkInstance instance)
            {
            }

        }

        public unsafe sealed class VulkanKHRExternalMemoryCapabilities
        {

            public VulkanKHRExternalMemoryCapabilities(VkInstance instance)
            {
            }

        }

        public unsafe sealed class VulkanKHRExternalMemoryWin32
        {
            private IntPtr vkGetMemoryWin32HandleKHR_ptr;
            private IntPtr vkGetMemoryWin32HandlePropertiesKHR_ptr;

            public VulkanKHRExternalMemoryWin32(VkDevice device)
            {
                vkGetMemoryWin32HandleKHR_ptr = LoadDeviceProcAddr(device, "vkGetMemoryWin32HandleKHR");
                vkGetMemoryWin32HandlePropertiesKHR_ptr = LoadDeviceProcAddr(device, "vkGetMemoryWin32HandlePropertiesKHR");
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetMemoryWin32HandleKHR(VkDevice device, VkMemoryGetWin32HandleInfoKHR* pGetWin32HandleInfo, Win32.HANDLE* pHandle)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetMemoryWin32HandleKHR(VkDevice device, VkMemoryGetWin32HandleInfoKHR* pGetWin32HandleInfo, out Win32.HANDLE pHandle)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetMemoryWin32HandleKHR(VkDevice device, ref VkMemoryGetWin32HandleInfoKHR pGetWin32HandleInfo, Win32.HANDLE* pHandle)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetMemoryWin32HandleKHR(VkDevice device, ref VkMemoryGetWin32HandleInfoKHR pGetWin32HandleInfo, out Win32.HANDLE pHandle)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetMemoryWin32HandleKHR(VkDevice device, IntPtr pGetWin32HandleInfo, Win32.HANDLE* pHandle)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetMemoryWin32HandleKHR(VkDevice device, IntPtr pGetWin32HandleInfo, out Win32.HANDLE pHandle)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetMemoryWin32HandlePropertiesKHR(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, Win32.HANDLE handle, VkMemoryWin32HandlePropertiesKHR* pMemoryWin32HandleProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetMemoryWin32HandlePropertiesKHR(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, Win32.HANDLE handle, out VkMemoryWin32HandlePropertiesKHR pMemoryWin32HandleProperties)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanKHRExternalMemoryFd
        {
            private IntPtr vkGetMemoryFdKHR_ptr;
            private IntPtr vkGetMemoryFdPropertiesKHR_ptr;

            public VulkanKHRExternalMemoryFd(VkDevice device)
            {
                vkGetMemoryFdKHR_ptr = LoadDeviceProcAddr(device, "vkGetMemoryFdKHR");
                vkGetMemoryFdPropertiesKHR_ptr = LoadDeviceProcAddr(device, "vkGetMemoryFdPropertiesKHR");
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetMemoryFdKHR(VkDevice device, VkMemoryGetFdInfoKHR* pGetFdInfo, int* pFd)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetMemoryFdKHR(VkDevice device, VkMemoryGetFdInfoKHR* pGetFdInfo, out int pFd)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetMemoryFdKHR(VkDevice device, ref VkMemoryGetFdInfoKHR pGetFdInfo, int* pFd)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetMemoryFdKHR(VkDevice device, ref VkMemoryGetFdInfoKHR pGetFdInfo, out int pFd)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetMemoryFdKHR(VkDevice device, IntPtr pGetFdInfo, int* pFd)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetMemoryFdKHR(VkDevice device, IntPtr pGetFdInfo, out int pFd)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetMemoryFdPropertiesKHR(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, int fd, VkMemoryFdPropertiesKHR* pMemoryFdProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetMemoryFdPropertiesKHR(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, int fd, out VkMemoryFdPropertiesKHR pMemoryFdProperties)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanKHRExternalSemaphoreCapabilities
        {

            public VulkanKHRExternalSemaphoreCapabilities(VkInstance instance)
            {
            }

        }

        public unsafe sealed class VulkanKHRExternalSemaphoreWin32
        {
            private IntPtr vkGetSemaphoreWin32HandleKHR_ptr;
            private IntPtr vkImportSemaphoreWin32HandleKHR_ptr;

            public VulkanKHRExternalSemaphoreWin32(VkDevice device)
            {
                vkGetSemaphoreWin32HandleKHR_ptr = LoadDeviceProcAddr(device, "vkGetSemaphoreWin32HandleKHR");
                vkImportSemaphoreWin32HandleKHR_ptr = LoadDeviceProcAddr(device, "vkImportSemaphoreWin32HandleKHR");
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetSemaphoreWin32HandleKHR(VkDevice device, VkSemaphoreGetWin32HandleInfoKHR* pGetWin32HandleInfo, Win32.HANDLE* pHandle)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetSemaphoreWin32HandleKHR(VkDevice device, VkSemaphoreGetWin32HandleInfoKHR* pGetWin32HandleInfo, out Win32.HANDLE pHandle)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetSemaphoreWin32HandleKHR(VkDevice device, ref VkSemaphoreGetWin32HandleInfoKHR pGetWin32HandleInfo, Win32.HANDLE* pHandle)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetSemaphoreWin32HandleKHR(VkDevice device, ref VkSemaphoreGetWin32HandleInfoKHR pGetWin32HandleInfo, out Win32.HANDLE pHandle)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetSemaphoreWin32HandleKHR(VkDevice device, IntPtr pGetWin32HandleInfo, Win32.HANDLE* pHandle)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetSemaphoreWin32HandleKHR(VkDevice device, IntPtr pGetWin32HandleInfo, out Win32.HANDLE pHandle)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkImportSemaphoreWin32HandleKHR(VkDevice device, VkImportSemaphoreWin32HandleInfoKHR* pImportSemaphoreWin32HandleInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkImportSemaphoreWin32HandleKHR(VkDevice device, ref VkImportSemaphoreWin32HandleInfoKHR pImportSemaphoreWin32HandleInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkImportSemaphoreWin32HandleKHR(VkDevice device, IntPtr pImportSemaphoreWin32HandleInfo)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanKHRExternalSemaphoreFd
        {
            private IntPtr vkGetSemaphoreFdKHR_ptr;
            private IntPtr vkImportSemaphoreFdKHR_ptr;

            public VulkanKHRExternalSemaphoreFd(VkDevice device)
            {
                vkGetSemaphoreFdKHR_ptr = LoadDeviceProcAddr(device, "vkGetSemaphoreFdKHR");
                vkImportSemaphoreFdKHR_ptr = LoadDeviceProcAddr(device, "vkImportSemaphoreFdKHR");
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetSemaphoreFdKHR(VkDevice device, VkSemaphoreGetFdInfoKHR* pGetFdInfo, int* pFd)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetSemaphoreFdKHR(VkDevice device, VkSemaphoreGetFdInfoKHR* pGetFdInfo, out int pFd)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetSemaphoreFdKHR(VkDevice device, ref VkSemaphoreGetFdInfoKHR pGetFdInfo, int* pFd)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetSemaphoreFdKHR(VkDevice device, ref VkSemaphoreGetFdInfoKHR pGetFdInfo, out int pFd)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetSemaphoreFdKHR(VkDevice device, IntPtr pGetFdInfo, int* pFd)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetSemaphoreFdKHR(VkDevice device, IntPtr pGetFdInfo, out int pFd)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkImportSemaphoreFdKHR(VkDevice device, VkImportSemaphoreFdInfoKHR* pImportSemaphoreFdInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkImportSemaphoreFdKHR(VkDevice device, ref VkImportSemaphoreFdInfoKHR pImportSemaphoreFdInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkImportSemaphoreFdKHR(VkDevice device, IntPtr pImportSemaphoreFdInfo)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanKHRPushDescriptor
        {
            private IntPtr vkCmdPushDescriptorSetKHR_ptr;

            public VulkanKHRPushDescriptor(VkDevice device)
            {
                vkCmdPushDescriptorSetKHR_ptr = LoadDeviceProcAddr(device, "vkCmdPushDescriptorSetKHR");
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdPushDescriptorSetKHR(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint set, uint descriptorWriteCount, VkWriteDescriptorSet* pDescriptorWrites)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdPushDescriptorSetKHR(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint set, uint descriptorWriteCount, ref VkWriteDescriptorSet pDescriptorWrites)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdPushDescriptorSetKHR(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint set, uint descriptorWriteCount, IntPtr pDescriptorWrites)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanEXTConditionalRendering
        {
            private IntPtr vkCmdBeginConditionalRenderingEXT_ptr;
            private IntPtr vkCmdEndConditionalRenderingEXT_ptr;

            public VulkanEXTConditionalRendering(VkDevice device)
            {
                vkCmdBeginConditionalRenderingEXT_ptr = LoadDeviceProcAddr(device, "vkCmdBeginConditionalRenderingEXT");
                vkCmdEndConditionalRenderingEXT_ptr = LoadDeviceProcAddr(device, "vkCmdEndConditionalRenderingEXT");
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBeginConditionalRenderingEXT(VkCommandBuffer commandBuffer, VkConditionalRenderingBeginInfoEXT* pConditionalRenderingBegin)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBeginConditionalRenderingEXT(VkCommandBuffer commandBuffer, ref VkConditionalRenderingBeginInfoEXT pConditionalRenderingBegin)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBeginConditionalRenderingEXT(VkCommandBuffer commandBuffer, IntPtr pConditionalRenderingBegin)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdEndConditionalRenderingEXT(VkCommandBuffer commandBuffer)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanKHRDescriptorUpdateTemplate
        {
            private IntPtr vkCmdPushDescriptorSetWithTemplateKHR_ptr;

            public VulkanKHRDescriptorUpdateTemplate(VkDevice device)
            {
                vkCmdPushDescriptorSetWithTemplateKHR_ptr = LoadDeviceProcAddr(device, "vkCmdPushDescriptorSetWithTemplateKHR");
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdPushDescriptorSetWithTemplateKHR(VkCommandBuffer commandBuffer, VkDescriptorUpdateTemplate descriptorUpdateTemplate, VkPipelineLayout layout, uint set, void* pData)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanNVClipSpaceWScaling
        {
            private IntPtr vkCmdSetViewportWScalingNV_ptr;

            public VulkanNVClipSpaceWScaling(VkDevice device)
            {
                vkCmdSetViewportWScalingNV_ptr = LoadDeviceProcAddr(device, "vkCmdSetViewportWScalingNV");
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetViewportWScalingNV(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkViewportWScalingNV* pViewportWScalings)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetViewportWScalingNV(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, ref VkViewportWScalingNV pViewportWScalings)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetViewportWScalingNV(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, IntPtr pViewportWScalings)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanEXTDirectModeDisplay
        {
            private IntPtr vkReleaseDisplayEXT_ptr;

            public VulkanEXTDirectModeDisplay(VkInstance instance)
            {
                vkReleaseDisplayEXT_ptr = LoadInstanceProcAddr(instance, "vkReleaseDisplayEXT");
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkReleaseDisplayEXT(VkPhysicalDevice physicalDevice, VkDisplayKHR display)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanEXTAcquireXlibDisplay
        {
            private IntPtr vkAcquireXlibDisplayEXT_ptr;
            private IntPtr vkGetRandROutputDisplayEXT_ptr;

            public VulkanEXTAcquireXlibDisplay(VkInstance instance)
            {
                vkAcquireXlibDisplayEXT_ptr = LoadInstanceProcAddr(instance, "vkAcquireXlibDisplayEXT");
                vkGetRandROutputDisplayEXT_ptr = LoadInstanceProcAddr(instance, "vkGetRandROutputDisplayEXT");
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkAcquireXlibDisplayEXT(VkPhysicalDevice physicalDevice, Xlib.Display* dpy, VkDisplayKHR display)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkAcquireXlibDisplayEXT(VkPhysicalDevice physicalDevice, ref Xlib.Display dpy, VkDisplayKHR display)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkAcquireXlibDisplayEXT(VkPhysicalDevice physicalDevice, IntPtr dpy, VkDisplayKHR display)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetRandROutputDisplayEXT(VkPhysicalDevice physicalDevice, Xlib.Display* dpy, IntPtr rrOutput, VkDisplayKHR* pDisplay)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetRandROutputDisplayEXT(VkPhysicalDevice physicalDevice, Xlib.Display* dpy, IntPtr rrOutput, out VkDisplayKHR pDisplay)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetRandROutputDisplayEXT(VkPhysicalDevice physicalDevice, ref Xlib.Display dpy, IntPtr rrOutput, VkDisplayKHR* pDisplay)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetRandROutputDisplayEXT(VkPhysicalDevice physicalDevice, ref Xlib.Display dpy, IntPtr rrOutput, out VkDisplayKHR pDisplay)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetRandROutputDisplayEXT(VkPhysicalDevice physicalDevice, IntPtr dpy, IntPtr rrOutput, VkDisplayKHR* pDisplay)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetRandROutputDisplayEXT(VkPhysicalDevice physicalDevice, IntPtr dpy, IntPtr rrOutput, out VkDisplayKHR pDisplay)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanEXTDisplaySurfaceCounter
        {
            private IntPtr vkGetPhysicalDeviceSurfaceCapabilities2EXT_ptr;

            public VulkanEXTDisplaySurfaceCounter(VkInstance instance)
            {
                vkGetPhysicalDeviceSurfaceCapabilities2EXT_ptr = LoadInstanceProcAddr(instance, "vkGetPhysicalDeviceSurfaceCapabilities2EXT");
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSurfaceCapabilities2EXT(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, VkSurfaceCapabilities2EXT* pSurfaceCapabilities)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSurfaceCapabilities2EXT(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, out VkSurfaceCapabilities2EXT pSurfaceCapabilities)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanEXTDisplayControl
        {
            private IntPtr vkDisplayPowerControlEXT_ptr;
            private IntPtr vkGetSwapchainCounterEXT_ptr;
            private IntPtr vkRegisterDeviceEventEXT_ptr;
            private IntPtr vkRegisterDisplayEventEXT_ptr;

            public VulkanEXTDisplayControl(VkDevice device)
            {
                vkDisplayPowerControlEXT_ptr = LoadDeviceProcAddr(device, "vkDisplayPowerControlEXT");
                vkGetSwapchainCounterEXT_ptr = LoadDeviceProcAddr(device, "vkGetSwapchainCounterEXT");
                vkRegisterDeviceEventEXT_ptr = LoadDeviceProcAddr(device, "vkRegisterDeviceEventEXT");
                vkRegisterDisplayEventEXT_ptr = LoadDeviceProcAddr(device, "vkRegisterDisplayEventEXT");
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkDisplayPowerControlEXT(VkDevice device, VkDisplayKHR display, VkDisplayPowerInfoEXT* pDisplayPowerInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkDisplayPowerControlEXT(VkDevice device, VkDisplayKHR display, ref VkDisplayPowerInfoEXT pDisplayPowerInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkDisplayPowerControlEXT(VkDevice device, VkDisplayKHR display, IntPtr pDisplayPowerInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_OUT_OF_DATE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetSwapchainCounterEXT(VkDevice device, VkSwapchainKHR swapchain, VkSurfaceCounterFlagsEXT counter, ulong* pCounterValue)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_OUT_OF_DATE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetSwapchainCounterEXT(VkDevice device, VkSwapchainKHR swapchain, VkSurfaceCounterFlagsEXT counter, out ulong pCounterValue)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkRegisterDeviceEventEXT(VkDevice device, VkDeviceEventInfoEXT* pDeviceEventInfo, VkAllocationCallbacks* pAllocator, VkFence* pFence)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkRegisterDeviceEventEXT(VkDevice device, VkDeviceEventInfoEXT* pDeviceEventInfo, VkAllocationCallbacks* pAllocator, ref VkFence pFence)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkRegisterDeviceEventEXT(VkDevice device, VkDeviceEventInfoEXT* pDeviceEventInfo, VkAllocationCallbacks* pAllocator, IntPtr pFence)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkRegisterDeviceEventEXT(VkDevice device, VkDeviceEventInfoEXT* pDeviceEventInfo, ref VkAllocationCallbacks pAllocator, VkFence* pFence)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkRegisterDeviceEventEXT(VkDevice device, VkDeviceEventInfoEXT* pDeviceEventInfo, ref VkAllocationCallbacks pAllocator, ref VkFence pFence)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkRegisterDeviceEventEXT(VkDevice device, VkDeviceEventInfoEXT* pDeviceEventInfo, ref VkAllocationCallbacks pAllocator, IntPtr pFence)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkRegisterDeviceEventEXT(VkDevice device, VkDeviceEventInfoEXT* pDeviceEventInfo, IntPtr pAllocator, VkFence* pFence)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkRegisterDeviceEventEXT(VkDevice device, VkDeviceEventInfoEXT* pDeviceEventInfo, IntPtr pAllocator, ref VkFence pFence)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkRegisterDeviceEventEXT(VkDevice device, VkDeviceEventInfoEXT* pDeviceEventInfo, IntPtr pAllocator, IntPtr pFence)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkRegisterDeviceEventEXT(VkDevice device, ref VkDeviceEventInfoEXT pDeviceEventInfo, VkAllocationCallbacks* pAllocator, VkFence* pFence)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkRegisterDeviceEventEXT(VkDevice device, ref VkDeviceEventInfoEXT pDeviceEventInfo, VkAllocationCallbacks* pAllocator, ref VkFence pFence)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkRegisterDeviceEventEXT(VkDevice device, ref VkDeviceEventInfoEXT pDeviceEventInfo, VkAllocationCallbacks* pAllocator, IntPtr pFence)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkRegisterDeviceEventEXT(VkDevice device, ref VkDeviceEventInfoEXT pDeviceEventInfo, ref VkAllocationCallbacks pAllocator, VkFence* pFence)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkRegisterDeviceEventEXT(VkDevice device, ref VkDeviceEventInfoEXT pDeviceEventInfo, ref VkAllocationCallbacks pAllocator, ref VkFence pFence)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkRegisterDeviceEventEXT(VkDevice device, ref VkDeviceEventInfoEXT pDeviceEventInfo, ref VkAllocationCallbacks pAllocator, IntPtr pFence)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkRegisterDeviceEventEXT(VkDevice device, ref VkDeviceEventInfoEXT pDeviceEventInfo, IntPtr pAllocator, VkFence* pFence)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkRegisterDeviceEventEXT(VkDevice device, ref VkDeviceEventInfoEXT pDeviceEventInfo, IntPtr pAllocator, ref VkFence pFence)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkRegisterDeviceEventEXT(VkDevice device, ref VkDeviceEventInfoEXT pDeviceEventInfo, IntPtr pAllocator, IntPtr pFence)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkRegisterDeviceEventEXT(VkDevice device, IntPtr pDeviceEventInfo, VkAllocationCallbacks* pAllocator, VkFence* pFence)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkRegisterDeviceEventEXT(VkDevice device, IntPtr pDeviceEventInfo, VkAllocationCallbacks* pAllocator, ref VkFence pFence)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkRegisterDeviceEventEXT(VkDevice device, IntPtr pDeviceEventInfo, VkAllocationCallbacks* pAllocator, IntPtr pFence)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkRegisterDeviceEventEXT(VkDevice device, IntPtr pDeviceEventInfo, ref VkAllocationCallbacks pAllocator, VkFence* pFence)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkRegisterDeviceEventEXT(VkDevice device, IntPtr pDeviceEventInfo, ref VkAllocationCallbacks pAllocator, ref VkFence pFence)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkRegisterDeviceEventEXT(VkDevice device, IntPtr pDeviceEventInfo, ref VkAllocationCallbacks pAllocator, IntPtr pFence)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkRegisterDeviceEventEXT(VkDevice device, IntPtr pDeviceEventInfo, IntPtr pAllocator, VkFence* pFence)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkRegisterDeviceEventEXT(VkDevice device, IntPtr pDeviceEventInfo, IntPtr pAllocator, ref VkFence pFence)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkRegisterDeviceEventEXT(VkDevice device, IntPtr pDeviceEventInfo, IntPtr pAllocator, IntPtr pFence)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, VkDisplayEventInfoEXT* pDisplayEventInfo, VkAllocationCallbacks* pAllocator, VkFence* pFence)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, VkDisplayEventInfoEXT* pDisplayEventInfo, VkAllocationCallbacks* pAllocator, ref VkFence pFence)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, VkDisplayEventInfoEXT* pDisplayEventInfo, VkAllocationCallbacks* pAllocator, IntPtr pFence)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, VkDisplayEventInfoEXT* pDisplayEventInfo, ref VkAllocationCallbacks pAllocator, VkFence* pFence)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, VkDisplayEventInfoEXT* pDisplayEventInfo, ref VkAllocationCallbacks pAllocator, ref VkFence pFence)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, VkDisplayEventInfoEXT* pDisplayEventInfo, ref VkAllocationCallbacks pAllocator, IntPtr pFence)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, VkDisplayEventInfoEXT* pDisplayEventInfo, IntPtr pAllocator, VkFence* pFence)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, VkDisplayEventInfoEXT* pDisplayEventInfo, IntPtr pAllocator, ref VkFence pFence)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, VkDisplayEventInfoEXT* pDisplayEventInfo, IntPtr pAllocator, IntPtr pFence)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, ref VkDisplayEventInfoEXT pDisplayEventInfo, VkAllocationCallbacks* pAllocator, VkFence* pFence)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, ref VkDisplayEventInfoEXT pDisplayEventInfo, VkAllocationCallbacks* pAllocator, ref VkFence pFence)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, ref VkDisplayEventInfoEXT pDisplayEventInfo, VkAllocationCallbacks* pAllocator, IntPtr pFence)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, ref VkDisplayEventInfoEXT pDisplayEventInfo, ref VkAllocationCallbacks pAllocator, VkFence* pFence)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, ref VkDisplayEventInfoEXT pDisplayEventInfo, ref VkAllocationCallbacks pAllocator, ref VkFence pFence)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, ref VkDisplayEventInfoEXT pDisplayEventInfo, ref VkAllocationCallbacks pAllocator, IntPtr pFence)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, ref VkDisplayEventInfoEXT pDisplayEventInfo, IntPtr pAllocator, VkFence* pFence)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, ref VkDisplayEventInfoEXT pDisplayEventInfo, IntPtr pAllocator, ref VkFence pFence)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, ref VkDisplayEventInfoEXT pDisplayEventInfo, IntPtr pAllocator, IntPtr pFence)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, IntPtr pDisplayEventInfo, VkAllocationCallbacks* pAllocator, VkFence* pFence)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, IntPtr pDisplayEventInfo, VkAllocationCallbacks* pAllocator, ref VkFence pFence)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, IntPtr pDisplayEventInfo, VkAllocationCallbacks* pAllocator, IntPtr pFence)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, IntPtr pDisplayEventInfo, ref VkAllocationCallbacks pAllocator, VkFence* pFence)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, IntPtr pDisplayEventInfo, ref VkAllocationCallbacks pAllocator, ref VkFence pFence)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, IntPtr pDisplayEventInfo, ref VkAllocationCallbacks pAllocator, IntPtr pFence)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, IntPtr pDisplayEventInfo, IntPtr pAllocator, VkFence* pFence)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, IntPtr pDisplayEventInfo, IntPtr pAllocator, ref VkFence pFence)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, IntPtr pDisplayEventInfo, IntPtr pAllocator, IntPtr pFence)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanGoogleDisplayTiming
        {
            private IntPtr vkGetPastPresentationTimingGOOGLE_ptr;
            private IntPtr vkGetRefreshCycleDurationGOOGLE_ptr;

            public VulkanGoogleDisplayTiming(VkDevice device)
            {
                vkGetPastPresentationTimingGOOGLE_ptr = LoadDeviceProcAddr(device, "vkGetPastPresentationTimingGOOGLE");
                vkGetRefreshCycleDurationGOOGLE_ptr = LoadDeviceProcAddr(device, "vkGetRefreshCycleDurationGOOGLE");
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_OUT_OF_DATE_KHR, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPastPresentationTimingGOOGLE(VkDevice device, VkSwapchainKHR swapchain, uint* pPresentationTimingCount, VkPastPresentationTimingGOOGLE* pPresentationTimings)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_OUT_OF_DATE_KHR, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPastPresentationTimingGOOGLE(VkDevice device, VkSwapchainKHR swapchain, uint* pPresentationTimingCount, out VkPastPresentationTimingGOOGLE pPresentationTimings)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_OUT_OF_DATE_KHR, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPastPresentationTimingGOOGLE(VkDevice device, VkSwapchainKHR swapchain, ref uint pPresentationTimingCount, VkPastPresentationTimingGOOGLE* pPresentationTimings)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_OUT_OF_DATE_KHR, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPastPresentationTimingGOOGLE(VkDevice device, VkSwapchainKHR swapchain, ref uint pPresentationTimingCount, out VkPastPresentationTimingGOOGLE pPresentationTimings)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_OUT_OF_DATE_KHR, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPastPresentationTimingGOOGLE(VkDevice device, VkSwapchainKHR swapchain, IntPtr pPresentationTimingCount, VkPastPresentationTimingGOOGLE* pPresentationTimings)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_OUT_OF_DATE_KHR, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPastPresentationTimingGOOGLE(VkDevice device, VkSwapchainKHR swapchain, IntPtr pPresentationTimingCount, out VkPastPresentationTimingGOOGLE pPresentationTimings)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetRefreshCycleDurationGOOGLE(VkDevice device, VkSwapchainKHR swapchain, VkRefreshCycleDurationGOOGLE* pDisplayTimingProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetRefreshCycleDurationGOOGLE(VkDevice device, VkSwapchainKHR swapchain, out VkRefreshCycleDurationGOOGLE pDisplayTimingProperties)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanEXTDiscardRectangles
        {
            private IntPtr vkCmdSetDiscardRectangleEXT_ptr;

            public VulkanEXTDiscardRectangles(VkDevice device)
            {
                vkCmdSetDiscardRectangleEXT_ptr = LoadDeviceProcAddr(device, "vkCmdSetDiscardRectangleEXT");
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetDiscardRectangleEXT(VkCommandBuffer commandBuffer, uint firstDiscardRectangle, uint discardRectangleCount, VkRect2D* pDiscardRectangles)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetDiscardRectangleEXT(VkCommandBuffer commandBuffer, uint firstDiscardRectangle, uint discardRectangleCount, ref VkRect2D pDiscardRectangles)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetDiscardRectangleEXT(VkCommandBuffer commandBuffer, uint firstDiscardRectangle, uint discardRectangleCount, IntPtr pDiscardRectangles)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanEXTHdrMetadata
        {
            private IntPtr vkSetHdrMetadataEXT_ptr;

            public VulkanEXTHdrMetadata(VkDevice device)
            {
                vkSetHdrMetadataEXT_ptr = LoadDeviceProcAddr(device, "vkSetHdrMetadataEXT");
            }

            [Generator.CalliRewrite]
            public unsafe void vkSetHdrMetadataEXT(VkDevice device, uint swapchainCount, VkSwapchainKHR* pSwapchains, VkHdrMetadataEXT* pMetadata)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkSetHdrMetadataEXT(VkDevice device, uint swapchainCount, VkSwapchainKHR* pSwapchains, ref VkHdrMetadataEXT pMetadata)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkSetHdrMetadataEXT(VkDevice device, uint swapchainCount, VkSwapchainKHR* pSwapchains, IntPtr pMetadata)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkSetHdrMetadataEXT(VkDevice device, uint swapchainCount, ref VkSwapchainKHR pSwapchains, VkHdrMetadataEXT* pMetadata)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkSetHdrMetadataEXT(VkDevice device, uint swapchainCount, ref VkSwapchainKHR pSwapchains, ref VkHdrMetadataEXT pMetadata)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkSetHdrMetadataEXT(VkDevice device, uint swapchainCount, ref VkSwapchainKHR pSwapchains, IntPtr pMetadata)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkSetHdrMetadataEXT(VkDevice device, uint swapchainCount, IntPtr pSwapchains, VkHdrMetadataEXT* pMetadata)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkSetHdrMetadataEXT(VkDevice device, uint swapchainCount, IntPtr pSwapchains, ref VkHdrMetadataEXT pMetadata)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkSetHdrMetadataEXT(VkDevice device, uint swapchainCount, IntPtr pSwapchains, IntPtr pMetadata)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanKHRCreateRenderpass2
        {

            public VulkanKHRCreateRenderpass2(VkDevice device)
            {
            }

        }

        public unsafe sealed class VulkanKHRSharedPresentableImage
        {
            private IntPtr vkGetSwapchainStatusKHR_ptr;

            public VulkanKHRSharedPresentableImage(VkDevice device)
            {
                vkGetSwapchainStatusKHR_ptr = LoadDeviceProcAddr(device, "vkGetSwapchainStatusKHR");
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_SUBOPTIMAL_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_OUT_OF_DATE_KHR, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_FULL_SCREEN_EXCLUSIVE_MODE_LOST_EXT</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetSwapchainStatusKHR(VkDevice device, VkSwapchainKHR swapchain)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanKHRExternalFenceCapabilities
        {

            public VulkanKHRExternalFenceCapabilities(VkInstance instance)
            {
            }

        }

        public unsafe sealed class VulkanKHRExternalFenceWin32
        {
            private IntPtr vkGetFenceWin32HandleKHR_ptr;
            private IntPtr vkImportFenceWin32HandleKHR_ptr;

            public VulkanKHRExternalFenceWin32(VkDevice device)
            {
                vkGetFenceWin32HandleKHR_ptr = LoadDeviceProcAddr(device, "vkGetFenceWin32HandleKHR");
                vkImportFenceWin32HandleKHR_ptr = LoadDeviceProcAddr(device, "vkImportFenceWin32HandleKHR");
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetFenceWin32HandleKHR(VkDevice device, VkFenceGetWin32HandleInfoKHR* pGetWin32HandleInfo, Win32.HANDLE* pHandle)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetFenceWin32HandleKHR(VkDevice device, VkFenceGetWin32HandleInfoKHR* pGetWin32HandleInfo, out Win32.HANDLE pHandle)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetFenceWin32HandleKHR(VkDevice device, ref VkFenceGetWin32HandleInfoKHR pGetWin32HandleInfo, Win32.HANDLE* pHandle)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetFenceWin32HandleKHR(VkDevice device, ref VkFenceGetWin32HandleInfoKHR pGetWin32HandleInfo, out Win32.HANDLE pHandle)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetFenceWin32HandleKHR(VkDevice device, IntPtr pGetWin32HandleInfo, Win32.HANDLE* pHandle)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetFenceWin32HandleKHR(VkDevice device, IntPtr pGetWin32HandleInfo, out Win32.HANDLE pHandle)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkImportFenceWin32HandleKHR(VkDevice device, VkImportFenceWin32HandleInfoKHR* pImportFenceWin32HandleInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkImportFenceWin32HandleKHR(VkDevice device, ref VkImportFenceWin32HandleInfoKHR pImportFenceWin32HandleInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkImportFenceWin32HandleKHR(VkDevice device, IntPtr pImportFenceWin32HandleInfo)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanKHRExternalFenceFd
        {
            private IntPtr vkGetFenceFdKHR_ptr;
            private IntPtr vkImportFenceFdKHR_ptr;

            public VulkanKHRExternalFenceFd(VkDevice device)
            {
                vkGetFenceFdKHR_ptr = LoadDeviceProcAddr(device, "vkGetFenceFdKHR");
                vkImportFenceFdKHR_ptr = LoadDeviceProcAddr(device, "vkImportFenceFdKHR");
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetFenceFdKHR(VkDevice device, VkFenceGetFdInfoKHR* pGetFdInfo, int* pFd)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetFenceFdKHR(VkDevice device, VkFenceGetFdInfoKHR* pGetFdInfo, out int pFd)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetFenceFdKHR(VkDevice device, ref VkFenceGetFdInfoKHR pGetFdInfo, int* pFd)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetFenceFdKHR(VkDevice device, ref VkFenceGetFdInfoKHR pGetFdInfo, out int pFd)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetFenceFdKHR(VkDevice device, IntPtr pGetFdInfo, int* pFd)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetFenceFdKHR(VkDevice device, IntPtr pGetFdInfo, out int pFd)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkImportFenceFdKHR(VkDevice device, VkImportFenceFdInfoKHR* pImportFenceFdInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkImportFenceFdKHR(VkDevice device, ref VkImportFenceFdInfoKHR pImportFenceFdInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkImportFenceFdKHR(VkDevice device, IntPtr pImportFenceFdInfo)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanKHRPerformanceQuery
        {
            private IntPtr vkAcquireProfilingLockKHR_ptr;
            private IntPtr vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR_ptr;
            private IntPtr vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR_ptr;
            private IntPtr vkReleaseProfilingLockKHR_ptr;

            public VulkanKHRPerformanceQuery(VkDevice device)
            {
                vkAcquireProfilingLockKHR_ptr = LoadDeviceProcAddr(device, "vkAcquireProfilingLockKHR");
                vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR_ptr = LoadDeviceProcAddr(device, "vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR");
                vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR_ptr = LoadDeviceProcAddr(device, "vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR");
                vkReleaseProfilingLockKHR_ptr = LoadDeviceProcAddr(device, "vkReleaseProfilingLockKHR");
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_TIMEOUT</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkAcquireProfilingLockKHR(VkDevice device, VkAcquireProfilingLockInfoKHR* pInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_TIMEOUT</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkAcquireProfilingLockKHR(VkDevice device, ref VkAcquireProfilingLockInfoKHR pInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_TIMEOUT</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkAcquireProfilingLockKHR(VkDevice device, IntPtr pInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, uint* pCounterCount, VkPerformanceCounterKHR* pCounters, VkPerformanceCounterDescriptionKHR* pCounterDescriptions)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, uint* pCounterCount, VkPerformanceCounterKHR* pCounters, ref VkPerformanceCounterDescriptionKHR pCounterDescriptions)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, uint* pCounterCount, VkPerformanceCounterKHR* pCounters, IntPtr pCounterDescriptions)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, uint* pCounterCount, ref VkPerformanceCounterKHR pCounters, VkPerformanceCounterDescriptionKHR* pCounterDescriptions)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, uint* pCounterCount, ref VkPerformanceCounterKHR pCounters, ref VkPerformanceCounterDescriptionKHR pCounterDescriptions)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, uint* pCounterCount, ref VkPerformanceCounterKHR pCounters, IntPtr pCounterDescriptions)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, uint* pCounterCount, IntPtr pCounters, VkPerformanceCounterDescriptionKHR* pCounterDescriptions)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, uint* pCounterCount, IntPtr pCounters, ref VkPerformanceCounterDescriptionKHR pCounterDescriptions)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, uint* pCounterCount, IntPtr pCounters, IntPtr pCounterDescriptions)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, ref uint pCounterCount, VkPerformanceCounterKHR* pCounters, VkPerformanceCounterDescriptionKHR* pCounterDescriptions)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, ref uint pCounterCount, VkPerformanceCounterKHR* pCounters, ref VkPerformanceCounterDescriptionKHR pCounterDescriptions)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, ref uint pCounterCount, VkPerformanceCounterKHR* pCounters, IntPtr pCounterDescriptions)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, ref uint pCounterCount, ref VkPerformanceCounterKHR pCounters, VkPerformanceCounterDescriptionKHR* pCounterDescriptions)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, ref uint pCounterCount, ref VkPerformanceCounterKHR pCounters, ref VkPerformanceCounterDescriptionKHR pCounterDescriptions)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, ref uint pCounterCount, ref VkPerformanceCounterKHR pCounters, IntPtr pCounterDescriptions)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, ref uint pCounterCount, IntPtr pCounters, VkPerformanceCounterDescriptionKHR* pCounterDescriptions)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, ref uint pCounterCount, IntPtr pCounters, ref VkPerformanceCounterDescriptionKHR pCounterDescriptions)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, ref uint pCounterCount, IntPtr pCounters, IntPtr pCounterDescriptions)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr pCounterCount, VkPerformanceCounterKHR* pCounters, VkPerformanceCounterDescriptionKHR* pCounterDescriptions)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr pCounterCount, VkPerformanceCounterKHR* pCounters, ref VkPerformanceCounterDescriptionKHR pCounterDescriptions)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr pCounterCount, VkPerformanceCounterKHR* pCounters, IntPtr pCounterDescriptions)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr pCounterCount, ref VkPerformanceCounterKHR pCounters, VkPerformanceCounterDescriptionKHR* pCounterDescriptions)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr pCounterCount, ref VkPerformanceCounterKHR pCounters, ref VkPerformanceCounterDescriptionKHR pCounterDescriptions)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr pCounterCount, ref VkPerformanceCounterKHR pCounters, IntPtr pCounterDescriptions)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr pCounterCount, IntPtr pCounters, VkPerformanceCounterDescriptionKHR* pCounterDescriptions)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr pCounterCount, IntPtr pCounters, ref VkPerformanceCounterDescriptionKHR pCounterDescriptions)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr pCounterCount, IntPtr pCounters, IntPtr pCounterDescriptions)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR(VkPhysicalDevice physicalDevice, VkQueryPoolPerformanceCreateInfoKHR* pPerformanceQueryCreateInfo, uint* pNumPasses)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR(VkPhysicalDevice physicalDevice, VkQueryPoolPerformanceCreateInfoKHR* pPerformanceQueryCreateInfo, out uint pNumPasses)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR(VkPhysicalDevice physicalDevice, ref VkQueryPoolPerformanceCreateInfoKHR pPerformanceQueryCreateInfo, uint* pNumPasses)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR(VkPhysicalDevice physicalDevice, ref VkQueryPoolPerformanceCreateInfoKHR pPerformanceQueryCreateInfo, out uint pNumPasses)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR(VkPhysicalDevice physicalDevice, IntPtr pPerformanceQueryCreateInfo, uint* pNumPasses)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR(VkPhysicalDevice physicalDevice, IntPtr pPerformanceQueryCreateInfo, out uint pNumPasses)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkReleaseProfilingLockKHR(VkDevice device)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanKHRGetSurfaceCapabilities2
        {
            private IntPtr vkGetPhysicalDeviceSurfaceCapabilities2KHR_ptr;
            private IntPtr vkGetPhysicalDeviceSurfaceFormats2KHR_ptr;

            public VulkanKHRGetSurfaceCapabilities2(VkInstance instance)
            {
                vkGetPhysicalDeviceSurfaceCapabilities2KHR_ptr = LoadInstanceProcAddr(instance, "vkGetPhysicalDeviceSurfaceCapabilities2KHR");
                vkGetPhysicalDeviceSurfaceFormats2KHR_ptr = LoadInstanceProcAddr(instance, "vkGetPhysicalDeviceSurfaceFormats2KHR");
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSurfaceCapabilities2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, VkSurfaceCapabilities2KHR* pSurfaceCapabilities)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSurfaceCapabilities2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, out VkSurfaceCapabilities2KHR pSurfaceCapabilities)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSurfaceCapabilities2KHR(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, VkSurfaceCapabilities2KHR* pSurfaceCapabilities)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSurfaceCapabilities2KHR(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, out VkSurfaceCapabilities2KHR pSurfaceCapabilities)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSurfaceCapabilities2KHR(VkPhysicalDevice physicalDevice, IntPtr pSurfaceInfo, VkSurfaceCapabilities2KHR* pSurfaceCapabilities)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSurfaceCapabilities2KHR(VkPhysicalDevice physicalDevice, IntPtr pSurfaceInfo, out VkSurfaceCapabilities2KHR pSurfaceCapabilities)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, uint* pSurfaceFormatCount, VkSurfaceFormat2KHR* pSurfaceFormats)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, uint* pSurfaceFormatCount, out VkSurfaceFormat2KHR pSurfaceFormats)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, ref uint pSurfaceFormatCount, VkSurfaceFormat2KHR* pSurfaceFormats)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, ref uint pSurfaceFormatCount, out VkSurfaceFormat2KHR pSurfaceFormats)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, IntPtr pSurfaceFormatCount, VkSurfaceFormat2KHR* pSurfaceFormats)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, IntPtr pSurfaceFormatCount, out VkSurfaceFormat2KHR pSurfaceFormats)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, uint* pSurfaceFormatCount, VkSurfaceFormat2KHR* pSurfaceFormats)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, uint* pSurfaceFormatCount, out VkSurfaceFormat2KHR pSurfaceFormats)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, ref uint pSurfaceFormatCount, VkSurfaceFormat2KHR* pSurfaceFormats)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, ref uint pSurfaceFormatCount, out VkSurfaceFormat2KHR pSurfaceFormats)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, IntPtr pSurfaceFormatCount, VkSurfaceFormat2KHR* pSurfaceFormats)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, IntPtr pSurfaceFormatCount, out VkSurfaceFormat2KHR pSurfaceFormats)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, IntPtr pSurfaceInfo, uint* pSurfaceFormatCount, VkSurfaceFormat2KHR* pSurfaceFormats)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, IntPtr pSurfaceInfo, uint* pSurfaceFormatCount, out VkSurfaceFormat2KHR pSurfaceFormats)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, IntPtr pSurfaceInfo, ref uint pSurfaceFormatCount, VkSurfaceFormat2KHR* pSurfaceFormats)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, IntPtr pSurfaceInfo, ref uint pSurfaceFormatCount, out VkSurfaceFormat2KHR pSurfaceFormats)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, IntPtr pSurfaceInfo, IntPtr pSurfaceFormatCount, VkSurfaceFormat2KHR* pSurfaceFormats)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, IntPtr pSurfaceInfo, IntPtr pSurfaceFormatCount, out VkSurfaceFormat2KHR pSurfaceFormats)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanKHRGetDisplayProperties2
        {
            private IntPtr vkGetDisplayModeProperties2KHR_ptr;
            private IntPtr vkGetDisplayPlaneCapabilities2KHR_ptr;
            private IntPtr vkGetPhysicalDeviceDisplayPlaneProperties2KHR_ptr;
            private IntPtr vkGetPhysicalDeviceDisplayProperties2KHR_ptr;

            public VulkanKHRGetDisplayProperties2(VkInstance instance)
            {
                vkGetDisplayModeProperties2KHR_ptr = LoadInstanceProcAddr(instance, "vkGetDisplayModeProperties2KHR");
                vkGetDisplayPlaneCapabilities2KHR_ptr = LoadInstanceProcAddr(instance, "vkGetDisplayPlaneCapabilities2KHR");
                vkGetPhysicalDeviceDisplayPlaneProperties2KHR_ptr = LoadInstanceProcAddr(instance, "vkGetPhysicalDeviceDisplayPlaneProperties2KHR");
                vkGetPhysicalDeviceDisplayProperties2KHR_ptr = LoadInstanceProcAddr(instance, "vkGetPhysicalDeviceDisplayProperties2KHR");
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetDisplayModeProperties2KHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, uint* pPropertyCount, VkDisplayModeProperties2KHR* pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetDisplayModeProperties2KHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, uint* pPropertyCount, out VkDisplayModeProperties2KHR pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetDisplayModeProperties2KHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, ref uint pPropertyCount, VkDisplayModeProperties2KHR* pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetDisplayModeProperties2KHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, ref uint pPropertyCount, out VkDisplayModeProperties2KHR pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetDisplayModeProperties2KHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, IntPtr pPropertyCount, VkDisplayModeProperties2KHR* pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetDisplayModeProperties2KHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, IntPtr pPropertyCount, out VkDisplayModeProperties2KHR pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetDisplayPlaneCapabilities2KHR(VkPhysicalDevice physicalDevice, VkDisplayPlaneInfo2KHR* pDisplayPlaneInfo, VkDisplayPlaneCapabilities2KHR* pCapabilities)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetDisplayPlaneCapabilities2KHR(VkPhysicalDevice physicalDevice, VkDisplayPlaneInfo2KHR* pDisplayPlaneInfo, out VkDisplayPlaneCapabilities2KHR pCapabilities)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetDisplayPlaneCapabilities2KHR(VkPhysicalDevice physicalDevice, ref VkDisplayPlaneInfo2KHR pDisplayPlaneInfo, VkDisplayPlaneCapabilities2KHR* pCapabilities)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetDisplayPlaneCapabilities2KHR(VkPhysicalDevice physicalDevice, ref VkDisplayPlaneInfo2KHR pDisplayPlaneInfo, out VkDisplayPlaneCapabilities2KHR pCapabilities)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetDisplayPlaneCapabilities2KHR(VkPhysicalDevice physicalDevice, IntPtr pDisplayPlaneInfo, VkDisplayPlaneCapabilities2KHR* pCapabilities)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetDisplayPlaneCapabilities2KHR(VkPhysicalDevice physicalDevice, IntPtr pDisplayPlaneInfo, out VkDisplayPlaneCapabilities2KHR pCapabilities)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceDisplayPlaneProperties2KHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayPlaneProperties2KHR* pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceDisplayPlaneProperties2KHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, out VkDisplayPlaneProperties2KHR pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceDisplayPlaneProperties2KHR(VkPhysicalDevice physicalDevice, ref uint pPropertyCount, VkDisplayPlaneProperties2KHR* pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceDisplayPlaneProperties2KHR(VkPhysicalDevice physicalDevice, ref uint pPropertyCount, out VkDisplayPlaneProperties2KHR pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceDisplayPlaneProperties2KHR(VkPhysicalDevice physicalDevice, IntPtr pPropertyCount, VkDisplayPlaneProperties2KHR* pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceDisplayPlaneProperties2KHR(VkPhysicalDevice physicalDevice, IntPtr pPropertyCount, out VkDisplayPlaneProperties2KHR pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceDisplayProperties2KHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayProperties2KHR* pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceDisplayProperties2KHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, out VkDisplayProperties2KHR pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceDisplayProperties2KHR(VkPhysicalDevice physicalDevice, ref uint pPropertyCount, VkDisplayProperties2KHR* pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceDisplayProperties2KHR(VkPhysicalDevice physicalDevice, ref uint pPropertyCount, out VkDisplayProperties2KHR pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceDisplayProperties2KHR(VkPhysicalDevice physicalDevice, IntPtr pPropertyCount, VkDisplayProperties2KHR* pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceDisplayProperties2KHR(VkPhysicalDevice physicalDevice, IntPtr pPropertyCount, out VkDisplayProperties2KHR pProperties)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanMvkIosSurface
        {
            private IntPtr vkCreateIOSSurfaceMVK_ptr;

            public VulkanMvkIosSurface(VkInstance instance)
            {
                vkCreateIOSSurfaceMVK_ptr = LoadInstanceProcAddr(instance, "vkCreateIOSSurfaceMVK");
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateIOSSurfaceMVK(VkInstance instance, VkIOSSurfaceCreateInfoMVK* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateIOSSurfaceMVK(VkInstance instance, VkIOSSurfaceCreateInfoMVK* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateIOSSurfaceMVK(VkInstance instance, VkIOSSurfaceCreateInfoMVK* pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateIOSSurfaceMVK(VkInstance instance, VkIOSSurfaceCreateInfoMVK* pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateIOSSurfaceMVK(VkInstance instance, VkIOSSurfaceCreateInfoMVK* pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateIOSSurfaceMVK(VkInstance instance, VkIOSSurfaceCreateInfoMVK* pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateIOSSurfaceMVK(VkInstance instance, ref VkIOSSurfaceCreateInfoMVK pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateIOSSurfaceMVK(VkInstance instance, ref VkIOSSurfaceCreateInfoMVK pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateIOSSurfaceMVK(VkInstance instance, ref VkIOSSurfaceCreateInfoMVK pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateIOSSurfaceMVK(VkInstance instance, ref VkIOSSurfaceCreateInfoMVK pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateIOSSurfaceMVK(VkInstance instance, ref VkIOSSurfaceCreateInfoMVK pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateIOSSurfaceMVK(VkInstance instance, ref VkIOSSurfaceCreateInfoMVK pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateIOSSurfaceMVK(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateIOSSurfaceMVK(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateIOSSurfaceMVK(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateIOSSurfaceMVK(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateIOSSurfaceMVK(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateIOSSurfaceMVK(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanMvkMacosSurface
        {
            private IntPtr vkCreateMacOSSurfaceMVK_ptr;

            public VulkanMvkMacosSurface(VkInstance instance)
            {
                vkCreateMacOSSurfaceMVK_ptr = LoadInstanceProcAddr(instance, "vkCreateMacOSSurfaceMVK");
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateMacOSSurfaceMVK(VkInstance instance, VkMacOSSurfaceCreateInfoMVK* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateMacOSSurfaceMVK(VkInstance instance, VkMacOSSurfaceCreateInfoMVK* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateMacOSSurfaceMVK(VkInstance instance, VkMacOSSurfaceCreateInfoMVK* pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateMacOSSurfaceMVK(VkInstance instance, VkMacOSSurfaceCreateInfoMVK* pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateMacOSSurfaceMVK(VkInstance instance, VkMacOSSurfaceCreateInfoMVK* pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateMacOSSurfaceMVK(VkInstance instance, VkMacOSSurfaceCreateInfoMVK* pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateMacOSSurfaceMVK(VkInstance instance, ref VkMacOSSurfaceCreateInfoMVK pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateMacOSSurfaceMVK(VkInstance instance, ref VkMacOSSurfaceCreateInfoMVK pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateMacOSSurfaceMVK(VkInstance instance, ref VkMacOSSurfaceCreateInfoMVK pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateMacOSSurfaceMVK(VkInstance instance, ref VkMacOSSurfaceCreateInfoMVK pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateMacOSSurfaceMVK(VkInstance instance, ref VkMacOSSurfaceCreateInfoMVK pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateMacOSSurfaceMVK(VkInstance instance, ref VkMacOSSurfaceCreateInfoMVK pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateMacOSSurfaceMVK(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateMacOSSurfaceMVK(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateMacOSSurfaceMVK(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateMacOSSurfaceMVK(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateMacOSSurfaceMVK(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateMacOSSurfaceMVK(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanEXTDebugUtils
        {
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

            public VulkanEXTDebugUtils(VkInstance instance)
            {
                vkCmdBeginDebugUtilsLabelEXT_ptr = LoadInstanceProcAddr(instance, "vkCmdBeginDebugUtilsLabelEXT");
                vkCmdEndDebugUtilsLabelEXT_ptr = LoadInstanceProcAddr(instance, "vkCmdEndDebugUtilsLabelEXT");
                vkCmdInsertDebugUtilsLabelEXT_ptr = LoadInstanceProcAddr(instance, "vkCmdInsertDebugUtilsLabelEXT");
                vkCreateDebugUtilsMessengerEXT_ptr = LoadInstanceProcAddr(instance, "vkCreateDebugUtilsMessengerEXT");
                vkDestroyDebugUtilsMessengerEXT_ptr = LoadInstanceProcAddr(instance, "vkDestroyDebugUtilsMessengerEXT");
                vkQueueBeginDebugUtilsLabelEXT_ptr = LoadInstanceProcAddr(instance, "vkQueueBeginDebugUtilsLabelEXT");
                vkQueueEndDebugUtilsLabelEXT_ptr = LoadInstanceProcAddr(instance, "vkQueueEndDebugUtilsLabelEXT");
                vkQueueInsertDebugUtilsLabelEXT_ptr = LoadInstanceProcAddr(instance, "vkQueueInsertDebugUtilsLabelEXT");
                vkSetDebugUtilsObjectNameEXT_ptr = LoadInstanceProcAddr(instance, "vkSetDebugUtilsObjectNameEXT");
                vkSetDebugUtilsObjectTagEXT_ptr = LoadInstanceProcAddr(instance, "vkSetDebugUtilsObjectTagEXT");
                vkSubmitDebugUtilsMessageEXT_ptr = LoadInstanceProcAddr(instance, "vkSubmitDebugUtilsMessageEXT");
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBeginDebugUtilsLabelEXT(VkCommandBuffer commandBuffer, VkDebugUtilsLabelEXT* pLabelInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBeginDebugUtilsLabelEXT(VkCommandBuffer commandBuffer, ref VkDebugUtilsLabelEXT pLabelInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBeginDebugUtilsLabelEXT(VkCommandBuffer commandBuffer, IntPtr pLabelInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdEndDebugUtilsLabelEXT(VkCommandBuffer commandBuffer)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdInsertDebugUtilsLabelEXT(VkCommandBuffer commandBuffer, VkDebugUtilsLabelEXT* pLabelInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdInsertDebugUtilsLabelEXT(VkCommandBuffer commandBuffer, ref VkDebugUtilsLabelEXT pLabelInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdInsertDebugUtilsLabelEXT(VkCommandBuffer commandBuffer, IntPtr pLabelInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDebugUtilsMessengerEXT(VkInstance instance, VkDebugUtilsMessengerCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDebugUtilsMessengerEXT* pMessenger)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDebugUtilsMessengerEXT(VkInstance instance, VkDebugUtilsMessengerCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkDebugUtilsMessengerEXT pMessenger)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDebugUtilsMessengerEXT(VkInstance instance, VkDebugUtilsMessengerCreateInfoEXT* pCreateInfo, ref VkAllocationCallbacks pAllocator, VkDebugUtilsMessengerEXT* pMessenger)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDebugUtilsMessengerEXT(VkInstance instance, VkDebugUtilsMessengerCreateInfoEXT* pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkDebugUtilsMessengerEXT pMessenger)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDebugUtilsMessengerEXT(VkInstance instance, VkDebugUtilsMessengerCreateInfoEXT* pCreateInfo, IntPtr pAllocator, VkDebugUtilsMessengerEXT* pMessenger)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDebugUtilsMessengerEXT(VkInstance instance, VkDebugUtilsMessengerCreateInfoEXT* pCreateInfo, IntPtr pAllocator, out VkDebugUtilsMessengerEXT pMessenger)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDebugUtilsMessengerEXT(VkInstance instance, ref VkDebugUtilsMessengerCreateInfoEXT pCreateInfo, VkAllocationCallbacks* pAllocator, VkDebugUtilsMessengerEXT* pMessenger)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDebugUtilsMessengerEXT(VkInstance instance, ref VkDebugUtilsMessengerCreateInfoEXT pCreateInfo, VkAllocationCallbacks* pAllocator, out VkDebugUtilsMessengerEXT pMessenger)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDebugUtilsMessengerEXT(VkInstance instance, ref VkDebugUtilsMessengerCreateInfoEXT pCreateInfo, ref VkAllocationCallbacks pAllocator, VkDebugUtilsMessengerEXT* pMessenger)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDebugUtilsMessengerEXT(VkInstance instance, ref VkDebugUtilsMessengerCreateInfoEXT pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkDebugUtilsMessengerEXT pMessenger)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDebugUtilsMessengerEXT(VkInstance instance, ref VkDebugUtilsMessengerCreateInfoEXT pCreateInfo, IntPtr pAllocator, VkDebugUtilsMessengerEXT* pMessenger)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDebugUtilsMessengerEXT(VkInstance instance, ref VkDebugUtilsMessengerCreateInfoEXT pCreateInfo, IntPtr pAllocator, out VkDebugUtilsMessengerEXT pMessenger)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDebugUtilsMessengerEXT(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, VkDebugUtilsMessengerEXT* pMessenger)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDebugUtilsMessengerEXT(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, out VkDebugUtilsMessengerEXT pMessenger)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDebugUtilsMessengerEXT(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, VkDebugUtilsMessengerEXT* pMessenger)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDebugUtilsMessengerEXT(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkDebugUtilsMessengerEXT pMessenger)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDebugUtilsMessengerEXT(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, VkDebugUtilsMessengerEXT* pMessenger)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDebugUtilsMessengerEXT(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, out VkDebugUtilsMessengerEXT pMessenger)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkDestroyDebugUtilsMessengerEXT(VkInstance instance, VkDebugUtilsMessengerEXT messenger, VkAllocationCallbacks* pAllocator)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkDestroyDebugUtilsMessengerEXT(VkInstance instance, VkDebugUtilsMessengerEXT messenger, ref VkAllocationCallbacks pAllocator)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkDestroyDebugUtilsMessengerEXT(VkInstance instance, VkDebugUtilsMessengerEXT messenger, IntPtr pAllocator)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkQueueBeginDebugUtilsLabelEXT(VkQueue queue, VkDebugUtilsLabelEXT* pLabelInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkQueueBeginDebugUtilsLabelEXT(VkQueue queue, ref VkDebugUtilsLabelEXT pLabelInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkQueueBeginDebugUtilsLabelEXT(VkQueue queue, IntPtr pLabelInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkQueueEndDebugUtilsLabelEXT(VkQueue queue)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkQueueInsertDebugUtilsLabelEXT(VkQueue queue, VkDebugUtilsLabelEXT* pLabelInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkQueueInsertDebugUtilsLabelEXT(VkQueue queue, ref VkDebugUtilsLabelEXT pLabelInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkQueueInsertDebugUtilsLabelEXT(VkQueue queue, IntPtr pLabelInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkSetDebugUtilsObjectNameEXT(VkDevice device, VkDebugUtilsObjectNameInfoEXT* pNameInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkSetDebugUtilsObjectNameEXT(VkDevice device, ref VkDebugUtilsObjectNameInfoEXT pNameInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkSetDebugUtilsObjectNameEXT(VkDevice device, IntPtr pNameInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkSetDebugUtilsObjectTagEXT(VkDevice device, VkDebugUtilsObjectTagInfoEXT* pTagInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkSetDebugUtilsObjectTagEXT(VkDevice device, ref VkDebugUtilsObjectTagInfoEXT pTagInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkSetDebugUtilsObjectTagEXT(VkDevice device, IntPtr pTagInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkSubmitDebugUtilsMessageEXT(VkInstance instance, VkDebugUtilsMessageSeverityFlagsEXT messageSeverity, VkDebugUtilsMessageTypeFlagsEXT messageTypes, VkDebugUtilsMessengerCallbackDataEXT* pCallbackData)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkSubmitDebugUtilsMessageEXT(VkInstance instance, VkDebugUtilsMessageSeverityFlagsEXT messageSeverity, VkDebugUtilsMessageTypeFlagsEXT messageTypes, ref VkDebugUtilsMessengerCallbackDataEXT pCallbackData)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkSubmitDebugUtilsMessageEXT(VkInstance instance, VkDebugUtilsMessageSeverityFlagsEXT messageSeverity, VkDebugUtilsMessageTypeFlagsEXT messageTypes, IntPtr pCallbackData)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanAndroidExternalMemoryAndroidHardwareBuffer
        {
            private IntPtr vkGetAndroidHardwareBufferPropertiesANDROID_ptr;
            private IntPtr vkGetMemoryAndroidHardwareBufferANDROID_ptr;

            public VulkanAndroidExternalMemoryAndroidHardwareBuffer(VkDevice device)
            {
                vkGetAndroidHardwareBufferPropertiesANDROID_ptr = LoadDeviceProcAddr(device, "vkGetAndroidHardwareBufferPropertiesANDROID");
                vkGetMemoryAndroidHardwareBufferANDROID_ptr = LoadDeviceProcAddr(device, "vkGetMemoryAndroidHardwareBufferANDROID");
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetAndroidHardwareBufferPropertiesANDROID(VkDevice device, Android.AHardwareBuffer* buffer, VkAndroidHardwareBufferPropertiesANDROID* pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetAndroidHardwareBufferPropertiesANDROID(VkDevice device, Android.AHardwareBuffer* buffer, out VkAndroidHardwareBufferPropertiesANDROID pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetAndroidHardwareBufferPropertiesANDROID(VkDevice device, ref Android.AHardwareBuffer buffer, VkAndroidHardwareBufferPropertiesANDROID* pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetAndroidHardwareBufferPropertiesANDROID(VkDevice device, ref Android.AHardwareBuffer buffer, out VkAndroidHardwareBufferPropertiesANDROID pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetAndroidHardwareBufferPropertiesANDROID(VkDevice device, IntPtr buffer, VkAndroidHardwareBufferPropertiesANDROID* pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetAndroidHardwareBufferPropertiesANDROID(VkDevice device, IntPtr buffer, out VkAndroidHardwareBufferPropertiesANDROID pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetMemoryAndroidHardwareBufferANDROID(VkDevice device, VkMemoryGetAndroidHardwareBufferInfoANDROID* pInfo, Android.AHardwareBuffer** pBuffer)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetMemoryAndroidHardwareBufferANDROID(VkDevice device, VkMemoryGetAndroidHardwareBufferInfoANDROID* pInfo, out Android.AHardwareBuffer* pBuffer)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetMemoryAndroidHardwareBufferANDROID(VkDevice device, ref VkMemoryGetAndroidHardwareBufferInfoANDROID pInfo, Android.AHardwareBuffer** pBuffer)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetMemoryAndroidHardwareBufferANDROID(VkDevice device, ref VkMemoryGetAndroidHardwareBufferInfoANDROID pInfo, out Android.AHardwareBuffer* pBuffer)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetMemoryAndroidHardwareBufferANDROID(VkDevice device, IntPtr pInfo, Android.AHardwareBuffer** pBuffer)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetMemoryAndroidHardwareBufferANDROID(VkDevice device, IntPtr pInfo, out Android.AHardwareBuffer* pBuffer)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanEXTSampleLocations
        {
            private IntPtr vkCmdSetSampleLocationsEXT_ptr;
            private IntPtr vkGetPhysicalDeviceMultisamplePropertiesEXT_ptr;

            public VulkanEXTSampleLocations(VkDevice device)
            {
                vkCmdSetSampleLocationsEXT_ptr = LoadDeviceProcAddr(device, "vkCmdSetSampleLocationsEXT");
                vkGetPhysicalDeviceMultisamplePropertiesEXT_ptr = LoadDeviceProcAddr(device, "vkGetPhysicalDeviceMultisamplePropertiesEXT");
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetSampleLocationsEXT(VkCommandBuffer commandBuffer, VkSampleLocationsInfoEXT* pSampleLocationsInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetSampleLocationsEXT(VkCommandBuffer commandBuffer, ref VkSampleLocationsInfoEXT pSampleLocationsInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetSampleLocationsEXT(VkCommandBuffer commandBuffer, IntPtr pSampleLocationsInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetPhysicalDeviceMultisamplePropertiesEXT(VkPhysicalDevice physicalDevice, VkSampleCountFlags samples, VkMultisamplePropertiesEXT* pMultisampleProperties)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetPhysicalDeviceMultisamplePropertiesEXT(VkPhysicalDevice physicalDevice, VkSampleCountFlags samples, out VkMultisamplePropertiesEXT pMultisampleProperties)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanKHRGetMemoryRequirements2
        {

            public VulkanKHRGetMemoryRequirements2(VkDevice device)
            {
            }

        }

        public unsafe sealed class VulkanKHRAccelerationStructure
        {
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

            public VulkanKHRAccelerationStructure(VkDevice device)
            {
                vkBuildAccelerationStructuresKHR_ptr = LoadDeviceProcAddr(device, "vkBuildAccelerationStructuresKHR");
                vkCmdBuildAccelerationStructuresIndirectKHR_ptr = LoadDeviceProcAddr(device, "vkCmdBuildAccelerationStructuresIndirectKHR");
                vkCmdBuildAccelerationStructuresKHR_ptr = LoadDeviceProcAddr(device, "vkCmdBuildAccelerationStructuresKHR");
                vkCmdCopyAccelerationStructureKHR_ptr = LoadDeviceProcAddr(device, "vkCmdCopyAccelerationStructureKHR");
                vkCmdCopyAccelerationStructureToMemoryKHR_ptr = LoadDeviceProcAddr(device, "vkCmdCopyAccelerationStructureToMemoryKHR");
                vkCmdCopyMemoryToAccelerationStructureKHR_ptr = LoadDeviceProcAddr(device, "vkCmdCopyMemoryToAccelerationStructureKHR");
                vkCmdWriteAccelerationStructuresPropertiesKHR_ptr = LoadDeviceProcAddr(device, "vkCmdWriteAccelerationStructuresPropertiesKHR");
                vkCopyAccelerationStructureKHR_ptr = LoadDeviceProcAddr(device, "vkCopyAccelerationStructureKHR");
                vkCopyAccelerationStructureToMemoryKHR_ptr = LoadDeviceProcAddr(device, "vkCopyAccelerationStructureToMemoryKHR");
                vkCopyMemoryToAccelerationStructureKHR_ptr = LoadDeviceProcAddr(device, "vkCopyMemoryToAccelerationStructureKHR");
                vkCreateAccelerationStructureKHR_ptr = LoadDeviceProcAddr(device, "vkCreateAccelerationStructureKHR");
                vkDestroyAccelerationStructureKHR_ptr = LoadDeviceProcAddr(device, "vkDestroyAccelerationStructureKHR");
                vkGetAccelerationStructureBuildSizesKHR_ptr = LoadDeviceProcAddr(device, "vkGetAccelerationStructureBuildSizesKHR");
                vkGetAccelerationStructureDeviceAddressKHR_ptr = LoadDeviceProcAddr(device, "vkGetAccelerationStructureDeviceAddressKHR");
                vkGetDeviceAccelerationStructureCompatibilityKHR_ptr = LoadDeviceProcAddr(device, "vkGetDeviceAccelerationStructureCompatibilityKHR");
                vkWriteAccelerationStructuresPropertiesKHR_ptr = LoadDeviceProcAddr(device, "vkWriteAccelerationStructuresPropertiesKHR");
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkBuildAccelerationStructuresKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, VkAccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkBuildAccelerationStructuresKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, ref VkAccelerationStructureBuildRangeInfoKHR* ppBuildRangeInfos)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkBuildAccelerationStructuresKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, IntPtr ppBuildRangeInfos)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkBuildAccelerationStructuresKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, VkAccelerationStructureBuildRangeInfoKHR*[] ppBuildRangeInfos)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkBuildAccelerationStructuresKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, VkAccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkBuildAccelerationStructuresKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, ref VkAccelerationStructureBuildRangeInfoKHR* ppBuildRangeInfos)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkBuildAccelerationStructuresKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, IntPtr ppBuildRangeInfos)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkBuildAccelerationStructuresKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, VkAccelerationStructureBuildRangeInfoKHR*[] ppBuildRangeInfos)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkBuildAccelerationStructuresKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, IntPtr pInfos, VkAccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkBuildAccelerationStructuresKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, IntPtr pInfos, ref VkAccelerationStructureBuildRangeInfoKHR* ppBuildRangeInfos)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkBuildAccelerationStructuresKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, IntPtr pInfos, IntPtr ppBuildRangeInfos)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkBuildAccelerationStructuresKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, IntPtr pInfos, VkAccelerationStructureBuildRangeInfoKHR*[] ppBuildRangeInfos)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkBuildAccelerationStructuresKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, VkAccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkBuildAccelerationStructuresKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, ref VkAccelerationStructureBuildRangeInfoKHR* ppBuildRangeInfos)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkBuildAccelerationStructuresKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, IntPtr ppBuildRangeInfos)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkBuildAccelerationStructuresKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, VkAccelerationStructureBuildRangeInfoKHR*[] ppBuildRangeInfos)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, ulong* pIndirectDeviceAddresses, uint* pIndirectStrides, uint** ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, ulong* pIndirectDeviceAddresses, uint* pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, ulong* pIndirectDeviceAddresses, uint* pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, ulong* pIndirectDeviceAddresses, ref uint pIndirectStrides, uint** ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, ulong* pIndirectDeviceAddresses, ref uint pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, ulong* pIndirectDeviceAddresses, ref uint pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, ulong* pIndirectDeviceAddresses, IntPtr pIndirectStrides, uint** ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, ulong* pIndirectDeviceAddresses, IntPtr pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, ulong* pIndirectDeviceAddresses, IntPtr pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, ref ulong pIndirectDeviceAddresses, uint* pIndirectStrides, uint** ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, ref ulong pIndirectDeviceAddresses, uint* pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, ref ulong pIndirectDeviceAddresses, uint* pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, ref ulong pIndirectDeviceAddresses, ref uint pIndirectStrides, uint** ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, ref ulong pIndirectDeviceAddresses, ref uint pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, ref ulong pIndirectDeviceAddresses, ref uint pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, ref ulong pIndirectDeviceAddresses, IntPtr pIndirectStrides, uint** ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, ref ulong pIndirectDeviceAddresses, IntPtr pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, ref ulong pIndirectDeviceAddresses, IntPtr pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, IntPtr pIndirectDeviceAddresses, uint* pIndirectStrides, uint** ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, IntPtr pIndirectDeviceAddresses, uint* pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, IntPtr pIndirectDeviceAddresses, uint* pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, IntPtr pIndirectDeviceAddresses, ref uint pIndirectStrides, uint** ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, IntPtr pIndirectDeviceAddresses, ref uint pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, IntPtr pIndirectDeviceAddresses, ref uint pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, IntPtr pIndirectDeviceAddresses, IntPtr pIndirectStrides, uint** ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, IntPtr pIndirectDeviceAddresses, IntPtr pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, IntPtr pIndirectDeviceAddresses, IntPtr pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, ulong* pIndirectDeviceAddresses, uint* pIndirectStrides, uint** ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, ulong* pIndirectDeviceAddresses, uint* pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, ulong* pIndirectDeviceAddresses, uint* pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, ulong* pIndirectDeviceAddresses, ref uint pIndirectStrides, uint** ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, ulong* pIndirectDeviceAddresses, ref uint pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, ulong* pIndirectDeviceAddresses, ref uint pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, ulong* pIndirectDeviceAddresses, IntPtr pIndirectStrides, uint** ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, ulong* pIndirectDeviceAddresses, IntPtr pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, ulong* pIndirectDeviceAddresses, IntPtr pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, ref ulong pIndirectDeviceAddresses, uint* pIndirectStrides, uint** ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, ref ulong pIndirectDeviceAddresses, uint* pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, ref ulong pIndirectDeviceAddresses, uint* pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, ref ulong pIndirectDeviceAddresses, ref uint pIndirectStrides, uint** ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, ref ulong pIndirectDeviceAddresses, ref uint pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, ref ulong pIndirectDeviceAddresses, ref uint pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, ref ulong pIndirectDeviceAddresses, IntPtr pIndirectStrides, uint** ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, ref ulong pIndirectDeviceAddresses, IntPtr pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, ref ulong pIndirectDeviceAddresses, IntPtr pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, IntPtr pIndirectDeviceAddresses, uint* pIndirectStrides, uint** ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, IntPtr pIndirectDeviceAddresses, uint* pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, IntPtr pIndirectDeviceAddresses, uint* pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, IntPtr pIndirectDeviceAddresses, ref uint pIndirectStrides, uint** ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, IntPtr pIndirectDeviceAddresses, ref uint pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, IntPtr pIndirectDeviceAddresses, ref uint pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, IntPtr pIndirectDeviceAddresses, IntPtr pIndirectStrides, uint** ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, IntPtr pIndirectDeviceAddresses, IntPtr pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, IntPtr pIndirectDeviceAddresses, IntPtr pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, ulong* pIndirectDeviceAddresses, uint* pIndirectStrides, uint** ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, ulong* pIndirectDeviceAddresses, uint* pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, ulong* pIndirectDeviceAddresses, uint* pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, ulong* pIndirectDeviceAddresses, ref uint pIndirectStrides, uint** ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, ulong* pIndirectDeviceAddresses, ref uint pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, ulong* pIndirectDeviceAddresses, ref uint pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, ulong* pIndirectDeviceAddresses, IntPtr pIndirectStrides, uint** ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, ulong* pIndirectDeviceAddresses, IntPtr pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, ulong* pIndirectDeviceAddresses, IntPtr pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, ref ulong pIndirectDeviceAddresses, uint* pIndirectStrides, uint** ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, ref ulong pIndirectDeviceAddresses, uint* pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, ref ulong pIndirectDeviceAddresses, uint* pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, ref ulong pIndirectDeviceAddresses, ref uint pIndirectStrides, uint** ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, ref ulong pIndirectDeviceAddresses, ref uint pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, ref ulong pIndirectDeviceAddresses, ref uint pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, ref ulong pIndirectDeviceAddresses, IntPtr pIndirectStrides, uint** ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, ref ulong pIndirectDeviceAddresses, IntPtr pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, ref ulong pIndirectDeviceAddresses, IntPtr pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, IntPtr pIndirectDeviceAddresses, uint* pIndirectStrides, uint** ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, IntPtr pIndirectDeviceAddresses, uint* pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, IntPtr pIndirectDeviceAddresses, uint* pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, IntPtr pIndirectDeviceAddresses, ref uint pIndirectStrides, uint** ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, IntPtr pIndirectDeviceAddresses, ref uint pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, IntPtr pIndirectDeviceAddresses, ref uint pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, IntPtr pIndirectDeviceAddresses, IntPtr pIndirectStrides, uint** ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, IntPtr pIndirectDeviceAddresses, IntPtr pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, IntPtr pIndirectDeviceAddresses, IntPtr pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, ulong* pIndirectDeviceAddresses, uint* pIndirectStrides, uint** ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, ulong* pIndirectDeviceAddresses, uint* pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, ulong* pIndirectDeviceAddresses, uint* pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, ulong* pIndirectDeviceAddresses, ref uint pIndirectStrides, uint** ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, ulong* pIndirectDeviceAddresses, ref uint pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, ulong* pIndirectDeviceAddresses, ref uint pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, ulong* pIndirectDeviceAddresses, IntPtr pIndirectStrides, uint** ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, ulong* pIndirectDeviceAddresses, IntPtr pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, ulong* pIndirectDeviceAddresses, IntPtr pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, ref ulong pIndirectDeviceAddresses, uint* pIndirectStrides, uint** ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, ref ulong pIndirectDeviceAddresses, uint* pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, ref ulong pIndirectDeviceAddresses, uint* pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, ref ulong pIndirectDeviceAddresses, ref uint pIndirectStrides, uint** ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, ref ulong pIndirectDeviceAddresses, ref uint pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, ref ulong pIndirectDeviceAddresses, ref uint pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, ref ulong pIndirectDeviceAddresses, IntPtr pIndirectStrides, uint** ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, ref ulong pIndirectDeviceAddresses, IntPtr pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, ref ulong pIndirectDeviceAddresses, IntPtr pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, IntPtr pIndirectDeviceAddresses, uint* pIndirectStrides, uint** ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, IntPtr pIndirectDeviceAddresses, uint* pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, IntPtr pIndirectDeviceAddresses, uint* pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, IntPtr pIndirectDeviceAddresses, ref uint pIndirectStrides, uint** ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, IntPtr pIndirectDeviceAddresses, ref uint pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, IntPtr pIndirectDeviceAddresses, ref uint pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, IntPtr pIndirectDeviceAddresses, IntPtr pIndirectStrides, uint** ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, IntPtr pIndirectDeviceAddresses, IntPtr pIndirectStrides, ref uint* ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, IntPtr pIndirectDeviceAddresses, IntPtr pIndirectStrides, IntPtr ppMaxPrimitiveCounts)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, VkAccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, ref VkAccelerationStructureBuildRangeInfoKHR* ppBuildRangeInfos)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, IntPtr ppBuildRangeInfos)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, VkAccelerationStructureBuildRangeInfoKHR*[] ppBuildRangeInfos)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, VkAccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, ref VkAccelerationStructureBuildRangeInfoKHR* ppBuildRangeInfos)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, IntPtr ppBuildRangeInfos)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresKHR(VkCommandBuffer commandBuffer, uint infoCount, ref VkAccelerationStructureBuildGeometryInfoKHR pInfos, VkAccelerationStructureBuildRangeInfoKHR*[] ppBuildRangeInfos)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, VkAccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, ref VkAccelerationStructureBuildRangeInfoKHR* ppBuildRangeInfos)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, IntPtr ppBuildRangeInfos)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, VkAccelerationStructureBuildRangeInfoKHR*[] ppBuildRangeInfos)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, VkAccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, ref VkAccelerationStructureBuildRangeInfoKHR* ppBuildRangeInfos)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, IntPtr ppBuildRangeInfos)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructuresKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR[] pInfos, VkAccelerationStructureBuildRangeInfoKHR*[] ppBuildRangeInfos)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdCopyAccelerationStructureKHR(VkCommandBuffer commandBuffer, VkCopyAccelerationStructureInfoKHR* pInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdCopyAccelerationStructureKHR(VkCommandBuffer commandBuffer, ref VkCopyAccelerationStructureInfoKHR pInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdCopyAccelerationStructureKHR(VkCommandBuffer commandBuffer, IntPtr pInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdCopyAccelerationStructureToMemoryKHR(VkCommandBuffer commandBuffer, VkCopyAccelerationStructureToMemoryInfoKHR* pInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdCopyAccelerationStructureToMemoryKHR(VkCommandBuffer commandBuffer, ref VkCopyAccelerationStructureToMemoryInfoKHR pInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdCopyAccelerationStructureToMemoryKHR(VkCommandBuffer commandBuffer, IntPtr pInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdCopyMemoryToAccelerationStructureKHR(VkCommandBuffer commandBuffer, VkCopyMemoryToAccelerationStructureInfoKHR* pInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdCopyMemoryToAccelerationStructureKHR(VkCommandBuffer commandBuffer, ref VkCopyMemoryToAccelerationStructureInfoKHR pInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdCopyMemoryToAccelerationStructureKHR(VkCommandBuffer commandBuffer, IntPtr pInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdWriteAccelerationStructuresPropertiesKHR(VkCommandBuffer commandBuffer, uint accelerationStructureCount, VkAccelerationStructureKHR* pAccelerationStructures, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdWriteAccelerationStructuresPropertiesKHR(VkCommandBuffer commandBuffer, uint accelerationStructureCount, ref VkAccelerationStructureKHR pAccelerationStructures, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdWriteAccelerationStructuresPropertiesKHR(VkCommandBuffer commandBuffer, uint accelerationStructureCount, IntPtr pAccelerationStructures, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCopyAccelerationStructureKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyAccelerationStructureInfoKHR* pInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCopyAccelerationStructureKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, ref VkCopyAccelerationStructureInfoKHR pInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCopyAccelerationStructureKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, IntPtr pInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCopyAccelerationStructureToMemoryKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyAccelerationStructureToMemoryInfoKHR* pInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCopyAccelerationStructureToMemoryKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, ref VkCopyAccelerationStructureToMemoryInfoKHR pInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCopyAccelerationStructureToMemoryKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, IntPtr pInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCopyMemoryToAccelerationStructureKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyMemoryToAccelerationStructureInfoKHR* pInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCopyMemoryToAccelerationStructureKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, ref VkCopyMemoryToAccelerationStructureInfoKHR pInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCopyMemoryToAccelerationStructureKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, IntPtr pInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateAccelerationStructureKHR(VkDevice device, VkAccelerationStructureCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkAccelerationStructureKHR* pAccelerationStructure)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateAccelerationStructureKHR(VkDevice device, VkAccelerationStructureCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkAccelerationStructureKHR pAccelerationStructure)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateAccelerationStructureKHR(VkDevice device, VkAccelerationStructureCreateInfoKHR* pCreateInfo, ref VkAllocationCallbacks pAllocator, VkAccelerationStructureKHR* pAccelerationStructure)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateAccelerationStructureKHR(VkDevice device, VkAccelerationStructureCreateInfoKHR* pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkAccelerationStructureKHR pAccelerationStructure)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateAccelerationStructureKHR(VkDevice device, VkAccelerationStructureCreateInfoKHR* pCreateInfo, IntPtr pAllocator, VkAccelerationStructureKHR* pAccelerationStructure)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateAccelerationStructureKHR(VkDevice device, VkAccelerationStructureCreateInfoKHR* pCreateInfo, IntPtr pAllocator, out VkAccelerationStructureKHR pAccelerationStructure)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateAccelerationStructureKHR(VkDevice device, ref VkAccelerationStructureCreateInfoKHR pCreateInfo, VkAllocationCallbacks* pAllocator, VkAccelerationStructureKHR* pAccelerationStructure)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateAccelerationStructureKHR(VkDevice device, ref VkAccelerationStructureCreateInfoKHR pCreateInfo, VkAllocationCallbacks* pAllocator, out VkAccelerationStructureKHR pAccelerationStructure)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateAccelerationStructureKHR(VkDevice device, ref VkAccelerationStructureCreateInfoKHR pCreateInfo, ref VkAllocationCallbacks pAllocator, VkAccelerationStructureKHR* pAccelerationStructure)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateAccelerationStructureKHR(VkDevice device, ref VkAccelerationStructureCreateInfoKHR pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkAccelerationStructureKHR pAccelerationStructure)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateAccelerationStructureKHR(VkDevice device, ref VkAccelerationStructureCreateInfoKHR pCreateInfo, IntPtr pAllocator, VkAccelerationStructureKHR* pAccelerationStructure)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateAccelerationStructureKHR(VkDevice device, ref VkAccelerationStructureCreateInfoKHR pCreateInfo, IntPtr pAllocator, out VkAccelerationStructureKHR pAccelerationStructure)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateAccelerationStructureKHR(VkDevice device, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, VkAccelerationStructureKHR* pAccelerationStructure)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateAccelerationStructureKHR(VkDevice device, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, out VkAccelerationStructureKHR pAccelerationStructure)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateAccelerationStructureKHR(VkDevice device, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, VkAccelerationStructureKHR* pAccelerationStructure)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateAccelerationStructureKHR(VkDevice device, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkAccelerationStructureKHR pAccelerationStructure)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateAccelerationStructureKHR(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, VkAccelerationStructureKHR* pAccelerationStructure)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateAccelerationStructureKHR(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, out VkAccelerationStructureKHR pAccelerationStructure)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkDestroyAccelerationStructureKHR(VkDevice device, VkAccelerationStructureKHR accelerationStructure, VkAllocationCallbacks* pAllocator)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkDestroyAccelerationStructureKHR(VkDevice device, VkAccelerationStructureKHR accelerationStructure, ref VkAllocationCallbacks pAllocator)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkDestroyAccelerationStructureKHR(VkDevice device, VkAccelerationStructureKHR accelerationStructure, IntPtr pAllocator)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetAccelerationStructureBuildSizesKHR(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, VkAccelerationStructureBuildGeometryInfoKHR* pBuildInfo, uint* pMaxPrimitiveCounts, VkAccelerationStructureBuildSizesInfoKHR* pSizeInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetAccelerationStructureBuildSizesKHR(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, VkAccelerationStructureBuildGeometryInfoKHR* pBuildInfo, uint* pMaxPrimitiveCounts, out VkAccelerationStructureBuildSizesInfoKHR pSizeInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetAccelerationStructureBuildSizesKHR(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, VkAccelerationStructureBuildGeometryInfoKHR* pBuildInfo, ref uint pMaxPrimitiveCounts, VkAccelerationStructureBuildSizesInfoKHR* pSizeInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetAccelerationStructureBuildSizesKHR(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, VkAccelerationStructureBuildGeometryInfoKHR* pBuildInfo, ref uint pMaxPrimitiveCounts, out VkAccelerationStructureBuildSizesInfoKHR pSizeInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetAccelerationStructureBuildSizesKHR(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, VkAccelerationStructureBuildGeometryInfoKHR* pBuildInfo, IntPtr pMaxPrimitiveCounts, VkAccelerationStructureBuildSizesInfoKHR* pSizeInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetAccelerationStructureBuildSizesKHR(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, VkAccelerationStructureBuildGeometryInfoKHR* pBuildInfo, IntPtr pMaxPrimitiveCounts, out VkAccelerationStructureBuildSizesInfoKHR pSizeInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetAccelerationStructureBuildSizesKHR(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, ref VkAccelerationStructureBuildGeometryInfoKHR pBuildInfo, uint* pMaxPrimitiveCounts, VkAccelerationStructureBuildSizesInfoKHR* pSizeInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetAccelerationStructureBuildSizesKHR(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, ref VkAccelerationStructureBuildGeometryInfoKHR pBuildInfo, uint* pMaxPrimitiveCounts, out VkAccelerationStructureBuildSizesInfoKHR pSizeInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetAccelerationStructureBuildSizesKHR(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, ref VkAccelerationStructureBuildGeometryInfoKHR pBuildInfo, ref uint pMaxPrimitiveCounts, VkAccelerationStructureBuildSizesInfoKHR* pSizeInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetAccelerationStructureBuildSizesKHR(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, ref VkAccelerationStructureBuildGeometryInfoKHR pBuildInfo, ref uint pMaxPrimitiveCounts, out VkAccelerationStructureBuildSizesInfoKHR pSizeInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetAccelerationStructureBuildSizesKHR(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, ref VkAccelerationStructureBuildGeometryInfoKHR pBuildInfo, IntPtr pMaxPrimitiveCounts, VkAccelerationStructureBuildSizesInfoKHR* pSizeInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetAccelerationStructureBuildSizesKHR(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, ref VkAccelerationStructureBuildGeometryInfoKHR pBuildInfo, IntPtr pMaxPrimitiveCounts, out VkAccelerationStructureBuildSizesInfoKHR pSizeInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetAccelerationStructureBuildSizesKHR(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, IntPtr pBuildInfo, uint* pMaxPrimitiveCounts, VkAccelerationStructureBuildSizesInfoKHR* pSizeInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetAccelerationStructureBuildSizesKHR(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, IntPtr pBuildInfo, uint* pMaxPrimitiveCounts, out VkAccelerationStructureBuildSizesInfoKHR pSizeInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetAccelerationStructureBuildSizesKHR(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, IntPtr pBuildInfo, ref uint pMaxPrimitiveCounts, VkAccelerationStructureBuildSizesInfoKHR* pSizeInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetAccelerationStructureBuildSizesKHR(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, IntPtr pBuildInfo, ref uint pMaxPrimitiveCounts, out VkAccelerationStructureBuildSizesInfoKHR pSizeInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetAccelerationStructureBuildSizesKHR(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, IntPtr pBuildInfo, IntPtr pMaxPrimitiveCounts, VkAccelerationStructureBuildSizesInfoKHR* pSizeInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetAccelerationStructureBuildSizesKHR(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, IntPtr pBuildInfo, IntPtr pMaxPrimitiveCounts, out VkAccelerationStructureBuildSizesInfoKHR pSizeInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe ulong vkGetAccelerationStructureDeviceAddressKHR(VkDevice device, VkAccelerationStructureDeviceAddressInfoKHR* pInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe ulong vkGetAccelerationStructureDeviceAddressKHR(VkDevice device, out VkAccelerationStructureDeviceAddressInfoKHR pInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetDeviceAccelerationStructureCompatibilityKHR(VkDevice device, VkAccelerationStructureVersionInfoKHR* pVersionInfo, VkAccelerationStructureCompatibilityKHR* pCompatibility)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetDeviceAccelerationStructureCompatibilityKHR(VkDevice device, VkAccelerationStructureVersionInfoKHR* pVersionInfo, out VkAccelerationStructureCompatibilityKHR pCompatibility)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetDeviceAccelerationStructureCompatibilityKHR(VkDevice device, ref VkAccelerationStructureVersionInfoKHR pVersionInfo, VkAccelerationStructureCompatibilityKHR* pCompatibility)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetDeviceAccelerationStructureCompatibilityKHR(VkDevice device, ref VkAccelerationStructureVersionInfoKHR pVersionInfo, out VkAccelerationStructureCompatibilityKHR pCompatibility)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetDeviceAccelerationStructureCompatibilityKHR(VkDevice device, IntPtr pVersionInfo, VkAccelerationStructureCompatibilityKHR* pCompatibility)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetDeviceAccelerationStructureCompatibilityKHR(VkDevice device, IntPtr pVersionInfo, out VkAccelerationStructureCompatibilityKHR pCompatibility)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkWriteAccelerationStructuresPropertiesKHR(VkDevice device, uint accelerationStructureCount, VkAccelerationStructureKHR* pAccelerationStructures, VkQueryType queryType, UIntPtr dataSize, void* pData, UIntPtr stride)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkWriteAccelerationStructuresPropertiesKHR(VkDevice device, uint accelerationStructureCount, ref VkAccelerationStructureKHR pAccelerationStructures, VkQueryType queryType, UIntPtr dataSize, void* pData, UIntPtr stride)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkWriteAccelerationStructuresPropertiesKHR(VkDevice device, uint accelerationStructureCount, IntPtr pAccelerationStructures, VkQueryType queryType, UIntPtr dataSize, void* pData, UIntPtr stride)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanKHRRayTracingPipeline
        {
            private IntPtr vkCmdSetRayTracingPipelineStackSizeKHR_ptr;
            private IntPtr vkCmdTraceRaysIndirectKHR_ptr;
            private IntPtr vkCmdTraceRaysKHR_ptr;
            private IntPtr vkCreateRayTracingPipelinesKHR_ptr;
            private IntPtr vkGetRayTracingCaptureReplayShaderGroupHandlesKHR_ptr;
            private IntPtr vkGetRayTracingShaderGroupHandlesKHR_ptr;
            private IntPtr vkGetRayTracingShaderGroupStackSizeKHR_ptr;

            public VulkanKHRRayTracingPipeline(VkDevice device)
            {
                vkCmdSetRayTracingPipelineStackSizeKHR_ptr = LoadDeviceProcAddr(device, "vkCmdSetRayTracingPipelineStackSizeKHR");
                vkCmdTraceRaysIndirectKHR_ptr = LoadDeviceProcAddr(device, "vkCmdTraceRaysIndirectKHR");
                vkCmdTraceRaysKHR_ptr = LoadDeviceProcAddr(device, "vkCmdTraceRaysKHR");
                vkCreateRayTracingPipelinesKHR_ptr = LoadDeviceProcAddr(device, "vkCreateRayTracingPipelinesKHR");
                vkGetRayTracingCaptureReplayShaderGroupHandlesKHR_ptr = LoadDeviceProcAddr(device, "vkGetRayTracingCaptureReplayShaderGroupHandlesKHR");
                vkGetRayTracingShaderGroupHandlesKHR_ptr = LoadDeviceProcAddr(device, "vkGetRayTracingShaderGroupHandlesKHR");
                vkGetRayTracingShaderGroupStackSizeKHR_ptr = LoadDeviceProcAddr(device, "vkGetRayTracingShaderGroupStackSizeKHR");
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetRayTracingPipelineStackSizeKHR(VkCommandBuffer commandBuffer, uint pipelineStackSize)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, IntPtr pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, IntPtr pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, IntPtr pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, IntPtr pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, IntPtr pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, IntPtr pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, IntPtr pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, IntPtr pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, IntPtr pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, IntPtr pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, IntPtr pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, IntPtr pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, IntPtr pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, IntPtr pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, IntPtr pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, IntPtr pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, IntPtr pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, IntPtr pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, IntPtr pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, IntPtr pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, IntPtr pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, IntPtr pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, IntPtr pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, IntPtr pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, IntPtr pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, IntPtr pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, IntPtr pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, IntPtr pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, IntPtr pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, IntPtr pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, IntPtr pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, IntPtr pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, IntPtr pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, IntPtr pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, IntPtr pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, IntPtr pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, IntPtr pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, IntPtr pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, IntPtr pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, IntPtr pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, IntPtr pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, IntPtr pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, IntPtr pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, IntPtr pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, ref VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, IntPtr pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, IntPtr pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, IntPtr pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, IntPtr pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, IntPtr pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, IntPtr pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, IntPtr pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, IntPtr pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, IntPtr pHitShaderBindingTable, ref VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, IntPtr pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoKHR* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoKHR* pCreateInfos, VkAllocationCallbacks* pAllocator, out VkPipeline pPipelines)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoKHR* pCreateInfos, ref VkAllocationCallbacks pAllocator, VkPipeline* pPipelines)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoKHR* pCreateInfos, ref VkAllocationCallbacks pAllocator, out VkPipeline pPipelines)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoKHR* pCreateInfos, IntPtr pAllocator, VkPipeline* pPipelines)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoKHR* pCreateInfos, IntPtr pAllocator, out VkPipeline pPipelines)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, ref VkRayTracingPipelineCreateInfoKHR pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, ref VkRayTracingPipelineCreateInfoKHR pCreateInfos, VkAllocationCallbacks* pAllocator, out VkPipeline pPipelines)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, ref VkRayTracingPipelineCreateInfoKHR pCreateInfos, ref VkAllocationCallbacks pAllocator, VkPipeline* pPipelines)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, ref VkRayTracingPipelineCreateInfoKHR pCreateInfos, ref VkAllocationCallbacks pAllocator, out VkPipeline pPipelines)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, ref VkRayTracingPipelineCreateInfoKHR pCreateInfos, IntPtr pAllocator, VkPipeline* pPipelines)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, ref VkRayTracingPipelineCreateInfoKHR pCreateInfos, IntPtr pAllocator, out VkPipeline pPipelines)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, IntPtr pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, IntPtr pCreateInfos, VkAllocationCallbacks* pAllocator, out VkPipeline pPipelines)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, IntPtr pCreateInfos, ref VkAllocationCallbacks pAllocator, VkPipeline* pPipelines)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, IntPtr pCreateInfos, ref VkAllocationCallbacks pAllocator, out VkPipeline pPipelines)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, IntPtr pCreateInfos, IntPtr pAllocator, VkPipeline* pPipelines)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, IntPtr pCreateInfos, IntPtr pAllocator, out VkPipeline pPipelines)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoKHR[] pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoKHR[] pCreateInfos, VkAllocationCallbacks* pAllocator, out VkPipeline pPipelines)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoKHR[] pCreateInfos, ref VkAllocationCallbacks pAllocator, VkPipeline* pPipelines)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoKHR[] pCreateInfos, ref VkAllocationCallbacks pAllocator, out VkPipeline pPipelines)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoKHR[] pCreateInfos, IntPtr pAllocator, VkPipeline* pPipelines)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoKHR[] pCreateInfos, IntPtr pAllocator, out VkPipeline pPipelines)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetRayTracingCaptureReplayShaderGroupHandlesKHR(VkDevice device, VkPipeline pipeline, uint firstGroup, uint groupCount, UIntPtr dataSize, void* pData)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetRayTracingShaderGroupHandlesKHR(VkDevice device, VkPipeline pipeline, uint firstGroup, uint groupCount, UIntPtr dataSize, void* pData)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe ulong vkGetRayTracingShaderGroupStackSizeKHR(VkDevice device, VkPipeline pipeline, uint group, VkShaderGroupShaderKHR groupShader)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanKHRSamplerYcbcrConversion
        {

            public VulkanKHRSamplerYcbcrConversion(VkDevice device)
            {
            }

        }

        public unsafe sealed class VulkanKHRBindMemory2
        {

            public VulkanKHRBindMemory2(VkDevice device)
            {
            }

        }

        public unsafe sealed class VulkanEXTImageDrmFormatModifier
        {
            private IntPtr vkGetImageDrmFormatModifierPropertiesEXT_ptr;

            public VulkanEXTImageDrmFormatModifier(VkDevice device)
            {
                vkGetImageDrmFormatModifierPropertiesEXT_ptr = LoadDeviceProcAddr(device, "vkGetImageDrmFormatModifierPropertiesEXT");
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetImageDrmFormatModifierPropertiesEXT(VkDevice device, VkImage image, VkImageDrmFormatModifierPropertiesEXT* pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetImageDrmFormatModifierPropertiesEXT(VkDevice device, VkImage image, out VkImageDrmFormatModifierPropertiesEXT pProperties)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanEXTValidationCache
        {
            private IntPtr vkCreateValidationCacheEXT_ptr;
            private IntPtr vkDestroyValidationCacheEXT_ptr;
            private IntPtr vkGetValidationCacheDataEXT_ptr;
            private IntPtr vkMergeValidationCachesEXT_ptr;

            public VulkanEXTValidationCache(VkDevice device)
            {
                vkCreateValidationCacheEXT_ptr = LoadDeviceProcAddr(device, "vkCreateValidationCacheEXT");
                vkDestroyValidationCacheEXT_ptr = LoadDeviceProcAddr(device, "vkDestroyValidationCacheEXT");
                vkGetValidationCacheDataEXT_ptr = LoadDeviceProcAddr(device, "vkGetValidationCacheDataEXT");
                vkMergeValidationCachesEXT_ptr = LoadDeviceProcAddr(device, "vkMergeValidationCachesEXT");
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateValidationCacheEXT(VkDevice device, VkValidationCacheCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkValidationCacheEXT* pValidationCache)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateValidationCacheEXT(VkDevice device, VkValidationCacheCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkValidationCacheEXT pValidationCache)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateValidationCacheEXT(VkDevice device, VkValidationCacheCreateInfoEXT* pCreateInfo, ref VkAllocationCallbacks pAllocator, VkValidationCacheEXT* pValidationCache)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateValidationCacheEXT(VkDevice device, VkValidationCacheCreateInfoEXT* pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkValidationCacheEXT pValidationCache)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateValidationCacheEXT(VkDevice device, VkValidationCacheCreateInfoEXT* pCreateInfo, IntPtr pAllocator, VkValidationCacheEXT* pValidationCache)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateValidationCacheEXT(VkDevice device, VkValidationCacheCreateInfoEXT* pCreateInfo, IntPtr pAllocator, out VkValidationCacheEXT pValidationCache)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateValidationCacheEXT(VkDevice device, ref VkValidationCacheCreateInfoEXT pCreateInfo, VkAllocationCallbacks* pAllocator, VkValidationCacheEXT* pValidationCache)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateValidationCacheEXT(VkDevice device, ref VkValidationCacheCreateInfoEXT pCreateInfo, VkAllocationCallbacks* pAllocator, out VkValidationCacheEXT pValidationCache)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateValidationCacheEXT(VkDevice device, ref VkValidationCacheCreateInfoEXT pCreateInfo, ref VkAllocationCallbacks pAllocator, VkValidationCacheEXT* pValidationCache)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateValidationCacheEXT(VkDevice device, ref VkValidationCacheCreateInfoEXT pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkValidationCacheEXT pValidationCache)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateValidationCacheEXT(VkDevice device, ref VkValidationCacheCreateInfoEXT pCreateInfo, IntPtr pAllocator, VkValidationCacheEXT* pValidationCache)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateValidationCacheEXT(VkDevice device, ref VkValidationCacheCreateInfoEXT pCreateInfo, IntPtr pAllocator, out VkValidationCacheEXT pValidationCache)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateValidationCacheEXT(VkDevice device, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, VkValidationCacheEXT* pValidationCache)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateValidationCacheEXT(VkDevice device, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, out VkValidationCacheEXT pValidationCache)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateValidationCacheEXT(VkDevice device, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, VkValidationCacheEXT* pValidationCache)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateValidationCacheEXT(VkDevice device, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkValidationCacheEXT pValidationCache)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateValidationCacheEXT(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, VkValidationCacheEXT* pValidationCache)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateValidationCacheEXT(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, out VkValidationCacheEXT pValidationCache)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkDestroyValidationCacheEXT(VkDevice device, VkValidationCacheEXT validationCache, VkAllocationCallbacks* pAllocator)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkDestroyValidationCacheEXT(VkDevice device, VkValidationCacheEXT validationCache, ref VkAllocationCallbacks pAllocator)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkDestroyValidationCacheEXT(VkDevice device, VkValidationCacheEXT validationCache, IntPtr pAllocator)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetValidationCacheDataEXT(VkDevice device, VkValidationCacheEXT validationCache, UIntPtr* pDataSize, void* pData)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetValidationCacheDataEXT(VkDevice device, VkValidationCacheEXT validationCache, ref UIntPtr pDataSize, void* pData)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetValidationCacheDataEXT(VkDevice device, VkValidationCacheEXT validationCache, IntPtr pDataSize, void* pData)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkMergeValidationCachesEXT(VkDevice device, VkValidationCacheEXT dstCache, uint srcCacheCount, VkValidationCacheEXT* pSrcCaches)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkMergeValidationCachesEXT(VkDevice device, VkValidationCacheEXT dstCache, uint srcCacheCount, ref VkValidationCacheEXT pSrcCaches)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkMergeValidationCachesEXT(VkDevice device, VkValidationCacheEXT dstCache, uint srcCacheCount, IntPtr pSrcCaches)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanNVShadingRateImage
        {
            private IntPtr vkCmdBindShadingRateImageNV_ptr;
            private IntPtr vkCmdSetCoarseSampleOrderNV_ptr;
            private IntPtr vkCmdSetViewportShadingRatePaletteNV_ptr;

            public VulkanNVShadingRateImage(VkDevice device)
            {
                vkCmdBindShadingRateImageNV_ptr = LoadDeviceProcAddr(device, "vkCmdBindShadingRateImageNV");
                vkCmdSetCoarseSampleOrderNV_ptr = LoadDeviceProcAddr(device, "vkCmdSetCoarseSampleOrderNV");
                vkCmdSetViewportShadingRatePaletteNV_ptr = LoadDeviceProcAddr(device, "vkCmdSetViewportShadingRatePaletteNV");
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBindShadingRateImageNV(VkCommandBuffer commandBuffer, VkImageView imageView, VkImageLayout imageLayout)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetCoarseSampleOrderNV(VkCommandBuffer commandBuffer, VkCoarseSampleOrderTypeNV sampleOrderType, uint customSampleOrderCount, VkCoarseSampleOrderCustomNV* pCustomSampleOrders)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetCoarseSampleOrderNV(VkCommandBuffer commandBuffer, VkCoarseSampleOrderTypeNV sampleOrderType, uint customSampleOrderCount, ref VkCoarseSampleOrderCustomNV pCustomSampleOrders)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetCoarseSampleOrderNV(VkCommandBuffer commandBuffer, VkCoarseSampleOrderTypeNV sampleOrderType, uint customSampleOrderCount, IntPtr pCustomSampleOrders)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetViewportShadingRatePaletteNV(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkShadingRatePaletteNV* pShadingRatePalettes)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetViewportShadingRatePaletteNV(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, ref VkShadingRatePaletteNV pShadingRatePalettes)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetViewportShadingRatePaletteNV(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, IntPtr pShadingRatePalettes)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanNVRayTracing
        {
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

            public VulkanNVRayTracing(VkDevice device)
            {
                vkBindAccelerationStructureMemoryNV_ptr = LoadDeviceProcAddr(device, "vkBindAccelerationStructureMemoryNV");
                vkCmdBuildAccelerationStructureNV_ptr = LoadDeviceProcAddr(device, "vkCmdBuildAccelerationStructureNV");
                vkCmdCopyAccelerationStructureNV_ptr = LoadDeviceProcAddr(device, "vkCmdCopyAccelerationStructureNV");
                vkCmdTraceRaysNV_ptr = LoadDeviceProcAddr(device, "vkCmdTraceRaysNV");
                vkCmdWriteAccelerationStructuresPropertiesNV_ptr = LoadDeviceProcAddr(device, "vkCmdWriteAccelerationStructuresPropertiesNV");
                vkCompileDeferredNV_ptr = LoadDeviceProcAddr(device, "vkCompileDeferredNV");
                vkCreateAccelerationStructureNV_ptr = LoadDeviceProcAddr(device, "vkCreateAccelerationStructureNV");
                vkCreateRayTracingPipelinesNV_ptr = LoadDeviceProcAddr(device, "vkCreateRayTracingPipelinesNV");
                vkDestroyAccelerationStructureNV_ptr = LoadDeviceProcAddr(device, "vkDestroyAccelerationStructureNV");
                vkGetAccelerationStructureHandleNV_ptr = LoadDeviceProcAddr(device, "vkGetAccelerationStructureHandleNV");
                vkGetAccelerationStructureMemoryRequirementsNV_ptr = LoadDeviceProcAddr(device, "vkGetAccelerationStructureMemoryRequirementsNV");
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkBindAccelerationStructureMemoryNV(VkDevice device, uint bindInfoCount, VkBindAccelerationStructureMemoryInfoNV* pBindInfos)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkBindAccelerationStructureMemoryNV(VkDevice device, uint bindInfoCount, ref VkBindAccelerationStructureMemoryInfoNV pBindInfos)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkBindAccelerationStructureMemoryNV(VkDevice device, uint bindInfoCount, IntPtr pBindInfos)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkBindAccelerationStructureMemoryNV(VkDevice device, uint bindInfoCount, VkBindAccelerationStructureMemoryInfoNV[] pBindInfos)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructureNV(VkCommandBuffer commandBuffer, VkAccelerationStructureInfoNV* pInfo, VkBuffer instanceData, ulong instanceOffset, VkBool32 update, VkAccelerationStructureNV dst, VkAccelerationStructureNV src, VkBuffer scratch, ulong scratchOffset)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructureNV(VkCommandBuffer commandBuffer, ref VkAccelerationStructureInfoNV pInfo, VkBuffer instanceData, ulong instanceOffset, VkBool32 update, VkAccelerationStructureNV dst, VkAccelerationStructureNV src, VkBuffer scratch, ulong scratchOffset)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildAccelerationStructureNV(VkCommandBuffer commandBuffer, IntPtr pInfo, VkBuffer instanceData, ulong instanceOffset, VkBool32 update, VkAccelerationStructureNV dst, VkAccelerationStructureNV src, VkBuffer scratch, ulong scratchOffset)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdCopyAccelerationStructureNV(VkCommandBuffer commandBuffer, VkAccelerationStructureNV dst, VkAccelerationStructureNV src, VkCopyAccelerationStructureModeKHR mode)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysNV(VkCommandBuffer commandBuffer, VkBuffer raygenShaderBindingTableBuffer, ulong raygenShaderBindingOffset, VkBuffer missShaderBindingTableBuffer, ulong missShaderBindingOffset, ulong missShaderBindingStride, VkBuffer hitShaderBindingTableBuffer, ulong hitShaderBindingOffset, ulong hitShaderBindingStride, VkBuffer callableShaderBindingTableBuffer, ulong callableShaderBindingOffset, ulong callableShaderBindingStride, uint width, uint height, uint depth)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdWriteAccelerationStructuresPropertiesNV(VkCommandBuffer commandBuffer, uint accelerationStructureCount, VkAccelerationStructureNV* pAccelerationStructures, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdWriteAccelerationStructuresPropertiesNV(VkCommandBuffer commandBuffer, uint accelerationStructureCount, ref VkAccelerationStructureNV pAccelerationStructures, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdWriteAccelerationStructuresPropertiesNV(VkCommandBuffer commandBuffer, uint accelerationStructureCount, IntPtr pAccelerationStructures, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCompileDeferredNV(VkDevice device, VkPipeline pipeline, uint shader)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateAccelerationStructureNV(VkDevice device, VkAccelerationStructureCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, VkAccelerationStructureNV* pAccelerationStructure)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateAccelerationStructureNV(VkDevice device, VkAccelerationStructureCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkAccelerationStructureNV pAccelerationStructure)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateAccelerationStructureNV(VkDevice device, VkAccelerationStructureCreateInfoNV* pCreateInfo, ref VkAllocationCallbacks pAllocator, VkAccelerationStructureNV* pAccelerationStructure)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateAccelerationStructureNV(VkDevice device, VkAccelerationStructureCreateInfoNV* pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkAccelerationStructureNV pAccelerationStructure)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateAccelerationStructureNV(VkDevice device, VkAccelerationStructureCreateInfoNV* pCreateInfo, IntPtr pAllocator, VkAccelerationStructureNV* pAccelerationStructure)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateAccelerationStructureNV(VkDevice device, VkAccelerationStructureCreateInfoNV* pCreateInfo, IntPtr pAllocator, out VkAccelerationStructureNV pAccelerationStructure)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateAccelerationStructureNV(VkDevice device, ref VkAccelerationStructureCreateInfoNV pCreateInfo, VkAllocationCallbacks* pAllocator, VkAccelerationStructureNV* pAccelerationStructure)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateAccelerationStructureNV(VkDevice device, ref VkAccelerationStructureCreateInfoNV pCreateInfo, VkAllocationCallbacks* pAllocator, out VkAccelerationStructureNV pAccelerationStructure)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateAccelerationStructureNV(VkDevice device, ref VkAccelerationStructureCreateInfoNV pCreateInfo, ref VkAllocationCallbacks pAllocator, VkAccelerationStructureNV* pAccelerationStructure)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateAccelerationStructureNV(VkDevice device, ref VkAccelerationStructureCreateInfoNV pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkAccelerationStructureNV pAccelerationStructure)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateAccelerationStructureNV(VkDevice device, ref VkAccelerationStructureCreateInfoNV pCreateInfo, IntPtr pAllocator, VkAccelerationStructureNV* pAccelerationStructure)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateAccelerationStructureNV(VkDevice device, ref VkAccelerationStructureCreateInfoNV pCreateInfo, IntPtr pAllocator, out VkAccelerationStructureNV pAccelerationStructure)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateAccelerationStructureNV(VkDevice device, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, VkAccelerationStructureNV* pAccelerationStructure)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateAccelerationStructureNV(VkDevice device, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, out VkAccelerationStructureNV pAccelerationStructure)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateAccelerationStructureNV(VkDevice device, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, VkAccelerationStructureNV* pAccelerationStructure)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateAccelerationStructureNV(VkDevice device, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkAccelerationStructureNV pAccelerationStructure)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateAccelerationStructureNV(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, VkAccelerationStructureNV* pAccelerationStructure)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateAccelerationStructureNV(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, out VkAccelerationStructureNV pAccelerationStructure)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_SHADER_NV</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoNV* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_SHADER_NV</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoNV* pCreateInfos, VkAllocationCallbacks* pAllocator, out VkPipeline pPipelines)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_SHADER_NV</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoNV* pCreateInfos, ref VkAllocationCallbacks pAllocator, VkPipeline* pPipelines)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_SHADER_NV</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoNV* pCreateInfos, ref VkAllocationCallbacks pAllocator, out VkPipeline pPipelines)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_SHADER_NV</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoNV* pCreateInfos, IntPtr pAllocator, VkPipeline* pPipelines)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_SHADER_NV</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoNV* pCreateInfos, IntPtr pAllocator, out VkPipeline pPipelines)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_SHADER_NV</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, ref VkRayTracingPipelineCreateInfoNV pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_SHADER_NV</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, ref VkRayTracingPipelineCreateInfoNV pCreateInfos, VkAllocationCallbacks* pAllocator, out VkPipeline pPipelines)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_SHADER_NV</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, ref VkRayTracingPipelineCreateInfoNV pCreateInfos, ref VkAllocationCallbacks pAllocator, VkPipeline* pPipelines)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_SHADER_NV</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, ref VkRayTracingPipelineCreateInfoNV pCreateInfos, ref VkAllocationCallbacks pAllocator, out VkPipeline pPipelines)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_SHADER_NV</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, ref VkRayTracingPipelineCreateInfoNV pCreateInfos, IntPtr pAllocator, VkPipeline* pPipelines)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_SHADER_NV</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, ref VkRayTracingPipelineCreateInfoNV pCreateInfos, IntPtr pAllocator, out VkPipeline pPipelines)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_SHADER_NV</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, IntPtr pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_SHADER_NV</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, IntPtr pCreateInfos, VkAllocationCallbacks* pAllocator, out VkPipeline pPipelines)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_SHADER_NV</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, IntPtr pCreateInfos, ref VkAllocationCallbacks pAllocator, VkPipeline* pPipelines)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_SHADER_NV</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, IntPtr pCreateInfos, ref VkAllocationCallbacks pAllocator, out VkPipeline pPipelines)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_SHADER_NV</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, IntPtr pCreateInfos, IntPtr pAllocator, VkPipeline* pPipelines)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_SHADER_NV</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, IntPtr pCreateInfos, IntPtr pAllocator, out VkPipeline pPipelines)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_SHADER_NV</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoNV[] pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_SHADER_NV</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoNV[] pCreateInfos, VkAllocationCallbacks* pAllocator, out VkPipeline pPipelines)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_SHADER_NV</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoNV[] pCreateInfos, ref VkAllocationCallbacks pAllocator, VkPipeline* pPipelines)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_SHADER_NV</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoNV[] pCreateInfos, ref VkAllocationCallbacks pAllocator, out VkPipeline pPipelines)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_SHADER_NV</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoNV[] pCreateInfos, IntPtr pAllocator, VkPipeline* pPipelines)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_PIPELINE_COMPILE_REQUIRED_EXT. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INVALID_SHADER_NV</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoNV[] pCreateInfos, IntPtr pAllocator, out VkPipeline pPipelines)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkDestroyAccelerationStructureNV(VkDevice device, VkAccelerationStructureNV accelerationStructure, VkAllocationCallbacks* pAllocator)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkDestroyAccelerationStructureNV(VkDevice device, VkAccelerationStructureNV accelerationStructure, ref VkAllocationCallbacks pAllocator)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkDestroyAccelerationStructureNV(VkDevice device, VkAccelerationStructureNV accelerationStructure, IntPtr pAllocator)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetAccelerationStructureHandleNV(VkDevice device, VkAccelerationStructureNV accelerationStructure, UIntPtr dataSize, void* pData)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetAccelerationStructureMemoryRequirementsNV(VkDevice device, VkAccelerationStructureMemoryRequirementsInfoNV* pInfo, VkMemoryRequirements2* pMemoryRequirements)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetAccelerationStructureMemoryRequirementsNV(VkDevice device, VkAccelerationStructureMemoryRequirementsInfoNV* pInfo, out VkMemoryRequirements2 pMemoryRequirements)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetAccelerationStructureMemoryRequirementsNV(VkDevice device, ref VkAccelerationStructureMemoryRequirementsInfoNV pInfo, VkMemoryRequirements2* pMemoryRequirements)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetAccelerationStructureMemoryRequirementsNV(VkDevice device, ref VkAccelerationStructureMemoryRequirementsInfoNV pInfo, out VkMemoryRequirements2 pMemoryRequirements)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetAccelerationStructureMemoryRequirementsNV(VkDevice device, IntPtr pInfo, VkMemoryRequirements2* pMemoryRequirements)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetAccelerationStructureMemoryRequirementsNV(VkDevice device, IntPtr pInfo, out VkMemoryRequirements2 pMemoryRequirements)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanKHRMaintenance3
        {

            public VulkanKHRMaintenance3(VkDevice device)
            {
            }

        }

        public unsafe sealed class VulkanKHRDrawIndirectCount
        {

            public VulkanKHRDrawIndirectCount(VkDevice device)
            {
            }

        }

        public unsafe sealed class VulkanEXTExternalMemoryHost
        {
            private IntPtr vkGetMemoryHostPointerPropertiesEXT_ptr;

            public VulkanEXTExternalMemoryHost(VkDevice device)
            {
                vkGetMemoryHostPointerPropertiesEXT_ptr = LoadDeviceProcAddr(device, "vkGetMemoryHostPointerPropertiesEXT");
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetMemoryHostPointerPropertiesEXT(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, void* pHostPointer, VkMemoryHostPointerPropertiesEXT* pMemoryHostPointerProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetMemoryHostPointerPropertiesEXT(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, void* pHostPointer, out VkMemoryHostPointerPropertiesEXT pMemoryHostPointerProperties)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanAMDBufferMarker
        {
            private IntPtr vkCmdWriteBufferMarkerAMD_ptr;

            public VulkanAMDBufferMarker(VkDevice device)
            {
                vkCmdWriteBufferMarkerAMD_ptr = LoadDeviceProcAddr(device, "vkCmdWriteBufferMarkerAMD");
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdWriteBufferMarkerAMD(VkCommandBuffer commandBuffer, VkPipelineStageFlags pipelineStage, VkBuffer dstBuffer, ulong dstOffset, uint marker)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanEXTCalibratedTimestamps
        {
            private IntPtr vkGetCalibratedTimestampsEXT_ptr;
            private IntPtr vkGetPhysicalDeviceCalibrateableTimeDomainsEXT_ptr;

            public VulkanEXTCalibratedTimestamps(VkDevice device)
            {
                vkGetCalibratedTimestampsEXT_ptr = LoadDeviceProcAddr(device, "vkGetCalibratedTimestampsEXT");
                vkGetPhysicalDeviceCalibrateableTimeDomainsEXT_ptr = LoadDeviceProcAddr(device, "vkGetPhysicalDeviceCalibrateableTimeDomainsEXT");
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, VkCalibratedTimestampInfoEXT* pTimestampInfos, ulong* pTimestamps, ulong* pMaxDeviation)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, VkCalibratedTimestampInfoEXT* pTimestampInfos, ulong* pTimestamps, out ulong pMaxDeviation)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, VkCalibratedTimestampInfoEXT* pTimestampInfos, ref ulong pTimestamps, ulong* pMaxDeviation)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, VkCalibratedTimestampInfoEXT* pTimestampInfos, ref ulong pTimestamps, out ulong pMaxDeviation)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, VkCalibratedTimestampInfoEXT* pTimestampInfos, IntPtr pTimestamps, ulong* pMaxDeviation)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, VkCalibratedTimestampInfoEXT* pTimestampInfos, IntPtr pTimestamps, out ulong pMaxDeviation)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, ref VkCalibratedTimestampInfoEXT pTimestampInfos, ulong* pTimestamps, ulong* pMaxDeviation)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, ref VkCalibratedTimestampInfoEXT pTimestampInfos, ulong* pTimestamps, out ulong pMaxDeviation)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, ref VkCalibratedTimestampInfoEXT pTimestampInfos, ref ulong pTimestamps, ulong* pMaxDeviation)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, ref VkCalibratedTimestampInfoEXT pTimestampInfos, ref ulong pTimestamps, out ulong pMaxDeviation)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, ref VkCalibratedTimestampInfoEXT pTimestampInfos, IntPtr pTimestamps, ulong* pMaxDeviation)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, ref VkCalibratedTimestampInfoEXT pTimestampInfos, IntPtr pTimestamps, out ulong pMaxDeviation)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, IntPtr pTimestampInfos, ulong* pTimestamps, ulong* pMaxDeviation)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, IntPtr pTimestampInfos, ulong* pTimestamps, out ulong pMaxDeviation)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, IntPtr pTimestampInfos, ref ulong pTimestamps, ulong* pMaxDeviation)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, IntPtr pTimestampInfos, ref ulong pTimestamps, out ulong pMaxDeviation)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, IntPtr pTimestampInfos, IntPtr pTimestamps, ulong* pMaxDeviation)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, IntPtr pTimestampInfos, IntPtr pTimestamps, out ulong pMaxDeviation)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, VkCalibratedTimestampInfoEXT[] pTimestampInfos, ulong* pTimestamps, ulong* pMaxDeviation)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, VkCalibratedTimestampInfoEXT[] pTimestampInfos, ulong* pTimestamps, out ulong pMaxDeviation)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, VkCalibratedTimestampInfoEXT[] pTimestampInfos, ref ulong pTimestamps, ulong* pMaxDeviation)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, VkCalibratedTimestampInfoEXT[] pTimestampInfos, ref ulong pTimestamps, out ulong pMaxDeviation)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, VkCalibratedTimestampInfoEXT[] pTimestampInfos, IntPtr pTimestamps, ulong* pMaxDeviation)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, VkCalibratedTimestampInfoEXT[] pTimestampInfos, IntPtr pTimestamps, out ulong pMaxDeviation)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceCalibrateableTimeDomainsEXT(VkPhysicalDevice physicalDevice, uint* pTimeDomainCount, VkTimeDomainEXT* pTimeDomains)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceCalibrateableTimeDomainsEXT(VkPhysicalDevice physicalDevice, uint* pTimeDomainCount, out VkTimeDomainEXT pTimeDomains)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceCalibrateableTimeDomainsEXT(VkPhysicalDevice physicalDevice, ref uint pTimeDomainCount, VkTimeDomainEXT* pTimeDomains)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceCalibrateableTimeDomainsEXT(VkPhysicalDevice physicalDevice, ref uint pTimeDomainCount, out VkTimeDomainEXT pTimeDomains)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceCalibrateableTimeDomainsEXT(VkPhysicalDevice physicalDevice, IntPtr pTimeDomainCount, VkTimeDomainEXT* pTimeDomains)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceCalibrateableTimeDomainsEXT(VkPhysicalDevice physicalDevice, IntPtr pTimeDomainCount, out VkTimeDomainEXT pTimeDomains)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanNVMeshShader
        {
            private IntPtr vkCmdDrawMeshTasksIndirectCountNV_ptr;
            private IntPtr vkCmdDrawMeshTasksIndirectNV_ptr;
            private IntPtr vkCmdDrawMeshTasksNV_ptr;

            public VulkanNVMeshShader(VkDevice device)
            {
                vkCmdDrawMeshTasksIndirectCountNV_ptr = LoadDeviceProcAddr(device, "vkCmdDrawMeshTasksIndirectCountNV");
                vkCmdDrawMeshTasksIndirectNV_ptr = LoadDeviceProcAddr(device, "vkCmdDrawMeshTasksIndirectNV");
                vkCmdDrawMeshTasksNV_ptr = LoadDeviceProcAddr(device, "vkCmdDrawMeshTasksNV");
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdDrawMeshTasksIndirectCountNV(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdDrawMeshTasksIndirectNV(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, uint drawCount, uint stride)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdDrawMeshTasksNV(VkCommandBuffer commandBuffer, uint taskCount, uint firstTask)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanNVScissorExclusive
        {
            private IntPtr vkCmdSetExclusiveScissorNV_ptr;

            public VulkanNVScissorExclusive(VkDevice device)
            {
                vkCmdSetExclusiveScissorNV_ptr = LoadDeviceProcAddr(device, "vkCmdSetExclusiveScissorNV");
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetExclusiveScissorNV(VkCommandBuffer commandBuffer, uint firstExclusiveScissor, uint exclusiveScissorCount, VkRect2D* pExclusiveScissors)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetExclusiveScissorNV(VkCommandBuffer commandBuffer, uint firstExclusiveScissor, uint exclusiveScissorCount, ref VkRect2D pExclusiveScissors)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetExclusiveScissorNV(VkCommandBuffer commandBuffer, uint firstExclusiveScissor, uint exclusiveScissorCount, IntPtr pExclusiveScissors)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanNVDeviceDiagnosticCheckpoints
        {
            private IntPtr vkCmdSetCheckpointNV_ptr;
            private IntPtr vkGetQueueCheckpointDataNV_ptr;

            public VulkanNVDeviceDiagnosticCheckpoints(VkDevice device)
            {
                vkCmdSetCheckpointNV_ptr = LoadDeviceProcAddr(device, "vkCmdSetCheckpointNV");
                vkGetQueueCheckpointDataNV_ptr = LoadDeviceProcAddr(device, "vkGetQueueCheckpointDataNV");
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetCheckpointNV(VkCommandBuffer commandBuffer, void* pCheckpointMarker)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetQueueCheckpointDataNV(VkQueue queue, uint* pCheckpointDataCount, VkCheckpointDataNV* pCheckpointData)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetQueueCheckpointDataNV(VkQueue queue, uint* pCheckpointDataCount, out VkCheckpointDataNV pCheckpointData)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetQueueCheckpointDataNV(VkQueue queue, ref uint pCheckpointDataCount, VkCheckpointDataNV* pCheckpointData)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetQueueCheckpointDataNV(VkQueue queue, ref uint pCheckpointDataCount, out VkCheckpointDataNV pCheckpointData)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetQueueCheckpointDataNV(VkQueue queue, IntPtr pCheckpointDataCount, VkCheckpointDataNV* pCheckpointData)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetQueueCheckpointDataNV(VkQueue queue, IntPtr pCheckpointDataCount, out VkCheckpointDataNV pCheckpointData)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanKHRTimelineSemaphore
        {

            public VulkanKHRTimelineSemaphore(VkDevice device)
            {
            }

        }

        public unsafe sealed class VulkanIntelPerformanceQuery
        {
            private IntPtr vkAcquirePerformanceConfigurationINTEL_ptr;
            private IntPtr vkCmdSetPerformanceMarkerINTEL_ptr;
            private IntPtr vkCmdSetPerformanceOverrideINTEL_ptr;
            private IntPtr vkCmdSetPerformanceStreamMarkerINTEL_ptr;
            private IntPtr vkGetPerformanceParameterINTEL_ptr;
            private IntPtr vkInitializePerformanceApiINTEL_ptr;
            private IntPtr vkQueueSetPerformanceConfigurationINTEL_ptr;
            private IntPtr vkReleasePerformanceConfigurationINTEL_ptr;
            private IntPtr vkUninitializePerformanceApiINTEL_ptr;

            public VulkanIntelPerformanceQuery(VkDevice device)
            {
                vkAcquirePerformanceConfigurationINTEL_ptr = LoadDeviceProcAddr(device, "vkAcquirePerformanceConfigurationINTEL");
                vkCmdSetPerformanceMarkerINTEL_ptr = LoadDeviceProcAddr(device, "vkCmdSetPerformanceMarkerINTEL");
                vkCmdSetPerformanceOverrideINTEL_ptr = LoadDeviceProcAddr(device, "vkCmdSetPerformanceOverrideINTEL");
                vkCmdSetPerformanceStreamMarkerINTEL_ptr = LoadDeviceProcAddr(device, "vkCmdSetPerformanceStreamMarkerINTEL");
                vkGetPerformanceParameterINTEL_ptr = LoadDeviceProcAddr(device, "vkGetPerformanceParameterINTEL");
                vkInitializePerformanceApiINTEL_ptr = LoadDeviceProcAddr(device, "vkInitializePerformanceApiINTEL");
                vkQueueSetPerformanceConfigurationINTEL_ptr = LoadDeviceProcAddr(device, "vkQueueSetPerformanceConfigurationINTEL");
                vkReleasePerformanceConfigurationINTEL_ptr = LoadDeviceProcAddr(device, "vkReleasePerformanceConfigurationINTEL");
                vkUninitializePerformanceApiINTEL_ptr = LoadDeviceProcAddr(device, "vkUninitializePerformanceApiINTEL");
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkAcquirePerformanceConfigurationINTEL(VkDevice device, VkPerformanceConfigurationAcquireInfoINTEL* pAcquireInfo, VkPerformanceConfigurationINTEL* pConfiguration)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkAcquirePerformanceConfigurationINTEL(VkDevice device, VkPerformanceConfigurationAcquireInfoINTEL* pAcquireInfo, ref VkPerformanceConfigurationINTEL pConfiguration)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkAcquirePerformanceConfigurationINTEL(VkDevice device, VkPerformanceConfigurationAcquireInfoINTEL* pAcquireInfo, IntPtr pConfiguration)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkAcquirePerformanceConfigurationINTEL(VkDevice device, ref VkPerformanceConfigurationAcquireInfoINTEL pAcquireInfo, VkPerformanceConfigurationINTEL* pConfiguration)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkAcquirePerformanceConfigurationINTEL(VkDevice device, ref VkPerformanceConfigurationAcquireInfoINTEL pAcquireInfo, ref VkPerformanceConfigurationINTEL pConfiguration)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkAcquirePerformanceConfigurationINTEL(VkDevice device, ref VkPerformanceConfigurationAcquireInfoINTEL pAcquireInfo, IntPtr pConfiguration)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkAcquirePerformanceConfigurationINTEL(VkDevice device, IntPtr pAcquireInfo, VkPerformanceConfigurationINTEL* pConfiguration)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkAcquirePerformanceConfigurationINTEL(VkDevice device, IntPtr pAcquireInfo, ref VkPerformanceConfigurationINTEL pConfiguration)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkAcquirePerformanceConfigurationINTEL(VkDevice device, IntPtr pAcquireInfo, IntPtr pConfiguration)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCmdSetPerformanceMarkerINTEL(VkCommandBuffer commandBuffer, VkPerformanceMarkerInfoINTEL* pMarkerInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCmdSetPerformanceMarkerINTEL(VkCommandBuffer commandBuffer, ref VkPerformanceMarkerInfoINTEL pMarkerInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCmdSetPerformanceMarkerINTEL(VkCommandBuffer commandBuffer, IntPtr pMarkerInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCmdSetPerformanceOverrideINTEL(VkCommandBuffer commandBuffer, VkPerformanceOverrideInfoINTEL* pOverrideInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCmdSetPerformanceOverrideINTEL(VkCommandBuffer commandBuffer, ref VkPerformanceOverrideInfoINTEL pOverrideInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCmdSetPerformanceOverrideINTEL(VkCommandBuffer commandBuffer, IntPtr pOverrideInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCmdSetPerformanceStreamMarkerINTEL(VkCommandBuffer commandBuffer, VkPerformanceStreamMarkerInfoINTEL* pMarkerInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCmdSetPerformanceStreamMarkerINTEL(VkCommandBuffer commandBuffer, ref VkPerformanceStreamMarkerInfoINTEL pMarkerInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCmdSetPerformanceStreamMarkerINTEL(VkCommandBuffer commandBuffer, IntPtr pMarkerInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPerformanceParameterINTEL(VkDevice device, VkPerformanceParameterTypeINTEL parameter, VkPerformanceValueINTEL* pValue)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPerformanceParameterINTEL(VkDevice device, VkPerformanceParameterTypeINTEL parameter, out VkPerformanceValueINTEL pValue)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkInitializePerformanceApiINTEL(VkDevice device, VkInitializePerformanceApiInfoINTEL* pInitializeInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkInitializePerformanceApiINTEL(VkDevice device, ref VkInitializePerformanceApiInfoINTEL pInitializeInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkInitializePerformanceApiINTEL(VkDevice device, IntPtr pInitializeInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkQueueSetPerformanceConfigurationINTEL(VkQueue queue, VkPerformanceConfigurationINTEL configuration)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkReleasePerformanceConfigurationINTEL(VkDevice device, VkPerformanceConfigurationINTEL configuration)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkUninitializePerformanceApiINTEL(VkDevice device)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanAMDDisplayNativeHdr
        {
            private IntPtr vkSetLocalDimmingAMD_ptr;

            public VulkanAMDDisplayNativeHdr(VkDevice device)
            {
                vkSetLocalDimmingAMD_ptr = LoadDeviceProcAddr(device, "vkSetLocalDimmingAMD");
            }

            [Generator.CalliRewrite]
            public unsafe void vkSetLocalDimmingAMD(VkDevice device, VkSwapchainKHR swapChain, VkBool32 localDimmingEnable)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanFuchsiaImagepipeSurface
        {
            private IntPtr vkCreateImagePipeSurfaceFUCHSIA_ptr;

            public VulkanFuchsiaImagepipeSurface(VkInstance instance)
            {
                vkCreateImagePipeSurfaceFUCHSIA_ptr = LoadInstanceProcAddr(instance, "vkCreateImagePipeSurfaceFUCHSIA");
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateImagePipeSurfaceFUCHSIA(VkInstance instance, VkImagePipeSurfaceCreateInfoFUCHSIA* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateImagePipeSurfaceFUCHSIA(VkInstance instance, VkImagePipeSurfaceCreateInfoFUCHSIA* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateImagePipeSurfaceFUCHSIA(VkInstance instance, VkImagePipeSurfaceCreateInfoFUCHSIA* pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateImagePipeSurfaceFUCHSIA(VkInstance instance, VkImagePipeSurfaceCreateInfoFUCHSIA* pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateImagePipeSurfaceFUCHSIA(VkInstance instance, VkImagePipeSurfaceCreateInfoFUCHSIA* pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateImagePipeSurfaceFUCHSIA(VkInstance instance, VkImagePipeSurfaceCreateInfoFUCHSIA* pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateImagePipeSurfaceFUCHSIA(VkInstance instance, ref VkImagePipeSurfaceCreateInfoFUCHSIA pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateImagePipeSurfaceFUCHSIA(VkInstance instance, ref VkImagePipeSurfaceCreateInfoFUCHSIA pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateImagePipeSurfaceFUCHSIA(VkInstance instance, ref VkImagePipeSurfaceCreateInfoFUCHSIA pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateImagePipeSurfaceFUCHSIA(VkInstance instance, ref VkImagePipeSurfaceCreateInfoFUCHSIA pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateImagePipeSurfaceFUCHSIA(VkInstance instance, ref VkImagePipeSurfaceCreateInfoFUCHSIA pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateImagePipeSurfaceFUCHSIA(VkInstance instance, ref VkImagePipeSurfaceCreateInfoFUCHSIA pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateImagePipeSurfaceFUCHSIA(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateImagePipeSurfaceFUCHSIA(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateImagePipeSurfaceFUCHSIA(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateImagePipeSurfaceFUCHSIA(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateImagePipeSurfaceFUCHSIA(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateImagePipeSurfaceFUCHSIA(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanEXTMetalSurface
        {
            private IntPtr vkCreateMetalSurfaceEXT_ptr;

            public VulkanEXTMetalSurface(VkInstance instance)
            {
                vkCreateMetalSurfaceEXT_ptr = LoadInstanceProcAddr(instance, "vkCreateMetalSurfaceEXT");
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateMetalSurfaceEXT(VkInstance instance, VkMetalSurfaceCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateMetalSurfaceEXT(VkInstance instance, VkMetalSurfaceCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateMetalSurfaceEXT(VkInstance instance, VkMetalSurfaceCreateInfoEXT* pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateMetalSurfaceEXT(VkInstance instance, VkMetalSurfaceCreateInfoEXT* pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateMetalSurfaceEXT(VkInstance instance, VkMetalSurfaceCreateInfoEXT* pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateMetalSurfaceEXT(VkInstance instance, VkMetalSurfaceCreateInfoEXT* pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateMetalSurfaceEXT(VkInstance instance, ref VkMetalSurfaceCreateInfoEXT pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateMetalSurfaceEXT(VkInstance instance, ref VkMetalSurfaceCreateInfoEXT pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateMetalSurfaceEXT(VkInstance instance, ref VkMetalSurfaceCreateInfoEXT pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateMetalSurfaceEXT(VkInstance instance, ref VkMetalSurfaceCreateInfoEXT pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateMetalSurfaceEXT(VkInstance instance, ref VkMetalSurfaceCreateInfoEXT pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateMetalSurfaceEXT(VkInstance instance, ref VkMetalSurfaceCreateInfoEXT pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateMetalSurfaceEXT(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateMetalSurfaceEXT(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateMetalSurfaceEXT(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateMetalSurfaceEXT(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateMetalSurfaceEXT(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateMetalSurfaceEXT(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanKHRFragmentShadingRate
        {
            private IntPtr vkCmdSetFragmentShadingRateKHR_ptr;
            private IntPtr vkGetPhysicalDeviceFragmentShadingRatesKHR_ptr;

            public VulkanKHRFragmentShadingRate(VkDevice device)
            {
                vkCmdSetFragmentShadingRateKHR_ptr = LoadDeviceProcAddr(device, "vkCmdSetFragmentShadingRateKHR");
                vkGetPhysicalDeviceFragmentShadingRatesKHR_ptr = LoadDeviceProcAddr(device, "vkGetPhysicalDeviceFragmentShadingRatesKHR");
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetFragmentShadingRateKHR(VkCommandBuffer commandBuffer, VkExtent2D* pFragmentSize, VkFragmentShadingRateCombinerOpKHR combinerOps)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetFragmentShadingRateKHR(VkCommandBuffer commandBuffer, ref VkExtent2D pFragmentSize, VkFragmentShadingRateCombinerOpKHR combinerOps)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetFragmentShadingRateKHR(VkCommandBuffer commandBuffer, IntPtr pFragmentSize, VkFragmentShadingRateCombinerOpKHR combinerOps)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceFragmentShadingRatesKHR(VkPhysicalDevice physicalDevice, uint* pFragmentShadingRateCount, VkPhysicalDeviceFragmentShadingRateKHR* pFragmentShadingRates)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceFragmentShadingRatesKHR(VkPhysicalDevice physicalDevice, uint* pFragmentShadingRateCount, out VkPhysicalDeviceFragmentShadingRateKHR pFragmentShadingRates)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceFragmentShadingRatesKHR(VkPhysicalDevice physicalDevice, ref uint pFragmentShadingRateCount, VkPhysicalDeviceFragmentShadingRateKHR* pFragmentShadingRates)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceFragmentShadingRatesKHR(VkPhysicalDevice physicalDevice, ref uint pFragmentShadingRateCount, out VkPhysicalDeviceFragmentShadingRateKHR pFragmentShadingRates)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceFragmentShadingRatesKHR(VkPhysicalDevice physicalDevice, IntPtr pFragmentShadingRateCount, VkPhysicalDeviceFragmentShadingRateKHR* pFragmentShadingRates)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceFragmentShadingRatesKHR(VkPhysicalDevice physicalDevice, IntPtr pFragmentShadingRateCount, out VkPhysicalDeviceFragmentShadingRateKHR pFragmentShadingRates)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanEXTBufferDeviceAddress
        {

            public VulkanEXTBufferDeviceAddress(VkDevice device)
            {
            }

        }

        public unsafe sealed class VulkanEXTToolingInfo
        {

            public VulkanEXTToolingInfo(VkDevice device)
            {
            }

        }

        public unsafe sealed class VulkanKHRPresentWait
        {
            private IntPtr vkWaitForPresentKHR_ptr;

            public VulkanKHRPresentWait(VkDevice device)
            {
                vkWaitForPresentKHR_ptr = LoadDeviceProcAddr(device, "vkWaitForPresentKHR");
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_TIMEOUT, VK_SUBOPTIMAL_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_OUT_OF_DATE_KHR, VK_ERROR_SURFACE_LOST_KHR, VK_ERROR_FULL_SCREEN_EXCLUSIVE_MODE_LOST_EXT</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkWaitForPresentKHR(VkDevice device, VkSwapchainKHR swapchain, ulong presentId, ulong timeout)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanNVCooperativeMatrix
        {
            private IntPtr vkGetPhysicalDeviceCooperativeMatrixPropertiesNV_ptr;

            public VulkanNVCooperativeMatrix(VkDevice device)
            {
                vkGetPhysicalDeviceCooperativeMatrixPropertiesNV_ptr = LoadDeviceProcAddr(device, "vkGetPhysicalDeviceCooperativeMatrixPropertiesNV");
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceCooperativeMatrixPropertiesNV(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkCooperativeMatrixPropertiesNV* pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceCooperativeMatrixPropertiesNV(VkPhysicalDevice physicalDevice, uint* pPropertyCount, out VkCooperativeMatrixPropertiesNV pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceCooperativeMatrixPropertiesNV(VkPhysicalDevice physicalDevice, ref uint pPropertyCount, VkCooperativeMatrixPropertiesNV* pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceCooperativeMatrixPropertiesNV(VkPhysicalDevice physicalDevice, ref uint pPropertyCount, out VkCooperativeMatrixPropertiesNV pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceCooperativeMatrixPropertiesNV(VkPhysicalDevice physicalDevice, IntPtr pPropertyCount, VkCooperativeMatrixPropertiesNV* pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceCooperativeMatrixPropertiesNV(VkPhysicalDevice physicalDevice, IntPtr pPropertyCount, out VkCooperativeMatrixPropertiesNV pProperties)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanNVCoverageReductionMode
        {
            private IntPtr vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV_ptr;

            public VulkanNVCoverageReductionMode(VkDevice device)
            {
                vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV_ptr = LoadDeviceProcAddr(device, "vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV");
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV(VkPhysicalDevice physicalDevice, uint* pCombinationCount, VkFramebufferMixedSamplesCombinationNV* pCombinations)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV(VkPhysicalDevice physicalDevice, uint* pCombinationCount, out VkFramebufferMixedSamplesCombinationNV pCombinations)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV(VkPhysicalDevice physicalDevice, ref uint pCombinationCount, VkFramebufferMixedSamplesCombinationNV* pCombinations)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV(VkPhysicalDevice physicalDevice, ref uint pCombinationCount, out VkFramebufferMixedSamplesCombinationNV pCombinations)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV(VkPhysicalDevice physicalDevice, IntPtr pCombinationCount, VkFramebufferMixedSamplesCombinationNV* pCombinations)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV(VkPhysicalDevice physicalDevice, IntPtr pCombinationCount, out VkFramebufferMixedSamplesCombinationNV pCombinations)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanEXTFullScreenExclusive
        {
            private IntPtr vkAcquireFullScreenExclusiveModeEXT_ptr;
            private IntPtr vkGetDeviceGroupSurfacePresentModes2EXT_ptr;
            private IntPtr vkGetPhysicalDeviceSurfacePresentModes2EXT_ptr;
            private IntPtr vkReleaseFullScreenExclusiveModeEXT_ptr;

            public VulkanEXTFullScreenExclusive(VkDevice device)
            {
                vkAcquireFullScreenExclusiveModeEXT_ptr = LoadDeviceProcAddr(device, "vkAcquireFullScreenExclusiveModeEXT");
                vkGetDeviceGroupSurfacePresentModes2EXT_ptr = LoadDeviceProcAddr(device, "vkGetDeviceGroupSurfacePresentModes2EXT");
                vkGetPhysicalDeviceSurfacePresentModes2EXT_ptr = LoadDeviceProcAddr(device, "vkGetPhysicalDeviceSurfacePresentModes2EXT");
                vkReleaseFullScreenExclusiveModeEXT_ptr = LoadDeviceProcAddr(device, "vkReleaseFullScreenExclusiveModeEXT");
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkAcquireFullScreenExclusiveModeEXT(VkDevice device, VkSwapchainKHR swapchain)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetDeviceGroupSurfacePresentModes2EXT(VkDevice device, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, VkDeviceGroupPresentModeFlagsKHR* pModes)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetDeviceGroupSurfacePresentModes2EXT(VkDevice device, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, out VkDeviceGroupPresentModeFlagsKHR pModes)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetDeviceGroupSurfacePresentModes2EXT(VkDevice device, ref VkPhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, VkDeviceGroupPresentModeFlagsKHR* pModes)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetDeviceGroupSurfacePresentModes2EXT(VkDevice device, ref VkPhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, out VkDeviceGroupPresentModeFlagsKHR pModes)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetDeviceGroupSurfacePresentModes2EXT(VkDevice device, IntPtr pSurfaceInfo, VkDeviceGroupPresentModeFlagsKHR* pModes)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetDeviceGroupSurfacePresentModes2EXT(VkDevice device, IntPtr pSurfaceInfo, out VkDeviceGroupPresentModeFlagsKHR pModes)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSurfacePresentModes2EXT(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, uint* pPresentModeCount, VkPresentModeKHR* pPresentModes)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSurfacePresentModes2EXT(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, uint* pPresentModeCount, out VkPresentModeKHR pPresentModes)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSurfacePresentModes2EXT(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, ref uint pPresentModeCount, VkPresentModeKHR* pPresentModes)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSurfacePresentModes2EXT(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, ref uint pPresentModeCount, out VkPresentModeKHR pPresentModes)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSurfacePresentModes2EXT(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, IntPtr pPresentModeCount, VkPresentModeKHR* pPresentModes)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSurfacePresentModes2EXT(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, IntPtr pPresentModeCount, out VkPresentModeKHR pPresentModes)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSurfacePresentModes2EXT(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, uint* pPresentModeCount, VkPresentModeKHR* pPresentModes)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSurfacePresentModes2EXT(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, uint* pPresentModeCount, out VkPresentModeKHR pPresentModes)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSurfacePresentModes2EXT(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, ref uint pPresentModeCount, VkPresentModeKHR* pPresentModes)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSurfacePresentModes2EXT(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, ref uint pPresentModeCount, out VkPresentModeKHR pPresentModes)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSurfacePresentModes2EXT(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, IntPtr pPresentModeCount, VkPresentModeKHR* pPresentModes)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSurfacePresentModes2EXT(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, IntPtr pPresentModeCount, out VkPresentModeKHR pPresentModes)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSurfacePresentModes2EXT(VkPhysicalDevice physicalDevice, IntPtr pSurfaceInfo, uint* pPresentModeCount, VkPresentModeKHR* pPresentModes)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSurfacePresentModes2EXT(VkPhysicalDevice physicalDevice, IntPtr pSurfaceInfo, uint* pPresentModeCount, out VkPresentModeKHR pPresentModes)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSurfacePresentModes2EXT(VkPhysicalDevice physicalDevice, IntPtr pSurfaceInfo, ref uint pPresentModeCount, VkPresentModeKHR* pPresentModes)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSurfacePresentModes2EXT(VkPhysicalDevice physicalDevice, IntPtr pSurfaceInfo, ref uint pPresentModeCount, out VkPresentModeKHR pPresentModes)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSurfacePresentModes2EXT(VkPhysicalDevice physicalDevice, IntPtr pSurfaceInfo, IntPtr pPresentModeCount, VkPresentModeKHR* pPresentModes)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceSurfacePresentModes2EXT(VkPhysicalDevice physicalDevice, IntPtr pSurfaceInfo, IntPtr pPresentModeCount, out VkPresentModeKHR pPresentModes)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkReleaseFullScreenExclusiveModeEXT(VkDevice device, VkSwapchainKHR swapchain)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanEXTHeadlessSurface
        {
            private IntPtr vkCreateHeadlessSurfaceEXT_ptr;

            public VulkanEXTHeadlessSurface(VkInstance instance)
            {
                vkCreateHeadlessSurfaceEXT_ptr = LoadInstanceProcAddr(instance, "vkCreateHeadlessSurfaceEXT");
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateHeadlessSurfaceEXT(VkInstance instance, VkHeadlessSurfaceCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateHeadlessSurfaceEXT(VkInstance instance, VkHeadlessSurfaceCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateHeadlessSurfaceEXT(VkInstance instance, VkHeadlessSurfaceCreateInfoEXT* pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateHeadlessSurfaceEXT(VkInstance instance, VkHeadlessSurfaceCreateInfoEXT* pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateHeadlessSurfaceEXT(VkInstance instance, VkHeadlessSurfaceCreateInfoEXT* pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateHeadlessSurfaceEXT(VkInstance instance, VkHeadlessSurfaceCreateInfoEXT* pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateHeadlessSurfaceEXT(VkInstance instance, ref VkHeadlessSurfaceCreateInfoEXT pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateHeadlessSurfaceEXT(VkInstance instance, ref VkHeadlessSurfaceCreateInfoEXT pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateHeadlessSurfaceEXT(VkInstance instance, ref VkHeadlessSurfaceCreateInfoEXT pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateHeadlessSurfaceEXT(VkInstance instance, ref VkHeadlessSurfaceCreateInfoEXT pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateHeadlessSurfaceEXT(VkInstance instance, ref VkHeadlessSurfaceCreateInfoEXT pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateHeadlessSurfaceEXT(VkInstance instance, ref VkHeadlessSurfaceCreateInfoEXT pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateHeadlessSurfaceEXT(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateHeadlessSurfaceEXT(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateHeadlessSurfaceEXT(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateHeadlessSurfaceEXT(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateHeadlessSurfaceEXT(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateHeadlessSurfaceEXT(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanKHRBufferDeviceAddress
        {

            public VulkanKHRBufferDeviceAddress(VkDevice device)
            {
            }

        }

        public unsafe sealed class VulkanEXTLineRasterization
        {
            private IntPtr vkCmdSetLineStippleEXT_ptr;

            public VulkanEXTLineRasterization(VkDevice device)
            {
                vkCmdSetLineStippleEXT_ptr = LoadDeviceProcAddr(device, "vkCmdSetLineStippleEXT");
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetLineStippleEXT(VkCommandBuffer commandBuffer, uint lineStippleFactor, ushort lineStipplePattern)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanEXTHostQueryReset
        {

            public VulkanEXTHostQueryReset(VkDevice device)
            {
            }

        }

        public unsafe sealed class VulkanEXTExtendedDynamicState
        {

            public VulkanEXTExtendedDynamicState(VkDevice device)
            {
            }

        }

        public unsafe sealed class VulkanKHRDeferredHostOperations
        {
            private IntPtr vkCreateDeferredOperationKHR_ptr;
            private IntPtr vkDeferredOperationJoinKHR_ptr;
            private IntPtr vkDestroyDeferredOperationKHR_ptr;
            private IntPtr vkGetDeferredOperationMaxConcurrencyKHR_ptr;
            private IntPtr vkGetDeferredOperationResultKHR_ptr;

            public VulkanKHRDeferredHostOperations(VkDevice device)
            {
                vkCreateDeferredOperationKHR_ptr = LoadDeviceProcAddr(device, "vkCreateDeferredOperationKHR");
                vkDeferredOperationJoinKHR_ptr = LoadDeviceProcAddr(device, "vkDeferredOperationJoinKHR");
                vkDestroyDeferredOperationKHR_ptr = LoadDeviceProcAddr(device, "vkDestroyDeferredOperationKHR");
                vkGetDeferredOperationMaxConcurrencyKHR_ptr = LoadDeviceProcAddr(device, "vkGetDeferredOperationMaxConcurrencyKHR");
                vkGetDeferredOperationResultKHR_ptr = LoadDeviceProcAddr(device, "vkGetDeferredOperationResultKHR");
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDeferredOperationKHR(VkDevice device, VkAllocationCallbacks* pAllocator, VkDeferredOperationKHR* pDeferredOperation)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDeferredOperationKHR(VkDevice device, VkAllocationCallbacks* pAllocator, out VkDeferredOperationKHR pDeferredOperation)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDeferredOperationKHR(VkDevice device, ref VkAllocationCallbacks pAllocator, VkDeferredOperationKHR* pDeferredOperation)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDeferredOperationKHR(VkDevice device, ref VkAllocationCallbacks pAllocator, out VkDeferredOperationKHR pDeferredOperation)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDeferredOperationKHR(VkDevice device, IntPtr pAllocator, VkDeferredOperationKHR* pDeferredOperation)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDeferredOperationKHR(VkDevice device, IntPtr pAllocator, out VkDeferredOperationKHR pDeferredOperation)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_THREAD_DONE_KHR, VK_THREAD_IDLE_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkDeferredOperationJoinKHR(VkDevice device, VkDeferredOperationKHR operation)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkDestroyDeferredOperationKHR(VkDevice device, VkDeferredOperationKHR operation, VkAllocationCallbacks* pAllocator)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkDestroyDeferredOperationKHR(VkDevice device, VkDeferredOperationKHR operation, ref VkAllocationCallbacks pAllocator)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkDestroyDeferredOperationKHR(VkDevice device, VkDeferredOperationKHR operation, IntPtr pAllocator)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe uint vkGetDeferredOperationMaxConcurrencyKHR(VkDevice device, VkDeferredOperationKHR operation)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_NOT_READY. Error codes:</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetDeferredOperationResultKHR(VkDevice device, VkDeferredOperationKHR operation)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanKHRPipelineExecutableProperties
        {
            private IntPtr vkGetPipelineExecutableInternalRepresentationsKHR_ptr;
            private IntPtr vkGetPipelineExecutablePropertiesKHR_ptr;
            private IntPtr vkGetPipelineExecutableStatisticsKHR_ptr;

            public VulkanKHRPipelineExecutableProperties(VkDevice device)
            {
                vkGetPipelineExecutableInternalRepresentationsKHR_ptr = LoadDeviceProcAddr(device, "vkGetPipelineExecutableInternalRepresentationsKHR");
                vkGetPipelineExecutablePropertiesKHR_ptr = LoadDeviceProcAddr(device, "vkGetPipelineExecutablePropertiesKHR");
                vkGetPipelineExecutableStatisticsKHR_ptr = LoadDeviceProcAddr(device, "vkGetPipelineExecutableStatisticsKHR");
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPipelineExecutableInternalRepresentationsKHR(VkDevice device, VkPipelineExecutableInfoKHR* pExecutableInfo, uint* pInternalRepresentationCount, VkPipelineExecutableInternalRepresentationKHR* pInternalRepresentations)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPipelineExecutableInternalRepresentationsKHR(VkDevice device, VkPipelineExecutableInfoKHR* pExecutableInfo, uint* pInternalRepresentationCount, out VkPipelineExecutableInternalRepresentationKHR pInternalRepresentations)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPipelineExecutableInternalRepresentationsKHR(VkDevice device, VkPipelineExecutableInfoKHR* pExecutableInfo, ref uint pInternalRepresentationCount, VkPipelineExecutableInternalRepresentationKHR* pInternalRepresentations)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPipelineExecutableInternalRepresentationsKHR(VkDevice device, VkPipelineExecutableInfoKHR* pExecutableInfo, ref uint pInternalRepresentationCount, out VkPipelineExecutableInternalRepresentationKHR pInternalRepresentations)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPipelineExecutableInternalRepresentationsKHR(VkDevice device, VkPipelineExecutableInfoKHR* pExecutableInfo, IntPtr pInternalRepresentationCount, VkPipelineExecutableInternalRepresentationKHR* pInternalRepresentations)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPipelineExecutableInternalRepresentationsKHR(VkDevice device, VkPipelineExecutableInfoKHR* pExecutableInfo, IntPtr pInternalRepresentationCount, out VkPipelineExecutableInternalRepresentationKHR pInternalRepresentations)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPipelineExecutableInternalRepresentationsKHR(VkDevice device, ref VkPipelineExecutableInfoKHR pExecutableInfo, uint* pInternalRepresentationCount, VkPipelineExecutableInternalRepresentationKHR* pInternalRepresentations)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPipelineExecutableInternalRepresentationsKHR(VkDevice device, ref VkPipelineExecutableInfoKHR pExecutableInfo, uint* pInternalRepresentationCount, out VkPipelineExecutableInternalRepresentationKHR pInternalRepresentations)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPipelineExecutableInternalRepresentationsKHR(VkDevice device, ref VkPipelineExecutableInfoKHR pExecutableInfo, ref uint pInternalRepresentationCount, VkPipelineExecutableInternalRepresentationKHR* pInternalRepresentations)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPipelineExecutableInternalRepresentationsKHR(VkDevice device, ref VkPipelineExecutableInfoKHR pExecutableInfo, ref uint pInternalRepresentationCount, out VkPipelineExecutableInternalRepresentationKHR pInternalRepresentations)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPipelineExecutableInternalRepresentationsKHR(VkDevice device, ref VkPipelineExecutableInfoKHR pExecutableInfo, IntPtr pInternalRepresentationCount, VkPipelineExecutableInternalRepresentationKHR* pInternalRepresentations)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPipelineExecutableInternalRepresentationsKHR(VkDevice device, ref VkPipelineExecutableInfoKHR pExecutableInfo, IntPtr pInternalRepresentationCount, out VkPipelineExecutableInternalRepresentationKHR pInternalRepresentations)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPipelineExecutableInternalRepresentationsKHR(VkDevice device, IntPtr pExecutableInfo, uint* pInternalRepresentationCount, VkPipelineExecutableInternalRepresentationKHR* pInternalRepresentations)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPipelineExecutableInternalRepresentationsKHR(VkDevice device, IntPtr pExecutableInfo, uint* pInternalRepresentationCount, out VkPipelineExecutableInternalRepresentationKHR pInternalRepresentations)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPipelineExecutableInternalRepresentationsKHR(VkDevice device, IntPtr pExecutableInfo, ref uint pInternalRepresentationCount, VkPipelineExecutableInternalRepresentationKHR* pInternalRepresentations)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPipelineExecutableInternalRepresentationsKHR(VkDevice device, IntPtr pExecutableInfo, ref uint pInternalRepresentationCount, out VkPipelineExecutableInternalRepresentationKHR pInternalRepresentations)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPipelineExecutableInternalRepresentationsKHR(VkDevice device, IntPtr pExecutableInfo, IntPtr pInternalRepresentationCount, VkPipelineExecutableInternalRepresentationKHR* pInternalRepresentations)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPipelineExecutableInternalRepresentationsKHR(VkDevice device, IntPtr pExecutableInfo, IntPtr pInternalRepresentationCount, out VkPipelineExecutableInternalRepresentationKHR pInternalRepresentations)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPipelineExecutablePropertiesKHR(VkDevice device, VkPipelineInfoKHR* pPipelineInfo, uint* pExecutableCount, VkPipelineExecutablePropertiesKHR* pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPipelineExecutablePropertiesKHR(VkDevice device, VkPipelineInfoKHR* pPipelineInfo, uint* pExecutableCount, out VkPipelineExecutablePropertiesKHR pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPipelineExecutablePropertiesKHR(VkDevice device, VkPipelineInfoKHR* pPipelineInfo, ref uint pExecutableCount, VkPipelineExecutablePropertiesKHR* pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPipelineExecutablePropertiesKHR(VkDevice device, VkPipelineInfoKHR* pPipelineInfo, ref uint pExecutableCount, out VkPipelineExecutablePropertiesKHR pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPipelineExecutablePropertiesKHR(VkDevice device, VkPipelineInfoKHR* pPipelineInfo, IntPtr pExecutableCount, VkPipelineExecutablePropertiesKHR* pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPipelineExecutablePropertiesKHR(VkDevice device, VkPipelineInfoKHR* pPipelineInfo, IntPtr pExecutableCount, out VkPipelineExecutablePropertiesKHR pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPipelineExecutablePropertiesKHR(VkDevice device, ref VkPipelineInfoKHR pPipelineInfo, uint* pExecutableCount, VkPipelineExecutablePropertiesKHR* pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPipelineExecutablePropertiesKHR(VkDevice device, ref VkPipelineInfoKHR pPipelineInfo, uint* pExecutableCount, out VkPipelineExecutablePropertiesKHR pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPipelineExecutablePropertiesKHR(VkDevice device, ref VkPipelineInfoKHR pPipelineInfo, ref uint pExecutableCount, VkPipelineExecutablePropertiesKHR* pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPipelineExecutablePropertiesKHR(VkDevice device, ref VkPipelineInfoKHR pPipelineInfo, ref uint pExecutableCount, out VkPipelineExecutablePropertiesKHR pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPipelineExecutablePropertiesKHR(VkDevice device, ref VkPipelineInfoKHR pPipelineInfo, IntPtr pExecutableCount, VkPipelineExecutablePropertiesKHR* pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPipelineExecutablePropertiesKHR(VkDevice device, ref VkPipelineInfoKHR pPipelineInfo, IntPtr pExecutableCount, out VkPipelineExecutablePropertiesKHR pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPipelineExecutablePropertiesKHR(VkDevice device, IntPtr pPipelineInfo, uint* pExecutableCount, VkPipelineExecutablePropertiesKHR* pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPipelineExecutablePropertiesKHR(VkDevice device, IntPtr pPipelineInfo, uint* pExecutableCount, out VkPipelineExecutablePropertiesKHR pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPipelineExecutablePropertiesKHR(VkDevice device, IntPtr pPipelineInfo, ref uint pExecutableCount, VkPipelineExecutablePropertiesKHR* pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPipelineExecutablePropertiesKHR(VkDevice device, IntPtr pPipelineInfo, ref uint pExecutableCount, out VkPipelineExecutablePropertiesKHR pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPipelineExecutablePropertiesKHR(VkDevice device, IntPtr pPipelineInfo, IntPtr pExecutableCount, VkPipelineExecutablePropertiesKHR* pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPipelineExecutablePropertiesKHR(VkDevice device, IntPtr pPipelineInfo, IntPtr pExecutableCount, out VkPipelineExecutablePropertiesKHR pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPipelineExecutableStatisticsKHR(VkDevice device, VkPipelineExecutableInfoKHR* pExecutableInfo, uint* pStatisticCount, VkPipelineExecutableStatisticKHR* pStatistics)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPipelineExecutableStatisticsKHR(VkDevice device, VkPipelineExecutableInfoKHR* pExecutableInfo, uint* pStatisticCount, out VkPipelineExecutableStatisticKHR pStatistics)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPipelineExecutableStatisticsKHR(VkDevice device, VkPipelineExecutableInfoKHR* pExecutableInfo, ref uint pStatisticCount, VkPipelineExecutableStatisticKHR* pStatistics)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPipelineExecutableStatisticsKHR(VkDevice device, VkPipelineExecutableInfoKHR* pExecutableInfo, ref uint pStatisticCount, out VkPipelineExecutableStatisticKHR pStatistics)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPipelineExecutableStatisticsKHR(VkDevice device, VkPipelineExecutableInfoKHR* pExecutableInfo, IntPtr pStatisticCount, VkPipelineExecutableStatisticKHR* pStatistics)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPipelineExecutableStatisticsKHR(VkDevice device, VkPipelineExecutableInfoKHR* pExecutableInfo, IntPtr pStatisticCount, out VkPipelineExecutableStatisticKHR pStatistics)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPipelineExecutableStatisticsKHR(VkDevice device, ref VkPipelineExecutableInfoKHR pExecutableInfo, uint* pStatisticCount, VkPipelineExecutableStatisticKHR* pStatistics)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPipelineExecutableStatisticsKHR(VkDevice device, ref VkPipelineExecutableInfoKHR pExecutableInfo, uint* pStatisticCount, out VkPipelineExecutableStatisticKHR pStatistics)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPipelineExecutableStatisticsKHR(VkDevice device, ref VkPipelineExecutableInfoKHR pExecutableInfo, ref uint pStatisticCount, VkPipelineExecutableStatisticKHR* pStatistics)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPipelineExecutableStatisticsKHR(VkDevice device, ref VkPipelineExecutableInfoKHR pExecutableInfo, ref uint pStatisticCount, out VkPipelineExecutableStatisticKHR pStatistics)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPipelineExecutableStatisticsKHR(VkDevice device, ref VkPipelineExecutableInfoKHR pExecutableInfo, IntPtr pStatisticCount, VkPipelineExecutableStatisticKHR* pStatistics)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPipelineExecutableStatisticsKHR(VkDevice device, ref VkPipelineExecutableInfoKHR pExecutableInfo, IntPtr pStatisticCount, out VkPipelineExecutableStatisticKHR pStatistics)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPipelineExecutableStatisticsKHR(VkDevice device, IntPtr pExecutableInfo, uint* pStatisticCount, VkPipelineExecutableStatisticKHR* pStatistics)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPipelineExecutableStatisticsKHR(VkDevice device, IntPtr pExecutableInfo, uint* pStatisticCount, out VkPipelineExecutableStatisticKHR pStatistics)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPipelineExecutableStatisticsKHR(VkDevice device, IntPtr pExecutableInfo, ref uint pStatisticCount, VkPipelineExecutableStatisticKHR* pStatistics)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPipelineExecutableStatisticsKHR(VkDevice device, IntPtr pExecutableInfo, ref uint pStatisticCount, out VkPipelineExecutableStatisticKHR pStatistics)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPipelineExecutableStatisticsKHR(VkDevice device, IntPtr pExecutableInfo, IntPtr pStatisticCount, VkPipelineExecutableStatisticKHR* pStatistics)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPipelineExecutableStatisticsKHR(VkDevice device, IntPtr pExecutableInfo, IntPtr pStatisticCount, out VkPipelineExecutableStatisticKHR pStatistics)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanEXTSwapchainMaintenance1
        {
            private IntPtr vkReleaseSwapchainImagesEXT_ptr;

            public VulkanEXTSwapchainMaintenance1(VkDevice device)
            {
                vkReleaseSwapchainImagesEXT_ptr = LoadDeviceProcAddr(device, "vkReleaseSwapchainImagesEXT");
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkReleaseSwapchainImagesEXT(VkDevice device, VkReleaseSwapchainImagesInfoEXT* pReleaseInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkReleaseSwapchainImagesEXT(VkDevice device, ref VkReleaseSwapchainImagesInfoEXT pReleaseInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkReleaseSwapchainImagesEXT(VkDevice device, IntPtr pReleaseInfo)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanNVDeviceGeneratedCommands
        {
            private IntPtr vkCmdBindPipelineShaderGroupNV_ptr;
            private IntPtr vkCmdExecuteGeneratedCommandsNV_ptr;
            private IntPtr vkCmdPreprocessGeneratedCommandsNV_ptr;
            private IntPtr vkCreateIndirectCommandsLayoutNV_ptr;
            private IntPtr vkDestroyIndirectCommandsLayoutNV_ptr;
            private IntPtr vkGetGeneratedCommandsMemoryRequirementsNV_ptr;

            public VulkanNVDeviceGeneratedCommands(VkDevice device)
            {
                vkCmdBindPipelineShaderGroupNV_ptr = LoadDeviceProcAddr(device, "vkCmdBindPipelineShaderGroupNV");
                vkCmdExecuteGeneratedCommandsNV_ptr = LoadDeviceProcAddr(device, "vkCmdExecuteGeneratedCommandsNV");
                vkCmdPreprocessGeneratedCommandsNV_ptr = LoadDeviceProcAddr(device, "vkCmdPreprocessGeneratedCommandsNV");
                vkCreateIndirectCommandsLayoutNV_ptr = LoadDeviceProcAddr(device, "vkCreateIndirectCommandsLayoutNV");
                vkDestroyIndirectCommandsLayoutNV_ptr = LoadDeviceProcAddr(device, "vkDestroyIndirectCommandsLayoutNV");
                vkGetGeneratedCommandsMemoryRequirementsNV_ptr = LoadDeviceProcAddr(device, "vkGetGeneratedCommandsMemoryRequirementsNV");
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBindPipelineShaderGroupNV(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline, uint groupIndex)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdExecuteGeneratedCommandsNV(VkCommandBuffer commandBuffer, VkBool32 isPreprocessed, VkGeneratedCommandsInfoNV* pGeneratedCommandsInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdExecuteGeneratedCommandsNV(VkCommandBuffer commandBuffer, VkBool32 isPreprocessed, ref VkGeneratedCommandsInfoNV pGeneratedCommandsInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdExecuteGeneratedCommandsNV(VkCommandBuffer commandBuffer, VkBool32 isPreprocessed, IntPtr pGeneratedCommandsInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdPreprocessGeneratedCommandsNV(VkCommandBuffer commandBuffer, VkGeneratedCommandsInfoNV* pGeneratedCommandsInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdPreprocessGeneratedCommandsNV(VkCommandBuffer commandBuffer, ref VkGeneratedCommandsInfoNV pGeneratedCommandsInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdPreprocessGeneratedCommandsNV(VkCommandBuffer commandBuffer, IntPtr pGeneratedCommandsInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateIndirectCommandsLayoutNV(VkDevice device, VkIndirectCommandsLayoutCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, VkIndirectCommandsLayoutNV* pIndirectCommandsLayout)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateIndirectCommandsLayoutNV(VkDevice device, VkIndirectCommandsLayoutCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkIndirectCommandsLayoutNV pIndirectCommandsLayout)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateIndirectCommandsLayoutNV(VkDevice device, VkIndirectCommandsLayoutCreateInfoNV* pCreateInfo, ref VkAllocationCallbacks pAllocator, VkIndirectCommandsLayoutNV* pIndirectCommandsLayout)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateIndirectCommandsLayoutNV(VkDevice device, VkIndirectCommandsLayoutCreateInfoNV* pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkIndirectCommandsLayoutNV pIndirectCommandsLayout)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateIndirectCommandsLayoutNV(VkDevice device, VkIndirectCommandsLayoutCreateInfoNV* pCreateInfo, IntPtr pAllocator, VkIndirectCommandsLayoutNV* pIndirectCommandsLayout)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateIndirectCommandsLayoutNV(VkDevice device, VkIndirectCommandsLayoutCreateInfoNV* pCreateInfo, IntPtr pAllocator, out VkIndirectCommandsLayoutNV pIndirectCommandsLayout)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateIndirectCommandsLayoutNV(VkDevice device, ref VkIndirectCommandsLayoutCreateInfoNV pCreateInfo, VkAllocationCallbacks* pAllocator, VkIndirectCommandsLayoutNV* pIndirectCommandsLayout)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateIndirectCommandsLayoutNV(VkDevice device, ref VkIndirectCommandsLayoutCreateInfoNV pCreateInfo, VkAllocationCallbacks* pAllocator, out VkIndirectCommandsLayoutNV pIndirectCommandsLayout)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateIndirectCommandsLayoutNV(VkDevice device, ref VkIndirectCommandsLayoutCreateInfoNV pCreateInfo, ref VkAllocationCallbacks pAllocator, VkIndirectCommandsLayoutNV* pIndirectCommandsLayout)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateIndirectCommandsLayoutNV(VkDevice device, ref VkIndirectCommandsLayoutCreateInfoNV pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkIndirectCommandsLayoutNV pIndirectCommandsLayout)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateIndirectCommandsLayoutNV(VkDevice device, ref VkIndirectCommandsLayoutCreateInfoNV pCreateInfo, IntPtr pAllocator, VkIndirectCommandsLayoutNV* pIndirectCommandsLayout)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateIndirectCommandsLayoutNV(VkDevice device, ref VkIndirectCommandsLayoutCreateInfoNV pCreateInfo, IntPtr pAllocator, out VkIndirectCommandsLayoutNV pIndirectCommandsLayout)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateIndirectCommandsLayoutNV(VkDevice device, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, VkIndirectCommandsLayoutNV* pIndirectCommandsLayout)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateIndirectCommandsLayoutNV(VkDevice device, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, out VkIndirectCommandsLayoutNV pIndirectCommandsLayout)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateIndirectCommandsLayoutNV(VkDevice device, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, VkIndirectCommandsLayoutNV* pIndirectCommandsLayout)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateIndirectCommandsLayoutNV(VkDevice device, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkIndirectCommandsLayoutNV pIndirectCommandsLayout)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateIndirectCommandsLayoutNV(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, VkIndirectCommandsLayoutNV* pIndirectCommandsLayout)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateIndirectCommandsLayoutNV(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, out VkIndirectCommandsLayoutNV pIndirectCommandsLayout)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkDestroyIndirectCommandsLayoutNV(VkDevice device, VkIndirectCommandsLayoutNV indirectCommandsLayout, VkAllocationCallbacks* pAllocator)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkDestroyIndirectCommandsLayoutNV(VkDevice device, VkIndirectCommandsLayoutNV indirectCommandsLayout, ref VkAllocationCallbacks pAllocator)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkDestroyIndirectCommandsLayoutNV(VkDevice device, VkIndirectCommandsLayoutNV indirectCommandsLayout, IntPtr pAllocator)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetGeneratedCommandsMemoryRequirementsNV(VkDevice device, VkGeneratedCommandsMemoryRequirementsInfoNV* pInfo, VkMemoryRequirements2* pMemoryRequirements)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetGeneratedCommandsMemoryRequirementsNV(VkDevice device, VkGeneratedCommandsMemoryRequirementsInfoNV* pInfo, out VkMemoryRequirements2 pMemoryRequirements)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetGeneratedCommandsMemoryRequirementsNV(VkDevice device, ref VkGeneratedCommandsMemoryRequirementsInfoNV pInfo, VkMemoryRequirements2* pMemoryRequirements)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetGeneratedCommandsMemoryRequirementsNV(VkDevice device, ref VkGeneratedCommandsMemoryRequirementsInfoNV pInfo, out VkMemoryRequirements2 pMemoryRequirements)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetGeneratedCommandsMemoryRequirementsNV(VkDevice device, IntPtr pInfo, VkMemoryRequirements2* pMemoryRequirements)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetGeneratedCommandsMemoryRequirementsNV(VkDevice device, IntPtr pInfo, out VkMemoryRequirements2 pMemoryRequirements)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanEXTAcquireDrmDisplay
        {
            private IntPtr vkAcquireDrmDisplayEXT_ptr;
            private IntPtr vkGetDrmDisplayEXT_ptr;

            public VulkanEXTAcquireDrmDisplay(VkInstance instance)
            {
                vkAcquireDrmDisplayEXT_ptr = LoadInstanceProcAddr(instance, "vkAcquireDrmDisplayEXT");
                vkGetDrmDisplayEXT_ptr = LoadInstanceProcAddr(instance, "vkGetDrmDisplayEXT");
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkAcquireDrmDisplayEXT(VkPhysicalDevice physicalDevice, int drmFd, VkDisplayKHR display)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetDrmDisplayEXT(VkPhysicalDevice physicalDevice, int drmFd, uint connectorId, VkDisplayKHR* display)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetDrmDisplayEXT(VkPhysicalDevice physicalDevice, int drmFd, uint connectorId, out VkDisplayKHR display)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanEXTPrivateData
        {

            public VulkanEXTPrivateData(VkDevice device)
            {
            }

        }

        public unsafe sealed class VulkanKHRVideoEncodeQueue
        {
            private IntPtr vkCmdEncodeVideoKHR_ptr;

            public VulkanKHRVideoEncodeQueue(VkDevice device)
            {
                vkCmdEncodeVideoKHR_ptr = LoadDeviceProcAddr(device, "vkCmdEncodeVideoKHR");
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdEncodeVideoKHR(VkCommandBuffer commandBuffer, VkVideoEncodeInfoKHR* pEncodeInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdEncodeVideoKHR(VkCommandBuffer commandBuffer, ref VkVideoEncodeInfoKHR pEncodeInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdEncodeVideoKHR(VkCommandBuffer commandBuffer, IntPtr pEncodeInfo)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanEXTMetalObjects
        {
            private IntPtr vkExportMetalObjectsEXT_ptr;

            public VulkanEXTMetalObjects(VkDevice device)
            {
                vkExportMetalObjectsEXT_ptr = LoadDeviceProcAddr(device, "vkExportMetalObjectsEXT");
            }

            [Generator.CalliRewrite]
            public unsafe void vkExportMetalObjectsEXT(VkDevice device, VkExportMetalObjectsInfoEXT* pMetalObjectsInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkExportMetalObjectsEXT(VkDevice device, ref VkExportMetalObjectsInfoEXT pMetalObjectsInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkExportMetalObjectsEXT(VkDevice device, IntPtr pMetalObjectsInfo)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanKHRSynchronization2
        {
            private IntPtr vkCmdWriteBufferMarker2AMD_ptr;
            private IntPtr vkGetQueueCheckpointData2NV_ptr;

            public VulkanKHRSynchronization2(VkDevice device)
            {
                vkCmdWriteBufferMarker2AMD_ptr = LoadDeviceProcAddr(device, "vkCmdWriteBufferMarker2AMD");
                vkGetQueueCheckpointData2NV_ptr = LoadDeviceProcAddr(device, "vkGetQueueCheckpointData2NV");
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdWriteBufferMarker2AMD(VkCommandBuffer commandBuffer, uint stage, VkBuffer dstBuffer, ulong dstOffset, uint marker)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetQueueCheckpointData2NV(VkQueue queue, uint* pCheckpointDataCount, VkCheckpointData2NV* pCheckpointData)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetQueueCheckpointData2NV(VkQueue queue, uint* pCheckpointDataCount, out VkCheckpointData2NV pCheckpointData)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetQueueCheckpointData2NV(VkQueue queue, ref uint pCheckpointDataCount, VkCheckpointData2NV* pCheckpointData)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetQueueCheckpointData2NV(VkQueue queue, ref uint pCheckpointDataCount, out VkCheckpointData2NV pCheckpointData)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetQueueCheckpointData2NV(VkQueue queue, IntPtr pCheckpointDataCount, VkCheckpointData2NV* pCheckpointData)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetQueueCheckpointData2NV(VkQueue queue, IntPtr pCheckpointDataCount, out VkCheckpointData2NV pCheckpointData)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanEXTDescriptorBuffer
        {
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

            public VulkanEXTDescriptorBuffer(VkDevice device)
            {
                vkCmdBindDescriptorBufferEmbeddedSamplersEXT_ptr = LoadDeviceProcAddr(device, "vkCmdBindDescriptorBufferEmbeddedSamplersEXT");
                vkCmdBindDescriptorBuffersEXT_ptr = LoadDeviceProcAddr(device, "vkCmdBindDescriptorBuffersEXT");
                vkCmdSetDescriptorBufferOffsetsEXT_ptr = LoadDeviceProcAddr(device, "vkCmdSetDescriptorBufferOffsetsEXT");
                vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT_ptr = LoadDeviceProcAddr(device, "vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT");
                vkGetBufferOpaqueCaptureDescriptorDataEXT_ptr = LoadDeviceProcAddr(device, "vkGetBufferOpaqueCaptureDescriptorDataEXT");
                vkGetDescriptorEXT_ptr = LoadDeviceProcAddr(device, "vkGetDescriptorEXT");
                vkGetDescriptorSetLayoutBindingOffsetEXT_ptr = LoadDeviceProcAddr(device, "vkGetDescriptorSetLayoutBindingOffsetEXT");
                vkGetDescriptorSetLayoutSizeEXT_ptr = LoadDeviceProcAddr(device, "vkGetDescriptorSetLayoutSizeEXT");
                vkGetImageOpaqueCaptureDescriptorDataEXT_ptr = LoadDeviceProcAddr(device, "vkGetImageOpaqueCaptureDescriptorDataEXT");
                vkGetImageViewOpaqueCaptureDescriptorDataEXT_ptr = LoadDeviceProcAddr(device, "vkGetImageViewOpaqueCaptureDescriptorDataEXT");
                vkGetSamplerOpaqueCaptureDescriptorDataEXT_ptr = LoadDeviceProcAddr(device, "vkGetSamplerOpaqueCaptureDescriptorDataEXT");
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBindDescriptorBufferEmbeddedSamplersEXT(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint set)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBindDescriptorBuffersEXT(VkCommandBuffer commandBuffer, uint bufferCount, VkDescriptorBufferBindingInfoEXT* pBindingInfos)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBindDescriptorBuffersEXT(VkCommandBuffer commandBuffer, uint bufferCount, ref VkDescriptorBufferBindingInfoEXT pBindingInfos)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBindDescriptorBuffersEXT(VkCommandBuffer commandBuffer, uint bufferCount, IntPtr pBindingInfos)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBindDescriptorBuffersEXT(VkCommandBuffer commandBuffer, uint bufferCount, VkDescriptorBufferBindingInfoEXT[] pBindingInfos)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetDescriptorBufferOffsetsEXT(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint firstSet, uint setCount, uint* pBufferIndices, ulong* pOffsets)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetDescriptorBufferOffsetsEXT(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint firstSet, uint setCount, uint* pBufferIndices, ref ulong pOffsets)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetDescriptorBufferOffsetsEXT(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint firstSet, uint setCount, uint* pBufferIndices, IntPtr pOffsets)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetDescriptorBufferOffsetsEXT(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint firstSet, uint setCount, ref uint pBufferIndices, ulong* pOffsets)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetDescriptorBufferOffsetsEXT(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint firstSet, uint setCount, ref uint pBufferIndices, ref ulong pOffsets)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetDescriptorBufferOffsetsEXT(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint firstSet, uint setCount, ref uint pBufferIndices, IntPtr pOffsets)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetDescriptorBufferOffsetsEXT(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint firstSet, uint setCount, IntPtr pBufferIndices, ulong* pOffsets)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetDescriptorBufferOffsetsEXT(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint firstSet, uint setCount, IntPtr pBufferIndices, ref ulong pOffsets)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetDescriptorBufferOffsetsEXT(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint firstSet, uint setCount, IntPtr pBufferIndices, IntPtr pOffsets)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT(VkDevice device, VkAccelerationStructureCaptureDescriptorDataInfoEXT* pInfo, void* pData)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT(VkDevice device, ref VkAccelerationStructureCaptureDescriptorDataInfoEXT pInfo, void* pData)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT(VkDevice device, IntPtr pInfo, void* pData)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetBufferOpaqueCaptureDescriptorDataEXT(VkDevice device, VkBufferCaptureDescriptorDataInfoEXT* pInfo, void* pData)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetBufferOpaqueCaptureDescriptorDataEXT(VkDevice device, ref VkBufferCaptureDescriptorDataInfoEXT pInfo, void* pData)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetBufferOpaqueCaptureDescriptorDataEXT(VkDevice device, IntPtr pInfo, void* pData)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetDescriptorEXT(VkDevice device, VkDescriptorGetInfoEXT* pDescriptorInfo, UIntPtr dataSize, void* pDescriptor)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetDescriptorEXT(VkDevice device, ref VkDescriptorGetInfoEXT pDescriptorInfo, UIntPtr dataSize, void* pDescriptor)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetDescriptorEXT(VkDevice device, IntPtr pDescriptorInfo, UIntPtr dataSize, void* pDescriptor)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetDescriptorSetLayoutBindingOffsetEXT(VkDevice device, VkDescriptorSetLayout layout, uint binding, ulong* pOffset)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetDescriptorSetLayoutBindingOffsetEXT(VkDevice device, VkDescriptorSetLayout layout, uint binding, out ulong pOffset)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetDescriptorSetLayoutSizeEXT(VkDevice device, VkDescriptorSetLayout layout, ulong* pLayoutSizeInBytes)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetDescriptorSetLayoutSizeEXT(VkDevice device, VkDescriptorSetLayout layout, out ulong pLayoutSizeInBytes)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetImageOpaqueCaptureDescriptorDataEXT(VkDevice device, VkImageCaptureDescriptorDataInfoEXT* pInfo, void* pData)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetImageOpaqueCaptureDescriptorDataEXT(VkDevice device, ref VkImageCaptureDescriptorDataInfoEXT pInfo, void* pData)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetImageOpaqueCaptureDescriptorDataEXT(VkDevice device, IntPtr pInfo, void* pData)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetImageViewOpaqueCaptureDescriptorDataEXT(VkDevice device, VkImageViewCaptureDescriptorDataInfoEXT* pInfo, void* pData)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetImageViewOpaqueCaptureDescriptorDataEXT(VkDevice device, ref VkImageViewCaptureDescriptorDataInfoEXT pInfo, void* pData)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetImageViewOpaqueCaptureDescriptorDataEXT(VkDevice device, IntPtr pInfo, void* pData)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetSamplerOpaqueCaptureDescriptorDataEXT(VkDevice device, VkSamplerCaptureDescriptorDataInfoEXT* pInfo, void* pData)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetSamplerOpaqueCaptureDescriptorDataEXT(VkDevice device, ref VkSamplerCaptureDescriptorDataInfoEXT pInfo, void* pData)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetSamplerOpaqueCaptureDescriptorDataEXT(VkDevice device, IntPtr pInfo, void* pData)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanNVFragmentShadingRateEnums
        {
            private IntPtr vkCmdSetFragmentShadingRateEnumNV_ptr;

            public VulkanNVFragmentShadingRateEnums(VkDevice device)
            {
                vkCmdSetFragmentShadingRateEnumNV_ptr = LoadDeviceProcAddr(device, "vkCmdSetFragmentShadingRateEnumNV");
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetFragmentShadingRateEnumNV(VkCommandBuffer commandBuffer, VkFragmentShadingRateNV shadingRate, VkFragmentShadingRateCombinerOpKHR combinerOps)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanEXTMeshShader
        {
            private IntPtr vkCmdDrawMeshTasksEXT_ptr;
            private IntPtr vkCmdDrawMeshTasksIndirectCountEXT_ptr;
            private IntPtr vkCmdDrawMeshTasksIndirectEXT_ptr;

            public VulkanEXTMeshShader(VkDevice device)
            {
                vkCmdDrawMeshTasksEXT_ptr = LoadDeviceProcAddr(device, "vkCmdDrawMeshTasksEXT");
                vkCmdDrawMeshTasksIndirectCountEXT_ptr = LoadDeviceProcAddr(device, "vkCmdDrawMeshTasksIndirectCountEXT");
                vkCmdDrawMeshTasksIndirectEXT_ptr = LoadDeviceProcAddr(device, "vkCmdDrawMeshTasksIndirectEXT");
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdDrawMeshTasksEXT(VkCommandBuffer commandBuffer, uint groupCountX, uint groupCountY, uint groupCountZ)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdDrawMeshTasksIndirectCountEXT(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdDrawMeshTasksIndirectEXT(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, uint drawCount, uint stride)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanKHRCopyCommands2
        {

            public VulkanKHRCopyCommands2(VkDevice device)
            {
            }

        }

        public unsafe sealed class VulkanEXTImageCompressionControl
        {
            private IntPtr vkGetImageSubresourceLayout2EXT_ptr;

            public VulkanEXTImageCompressionControl(VkDevice device)
            {
                vkGetImageSubresourceLayout2EXT_ptr = LoadDeviceProcAddr(device, "vkGetImageSubresourceLayout2EXT");
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetImageSubresourceLayout2EXT(VkDevice device, VkImage image, VkImageSubresource2EXT* pSubresource, VkSubresourceLayout2EXT* pLayout)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetImageSubresourceLayout2EXT(VkDevice device, VkImage image, VkImageSubresource2EXT* pSubresource, out VkSubresourceLayout2EXT pLayout)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetImageSubresourceLayout2EXT(VkDevice device, VkImage image, ref VkImageSubresource2EXT pSubresource, VkSubresourceLayout2EXT* pLayout)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetImageSubresourceLayout2EXT(VkDevice device, VkImage image, ref VkImageSubresource2EXT pSubresource, out VkSubresourceLayout2EXT pLayout)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetImageSubresourceLayout2EXT(VkDevice device, VkImage image, IntPtr pSubresource, VkSubresourceLayout2EXT* pLayout)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetImageSubresourceLayout2EXT(VkDevice device, VkImage image, IntPtr pSubresource, out VkSubresourceLayout2EXT pLayout)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanEXTDeviceFault
        {
            private IntPtr vkGetDeviceFaultInfoEXT_ptr;

            public VulkanEXTDeviceFault(VkDevice device)
            {
                vkGetDeviceFaultInfoEXT_ptr = LoadDeviceProcAddr(device, "vkGetDeviceFaultInfoEXT");
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetDeviceFaultInfoEXT(VkDevice device, VkDeviceFaultCountsEXT* pFaultCounts, VkDeviceFaultInfoEXT* pFaultInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetDeviceFaultInfoEXT(VkDevice device, VkDeviceFaultCountsEXT* pFaultCounts, out VkDeviceFaultInfoEXT pFaultInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetDeviceFaultInfoEXT(VkDevice device, ref VkDeviceFaultCountsEXT pFaultCounts, VkDeviceFaultInfoEXT* pFaultInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetDeviceFaultInfoEXT(VkDevice device, ref VkDeviceFaultCountsEXT pFaultCounts, out VkDeviceFaultInfoEXT pFaultInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetDeviceFaultInfoEXT(VkDevice device, IntPtr pFaultCounts, VkDeviceFaultInfoEXT* pFaultInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetDeviceFaultInfoEXT(VkDevice device, IntPtr pFaultCounts, out VkDeviceFaultInfoEXT pFaultInfo)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanNVAcquireWinrtDisplay
        {
            private IntPtr vkAcquireWinrtDisplayNV_ptr;
            private IntPtr vkGetWinrtDisplayNV_ptr;

            public VulkanNVAcquireWinrtDisplay(VkDevice device)
            {
                vkAcquireWinrtDisplayNV_ptr = LoadDeviceProcAddr(device, "vkAcquireWinrtDisplayNV");
                vkGetWinrtDisplayNV_ptr = LoadDeviceProcAddr(device, "vkGetWinrtDisplayNV");
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkAcquireWinrtDisplayNV(VkPhysicalDevice physicalDevice, VkDisplayKHR display)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetWinrtDisplayNV(VkPhysicalDevice physicalDevice, uint deviceRelativeId, VkDisplayKHR* pDisplay)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_DEVICE_LOST, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetWinrtDisplayNV(VkPhysicalDevice physicalDevice, uint deviceRelativeId, out VkDisplayKHR pDisplay)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanEXTDirectfbSurface
        {
            private IntPtr vkCreateDirectFBSurfaceEXT_ptr;
            private IntPtr vkGetPhysicalDeviceDirectFBPresentationSupportEXT_ptr;

            public VulkanEXTDirectfbSurface(VkInstance instance)
            {
                vkCreateDirectFBSurfaceEXT_ptr = LoadInstanceProcAddr(instance, "vkCreateDirectFBSurfaceEXT");
                vkGetPhysicalDeviceDirectFBPresentationSupportEXT_ptr = LoadInstanceProcAddr(instance, "vkGetPhysicalDeviceDirectFBPresentationSupportEXT");
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDirectFBSurfaceEXT(VkInstance instance, VkDirectFBSurfaceCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDirectFBSurfaceEXT(VkInstance instance, VkDirectFBSurfaceCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDirectFBSurfaceEXT(VkInstance instance, VkDirectFBSurfaceCreateInfoEXT* pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDirectFBSurfaceEXT(VkInstance instance, VkDirectFBSurfaceCreateInfoEXT* pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDirectFBSurfaceEXT(VkInstance instance, VkDirectFBSurfaceCreateInfoEXT* pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDirectFBSurfaceEXT(VkInstance instance, VkDirectFBSurfaceCreateInfoEXT* pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDirectFBSurfaceEXT(VkInstance instance, ref VkDirectFBSurfaceCreateInfoEXT pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDirectFBSurfaceEXT(VkInstance instance, ref VkDirectFBSurfaceCreateInfoEXT pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDirectFBSurfaceEXT(VkInstance instance, ref VkDirectFBSurfaceCreateInfoEXT pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDirectFBSurfaceEXT(VkInstance instance, ref VkDirectFBSurfaceCreateInfoEXT pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDirectFBSurfaceEXT(VkInstance instance, ref VkDirectFBSurfaceCreateInfoEXT pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDirectFBSurfaceEXT(VkInstance instance, ref VkDirectFBSurfaceCreateInfoEXT pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDirectFBSurfaceEXT(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDirectFBSurfaceEXT(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDirectFBSurfaceEXT(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDirectFBSurfaceEXT(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDirectFBSurfaceEXT(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateDirectFBSurfaceEXT(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe VkBool32 vkGetPhysicalDeviceDirectFBPresentationSupportEXT(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, DirectFB.IDirectFB* dfb)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe VkBool32 vkGetPhysicalDeviceDirectFBPresentationSupportEXT(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, out DirectFB.IDirectFB dfb)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanEXTVertexInputDynamicState
        {
            private IntPtr vkCmdSetVertexInputEXT_ptr;

            public VulkanEXTVertexInputDynamicState(VkDevice device)
            {
                vkCmdSetVertexInputEXT_ptr = LoadDeviceProcAddr(device, "vkCmdSetVertexInputEXT");
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetVertexInputEXT(VkCommandBuffer commandBuffer, uint vertexBindingDescriptionCount, VkVertexInputBindingDescription2EXT* pVertexBindingDescriptions, uint vertexAttributeDescriptionCount, VkVertexInputAttributeDescription2EXT* pVertexAttributeDescriptions)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetVertexInputEXT(VkCommandBuffer commandBuffer, uint vertexBindingDescriptionCount, VkVertexInputBindingDescription2EXT* pVertexBindingDescriptions, uint vertexAttributeDescriptionCount, ref VkVertexInputAttributeDescription2EXT pVertexAttributeDescriptions)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetVertexInputEXT(VkCommandBuffer commandBuffer, uint vertexBindingDescriptionCount, VkVertexInputBindingDescription2EXT* pVertexBindingDescriptions, uint vertexAttributeDescriptionCount, IntPtr pVertexAttributeDescriptions)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetVertexInputEXT(VkCommandBuffer commandBuffer, uint vertexBindingDescriptionCount, ref VkVertexInputBindingDescription2EXT pVertexBindingDescriptions, uint vertexAttributeDescriptionCount, VkVertexInputAttributeDescription2EXT* pVertexAttributeDescriptions)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetVertexInputEXT(VkCommandBuffer commandBuffer, uint vertexBindingDescriptionCount, ref VkVertexInputBindingDescription2EXT pVertexBindingDescriptions, uint vertexAttributeDescriptionCount, ref VkVertexInputAttributeDescription2EXT pVertexAttributeDescriptions)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetVertexInputEXT(VkCommandBuffer commandBuffer, uint vertexBindingDescriptionCount, ref VkVertexInputBindingDescription2EXT pVertexBindingDescriptions, uint vertexAttributeDescriptionCount, IntPtr pVertexAttributeDescriptions)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetVertexInputEXT(VkCommandBuffer commandBuffer, uint vertexBindingDescriptionCount, IntPtr pVertexBindingDescriptions, uint vertexAttributeDescriptionCount, VkVertexInputAttributeDescription2EXT* pVertexAttributeDescriptions)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetVertexInputEXT(VkCommandBuffer commandBuffer, uint vertexBindingDescriptionCount, IntPtr pVertexBindingDescriptions, uint vertexAttributeDescriptionCount, ref VkVertexInputAttributeDescription2EXT pVertexAttributeDescriptions)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetVertexInputEXT(VkCommandBuffer commandBuffer, uint vertexBindingDescriptionCount, IntPtr pVertexBindingDescriptions, uint vertexAttributeDescriptionCount, IntPtr pVertexAttributeDescriptions)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanFuchsiaExternalMemory
        {
            private IntPtr vkGetMemoryZirconHandleFUCHSIA_ptr;
            private IntPtr vkGetMemoryZirconHandlePropertiesFUCHSIA_ptr;

            public VulkanFuchsiaExternalMemory(VkDevice device)
            {
                vkGetMemoryZirconHandleFUCHSIA_ptr = LoadDeviceProcAddr(device, "vkGetMemoryZirconHandleFUCHSIA");
                vkGetMemoryZirconHandlePropertiesFUCHSIA_ptr = LoadDeviceProcAddr(device, "vkGetMemoryZirconHandlePropertiesFUCHSIA");
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetMemoryZirconHandleFUCHSIA(VkDevice device, VkMemoryGetZirconHandleInfoFUCHSIA* pGetZirconHandleInfo, Zircon.ZXHandle* pZirconHandle)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetMemoryZirconHandleFUCHSIA(VkDevice device, VkMemoryGetZirconHandleInfoFUCHSIA* pGetZirconHandleInfo, out Zircon.ZXHandle pZirconHandle)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetMemoryZirconHandleFUCHSIA(VkDevice device, ref VkMemoryGetZirconHandleInfoFUCHSIA pGetZirconHandleInfo, Zircon.ZXHandle* pZirconHandle)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetMemoryZirconHandleFUCHSIA(VkDevice device, ref VkMemoryGetZirconHandleInfoFUCHSIA pGetZirconHandleInfo, out Zircon.ZXHandle pZirconHandle)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetMemoryZirconHandleFUCHSIA(VkDevice device, IntPtr pGetZirconHandleInfo, Zircon.ZXHandle* pZirconHandle)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetMemoryZirconHandleFUCHSIA(VkDevice device, IntPtr pGetZirconHandleInfo, out Zircon.ZXHandle pZirconHandle)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_INVALID_EXTERNAL_HANDLE</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetMemoryZirconHandlePropertiesFUCHSIA(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, Zircon.ZXHandle zirconHandle, VkMemoryZirconHandlePropertiesFUCHSIA* pMemoryZirconHandleProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_INVALID_EXTERNAL_HANDLE</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetMemoryZirconHandlePropertiesFUCHSIA(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, Zircon.ZXHandle zirconHandle, out VkMemoryZirconHandlePropertiesFUCHSIA pMemoryZirconHandleProperties)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanFuchsiaExternalSemaphore
        {
            private IntPtr vkGetSemaphoreZirconHandleFUCHSIA_ptr;
            private IntPtr vkImportSemaphoreZirconHandleFUCHSIA_ptr;

            public VulkanFuchsiaExternalSemaphore(VkDevice device)
            {
                vkGetSemaphoreZirconHandleFUCHSIA_ptr = LoadDeviceProcAddr(device, "vkGetSemaphoreZirconHandleFUCHSIA");
                vkImportSemaphoreZirconHandleFUCHSIA_ptr = LoadDeviceProcAddr(device, "vkImportSemaphoreZirconHandleFUCHSIA");
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetSemaphoreZirconHandleFUCHSIA(VkDevice device, VkSemaphoreGetZirconHandleInfoFUCHSIA* pGetZirconHandleInfo, Zircon.ZXHandle* pZirconHandle)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetSemaphoreZirconHandleFUCHSIA(VkDevice device, VkSemaphoreGetZirconHandleInfoFUCHSIA* pGetZirconHandleInfo, out Zircon.ZXHandle pZirconHandle)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetSemaphoreZirconHandleFUCHSIA(VkDevice device, ref VkSemaphoreGetZirconHandleInfoFUCHSIA pGetZirconHandleInfo, Zircon.ZXHandle* pZirconHandle)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetSemaphoreZirconHandleFUCHSIA(VkDevice device, ref VkSemaphoreGetZirconHandleInfoFUCHSIA pGetZirconHandleInfo, out Zircon.ZXHandle pZirconHandle)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetSemaphoreZirconHandleFUCHSIA(VkDevice device, IntPtr pGetZirconHandleInfo, Zircon.ZXHandle* pZirconHandle)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_TOO_MANY_OBJECTS, VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetSemaphoreZirconHandleFUCHSIA(VkDevice device, IntPtr pGetZirconHandleInfo, out Zircon.ZXHandle pZirconHandle)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkImportSemaphoreZirconHandleFUCHSIA(VkDevice device, VkImportSemaphoreZirconHandleInfoFUCHSIA* pImportSemaphoreZirconHandleInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkImportSemaphoreZirconHandleFUCHSIA(VkDevice device, ref VkImportSemaphoreZirconHandleInfoFUCHSIA pImportSemaphoreZirconHandleInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkImportSemaphoreZirconHandleFUCHSIA(VkDevice device, IntPtr pImportSemaphoreZirconHandleInfo)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanFuchsiaBufferCollection
        {
            private IntPtr vkCreateBufferCollectionFUCHSIA_ptr;
            private IntPtr vkDestroyBufferCollectionFUCHSIA_ptr;
            private IntPtr vkGetBufferCollectionPropertiesFUCHSIA_ptr;
            private IntPtr vkSetBufferCollectionBufferConstraintsFUCHSIA_ptr;
            private IntPtr vkSetBufferCollectionImageConstraintsFUCHSIA_ptr;

            public VulkanFuchsiaBufferCollection(VkDevice device)
            {
                vkCreateBufferCollectionFUCHSIA_ptr = LoadDeviceProcAddr(device, "vkCreateBufferCollectionFUCHSIA");
                vkDestroyBufferCollectionFUCHSIA_ptr = LoadDeviceProcAddr(device, "vkDestroyBufferCollectionFUCHSIA");
                vkGetBufferCollectionPropertiesFUCHSIA_ptr = LoadDeviceProcAddr(device, "vkGetBufferCollectionPropertiesFUCHSIA");
                vkSetBufferCollectionBufferConstraintsFUCHSIA_ptr = LoadDeviceProcAddr(device, "vkSetBufferCollectionBufferConstraintsFUCHSIA");
                vkSetBufferCollectionImageConstraintsFUCHSIA_ptr = LoadDeviceProcAddr(device, "vkSetBufferCollectionImageConstraintsFUCHSIA");
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateBufferCollectionFUCHSIA(VkDevice device, VkBufferCollectionCreateInfoFUCHSIA* pCreateInfo, VkAllocationCallbacks* pAllocator, VkBufferCollectionFUCHSIA* pCollection)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateBufferCollectionFUCHSIA(VkDevice device, VkBufferCollectionCreateInfoFUCHSIA* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkBufferCollectionFUCHSIA pCollection)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateBufferCollectionFUCHSIA(VkDevice device, VkBufferCollectionCreateInfoFUCHSIA* pCreateInfo, ref VkAllocationCallbacks pAllocator, VkBufferCollectionFUCHSIA* pCollection)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateBufferCollectionFUCHSIA(VkDevice device, VkBufferCollectionCreateInfoFUCHSIA* pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkBufferCollectionFUCHSIA pCollection)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateBufferCollectionFUCHSIA(VkDevice device, VkBufferCollectionCreateInfoFUCHSIA* pCreateInfo, IntPtr pAllocator, VkBufferCollectionFUCHSIA* pCollection)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateBufferCollectionFUCHSIA(VkDevice device, VkBufferCollectionCreateInfoFUCHSIA* pCreateInfo, IntPtr pAllocator, out VkBufferCollectionFUCHSIA pCollection)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateBufferCollectionFUCHSIA(VkDevice device, ref VkBufferCollectionCreateInfoFUCHSIA pCreateInfo, VkAllocationCallbacks* pAllocator, VkBufferCollectionFUCHSIA* pCollection)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateBufferCollectionFUCHSIA(VkDevice device, ref VkBufferCollectionCreateInfoFUCHSIA pCreateInfo, VkAllocationCallbacks* pAllocator, out VkBufferCollectionFUCHSIA pCollection)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateBufferCollectionFUCHSIA(VkDevice device, ref VkBufferCollectionCreateInfoFUCHSIA pCreateInfo, ref VkAllocationCallbacks pAllocator, VkBufferCollectionFUCHSIA* pCollection)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateBufferCollectionFUCHSIA(VkDevice device, ref VkBufferCollectionCreateInfoFUCHSIA pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkBufferCollectionFUCHSIA pCollection)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateBufferCollectionFUCHSIA(VkDevice device, ref VkBufferCollectionCreateInfoFUCHSIA pCreateInfo, IntPtr pAllocator, VkBufferCollectionFUCHSIA* pCollection)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateBufferCollectionFUCHSIA(VkDevice device, ref VkBufferCollectionCreateInfoFUCHSIA pCreateInfo, IntPtr pAllocator, out VkBufferCollectionFUCHSIA pCollection)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateBufferCollectionFUCHSIA(VkDevice device, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, VkBufferCollectionFUCHSIA* pCollection)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateBufferCollectionFUCHSIA(VkDevice device, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, out VkBufferCollectionFUCHSIA pCollection)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateBufferCollectionFUCHSIA(VkDevice device, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, VkBufferCollectionFUCHSIA* pCollection)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateBufferCollectionFUCHSIA(VkDevice device, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkBufferCollectionFUCHSIA pCollection)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateBufferCollectionFUCHSIA(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, VkBufferCollectionFUCHSIA* pCollection)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_EXTERNAL_HANDLE, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateBufferCollectionFUCHSIA(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, out VkBufferCollectionFUCHSIA pCollection)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkDestroyBufferCollectionFUCHSIA(VkDevice device, VkBufferCollectionFUCHSIA collection, VkAllocationCallbacks* pAllocator)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkDestroyBufferCollectionFUCHSIA(VkDevice device, VkBufferCollectionFUCHSIA collection, ref VkAllocationCallbacks pAllocator)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkDestroyBufferCollectionFUCHSIA(VkDevice device, VkBufferCollectionFUCHSIA collection, IntPtr pAllocator)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetBufferCollectionPropertiesFUCHSIA(VkDevice device, VkBufferCollectionFUCHSIA collection, VkBufferCollectionPropertiesFUCHSIA* pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetBufferCollectionPropertiesFUCHSIA(VkDevice device, VkBufferCollectionFUCHSIA collection, out VkBufferCollectionPropertiesFUCHSIA pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_FORMAT_NOT_SUPPORTED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkSetBufferCollectionBufferConstraintsFUCHSIA(VkDevice device, VkBufferCollectionFUCHSIA collection, VkBufferConstraintsInfoFUCHSIA* pBufferConstraintsInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_FORMAT_NOT_SUPPORTED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkSetBufferCollectionBufferConstraintsFUCHSIA(VkDevice device, VkBufferCollectionFUCHSIA collection, ref VkBufferConstraintsInfoFUCHSIA pBufferConstraintsInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_FORMAT_NOT_SUPPORTED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkSetBufferCollectionBufferConstraintsFUCHSIA(VkDevice device, VkBufferCollectionFUCHSIA collection, IntPtr pBufferConstraintsInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_FORMAT_NOT_SUPPORTED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkSetBufferCollectionImageConstraintsFUCHSIA(VkDevice device, VkBufferCollectionFUCHSIA collection, VkImageConstraintsInfoFUCHSIA* pImageConstraintsInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_FORMAT_NOT_SUPPORTED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkSetBufferCollectionImageConstraintsFUCHSIA(VkDevice device, VkBufferCollectionFUCHSIA collection, ref VkImageConstraintsInfoFUCHSIA pImageConstraintsInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_FORMAT_NOT_SUPPORTED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkSetBufferCollectionImageConstraintsFUCHSIA(VkDevice device, VkBufferCollectionFUCHSIA collection, IntPtr pImageConstraintsInfo)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanHuaweiSubpassShading
        {
            private IntPtr vkCmdSubpassShadingHUAWEI_ptr;
            private IntPtr vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI_ptr;

            public VulkanHuaweiSubpassShading(VkDevice device)
            {
                vkCmdSubpassShadingHUAWEI_ptr = LoadDeviceProcAddr(device, "vkCmdSubpassShadingHUAWEI");
                vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI_ptr = LoadDeviceProcAddr(device, "vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI");
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSubpassShadingHUAWEI(VkCommandBuffer commandBuffer)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI(VkDevice device, VkRenderPass renderpass, VkExtent2D* pMaxWorkgroupSize)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY, VK_ERROR_SURFACE_LOST_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI(VkDevice device, VkRenderPass renderpass, out VkExtent2D pMaxWorkgroupSize)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanHuaweiInvocationMask
        {
            private IntPtr vkCmdBindInvocationMaskHUAWEI_ptr;

            public VulkanHuaweiInvocationMask(VkDevice device)
            {
                vkCmdBindInvocationMaskHUAWEI_ptr = LoadDeviceProcAddr(device, "vkCmdBindInvocationMaskHUAWEI");
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBindInvocationMaskHUAWEI(VkCommandBuffer commandBuffer, VkImageView imageView, VkImageLayout imageLayout)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanNVExternalMemoryRdma
        {
            private IntPtr vkGetMemoryRemoteAddressNV_ptr;

            public VulkanNVExternalMemoryRdma(VkDevice device)
            {
                vkGetMemoryRemoteAddressNV_ptr = LoadDeviceProcAddr(device, "vkGetMemoryRemoteAddressNV");
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_INVALID_EXTERNAL_HANDLE</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetMemoryRemoteAddressNV(VkDevice device, VkMemoryGetRemoteAddressInfoNV* pMemoryGetRemoteAddressInfo, void* pAddress)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_INVALID_EXTERNAL_HANDLE</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetMemoryRemoteAddressNV(VkDevice device, ref VkMemoryGetRemoteAddressInfoNV pMemoryGetRemoteAddressInfo, void* pAddress)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_INVALID_EXTERNAL_HANDLE</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetMemoryRemoteAddressNV(VkDevice device, IntPtr pMemoryGetRemoteAddressInfo, void* pAddress)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanEXTPipelineProperties
        {
            private IntPtr vkGetPipelinePropertiesEXT_ptr;

            public VulkanEXTPipelineProperties(VkDevice device)
            {
                vkGetPipelinePropertiesEXT_ptr = LoadDeviceProcAddr(device, "vkGetPipelinePropertiesEXT");
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPipelinePropertiesEXT(VkDevice device, VkPipelineInfoKHR* pPipelineInfo, VkBaseOutStructure* pPipelineProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPipelinePropertiesEXT(VkDevice device, VkPipelineInfoKHR* pPipelineInfo, out VkBaseOutStructure pPipelineProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPipelinePropertiesEXT(VkDevice device, ref VkPipelineInfoKHR pPipelineInfo, VkBaseOutStructure* pPipelineProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPipelinePropertiesEXT(VkDevice device, ref VkPipelineInfoKHR pPipelineInfo, out VkBaseOutStructure pPipelineProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPipelinePropertiesEXT(VkDevice device, IntPtr pPipelineInfo, VkBaseOutStructure* pPipelineProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPipelinePropertiesEXT(VkDevice device, IntPtr pPipelineInfo, out VkBaseOutStructure pPipelineProperties)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanEXTExtendedDynamicState2
        {
            private IntPtr vkCmdSetLogicOpEXT_ptr;
            private IntPtr vkCmdSetPatchControlPointsEXT_ptr;

            public VulkanEXTExtendedDynamicState2(VkDevice device)
            {
                vkCmdSetLogicOpEXT_ptr = LoadDeviceProcAddr(device, "vkCmdSetLogicOpEXT");
                vkCmdSetPatchControlPointsEXT_ptr = LoadDeviceProcAddr(device, "vkCmdSetPatchControlPointsEXT");
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetLogicOpEXT(VkCommandBuffer commandBuffer, VkLogicOp logicOp)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetPatchControlPointsEXT(VkCommandBuffer commandBuffer, uint patchControlPoints)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanQnxScreenSurface
        {
            private IntPtr vkCreateScreenSurfaceQNX_ptr;
            private IntPtr vkGetPhysicalDeviceScreenPresentationSupportQNX_ptr;

            public VulkanQnxScreenSurface(VkInstance instance)
            {
                vkCreateScreenSurfaceQNX_ptr = LoadInstanceProcAddr(instance, "vkCreateScreenSurfaceQNX");
                vkGetPhysicalDeviceScreenPresentationSupportQNX_ptr = LoadInstanceProcAddr(instance, "vkGetPhysicalDeviceScreenPresentationSupportQNX");
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateScreenSurfaceQNX(VkInstance instance, VkScreenSurfaceCreateInfoQNX* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateScreenSurfaceQNX(VkInstance instance, VkScreenSurfaceCreateInfoQNX* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateScreenSurfaceQNX(VkInstance instance, VkScreenSurfaceCreateInfoQNX* pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateScreenSurfaceQNX(VkInstance instance, VkScreenSurfaceCreateInfoQNX* pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateScreenSurfaceQNX(VkInstance instance, VkScreenSurfaceCreateInfoQNX* pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateScreenSurfaceQNX(VkInstance instance, VkScreenSurfaceCreateInfoQNX* pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateScreenSurfaceQNX(VkInstance instance, ref VkScreenSurfaceCreateInfoQNX pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateScreenSurfaceQNX(VkInstance instance, ref VkScreenSurfaceCreateInfoQNX pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateScreenSurfaceQNX(VkInstance instance, ref VkScreenSurfaceCreateInfoQNX pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateScreenSurfaceQNX(VkInstance instance, ref VkScreenSurfaceCreateInfoQNX pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateScreenSurfaceQNX(VkInstance instance, ref VkScreenSurfaceCreateInfoQNX pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateScreenSurfaceQNX(VkInstance instance, ref VkScreenSurfaceCreateInfoQNX pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateScreenSurfaceQNX(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateScreenSurfaceQNX(VkInstance instance, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateScreenSurfaceQNX(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateScreenSurfaceQNX(VkInstance instance, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateScreenSurfaceQNX(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, VkSurfaceKHR* pSurface)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateScreenSurfaceQNX(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, out VkSurfaceKHR pSurface)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe VkBool32 vkGetPhysicalDeviceScreenPresentationSupportQNX(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, Screen.ScreenWindow* window)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe VkBool32 vkGetPhysicalDeviceScreenPresentationSupportQNX(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, out Screen.ScreenWindow window)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanEXTColorWriteEnable
        {
            private IntPtr vkCmdSetColorWriteEnableEXT_ptr;

            public VulkanEXTColorWriteEnable(VkDevice device)
            {
                vkCmdSetColorWriteEnableEXT_ptr = LoadDeviceProcAddr(device, "vkCmdSetColorWriteEnableEXT");
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetColorWriteEnableEXT(VkCommandBuffer commandBuffer, uint attachmentCount, VkBool32* pColorWriteEnables)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetColorWriteEnableEXT(VkCommandBuffer commandBuffer, uint attachmentCount, ref VkBool32 pColorWriteEnables)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetColorWriteEnableEXT(VkCommandBuffer commandBuffer, uint attachmentCount, IntPtr pColorWriteEnables)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanKHRRayTracingMaintenance1
        {
            private IntPtr vkCmdTraceRaysIndirect2KHR_ptr;

            public VulkanKHRRayTracingMaintenance1(VkDevice device)
            {
                vkCmdTraceRaysIndirect2KHR_ptr = LoadDeviceProcAddr(device, "vkCmdTraceRaysIndirect2KHR");
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdTraceRaysIndirect2KHR(VkCommandBuffer commandBuffer, ulong indirectDeviceAddress)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanEXTMultiDraw
        {
            private IntPtr vkCmdDrawMultiEXT_ptr;
            private IntPtr vkCmdDrawMultiIndexedEXT_ptr;

            public VulkanEXTMultiDraw(VkDevice device)
            {
                vkCmdDrawMultiEXT_ptr = LoadDeviceProcAddr(device, "vkCmdDrawMultiEXT");
                vkCmdDrawMultiIndexedEXT_ptr = LoadDeviceProcAddr(device, "vkCmdDrawMultiIndexedEXT");
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdDrawMultiEXT(VkCommandBuffer commandBuffer, uint drawCount, VkMultiDrawInfoEXT* pVertexInfo, uint instanceCount, uint firstInstance, uint stride)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdDrawMultiEXT(VkCommandBuffer commandBuffer, uint drawCount, ref VkMultiDrawInfoEXT pVertexInfo, uint instanceCount, uint firstInstance, uint stride)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdDrawMultiEXT(VkCommandBuffer commandBuffer, uint drawCount, IntPtr pVertexInfo, uint instanceCount, uint firstInstance, uint stride)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdDrawMultiIndexedEXT(VkCommandBuffer commandBuffer, uint drawCount, VkMultiDrawIndexedInfoEXT* pIndexInfo, uint instanceCount, uint firstInstance, uint stride, int* pVertexOffset)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdDrawMultiIndexedEXT(VkCommandBuffer commandBuffer, uint drawCount, VkMultiDrawIndexedInfoEXT* pIndexInfo, uint instanceCount, uint firstInstance, uint stride, ref int pVertexOffset)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdDrawMultiIndexedEXT(VkCommandBuffer commandBuffer, uint drawCount, VkMultiDrawIndexedInfoEXT* pIndexInfo, uint instanceCount, uint firstInstance, uint stride, IntPtr pVertexOffset)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdDrawMultiIndexedEXT(VkCommandBuffer commandBuffer, uint drawCount, ref VkMultiDrawIndexedInfoEXT pIndexInfo, uint instanceCount, uint firstInstance, uint stride, int* pVertexOffset)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdDrawMultiIndexedEXT(VkCommandBuffer commandBuffer, uint drawCount, ref VkMultiDrawIndexedInfoEXT pIndexInfo, uint instanceCount, uint firstInstance, uint stride, ref int pVertexOffset)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdDrawMultiIndexedEXT(VkCommandBuffer commandBuffer, uint drawCount, ref VkMultiDrawIndexedInfoEXT pIndexInfo, uint instanceCount, uint firstInstance, uint stride, IntPtr pVertexOffset)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdDrawMultiIndexedEXT(VkCommandBuffer commandBuffer, uint drawCount, IntPtr pIndexInfo, uint instanceCount, uint firstInstance, uint stride, int* pVertexOffset)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdDrawMultiIndexedEXT(VkCommandBuffer commandBuffer, uint drawCount, IntPtr pIndexInfo, uint instanceCount, uint firstInstance, uint stride, ref int pVertexOffset)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdDrawMultiIndexedEXT(VkCommandBuffer commandBuffer, uint drawCount, IntPtr pIndexInfo, uint instanceCount, uint firstInstance, uint stride, IntPtr pVertexOffset)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanEXTOpacityMicromap
        {
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

            public VulkanEXTOpacityMicromap(VkDevice device)
            {
                vkBuildMicromapsEXT_ptr = LoadDeviceProcAddr(device, "vkBuildMicromapsEXT");
                vkCmdBuildMicromapsEXT_ptr = LoadDeviceProcAddr(device, "vkCmdBuildMicromapsEXT");
                vkCmdCopyMemoryToMicromapEXT_ptr = LoadDeviceProcAddr(device, "vkCmdCopyMemoryToMicromapEXT");
                vkCmdCopyMicromapEXT_ptr = LoadDeviceProcAddr(device, "vkCmdCopyMicromapEXT");
                vkCmdCopyMicromapToMemoryEXT_ptr = LoadDeviceProcAddr(device, "vkCmdCopyMicromapToMemoryEXT");
                vkCmdWriteMicromapsPropertiesEXT_ptr = LoadDeviceProcAddr(device, "vkCmdWriteMicromapsPropertiesEXT");
                vkCopyMemoryToMicromapEXT_ptr = LoadDeviceProcAddr(device, "vkCopyMemoryToMicromapEXT");
                vkCopyMicromapEXT_ptr = LoadDeviceProcAddr(device, "vkCopyMicromapEXT");
                vkCopyMicromapToMemoryEXT_ptr = LoadDeviceProcAddr(device, "vkCopyMicromapToMemoryEXT");
                vkCreateMicromapEXT_ptr = LoadDeviceProcAddr(device, "vkCreateMicromapEXT");
                vkDestroyMicromapEXT_ptr = LoadDeviceProcAddr(device, "vkDestroyMicromapEXT");
                vkGetDeviceMicromapCompatibilityEXT_ptr = LoadDeviceProcAddr(device, "vkGetDeviceMicromapCompatibilityEXT");
                vkGetMicromapBuildSizesEXT_ptr = LoadDeviceProcAddr(device, "vkGetMicromapBuildSizesEXT");
                vkWriteMicromapsPropertiesEXT_ptr = LoadDeviceProcAddr(device, "vkWriteMicromapsPropertiesEXT");
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkBuildMicromapsEXT(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, VkMicromapBuildInfoEXT* pInfos)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkBuildMicromapsEXT(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, ref VkMicromapBuildInfoEXT pInfos)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkBuildMicromapsEXT(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, IntPtr pInfos)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkBuildMicromapsEXT(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, VkMicromapBuildInfoEXT[] pInfos)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildMicromapsEXT(VkCommandBuffer commandBuffer, uint infoCount, VkMicromapBuildInfoEXT* pInfos)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildMicromapsEXT(VkCommandBuffer commandBuffer, uint infoCount, ref VkMicromapBuildInfoEXT pInfos)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildMicromapsEXT(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdBuildMicromapsEXT(VkCommandBuffer commandBuffer, uint infoCount, VkMicromapBuildInfoEXT[] pInfos)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdCopyMemoryToMicromapEXT(VkCommandBuffer commandBuffer, VkCopyMemoryToMicromapInfoEXT* pInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdCopyMemoryToMicromapEXT(VkCommandBuffer commandBuffer, ref VkCopyMemoryToMicromapInfoEXT pInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdCopyMemoryToMicromapEXT(VkCommandBuffer commandBuffer, IntPtr pInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdCopyMicromapEXT(VkCommandBuffer commandBuffer, VkCopyMicromapInfoEXT* pInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdCopyMicromapEXT(VkCommandBuffer commandBuffer, ref VkCopyMicromapInfoEXT pInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdCopyMicromapEXT(VkCommandBuffer commandBuffer, IntPtr pInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdCopyMicromapToMemoryEXT(VkCommandBuffer commandBuffer, VkCopyMicromapToMemoryInfoEXT* pInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdCopyMicromapToMemoryEXT(VkCommandBuffer commandBuffer, ref VkCopyMicromapToMemoryInfoEXT pInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdCopyMicromapToMemoryEXT(VkCommandBuffer commandBuffer, IntPtr pInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdWriteMicromapsPropertiesEXT(VkCommandBuffer commandBuffer, uint micromapCount, VkMicromapEXT* pMicromaps, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdWriteMicromapsPropertiesEXT(VkCommandBuffer commandBuffer, uint micromapCount, ref VkMicromapEXT pMicromaps, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdWriteMicromapsPropertiesEXT(VkCommandBuffer commandBuffer, uint micromapCount, IntPtr pMicromaps, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCopyMemoryToMicromapEXT(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyMemoryToMicromapInfoEXT* pInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCopyMemoryToMicromapEXT(VkDevice device, VkDeferredOperationKHR deferredOperation, ref VkCopyMemoryToMicromapInfoEXT pInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCopyMemoryToMicromapEXT(VkDevice device, VkDeferredOperationKHR deferredOperation, IntPtr pInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCopyMicromapEXT(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyMicromapInfoEXT* pInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCopyMicromapEXT(VkDevice device, VkDeferredOperationKHR deferredOperation, ref VkCopyMicromapInfoEXT pInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCopyMicromapEXT(VkDevice device, VkDeferredOperationKHR deferredOperation, IntPtr pInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCopyMicromapToMemoryEXT(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyMicromapToMemoryInfoEXT* pInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCopyMicromapToMemoryEXT(VkDevice device, VkDeferredOperationKHR deferredOperation, ref VkCopyMicromapToMemoryInfoEXT pInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_OPERATION_DEFERRED_KHR, VK_OPERATION_NOT_DEFERRED_KHR. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCopyMicromapToMemoryEXT(VkDevice device, VkDeferredOperationKHR deferredOperation, IntPtr pInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateMicromapEXT(VkDevice device, VkMicromapCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkMicromapEXT* pMicromap)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateMicromapEXT(VkDevice device, VkMicromapCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkMicromapEXT pMicromap)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateMicromapEXT(VkDevice device, VkMicromapCreateInfoEXT* pCreateInfo, ref VkAllocationCallbacks pAllocator, VkMicromapEXT* pMicromap)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateMicromapEXT(VkDevice device, VkMicromapCreateInfoEXT* pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkMicromapEXT pMicromap)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateMicromapEXT(VkDevice device, VkMicromapCreateInfoEXT* pCreateInfo, IntPtr pAllocator, VkMicromapEXT* pMicromap)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateMicromapEXT(VkDevice device, VkMicromapCreateInfoEXT* pCreateInfo, IntPtr pAllocator, out VkMicromapEXT pMicromap)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateMicromapEXT(VkDevice device, ref VkMicromapCreateInfoEXT pCreateInfo, VkAllocationCallbacks* pAllocator, VkMicromapEXT* pMicromap)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateMicromapEXT(VkDevice device, ref VkMicromapCreateInfoEXT pCreateInfo, VkAllocationCallbacks* pAllocator, out VkMicromapEXT pMicromap)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateMicromapEXT(VkDevice device, ref VkMicromapCreateInfoEXT pCreateInfo, ref VkAllocationCallbacks pAllocator, VkMicromapEXT* pMicromap)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateMicromapEXT(VkDevice device, ref VkMicromapCreateInfoEXT pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkMicromapEXT pMicromap)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateMicromapEXT(VkDevice device, ref VkMicromapCreateInfoEXT pCreateInfo, IntPtr pAllocator, VkMicromapEXT* pMicromap)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateMicromapEXT(VkDevice device, ref VkMicromapCreateInfoEXT pCreateInfo, IntPtr pAllocator, out VkMicromapEXT pMicromap)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateMicromapEXT(VkDevice device, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, VkMicromapEXT* pMicromap)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateMicromapEXT(VkDevice device, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, out VkMicromapEXT pMicromap)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateMicromapEXT(VkDevice device, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, VkMicromapEXT* pMicromap)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateMicromapEXT(VkDevice device, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkMicromapEXT pMicromap)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateMicromapEXT(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, VkMicromapEXT* pMicromap)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateMicromapEXT(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, out VkMicromapEXT pMicromap)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkDestroyMicromapEXT(VkDevice device, VkMicromapEXT micromap, VkAllocationCallbacks* pAllocator)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkDestroyMicromapEXT(VkDevice device, VkMicromapEXT micromap, ref VkAllocationCallbacks pAllocator)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkDestroyMicromapEXT(VkDevice device, VkMicromapEXT micromap, IntPtr pAllocator)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetDeviceMicromapCompatibilityEXT(VkDevice device, VkMicromapVersionInfoEXT* pVersionInfo, VkAccelerationStructureCompatibilityKHR* pCompatibility)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetDeviceMicromapCompatibilityEXT(VkDevice device, VkMicromapVersionInfoEXT* pVersionInfo, out VkAccelerationStructureCompatibilityKHR pCompatibility)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetDeviceMicromapCompatibilityEXT(VkDevice device, ref VkMicromapVersionInfoEXT pVersionInfo, VkAccelerationStructureCompatibilityKHR* pCompatibility)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetDeviceMicromapCompatibilityEXT(VkDevice device, ref VkMicromapVersionInfoEXT pVersionInfo, out VkAccelerationStructureCompatibilityKHR pCompatibility)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetDeviceMicromapCompatibilityEXT(VkDevice device, IntPtr pVersionInfo, VkAccelerationStructureCompatibilityKHR* pCompatibility)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetDeviceMicromapCompatibilityEXT(VkDevice device, IntPtr pVersionInfo, out VkAccelerationStructureCompatibilityKHR pCompatibility)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetMicromapBuildSizesEXT(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, VkMicromapBuildInfoEXT* pBuildInfo, VkMicromapBuildSizesInfoEXT* pSizeInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetMicromapBuildSizesEXT(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, VkMicromapBuildInfoEXT* pBuildInfo, out VkMicromapBuildSizesInfoEXT pSizeInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetMicromapBuildSizesEXT(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, ref VkMicromapBuildInfoEXT pBuildInfo, VkMicromapBuildSizesInfoEXT* pSizeInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetMicromapBuildSizesEXT(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, ref VkMicromapBuildInfoEXT pBuildInfo, out VkMicromapBuildSizesInfoEXT pSizeInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetMicromapBuildSizesEXT(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, IntPtr pBuildInfo, VkMicromapBuildSizesInfoEXT* pSizeInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetMicromapBuildSizesEXT(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, IntPtr pBuildInfo, out VkMicromapBuildSizesInfoEXT pSizeInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkWriteMicromapsPropertiesEXT(VkDevice device, uint micromapCount, VkMicromapEXT* pMicromaps, VkQueryType queryType, UIntPtr dataSize, void* pData, UIntPtr stride)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkWriteMicromapsPropertiesEXT(VkDevice device, uint micromapCount, ref VkMicromapEXT pMicromaps, VkQueryType queryType, UIntPtr dataSize, void* pData, UIntPtr stride)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_OUT_OF_DEVICE_MEMORY</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkWriteMicromapsPropertiesEXT(VkDevice device, uint micromapCount, IntPtr pMicromaps, VkQueryType queryType, UIntPtr dataSize, void* pData, UIntPtr stride)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanEXTPageableDeviceLocalMemory
        {
            private IntPtr vkSetDeviceMemoryPriorityEXT_ptr;

            public VulkanEXTPageableDeviceLocalMemory(VkDevice device)
            {
                vkSetDeviceMemoryPriorityEXT_ptr = LoadDeviceProcAddr(device, "vkSetDeviceMemoryPriorityEXT");
            }

            [Generator.CalliRewrite]
            public unsafe void vkSetDeviceMemoryPriorityEXT(VkDevice device, VkDeviceMemory memory, float priority)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanKHRMaintenance4
        {

            public VulkanKHRMaintenance4(VkDevice device)
            {
            }

        }

        public unsafe sealed class VulkanValveDescriptorSetHostMapping
        {
            private IntPtr vkGetDescriptorSetHostMappingVALVE_ptr;
            private IntPtr vkGetDescriptorSetLayoutHostMappingInfoVALVE_ptr;

            public VulkanValveDescriptorSetHostMapping(VkDevice device)
            {
                vkGetDescriptorSetHostMappingVALVE_ptr = LoadDeviceProcAddr(device, "vkGetDescriptorSetHostMappingVALVE");
                vkGetDescriptorSetLayoutHostMappingInfoVALVE_ptr = LoadDeviceProcAddr(device, "vkGetDescriptorSetLayoutHostMappingInfoVALVE");
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetDescriptorSetHostMappingVALVE(VkDevice device, VkDescriptorSet descriptorSet, void** ppData)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetDescriptorSetLayoutHostMappingInfoVALVE(VkDevice device, VkDescriptorSetBindingReferenceVALVE* pBindingReference, VkDescriptorSetLayoutHostMappingInfoVALVE* pHostMapping)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetDescriptorSetLayoutHostMappingInfoVALVE(VkDevice device, VkDescriptorSetBindingReferenceVALVE* pBindingReference, out VkDescriptorSetLayoutHostMappingInfoVALVE pHostMapping)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetDescriptorSetLayoutHostMappingInfoVALVE(VkDevice device, ref VkDescriptorSetBindingReferenceVALVE pBindingReference, VkDescriptorSetLayoutHostMappingInfoVALVE* pHostMapping)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetDescriptorSetLayoutHostMappingInfoVALVE(VkDevice device, ref VkDescriptorSetBindingReferenceVALVE pBindingReference, out VkDescriptorSetLayoutHostMappingInfoVALVE pHostMapping)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetDescriptorSetLayoutHostMappingInfoVALVE(VkDevice device, IntPtr pBindingReference, VkDescriptorSetLayoutHostMappingInfoVALVE* pHostMapping)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetDescriptorSetLayoutHostMappingInfoVALVE(VkDevice device, IntPtr pBindingReference, out VkDescriptorSetLayoutHostMappingInfoVALVE pHostMapping)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanNVCopyMemoryIndirect
        {
            private IntPtr vkCmdCopyMemoryIndirectNV_ptr;
            private IntPtr vkCmdCopyMemoryToImageIndirectNV_ptr;

            public VulkanNVCopyMemoryIndirect(VkDevice device)
            {
                vkCmdCopyMemoryIndirectNV_ptr = LoadDeviceProcAddr(device, "vkCmdCopyMemoryIndirectNV");
                vkCmdCopyMemoryToImageIndirectNV_ptr = LoadDeviceProcAddr(device, "vkCmdCopyMemoryToImageIndirectNV");
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdCopyMemoryIndirectNV(VkCommandBuffer commandBuffer, ulong copyBufferAddress, uint copyCount, uint stride)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdCopyMemoryToImageIndirectNV(VkCommandBuffer commandBuffer, ulong copyBufferAddress, uint copyCount, uint stride, VkImage dstImage, VkImageLayout dstImageLayout, VkImageSubresourceLayers* pImageSubresources)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdCopyMemoryToImageIndirectNV(VkCommandBuffer commandBuffer, ulong copyBufferAddress, uint copyCount, uint stride, VkImage dstImage, VkImageLayout dstImageLayout, ref VkImageSubresourceLayers pImageSubresources)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdCopyMemoryToImageIndirectNV(VkCommandBuffer commandBuffer, ulong copyBufferAddress, uint copyCount, uint stride, VkImage dstImage, VkImageLayout dstImageLayout, IntPtr pImageSubresources)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanNVMemoryDecompression
        {
            private IntPtr vkCmdDecompressMemoryIndirectCountNV_ptr;
            private IntPtr vkCmdDecompressMemoryNV_ptr;

            public VulkanNVMemoryDecompression(VkDevice device)
            {
                vkCmdDecompressMemoryIndirectCountNV_ptr = LoadDeviceProcAddr(device, "vkCmdDecompressMemoryIndirectCountNV");
                vkCmdDecompressMemoryNV_ptr = LoadDeviceProcAddr(device, "vkCmdDecompressMemoryNV");
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdDecompressMemoryIndirectCountNV(VkCommandBuffer commandBuffer, ulong indirectCommandsAddress, ulong indirectCommandsCountAddress, uint stride)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdDecompressMemoryNV(VkCommandBuffer commandBuffer, uint decompressRegionCount, VkDecompressMemoryRegionNV* pDecompressMemoryRegions)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdDecompressMemoryNV(VkCommandBuffer commandBuffer, uint decompressRegionCount, ref VkDecompressMemoryRegionNV pDecompressMemoryRegions)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdDecompressMemoryNV(VkCommandBuffer commandBuffer, uint decompressRegionCount, IntPtr pDecompressMemoryRegions)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanEXTExtendedDynamicState3
        {
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

            public VulkanEXTExtendedDynamicState3(VkDevice device)
            {
                vkCmdSetAlphaToCoverageEnableEXT_ptr = LoadDeviceProcAddr(device, "vkCmdSetAlphaToCoverageEnableEXT");
                vkCmdSetAlphaToOneEnableEXT_ptr = LoadDeviceProcAddr(device, "vkCmdSetAlphaToOneEnableEXT");
                vkCmdSetColorBlendAdvancedEXT_ptr = LoadDeviceProcAddr(device, "vkCmdSetColorBlendAdvancedEXT");
                vkCmdSetColorBlendEnableEXT_ptr = LoadDeviceProcAddr(device, "vkCmdSetColorBlendEnableEXT");
                vkCmdSetColorBlendEquationEXT_ptr = LoadDeviceProcAddr(device, "vkCmdSetColorBlendEquationEXT");
                vkCmdSetColorWriteMaskEXT_ptr = LoadDeviceProcAddr(device, "vkCmdSetColorWriteMaskEXT");
                vkCmdSetConservativeRasterizationModeEXT_ptr = LoadDeviceProcAddr(device, "vkCmdSetConservativeRasterizationModeEXT");
                vkCmdSetCoverageModulationModeNV_ptr = LoadDeviceProcAddr(device, "vkCmdSetCoverageModulationModeNV");
                vkCmdSetCoverageModulationTableEnableNV_ptr = LoadDeviceProcAddr(device, "vkCmdSetCoverageModulationTableEnableNV");
                vkCmdSetCoverageModulationTableNV_ptr = LoadDeviceProcAddr(device, "vkCmdSetCoverageModulationTableNV");
                vkCmdSetCoverageReductionModeNV_ptr = LoadDeviceProcAddr(device, "vkCmdSetCoverageReductionModeNV");
                vkCmdSetCoverageToColorEnableNV_ptr = LoadDeviceProcAddr(device, "vkCmdSetCoverageToColorEnableNV");
                vkCmdSetCoverageToColorLocationNV_ptr = LoadDeviceProcAddr(device, "vkCmdSetCoverageToColorLocationNV");
                vkCmdSetDepthClampEnableEXT_ptr = LoadDeviceProcAddr(device, "vkCmdSetDepthClampEnableEXT");
                vkCmdSetDepthClipEnableEXT_ptr = LoadDeviceProcAddr(device, "vkCmdSetDepthClipEnableEXT");
                vkCmdSetDepthClipNegativeOneToOneEXT_ptr = LoadDeviceProcAddr(device, "vkCmdSetDepthClipNegativeOneToOneEXT");
                vkCmdSetExtraPrimitiveOverestimationSizeEXT_ptr = LoadDeviceProcAddr(device, "vkCmdSetExtraPrimitiveOverestimationSizeEXT");
                vkCmdSetLineRasterizationModeEXT_ptr = LoadDeviceProcAddr(device, "vkCmdSetLineRasterizationModeEXT");
                vkCmdSetLineStippleEnableEXT_ptr = LoadDeviceProcAddr(device, "vkCmdSetLineStippleEnableEXT");
                vkCmdSetLogicOpEnableEXT_ptr = LoadDeviceProcAddr(device, "vkCmdSetLogicOpEnableEXT");
                vkCmdSetPolygonModeEXT_ptr = LoadDeviceProcAddr(device, "vkCmdSetPolygonModeEXT");
                vkCmdSetProvokingVertexModeEXT_ptr = LoadDeviceProcAddr(device, "vkCmdSetProvokingVertexModeEXT");
                vkCmdSetRasterizationSamplesEXT_ptr = LoadDeviceProcAddr(device, "vkCmdSetRasterizationSamplesEXT");
                vkCmdSetRasterizationStreamEXT_ptr = LoadDeviceProcAddr(device, "vkCmdSetRasterizationStreamEXT");
                vkCmdSetRepresentativeFragmentTestEnableNV_ptr = LoadDeviceProcAddr(device, "vkCmdSetRepresentativeFragmentTestEnableNV");
                vkCmdSetSampleLocationsEnableEXT_ptr = LoadDeviceProcAddr(device, "vkCmdSetSampleLocationsEnableEXT");
                vkCmdSetSampleMaskEXT_ptr = LoadDeviceProcAddr(device, "vkCmdSetSampleMaskEXT");
                vkCmdSetShadingRateImageEnableNV_ptr = LoadDeviceProcAddr(device, "vkCmdSetShadingRateImageEnableNV");
                vkCmdSetTessellationDomainOriginEXT_ptr = LoadDeviceProcAddr(device, "vkCmdSetTessellationDomainOriginEXT");
                vkCmdSetViewportSwizzleNV_ptr = LoadDeviceProcAddr(device, "vkCmdSetViewportSwizzleNV");
                vkCmdSetViewportWScalingEnableNV_ptr = LoadDeviceProcAddr(device, "vkCmdSetViewportWScalingEnableNV");
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetAlphaToCoverageEnableEXT(VkCommandBuffer commandBuffer, VkBool32 alphaToCoverageEnable)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetAlphaToOneEnableEXT(VkCommandBuffer commandBuffer, VkBool32 alphaToOneEnable)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetColorBlendAdvancedEXT(VkCommandBuffer commandBuffer, uint firstAttachment, uint attachmentCount, VkColorBlendAdvancedEXT* pColorBlendAdvanced)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetColorBlendAdvancedEXT(VkCommandBuffer commandBuffer, uint firstAttachment, uint attachmentCount, ref VkColorBlendAdvancedEXT pColorBlendAdvanced)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetColorBlendAdvancedEXT(VkCommandBuffer commandBuffer, uint firstAttachment, uint attachmentCount, IntPtr pColorBlendAdvanced)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetColorBlendEnableEXT(VkCommandBuffer commandBuffer, uint firstAttachment, uint attachmentCount, VkBool32* pColorBlendEnables)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetColorBlendEnableEXT(VkCommandBuffer commandBuffer, uint firstAttachment, uint attachmentCount, ref VkBool32 pColorBlendEnables)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetColorBlendEnableEXT(VkCommandBuffer commandBuffer, uint firstAttachment, uint attachmentCount, IntPtr pColorBlendEnables)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetColorBlendEquationEXT(VkCommandBuffer commandBuffer, uint firstAttachment, uint attachmentCount, VkColorBlendEquationEXT* pColorBlendEquations)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetColorBlendEquationEXT(VkCommandBuffer commandBuffer, uint firstAttachment, uint attachmentCount, ref VkColorBlendEquationEXT pColorBlendEquations)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetColorBlendEquationEXT(VkCommandBuffer commandBuffer, uint firstAttachment, uint attachmentCount, IntPtr pColorBlendEquations)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetColorWriteMaskEXT(VkCommandBuffer commandBuffer, uint firstAttachment, uint attachmentCount, VkColorComponentFlags* pColorWriteMasks)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetColorWriteMaskEXT(VkCommandBuffer commandBuffer, uint firstAttachment, uint attachmentCount, ref VkColorComponentFlags pColorWriteMasks)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetColorWriteMaskEXT(VkCommandBuffer commandBuffer, uint firstAttachment, uint attachmentCount, IntPtr pColorWriteMasks)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetConservativeRasterizationModeEXT(VkCommandBuffer commandBuffer, VkConservativeRasterizationModeEXT conservativeRasterizationMode)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetCoverageModulationModeNV(VkCommandBuffer commandBuffer, VkCoverageModulationModeNV coverageModulationMode)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetCoverageModulationTableEnableNV(VkCommandBuffer commandBuffer, VkBool32 coverageModulationTableEnable)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetCoverageModulationTableNV(VkCommandBuffer commandBuffer, uint coverageModulationTableCount, float* pCoverageModulationTable)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetCoverageModulationTableNV(VkCommandBuffer commandBuffer, uint coverageModulationTableCount, ref float pCoverageModulationTable)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetCoverageModulationTableNV(VkCommandBuffer commandBuffer, uint coverageModulationTableCount, IntPtr pCoverageModulationTable)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetCoverageReductionModeNV(VkCommandBuffer commandBuffer, VkCoverageReductionModeNV coverageReductionMode)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetCoverageToColorEnableNV(VkCommandBuffer commandBuffer, VkBool32 coverageToColorEnable)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetCoverageToColorLocationNV(VkCommandBuffer commandBuffer, uint coverageToColorLocation)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetDepthClampEnableEXT(VkCommandBuffer commandBuffer, VkBool32 depthClampEnable)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetDepthClipEnableEXT(VkCommandBuffer commandBuffer, VkBool32 depthClipEnable)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetDepthClipNegativeOneToOneEXT(VkCommandBuffer commandBuffer, VkBool32 negativeOneToOne)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetExtraPrimitiveOverestimationSizeEXT(VkCommandBuffer commandBuffer, float extraPrimitiveOverestimationSize)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetLineRasterizationModeEXT(VkCommandBuffer commandBuffer, VkLineRasterizationModeEXT lineRasterizationMode)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetLineStippleEnableEXT(VkCommandBuffer commandBuffer, VkBool32 stippledLineEnable)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetLogicOpEnableEXT(VkCommandBuffer commandBuffer, VkBool32 logicOpEnable)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetPolygonModeEXT(VkCommandBuffer commandBuffer, VkPolygonMode polygonMode)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetProvokingVertexModeEXT(VkCommandBuffer commandBuffer, VkProvokingVertexModeEXT provokingVertexMode)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetRasterizationSamplesEXT(VkCommandBuffer commandBuffer, VkSampleCountFlags rasterizationSamples)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetRasterizationStreamEXT(VkCommandBuffer commandBuffer, uint rasterizationStream)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetRepresentativeFragmentTestEnableNV(VkCommandBuffer commandBuffer, VkBool32 representativeFragmentTestEnable)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetSampleLocationsEnableEXT(VkCommandBuffer commandBuffer, VkBool32 sampleLocationsEnable)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetSampleMaskEXT(VkCommandBuffer commandBuffer, VkSampleCountFlags samples, uint* pSampleMask)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetSampleMaskEXT(VkCommandBuffer commandBuffer, VkSampleCountFlags samples, ref uint pSampleMask)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetSampleMaskEXT(VkCommandBuffer commandBuffer, VkSampleCountFlags samples, IntPtr pSampleMask)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetShadingRateImageEnableNV(VkCommandBuffer commandBuffer, VkBool32 shadingRateImageEnable)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetTessellationDomainOriginEXT(VkCommandBuffer commandBuffer, VkTessellationDomainOrigin domainOrigin)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetViewportSwizzleNV(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkViewportSwizzleNV* pViewportSwizzles)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetViewportSwizzleNV(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, ref VkViewportSwizzleNV pViewportSwizzles)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetViewportSwizzleNV(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, IntPtr pViewportSwizzles)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdSetViewportWScalingEnableNV(VkCommandBuffer commandBuffer, VkBool32 viewportWScalingEnable)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanEXTShaderModuleIdentifier
        {
            private IntPtr vkGetShaderModuleCreateInfoIdentifierEXT_ptr;
            private IntPtr vkGetShaderModuleIdentifierEXT_ptr;

            public VulkanEXTShaderModuleIdentifier(VkDevice device)
            {
                vkGetShaderModuleCreateInfoIdentifierEXT_ptr = LoadDeviceProcAddr(device, "vkGetShaderModuleCreateInfoIdentifierEXT");
                vkGetShaderModuleIdentifierEXT_ptr = LoadDeviceProcAddr(device, "vkGetShaderModuleIdentifierEXT");
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetShaderModuleCreateInfoIdentifierEXT(VkDevice device, VkShaderModuleCreateInfo* pCreateInfo, VkShaderModuleIdentifierEXT* pIdentifier)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetShaderModuleCreateInfoIdentifierEXT(VkDevice device, VkShaderModuleCreateInfo* pCreateInfo, out VkShaderModuleIdentifierEXT pIdentifier)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetShaderModuleCreateInfoIdentifierEXT(VkDevice device, ref VkShaderModuleCreateInfo pCreateInfo, VkShaderModuleIdentifierEXT* pIdentifier)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetShaderModuleCreateInfoIdentifierEXT(VkDevice device, ref VkShaderModuleCreateInfo pCreateInfo, out VkShaderModuleIdentifierEXT pIdentifier)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetShaderModuleCreateInfoIdentifierEXT(VkDevice device, IntPtr pCreateInfo, VkShaderModuleIdentifierEXT* pIdentifier)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetShaderModuleCreateInfoIdentifierEXT(VkDevice device, IntPtr pCreateInfo, out VkShaderModuleIdentifierEXT pIdentifier)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetShaderModuleIdentifierEXT(VkDevice device, VkShaderModule shaderModule, VkShaderModuleIdentifierEXT* pIdentifier)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkGetShaderModuleIdentifierEXT(VkDevice device, VkShaderModule shaderModule, out VkShaderModuleIdentifierEXT pIdentifier)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanNVOpticalFlow
        {
            private IntPtr vkBindOpticalFlowSessionImageNV_ptr;
            private IntPtr vkCmdOpticalFlowExecuteNV_ptr;
            private IntPtr vkCreateOpticalFlowSessionNV_ptr;
            private IntPtr vkDestroyOpticalFlowSessionNV_ptr;
            private IntPtr vkGetPhysicalDeviceOpticalFlowImageFormatsNV_ptr;

            public VulkanNVOpticalFlow(VkDevice device)
            {
                vkBindOpticalFlowSessionImageNV_ptr = LoadDeviceProcAddr(device, "vkBindOpticalFlowSessionImageNV");
                vkCmdOpticalFlowExecuteNV_ptr = LoadDeviceProcAddr(device, "vkCmdOpticalFlowExecuteNV");
                vkCreateOpticalFlowSessionNV_ptr = LoadDeviceProcAddr(device, "vkCreateOpticalFlowSessionNV");
                vkDestroyOpticalFlowSessionNV_ptr = LoadDeviceProcAddr(device, "vkDestroyOpticalFlowSessionNV");
                vkGetPhysicalDeviceOpticalFlowImageFormatsNV_ptr = LoadDeviceProcAddr(device, "vkGetPhysicalDeviceOpticalFlowImageFormatsNV");
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkBindOpticalFlowSessionImageNV(VkDevice device, VkOpticalFlowSessionNV session, VkOpticalFlowSessionBindingPointNV bindingPoint, VkImageView view, VkImageLayout layout)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdOpticalFlowExecuteNV(VkCommandBuffer commandBuffer, VkOpticalFlowSessionNV session, VkOpticalFlowExecuteInfoNV* pExecuteInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdOpticalFlowExecuteNV(VkCommandBuffer commandBuffer, VkOpticalFlowSessionNV session, ref VkOpticalFlowExecuteInfoNV pExecuteInfo)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkCmdOpticalFlowExecuteNV(VkCommandBuffer commandBuffer, VkOpticalFlowSessionNV session, IntPtr pExecuteInfo)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateOpticalFlowSessionNV(VkDevice device, VkOpticalFlowSessionCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, VkOpticalFlowSessionNV* pSession)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateOpticalFlowSessionNV(VkDevice device, VkOpticalFlowSessionCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkOpticalFlowSessionNV pSession)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateOpticalFlowSessionNV(VkDevice device, VkOpticalFlowSessionCreateInfoNV* pCreateInfo, ref VkAllocationCallbacks pAllocator, VkOpticalFlowSessionNV* pSession)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateOpticalFlowSessionNV(VkDevice device, VkOpticalFlowSessionCreateInfoNV* pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkOpticalFlowSessionNV pSession)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateOpticalFlowSessionNV(VkDevice device, VkOpticalFlowSessionCreateInfoNV* pCreateInfo, IntPtr pAllocator, VkOpticalFlowSessionNV* pSession)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateOpticalFlowSessionNV(VkDevice device, VkOpticalFlowSessionCreateInfoNV* pCreateInfo, IntPtr pAllocator, out VkOpticalFlowSessionNV pSession)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateOpticalFlowSessionNV(VkDevice device, ref VkOpticalFlowSessionCreateInfoNV pCreateInfo, VkAllocationCallbacks* pAllocator, VkOpticalFlowSessionNV* pSession)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateOpticalFlowSessionNV(VkDevice device, ref VkOpticalFlowSessionCreateInfoNV pCreateInfo, VkAllocationCallbacks* pAllocator, out VkOpticalFlowSessionNV pSession)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateOpticalFlowSessionNV(VkDevice device, ref VkOpticalFlowSessionCreateInfoNV pCreateInfo, ref VkAllocationCallbacks pAllocator, VkOpticalFlowSessionNV* pSession)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateOpticalFlowSessionNV(VkDevice device, ref VkOpticalFlowSessionCreateInfoNV pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkOpticalFlowSessionNV pSession)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateOpticalFlowSessionNV(VkDevice device, ref VkOpticalFlowSessionCreateInfoNV pCreateInfo, IntPtr pAllocator, VkOpticalFlowSessionNV* pSession)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateOpticalFlowSessionNV(VkDevice device, ref VkOpticalFlowSessionCreateInfoNV pCreateInfo, IntPtr pAllocator, out VkOpticalFlowSessionNV pSession)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateOpticalFlowSessionNV(VkDevice device, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, VkOpticalFlowSessionNV* pSession)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateOpticalFlowSessionNV(VkDevice device, IntPtr pCreateInfo, VkAllocationCallbacks* pAllocator, out VkOpticalFlowSessionNV pSession)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateOpticalFlowSessionNV(VkDevice device, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, VkOpticalFlowSessionNV* pSession)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateOpticalFlowSessionNV(VkDevice device, IntPtr pCreateInfo, ref VkAllocationCallbacks pAllocator, out VkOpticalFlowSessionNV pSession)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateOpticalFlowSessionNV(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, VkOpticalFlowSessionNV* pSession)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:VK_ERROR_OUT_OF_HOST_MEMORY, VK_ERROR_INITIALIZATION_FAILED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkCreateOpticalFlowSessionNV(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, out VkOpticalFlowSessionNV pSession)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkDestroyOpticalFlowSessionNV(VkDevice device, VkOpticalFlowSessionNV session, VkAllocationCallbacks* pAllocator)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkDestroyOpticalFlowSessionNV(VkDevice device, VkOpticalFlowSessionNV session, ref VkAllocationCallbacks pAllocator)
            {
                throw CreateUnpatchedException();
            }

            [Generator.CalliRewrite]
            public unsafe void vkDestroyOpticalFlowSessionNV(VkDevice device, VkOpticalFlowSessionNV session, IntPtr pAllocator)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_EXTENSION_NOT_PRESENT, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_FORMAT_NOT_SUPPORTED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceOpticalFlowImageFormatsNV(VkPhysicalDevice physicalDevice, VkOpticalFlowImageFormatInfoNV* pOpticalFlowImageFormatInfo, uint* pFormatCount, VkOpticalFlowImageFormatPropertiesNV* pImageFormatProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_EXTENSION_NOT_PRESENT, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_FORMAT_NOT_SUPPORTED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceOpticalFlowImageFormatsNV(VkPhysicalDevice physicalDevice, VkOpticalFlowImageFormatInfoNV* pOpticalFlowImageFormatInfo, uint* pFormatCount, out VkOpticalFlowImageFormatPropertiesNV pImageFormatProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_EXTENSION_NOT_PRESENT, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_FORMAT_NOT_SUPPORTED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceOpticalFlowImageFormatsNV(VkPhysicalDevice physicalDevice, VkOpticalFlowImageFormatInfoNV* pOpticalFlowImageFormatInfo, ref uint pFormatCount, VkOpticalFlowImageFormatPropertiesNV* pImageFormatProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_EXTENSION_NOT_PRESENT, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_FORMAT_NOT_SUPPORTED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceOpticalFlowImageFormatsNV(VkPhysicalDevice physicalDevice, VkOpticalFlowImageFormatInfoNV* pOpticalFlowImageFormatInfo, ref uint pFormatCount, out VkOpticalFlowImageFormatPropertiesNV pImageFormatProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_EXTENSION_NOT_PRESENT, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_FORMAT_NOT_SUPPORTED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceOpticalFlowImageFormatsNV(VkPhysicalDevice physicalDevice, VkOpticalFlowImageFormatInfoNV* pOpticalFlowImageFormatInfo, IntPtr pFormatCount, VkOpticalFlowImageFormatPropertiesNV* pImageFormatProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_EXTENSION_NOT_PRESENT, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_FORMAT_NOT_SUPPORTED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceOpticalFlowImageFormatsNV(VkPhysicalDevice physicalDevice, VkOpticalFlowImageFormatInfoNV* pOpticalFlowImageFormatInfo, IntPtr pFormatCount, out VkOpticalFlowImageFormatPropertiesNV pImageFormatProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_EXTENSION_NOT_PRESENT, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_FORMAT_NOT_SUPPORTED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceOpticalFlowImageFormatsNV(VkPhysicalDevice physicalDevice, ref VkOpticalFlowImageFormatInfoNV pOpticalFlowImageFormatInfo, uint* pFormatCount, VkOpticalFlowImageFormatPropertiesNV* pImageFormatProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_EXTENSION_NOT_PRESENT, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_FORMAT_NOT_SUPPORTED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceOpticalFlowImageFormatsNV(VkPhysicalDevice physicalDevice, ref VkOpticalFlowImageFormatInfoNV pOpticalFlowImageFormatInfo, uint* pFormatCount, out VkOpticalFlowImageFormatPropertiesNV pImageFormatProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_EXTENSION_NOT_PRESENT, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_FORMAT_NOT_SUPPORTED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceOpticalFlowImageFormatsNV(VkPhysicalDevice physicalDevice, ref VkOpticalFlowImageFormatInfoNV pOpticalFlowImageFormatInfo, ref uint pFormatCount, VkOpticalFlowImageFormatPropertiesNV* pImageFormatProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_EXTENSION_NOT_PRESENT, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_FORMAT_NOT_SUPPORTED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceOpticalFlowImageFormatsNV(VkPhysicalDevice physicalDevice, ref VkOpticalFlowImageFormatInfoNV pOpticalFlowImageFormatInfo, ref uint pFormatCount, out VkOpticalFlowImageFormatPropertiesNV pImageFormatProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_EXTENSION_NOT_PRESENT, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_FORMAT_NOT_SUPPORTED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceOpticalFlowImageFormatsNV(VkPhysicalDevice physicalDevice, ref VkOpticalFlowImageFormatInfoNV pOpticalFlowImageFormatInfo, IntPtr pFormatCount, VkOpticalFlowImageFormatPropertiesNV* pImageFormatProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_EXTENSION_NOT_PRESENT, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_FORMAT_NOT_SUPPORTED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceOpticalFlowImageFormatsNV(VkPhysicalDevice physicalDevice, ref VkOpticalFlowImageFormatInfoNV pOpticalFlowImageFormatInfo, IntPtr pFormatCount, out VkOpticalFlowImageFormatPropertiesNV pImageFormatProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_EXTENSION_NOT_PRESENT, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_FORMAT_NOT_SUPPORTED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceOpticalFlowImageFormatsNV(VkPhysicalDevice physicalDevice, IntPtr pOpticalFlowImageFormatInfo, uint* pFormatCount, VkOpticalFlowImageFormatPropertiesNV* pImageFormatProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_EXTENSION_NOT_PRESENT, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_FORMAT_NOT_SUPPORTED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceOpticalFlowImageFormatsNV(VkPhysicalDevice physicalDevice, IntPtr pOpticalFlowImageFormatInfo, uint* pFormatCount, out VkOpticalFlowImageFormatPropertiesNV pImageFormatProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_EXTENSION_NOT_PRESENT, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_FORMAT_NOT_SUPPORTED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceOpticalFlowImageFormatsNV(VkPhysicalDevice physicalDevice, IntPtr pOpticalFlowImageFormatInfo, ref uint pFormatCount, VkOpticalFlowImageFormatPropertiesNV* pImageFormatProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_EXTENSION_NOT_PRESENT, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_FORMAT_NOT_SUPPORTED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceOpticalFlowImageFormatsNV(VkPhysicalDevice physicalDevice, IntPtr pOpticalFlowImageFormatInfo, ref uint pFormatCount, out VkOpticalFlowImageFormatPropertiesNV pImageFormatProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_EXTENSION_NOT_PRESENT, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_FORMAT_NOT_SUPPORTED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceOpticalFlowImageFormatsNV(VkPhysicalDevice physicalDevice, IntPtr pOpticalFlowImageFormatInfo, IntPtr pFormatCount, VkOpticalFlowImageFormatPropertiesNV* pImageFormatProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:VK_ERROR_EXTENSION_NOT_PRESENT, VK_ERROR_INITIALIZATION_FAILED, VK_ERROR_FORMAT_NOT_SUPPORTED</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetPhysicalDeviceOpticalFlowImageFormatsNV(VkPhysicalDevice physicalDevice, IntPtr pOpticalFlowImageFormatInfo, IntPtr pFormatCount, out VkOpticalFlowImageFormatPropertiesNV pImageFormatProperties)
            {
                throw CreateUnpatchedException();
            }
        }

        public unsafe sealed class VulkanQcomTileProperties
        {
            private IntPtr vkGetDynamicRenderingTilePropertiesQCOM_ptr;
            private IntPtr vkGetFramebufferTilePropertiesQCOM_ptr;

            public VulkanQcomTileProperties(VkDevice device)
            {
                vkGetDynamicRenderingTilePropertiesQCOM_ptr = LoadDeviceProcAddr(device, "vkGetDynamicRenderingTilePropertiesQCOM");
                vkGetFramebufferTilePropertiesQCOM_ptr = LoadDeviceProcAddr(device, "vkGetFramebufferTilePropertiesQCOM");
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetDynamicRenderingTilePropertiesQCOM(VkDevice device, VkRenderingInfo* pRenderingInfo, VkTilePropertiesQCOM* pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetDynamicRenderingTilePropertiesQCOM(VkDevice device, VkRenderingInfo* pRenderingInfo, out VkTilePropertiesQCOM pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetDynamicRenderingTilePropertiesQCOM(VkDevice device, ref VkRenderingInfo pRenderingInfo, VkTilePropertiesQCOM* pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetDynamicRenderingTilePropertiesQCOM(VkDevice device, ref VkRenderingInfo pRenderingInfo, out VkTilePropertiesQCOM pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetDynamicRenderingTilePropertiesQCOM(VkDevice device, IntPtr pRenderingInfo, VkTilePropertiesQCOM* pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS. Error codes:</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetDynamicRenderingTilePropertiesQCOM(VkDevice device, IntPtr pRenderingInfo, out VkTilePropertiesQCOM pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetFramebufferTilePropertiesQCOM(VkDevice device, VkFramebuffer framebuffer, uint* pPropertiesCount, VkTilePropertiesQCOM* pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetFramebufferTilePropertiesQCOM(VkDevice device, VkFramebuffer framebuffer, uint* pPropertiesCount, out VkTilePropertiesQCOM pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetFramebufferTilePropertiesQCOM(VkDevice device, VkFramebuffer framebuffer, ref uint pPropertiesCount, VkTilePropertiesQCOM* pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetFramebufferTilePropertiesQCOM(VkDevice device, VkFramebuffer framebuffer, ref uint pPropertiesCount, out VkTilePropertiesQCOM pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetFramebufferTilePropertiesQCOM(VkDevice device, VkFramebuffer framebuffer, IntPtr pPropertiesCount, VkTilePropertiesQCOM* pProperties)
            {
                throw CreateUnpatchedException();
            }

            ///<remarks>Success codes:VK_SUCCESS, VK_INCOMPLETE. Error codes:</remarks>
            [Generator.CalliRewrite]
            public unsafe VkResult vkGetFramebufferTilePropertiesQCOM(VkDevice device, VkFramebuffer framebuffer, IntPtr pPropertiesCount, out VkTilePropertiesQCOM pProperties)
            {
                throw CreateUnpatchedException();
            }
        }

    }
}
