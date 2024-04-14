/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Feeds.Models;
using Astrana.Core.Domain.Feeds.Models.Atom;
using Astrana.Core.Domain.Markdown;
using Astrana.Core.Domain.Models.Files.DomainTransferObjects;
using Astrana.Core.Domain.Models.Images.DomainTransferObjects;
using Astrana.Core.Extensions;
using Astrana.Core.Utilities;
using Microsoft.Extensions.Logging;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Xml;

namespace Astrana.Core.Domain.Feeds.Builders.Atom
{
    public class AtomFeedBuilder : IAtomFeedBuilder
    {
        private readonly ILogger<AtomFeedBuilder> _logger;
        private readonly IMarkdownService _markdownService;

        private readonly List<string> _htmlTextGroupingElementTags = ["p", "span", "br"];
        private readonly List<string> _htmlTextFormattingElementTags = ["strong", "b", "i", "em", "u"];
        private readonly List<string> _htmlLinkElementTags = ["a"];

        private readonly List<string> _htmlTextElementTags = [];

        public AtomFeedBuilder(ILogger<AtomFeedBuilder> logger, IMarkdownService markdownService)
        {
            _logger = logger;
            _markdownService = markdownService;

            _htmlTextElementTags.AddRange(_htmlTextGroupingElementTags);
            _htmlTextElementTags.AddRange(_htmlTextFormattingElementTags);
            _htmlTextElementTags.AddRange(_htmlLinkElementTags);
        }

