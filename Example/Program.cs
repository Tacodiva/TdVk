/*
 * This example was written by Tacodiva following the Vulkan tutorial at https://vulkan-tutorial.com/
 */

#nullable disable

using Vulkan;
using static Vulkan.VulkanNative;
using static Vulkan.RawConstants;

using GLFW;
using System;
using System.Collections.Generic;
using System.IO;

VulkanTutorial.Run();

unsafe static class VulkanTutorial
{

    public static readonly StringPtr ApplicationName = StringPtr.Allocate("Hello Triangle");
    public static readonly uint ApplicationVersion = VK_MAKE_VERSION(1, 0, 0);

    public static readonly StringPtr EngineName = StringPtr.Allocate("Triangle Engine");
    public static readonly uint EngineVersion = VK_MAKE_VERSION(1, 0, 0);

    private static Window Window;
    private static VkSurfaceKHR Surface;
    private const int WindowWidth = 800;
    private const int WindowHeight = 600;

    private static readonly string[] ValidationLayers = {
        "VK_LAYER_KHRONOS_validation",
    };

#if DEBUG
    private static readonly bool EnableValidationLayers = true;
#else
    private static readonly bool EnableValidationLayers = false;
#endif
    private static VulkanEXTDebugUtils DebugUtilsExt;
    private static VkDebugUtilsMessengerEXT DebugMessenger;

    public static readonly string[] DeviceExtensions = {
        VK_KHR_SWAPCHAIN_EXTENSION_NAME
    };

    private static VkInstance Instance;
    private static VkPhysicalDevice PhysicalDevice;
    private static VkDevice Device;

    private static VkQueue GraphicsQueue;
    private static VkQueue PresentQueue;

    private static VkSwapchainKHR SwapChain;
    private static VkImage[] SwapChainImages;
    private static VkFormat SwapChainImageFormat;
    private static VkExtent2D SwapChainExtent;
    private static VkImageView[] SwapChainImageViews;
    private static VkFramebuffer[] SwapChainFramebuffers;

    private static VkRenderPass RenderPass;
    private static VkPipelineLayout PipelineLayout;
    private static VkPipeline GraphicsPipeline;

    private const int MaxFramesInFlight = 2;

    private static VkCommandPool CommandPool;
    private static VkCommandBuffer[] CommandBuffers;

    private static VkSemaphore[] ImageAvailableSemaphores;
    private static VkSemaphore[] RenderFinishedSemaphores;
    private static VkFence[] InFlightFences;

    private static bool FramebufferResized = false;

    public record struct QueueFamilyIndices
    {
        public uint? GraphicsFamily;
        public uint? PresentFamily;

        public bool IsComplete()
        {
            return GraphicsFamily.HasValue && PresentFamily.HasValue;
        }
    }

    public struct SwapChainSupportDetails
    {
        public VkSurfaceCapabilitiesKHR Capabilities;
        public VkSurfaceFormatKHR[] Formats;
        public VkPresentModeKHR[] PresentModes;
    };

    public static void Run()
    {
        InitWindow();
        InitVulkan();
        MainLoop();
        Cleanup();
    }

    private static void InitWindow()
    {
        Glfw.WindowHint(Hint.ClientApi, ClientApi.None);
        Window = Glfw.CreateWindow(WindowWidth, WindowHeight, "Vulkan", GLFW.Monitor.None, Window.None);
        Glfw.SetFramebufferSizeCallback(Window, (window, width, height) =>
        {
            FramebufferResized = true;
        });
    }


    private static void InitVulkan()
    {
        CreateInstance();
        SetupDebugMessenger();
        CreateSurface();
        PickPhysicalDevice();
        CreateLogicalDevice();
        CreateSwapChain();
        CreateImageViews();
        CreateRenderPass();
        CreateGraphicsPipeline();
        CreateFramebuffers();
        CreateCommandPool();
        CreateCommandBuffers();
        CreateSyncObjects();
    }

