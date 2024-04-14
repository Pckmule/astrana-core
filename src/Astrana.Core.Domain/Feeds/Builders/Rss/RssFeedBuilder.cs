/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Feeds.Models;
using Astrana.Core.Domain.Feeds.Models.Rss;
using Astrana.Core.Domain.Markdown;
using Astrana.Core.Domain.Models.Files.DomainTransferObjects;
using Astrana.Core.Domain.Models.Images.DomainTransferObjects;
using Astrana.Core.Extensions;
using Astrana.Core.Utilities;
using Microsoft.Extensions.Logging;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Xml;

namespace Astrana.Core.Domain.Feeds.Builders.Rss
{
    public class RssFeedBuilder : IRssFeedBuilder
    {
        private readonly ILogger<RssFeedBuilder> _logger;
        private readonly IMarkdownService _markdownService;

        private readonly List<string> _htmlTextGroupingElementTags = ["p", "span", "br"];
        private readonly List<string> _htmlTextFormattingElementTags = ["strong", "b", "i", "em", "u"];
        private readonly List<string> _htmlLinkElementTags = ["a"];
        
        private readonly List<string> _htmlTextElementTags = [];

        public RssFeedBuilder(ILogger<RssFeedBuilder> logger, IMarkdownService markdownService)
        {
            _logger = logger;
            _markdownService = markdownService;

            _htmlTextElementTags.AddRange(_htmlTextGroupingElementTags);
            _htmlTextElementTags.AddRange(_htmlTextFormattingElementTags);
            _htmlTextElementTags.AddRange(_htmlLinkElementTags);
        }

        public RssFeedSummary BuildFeedSummary(Uri url, XmlDocument xmlDocument)
        {
            _logger.LogDebug("Building RSS feed summary.");

            ArgumentNullException.ThrowIfNull(xmlDocument);

            if (xmlDocument.DocumentElement == null)
                throw new ArgumentException("No feed data found.");

            var htmlRoot = xmlDocument.DocumentElement;

            var rawFormatVersion = StripCData(htmlRoot?.GetAttributeValueByName("version"));

            var channelNode = htmlRoot.GetNodeByName("channel");

            var rawId = StripCData(channelNode?.GetNodeByName("id")?.InnerXml);

            var rawPageLang = StripCData(channelNode?.GetAttributeValueByName("lang"));
            var rawLanguage = StripCData(channelNode?.GetNodeByName("language")?.InnerXml);

            var rawTitle = StripCData(channelNode?.GetNodeByName("title")?.InnerXml);
            var rawDescription = StripCData(channelNode?.GetNodeByName("description")?.InnerXml);

            var rawIconNode = channelNode?.GetNodeByName("icon");
            var rawImageNode = channelNode?.GetNodeByName("image");

            var rawCopyright = StripCData(channelNode?.GetNodeByName("copyright")?.InnerXml);
            var rawRights = StripCData(channelNode?.GetNodeByName("rights")?.InnerXml);

            var rawRating = StripCData(channelNode?.GetNodeByName("rating")?.InnerXml);

            var rawTimeToLive = StripCData(channelNode?.GetNodeByName("ttl")?.InnerXml);
            var rawGenerator = StripCData(channelNode?.GetNodeByName("generator")?.InnerXml);

            var rawCategories = channelNode?.GetNodesByName("category");
            var rawAuthors = channelNode?.GetNodesByName("author");
            var rawLinks = channelNode?.GetNodesByName("links");

            var rawPublished = StripCData(channelNode?.GetNodeByName("pubDate")?.InnerXml);


            var id = Normalize(rawId);

            var title = GetTitle(rawTitle, true);

            var description = GetFeedSummaryDescription(rawDescription, rawTitle);

            var copyright = SelectRightsText(rawCopyright, rawRights);
            var rating = Normalize(rawRating);

            var iconImage = GetImageDtoFromNode(rawIconNode);
            var image = GetImageDtoFromNode(rawImageNode);

            var locale = GetFeedSummaryLocale(rawLanguage, rawPageLang);
            var language = GetFeedSummaryLanguage(rawLanguage, rawPageLang);

            var categories = ParseCategories(rawCategories);

            var authors = ParseAuthors(rawAuthors);

            var links = ParseLinks(rawLinks);

            var websiteLink = GetWebsiteLink(links);

            var timeToLive = int.TryParse(rawTimeToLive, out var rawTimeToLiveParsed) ? rawTimeToLiveParsed : (int?)null;
            var generator = Normalize(rawGenerator);

            var published = AsDateTimeOffset(rawPublished);

            var feedSummary = new RssFeedSummary
            {
                Url = url,
                FormatVersion = Normalize(rawFormatVersion),

                Id = id,

                Locale = locale,
                Language = language,

                Title = title,
                Description = description,

                Copyright = copyright,
                Rating = rating,

                IconImage = iconImage,
                Image = image,

                Authors = authors,

                Categories = categories,
                Links = links,

                WebsiteUrl = websiteLink?.Href,

                TimeToLive = timeToLive,
                Generator = generator,

                Published = published
            };

            return feedSummary;
        }

