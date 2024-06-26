/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Constants;
using Astrana.Core.Domain.ExternalContentSubscriptions.Commands.ComposeFeed;
using Astrana.Core.Domain.IdentityAccessManagement.Managers.SignIn;
using Astrana.Core.Domain.MainFeed.Commands.ComposeFeed;
using Astrana.Core.Domain.MainFeed.Queries;
using Astrana.Core.Domain.Models.MainFeed.Options;
using Astrana.Core.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.API.Controllers
{
    [ApiController]
    public class FeedController : BaseController<FeedController>
    {
        private readonly ILogger<FeedController> _logger;

        private readonly IGetMainFeedQuery _getMainFeedQuery;

        private readonly IComposeFeedCommand _composeFeedCommand;
        private readonly IComposeExternalContentSubscriptionFeedCommand _composeExternalContentSubscriptionFeedCommand;

        public FeedController(
            ILogger<FeedController> logger, 
            ISignInManager signInManager, 
            IGetMainFeedQuery getMainFeedQuery, 
            IComposeFeedCommand composeFeedCommand,
            IComposeExternalContentSubscriptionFeedCommand composeExternalContentSubscriptionFeedCommand
        ) : base(logger, signInManager)
        {
            _logger = logger;

            _getMainFeedQuery = getMainFeedQuery;
            _composeFeedCommand = composeFeedCommand;
            _composeExternalContentSubscriptionFeedCommand = composeExternalContentSubscriptionFeedCommand;
        }

        /// <summary>
        /// Returns a paged set of feed content according to the options provided.
        /// </summary>
        /// <param name="createdAfter"></param>
        /// <param name="createdBefore"></param>
        /// <param name="createdById"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        /// <response code="200">Item(s) successfully retrieved.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpGet("community")]
        public async Task<IActionResult> GetCommunityFeedAsync(DateTime? createdAfter = null, DateTime? createdBefore = null, Guid? createdById = null, int page = Pagination.DefaultPage, int pageSize = Pagination.DefaultPageSize)
        {
            var actioningUserId = GetActioningUserId();

            var queryOptions = new MainFeedQueryOptions<Guid, Guid>
            {
                CreatedAfter = createdAfter,
                CreatedBefore = createdBefore,
                CurrentPage = page,
                PageSize = pageSize
            };

            queryOptions.SetOwnerUserIds(createdById.AsList());

            var feedResults = await _composeFeedCommand.ExecuteAsync(queryOptions, actioningUserId);

            // var result = await _getMainFeedQuery.ExecuteAsync(actioningUserId, queryOptions);

            return PagedGetResponse(feedResults, page, pageSize, feedResults.Message);
        }

        /// <summary>
        /// Returns a paged set of news feed content according to the options provided.
        /// </summary>
        /// <param name="createdAfter"></param>
        /// <param name="createdBefore"></param>
        /// <param name="createdById"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        /// <response code="200">Item(s) successfully retrieved.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpGet("external/subscriptions")]
        public async Task<IActionResult> GetExternalContentSubscriptionsFeedAsync(DateTime? createdAfter = null, DateTime? createdBefore = null, Guid? createdById = null, int page = Pagination.DefaultPage, int pageSize = Pagination.DefaultPageSize)
        {
            var actioningUserId = GetActioningUserId();

            var queryOptions = new MainFeedQueryOptions<Guid, Guid>
            {
                CreatedAfter = createdAfter,
                CreatedBefore = createdBefore,
                CurrentPage = page,
                PageSize = pageSize
            };

            queryOptions.SetOwnerUserIds(createdById.AsList());

            var feedResults = await _composeExternalContentSubscriptionFeedCommand.ExecuteAsync(queryOptions, actioningUserId);

            // var result = await _getMainFeedQuery.ExecuteAsync(actioningUserId, queryOptions);

            return PagedGetResponse(feedResults, page, pageSize, feedResults.Message);
        }

        /// <summary>
        /// Returns a paged set of external content subscription feed content according to the options provided.
        /// </summary>
        /// <param name="createdAfter"></param>
        /// <param name="createdBefore"></param>
        /// <param name="createdById"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        /// <response code="200">Item(s) successfully retrieved.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpGet("external/subscriptions/{id}")]
        public async Task<IActionResult> GetExternalContentSubscriptionFeedAsync(Guid id, DateTime? createdAfter = null, DateTime? createdBefore = null, Guid? createdById = null, int page = Pagination.DefaultPage, int pageSize = Pagination.DefaultPageSize)
        {
            var actioningUserId = GetActioningUserId();

            var queryOptions = new MainFeedQueryOptions<Guid, Guid>
            {
                CreatedAfter = createdAfter,
                CreatedBefore = createdBefore,
                CurrentPage = page,
                PageSize = pageSize
            };

            queryOptions.SetOwnerUserIds(createdById.AsList());

            var feedResults = await _composeExternalContentSubscriptionFeedCommand.ExecuteAsync(queryOptions, actioningUserId);

            // var result = await _getMainFeedQuery.ExecuteAsync(actioningUserId, queryOptions);

            return PagedGetResponse(feedResults, page, pageSize, feedResults.Message);
        }
    }
}