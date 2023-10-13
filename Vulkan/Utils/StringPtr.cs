
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace Vulkan
{
    public unsafe struct StringPtr
    {
        public readonly IntPtr Handle;
        public readonly int Length;

        public StringPtr(IntPtr ptr, int length)
        {
            Handle = ptr;
            Length = length;
        }

        public StringPtr(void* ptr) : this(new IntPtr(ptr)) { }
        public StringPtr(char* ptr) : this(new IntPtr(ptr)) { }
        public StringPtr(byte* ptr) : this(new IntPtr(ptr)) { }

        public StringPtr(IntPtr ptr)
        {
            Handle = ptr;
            int length = 0;
            while (*(((byte*)ptr) + length) != '\0') ++length;
            Length = length;
        }

        public override string ToString()
        {
            return Encoding.UTF8.GetString((byte*)Handle, Length);
        }

        public static StringPtr Allocate(string str)
        {
            int length = Encoding.UTF8.GetByteCount(str);
            IntPtr ptr = Marshal.AllocHGlobal(length + 1);
            fixed (char* strPtr = str)
                Encoding.UTF8.GetBytes(strPtr, str.Length, (byte*)ptr, length);
            *((byte*)ptr + length) = 0;
            return new StringPtr(ptr, length);
        }

        public static void Free(IntPtr ptr)
        {
            Marshal.FreeHGlobal(ptr);
        }

        public static void Free(StringPtr ptr)
        {
            Free(ptr.Handle);
        }

        public static void Free(byte* ptr)
        {
            Free(new IntPtr(ptr));
        }

        public static void Free(void* ptr)
        {
            Free(new IntPtr(ptr));
        }

        public static void Free(char* ptr)
        {
            Free(new IntPtr(ptr));
        }

        public static unsafe implicit operator string(StringPtr ptr) => ptr.ToString();

        public static implicit operator IntPtr(StringPtr ptr) => ptr.Handle;
        public static implicit operator void*(StringPtr ptr) => (void*)ptr.Handle;
        public static implicit operator char*(StringPtr ptr) => (char*)ptr.Handle;
        public static implicit operator byte*(StringPtr ptr) => (byte*)ptr.Handle;

        public static implicit operator StringPtr(IntPtr ptr) => new StringPtr(ptr);
        public static implicit operator StringPtr(void* ptr) => new StringPtr(ptr);
        public static implicit operator StringPtr(char* ptr) => new StringPtr(ptr);
        public static implicit operator StringPtr(byte* ptr) => new StringPtr(ptr);


        public unsafe Span<char> AsSpan()
        {
            return new Span<char>((void*)Handle, Length);
        }

        public static unsafe implicit operator Span<char>(StringPtr ptr) => ptr.AsSpan();
        public static unsafe implicit operator StringPtr(Span<char> span) {
            fixed (char* ptr = &span.GetPinnableReference()) {
                return new StringPtr(new IntPtr(ptr), span.Length);
            }
        }
    }
}
