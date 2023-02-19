using System;
using System.Runtime.InteropServices;

namespace Vulkan
{

    public interface INativeDynamicLinker
    {
        IntPtr LoadLibrary(string libraryName);
        void FreeLibrary(IntPtr libraryHandle);
        IntPtr LoadFunction(IntPtr libraryHandle, string functionName);
    }
}