using System;
using System.Runtime.InteropServices;

namespace Vulkan
{
    internal class NativeLibC : INativeLibDL
    {
        public int dlclose(IntPtr handle)
        {
            return Libc.dlclose(handle);
        }

        public string dlerror()
        {
            return Libc.dlerror();
        }

        public IntPtr dlopen(string fileName, int flags)
        {
            return Libc.dlopen(fileName, flags);
        }

        public IntPtr dlsym(IntPtr handle, string name)
        {
            return Libc.dlsym(handle, name);
        }

        private static class Libc
        {
            [DllImport("libc")]
            public static extern IntPtr dlopen(string fileName, int flags);

            [DllImport("libc")]
            public static extern IntPtr dlsym(IntPtr handle, string name);

            [DllImport("libc")]
            public static extern int dlclose(IntPtr handle);

            [DllImport("libc")]
            public static extern string dlerror();

            public const int RTLD_NOW = 0x002;
        }
    }
}