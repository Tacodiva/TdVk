using System;
using System.Linq;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Vulkan.Build.Codegen
{
    public class EnumDefinition
    {
        public string Name { get; }
        public int Bitwidth;
        public EnumType Type { get; }
        public EnumValue[] Values { get; set; }

        public EnumDefinition(string name, int bitwidth, EnumType type, EnumValue[] values)
        {
            Require.NotNullOrEmpty(name);
            Require.NotNull(values);

            Name = name;
            Type = type;
            Values = values;
            Bitwidth = bitwidth;
        }

        public static EnumDefinition CreateFromXml(XElement xe)
        {
            Require.NotNull(xe);

            EnumType type;
            var typeAttr = xe.Attribute("type");
            if (typeAttr != null)
            {
                string typeString = xe.Attribute("type").Value;
                type = (EnumType)Enum.Parse(typeof(EnumType), typeString, true);
            }
            else
            {
                type = EnumType.Constants;
            }

            string name = xe.Attribute("name").Value;
            int bitwidth = int.Parse(xe.Attribute("bitwidth")?.Value ?? "32");
            EnumValue[] values = xe.Elements("enum")
                .Where(typex => typex.Attribute("alias") == null)
                .Select(valuesx => EnumValue.CreateFromXml(valuesx, type == EnumType.Bitmask))
                .ToArray();
            return new EnumDefinition(name, bitwidth, type, values);
        }

        public override string ToString()
        {
            return $"Enum: {Name} ({Type})[{Values.Length}]";
        }
    }

    public enum EnumType
    {
        Bitmask,
        Enum,
        Constants,
    }

    public class EnumValue
    {
        public string Name { get; }
        public long Value { get; }
        public string Comment { get; }

        public EnumValue(string name, long value, string comment)
        {
            Name = name;
            Value = value;
            Comment = comment;
        }

        public static EnumValue CreateFromXml(XElement xe, bool isBitmask)
        {
            Require.NotNull(xe);

            string name = xe.Attribute("name").Value;

            long value;
            string valueStr = xe.Attribute("value")?.Value;
            if (valueStr != null)
            {
                if (valueStr.StartsWith("0x"))
                {
                    valueStr = valueStr.Substring(2);
                    value = long.Parse(valueStr, System.Globalization.NumberStyles.HexNumber);
                }
                else
                {
                    value = long.Parse(valueStr);
                }
            }
            else
            {
                string bitposStr = xe.Attribute("bitpos").Value;
                value = 1L << int.Parse(bitposStr);
            }

            var commentAttr = xe.Attribute("comment");
            string comment = commentAttr != null ? commentAttr.Value : string.Empty;
            return new EnumValue(name, value, comment);
        }
    }
}