    private static void CreateInstance()
    {
        if (EnableValidationLayers && !CheckValidationLayerSupport())
        {
            throw new SystemException("validation layers requested, but not available!");
        }

        VkApplicationInfo appInfo = new VkApplicationInfo()
        {
            sType = VkStructureType.ApplicationInfo,
            pApplicationName = ApplicationName,
            applicationVersion = ApplicationVersion,
            pEngineName = EngineName,
            engineVersion = EngineVersion,
            apiVersion = VK_MAKE_VERSION(1, 0, 0)
        };

        VkInstanceCreateInfo createInfo = new VkInstanceCreateInfo()
        {
            sType = VkStructureType.InstanceCreateInfo,
            pApplicationInfo = &appInfo
        };

        List<string> requiredExtentions = GetRequiredExtensions();

        // 'Checking for extension support'
        uint extensionCount;
        vkEnumerateInstanceExtensionProperties((byte*)null, &extensionCount, null);
        VkExtensionProperties[] extensions = new VkExtensionProperties[extensionCount];

        fixed (VkExtensionProperties* extensionsPtr = extensions)
            vkEnumerateInstanceExtensionProperties((byte*)null, &extensionCount, extensionsPtr);

        Console.WriteLine("available extensions:");

        foreach (VkExtensionProperties extension in extensions)
        {
            Console.WriteLine("\t" + new StringPtr(extension.extensionName));
        }

        // Convert our nice C# string objects in requiredExtentions and ValidationLayers to pointers to
        //  C strings using StringPtr.Allocate. These need to be freed below as to not leak memory. 
        byte** enabledExtensionNames = stackalloc byte*[requiredExtentions.Count];
        for (int i = 0; i < requiredExtentions.Count; i++)
            enabledExtensionNames[i] = StringPtr.Allocate(requiredExtentions[i]);
        createInfo.enabledExtensionCount = (uint)requiredExtentions.Count;
        createInfo.ppEnabledExtensionNames = enabledExtensionNames;

        VkDebugUtilsMessengerCreateInfoEXT debugCreateInfo = default;

        if (EnableValidationLayers)
        {
            byte** enabledLayerNames = stackalloc byte*[ValidationLayers.Length];
            for (int i = 0; i < ValidationLayers.Length; i++)
                enabledLayerNames[i] = StringPtr.Allocate(ValidationLayers[i]);
            createInfo.enabledLayerCount = (uint)ValidationLayers.Length;
            createInfo.ppEnabledLayerNames = enabledLayerNames;

            PopulateDebugMessengerCreateInfo(ref debugCreateInfo);
            createInfo.pNext = &debugCreateInfo;
        }
        else
        {
            createInfo.enabledLayerCount = 0;
            createInfo.pNext = null;
        }

        if (vkCreateInstance(&createInfo, null, out VkInstance instance) != VK_SUCCESS)
        {
            throw new SystemException("failed to create instance!");
        }
        Instance = instance;

        // Free our string created above
        for (int i = 0; i < requiredExtentions.Count; i++)
            StringPtr.Free(enabledExtensionNames[i]);

        if (EnableValidationLayers)
            for (int i = 0; i < ValidationLayers.Length; i++)
                StringPtr.Free(createInfo.ppEnabledLayerNames[i]);
    }

    private static bool CheckValidationLayerSupport()
    {
        uint layerCount;
        vkEnumerateInstanceLayerProperties(&layerCount, null);

        VkLayerProperties[] availableLayers = new VkLayerProperties[layerCount];

        fixed (VkLayerProperties* avalibleLayersPtr = availableLayers)
            vkEnumerateInstanceLayerProperties(&layerCount, avalibleLayersPtr);

        foreach (string layerName in ValidationLayers)
        {
            bool layerFound = false;

            foreach (VkLayerProperties layerProperties in availableLayers)
            {
                if (layerName == new StringPtr(layerProperties.layerName))
                {
                    layerFound = true;
                    break;
                }
            }

            if (!layerFound)
                return false;
        }

        return true;
    }

    private static List<string> GetRequiredExtensions()
    {
        List<string> extensions = new List<string>();

        extensions.AddRange(Glfw.Vulkan.GetRequiredInstanceExtensions());

        if (EnableValidationLayers)
        {
            extensions.Add(VK_EXT_DEBUG_UTILS_EXTENSION_NAME);
        }

        return extensions;
    }

    private static void SetupDebugMessenger()
    {
        if (!EnableValidationLayers) return;

        DebugUtilsExt = new VulkanEXTDebugUtils(Instance);

        VkDebugUtilsMessengerCreateInfoEXT createInfo = default;
        PopulateDebugMessengerCreateInfo(ref createInfo);
        VkDebugUtilsMessengerEXT extension;
        DebugUtilsExt.vkCreateDebugUtilsMessengerEXT(Instance, &createInfo, null, &extension);
        DebugMessenger = extension;
    }

    private static void PopulateDebugMessengerCreateInfo(ref VkDebugUtilsMessengerCreateInfoEXT createInfo)
    {
        createInfo.sType = VkStructureType.DebugUtilsMessengerCreateInfoEXT;
        createInfo.messageSeverity = VkDebugUtilsMessageSeverityFlagsEXT.VerboseEXT
            | VkDebugUtilsMessageSeverityFlagsEXT.WarningEXT | VkDebugUtilsMessageSeverityFlagsEXT.ErrorEXT;
        createInfo.messageType = VkDebugUtilsMessageTypeFlagsEXT.GeneralEXT
            | VkDebugUtilsMessageTypeFlagsEXT.ValidationEXT | VkDebugUtilsMessageTypeFlagsEXT.PerformanceEXT;
        createInfo.pfnUserCallback = new FuncPtr<PFN_vkDebugUtilsMessengerCallbackEXT>(DebugCallback);
    }

    private static VkBool32 DebugCallback(VkDebugUtilsMessageSeverityFlagsEXT messageSeverity, VkDebugUtilsMessageTypeFlagsEXT messageType, VkDebugUtilsMessengerCallbackDataEXT* pCallbackData, void* pUserData)
    {
        Console.Error.WriteLine("validation layer: " + new StringPtr(pCallbackData->pMessage));
        return false;
    }

    private static void CreateSurface()
    {
        if ((VkResult)Glfw.Vulkan.CreateWindowSurface(Instance.Handle, Window, IntPtr.Zero, out ulong surfaceHandle) != VK_SUCCESS)
        {
            throw new SystemException("failed to create window surface!");
        }
        Surface = surfaceHandle;
    }

