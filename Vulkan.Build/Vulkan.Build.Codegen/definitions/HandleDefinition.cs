using System.Xml.Linq;

namespace Vulkan.Build.Codegen
{
    public class HandleDefinition
    {
        public string Name { get; }
        public bool Dispatchable { get; }
        public string Parent { get; }
        public string ObjTypeEnum { get; }

        public HandleDefinition(string name, bool dispatchable, string parent, string objTypeEnum)
        {
            Name = name;
            Dispatchable = dispatchable;
            Parent = parent;
            ObjTypeEnum = objTypeEnum;
        }

        public static HandleDefinition CreateFromXml(XElement xe)
        {
            Require.NotNull(xe);
            string name = xe.GetNameElement();
            bool dispatchable = xe.GetTypeElement() == "VK_DEFINE_HANDLE";
            string parent = xe.Attribute("parent")?.Value;
            string objTypeEnum = xe.Attribute("objtypeenum").Value;

            return new HandleDefinition(name, dispatchable, parent, objTypeEnum);
        }
    }
}
