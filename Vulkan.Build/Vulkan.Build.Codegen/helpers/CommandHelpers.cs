using System.Linq;
using System.Runtime.InteropServices;

namespace Vulkan.Build.Codegen
{
    public static class CommandHelpers
    {
        public static void WriteCommand(CsCodeWriter cw, TypeNameMappings tnm, CommandDefinition command, bool @static)
        {
            if (command.SuccessCodes.Length != 0)
            {
                cw.WriteLine($"///<remarks>Success codes:{string.Join(", ", command.SuccessCodes)}. Error codes:{string.Join(", ", command.ErrorCodes)}</remarks>");
            }

            cw.WriteLine("[Generator.CalliRewrite]");
            // cw.WriteLine("[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]");
            using (cw.PushBlock($"public{(@static ? " static " : " ")}unsafe {command.ReturnType.MapTypeSpec(tnm)} {command.Name}({command.GetParametersSignature(tnm)})"))
            {
                cw.WriteLine("throw VulkanNative.CreateUnpatchedException();");
            }
        }
    }
}
