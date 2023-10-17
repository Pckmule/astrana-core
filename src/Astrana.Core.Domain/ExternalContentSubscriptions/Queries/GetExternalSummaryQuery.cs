/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.ExternalContentSubscriptions;
using Astrana.Core.Domain.Models.Results;
using HtmlAgilityPack;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.Domain.ExternalContentSubscriptions.Queries
{
    public class GetExternalSummaryQuery : IGetExternalSummaryQuery
    {
        private readonly ILogger<GetExternalSummaryQuery> _logger;


        public GetExternalSummaryQuery(ILogger<GetExternalSummaryQuery> logger)
        {
            _logger = logger;
        }

        public async Task<ExecutionResult<ExternalContentSubscriptionSummary>> ExecuteAsync(Uri url, Guid actioningUserId)
        {
            var externalContentSubscriptionSummary = new ExternalContentSubscriptionSummary(url);

            try
            {
                var content = await GetHtmlPageContentAsync(url);

                if(string.IsNullOrWhiteSpace(content))
                    return new ExecutionSuccessResult<ExternalContentSubscriptionSummary>(externalContentSubscriptionSummary, "Failed to retrieve external content subscription summary.");

                var htmlDoc = new HtmlDocument();
                htmlDoc.LoadHtml(content);

                var htmlRoot = htmlDoc.DocumentNode.SelectSingleNode("//html");
                var htmlHead = htmlDoc.DocumentNode.SelectSingleNode("//head");

                var pageLang = htmlRoot?.GetAttributeValue("lang", "").Trim();
                var charSet = GetAttributeValue(htmlHead, "//meta[@charset]", "content");
                var title = htmlHead.SelectSingleNode("//title")?.InnerText.Trim();

                var metadataOpenGraphType = GetAttributeValue(htmlHead, "//meta[@property='og:type']", "content");
                var metadataOpenGraphUrl = GetAttributeValue(htmlHead, "//meta[@property='og:url']", "content");
                var metadataOpenGraphTitle = GetAttributeValue(htmlHead, "//meta[@property='og:title']", "content");
                var metadataOpenGraphLocale = GetAttributeValue(htmlHead, "//meta[@property='og:locale']", "content");
                var metadataOpenGraphDescription = GetAttributeValue(htmlHead, "//meta[@property='og:description']", "content");
                var metadataOpenGraphImage = GetAttributeValue(htmlHead, "//meta[@property='og:image']", "content");

                var metadataHttpEquivContentLanguage = GetAttributeValue(htmlHead, "//meta[@http-equiv='content-language']", "content");

                var metadataDescription = GetAttributeValue(htmlHead, "//meta[@name='description']", "content");
                var metadataKeywords = GetAttributeValue(htmlHead, "//meta[@name='keywords']", "content");
                var metadataRobots = GetAttributeValue(htmlHead, "//meta[@name='robots']", "content");

                externalContentSubscriptionSummary.Locale = DefaultIfEmpty(metadataOpenGraphLocale, pageLang, metadataHttpEquivContentLanguage);
                externalContentSubscriptionSummary.Title = DefaultIfEmpty(metadataOpenGraphTitle, title);
                externalContentSubscriptionSummary.CharSet = charSet;

                externalContentSubscriptionSummary.Description = DefaultIfEmpty(metadataOpenGraphDescription, metadataDescription);

                if (externalContentSubscriptionSummary.Description == externalContentSubscriptionSummary.Title)
                    externalContentSubscriptionSummary.Description = string.Empty;

                externalContentSubscriptionSummary.Keywords = metadataKeywords;
                externalContentSubscriptionSummary.Robots = metadataRobots;

                if (!string.IsNullOrWhiteSpace(metadataOpenGraphImage))
                    externalContentSubscriptionSummary.PreviewImageUrls?.Add(metadataOpenGraphImage);

                return new ExecutionSuccessResult<ExternalContentSubscriptionSummary>(externalContentSubscriptionSummary, "Successfully retrieved external content subscription summary.");

            }
            catch (Exception)
            {
                return new ExecutionSuccessResult<ExternalContentSubscriptionSummary>(externalContentSubscriptionSummary, "Failed to retrieve external content subscription summary.");
            }
        }

        private static string? DefaultIfEmpty(string? value, string? fallbackValue1, string? fallbackValue2 = "")
        {
            return string.IsNullOrWhiteSpace(value) ? string.IsNullOrWhiteSpace(fallbackValue1) ? fallbackValue2 : fallbackValue1 : value;
        }

        private static string? GetAttributeValue(HtmlNode htmlNode, string xPathStatement, string attributeName, string defaultValue = "", bool trim = true)
        {
            var value = htmlNode.SelectSingleNode(xPathStatement)?.GetAttributeValue(attributeName, defaultValue);

            return trim ? value?.Trim() : value;
        }


        private static async Task<string> GetHtmlPageContentAsync(Uri url)
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
            }

            return string.Empty;
        }
    }
}
