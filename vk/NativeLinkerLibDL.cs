using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Vulkan
{

    internal class NativeLinkerLibDL : INativeDynamicLinker
    {

        public readonly INativeLibDL LibDL;

        public NativeLinkerLibDL(INativeLibDL libDL)
        {
            LibDL = libDL;
        }

        public IntPtr LoadLibrary(string libraryName)
        {
            LibDL.dlerror();
            IntPtr handle = LibDL.dlopen(libraryName, INativeLibDL.RTLD_NOW);
            if (handle == IntPtr.Zero && !Path.IsPathRooted(libraryName))
            {
                string baseDir = AppContext.BaseDirectory;
                if (!string.IsNullOrWhiteSpace(baseDir))
                {
                    string localPath = Path.Combine(baseDir, libraryName);
                    handle = LibDL.dlopen(localPath, INativeLibDL.RTLD_NOW);
                }
            }

            return handle;
        }

        public void FreeLibrary(IntPtr libraryHandle)
        {
            LibDL.dlclose(libraryHandle);
        }

        public nint LoadFunction(IntPtr libraryHandle, string functionName)
        {
            return LibDL.dlsym(libraryHandle, functionName);
        }

        public interface INativeLibDL
        {
            public const int RTLD_NOW = 0x002;

            public IntPtr dlopen(string fileName, int flags);

            public IntPtr dlsym(IntPtr handle, string name);

            public int dlclose(IntPtr handle);

            public string dlerror();
        }

    }
}