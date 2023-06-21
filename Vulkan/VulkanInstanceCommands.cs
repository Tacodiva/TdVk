
namespace Vulkan {
    /// <summary>
    /// The Vulkan commands under VulkanNative link directly to the Vulkan loader binary.
    /// This can incur a small performance penalty because the loader needs to redirect calls to commands
    /// to the actual implementation. The commands in this class avoids that layer of indirection by
    /// using vkGetInstanceProcAddr to link to commands relevant to a specific instance.
    /// 
    /// See https://github.com/KhronosGroup/Vulkan-Loader/blob/main/docs/LoaderApplicationInterface.md#best-application-performance-setup.
    /// </summary>
    public unsafe sealed partial class VulkanInstanceCommands {

        public readonly VkInstance Instance;

        public VulkanInstanceCommands(VkInstance instance) {
            Instance = instance;
            LoadFunctionPointers();
        }
    }
}