    private static void PickPhysicalDevice()
    {
        uint deviceCount = 0;
        vkEnumeratePhysicalDevices(Instance, &deviceCount, null);

        if (deviceCount == 0)
            throw new SystemException("failed to find GPUs with Vulkan support!");

        VkPhysicalDevice[] devices = new VkPhysicalDevice[deviceCount];

        fixed (VkPhysicalDevice* devicesPtr = devices)
            vkEnumeratePhysicalDevices(Instance, &deviceCount, devicesPtr);

        foreach (VkPhysicalDevice device in devices)
        {
            if (IsDeviceSuitable(device))
            {
                PhysicalDevice = device;
                break;
            }
        }

        if (PhysicalDevice.Handle == IntPtr.Zero)
        {
            throw new SystemException("failed to find a suitable GPU!");
        }
    }

    private static bool IsDeviceSuitable(VkPhysicalDevice device)
    {
        QueueFamilyIndices indices = FindQueueFamilies(device);

        bool extensionsSupported = CheckDeviceExtensionSupport(device);

        bool swapChainAdequate = false;
        if (extensionsSupported)
        {
            SwapChainSupportDetails swapChainSupport = QuerySwapChainSupport(device);
            swapChainAdequate = swapChainSupport.Formats.Length != 0 && swapChainSupport.PresentModes.Length != 0;
        }

        return indices.IsComplete() && extensionsSupported && swapChainAdequate;
    }

    private static QueueFamilyIndices FindQueueFamilies(VkPhysicalDevice device)
    {
        QueueFamilyIndices indices = default;

        uint queueFamilyCount = 0;
        vkGetPhysicalDeviceQueueFamilyProperties(device, &queueFamilyCount, null);

        VkQueueFamilyProperties[] queueFamilies = new VkQueueFamilyProperties[queueFamilyCount];

        fixed (VkQueueFamilyProperties* queueFamiliesPtr = queueFamilies)
            vkGetPhysicalDeviceQueueFamilyProperties(device, &queueFamilyCount, queueFamiliesPtr);

        uint i = 0;
        foreach (VkQueueFamilyProperties queueFamily in queueFamilies)
        {
            if ((queueFamily.queueFlags & VkQueueFlags.Graphics) != 0)
            {
                indices.GraphicsFamily = i;
            }

            vkGetPhysicalDeviceSurfaceSupportKHR(device, i, Surface, out VkBool32 presentSupport);
            if (presentSupport)
            {
                indices.PresentFamily = i;
            }

            if (indices.IsComplete())
                break;

            i++;
        }

        return indices;
    }

    private static bool CheckDeviceExtensionSupport(VkPhysicalDevice device)
    {
        uint extensionCount;
        vkEnumerateDeviceExtensionProperties(device, (byte*)null, &extensionCount, null);
        VkExtensionProperties[] availableExtensions = new VkExtensionProperties[extensionCount];

        fixed (VkExtensionProperties* availableExtensionsPtr = availableExtensions)
            vkEnumerateDeviceExtensionProperties(device, (byte*)null, &extensionCount, availableExtensionsPtr);

        HashSet<string> requiredExtensions = new HashSet<string>(DeviceExtensions);

        foreach (VkExtensionProperties extension in availableExtensions)
        {
            requiredExtensions.Remove(new StringPtr(extension.extensionName));
        }

        return requiredExtensions.Count == 0;
    }

    private static SwapChainSupportDetails QuerySwapChainSupport(VkPhysicalDevice device)
    {
        SwapChainSupportDetails details = default;

        vkGetPhysicalDeviceSurfaceCapabilitiesKHR(device, Surface, &details.Capabilities);

        uint formatCount;
        vkGetPhysicalDeviceSurfaceFormatsKHR(device, Surface, &formatCount, null);
        details.Formats = new VkSurfaceFormatKHR[formatCount];
        fixed (VkSurfaceFormatKHR* formatsPtr = details.Formats)
            vkGetPhysicalDeviceSurfaceFormatsKHR(device, Surface, &formatCount, formatsPtr);

        uint presentModeCount;
        vkGetPhysicalDeviceSurfacePresentModesKHR(device, Surface, &presentModeCount, null);
        details.PresentModes = new VkPresentModeKHR[presentModeCount];
        fixed (VkPresentModeKHR* presentModesPtr = details.PresentModes)
            vkGetPhysicalDeviceSurfacePresentModesKHR(device, Surface, &presentModeCount, presentModesPtr);


        return details;
    }

