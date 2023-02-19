using System;
using System.Collections.Generic;
using System.Text;

namespace Vulkan.Build.Codegen
{
    public static class CodegenUtil
    {
        private static readonly Dictionary<string, int> s_typeSizes = new Dictionary<string, int>
        {
            { "byte", 1 },
            { "uint", 4 },
            { "ulong", 4 },
            { "int", 4 },
            { "float", 4 },
        };

        private static readonly HashSet<string> s_keywords = new HashSet<string>
        {
            "object",
            "event",
        };

        public static int GetTypeSize(TypeSpec type)
        {
            if (type.PointerIndirection != 0 || !s_typeSizes.TryGetValue(type.Name, out int size))
            {
                throw new InvalidOperationException();
            }

            return size;
        }

        public static string NormalizeFieldName(string name)
        {
            if (s_keywords.Contains(name))
            {
                return "@" + name;
            }

            return name;
        }
        public static void SpaceSeparatedList<T>(CsCodeWriter cw, IList<T> list, Action<T> action)
        {
            for (int i = 0; i < list.Count; i++)
            {
                var item = list[i];
                action(item);
                if (i != list.Count - 1)
                {
                    cw.WriteLine();
                }
            }
        }

        private static readonly char[] s_underscoreSeparator = { '_' };

        private static readonly HashSet<string> s_preserveCaps = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            "khr",
            "khx",
            "ext",
            "nv",
            "nvx",
            "amd",
        };


        public static string GetPrettyName(string value, string prefix, HashSet<string> ignoredParts = null)
        {
            if (value.IndexOf(prefix) != 0)
            {
                return value;
            }

            string[] parts = value.Substring(prefix.Length, value.Length - prefix.Length)
                .Split(s_underscoreSeparator, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder sb = new StringBuilder();
            foreach (string part in parts)
            {
                if (ignoredParts != null && ignoredParts.Contains(part))
                {
                    continue;
                }

                if (s_preserveCaps.Contains(part))
                {
                    sb.Append(part);
                }
                else
                {
                    sb.Append(char.ToUpper(part[0]));
                    for (int i = 1; i < part.Length; i++)
                    {
                        sb.Append(char.ToLower(part[i]));
                    }
                }
            }

            string prettyName = sb.ToString();
            return (char.IsNumber(prettyName[0])) ? "_" + prettyName : prettyName;
        }
    }
}