using System;

namespace Vulkan.Build.Codegen
{
    public static class HandleHelpers
    {
        public static void WriteHandle(CsCodeWriter cw, HandleDefinition handle)
        {
            if (handle.Parent != null)
            {
                cw.WriteIndentation();
                cw.Write($"///<summary>");
                cw.Write($"A {(handle.Dispatchable ? "dispatchable" : "non-dispatchable")} handle owned by a {handle.Parent}.");
                cw.Write("</summary>");
                cw.Write(Environment.NewLine);
            }
            cw.WriteLine($"[DebuggerDisplay(\"{{DebuggerDisplay,nq}}\")]");
            using (cw.PushBlock($"public partial struct {handle.Name} : IVulkanHandle, IEquatable<{handle.Name}>"))
            {

                cw.WriteLine($"public static VkObjectType VkObjectType => VkObjectType.{EnumHelpers.GetPrettyEnumName(handle.ObjTypeEnum, "VK_OBJECT_TYPE")};");

                string handleType = handle.Dispatchable ? "IntPtr" : "ulong";
                string nullValue = handle.Dispatchable ? "IntPtr.Zero" : "0";

                cw.WriteLine($"public readonly {handleType} Handle;");

                cw.WriteLine($"public {handle.Name}({handleType} existingHandle) {{ Handle = existingHandle; }}");
                cw.WriteLine($"public static {handle.Name} Null => new {handle.Name}({nullValue});");
                cw.WriteLine($"public static implicit operator {handle.Name}({handleType} handle) => new {handle.Name}(handle);");
                cw.WriteLine($"public static bool operator ==({handle.Name} left, {handle.Name} right) => left.Handle == right.Handle;");
                cw.WriteLine($"public static bool operator !=({handle.Name} left, {handle.Name} right) => left.Handle != right.Handle;");
                cw.WriteLine($"public static bool operator ==({handle.Name} left, {handleType} right) => left.Handle == right;");
                cw.WriteLine($"public static bool operator !=({handle.Name} left, {handleType} right) => left.Handle != right;");
                cw.WriteLine($"public bool Equals({handle.Name} h) => Handle == h.Handle;");
                cw.WriteLine($"public override bool Equals(object o) => o is {handle.Name} h && Equals(h);");
                cw.WriteLine($"public override int GetHashCode() => Handle.GetHashCode();");
                cw.WriteLine($"private string DebuggerDisplay => string.Format(\"{handle.Name} [0x{{0}}]\", Handle.ToString(\"X\"));");

                cw.WriteLine($"VkObjectType IVulkanHandle.GetVkObjectType() => VkObjectType;");

                if (handle.Dispatchable)
                    cw.WriteLine($"ulong IVulkanHandle.GetHandle() => (ulong)Handle;");
                else
                    cw.WriteLine($"ulong IVulkanHandle.GetHandle() => Handle;");

            }
        }
    }
}