    private static void CreateLogicalDevice()
    {
        QueueFamilyIndices indices = FindQueueFamilies(PhysicalDevice);

        HashSet<uint> uniqueQueueFamilies = new HashSet<uint> {
            indices.GraphicsFamily.Value,
            indices.PresentFamily.Value
        };
        VkDeviceQueueCreateInfo* queueCreateInfos = stackalloc VkDeviceQueueCreateInfo[uniqueQueueFamilies.Count];

        float queuePriority = 1.0f;
        {
            int i = 0;
            foreach (uint queueFamily in uniqueQueueFamilies)
            {
                queueCreateInfos[i] = new()
                {
                    sType = VkStructureType.DeviceQueueCreateInfo,
                    queueFamilyIndex = indices.GraphicsFamily.Value,
                    queueCount = 1,
                    pQueuePriorities = &queuePriority
                };
                ++i;
            }
        }

        VkPhysicalDeviceFeatures deviceFeatures = new();

        VkDeviceCreateInfo createInfo = new()
        {
            sType = VkStructureType.DeviceCreateInfo,

            pQueueCreateInfos = queueCreateInfos,
            queueCreateInfoCount = (uint)uniqueQueueFamilies.Count,

            pEnabledFeatures = &deviceFeatures
        };

        byte** enabledExtensionNames = stackalloc byte*[DeviceExtensions.Length];
        for (int i = 0; i < DeviceExtensions.Length; i++)
            enabledExtensionNames[i] = StringPtr.Allocate(DeviceExtensions[i]);
        createInfo.enabledExtensionCount = (uint)DeviceExtensions.Length;
        createInfo.ppEnabledExtensionNames = enabledExtensionNames;

        if (EnableValidationLayers)
        {
            byte** enabledLayerNames = stackalloc byte*[ValidationLayers.Length];
            for (int i = 0; i < ValidationLayers.Length; i++)
                enabledLayerNames[i] = StringPtr.Allocate(ValidationLayers[i]);
            createInfo.enabledLayerCount = (uint)ValidationLayers.Length;
            createInfo.ppEnabledLayerNames = enabledLayerNames;
        }
        else
        {
            createInfo.enabledLayerCount = 0;
        }

        if (vkCreateDevice(PhysicalDevice, &createInfo, null, out VkDevice device) != VK_SUCCESS)
        {
            throw new SystemException("failed ot create logical device!");
        }
        Device = device;

        for (int i = 0; i < DeviceExtensions.Length; i++)
            StringPtr.Free(enabledExtensionNames[i]);
        if (EnableValidationLayers)
            for (int i = 0; i < ValidationLayers.Length; i++)
                StringPtr.Free(createInfo.ppEnabledLayerNames[i]);

        vkGetDeviceQueue(Device, indices.GraphicsFamily.Value, 0, out VkQueue graphicsQueue);
        GraphicsQueue = graphicsQueue;

        vkGetDeviceQueue(Device, indices.PresentFamily.Value, 0, out VkQueue presentQueue);
        PresentQueue = presentQueue;
    }

    private static VkSurfaceFormatKHR ChooseSwapSurfaceFormat(VkSurfaceFormatKHR[] availableFormats)
    {
        foreach (VkSurfaceFormatKHR availableFormat in availableFormats)
        {
            if (availableFormat.format == VkFormat.B8g8r8a8Srgb && availableFormat.colorSpace == VkColorSpaceKHR.SrgbNonlinearKHR)
            {
                return availableFormat;
            }
        }
        return availableFormats[0];
    }

    private static VkPresentModeKHR ChooseSwapPresentMode(VkPresentModeKHR[] availablePresentModes)
    {
        foreach (VkPresentModeKHR availablePresentMode in availablePresentModes)
        {
            if (availablePresentMode == VkPresentModeKHR.MailboxKHR)
            {
                return availablePresentMode;
            }
        }
        return VkPresentModeKHR.FifoKHR;
    }

    private static VkExtent2D ChooseSwapExtent(VkSurfaceCapabilitiesKHR capabilities)
    {
        if (capabilities.currentExtent.width != uint.MaxValue)
        {
            return capabilities.currentExtent;
        }
        else
        {
            Glfw.GetFramebufferSize(Window, out int width, out int height);

            VkExtent2D actualExtent = new VkExtent2D(width, height);

            actualExtent.width = Math.Clamp(actualExtent.width, capabilities.minImageExtent.width, capabilities.maxImageExtent.width);
            actualExtent.width = Math.Clamp(actualExtent.height, capabilities.minImageExtent.height, capabilities.maxImageExtent.height);

            return actualExtent;
        }
    }

    private static void RecreateSwapChain()
    {
        Glfw.GetWindowSize(Window, out int width, out int height);
        while (width == 0 || height == 0)
        {
            Glfw.GetWindowSize(Window, out width, out height);
            Glfw.WaitEvents();
        }

        Console.WriteLine("Recreating swapchain with " + width + " x" + height);

        vkDeviceWaitIdle(Device);

        CleanupSwapChain();
        vkDestroyPipeline(Device, GraphicsPipeline, null);
        vkDestroyPipelineLayout(Device, PipelineLayout, null);
        vkDestroyRenderPass(Device, RenderPass, null);

        CreateSwapChain();
        CreateImageViews();
        CreateRenderPass();
        CreateGraphicsPipeline();
        CreateFramebuffers();
    }

