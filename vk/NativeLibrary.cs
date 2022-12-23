using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace Vulkan
{

    public interface INativeDynamicLinker
    {
        public IntPtr LoadLibrary(string libraryName);
        public void FreeLibrary(IntPtr libraryHandle);
        public IntPtr LoadFunction(IntPtr libraryHandle, string functionName);

        private static INativeDynamicLinker _linker;

        public static INativeDynamicLinker GetInstance()
        {
            if (_linker != null) return _linker;

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return _linker = new NativeLinkerWindows();
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX)
#if NET5_0
                || OperatingSystem.IsAndroid()
#endif
                )
            {
                return new NativeLinkerLibDL(new NativeLibDLGeneric());
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                return new NativeLinkerLibDL(new NativeLibDLLinux());
            }
            else
            {
                throw new PlatformNotSupportedException("Cannot load native libraries on this platform: " + RuntimeInformation.OSDescription);
            }
        }
    }

    public class NativeLibrary : IDisposable
    {
        public static NativeLibrary Load(string libraryName)
        {
            if (libraryName == null)
                throw new ArgumentNullException(nameof(libraryName));

            INativeDynamicLinker linker = INativeDynamicLinker.GetInstance();
            IntPtr libraryHandle = linker.LoadLibrary(libraryName);
            
            if (libraryHandle == IntPtr.Zero)
                throw new InvalidOperationException("Could not load " + libraryName);

            return new NativeLibrary(libraryHandle, linker);
        }

        private readonly IntPtr _libraryHandle;
        private readonly INativeDynamicLinker _linker;

        public IntPtr NativeHandle => _libraryHandle;

        private NativeLibrary(IntPtr libraryHandle, INativeDynamicLinker linker)
        {
            _libraryHandle = libraryHandle;
            _linker = linker;
        }

        public IntPtr LoadFunctionPointer(string functionName)
        {
            if (functionName == null)
            {
                throw new ArgumentNullException(nameof(functionName));
            }

            return _linker.LoadFunction(_libraryHandle, functionName);
        }

        public void Dispose()
        {
            _linker.FreeLibrary(_libraryHandle);
        }
    }
}