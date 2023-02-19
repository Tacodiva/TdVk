using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace Vulkan
{
    internal static class PatchHelper
    {
        internal static unsafe PatchHelperIntPtr StringToHGlobalUtf8(string s)
        {
            if (s == null) return new PatchHelperIntPtr() { Handle = IntPtr.Zero };
            int byteCount = Encoding.UTF8.GetByteCount(s);
            IntPtr retPtr = Marshal.AllocHGlobal(byteCount + 1);
            fixed (char* stringPtr = s)
                Encoding.UTF8.GetBytes(stringPtr, s.Length, (byte*)retPtr, byteCount);
            *(((byte*)retPtr) + byteCount) = 0;

            return new PatchHelperIntPtr() { Handle = retPtr };
        }

        internal static void FreeHGlobal(PatchHelperIntPtr ptr)
        {
            Marshal.FreeHGlobal(ptr.Handle);
        }
    }

    internal struct PatchHelperIntPtr
    {
        public IntPtr Handle;
    }
}