    private static void CreateSwapChain()
    {
        SwapChainSupportDetails swapChainSupport = QuerySwapChainSupport(PhysicalDevice);

        VkSurfaceFormatKHR surfaceFormat = ChooseSwapSurfaceFormat(swapChainSupport.Formats);
        VkPresentModeKHR presentMode = ChooseSwapPresentMode(swapChainSupport.PresentModes);
        VkExtent2D extent = ChooseSwapExtent(swapChainSupport.Capabilities);

        uint imageCount = swapChainSupport.Capabilities.minImageCount + 1;
        if (swapChainSupport.Capabilities.maxImageCount > 0 & imageCount > swapChainSupport.Capabilities.maxImageCount)
        {
            imageCount = swapChainSupport.Capabilities.maxImageCount;
        }

        VkSwapchainCreateInfoKHR createInfo = new()
        {
            sType = VkStructureType.SwapchainCreateInfoKHR,
            surface = Surface,

            minImageCount = imageCount,
            imageFormat = surfaceFormat.format,
            imageColorSpace = surfaceFormat.colorSpace,
            imageExtent = extent,
            imageArrayLayers = 1,
            imageUsage = VkImageUsageFlags.ColorAttachment
        };

        QueueFamilyIndices indices = FindQueueFamilies(PhysicalDevice);
        uint* queueFamilyIndices = stackalloc uint[] {
            indices.GraphicsFamily.Value,
            indices.PresentFamily.Value
        };

        if (indices.GraphicsFamily != indices.PresentFamily)
        {
            createInfo.imageSharingMode = VkSharingMode.Concurrent;
            createInfo.queueFamilyIndexCount = 2;
            createInfo.pQueueFamilyIndices = queueFamilyIndices;
        }
        else
        {
            createInfo.imageSharingMode = VkSharingMode.Exclusive;
            createInfo.queueFamilyIndexCount = 0;
            createInfo.pQueueFamilyIndices = null;
        }

        createInfo.preTransform = swapChainSupport.Capabilities.currentTransform;
        createInfo.compositeAlpha = VkCompositeAlphaFlagsKHR.OpaqueKHR;

        createInfo.presentMode = presentMode;
        createInfo.clipped = true;
        createInfo.oldSwapchain = VkSwapchainKHR.Null;

        if (vkCreateSwapchainKHR(Device, &createInfo, null, out VkSwapchainKHR swapChain) != VkResult.Success)
        {
            throw new SystemException("failed to create swap chain!");
        }
        SwapChain = swapChain;

        vkGetSwapchainImagesKHR(Device, swapChain, &imageCount, null);
        SwapChainImages = new VkImage[imageCount];
        fixed (VkImage* swapChainImagesPtr = SwapChainImages)
            vkGetSwapchainImagesKHR(Device, swapChain, &imageCount, swapChainImagesPtr);

        SwapChainImageFormat = surfaceFormat.format;
        SwapChainExtent = extent;
    }

    private static void CreateImageViews()
    {
        SwapChainImageViews = new VkImageView[SwapChainImages.Length];

        for (int i = 0; i < SwapChainImageViews.Length; i++)
        {
            VkImageViewCreateInfo createInfo = new()
            {
                sType = VkStructureType.ImageViewCreateInfo,
                image = SwapChainImages[i],
                viewType = VkImageViewType.Image2D,
                format = SwapChainImageFormat,
                components = new VkComponentMapping()
                {
                    r = VkComponentSwizzle.Identity,
                    g = VkComponentSwizzle.Identity,
                    b = VkComponentSwizzle.Identity,
                    a = VkComponentSwizzle.Identity,
                },
                subresourceRange = new VkImageSubresourceRange()
                {
                    aspectMask = VkImageAspectFlags.Color,
                    baseMipLevel = 0,
                    levelCount = 1,
                    baseArrayLayer = 0,
                    layerCount = 1
                }
            };

            if (vkCreateImageView(Device, &createInfo, null, out VkImageView view) != VkResult.Success)
            {
                throw new SystemException("failed to create image views!");
            }
            SwapChainImageViews[i] = view;
        }
    }

    private static void CreateRenderPass()
    {
        VkAttachmentDescription colorAttachment = new VkAttachmentDescription()
        {
            format = SwapChainImageFormat,
            samples = VkSampleCountFlags.Count1,

            loadOp = VkAttachmentLoadOp.Clear,
            storeOp = VkAttachmentStoreOp.Store,

            stencilLoadOp = VkAttachmentLoadOp.DontCare,
            stencilStoreOp = VkAttachmentStoreOp.DontCare,

            initialLayout = VkImageLayout.Undefined,
            finalLayout = VkImageLayout.PresentSrcKHR
        };

        VkAttachmentReference colorAttachmentRef = new VkAttachmentReference()
        {
            attachment = 0,
            layout = VkImageLayout.ColorAttachmentOptimal
        };

        VkSubpassDescription subpass = new VkSubpassDescription()
        {
            pipelineBindPoint = VkPipelineBindPoint.Graphics,
            colorAttachmentCount = 1,
            pColorAttachments = &colorAttachmentRef
        };

        VkSubpassDependency renderPassDependency = new VkSubpassDependency()
        {
            srcSubpass = VK_SUBPASS_EXTERNAL,
            dstSubpass = 0,

            srcStageMask = VkPipelineStageFlags.ColorAttachmentOutput,
            srcAccessMask = 0,

            dstStageMask = VkPipelineStageFlags.ColorAttachmentOutput,
            dstAccessMask = VkAccessFlags.ColorAttachmentWrite
        };

        VkRenderPassCreateInfo renderPassCreateInfo = new VkRenderPassCreateInfo()
        {
            sType = VkStructureType.RenderPassCreateInfo,
            attachmentCount = 1,
            pAttachments = &colorAttachment,
            subpassCount = 1,
            pSubpasses = &subpass,

            dependencyCount = 1,
            pDependencies = &renderPassDependency
        };

        if (vkCreateRenderPass(Device, &renderPassCreateInfo, null, out VkRenderPass renderPass) != VkResult.Success)
        {
            throw new SystemException("failed to create render pass!");
        }
        RenderPass = renderPass;
    }

