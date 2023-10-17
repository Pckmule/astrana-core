/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Constants;
using Astrana.Core.Domain.ExternalContentSubscriptions.Commands.CreateExternalSubscriptions;
using Astrana.Core.Domain.ExternalContentSubscriptions.Commands.DeleteExternalSubscriptions;
using Astrana.Core.Domain.IdentityAccessManagement.Managers.SignIn;
using Astrana.Core.Domain.ExternalContentSubscriptions.Commands.UpdateExternalSubscriptions;
using Astrana.Core.Domain.ExternalContentSubscriptions.Queries;
using Astrana.Core.Domain.Models.ExternalContentSubscriptions;
using Astrana.Core.Domain.Models.ExternalContentSubscriptions.Options;
using Astrana.Core.Domain.Models.Results.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.API.Controllers
{
    [ApiController]
    public class ExternalSubscriptionsController : BaseController<ExternalSubscriptionsController>
    {
        private readonly ILogger<ExternalSubscriptionsController> _logger;

        private readonly IGetExternalSubscriptionsQuery _getExternalSubscriptionsQuery;
        private readonly ICreateExternalSubscriptionsCommand _createExternalSubscriptionsCommand;
        private readonly IUpdateExternalSubscriptionsCommand _updateExternalSubscriptionsCommand;
        private readonly IDeleteExternalSubscriptionsCommand _deleteExternalSubscriptionsCommand;
        private readonly IGetExternalSummaryQuery _getExternalSummaryQuery;

        public ExternalSubscriptionsController(ILogger<ExternalSubscriptionsController> logger, ISignInManager signInManager, IGetExternalSubscriptionsQuery getExternalSubscriptionsQuery, ICreateExternalSubscriptionsCommand createExternalSubscriptionsCommand, IUpdateExternalSubscriptionsCommand updateExternalSubscriptionsCommand, IDeleteExternalSubscriptionsCommand deleteExternalSubscriptionsCommand, IGetExternalSummaryQuery getExternalSummaryQuery) : base(logger, signInManager)
        {
            _logger = logger;

            _getExternalSubscriptionsQuery = getExternalSubscriptionsQuery;
            _createExternalSubscriptionsCommand = createExternalSubscriptionsCommand;
            _updateExternalSubscriptionsCommand = updateExternalSubscriptionsCommand;
            _deleteExternalSubscriptionsCommand = deleteExternalSubscriptionsCommand;
            _getExternalSummaryQuery = getExternalSummaryQuery;
        }

        /// <summary>
        /// Returns a paged set of external content subscriptions according to the options provided.
        /// </summary>
        /// <param name="createdAfter"></param>
        /// <param name="createdBefore"></param>
        /// <param name="createdById"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        /// <response code="200">ExternalContentSubscription(s) successfully retrieved.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpGet]
        public async Task<IActionResult> GetAsync(DateTime? createdAfter = null, DateTime? createdBefore = null, Guid? createdById = null, int page = Pagination.DefaultPage, int pageSize = Pagination.DefaultPageSize)
        {
            var actioningUserId = GetActioningUserId();

            var queryOptions = new ExternalContentSubscriptionQueryOptions<Guid, Guid>
            {
                OwnerUserIds = createdById.HasValue ? new List<Guid> { createdById.Value } : new List<Guid>(),

                CreatedAfter = createdAfter,
                CreatedBefore = createdBefore,

                PageSize = pageSize,
                CurrentPage = page
            };

            var result = await _getExternalSubscriptionsQuery.ExecuteAsync(actioningUserId, queryOptions);

            return PagedGetResponse(result, page, pageSize, result.Message);
        }

        /// <summary>
        /// Gets a external content subscription by it's ID if it exists.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <response code="200">ExternalContentSubscription successfully retrieved.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetExternalContentSubscriptionByIdAsync(Guid id)
        {
            var actioningUserId = GetActioningUserId();

            var queryOptions = new ExternalContentSubscriptionQueryOptions<Guid, Guid>
            {
                Ids = new List<Guid> { id }
            };

            var result = await _getExternalSubscriptionsQuery.ExecuteAsync(actioningUserId, queryOptions);

            return UnpagedGetResponse(result.Data.FirstOrDefault(), result.Message);
        }

        /// <summary>
        /// Creates new external content subscriptions.
        /// </summary>
        /// <param name="externalContentSubscriptions"></param>
        /// <returns></returns>
        /// <response code="201">ExternalContentSubscription(s) successfully created.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpPut]
        public async Task<IActionResult> CreateExternalContentSubscriptions(IList<ExternalSubscriptionToAdd> externalContentSubscriptions)
        {
            var actioningUserId = GetActioningUserId();

            try
            {
                var result = await _createExternalSubscriptionsCommand.ExecuteAsync(externalContentSubscriptions, actioningUserId);

                if (result.Outcome == ResultOutcome.Success)
                {
                    return CreatedSuccessResponse(result, result.Message);
                }

                return ErrorResponse(result, result.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                return ErrorResponse(externalContentSubscriptions);
            }
        }

        /// <summary>
        /// Updates existing external content subscriptions.
        /// </summary>
        /// <param name="externalContentSubscriptions"></param>
        /// <returns></returns>
        /// <response code="200">ExternalContentSubscription(s) successfully updated.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpPost]
        public async Task<IActionResult> UpdateExternalContentSubscriptions(IList<ExternalSubscription> externalContentSubscriptions)
        {
            var actioningUserId = GetActioningUserId();

            try
            {
                var result = await _updateExternalSubscriptionsCommand.ExecuteAsync(externalContentSubscriptions, actioningUserId);

                if (result.Outcome == ResultOutcome.Success)
                    return UpdatedSuccessResponse(result, result.Message);

                return ErrorResponse(result, result.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                return ErrorResponse(externalContentSubscriptions);
            }
        }

        /// <summary>
        /// Deletes existing external content subscriptions by their IDs.
        /// </summary>
        /// <param name="externalContentSubscriptionIds"></param>
        /// <returns></returns>
        /// <response code="200">ExternalContentSubscription(s) successfully updated.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpDelete]
        public async Task<IActionResult> DeleteExternalContentSubscriptions(IList<Guid> externalContentSubscriptionIds)
        {
            var actioningUserId = GetActioningUserId();

            try
            {
                var result = await _deleteExternalSubscriptionsCommand.ExecuteAsync(externalContentSubscriptionIds, actioningUserId);

                if (result.Outcome == ResultOutcome.Success)
                    return DeletedSuccessResponse(result, result.Message);

                return ErrorResponse(result, result.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                return ErrorResponse(externalContentSubscriptionIds);
            }
        }

        /// <summary>
        /// Gets a summary of a specified external content subscription.
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        [HttpGet("Summary")]
        public async Task<IActionResult> Summary(Uri url)
        {
            var actioningUserId = GetActioningUserId();

            var result = await _getExternalSummaryQuery.ExecuteAsync(url, actioningUserId);

            if (result.Outcome != ResultOutcome.Success)
                return ErrorResponse(result.Data, result.Message);

            return ExecutionSuccessResponse(result, result.Message);
        }
    }
}