        public AtomFeedSummary BuildFeedSummary(Uri url, XmlDocument xmlDocument)
        {
            _logger.LogDebug("Building ATOM feed summary.");

            ArgumentNullException.ThrowIfNull(xmlDocument);

            if (xmlDocument.DocumentElement == null)
                throw new ArgumentException("No feed data found.");

            var htmlRoot = xmlDocument.DocumentElement;

            var rawFormatVersion = StripCData(htmlRoot?.GetNodeByName("version")?.InnerXml);

            var rawId = StripCData(htmlRoot?.GetNodeByName("id")?.InnerXml);

            var rawPageLang = StripCData(htmlRoot?.GetAttributeValueByName("lang", ""));
            var rawLanguage = StripCData(htmlRoot?.GetNodeByName("language")?.InnerXml);

            var rawTitle = StripCData(htmlRoot?.GetNodeByName("title")?.InnerXml);
            var rawSubTitle = StripCData(htmlRoot?.GetNodeByName("subtitle")?.InnerXml);
            var rawDescription = StripCData(htmlRoot?.GetNodeByName("description")?.InnerXml);

            var rawIconNode = htmlRoot?.GetNodeByName("icon");
            var rawLogoNode = htmlRoot?.GetNodeByName("logo");

            var rawCopyright = StripCData(htmlRoot?.GetNodeByName("copyright")?.InnerXml);
            var rawRights = StripCData(htmlRoot?.GetNodeByName("rights")?.InnerXml);

            var rawTimeToLive = StripCData(htmlRoot?.GetNodeByName("ttl")?.InnerXml);
            var rawGenerator = StripCData(htmlRoot?.GetNodeByName("generator")?.InnerXml);

            var rawCategories = htmlRoot?.GetNodesByName("category");
            var rawAuthors = htmlRoot?.GetNodesByName("author");
            var rawContributors = htmlRoot?.GetNodesByName("contributor");
            var rawLinks = htmlRoot?.GetNodesByName("links");

            var rawUpdated = StripCData(htmlRoot?.GetNodeByName("updated")?.InnerXml);


            var id = Normalize(rawId);

            var title = GetTitle(rawTitle, true);

            var subTitle = GetFeedSummarySubTitle(rawSubTitle, rawTitle);

            var summary = GetFeedSummaryDescription(rawDescription, rawTitle);

            var rights = SelectRightsText(rawRights, rawCopyright);

            var iconImage = GetImageDtoFromNode(rawIconNode);
            var logoImage = GetImageDtoFromNode(rawLogoNode);

            var locale = GetFeedSummaryLocale(rawLanguage, rawPageLang);
            var language = GetFeedSummaryLanguage(rawLanguage, rawPageLang);

            var categories = ParseCategories(rawCategories);

            var authors = ParseAuthors(rawAuthors);
            var contributors = ParseContributors(rawContributors);

            var links = ParseLinks(rawLinks);

            var websiteLink = GetWebsiteLink(links);

            var timeToLive = int.TryParse(rawTimeToLive, out var rawTimeToLiveParsed) ? rawTimeToLiveParsed : (int?)null;
            var generator = Normalize(rawGenerator);

            var lastUpdated = AsDateTimeOffset(rawUpdated);

            var feedSummary = new AtomFeedSummary
            {
                Url = url,
                FormatVersion = Normalize(rawFormatVersion),

                Id = id,

                Locale = locale,
                Language = language,

                Title = title,
                SubTitle = subTitle,
                Summary = summary,

                Rights = rights,

                IconImage = iconImage,
                LogoImage = logoImage,

                Authors = authors,
                Contributors = contributors,

                Categories = categories,
                Links = links,

                WebsiteUrl = websiteLink?.Href,

                TimeToLive = timeToLive,
                Generator = generator,

                Updated = lastUpdated
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

        private string? GetFeedSummarySubTitle(string? rawSubtitle, string? rawTitle, bool allowHtml = false)
        {
            var subtitle = rawSubtitle;

            if (string.IsNullOrWhiteSpace(subtitle) && !string.IsNullOrWhiteSpace(rawTitle))
                subtitle = rawTitle;

            if (string.IsNullOrWhiteSpace(subtitle))
                return null;

            if (allowHtml)
                subtitle = _markdownService.ToMarkdown(subtitle, _htmlTextFormattingElementTags);

            return Normalize(subtitle);
        }

        private string? GetFeedSummaryDescription(string? rawDescription, string? rawTitle = null)
        {
            if (rawDescription == rawTitle)
                return null;

            var description = TruncateText(_markdownService.ToMarkdown(rawDescription, _htmlTextElementTags));

            return Normalize(description);
        }

        private string? SelectRightsText(string? rawRights, string? rawCopyright = null)
        {
            var rights = rawRights;

            if (!string.IsNullOrWhiteSpace(rights))
                return rights;

            if (string.IsNullOrWhiteSpace(rawCopyright))
                rights = rawCopyright;

            rights = _markdownService.ToMarkdown(rights, _htmlTextElementTags);

            return Normalize(rights);
        }

        private static string? GetFeedSummaryLanguage(string? rawLanguage, string? rawPageLang)
        {
            return Normalize(rawLanguage.DefaultIfEmpty(rawPageLang));
        }

        private static string? GetFeedSummaryLocale(string? rawLanguage, string? rawPageLang)
        {
            return Normalize(rawLanguage.DefaultIfEmpty(rawPageLang));
        }

        public List<AtomFeedItem> BuildFeedItems(Uri feedUrl, string feedContent, FeedSource? source = null)
        {
            if (feedUrl == null)
                throw new ArgumentNullException(nameof(feedUrl));

            if (string.IsNullOrWhiteSpace(feedContent))
                throw new ArgumentNullException(nameof(feedContent));

            var xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(feedContent);
            
            var feedItems = xmlDocument.DocumentElement?.GetNodesByName("entry").Select(feedItem =>
            {
                var item = BuildAtomFeedItem(feedItem, source);

                return item.IsValid ? item : null;

            }).Where(item => item != null).ToList();

            return (feedItems ?? [])!;
        }

        public AtomFeedItem BuildAtomFeedItem(XmlElement itemNode, FeedSource? source = null)
        {
            _logger.LogDebug("Building ATOM Feed Item.");

            if (itemNode == null)
                throw new ArgumentNullException(nameof(itemNode));

            var rawId = StripCData(itemNode.GetNodeByName("id")?.InnerXml);

            var rawTitle = StripCData(itemNode.GetNodeByName("title")?.InnerXml);
            
            var rawContent = StripCData(itemNode.GetNodeByName("content")?.InnerXml);
            var rawContentEncoded = StripCData(itemNode.GetNodeByName("content:encoded")?.InnerXml);
            
            var rawDescription = StripCData(itemNode.GetNodeByName("description")?.InnerXml);

            var rawRating = StripCData(itemNode.GetNodeByName("rating")?.InnerXml); // https://www.w3.org/PICS

            var rawCopyright = StripCData(itemNode.GetNodeByName("copyright")?.InnerXml);
            var rawRights = StripCData(itemNode.GetNodeByName("rights")?.InnerXml);

            var rawImageNode = itemNode.GetNodeByName("image");
            var rawThumbnailNode = itemNode.GetNodeByName("thumbnail");

            var rawContributorNodes = itemNode.GetNodesByName("contributor");
            var rawCategoryNodes = itemNode.GetNodesByName("category");
            var rawLinkNodes = itemNode.GetNodesByName("link");

            var rawDcCreatorNodes = itemNode.GetNodesByName("dc:creator");

            var rawMediaThumbnailNode = itemNode.GetNodeByName("media:thumbnail");

            var rawMediaGroupNode = itemNode.GetNodeByName("media:group");
            var mediaGroupThumbnailNode = rawMediaGroupNode?.GetNodeByName("media:thumbnail");
            var rawMediaGroupDescription = StripCData(rawMediaGroupNode?.GetNodeByName("media:description")?.InnerXml);
            var rawMediaGroupRating = StripCData(rawMediaGroupNode?.GetNodeByName("media:rating")?.InnerXml);

            var rawPublished = StripCData(itemNode.GetNodeByName("pubdate")?.InnerXml);
            var rawLastUpdated = StripCData(itemNode.GetNodeByName("updated")?.InnerXml);

            var id = Normalize(rawId);

            var title = GetTitle(rawTitle, true);

            var content = GetItemContent(rawContent, rawContentEncoded, rawMediaGroupDescription);

            var summary = GetItemSummary(rawDescription, rawContent, rawContentEncoded, rawMediaGroupDescription);

            var rating = GetItemRating(rawRating, rawMediaGroupRating);

            var rights = SelectRightsText(rawRights, rawCopyright);

            var thumbnail = SelectThumbnailImage(rawThumbnailNode, rawMediaThumbnailNode, mediaGroupThumbnailNode);
            var image = SelectImage(rawImageNode, rawThumbnailNode, rawDescription, rawContent, rawContentEncoded, rawMediaGroupDescription);

            var published = AsDateTimeOffset(rawPublished);
            var lastUpdated = AsDateTimeOffset(rawLastUpdated);

            var authors = ParseAuthors(rawContributorNodes, rawDcCreatorNodes);
            var contributors = ParseContributors(rawContributorNodes);

            var categories = ParseCategories(rawCategoryNodes);
            var links = ParseLinks(rawLinkNodes);

            var websiteLink = GetWebsiteLink(links);
            var sourceUrl = websiteLink?.Href;

            var feedItem = new AtomFeedItem
            {
                Id = id,

                Title = title,
                Summary = summary,
                Content = content,

                Rights = rights,

                ContentRating = rating,

                Image = image,
                Thumbnail = thumbnail,

                Authors = authors,
                Contributors = contributors,

                Categories = categories,
                Links = links,

                Published = published,
                LastUpdated = lastUpdated,

                Source = new FeedSource(sourceUrl, source?.Name, source?.IconUrl)
            };

            return feedItem;
        }

        private static AtomFeedLink? GetWebsiteLink(List<AtomFeedLink>? links)
        {
            if (links == null)
                throw new ArgumentNullException(nameof(links));

            return links.Find(l => string.IsNullOrWhiteSpace(l.Rel)) ?? links.Find(l => l.Rel == "alternate");
        }

        private string? GetItemContent(string? rawContent, string? rawContentEncoded, string? rawMediaGroupDescription)
        {
            var content = rawContent;

            if (string.IsNullOrWhiteSpace(content) && !string.IsNullOrWhiteSpace(rawContentEncoded))
                content = rawContentEncoded;

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
            if (rawImageNode == null)
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

        private static List<AtomFeedAuthor> ParseAuthors(List<XmlElement>? authorNodes, List<XmlElement>? rawDcCreatorNodes = null)
        {
            if (authorNodes == null)
                return [];

            var authors = new List<AtomFeedAuthor>();

            foreach (var authorNode in authorNodes)
            {
                var authorName = Normalize(StripCData(authorNode.GetNodeByName("name")?.InnerXml));
                var authorUri = Normalize(StripCData(authorNode.GetNodeByName("uri")?.InnerXml));

                if (!string.IsNullOrWhiteSpace(authorName))
                    authors.Add(new AtomFeedAuthor(authorName, authorUri == null ? null : new Uri(authorUri)));
            }

            if (rawDcCreatorNodes == null)
                return authors;

            foreach (var creatorNode in rawDcCreatorNodes)
            {
                var creatorName = Normalize(StripCData(creatorNode.InnerText));

                if (!string.IsNullOrWhiteSpace(creatorName))
                    authors.Add(new AtomFeedAuthor(creatorName));
            }

            return authors;
        }

        private static List<AtomFeedContributor> ParseContributors(List<XmlElement>? contributorsNodes)
        {
            if (contributorsNodes == null)
                return [];

            var contributors = new List<AtomFeedContributor>();

            foreach (var authorNode in contributorsNodes)
            {
                var contributorName = Normalize(StripCData(authorNode.GetNodeByName("name")?.InnerXml));
                var contributorUri = Normalize(StripCData(authorNode.GetNodeByName("uri")?.InnerXml));

                if (!string.IsNullOrWhiteSpace(contributorName))
                    contributors.Add(new AtomFeedContributor(contributorName, contributorUri == null ? null : new Uri(contributorUri)));
            }

            return contributors;
        }

        private static List<string> ParseCategories(List<XmlElement>? categoryNodes)
        {
            if (categoryNodes == null)
                return [];

            var categories = new List<string>();

            foreach (var categoryNode in categoryNodes)
            {
                var category = Normalize(StripCData(categoryNode.InnerText));

                if (!string.IsNullOrWhiteSpace(category))
                    categories.Add(category);
            }

            return categories;
        }

        private static List<AtomFeedLink> ParseLinks(List<XmlElement>? linkNodes)
        {
            if (linkNodes == null)
                return [];

            var links = new List<AtomFeedLink>();

            foreach (var linkNode in linkNodes)
            {
                var href = Normalize(StripCData(linkNode.GetAttributeValueByName("href")));

                if (string.IsNullOrWhiteSpace(href))
                    href = Normalize(StripCData(linkNode.InnerXml));

                var rel = Normalize(StripCData(linkNode.GetAttributeValueByName("rel")));

                if (!string.IsNullOrWhiteSpace(href) && Uri.TryCreate(href, new UriCreationOptions(), out var url) && links.TrueForAll(l => l.Href != url))
                    links.Add(new AtomFeedLink(url, rel: rel));
            }

            return links;
        }

        private static string? TruncateText(string? text, int maximumLength = 500, bool truncateAtLastNewLine = true)
        {
            text = text.Trim();

            if (string.IsNullOrWhiteSpace(text))
                return null;

            if (text.Length <= maximumLength)
                return text;

            if (text.Length > maximumLength)
                text = text[..maximumLength] + "...";

            if (!truncateAtLastNewLine)
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
