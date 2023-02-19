using System;
using System.Runtime.InteropServices;

namespace Vulkan
{
    internal class NativeLinkerWindows : INativeDynamicLinker
    {

        public IntPtr LoadLibrary(string libraryName)
        {
            return Kernel32.LoadLibrary(libraryName);
        }

        public void FreeLibrary(IntPtr libraryHandle)
        {
            Kernel32.FreeLibrary(libraryHandle);
        }

        public IntPtr LoadFunction(IntPtr libraryHandle, string functionName)
        {
            return Kernel32.GetProcAddress(libraryHandle, functionName);
        }

        private static class Kernel32
        {
            private const string Library = "kernel32.dll";

            [DllImport(Library)]
            public static extern IntPtr LoadLibrary(string fileName);

            [DllImport(Library)]
            public static extern IntPtr GetProcAddress(IntPtr module, string procName);

            [DllImport(Library)]
            public static extern int FreeLibrary(IntPtr module);
        }
    }
}