    private static void CreateGraphicsPipeline()
    {
        byte[] vertShaderCode = File.ReadAllBytes("shaders/vert.spv");
        byte[] fragShaderCode = File.ReadAllBytes("shaders/frag.spv");

        VkShaderModule vertShaderModule = CreateShaderModule(vertShaderCode);
        VkShaderModule fragShaderModule = CreateShaderModule(fragShaderCode);

        byte* functionName = StringPtr.Allocate("main");

        VkPipelineShaderStageCreateInfo vertShaderStageInfo = new()
        {
            sType = VkStructureType.PipelineShaderStageCreateInfo,
            stage = VkShaderStageFlags.Vertex,
            module = vertShaderModule,
            pName = functionName
        };

        VkPipelineShaderStageCreateInfo fragShaderStageInfo = new()
        {
            sType = VkStructureType.PipelineShaderStageCreateInfo,
            stage = VkShaderStageFlags.Fragment,
            module = fragShaderModule,
            pName = functionName
        };

        VkPipelineShaderStageCreateInfo[] shaderStages = { vertShaderStageInfo, fragShaderStageInfo };

        VkPipelineVertexInputStateCreateInfo vertexInputInfo = new()
        {
            sType = VkStructureType.PipelineVertexInputStateCreateInfo,
            vertexBindingDescriptionCount = 0,
            pVertexBindingDescriptions = null,
            vertexAttributeDescriptionCount = 0,
            pVertexAttributeDescriptions = null
        };

        VkPipelineInputAssemblyStateCreateInfo inputAssemblyInfo = new()
        {
            sType = VkStructureType.PipelineInputAssemblyStateCreateInfo,
            topology = VkPrimitiveTopology.TriangleList,
            primitiveRestartEnable = false
        };

        VkDynamicState* dynamicStates = stackalloc VkDynamicState[] {
            VkDynamicState.Viewport,
            VkDynamicState.Scissor
        };

        VkPipelineDynamicStateCreateInfo dynamicState = new()
        {
            sType = VkStructureType.PipelineDynamicStateCreateInfo,
            dynamicStateCount = 2,
            pDynamicStates = dynamicStates
        };

        VkPipelineViewportStateCreateInfo viewportState = new()
        {
            sType = VkStructureType.PipelineViewportStateCreateInfo,
            viewportCount = 1,
            scissorCount = 1,
        };

        VkPipelineRasterizationStateCreateInfo rasterizerInfo = new()
        {
            sType = VkStructureType.PipelineRasterizationStateCreateInfo,
            depthClampEnable = false,
            rasterizerDiscardEnable = false,
            polygonMode = VkPolygonMode.Fill,
            lineWidth = 1.0f,
            cullMode = VkCullModeFlags.Back,
            frontFace = VkFrontFace.Clockwise,
            depthBiasEnable = false,
            depthBiasConstantFactor = 0f,
            depthBiasClamp = 0f,
            depthBiasSlopeFactor = 0f
        };

        VkPipelineMultisampleStateCreateInfo multisampleingInfo = new()
        {
            sType = VkStructureType.PipelineMultisampleStateCreateInfo,
            sampleShadingEnable = false,
            rasterizationSamples = VkSampleCountFlags.Count1,
            minSampleShading = 1f,
            pSampleMask = null,
            alphaToCoverageEnable = false,
            alphaToOneEnable = false
        };

        VkPipelineColorBlendAttachmentState colorBlendAttachment = new()
        {
            colorWriteMask = VkColorComponentFlags.R | VkColorComponentFlags.G | VkColorComponentFlags.B | VkColorComponentFlags.A,
            blendEnable = VkBool32.False
        };

        VkPipelineColorBlendStateCreateInfo colorBlendingInfo = new()
        {
            sType = VkStructureType.PipelineColorBlendStateCreateInfo,
            logicOpEnable = VkBool32.False,
            attachmentCount = 1,
            pAttachments = &colorBlendAttachment
        };

        VkPipelineLayoutCreateInfo pipelineCreateInfo = new VkPipelineLayoutCreateInfo()
        {
            sType = VkStructureType.PipelineLayoutCreateInfo
        };

        if (vkCreatePipelineLayout(Device, &pipelineCreateInfo, null, out VkPipelineLayout layout) != VkResult.Success)
        {
            throw new SystemException("failed to create pipline layout");
        }
        PipelineLayout = layout;

        fixed (VkPipelineShaderStageCreateInfo* shaderStagesPtr = shaderStages)
        {
            VkGraphicsPipelineCreateInfo pipelineInfo = new VkGraphicsPipelineCreateInfo()
            {
                sType = VkStructureType.GraphicsPipelineCreateInfo,
                stageCount = 2,
                pStages = shaderStagesPtr,

                pVertexInputState = &vertexInputInfo,
                pInputAssemblyState = &inputAssemblyInfo,
                pViewportState = &viewportState,
                pRasterizationState = &rasterizerInfo,
                pMultisampleState = &multisampleingInfo,
                pDepthStencilState = null,
                pColorBlendState = &colorBlendingInfo,
                pDynamicState = &dynamicState,

                layout = layout,

                renderPass = RenderPass,
                subpass = 0,

                basePipelineHandle = VkPipeline.Null,
                basePipelineIndex = 0
            };

            if (vkCreateGraphicsPipelines(Device, VkPipelineCache.Null, 1, &pipelineInfo, null, out VkPipeline pipeline) != VkResult.Success)
            {
                throw new SystemException("failed to create graphics pipeline!");
            }
            GraphicsPipeline = pipeline;
        }

        StringPtr.Free(functionName);
        vkDestroyShaderModule(Device, fragShaderModule, null);
        vkDestroyShaderModule(Device, vertShaderModule, null);
    }

