using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace Vulkan
{
    public static partial class VulkanNative
    {
        private static IntPtr s_nativeLib;

        static VulkanNative()
        {
            s_nativeLib = LoadNativeLibrary();
            LoadFunctionPointers();
        }

        private static IntPtr LoadNativeLibrary()
        {
            return NativeLibrary.Load(GetNativeLibraryName());
        }

        private static string GetNativeLibraryName()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return "vulkan-1.dll";
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                if (RuntimeInformation.OSDescription.Contains("Unix"))
                {
                    // Android
                    return "libvulkan.so";
                }
                else
                {
                    // Desktop Linux
                    return "libvulkan.so.1";
                }
            }
            else if (OperatingSystem.IsAndroid())
            {
                return "libvulkan.so";
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                return "libvulkan.dylib";
            }
            else
            {
                throw new PlatformNotSupportedException();
            }
        }

        internal static Exception CreateUnpatchedException()
        {
            return new InvalidOperationException("This command was has not been patched.");
        }

        // We need to keep this around so it doesn't get collected.
        private static Action s_ErrFnDelegate;
        private static IntPtr s_ErrFnPtr;

        private unsafe static IntPtr GetErrorFnPtr()
        {
            if (s_ErrFnDelegate != null) return s_ErrFnPtr;
            s_ErrFnDelegate = () => throw new PlatformNotSupportedException($"Could not find vulkan command.");
            s_ErrFnPtr = Marshal.GetFunctionPointerForDelegate(s_ErrFnDelegate);
            return s_ErrFnPtr;
        }

        private unsafe static IntPtr LoadStaticProcAddr(string name)
        {
            if (NativeLibrary.TryGetExport(s_nativeLib, name, out IntPtr ptr))
                return ptr;
            return GetErrorFnPtr();
        }

        internal unsafe static IntPtr LoadInstanceProcAddr(VkInstance instance, string name, bool required)
        {
            IntPtr ptr = vkGetInstanceProcAddr(instance, name);
            if (ptr == IntPtr.Zero)
            {
                if (required)
                    throw new InvalidOperationException($"Could not find vulkan instance command '{name}'. If it's from an extension, make sure it is enabled on the instance.");
                return GetErrorFnPtr();
            }
            return ptr;
        }

        internal unsafe static IntPtr LoadDeviceProcAddr(VkDevice device, string name, bool required)
        {
            IntPtr ptr = vkGetDeviceProcAddr(device, name);
            if (ptr == IntPtr.Zero)
            {
                if (required)
                    throw new InvalidOperationException($"Could not find vulkan device command '{name}'. If it's from an extension, make sure it is enabled on the device.");
                return GetErrorFnPtr();
            }
            return ptr;
        }

        public unsafe static IntPtr vkGetInstanceProcAddr(string name)
        {
            return vkGetInstanceProcAddr(new VkInstance(IntPtr.Zero), name);
        }

        public unsafe static IntPtr vkGetInstanceProcAddr(VkInstance instance, string name)
        {
            int byteCount = Encoding.UTF8.GetByteCount(name);
            byte* utf8Ptr = stackalloc byte[byteCount + 1];
            fixed (char* namePtr = name)
            {
                Encoding.UTF8.GetBytes(namePtr, name.Length, utf8Ptr, byteCount);
            }
            utf8Ptr[byteCount] = 0;
            return vkGetInstanceProcAddr(instance, utf8Ptr);
        }

        public unsafe static IntPtr vkGetDeviceProcAddr(VkDevice device, string name)
        {
            int byteCount = Encoding.UTF8.GetByteCount(name);
            byte* utf8Ptr = stackalloc byte[byteCount + 1];
            fixed (char* namePtr = name)
            {
                Encoding.UTF8.GetBytes(namePtr, name.Length, utf8Ptr, byteCount);
            }
            utf8Ptr[byteCount] = 0;
            return vkGetDeviceProcAddr(device, utf8Ptr);
        }
    }
}
