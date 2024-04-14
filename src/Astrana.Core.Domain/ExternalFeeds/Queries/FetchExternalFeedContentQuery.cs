/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Feeds.Enums;
using Astrana.Core.Domain.Feeds.Models;
using Astrana.Core.Domain.Models.Results;
using Microsoft.Extensions.Logging;
using System.Xml;

namespace Astrana.Core.Domain.ExternalFeeds.Queries
{
    public class FetchExternalFeedContentQuery : IFetchExternalFeedContentQuery
    {
        private readonly ILogger<GetExternalFeedSummaryQuery> _logger;
        
        public FetchExternalFeedContentQuery(ILogger<GetExternalFeedSummaryQuery> logger)
        {
            _logger = logger;
        }

        public async Task<ExecutionResult<FeedContent?>> ExecuteAsync(Uri url, Guid actioningUserId)
        {
            try
            {
                var content = await GetContentAsync(url);
                var format = DetectFeedFormat(content);

                _logger.LogDebug($"Detected feed format as {format}");

                return new ExecutionSuccessResult<FeedContent?>(new FeedContent(format, content), "Successfully retrieved external feed content.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                return new ExecutionFailResult<FeedContent>(null, "Failed to retrieve external feed content.");
            }
        }

        private static FeedFormat DetectFeedFormat(string content)
        {
            const string atomXmlNamespace = "http://www.w3.org/2005/Atom";

            if (content.StartsWith("<rss"))
                return FeedFormat.Rss;

            if (content.StartsWith("<feed"))
                return FeedFormat.Atom;

            if (!content.StartsWith("<?xml")) 
                return FeedFormat.Default;

            var xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(content);

            var root = xmlDocument.DocumentElement;

            if (root == null)
                return FeedFormat.Default;

            var documentNodeName = root.LocalName.ToLower();

            if (documentNodeName == "rss")
                return FeedFormat.Rss;

            if (documentNodeName == "feed")
            {
                if (root.HasAttribute("xmlns") && root.GetAttribute("xmlns") == atomXmlNamespace)
                    return FeedFormat.Atom;
            }

            return FeedFormat.Default;
        }

        private async Task<string> GetContentAsync(Uri url)
        {
            string? feedContent = null;

            try
            {
                var client = new HttpClient();

                client.DefaultRequestHeaders.UserAgent.ParseAdd(Constants.Application.UserAgentString);

                _logger.LogDebug($"Fetching external feed content from {url}.");

                using var response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                feedContent = await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                // ignored
                _logger.LogWarning($"Failed to fetch external feed content from {url}. {ex.Message}");
            }

            if (string.IsNullOrWhiteSpace(feedContent))
                throw new Exception("Content may not be empty.");

            return feedContent;
        }
    }
}
