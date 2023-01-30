/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Constants;
using Astrana.Core.Domain.IdentityAccessManagement.Managers.SignIn;
using Astrana.Core.Domain.MainFeed.Commands.ComposeFeed;
using Astrana.Core.Domain.MainFeed.Queries;
using Astrana.Core.Domain.Models.MainFeed.Options;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FeedController : BaseController<FeedController>
    {
        private readonly ILogger<FeedController> _logger;
        private readonly IConfiguration _configuration;

        private readonly IGetMainFeedQuery _getMainFeedQuery;
        private readonly IComposeFeedCommand _composeFeedCommand;

        public FeedController(IConfiguration configuration, ILogger<FeedController> logger, ISignInManager signInManager, IGetMainFeedQuery getMainFeedQuery, IComposeFeedCommand composeFeedCommand) : base(logger, signInManager)
        {
            _configuration = configuration;
            _logger = logger;

            _getMainFeedQuery = getMainFeedQuery;
            _composeFeedCommand = composeFeedCommand;
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
        [HttpGet]
        public async Task<IActionResult> GetFeedAsync(DateTime? createdAfter = null, DateTime? createdBefore = null, Guid? createdById = null, int page = Pagination.DefaultPage, int pageSize = Pagination.DefaultPageSize)
        {
            var actioningUserId = GetActioningUserId();

            var feedResults = await _composeFeedCommand.ExecuteAsync(new MainFeedQueryOptions<Guid, Guid>
            {
                CreatedAfter = createdAfter,
                CreatedBefore = createdBefore,
                OwnerUserIds = createdById.HasValue ? new List<Guid> { createdById.Value } : new List<Guid>(),
                CurrentPage = page,
                PageSize = pageSize

            }, actioningUserId);

            var queryOptions = new MainFeedQueryOptions<long, Guid>();

            //var result = await _getMainFeedQuery.ExecuteAsync(actioningUserId, queryOptions);

            return PagedGetResponse(feedResults, page, pageSize, feedResults.Message);
        }
    }
}