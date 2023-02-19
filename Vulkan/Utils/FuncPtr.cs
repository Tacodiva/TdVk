using System;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public struct FuncPtr<TFunc> where TFunc : Delegate
    {
        public IntPtr Handle;

        public FuncPtr(TFunc func)
        {
            Handle = Marshal.GetFunctionPointerForDelegate(func);
        }

        public TFunc GetDelegate()
        {
            return Marshal.GetDelegateForFunctionPointer<TFunc>(Handle);
        }

        public static implicit operator FuncPtr<TFunc>(TFunc func) => new FuncPtr<TFunc>(func);
        public static implicit operator TFunc(FuncPtr<TFunc> func) => func.GetDelegate();

        public static implicit operator IntPtr(FuncPtr<TFunc> ptr) => ptr.Handle;
        public static unsafe implicit operator void*(FuncPtr<TFunc> ptr) => (void*) ptr.Handle;
    }
}
