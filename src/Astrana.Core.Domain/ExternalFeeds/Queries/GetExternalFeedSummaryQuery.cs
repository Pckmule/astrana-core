/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Feeds.Builders.Generic;
using Astrana.Core.Domain.Feeds.Models;
using Astrana.Core.Domain.Models.Results;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.Domain.ExternalFeeds.Queries
{
    public class GetExternalFeedSummaryQuery : IGetExternalFeedSummaryQuery
    {
        private readonly ILogger<GetExternalFeedSummaryQuery> _logger;

        private readonly IStandardFeedBuilder _standardFeedBuilder;
        private readonly IFetchExternalFeedContentQuery _fetchExternalFeedContentQuery;

        public GetExternalFeedSummaryQuery(
            ILogger<GetExternalFeedSummaryQuery> logger, 
            IStandardFeedBuilder standardFeedBuilder,
            IFetchExternalFeedContentQuery fetchExternalFeedContentQuery
        )
        {
            _logger = logger;
            _standardFeedBuilder = standardFeedBuilder;
            _fetchExternalFeedContentQuery = fetchExternalFeedContentQuery;
        }

        public async Task<ExecutionResult<StandardFeedSummary>> ExecuteAsync(Uri url, Guid actioningUserId)
        {
            try
            {
                var feedContent = (await _fetchExternalFeedContentQuery.ExecuteAsync(url, actioningUserId)).Data;

                if(feedContent == null)
                    return new ExecutionFailResult<StandardFeedSummary>(null, "Failed to retrieve external feed summary.");

                var externalFeedSummary = _standardFeedBuilder.BuildFeedSummary(url, feedContent.Content, feedContent.Format);

                return new ExecutionSuccessResult<StandardFeedSummary>(externalFeedSummary, "Successfully retrieved external content feed summary.");
            }
            catch (Exception)
            {
                return new ExecutionFailResult<StandardFeedSummary>(null, "Failed to retrieve external feed summary.");
            }
        }
    }
}
