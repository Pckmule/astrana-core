using Astrana.Core.Domain.Markdown.Models;
using Astrana.Core.Extensions;
using HtmlAgilityPack;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace Astrana.Core.Domain.Markdown
{
    public class MarkdownService: IMarkdownService
    {
        private const string MarkdownHeadingPattern = @"(?<=(^#)\s).*";
        private const string NewLinePlaceholder = "<!--newline-->";

        private const string NewLine = "\n";
        private const string DoubleNewLine = $"{NewLine}{NewLine}";
        private const string TripleNewLine = $"{NewLine}{NewLine}{NewLine}";

        public readonly IReadOnlyList<string> DefaultValidElements = ["h1", "h2", "h3", "h4", "h5", "h6", "p", "span", "strong", "b", "i", "em", "u", "a", "img", "br"];

        public string RemoveHeadings(string? markdownText)
        {
            if (string.IsNullOrWhiteSpace(markdownText))
                return null;

            return string.Join(NewLine, markdownText.Split(NewLine).Select(line => !line.StartsWith("#") ? line : null)).Trim();

            // return Regex.Replace(markdownText, MarkdownHeadingPattern, "");
        }

        public MarkdownNode? BuildDOM(string? content, List<string>? validElements = null)
        {
            if (string.IsNullOrWhiteSpace(content))
                return null;

            validElements ??= [..DefaultValidElements];

            var htmlDocument = new HtmlDocument();
                htmlDocument.LoadHtml(WebUtility.HtmlDecode(content));

            var markdownNode = new MarkdownNode(htmlDocument.DocumentNode, validElements);

            return validElements.Contains(markdownNode.Name) || markdownNode.HtmlNodeType == HtmlNodeType.Document ? markdownNode : null;
        }

        public List<MarkdownNode>? GetImageNodes(string content)
        {
            if (string.IsNullOrWhiteSpace(content))
                return null;

            var nodes = BuildDOM(content, ["a", "figure", "img"]);

            if(nodes?.ChildNodes == null)
                return new();

            var imageNodes = new List<MarkdownNode>();

            imageNodes.AddRange(nodes.ChildNodes.Where(node => node.Name == "img").Select(node => node).ToList());

            foreach (var childNode in nodes.ChildNodes)
            {
                imageNodes.AddRange(childNode.ChildNodes.Where(node => node.Name == "img").Select(node => node).ToList());
            }

            return imageNodes;
        }

        public string ToMarkdown(string? content, List<string>? validElements = null)
        {
            return ToMarkdown(BuildDOM(content, validElements));
        }

        public string ToMarkdown(MarkdownNode? node)
        {
            var markdownText = ToMarkdownText(node).Trim().Replace(NewLinePlaceholder, NewLine);

            while (markdownText.Contains(TripleNewLine))
            {
                markdownText = markdownText.Replace(TripleNewLine, DoubleNewLine);
            }

            return markdownText;
        }

        private static string ToMarkdownText(MarkdownNode? node, MarkdownNode? previousSiblingNode = null, MarkdownNode? nextSiblingNode = null)
        {
            if (node == null)
                return string.Empty;

            var sb = new StringBuilder();

            if (node.HtmlNodeType == HtmlNodeType.Document)
            {
                for (var i = 0; i < node.ChildNodes.Count; i++)
                {
                    sb.Append
                    (
                        ToMarkdownText
                        (
                            node.ChildNodes[i],
                            i > 0 ? node.ChildNodes[i - 1] : null,
                            i < node.ChildNodes.Count - 1 ? node.ChildNodes[i + 1] : null
                        )
                    );
                }
            }
            else if (node.HtmlNodeType == HtmlNodeType.Element)
            {
                if (node.Name == "img")
                {
                    sb.AppendIfNotEmptyOrWhitespace(BuildImageMarkdown(node));
                }
                else if (node.Name == "figure")
                {
                    if (node.ChildNodes.Any())
                        foreach (var childNode in node.ChildNodes)
                            sb.Append(ToMarkdownText(childNode));
                }
                else if (node.Name == "a")
                {
                    var markdownText = BuildLinkMarkdown(node, previousSiblingNode, nextSiblingNode);

                    if (!string.IsNullOrWhiteSpace(markdownText))
                        sb.Append(markdownText);
                }
                else if (node.Name is "h1" or "h2" or "h3" or "h4" or "h5" or "h6")
                {
                    var markdownText = BuildHeadingMarkdown(node);

                    if (!string.IsNullOrWhiteSpace(markdownText))
                        sb.Append(markdownText);
                }
                else if (node.Name == "p")
                {
                    sb.Append(NewLinePlaceholder);
                    sb.Append(NewLinePlaceholder);
                }
                else if (node.Name == "br")
                {
                    sb.Append(NewLinePlaceholder);
                }
                else if (node.Name is "strong" or "b")
                {
                    var markdown = BuildWrappedTextMarkdown(node, "**");

                    if (!string.IsNullOrEmpty(markdown))
                        sb.Append(markdown);
                }
                else if (node.Name is "i" or "em")
                {
                    var markdown = BuildWrappedTextMarkdown(node, "*");

                    if (!string.IsNullOrEmpty(markdown))
                        sb.Append(markdown);
                }
                else if (node.Name == "u")
                {
                    var markdown = BuildNoMarkupTextMarkdown(node);

                    if (!string.IsNullOrWhiteSpace(markdown))
                        sb.Append(markdown);
                }

                if (node.Name is not ("p" or "span"))
                    return sb.ToString();

                for (var i = 0; i < node.ChildNodes.Count; i++)
                {
                    sb.Append
                    (
                        ToMarkdownText
                        (
                            node.ChildNodes[i],
                            i > 0 ? node.ChildNodes[i - 1] : null,
                            i < node.ChildNodes.Count - 1 ? node.ChildNodes[i + 1] : null
                        )
                    );
                }
            }
            else if (node.HtmlNodeType == HtmlNodeType.Text)
            {
                var text = node.InnerText;

                if (!string.IsNullOrWhiteSpace(text))
                {
                    const string linkPattern = @"^http(s?)\:\/\/[0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*(:(0-9)*)*(\/?)([a-zA-Z0-9\-\.\?\,\'\/\\\+&%\$#_]*)?$";

                    var matches = new Regex(linkPattern).Matches(text);

                    if (matches.Count < 1)
                        return text;

                    foreach (var matchedValue in matches.Select(match => match.Value).ToList())
                    {
                        text = text.Replace(matchedValue, BuildLinkMarkdown(matchedValue));
                    }

                    sb.Append(text);
                }
            }

            var lines = sb.ToString().Split('\n');
            for (var i = 0; i < lines.Length; i++)
            {
                lines[i] = lines[i].Trim();
            }

            return new StringBuilder().AppendJoin("\n", lines).ToString();
        }

        private static string? GetNodeAttribute(MarkdownNode node, string attributeName, string? defaultValue = "")
        {
            if (node == null)
                throw new ArgumentNullException(nameof(node));

            if (string.IsNullOrWhiteSpace(attributeName))
                throw new ArgumentException(nameof(node));

            return node.Attributes.Find(a => a.Name == attributeName)?.Value ?? defaultValue;
        }

        public static StringBuilder GetNodeChildrenMarkdownText(MarkdownNode node)
        {
            var sb = new StringBuilder();

            foreach (var childNode in node.ChildNodes)
                sb.Append(ToMarkdownText(childNode));

            return sb;
        }

        public static string BuildHeadingMarkdown(MarkdownNode node)
        {
            if (node == null)
                throw new ArgumentNullException(nameof(node));

            var text = GetChildNodeText(node);

            return BuildHeadingMarkdown(short.Parse(node.Name[1..]), text);
        }

        public static string BuildHeadingMarkdown(short headingSize, string text)
        {
            if (headingSize is < 1 or > 6)
                throw new ArgumentOutOfRangeException(nameof(headingSize), "Heading size must be a number from 1 to 6.");

            if (string.IsNullOrWhiteSpace(text))
                throw new ArgumentException(nameof(text));

            var sb = new StringBuilder();

            if (string.IsNullOrWhiteSpace(text)) 
                return string.Empty;

            for (var i = headingSize; i > 0; i--)
                sb.Append('#');

            sb.Append(' ');
            sb.AppendLine(text);
            sb.AppendLine();

            return sb.ToString();
        }

        public static string BuildLinkMarkdown(MarkdownNode node, MarkdownNode? previousSiblingNode = null, MarkdownNode? nextSiblingNode = null)
        {
            if (node == null)
                throw new ArgumentNullException(nameof(node));

            var sb = new StringBuilder();

            var href = GetNodeAttribute(node, "href");
            var text = GetChildNodeText(node);

            if (string.IsNullOrWhiteSpace(href))
                return sb.ToString();

            if (string.IsNullOrWhiteSpace(text))
                text = href;

            var hasTextContentOnly = !node.ChildNodes.Exists(c => c.HtmlNodeType != HtmlNodeType.Text);

            if (previousSiblingNode != null)
                sb.Append(' ');

            sb.Append(hasTextContentOnly
                ? BuildLinkMarkdown(href, text.Trim())
                : BuildLinkMarkdown(href, GetNodeChildrenMarkdownText(node).ToString().Trim()));

            if (nextSiblingNode != null)
                sb.Append(' ');

            return sb.ToString();
        }

        public static string BuildLinkMarkdown(string href, string? text = null)
        {
            if (string.IsNullOrWhiteSpace(href))
                throw new ArgumentException(nameof(href));

            var sb = new StringBuilder();

            if (string.IsNullOrWhiteSpace(text))
                text = href;

            var safeHref = BuildSafeUrl(href);

            sb.Append($"[{text}](" + safeHref + ")");

            return sb.ToString();
        }

        private static string BuildSafeUrl(string? href)
        {
            return "/redirect?l=" + WebUtility.UrlEncode(href);
        }

        public static string BuildImageMarkdown(MarkdownNode node)
        {
            if (node == null)
                throw new ArgumentNullException(nameof(node));

            var source = GetNodeAttribute(node, "src");
            var altText = GetNodeAttribute(node, "alt");
            var title = GetNodeAttribute(node, "title");
            var width = GetNodeAttribute(node, "width", "100%");

            if (string.IsNullOrWhiteSpace(source))
                return string.Empty;

            return "![" + altText + "](" + source + "" + (string.IsNullOrWhiteSpace(title) ? "" : " \"" + title + "\"") + ")";
        }

        public static string BuildWrappedTextMarkdown(MarkdownNode node, string wrapWith)
        {
            if (node == null)
                return string.Empty;

            if (string.IsNullOrWhiteSpace(wrapWith))
                throw new ArgumentException(nameof(wrapWith));

            var text = GetChildNodeText(node);

            if (string.IsNullOrWhiteSpace(text) && !string.IsNullOrEmpty(text))
                return text;

            if (string.IsNullOrWhiteSpace(text))
                return string.Empty;

            return wrapWith + text + wrapWith;
        }

        public static string BuildNoMarkupTextMarkdown(MarkdownNode node)
        {
            if (node == null)
                return string.Empty;

            var text = GetChildNodeText(node);

            if (string.IsNullOrWhiteSpace(text))
                return string.Empty;

            return text;
        }

        public static string GetChildNodeText(MarkdownNode node)
        {
            return string.Join("", node.ChildNodes.Where(c => c.HtmlNodeType == HtmlNodeType.Text).Select(t => t.InnerText).ToList());
        }
    }
}