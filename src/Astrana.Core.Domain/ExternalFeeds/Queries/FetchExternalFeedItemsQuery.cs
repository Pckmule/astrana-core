/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Feeds.Builders.Generic;
using Astrana.Core.Domain.Feeds.Models;
using Astrana.Core.Domain.Models.Results;
using HtmlAgilityPack;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.Domain.ExternalFeeds.Queries
{
    public class FetchExternalFeedItemsQuery : IFetchExternalFeedItemsQuery
    {
        private readonly ILogger<FetchExternalFeedItemsQuery> _logger;

        private readonly IStandardFeedBuilder _standardFeedBuilder;

        private readonly IFetchExternalFeedContentQuery _fetchExternalFeedContentQuery;

        public FetchExternalFeedItemsQuery(
            ILogger<FetchExternalFeedItemsQuery> logger,
            IStandardFeedBuilder standardFeedBuilder,
            IFetchExternalFeedContentQuery fetchExternalFeedContentQuery)
        {
            _logger = logger;
            _standardFeedBuilder = standardFeedBuilder;

            _fetchExternalFeedContentQuery = fetchExternalFeedContentQuery;
        }

        public async Task<ExecutionResult<List<StandardFeedItem>>> ExecuteAsync(Uri url, Guid actioningUserId, FeedSource? source = null)
        {
            try
            {
                var feedContent = (await _fetchExternalFeedContentQuery.ExecuteAsync(url, actioningUserId)).Data;

                if (feedContent == null)
                    throw new Exception("No feed content.");

                var htmlDocument = new HtmlDocument();
                    htmlDocument.LoadHtml(feedContent.Content);

                var feedSummary = _standardFeedBuilder.BuildFeedSummary(url, feedContent.Content, feedContent.Format);

                source ??= new FeedSource(url, feedSummary.Title);

                if (string.IsNullOrWhiteSpace(source.Name))
                    source.Name = feedSummary.Title;

                var externalFeedItems = _standardFeedBuilder.BuildFeedItems(url, feedContent.Content, feedContent.Format, source);

                return new ExecutionSuccessResult<List<StandardFeedItem>>(externalFeedItems, "Successfully retrieved external content subscription summary.");
            }
            catch (Exception)
            {
                return new ExecutionFailResult<List<StandardFeedItem>>(null, "Failed to retrieve external feed summary.");
            }
        }
    }
}