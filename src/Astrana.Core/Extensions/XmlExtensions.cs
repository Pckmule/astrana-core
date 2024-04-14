using System.Xml;

namespace Astrana.Core.Extensions
{
    public static class XmlElementExtensions
    {
        public static List<XmlElement> GetNodesByName(this XmlElement? itemNode, string tagName, string? namespaceName = null)
        {
            var list = new List<XmlElement>();

            if (itemNode?.ChildNodes == null || itemNode.ChildNodes.Count < 1)
                return list;

            foreach (var childNode in itemNode.ChildNodes)
            {
                if (childNode is XmlElement node && node.Name.Equals(tagName, StringComparison.InvariantCultureIgnoreCase))
                    list.Add(node);
            }

            return list;
        }

        public static XmlElement? GetNodeByName(this XmlElement? itemNode, string tagName, string? namespaceName = null)
        {
            return GetNodesByName(itemNode, tagName, namespaceName).FirstOrDefault();
        }


        public static List<XmlAttribute> GetAttributesByName(this XmlElement? itemNode, string attributeName, string? namespaceName = null)
        {
            var attributes = new List<XmlAttribute>();

            if (itemNode?.Attributes == null || itemNode.Attributes.Count < 1)
                return attributes;

            foreach (var nodeAttribute in itemNode.Attributes)
            {
                if (nodeAttribute is XmlAttribute attribute &&
                    attribute.Name.Equals(attributeName, StringComparison.InvariantCultureIgnoreCase))
                    attributes.Add(attribute);
            }

            return attributes;
        }

        public static XmlAttribute? GetAttributeByName(this XmlElement? itemNode, string attributeName, string? namespaceName = null)
        {
            return GetAttributesByName(itemNode, attributeName, namespaceName).FirstOrDefault();
        }

        public static string? GetAttributeValueByName(this XmlElement? itemNode, string attributeName, string? namespaceName = null)
        {
            return GetAttributeByName(itemNode, attributeName, namespaceName)?.Value;
        }
    }
}
