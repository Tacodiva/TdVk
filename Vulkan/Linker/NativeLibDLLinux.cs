using System;
using System.Runtime.InteropServices;

namespace Vulkan
{
    internal class NativeLibDLLinux : INativeLibDL
    {
        public int dlclose(IntPtr handle)
        {
            return LibDL.dlclose(handle);
        }

        public string dlerror()
        {
            return LibDL.dlerror();
        }

        public IntPtr dlopen(string fileName, int flags)
        {
            return LibDL.dlopen(fileName, flags);
        }

        public IntPtr dlsym(IntPtr handle, string name)
        {
            return LibDL.dlsym(handle, name);
        }

        private static class LibDL
        {
            private const string Library = "libdl.so.2";

            [DllImport(Library)]
            public static extern IntPtr dlopen(string fileName, int flags);

            [DllImport(Library)]
            public static extern IntPtr dlsym(IntPtr handle, string name);

            [DllImport(Library)]
            public static extern int dlclose(IntPtr handle);

            [DllImport(Library)]
            public static extern string dlerror();
        }
    }
}
