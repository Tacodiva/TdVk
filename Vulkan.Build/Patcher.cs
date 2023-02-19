using Mono.Cecil;
using Mono.Cecil.Cil;
using System;
using System.Linq;
using Mono.Collections.Generic;
using System.IO;
using System.Collections.Generic;
using System.Text;
using Cake.Frosting;
using Cake.Common.IO;
using Cake.Core.Diagnostics;

namespace Vulkan.Build;

public class Patcher : FrostingTask<VulkanFrostingContext>
{
    private static TypeReference s_calliRewriteRef;
    private static MethodReference s_stringToHGlobalUtf8Ref;
    private static MethodDefinition s_freeHGlobalRef;
    private static TypeReference s_intPtrRef;

    public static void Run(VulkanFrostingContext context, string path)
    {
        string vkDllPath = Path.Join(path, context.ProjectName + ".dll.temp");
        string outputPath = Path.Join(path, context.ProjectName + ".dll");

        context.MoveFile(outputPath, vkDllPath);

        try
        {
            Rewrite(context, vkDllPath, outputPath);
        }
        finally
        {
            File.Delete(vkDllPath);
        }
    }

    private static void Rewrite(VulkanFrostingContext context, string vkDllPath, string outputPath)
    {
        using (AssemblyDefinition vkDll = AssemblyDefinition.ReadAssembly(vkDllPath))
        {
            LoadRefs(vkDll);
            ModuleDefinition mainModule = vkDll.Modules[0];

            s_intPtrRef = mainModule.GetType("Vulkan.PatchHelperIntPtr");
            TypeDefinition bindingHelpers = mainModule.GetType("Vulkan.PatchHelper");
            s_stringToHGlobalUtf8Ref = bindingHelpers.Methods.Single(md => md.Name == "StringToHGlobalUtf8");
            s_freeHGlobalRef = bindingHelpers.Methods.Single(md => md.Name == "FreeHGlobal");

            foreach (var type in mainModule.Types)
            {
                ProcessType(type);
            }
            vkDll.Write(outputPath);
            context.Log.Information("Patched DLL " + outputPath);
        }
    }

    private static void LoadRefs(AssemblyDefinition vkDll)
    {
        s_calliRewriteRef = vkDll.MainModule.GetType("Vulkan.Generator.CalliRewriteAttribute");
    }

    private static void ProcessType(TypeDefinition type)
    {
        foreach (var subtype in type.NestedTypes)
        {
            ProcessType(subtype);
        }

        foreach (var method in type.Methods)
        {
            ProcessMethod(method);
        }
    }

    private static void ProcessMethod(MethodDefinition method)
    {
        if (method.CustomAttributes.Any(ca => ca.AttributeType == s_calliRewriteRef))
        {
            var processor = method.Body.GetILProcessor();
            RewriteMethod(method);
            method.CustomAttributes.Remove(method.CustomAttributes.Single(ca => ca.AttributeType == s_calliRewriteRef));
        }
    }

    private static void RewriteMethod(MethodDefinition method)
    {
        var il = method.Body.GetILProcessor();
        il.Body.Instructions.Clear();

        List<VariableDefinition> stringParams = new List<VariableDefinition>();
        for (int i = 0; i < method.Parameters.Count; i++)
        {
            EmitLoadArgument(il, i + (method.IsStatic ? 0 : 1), method.Parameters);
            TypeReference parameterType = method.Parameters[i].ParameterType;
            if (parameterType.FullName == "System.String")
            {
                VariableDefinition variableDef = new VariableDefinition(s_intPtrRef);
                method.Body.Variables.Add(variableDef);
                il.Emit(OpCodes.Call, s_stringToHGlobalUtf8Ref);
                il.Emit(OpCodes.Stloc, variableDef);
                il.Emit(OpCodes.Ldloc, variableDef);
                stringParams.Add(variableDef);
            }
            else if (parameterType.IsByReference)
            {
                VariableDefinition byRefVariable = new VariableDefinition(new PinnedType(parameterType));
                method.Body.Variables.Add(byRefVariable);
                il.Emit(OpCodes.Stloc, byRefVariable);
                il.Emit(OpCodes.Ldloc, byRefVariable);
                il.Emit(OpCodes.Conv_I);
            }
        }

        string functionPtrName = method.Name + "_ptr";
        var field = method.DeclaringType.Fields.SingleOrDefault(fd => fd.Name == functionPtrName);
        if (field == null)
        {
            throw new InvalidOperationException("Can't find function pointer field for " + method.Name);
        }

        if (field.IsStatic)
        {
            il.Emit(OpCodes.Ldsfld, field);
        }
        else
        {
            il.Emit(OpCodes.Ldarg_0);
            il.Emit(OpCodes.Ldfld, field);
        }

        CallSite callSite = new CallSite(method.ReturnType)
        {
            CallingConvention = MethodCallingConvention.StdCall
        };
        foreach (ParameterDefinition pd in method.Parameters)
        {
            TypeReference parameterType;
            if (pd.ParameterType.IsByReference)
            {
                parameterType = new PointerType(pd.ParameterType.GetElementType());
            }
            else if (pd.ParameterType.FullName == "System.String")
            {
                parameterType = s_intPtrRef;
            }
            else
            {
                parameterType = pd.ParameterType;
            }
            ParameterDefinition calliPD = new ParameterDefinition(pd.Name, pd.Attributes, parameterType);

            callSite.Parameters.Add(calliPD);
        }
        il.Emit(OpCodes.Calli, callSite);

        foreach (var stringVar in stringParams)
        {
            il.Emit(OpCodes.Ldloc, stringVar);
            il.Emit(OpCodes.Call, s_freeHGlobalRef);
        }

        il.Emit(OpCodes.Ret);

        if (method.Body.Variables.Count > 0)
        {
            method.Body.InitLocals = true;
        }
    }

    private static void EmitLoadArgument(ILProcessor il, int i, Collection<ParameterDefinition> parameters)
    {
        if (i == 0)
        {
            il.Emit(OpCodes.Ldarg_0);
        }
        else if (i == 1)
        {
            il.Emit(OpCodes.Ldarg_1);
        }
        else if (i == 2)
        {
            il.Emit(OpCodes.Ldarg_2);
        }
        else if (i == 3)
        {
            il.Emit(OpCodes.Ldarg_3);
        }
        else
        {
            il.Emit(OpCodes.Ldarg, i);
        }
    }
}