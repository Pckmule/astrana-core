using Astrana.Core.Domain.Markdown.Models;

namespace Astrana.Core.Domain.Markdown
{
    public interface IMarkdownService
    {
        public string RemoveHeadings(string? markdownText);

        public MarkdownNode? BuildDOM(string content, List<string>? validElements = null);

        public List<MarkdownNode>? GetImageNodes(string content);

        public string ToMarkdown(string? content, List<string>? validElements = null);

        public string ToMarkdown(MarkdownNode? node);
    }
}