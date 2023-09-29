using System.Xml.Linq;

namespace Vulkan.Build.Codegen
{
    public class TypedefDefinition
    {
        public string Name { get; }
        public string Requires { get; }
        public string Type { get; }
        public string BitValues { get; }

        public TypedefDefinition(string name, string requires, string type, string bitValues)
        {
            Name = name;
            Requires = requires;
            Type = type;
            BitValues = bitValues;
        }

        public static TypedefDefinition CreateFromXml(XElement xe)
        {
            string name = xe.GetNameElement();
            string requires = xe.Attribute("requires")?.Value;
            string type = xe.GetTypeElement();
            string bitValues = xe.Attribute("bitvalues")?.Value;
            return new TypedefDefinition(name, requires, type, bitValues);
        }

        public override string ToString()
        {
            return $"{Name}, {Requires} -> {Type}";
        }
    }
}