        private string? GetTitle(string? rawTitle, bool allowHtml = false)
        {
            var title = rawTitle;

            if (allowHtml)
                title = _markdownService.ToMarkdown(title, _htmlTextFormattingElementTags);

            return Normalize(title);
        }

        private string? GetFeedSummaryDescription(string? rawDescription, string? rawTitle = null)
        {
            if (rawDescription == rawTitle)
                return null;

            var description = TruncateText(_markdownService.ToMarkdown(rawDescription, _htmlTextGroupingElementTags));

            return Normalize(description);
        }

        private string? SelectRightsText(string? rawCopyright, string? rawRights = null)
        {
            var copyright = rawCopyright;

            if (!string.IsNullOrWhiteSpace(copyright))
                return copyright;

            if (string.IsNullOrWhiteSpace(rawRights))
                copyright = rawRights;

            copyright = _markdownService.ToMarkdown(copyright, _htmlTextGroupingElementTags);

            return Normalize(copyright);
        }

        private static string? GetFeedSummaryLanguage(string? rawLanguage, string? rawPageLang)
        {
            return Normalize(rawLanguage.DefaultIfEmpty(rawPageLang));
        }

        private static string? GetFeedSummaryLocale(string? rawLanguage, string? rawPageLang)
        {
            return Normalize(rawLanguage.DefaultIfEmpty(rawPageLang));
        }

        public List<RssFeedItem> BuildFeedItems(Uri feedUrl, string feedContent, FeedSource? source = null)
        {
            ArgumentNullException.ThrowIfNull(feedUrl);
            ArgumentNullException.ThrowIfNull(feedContent);

            var xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(feedContent);

            var feedItems = xmlDocument.DocumentElement?.GetNodeByName("channel").GetNodesByName("item").Select(feedItem =>
            {
                var item = BuildRssFeedItem(feedItem, source);

                return item.IsValid ? item : null;

            }).Where(item => item != null).ToList();

            return (feedItems ?? [])!;
        }

