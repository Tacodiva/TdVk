using System;

namespace Vulkan
{
    // Windows
    namespace Win32
    {
        public struct HINSTANCE
        {
            public IntPtr Handle;
            public static implicit operator IntPtr(HINSTANCE hinst) => hinst.Handle;
            public static implicit operator HINSTANCE(IntPtr handle) => new HINSTANCE() { Handle = handle };
        }

        public struct HWND
        {
            public IntPtr Handle;
            public static implicit operator IntPtr(HWND hwnd) => hwnd.Handle;
            public static implicit operator HWND(IntPtr handle) => new HWND() { Handle = handle };
        }

        public struct HANDLE
        {
            public IntPtr Handle;
            public static implicit operator IntPtr(HANDLE handle) => handle.Handle;
            public static implicit operator HANDLE(IntPtr handle) => new HANDLE() { Handle = handle };
        }

        public struct SECURITY_ATTRIBUTES
        {
            public uint nLength;
            public IntPtr lpSecurityDescriptor;
            public uint bInheritHandle;
        }

        public struct HMONITOR
        {
            public IntPtr Handle;
            public static implicit operator IntPtr(HMONITOR handle) => handle.Handle;
            public static implicit operator HMONITOR(IntPtr handle) => new HMONITOR() { Handle = handle };
        }

        public struct DWORD
        {
            public IntPtr Handle;
            public static implicit operator IntPtr(DWORD handle) => handle.Handle;
            public static implicit operator DWORD(IntPtr handle) => new DWORD() { Handle = handle };
        }
    }

    // Android
    namespace Android
    {
        public struct ANativeWindow { }
        public struct AHardwareBuffer { }
    }

    // Linux
    namespace Mir
    {
        public struct MirConnection { }
        public struct MirSurface { }
    }

    namespace Wayland
    {
        public struct wl_display { }
        public struct wl_surface { }
    }

    namespace Xlib
    {
        public struct Display { }
        public struct Window
        {
            public IntPtr Value;
        }
        public struct VisualID
        {
            public ulong ID;
            public static implicit operator VisualID(ulong value) => new VisualID() { ID = value };
            public static implicit operator ulong(VisualID id) => id.ID;
        }
    }

    namespace Xcb
    {
        public struct xcb_connection_t { }
        public struct xcb_window_t { }
        public struct xcb_visualid_t
        {
            public uint ID;
            public static implicit operator xcb_visualid_t(uint value) => new xcb_visualid_t() { ID = value };
            public static implicit operator uint(xcb_visualid_t id) => id.ID;
        }
    }

    namespace DirectFB
    {
        public struct IDirectFB { }
        public struct IDirectFBSurface { }
    }

    namespace Zircon
    {
        public struct ZXHandle
        {
            public IntPtr Handle;
            public static implicit operator IntPtr(ZXHandle handle) => handle.Handle;
            public static implicit operator ZXHandle(IntPtr handle) => new ZXHandle() { Handle = handle };
        }
    }

    namespace GGP
    {
        public struct GgpStreamDescriptor
        {
            public IntPtr Handle;
            public static implicit operator IntPtr(GgpStreamDescriptor handle) => handle.Handle;
            public static implicit operator GgpStreamDescriptor(IntPtr handle) => new GgpStreamDescriptor() { Handle = handle };
        }

        public struct GgpFrameToken
        {
            public IntPtr Handle;
            public static implicit operator IntPtr(GgpFrameToken handle) => handle.Handle;
            public static implicit operator GgpFrameToken(IntPtr handle) => new GgpFrameToken() { Handle = handle };
        }
    }

    namespace Screen {
        public struct ScreenContext { }
        public struct ScreenWindow { }
    }
}
