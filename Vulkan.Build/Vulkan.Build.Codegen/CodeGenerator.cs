using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Vulkan.Build.Codegen
{
    public class CodeGenerator
    {

        public static readonly string[] WSIExtensions = {
            "VK_VERSION_1_0",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_KHR_surface",
            "VK_KHR_swapchain",
            "VK_KHR_display",
            "VK_KHR_win32_surface",
            "VK_KHR_wayland_surface",
            "VK_KHR_xcb_surface",
            "VK_KHR_xlib_surface",
            "VK_MVK_macos_surface",
            "VK_QNX_screen_surface"
        };

        public static void GenerateCodeFiles(VulkanSpecification spec, TypeNameMappings tnm, string path)
        {
            Directory.CreateDirectory(path);
            GenerateAllTypes(spec, tnm, path);
        }

        private static void GenerateAllTypes(VulkanSpecification spec, TypeNameMappings tnm, string path)
        {
            using (StreamWriter sw = File.CreateText(Path.Combine(path, "Structures.gen.cs")))
            {
                CsCodeWriter cw = new CsCodeWriter(sw);
                cw.WriteHeader();
                cw.WriteLine();

                cw.Using("System");
                cw.WriteLine();

                using (cw.PushBlock("namespace Vulkan"))
                {
                    CodegenUtil.SpaceSeparatedList(cw, spec.Structures, structure =>
                    {
                        StructureHelpers.WriteStructure(cw, structure, tnm, spec.Constants);
                    });
                }
            }

            using (StreamWriter enumWriter = File.CreateText(Path.Combine(path, "Enums.gen.cs")))
            {
                CsCodeWriter cw = new CsCodeWriter(enumWriter);
                cw.WriteHeader();
                cw.WriteLine();

                cw.Using("System");
                cw.WriteLine();

                using (cw.PushBlock("namespace Vulkan"))
                {
                    CodegenUtil.SpaceSeparatedList(cw, spec.Enums, enumDef =>
                    {
                        EnumHelpers.WriteEnum(cw, enumDef, tnm);
                    });
                }
            }

            CommandDefinition[] allVariants = spec.Commands.SelectMany(cd => VariantGenerator.GenerateVariants(cd, tnm)).ToArray();
            CommandDefinition[] allCommandsWithVariants = spec.Commands.Concat(allVariants).OrderBy(cd => cd.Name).ToArray();

            using (StreamWriter commandWriter = File.CreateText(Path.Combine(path, "Commands.gen.cs")))
            {
                CsCodeWriter cw = new CsCodeWriter(commandWriter);
                cw.WriteHeader();
                cw.WriteLine();

                cw.Using("System");

                using (cw.PushBlock("namespace Vulkan"))
                using (cw.PushBlock("public static unsafe partial class VulkanNative"))
                {
                    IEnumerable<CommandDefinition> commands = allCommandsWithVariants.Where(cmd => WSIExtensions.Contains(cmd.Extension.Name));
                    IEnumerable<CommandDefinition> uniqueCommands = commands.Where(cmd => !cmd.IsVariant);

                    foreach (CommandDefinition command in uniqueCommands)
                    {
                        cw.WriteLine($"private static IntPtr {command.Name}_ptr;");
                    };

                    cw.WriteLine();

                    CodegenUtil.SpaceSeparatedList(cw, commands.ToList(), command =>
                    {
                        CommandHelpers.WriteCommand(cw, tnm, command, true);
                    });

                    cw.WriteLine();

                    using (cw.PushBlock("private static void LoadFunctionPointers()"))
                    {
                        foreach (CommandDefinition command in uniqueCommands)
                        {
                            cw.WriteLine($"{command.Name}_ptr = LoadStaticProcAddr(\"{command.Name}\");");
                        }
                    }
                }
            }

            using (StreamWriter commandWriter = File.CreateText(Path.Combine(path, "Extensions.gen.cs")))
            {
                CsCodeWriter cw = new CsCodeWriter(commandWriter);
                cw.WriteHeader();
                cw.WriteLine();

                cw.Using("System");

                cw.WriteLine();

                using (cw.PushBlock("namespace Vulkan"))
                using (cw.PushBlock("public static unsafe partial class VulkanNative"))
                {
                    foreach (ExtensionDefinition ext in spec.Extensions)
                    {

                        if (ext.CommandNames.Length == 0 || !(ext.IsDeviceExtension() || ext.IsInstanceExtension())) continue;
                        IEnumerable<CommandDefinition> commands = allCommandsWithVariants.Where(cmd => cmd.Extension == ext);
                        IEnumerable<CommandDefinition> uniqueCommands = commands.Where(cmd => !cmd.IsVariant);

                        string extClassName = "Vulkan" + CodegenUtil.GetPrettyName(ext.Name, "VK_");
                        using (cw.PushBlock($"public unsafe sealed class {extClassName}"))
                        {
                            foreach (CommandDefinition command in uniqueCommands)
                            {
                                cw.WriteLine($"private IntPtr {command.Name}_ptr;");
                            };

                            cw.WriteLine();

                            if (ext.IsDeviceExtension())
                            {
                                using (cw.PushBlock($"public {extClassName}(VkDevice device)"))
                                {
                                    foreach (CommandDefinition command in uniqueCommands)
                                    {
                                        cw.WriteLine($"{command.Name}_ptr = LoadDeviceProcAddr(device, \"{command.Name}\");");
                                    }
                                }
                            }
                            else
                            {
                                using (cw.PushBlock($"public {extClassName}(VkInstance instance)"))
                                {
                                    foreach (CommandDefinition command in uniqueCommands)
                                    {
                                        cw.WriteLine($"{command.Name}_ptr = LoadInstanceProcAddr(instance, \"{command.Name}\");");
                                    }
                                }
                            }
                            cw.WriteLine();

                            CodegenUtil.SpaceSeparatedList(cw, commands.ToList(), command =>
                            {
                                CommandHelpers.WriteCommand(cw, tnm, command, false);
                            });
                        }
                        cw.WriteLine();
                    }
                }
            }

            using (StreamWriter handleWriter = File.CreateText(Path.Combine(path, "Handles.gen.cs")))
            {
                CsCodeWriter cw = new CsCodeWriter(handleWriter);
                cw.WriteHeader();
                cw.WriteLine();

                cw.Using("System");
                cw.Using("System.Diagnostics");
                cw.WriteLine();

                using (cw.PushBlock("namespace Vulkan"))
                {
                    CodegenUtil.SpaceSeparatedList(cw, spec.Handles, handle =>
                    {
                        HandleHelpers.WriteHandle(cw, handle);
                    });
                }
            }

            using (StreamWriter unionWriter = File.CreateText(Path.Combine(path, "Unions.gen.cs")))
            {
                CsCodeWriter cw = new CsCodeWriter(unionWriter);
                cw.WriteHeader();
                cw.WriteLine();

                cw.Using("System.Runtime.InteropServices");
                cw.WriteLine();

                using (cw.PushBlock("namespace Vulkan"))
                {
                    CodegenUtil.SpaceSeparatedList(cw, spec.Unions, union =>
                    {
                        UnionHelpers.WriteUnion(cw, tnm, union);
                    });
                }
            }

            using (StreamWriter unionWriter = File.CreateText(Path.Combine(path, "Constants.gen.cs")))
            {
                CsCodeWriter cw = new CsCodeWriter(unionWriter);
                cw.WriteHeader();
                cw.WriteLine();
                cw.Using("System.Runtime.InteropServices");
                cw.WriteLine();

                using (cw.PushBlock("namespace Vulkan"))
                {
                    ConstantHelpers.WriteAllConstants(cw, tnm, spec.Constants);
                }
            }
        }
    }

    public class CsCodeWriter
    {
        private readonly StreamWriter _sw;

        private int _indentLevel = 0;

        public CsCodeWriter(StreamWriter sw)
        {
            _sw = sw;
        }

        public void Using(string ns)
        {
            _sw.WriteLine($"using {ns};");
        }

        public void WriteHeader()
        {
            _sw.WriteLine("// This file is generated.");
        }

        public void PushBlock()
        {
            WriteLine('{');
            _indentLevel += 4;
        }

        public CodeBlock PushBlock(string ns)
        {
            return new CodeBlock(this, ns);
        }

        public IfDefSection PushIfDef(string condition)
        {
            return new IfDefSection(this, condition);
        }

        public void PopBlock()
        {
            _indentLevel -= 4;
            WriteLine('}');
        }

        public void WriteLine()
        {
            _sw.WriteLine();
        }

        public void WriteLine(string text)
        {
            WriteIndentation();
            _sw.WriteLine(text);
        }

        public void WriteLine(char c)
        {
            WriteIndentation();
            _sw.WriteLine(c);
        }

        public void Write(string text)
        {
            _sw.Write(text);
        }

        public void WriteIndentation()
        {
            for (int i = 0; i < _indentLevel; i++)
            {
                _sw.Write(' ');
            }
        }

        public class CodeBlock : IDisposable
        {
            private readonly CsCodeWriter _cw;

            public CodeBlock(CsCodeWriter cw, string header)
            {
                _cw = cw;
                _cw.WriteLine(header);
                _cw.PushBlock();
            }

            public void Dispose()
            {
                _cw.PopBlock();
            }
        }

        public class IfDefSection : IDisposable
        {
            private readonly CsCodeWriter _cw;
            private readonly string _condition;

            public IfDefSection(CsCodeWriter cw, string condition)
            {
                _cw = cw;
                _condition = condition;
                _cw.WriteLine($"#if {condition}");
            }

            public void Dispose()
            {
                _cw.WriteLine($"#endif // {_condition}");
            }
        }
    }
}