        public RssFeedItem BuildRssFeedItem(XmlElement itemNode, FeedSource? source = null)
        {
            _logger.LogDebug("Building RSS Feed Item.");

            if (itemNode == null)
                throw new ArgumentNullException(nameof(itemNode));

            var rawGuid = StripCData(itemNode.GetNodeByName("guid")?.InnerXml);

            var rawTitle = StripCData(itemNode.GetNodeByName("title")?.InnerXml);
            
            var rawContent = StripCData(itemNode.GetNodeByName("content")?.InnerXml);
            var rawContentEncoded = StripCData(itemNode.GetNodeByName("content:encoded")?.InnerXml);

            var rawDescription = StripCData(itemNode.GetNodeByName("description")?.InnerXml);
            
            var rawRating = StripCData(itemNode.GetNodeByName("rating")?.InnerXml); // https://www.w3.org/PICS

            var rawCopyright = StripCData(itemNode.GetNodeByName("copyright")?.InnerXml);
            var rawRights = StripCData(itemNode.GetNodeByName("rights")?.InnerXml);

            var rawImageNode = itemNode.GetNodeByName("thumbnail");
            var rawThumbnailNode = itemNode.GetNodeByName("thumbnail");

            var rawAuthorNodes = itemNode.GetNodesByName("author");
            var rawCategoryNodes = itemNode.GetNodesByName("category");
            var rawLinkNodes = itemNode.GetNodesByName("link");

            var rawDcCreatorNodes = itemNode.GetNodesByName("dc:creator");

            var rawMediaThumbnailNode = itemNode.GetNodeByName("media:thumbnail");

            var rawMediaGroupNode = itemNode.GetNodeByName("media:group");
            var rawMediaGroupThumbnailNode = rawMediaGroupNode?.GetNodeByName("media:thumbnail");
            var rawMediaGroupDescription = StripCData(rawMediaGroupNode?.GetNodeByName("media:description")?.InnerXml);
            var rawMediaGroupRating = StripCData(rawMediaGroupNode?.GetNodeByName("media:rating")?.InnerXml);

            var rawPublished = StripCData(itemNode.GetNodeByName("pubdate")?.InnerXml);
            var rawLastUpdated = StripCData(itemNode.GetNodeByName("updated")?.InnerXml);

            var title = GetTitle(rawTitle, true);

            var content = GetItemContent(rawContent, rawMediaGroupDescription);

            var summary = GetItemSummary(rawDescription, rawContent, rawContentEncoded, rawMediaGroupDescription);

            var rating = GetItemRating(rawRating, rawMediaGroupRating);

            var copyright = GetItemCopyright(rawCopyright, rawRights);

            var thumbnailImage = SelectThumbnailImage(rawThumbnailNode, rawMediaThumbnailNode, rawMediaGroupThumbnailNode);
            var image = SelectImage(rawImageNode, rawThumbnailNode, rawDescription, rawContent, rawContentEncoded, rawMediaGroupDescription);

            var published = AsDateTimeOffset(rawPublished);
            var lastUpdated = AsDateTimeOffset(rawLastUpdated);

            var authors = ParseAuthors(rawAuthorNodes, rawDcCreatorNodes);
            var categories = ParseCategories(rawCategoryNodes);
            var links = ParseLinks(rawLinkNodes);

            var websiteLink = GetWebsiteLink(links);
            var sourceUrl = websiteLink?.Href;

            var feedItem = new RssFeedItem
            {
                Guid = Normalize(rawGuid),

                Title = title,
                Summary = summary,
                Content = content,
                
                Copyright = copyright,
                
                Rating = Normalize(rating),

                Image = image,
                Thumbnail = thumbnailImage,
                
                Authors = authors,
                Categories = categories,
                Links = links,

                Published = published,
                LastUpdated = lastUpdated ?? published,

                Source = new FeedSource(sourceUrl, source?.Name, source?.IconUrl)
            };

            return feedItem;
        }

        private static RssFeedLink? GetWebsiteLink(List<RssFeedLink>? links)
        {
            if (links == null)
                throw new ArgumentNullException(nameof(links));

            return links.Find(l => string.IsNullOrWhiteSpace(l.Rel)) ?? links.Find(l => l.Rel == "alternate");
        }

        private string? GetItemContent(string? rawContent, string? rawMediaGroupDescription)
        {
            var content = rawContent;

            if (string.IsNullOrWhiteSpace(content) && !string.IsNullOrWhiteSpace(rawMediaGroupDescription))
                content = rawMediaGroupDescription;

            if (string.IsNullOrWhiteSpace(content))
                return null;

            content = _markdownService.ToMarkdown(content);

            return Normalize(content);
        }

        private string? GetItemSummary(string? rawDescription, string? rawContent = null, string? rawContentEncoded = null, string? rawMediaGroupDescription = null)
        {
            var summary = _markdownService.ToMarkdown(rawDescription?.Trim(), _htmlTextElementTags);

            if (string.IsNullOrWhiteSpace(summary) && !string.IsNullOrWhiteSpace(rawContent?.Trim()))
                summary = TruncateText(_markdownService.ToMarkdown(rawContent.Trim(), _htmlTextElementTags));

            if (string.IsNullOrWhiteSpace(summary) && !string.IsNullOrWhiteSpace(rawContentEncoded?.Trim()))
                summary = TruncateText(_markdownService.ToMarkdown(rawContentEncoded.Trim(), _htmlTextElementTags));

            if (string.IsNullOrWhiteSpace(summary) && !string.IsNullOrWhiteSpace(rawMediaGroupDescription?.Trim()))
                summary = TruncateText(_markdownService.ToMarkdown(rawMediaGroupDescription.Trim(), _htmlTextElementTags));

            return Normalize(summary);
        }