    private static VkShaderModule CreateShaderModule(byte[] code)
    {
        fixed (byte* codePtr = code)
        {
            VkShaderModuleCreateInfo createInfo = new VkShaderModuleCreateInfo()
            {
                sType = VkStructureType.ShaderModuleCreateInfo,
                codeSize = (uint)code.Length,
                pCode = (uint*)codePtr
            };

            if (vkCreateShaderModule(Device, &createInfo, null, out VkShaderModule module) != VkResult.Success)
            {
                throw new SystemException("failed to create shader module!");
            }
            return module;
        }
    }

    private static void CreateFramebuffers()
    {
        SwapChainFramebuffers = new VkFramebuffer[SwapChainImageViews.Length];
        for (int i = 0; i < SwapChainImageViews.Length; i++)
        {
            VkImageView[] attachments = {
                SwapChainImageViews[i]
            };

            fixed (VkImageView* attachmentsPtr = attachments)
            {
                VkFramebufferCreateInfo framebufferInfo = new()
                {
                    sType = VkStructureType.FramebufferCreateInfo,
                    renderPass = RenderPass,
                    attachmentCount = 1,
                    pAttachments = attachmentsPtr,
                    width = SwapChainExtent.width,
                    height = SwapChainExtent.height,
                    layers = 1
                };

                if (vkCreateFramebuffer(Device, &framebufferInfo, null, out VkFramebuffer framebuffer) != VkResult.Success)
                {
                    throw new SystemException("failed to create famebuffer!");
                }
                SwapChainFramebuffers[i] = framebuffer;
            }
        }
    }

    private static void CreateCommandPool()
    {
        QueueFamilyIndices indices = FindQueueFamilies(PhysicalDevice);

        VkCommandPoolCreateInfo poolInfo = new()
        {
            sType = VkStructureType.CommandPoolCreateInfo,
            flags = VkCommandPoolCreateFlags.ResetCommandBuffer,
            queueFamilyIndex = indices.GraphicsFamily.Value
        };

        if (vkCreateCommandPool(Device, &poolInfo, null, out VkCommandPool commandPool) != VkResult.Success)
        {
            throw new SystemException("failed to create command pool!");
        }
        CommandPool = commandPool;
    }

    private static void CreateCommandBuffers()
    {
        CommandBuffers = new VkCommandBuffer[MaxFramesInFlight];

        VkCommandBufferAllocateInfo allocInfo = new()
        {
            sType = VkStructureType.CommandBufferAllocateInfo,
            commandPool = CommandPool,
            level = VkCommandBufferLevel.Primary,
            commandBufferCount = MaxFramesInFlight
        };

        fixed (VkCommandBuffer* commandBuffersPtr = CommandBuffers)
            if (vkAllocateCommandBuffers(Device, &allocInfo, commandBuffersPtr) != VkResult.Success)
            {
                throw new SystemException("failed to allocate command buffers!");
            }
    }

    private static void RecordCommandBuffer(VkCommandBuffer commandBuffer, uint imageIndex)
    {
        VkCommandBufferBeginInfo beginInfo = new()
        {
            sType = VkStructureType.CommandBufferBeginInfo,
            flags = 0,
            pInheritanceInfo = null
        };

        if (vkBeginCommandBuffer(commandBuffer, &beginInfo) != VkResult.Success)
        {
            throw new SystemException("failed to begin recording command buffer!");
        }

        VkRenderPassBeginInfo renderPassInfo = new()
        {
            sType = VkStructureType.RenderPassBeginInfo,
            renderPass = RenderPass,
            framebuffer = SwapChainFramebuffers[imageIndex],
            renderArea = new()
            {
                offset = new VkOffset2D(0, 0),
                extent = SwapChainExtent
            }
        };
        VkClearValue clearColor = new()
        {
            color = new VkClearColorValue(0, 0, 0)
        };
        renderPassInfo.clearValueCount = 1;
        renderPassInfo.pClearValues = &clearColor;

        vkCmdBeginRenderPass(commandBuffer, &renderPassInfo, VkSubpassContents.Inline);
        vkCmdBindPipeline(commandBuffer, VkPipelineBindPoint.Graphics, GraphicsPipeline);

        VkViewport viewport = new()
        {
            x = 0,
            y = 0,
            width = (float)SwapChainExtent.width,
            height = (float)SwapChainExtent.height,
            minDepth = 0,
            maxDepth = 1
        };
        vkCmdSetViewport(commandBuffer, 0, 1, &viewport);

        VkRect2D scissor = new()
        {
            offset = new VkOffset2D() { x = 0, y = 0 },
            extent = SwapChainExtent
        };
        vkCmdSetScissor(commandBuffer, 0, 1, &scissor);

        vkCmdDraw(commandBuffer, 3, 1, 0, 0);
        vkCmdEndRenderPass(commandBuffer);

        if (vkEndCommandBuffer(commandBuffer) != VkResult.Success)
        {
            throw new SystemException("failed to record command buffer!");
        }
    }

    private static void CreateSyncObjects()
    {
        ImageAvailableSemaphores = new VkSemaphore[MaxFramesInFlight];
        RenderFinishedSemaphores = new VkSemaphore[MaxFramesInFlight];
        InFlightFences = new VkFence[MaxFramesInFlight];

        VkSemaphoreCreateInfo semaphoreInfo = new()
        {
            sType = VkStructureType.SemaphoreCreateInfo
        };

        VkFenceCreateInfo fenceInfo = new()
        {
            sType = VkStructureType.FenceCreateInfo,
            flags = VkFenceCreateFlags.Signaled
        };

        for (int i = 0; i < MaxFramesInFlight; i++)
        {
            if (vkCreateSemaphore(Device, &semaphoreInfo, null, out VkSemaphore imageAvailableSemaphore) != VkResult.Success ||
                vkCreateSemaphore(Device, &semaphoreInfo, null, out VkSemaphore renderFinishedSemaphore) != VkResult.Success ||
                vkCreateFence(Device, &fenceInfo, null, out VkFence inFlightFence) != VkResult.Success)
            {
                throw new SystemException("failed to create semaphores!");
            }
            ImageAvailableSemaphores[i] = imageAvailableSemaphore;
            RenderFinishedSemaphores[i] = renderFinishedSemaphore;
            InFlightFences[i] = inFlightFence;
        }
    }

