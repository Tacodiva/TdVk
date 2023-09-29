using System;
using System.Collections.Generic;
using System.Linq;

namespace Vulkan.Build.Codegen
{
    public static class VariantGenerator
    {
        public static CommandDefinition[] GenerateVariants(CommandDefinition cd, TypeNameMappings tnm)
        {
            ParameterDefinition[] parameters = cd.Parameters;
            List<ParameterDefinition>[] parameterPossibilities = new List<ParameterDefinition>[parameters.Length];
            for (int i = 0; i < parameters.Length; i++)
            {
                parameterPossibilities[i] = new List<ParameterDefinition>() { parameters[i] };
                parameterPossibilities[i].AddRange(GenerateVariantParameters(cd, parameters[i], tnm));
            }

            ParameterDefinition[][] definitions = parameterPossibilities.Select(l => l.ToArray()).ToArray();
            var combos = GetCombinations(definitions).ToArray();
            CommandDefinition[] commands = combos.Skip(1).Select(pd =>
            {
                return new CommandDefinition(cd.Name, cd.ReturnType, pd, cd.API, cd.SuccessCodes, cd.ErrorCodes, true, cd.Extension);
            }).ToArray();

            return commands;
        }

        private static IEnumerable<ParameterDefinition[]> GetCombinations(ParameterDefinition[][] pds)
        {
            ParameterDefinition[] first = pds.First();
            ParameterDefinition[][] rest = GetSubArray(pds, 1);
            foreach (var option in first)
            {
                if (!rest.Any())
                {
                    yield return new[] { option };
                }
                else
                {
                    var restVariants = GetCombinations(rest);
                    foreach (var restVariant in restVariants)
                    {
                        yield return Prepend(option, restVariant);
                    }
                }
            }
        }

        private static IEnumerable<ParameterDefinition> GenerateVariantParameters(CommandDefinition cd, ParameterDefinition pd, TypeNameMappings tnm)
        {
            if (CanHaveVariant(pd, tnm))
            {
                if ((cd.Name.StartsWith("vkCreate") || cd.Name.StartsWith("vkAllocate") || cd.Name.StartsWith("vkGet")) && pd == cd.Parameters.Last())
                {
                    yield return OutVariant(pd);
                }
                else if (pd.Type.Name == "char" && pd.Type.PointerIndirection == 1)
                {
                    yield return StringVariant(pd);
                }
                else
                {
                    yield return RefVariant(pd);
                    yield return IntPtrVariant(pd);
                    if (pd.Name.EndsWith("Infos"))
                    {
                        yield return ArrayVariant(pd, 1);
                    }
                }
            }
        }

        private static ParameterDefinition StringVariant(ParameterDefinition pd)
        {
            TypeSpec typeSpec = new TypeSpec("string");
            return new ParameterDefinition(pd.Name, typeSpec, ParameterModifier.None, pd.IsOptional, pd.API);
        }

        private static ParameterDefinition ArrayVariant(ParameterDefinition pd, int dimensions)
        {
            TypeSpec typeSpec = new TypeSpec(pd.Type.Name, pd.Type.PointerIndirection - 1, dimensions);
            return new ParameterDefinition(pd.Name, typeSpec, ParameterModifier.None, pd.IsOptional, pd.API);
        }

        private static ParameterDefinition OutVariant(ParameterDefinition pd)
        {
            TypeSpec typeSpec = new TypeSpec(pd.Type.Name, pd.Type.PointerIndirection - 1);
            return new ParameterDefinition(pd.Name, typeSpec, ParameterModifier.Out, pd.IsOptional, pd.API);
        }

        private static ParameterDefinition RefVariant(ParameterDefinition pd)
        {
            TypeSpec typeSpec = new TypeSpec(pd.Type.Name, pd.Type.PointerIndirection - 1);
            return new ParameterDefinition(pd.Name, typeSpec, ParameterModifier.Ref, pd.IsOptional, pd.API);
        }

        private static ParameterDefinition IntPtrVariant(ParameterDefinition pd)
        {
            TypeSpec typeSpec = new TypeSpec(nameof(IntPtr));
            return new ParameterDefinition(pd.Name, typeSpec, ParameterModifier.None, pd.IsOptional, pd.API);
        }

        private static bool CanHaveVariant(ParameterDefinition pd, TypeNameMappings tnm)
        {
            return pd.Type.PointerIndirection > 0 && tnm.GetMappedName(pd.Type.Name) != "void" && (pd.API == null || pd.API == "vulkan");
        }

        private static T[] GetSubArray<T>(T[] array, int skip)
        {
            return array.Skip(skip).ToArray();
        }

        private static T[] Prepend<T>(T first, T[] rest)
        {
            T[] arr = new T[rest.Length + 1];
            rest.CopyTo(arr, 1);
            arr[0] = first;
            return arr;
        }
    }
}
