
namespace Vulkan {
    /// <summary>
    /// The Vulkan commands under VulkanNative link directly to the Vulkan loader binary.
    /// This can incur a small performance penalty because the loader needs to redirect calls to commands
    /// to the actual implementation. The commands in this class avoids that layer of indirection by
    /// using vkGetDeviceProcAddr to link to commands relevant to a specific device.
    /// Note that not all commands are avaliable here, only the 'device-level' commands which are 
    /// specific to a device.
    /// 
    /// See https://github.com/KhronosGroup/Vulkan-Loader/blob/main/docs/LoaderApplicationInterface.md#best-application-performance-setup.
    /// </summary>
    public unsafe sealed partial class VulkanDeviceCommands {

        public readonly VkDevice Device;

        public VulkanDeviceCommands(VkDevice device) {
            Device = device;
            LoadFunctionPointers();
        }
    }
}