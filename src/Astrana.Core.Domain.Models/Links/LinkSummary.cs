using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Models.Links
{
    public class LinkSummary
    {
        [JsonConstructor]
        public LinkSummary() { }
        
        public LinkSummary(Uri url, string title = "", string description = "", List<string>? previewImages = null)
        {
            Url = url;
            Title = title;
            Description = description;
            PreviewImageUrls = previewImages ?? new List<string>();
        }

        public Uri Url { get; set; }

        public string? Locale { get; set; }

        public string? CharSet { get; set; }

        public string? Robots { get; set; }

        public string? SiteName { get; set; }

        public string? Title { get; set; }

        public string? Description { get; set; }

        public string? Keywords { get; set; }

        public List<string>? PreviewImageUrls { get; set; } = new();
    }
}