        private static string? GetItemRating(string? rawRating, string? rawMediaGroupRating)
        {
            var rating = rawRating;

            if (!string.IsNullOrWhiteSpace(rating)) 
                return rating;

            if (!string.IsNullOrWhiteSpace(rawMediaGroupRating))
                rating = rawMediaGroupRating;

            return Normalize(rating);
        }

        private string? GetItemCopyright(string? rawCopyright, string? rawRights)
        {
            var copyright = rawCopyright;

            if (!string.IsNullOrWhiteSpace(copyright)) 
                return copyright;

            if (string.IsNullOrWhiteSpace(rawRights))
                copyright = rawRights;

            copyright = _markdownService.ToMarkdown(copyright, _htmlTextElementTags);
            
            return Normalize(copyright);
        }

        private static ImageDto? SelectThumbnailImage(XmlElement? rawThumbnailNode, XmlElement? rawMediaThumbnailNode, XmlElement? rawMediaGroupThumbnailNode)
        {
            var image = rawThumbnailNode == null ? null : GetImageDtoFromNode(rawThumbnailNode);

            if (string.IsNullOrWhiteSpace(image?.Location) && rawMediaThumbnailNode != null)
                image = GetImageDtoFromNode(rawMediaThumbnailNode);

            if (string.IsNullOrWhiteSpace(image?.Location) && rawMediaGroupThumbnailNode != null)
                image = GetImageDtoFromNode(rawMediaGroupThumbnailNode);

            return image;
        }

        private ImageDto? SelectImage(XmlElement? rawImageNode, XmlElement? rawThumbnailNode = null, string? rawDescription = null, string? rawContent = null, string? rawContentEncoded = null, string? rawMediaGroupDescription = null)
        {
            var image = GetImageDtoFromNode(rawImageNode);

            if (string.IsNullOrWhiteSpace(image?.Location) && !string.IsNullOrWhiteSpace(rawDescription))
            {
                image = SelectImageFromHtmlText(rawDescription);
            }

            if (string.IsNullOrWhiteSpace(image?.Location) && !string.IsNullOrWhiteSpace(rawContent))
            {
                image = SelectImageFromHtmlText(rawContent);
            }

            if (string.IsNullOrWhiteSpace(image?.Location) && !string.IsNullOrWhiteSpace(rawContentEncoded))
            {
                image = SelectImageFromHtmlText(rawContentEncoded);
            }

            if (string.IsNullOrWhiteSpace(image?.Location) && !string.IsNullOrWhiteSpace(rawMediaGroupDescription))
            {
                image = SelectImageFromHtmlText(rawMediaGroupDescription);
            }

            if (!string.IsNullOrWhiteSpace(image?.Location) && rawThumbnailNode != null)
                image = GetImageDtoFromNode(rawThumbnailNode);

            return image;
        }

        private ImageDto? SelectImageFromHtmlText(string text)
        {
            var imagesFromSummary = _markdownService.GetImageNodes(text);

            if (imagesFromSummary is not { Count: > 0 })
                return null;

            var location = imagesFromSummary[0].Attributes.Find(a => a.Name == "src")?.Value;

            long? imageWidth = long.TryParse(imagesFromSummary[0].Attributes.Find(a => a.Name == "width")?.Value, out var width) ? width : null;
            long? imageHeight = long.TryParse(imagesFromSummary[0].Attributes.Find(a => a.Name == "height")?.Value, out var height) ? height : null;

            return new ImageDto
            {
                Location = location,
                Size = new FileSizeInfoDto(null, imageWidth, imageHeight)
            };
        }

        private static ImageDto? GetImageDtoFromNode(XmlElement? rawImageNode)
        {
            if(rawImageNode == null) 
                return null;

            var image = new ImageDto
            {
                Location = Normalize(StripCData(rawImageNode.GetNodeByName("url")?.InnerXml))
            };

            if (string.IsNullOrWhiteSpace(image.Location))
                image.Location = Normalize(StripCData(rawImageNode.GetAttributeValueByName("url")));

            if (string.IsNullOrWhiteSpace(image.Location))
                image.Location = Normalize(StripCData(rawImageNode.GetAttributeValueByName("src")));

            if (string.IsNullOrWhiteSpace(image.Location)) 
                return null;

            long? imageWidth = long.TryParse(StripCData(rawImageNode.GetNodeByName("width")?.InnerXml), out var width) ? width : null;
            long? imageHeight = long.TryParse(StripCData(rawImageNode.GetNodeByName("height")?.InnerXml), out var height) ? height : null;

            imageWidth ??= long.TryParse(StripCData(rawImageNode.GetAttributeValueByName("width")), out width) ? width : null;
            imageHeight ??= long.TryParse(StripCData(rawImageNode.GetAttributeValueByName("height")), out height) ? height : null;

            if (imageWidth.HasValue || imageHeight.HasValue)
                image.Size = new FileSizeInfoDto(null, imageWidth, imageHeight);

            return image;
        }

