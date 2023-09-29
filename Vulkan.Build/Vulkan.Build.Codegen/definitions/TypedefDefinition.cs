using System.Xml.Linq;

namespace Vulkan.Build.Codegen
{
    public class TypedefDefinition
    {
        public string Name { get; }
        public string Requires { get; }
        public string Type { get; }
        public string BitValues { get; }
        public string API { get; }

        public TypedefDefinition(string name, string requires, string type, string bitValues, string api)
        {
            Name = name;
            Requires = requires;
            Type = type;
            BitValues = bitValues;
            API = api;
        }

        public static TypedefDefinition CreateFromXml(XElement xe)
        {
            string name = xe.GetNameElement();
            string requires = xe.Attribute("requires")?.Value;
            string type = xe.GetTypeElement();
            string bitValues = xe.Attribute("bitvalues")?.Value;
            string api = xe.Attribute("api")?.Value;
            return new TypedefDefinition(name, requires, type, bitValues, api);
        }

        public override string ToString()
        {
            return $"{Name}, {Requires} -> {Type}";
        }
    }
}
