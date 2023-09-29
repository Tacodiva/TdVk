using System;
using System.Collections.Generic;

namespace Vulkan.Build.Codegen
{
    public class TypeNameMappings
    {
        private readonly Dictionary<string, string> _nameMappings = new Dictionary<string, string>()
        {
            { "uint8_t", "byte" },
            { "int8_t", "sbyte" },
            { "uint16_t", "ushort" },
            { "uint32_t", "uint" },
            { "uint64_t", "ulong" },
            { "int32_t", "int" },
            { "int64_t", "long" },
            { "int64_t*", "long*" },
            { "char", "byte" },
            { "size_t", "UIntPtr" },
            { "DWORD", "uint" },

            { "ANativeWindow", "Android.ANativeWindow" },
            { "AHardwareBuffer", "Android.AHardwareBuffer" },

            { "MirConnection", "Mir.MirConnection" },
            { "MirSurface", "Mir.MirSurface" },

            { "wl_display", "Wayland.wl_display" },
            { "wl_surface", "Wayland.wl_surface" },

            { "Display", "Xlib.Display" },
            { "Window", "Xlib.Window" },
            { "VisualID", "Xlib.VisualID" },
            { "RROutput", "IntPtr" },

            { "HINSTANCE", "Win32.HINSTANCE" },
            { "HWND", "Win32.HWND" },
            { "HANDLE", "Win32.HANDLE" },
            { "SECURITY_ATTRIBUTES", "Win32.SECURITY_ATTRIBUTES" },
            { "LPCWSTR", "IntPtr" },
            { "HMONITOR", "Win32.HMONITOR" },

            { "xcb_connection_t", "Xcb.xcb_connection_t" },
            { "xcb_window_t", "Xcb.xcb_window_t" },
            { "xcb_visualid_t", "Xcb.xcb_visualid_t" },

            { "IDirectFB", "DirectFB.IDirectFB" },
            { "IDirectFBSurface", "DirectFB.IDirectFBSurface" },

            { "zx_handle_t", "Zircon.ZXHandle" },

            { "GgpStreamDescriptor", "GGP.GgpStreamDescriptor" },
            { "GgpFrameToken", "GGP.GgpFrameToken" },

            { "_screen_context", "Screen.ScreenContext" },
            { "_screen_window", "Screen.ScreenWindow" },
            { "_screen_buffer", "Screen.ScreenBuffer" },

            { "CAMetalLayer", "void" },
            { "MTLDevice_id", "void*" },
            { "MTLCommandQueue_id", "void*" },
            { "MTLBuffer_id", "void*" },
            { "MTLTexture_id", "void*" },
            { "MTLSharedEvent_id", "void*" },
            { "IOSurfaceRef", "void*" },

            { "NvSciBufAttrList", "NvCsi.NvSciBufAttrList" },
            { "NvSciBufObj", "NvCsi.NvSciBufObj" },
            { "NvSciSyncAttrList", "NvCsi.NvSciSyncAttrList" },
            { "NvSciSyncObj", "NvCsi.NvSciSyncObj" },
            { "NvSciSyncFence", "NvCsi.NvSciSyncFence" },

        };

        internal IEnumerable<KeyValuePair<string, string>> GetAllMappings()
        {
            return _nameMappings;
        }

        public void AddMapping(string originalName, string newName)
        {
            _nameMappings.Add(originalName, newName);
        }

        public string GetMappedName(string name)
        {
            if (_nameMappings.TryGetValue(name, out string mappedName))
            {
                return GetMappedName(mappedName);
            }
            else if (name.StartsWith("PFN"))
            {
                return "IntPtr";
            }
            else
            {
                return name;
            }
        }
    }
}
