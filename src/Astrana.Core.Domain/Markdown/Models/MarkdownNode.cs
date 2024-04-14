using HtmlAgilityPack;

namespace Astrana.Core.Domain.Markdown.Models
{
    public class MarkdownNode
    {
        public MarkdownNode(HtmlNode node, IReadOnlyList<string> validElements = null)
        {
            if (node == null)
                return;

            if (node.NodeType != HtmlNodeType.Document && node.NodeType != HtmlNodeType.Text && validElements is { Count: > 0 } && !validElements.Contains(node.Name))
                return;

            Name = node.Name;
            HtmlNodeType = node.NodeType;

            if (node.NodeType == HtmlNodeType.Text)
                InnerText = node.InnerText;

            Attributes = new();
            ChildNodes = new();

            Attributes.AddRange(node.Attributes);

            foreach (var childNode in node.ChildNodes)
            {
                ChildNodes.Add(new MarkdownNode(childNode, validElements));
            }
        }

        public string Name { get; set; }

        public string InnerText { get; set; }

        public HtmlNodeType HtmlNodeType { get; set; }

        public List<HtmlAttribute> Attributes { get; set; } = new();

        public List<MarkdownNode> ChildNodes { get; set; } = new();
    }
}