    private static void MainLoop()
    {
        while (!Glfw.WindowShouldClose(Window))
        {
            Glfw.PollEvents();
            DrawFrame();
        }

        vkDeviceWaitIdle(Device);
    }

    private static uint currentFrame = 0;

    private static void DrawFrame()
    {
        VkFence inFlightFence = InFlightFences[currentFrame];
        vkWaitForFences(Device, 1, &inFlightFence, true, ulong.MaxValue);

        uint imageIndex;
        VkResult result = vkAcquireNextImageKHR(Device, SwapChain, ulong.MaxValue, ImageAvailableSemaphores[currentFrame], VkFence.Null, &imageIndex);

        if (result == VkResult.ErrorOutOfDateKHR)
        {
            RecreateSwapChain();
            return;
        }
        else if (result != VkResult.Success && result != VkResult.SuboptimalKHR)
        {
            throw new SystemException("failed to aquire swap chain image!");
        }

        vkResetFences(Device, 1, &inFlightFence);

        vkResetCommandBuffer(CommandBuffers[currentFrame], 0);
        RecordCommandBuffer(CommandBuffers[currentFrame], imageIndex);

        VkSubmitInfo submitInfo = new VkSubmitInfo()
        {
            sType = VkStructureType.SubmitInfo
        };

        VkSemaphore* waitSemaphores = stackalloc VkSemaphore[] { ImageAvailableSemaphores[currentFrame] };
        VkPipelineStageFlags* waitStages = stackalloc VkPipelineStageFlags[] { VkPipelineStageFlags.ColorAttachmentOutput };

        submitInfo.waitSemaphoreCount = 1;
        submitInfo.pWaitSemaphores = waitSemaphores;
        submitInfo.pWaitDstStageMask = waitStages;
        submitInfo.commandBufferCount = 1;

        VkCommandBuffer commandBuffer = CommandBuffers[currentFrame];
        submitInfo.pCommandBuffers = &commandBuffer;

        VkSemaphore* signalSemaphores = stackalloc VkSemaphore[] { RenderFinishedSemaphores[currentFrame] };
        submitInfo.signalSemaphoreCount = 1;
        submitInfo.pSignalSemaphores = signalSemaphores;

        if (vkQueueSubmit(GraphicsQueue, 1, &submitInfo, inFlightFence) != VkResult.Success)
        {
            throw new SystemException("failed to submit draw command buffer!");
        }

        VkPresentInfoKHR presentInfo = new()
        {
            sType = VkStructureType.PresentInfoKHR,
            waitSemaphoreCount = 1,
            pWaitSemaphores = signalSemaphores
        };

        VkSwapchainKHR* swapChains = stackalloc VkSwapchainKHR[] { SwapChain };
        presentInfo.swapchainCount = 1;
        presentInfo.pSwapchains = swapChains;

        presentInfo.pImageIndices = &imageIndex;

        result = vkQueuePresentKHR(PresentQueue, &presentInfo);

        if (result == VkResult.ErrorOutOfDateKHR || result == VkResult.SuboptimalKHR || FramebufferResized)
        {
            RecreateSwapChain();
            FramebufferResized = false;
        }
        else if (result != VkResult.Success)
        {
            throw new SystemException("failed to present swap chain image!");
        }

        currentFrame = (currentFrame + 1) % MaxFramesInFlight;
    }

    private static void CleanupSwapChain()
    {
        foreach (var framebuffer in SwapChainFramebuffers)
        {
            vkDestroyFramebuffer(Device, framebuffer, null);
        }

        foreach (var imageView in SwapChainImageViews)
        {
            vkDestroyImageView(Device, imageView, null);
        }

        vkDestroySwapchainKHR(Device, SwapChain, null);
    }

    private static void Cleanup()
    {
        for (int i = 0; i < MaxFramesInFlight; i++)
        {
            vkDestroySemaphore(Device, ImageAvailableSemaphores[i], null);
            vkDestroySemaphore(Device, RenderFinishedSemaphores[i], null);
            vkDestroyFence(Device, InFlightFences[i], null);
        }
        vkDestroyCommandPool(Device, CommandPool, null);

        CleanupSwapChain();
        vkDestroyPipeline(Device, GraphicsPipeline, null);
        vkDestroyPipelineLayout(Device, PipelineLayout, null);
        vkDestroyRenderPass(Device, RenderPass, null);
        vkDestroyDevice(Device, null);

        if (EnableValidationLayers)
        {
            DebugUtilsExt.vkDestroyDebugUtilsMessengerEXT(Instance, DebugMessenger, null);
        }

        vkDestroySurfaceKHR(Instance, Surface, null);
        vkDestroyInstance(Instance, null);

        Glfw.DestroyWindow(Window);
        Glfw.Terminate();
    }
}