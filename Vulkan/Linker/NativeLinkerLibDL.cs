using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Vulkan
{
    internal class NativeLinkerLibDL : INativeDynamicLinker
    {
        public const int RTLD_NOW = 0x002;

        public readonly INativeLibDL LibDL;

        public NativeLinkerLibDL(INativeLibDL libDL)
        {
            LibDL = libDL;
        }

        public IntPtr LoadLibrary(string libraryName)
        {
            LibDL.dlerror();
            IntPtr handle = LibDL.dlopen(libraryName, RTLD_NOW);
            if (handle == IntPtr.Zero && !Path.IsPathRooted(libraryName))
            {
                string baseDir = AppContext.BaseDirectory;
                if (!string.IsNullOrWhiteSpace(baseDir))
                {
                    string localPath = Path.Combine(baseDir, libraryName);
                    handle = LibDL.dlopen(localPath, RTLD_NOW);
                }
            }

            return handle;
        }

        public void FreeLibrary(IntPtr libraryHandle)
        {
            LibDL.dlclose(libraryHandle);
        }

        public IntPtr LoadFunction(IntPtr libraryHandle, string functionName)
        {
            return LibDL.dlsym(libraryHandle, functionName);
        }
    }
}