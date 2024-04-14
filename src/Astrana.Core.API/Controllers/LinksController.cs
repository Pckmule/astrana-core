/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Constants;
using Astrana.Core.Domain.IdentityAccessManagement.Managers.SignIn;
using Astrana.Core.Domain.Links.Commands.CreateLinks;
using Astrana.Core.Domain.Links.Commands.DeleteLinks;
using Astrana.Core.Domain.Links.Commands.UpdateLinks;
using Astrana.Core.Domain.Links.Queries;
using Astrana.Core.Domain.Models.Links;
using Astrana.Core.Domain.Models.Links.Options;
using Astrana.Core.Domain.Models.Results.Enums;
using Astrana.Core.Domain.Models.System.Enums;
using Astrana.Core.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.API.Controllers
{
    [ApiController]
    public class LinksController : BaseController<LinksController>
    {
        private readonly ILogger<LinksController> _logger;

        private readonly IGetLinksQuery _getLinksQuery;

        private readonly ICreateLinksCommand _createLinksCommand;
        private readonly IUpdateLinksCommand _updateLinksCommand;
        private readonly IDeleteLinksCommand _deleteLinksCommand;

        private readonly IGetLinkSummaryQuery _getLinkSummaryCommand;

        public LinksController(ILogger<LinksController> logger, ISignInManager signInManager, IGetLinksQuery getLinksQuery, ICreateLinksCommand createLinksCommand, IUpdateLinksCommand updateLinksCommand, IDeleteLinksCommand deleteLinksCommand, IGetLinkSummaryQuery getLinkSummaryCommand) : base(logger, signInManager)
        {
            _logger = logger;
         
            _getLinksQuery = getLinksQuery;
            _createLinksCommand = createLinksCommand;
            _updateLinksCommand = updateLinksCommand;
            _deleteLinksCommand = deleteLinksCommand;

            _getLinkSummaryCommand = getLinkSummaryCommand;
        }

        /// <summary>
        /// Returns a paged set of links according to the options provided.
        /// </summary>
        /// <param name="createdAfter"></param>
        /// <param name="createdBefore"></param>
        /// <param name="createdById"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="orderBy"></param>
        /// <param name="orderByDirection"></param>
        /// <returns></returns>
        /// <response code="200">Link(s) successfully retrieved.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpGet]
        public async Task<IActionResult> GetAsync(DateTime? createdAfter = null, DateTime? createdBefore = null, Guid? createdById = null, int page = Pagination.DefaultPage, int pageSize = Pagination.DefaultPageSize, string? orderBy = null, OrderByDirection orderByDirection = OrderByDirection.Default)
        {
            var actioningUserId = GetActioningUserId();

            var queryOptions = new LinkQueryOptions<Guid, Guid>
            {
                CreatedAfter = createdAfter,
                CreatedBefore = createdBefore,

                PageSize = pageSize,
                CurrentPage = page,

                OrderByDirection = orderByDirection,
                OrderBy = orderBy
            };

            queryOptions.SetOwnerUserIds(createdById.AsList());

            var result = await _getLinksQuery.ExecuteAsync(actioningUserId, queryOptions);

            return PagedGetResponse(result, page, pageSize, result.Message);
        }

        /// <summary>
        /// Gets a link by it's ID if it exists.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <response code="200">Link successfully retrieved.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetLinkByIdAsync(Guid id)
        {
            var actioningUserId = GetActioningUserId();

            var queryOptions = new LinkQueryOptions<Guid, Guid>(id.AsList());

            var result = await _getLinksQuery.ExecuteAsync(actioningUserId, queryOptions);

            return UnpagedGetResponse(result.Data.FirstOrDefault(), result.Message);
        }

        /// <summary>
        /// Creates new links.
        /// </summary>
        /// <param name="links"></param>
        /// <returns></returns>
        /// <response code="201">Link(s) successfully created.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpPut]
        public async Task<IActionResult> CreateLinks(IList<Link> links)
        {
            var actioningUserId = GetActioningUserId();

            try
            {
                var result = await _createLinksCommand.ExecuteAsync(links, actioningUserId);

                if (result.Outcome == ResultOutcome.Success)
                {
                    return CreatedSuccessResponse(result, result.Message);
                }

                return ErrorResponse(result, result.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                return ErrorResponse(links);
            }
        }

        /// <summary>
        /// Updates existing links.
        /// </summary>
        /// <param name="links"></param>
        /// <returns></returns>
        /// <response code="200">Link(s) successfully updated.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpPost]
        public async Task<IActionResult> UpdateLinks(IList<Link> links)
        {
            var actioningUserId = GetActioningUserId();

            try
            {
                var result = await _updateLinksCommand.ExecuteAsync(links, actioningUserId);

                if (result.Outcome == ResultOutcome.Success)
                    return UpdatedSuccessResponse(result, result.Message);

                return ErrorResponse(result, result.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                return ErrorResponse(links);
            }
        }

        /// <summary>
        /// Deletes existing links by their IDs.
        /// </summary>
        /// <param name="linkIds"></param>
        /// <returns></returns>
        /// <response code="200">Link(s) successfully updated.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpDelete]
        public async Task<IActionResult> DeleteLinks(IList<Guid> linkIds)
        {
            var actioningUserId = GetActioningUserId();

            try
            {
                var result = await _deleteLinksCommand.ExecuteAsync(linkIds, actioningUserId);

                if (result.Outcome == ResultOutcome.Success)
                    return DeletedSuccessResponse(result, result.Message);

                return ErrorResponse(result, result.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                return ErrorResponse(linkIds);
            }
        }

        /// <summary>
        /// Gets a summary of a specified link.
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        [HttpGet("Summary")]
        public async Task<IActionResult> Summary(Uri url)
        {
            var actioningUserId = GetActioningUserId();

            var result = await _getLinkSummaryCommand.ExecuteAsync(url, actioningUserId);

            if(result.Outcome != ResultOutcome.Success)
                return ErrorResponse(result.Data, result.Message);

            return ExecutionSuccessResponse(result, result.Message);
        }
    }
}