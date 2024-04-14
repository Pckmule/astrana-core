/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Constants;
using Astrana.Core.Domain.IdentityAccessManagement.Managers.SignIn;
using Astrana.Core.Domain.Models.NewContentWorkflowStages;
using Astrana.Core.Domain.Models.NewContentWorkflowStages.Options;
using Astrana.Core.Domain.Models.Results.Enums;
using Astrana.Core.Domain.NewContentWorkflowStages.Commands.CreateNewContentWorkflowStages;
using Astrana.Core.Domain.NewContentWorkflowStages.Commands.DeleteNewContentWorkflowStages;
using Astrana.Core.Domain.NewContentWorkflowStages.Commands.UpdateNewContentWorkflowStages;
using Astrana.Core.Domain.NewContentWorkflowStages.Queries;
using Astrana.Core.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.API.Controllers
{
    [ApiController]
    public class WorkflowsController : BaseController<WorkflowsController>
    {
        private readonly ILogger<WorkflowsController> _logger;

        private readonly IGetNewContentWorkflowStagesQuery _getNewContentWorkflowStagesQuery;

        private readonly ICreateNewContentWorkflowStagesCommand _createNewContentWorkflowStagesCommand;
        private readonly IUpdateNewContentWorkflowStagesCommand _updateNewContentWorkflowStagesCommand;
        private readonly IDeleteNewContentWorkflowStagesCommand _deleteNewContentWorkflowStagesCommand;
        
        public WorkflowsController(ILogger<WorkflowsController> logger, ISignInManager signInManager, IGetNewContentWorkflowStagesQuery getNewContentWorkflowStagesQuery, ICreateNewContentWorkflowStagesCommand createNewContentWorkflowStagesCommand, IUpdateNewContentWorkflowStagesCommand updateNewContentWorkflowStagesCommand, IDeleteNewContentWorkflowStagesCommand deleteNewContentWorkflowStagesCommand) : base(logger, signInManager)
        {
            _logger = logger;
         
            _getNewContentWorkflowStagesQuery = getNewContentWorkflowStagesQuery;
            _createNewContentWorkflowStagesCommand = createNewContentWorkflowStagesCommand;
            _updateNewContentWorkflowStagesCommand = updateNewContentWorkflowStagesCommand;
            _deleteNewContentWorkflowStagesCommand = deleteNewContentWorkflowStagesCommand;
        }

        /// <summary>
        /// Returns a paged set of New Content Workflow Stages according to the options provided.
        /// </summary>
        /// <param name="createdAfter"></param>
        /// <param name="createdBefore"></param>
        /// <param name="createdById"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        /// <response code="200">New Content Workflow Stage(s) successfully retrieved.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpGet]
        public async Task<IActionResult> GetAsync(DateTime? createdAfter = null, DateTime? createdBefore = null, Guid? createdById = null, int page = Pagination.DefaultPage, int pageSize = Pagination.DefaultPageSize)
        {
            var actioningUserId = GetActioningUserId();

            var queryOptions = new NewContentWorkflowStageQueryOptions<Guid, Guid>
            {
                CreatedAfter = createdAfter,
                CreatedBefore = createdBefore,

                PageSize = pageSize,
                CurrentPage = page
            };

            queryOptions.SetOwnerUserIds(createdById.AsList());

            var result = await _getNewContentWorkflowStagesQuery.ExecuteAsync(actioningUserId, queryOptions);

            return PagedGetResponse(result, page, pageSize, result.Message);
        }

        /// <summary>
        /// Gets a New Content Workflow Stage by it's ID if it exists.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <response code="200">New Content Workflow Stage successfully retrieved.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetNewContentWorkflowStageByIdAsync(Guid id)
        {
            var actioningUserId = GetActioningUserId();

            var queryOptions = new NewContentWorkflowStageQueryOptions<Guid, Guid>(id.AsList());

            var result = await _getNewContentWorkflowStagesQuery.ExecuteAsync(actioningUserId, queryOptions);

            return UnpagedGetResponse(result.Data.FirstOrDefault(), result.Message);
        }

        /// <summary>
        /// Creates a New Content Workflow Stage.
        /// </summary>
        /// <param name="newContentWorkflowStages"></param>
        /// <returns></returns>
        /// <response code="201">New Content Workflow Stage(s) successfully created.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpPut]
        public async Task<IActionResult> CreateNewContentWorkflowStages(IList<NewContentWorkflowStage> newContentWorkflowStages)
        {
            var actioningUserId = GetActioningUserId();

            try
            {
                var result = await _createNewContentWorkflowStagesCommand.ExecuteAsync(newContentWorkflowStages, actioningUserId);

                if (result.Outcome == ResultOutcome.Success)
                {
                    return CreatedSuccessResponse(result, result.Message);
                }

                return ErrorResponse(result, result.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                return ErrorResponse(newContentWorkflowStages);
            }
        }

        /// <summary>
        /// Updates an existing New Content Workflow Stage.
        /// </summary>
        /// <param name="newContentWorkflowStages"></param>
        /// <returns></returns>
        /// <response code="200">New Content Workflow Stage(s) successfully updated.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpPost]
        public async Task<IActionResult> UpdateNewContentWorkflowStages(IList<NewContentWorkflowStage> newContentWorkflowStages)
        {
            var actioningUserId = GetActioningUserId();

            try
            {
                var result = await _updateNewContentWorkflowStagesCommand.ExecuteAsync(newContentWorkflowStages, actioningUserId);

                if (result.Outcome == ResultOutcome.Success)
                    return UpdatedSuccessResponse(result, result.Message);

                return ErrorResponse(result, result.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                return ErrorResponse(newContentWorkflowStages);
            }
        }

        /// <summary>
        /// Deletes existing New Content Workflow Stage by their IDs.
        /// </summary>
        /// <param name="newContentWorkflowStageIds"></param>
        /// <returns></returns>
        /// <response code="200">New Content Workflow Stage(s) successfully updated.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpDelete]
        public async Task<IActionResult> DeleteNewContentWorkflowStages(IList<Guid> newContentWorkflowStageIds)
        {
            var actioningUserId = GetActioningUserId();

            try
            {
                var result = await _deleteNewContentWorkflowStagesCommand.ExecuteAsync(newContentWorkflowStageIds, actioningUserId);

                if (result.Outcome == ResultOutcome.Success)
                    return DeletedSuccessResponse(result, result.Message);

                return ErrorResponse(result, result.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                return ErrorResponse(newContentWorkflowStageIds);
            }
        }
    }
}