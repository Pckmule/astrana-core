/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Links;
using Astrana.Core.Domain.Models.Results;
using HtmlAgilityPack;
using Microsoft.Extensions.Logging;
using System.Web;

namespace Astrana.Core.Domain.Links.Queries
{
    public class GetLinkSummaryQuery : IGetLinkSummaryQuery
    {
        private readonly ILogger<GetLinkSummaryQuery> _logger;
        
        public GetLinkSummaryQuery(ILogger<GetLinkSummaryQuery> logger)
        {
            _logger = logger;
        }

        public async Task<ExecutionResult<LinkSummary>> ExecuteAsync(Uri url, Guid actioningUserId)
        {
            var linkSummary = new LinkSummary(url);

            try
            {
                var content = await GetHtmlPageContentAsync(url);

                if(string.IsNullOrWhiteSpace(content))
                    return new ExecutionSuccessResult<LinkSummary>(linkSummary, "Failed to retrieve link summary.");

                var htmlDoc = new HtmlDocument();
                htmlDoc.LoadHtml(content);

                var htmlRoot = htmlDoc.DocumentNode.SelectSingleNode("//html");
                var htmlHead = htmlDoc.DocumentNode.SelectSingleNode("//head");

                var pageLang = htmlRoot?.GetAttributeValue("lang", "").Trim();
                var charSet = GetAttributeValue(htmlHead, "//meta[@charset]", "content");
                var title = HttpUtility.HtmlDecode(htmlHead.SelectSingleNode("//title")?.InnerText.Trim());

                var metadataOpenGraphType = GetAttributeValue(htmlHead, "//meta[@property='og:type']", "content");
                var metadataOpenGraphUrl = GetAttributeValue(htmlHead, "//meta[@property='og:url']", "content");
                var metadataOpenGraphTitle = HttpUtility.HtmlDecode(GetAttributeValue(htmlHead, "//meta[@property='og:title']", "content"));
                var metadataOpenGraphLocale = GetAttributeValue(htmlHead, "//meta[@property='og:locale']", "content");
                var metadataOpenGraphDescription = HttpUtility.HtmlDecode(GetAttributeValue(htmlHead, "//meta[@property='og:description']", "content"));
                var metadataOpenGraphImage = GetAttributeValue(htmlHead, "//meta[@property='og:image']", "content");

                var metadataHttpEquivContentLanguage = GetAttributeValue(htmlHead, "//meta[@http-equiv='content-language']", "content");

                var metadataDescription = HttpUtility.HtmlDecode(GetAttributeValue(htmlHead, "//meta[@name='description']", "content"));
                var metadataKeywords = HttpUtility.HtmlDecode(GetAttributeValue(htmlHead, "//meta[@name='keywords']", "content"));
                var metadataRobots = GetAttributeValue(htmlHead, "//meta[@name='robots']", "content");

                linkSummary.Locale = DefaultIfEmpty(metadataOpenGraphLocale, pageLang, metadataHttpEquivContentLanguage);
                linkSummary.Title = DefaultIfEmpty(metadataOpenGraphTitle, title);
                linkSummary.CharSet = charSet;

                linkSummary.Description = DefaultIfEmpty(metadataOpenGraphDescription, metadataDescription);

                if (linkSummary.Description == linkSummary.Title)
                    linkSummary.Description = string.Empty;

                linkSummary.Keywords = metadataKeywords;
                linkSummary.Robots = metadataRobots;

                if (!string.IsNullOrWhiteSpace(metadataOpenGraphImage))
                {
                    if(metadataOpenGraphImage.StartsWith("/"))
                        linkSummary.PreviewImageUrls?.Add(url.Scheme + Uri.SchemeDelimiter + url.Host + metadataOpenGraphImage);
                    else
                        linkSummary.PreviewImageUrls?.Add(metadataOpenGraphImage);
                }

                return new ExecutionSuccessResult<LinkSummary>(linkSummary, "Successfully retrieved link summary.");

            }
            catch (Exception)
            {
                return new ExecutionSuccessResult<LinkSummary>(linkSummary, "Failed to retrieve link summary.");
            }
        }

        private static string DefaultIfEmpty(string? value, string? fallbackValue1, string? fallbackValue2 = "")
        {
            return string.IsNullOrWhiteSpace(value) ? string.IsNullOrWhiteSpace(fallbackValue1) ? fallbackValue2 : fallbackValue1 : value;
        }

        private static string? GetAttributeValue(HtmlNode htmlNode, string xPathStatement, string attributeName, string defaultValue = "", bool trim = true)
        {
            var value = htmlNode.SelectSingleNode(xPathStatement)?.GetAttributeValue(attributeName, defaultValue);

            return trim ? value?.Trim() : value;
        }

        private async Task<string> GetHtmlPageContentAsync(Uri url)
        {
            try
            {
                var client = new HttpClient();

                client.DefaultRequestHeaders.UserAgent.ParseAdd(Constants.Application.UserAgentString);

                using var response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                // ignored
                _logger.LogError(ex, ex.Message);
            }

            return string.Empty;
        }
    }
}