        private static List<RssFeedAuthor> ParseAuthors(List<XmlElement>? authorNodes, List<XmlElement>? rawDcCreatorNodes = null)
        {
            if (authorNodes == null)
                return [];

            var authors = new List<RssFeedAuthor>();

            foreach (var authorNode in authorNodes)
            {
                var authorName = Normalize(StripCData(authorNode.GetNodeByName("name")?.InnerXml));
                var authorUri = Normalize(StripCData(authorNode.GetNodeByName("uri")?.InnerXml));

                if (!string.IsNullOrWhiteSpace(authorName))
                    authors.Add(new RssFeedAuthor(authorName, authorUri == null ? null : new Uri(authorUri)));
            }

            if (rawDcCreatorNodes == null)
                return authors;

            foreach (var creatorNode in rawDcCreatorNodes)
            {
                var creatorName = Normalize(StripCData(creatorNode.InnerText));

                if (!string.IsNullOrWhiteSpace(creatorName))
                    authors.Add(new RssFeedAuthor(creatorName));
            }

            return authors;
        }

        private static List<string> ParseCategories(List<XmlElement>? categoryNodes)
        {
            if (categoryNodes == null) 
                return [];

            var categories = new List<string>();

            foreach(var categoryNode in categoryNodes)
            {
                var category = Normalize(StripCData(categoryNode.InnerText));

                if (!string.IsNullOrWhiteSpace(category))
                    categories.Add(category);
            }

            return categories;
        }

        private static List<RssFeedLink> ParseLinks(List<XmlElement>? linkNodes)
        {
            if (linkNodes == null)
                return [];

            var links = new List<RssFeedLink>();

            foreach (var linkNode in linkNodes)
            {
                var href = Normalize(StripCData(linkNode.GetAttributeValueByName("href")));

                if(string.IsNullOrWhiteSpace(href))
                    href = Normalize(StripCData(linkNode.InnerXml));

                var rel = Normalize(StripCData(linkNode.GetAttributeValueByName("rel")));

                if (!string.IsNullOrWhiteSpace(href) && Uri.TryCreate(href, new UriCreationOptions(), out var url) && links.TrueForAll(l => l.Href != url))
                    links.Add(new RssFeedLink(url, rel: rel));
            }

            return links;
        }

        private static string? TruncateText(string? text, int maximumLength = 500, bool truncateAtLastNewLine = true)
        {
            if (string.IsNullOrWhiteSpace(text))
                return null;

            if (text.Length <= maximumLength)
                return text;

            if (text.Length > maximumLength)
                text = text[..maximumLength] + "...";

            if(!truncateAtLastNewLine)
                return text;

            var indexOfLastNewLine = text.LastIndexOf("\n", StringComparison.Ordinal);

            if (indexOfLastNewLine > 0)
                text = text[..indexOfLastNewLine];

            return text;
        }

        private static DateTimeOffset? AsDateTimeOffset(string? dateTimeString)
        {
            return DateTimeOffset.TryParse(dateTimeString, DateTimeFormatInfo.InvariantInfo, out var result) ? result.ToUniversalTime() : null;
        }

        private static string? StripCData(string? content)
        {
            if (string.IsNullOrWhiteSpace(content))
                return null;

            const string cdataPattern = @"\<\!\[CDATA\[(?<text>[^\]]*)\]\]\>";

            var regex = new Regex(cdataPattern, RegexOptions.None);

            return regex.IsMatch(content) ? regex.Match(content).Groups["text"].Value : content;
        }

        private static string? Normalize(string? content)
        {
            if (string.IsNullOrWhiteSpace(content))
                return null;

            return content.Trim();
        }
    }
}
