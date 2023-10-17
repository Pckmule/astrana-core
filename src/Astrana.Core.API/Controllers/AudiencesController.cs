/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Constants;
using Astrana.Core.Domain.Audiences.Commands.CreateAudiences;
using Astrana.Core.Domain.Audiences.Commands.DeleteAudiences;
using Astrana.Core.Domain.Audiences.Commands.UpdateAudiences;
using Astrana.Core.Domain.Audiences.Queries;
using Astrana.Core.Domain.IdentityAccessManagement.Managers.SignIn;
using Astrana.Core.Domain.Models.Audiences;
using Astrana.Core.Domain.Models.Audiences.Options;
using Astrana.Core.Domain.Models.Results.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.API.Controllers
{
    [ApiController]
    public class AudiencesController : BaseController<AudiencesController>
    {
        private readonly ILogger<AudiencesController> _logger;

        private readonly IGetAudiencesQuery _getAudiencesQuery;

        private readonly ICreateAudiencesCommand _createAudiencesCommand;
        private readonly IUpdateAudiencesCommand _updateAudiencesCommand;
        private readonly IDeleteAudiencesCommand _deleteAudiencesCommand;

        public AudiencesController(ILogger<AudiencesController> logger, ISignInManager signInManager, IGetAudiencesQuery getAudiencesQuery, ICreateAudiencesCommand createAudiencesCommand, IUpdateAudiencesCommand updateAudiencesCommand, IDeleteAudiencesCommand deleteAudiencesCommand) : base(logger, signInManager)
        {
            _logger = logger;

            _getAudiencesQuery = getAudiencesQuery;
            _createAudiencesCommand = createAudiencesCommand;
            _updateAudiencesCommand = updateAudiencesCommand;
            _deleteAudiencesCommand = deleteAudiencesCommand;
        }

        /// <summary>
        /// Returns a paged set of audiences according to the options provided.
        /// </summary>
        /// <param name="createdAfter"></param>
        /// <param name="createdBefore"></param>
        /// <param name="createdById"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        /// <response code="200">Audience(s) successfully retrieved.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpGet]
        public async Task<IActionResult> GetAsync(DateTime? createdAfter = null, DateTime? createdBefore = null, Guid? createdById = null, int page = Pagination.DefaultPage, int pageSize = Pagination.DefaultPageSize)
        {
            var actioningUserId = GetActioningUserId();

            var queryOptions = new AudienceQueryOptions<Guid, Guid>
            {
                OwnerUserIds = createdById.HasValue ? new List<Guid> { createdById.Value } : new List<Guid>(),

                CreatedAfter = createdAfter,
                CreatedBefore = createdBefore,

                PageSize = pageSize,
                CurrentPage = page
            };

            var result = await _getAudiencesQuery.ExecuteAsync(actioningUserId, queryOptions);

            return PagedGetResponse(result, page, pageSize, result.Message);
        }

        /// <summary>
        /// Gets a audience by it's ID if it exists.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <response code="200">Audience successfully retrieved.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAudienceByIdAsync(Guid id)
        {
            var actioningUserId = GetActioningUserId();

            var queryOptions = new AudienceQueryOptions<Guid, Guid>
            {
                Ids = new List<Guid> { id }
            };

            var result = await _getAudiencesQuery.ExecuteAsync(actioningUserId, queryOptions);

            return UnpagedGetResponse(result.Data.FirstOrDefault(), result.Message);
        }

        /// <summary>
        /// Creates new audiences.
        /// </summary>
        /// <param name="audiences"></param>
        /// <returns></returns>
        /// <response code="201">Audience(s) successfully created.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpPut]
        public async Task<IActionResult> CreateAudiences(IList<AudienceToAdd> audiences)
        {
            var actioningUserId = GetActioningUserId();

            try
            {
                var result = await _createAudiencesCommand.ExecuteAsync(audiences, actioningUserId);

                if (result.Outcome == ResultOutcome.Success)
                {
                    return CreatedSuccessResponse(result, result.Message);
                }

                return ErrorResponse(result, result.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                return ErrorResponse(audiences);
            }
        }

        /// <summary>
        /// Updates existing audiences.
        /// </summary>
        /// <param name="audiences"></param>
        /// <returns></returns>
        /// <response code="200">Audience(s) successfully updated.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpPost]
        public async Task<IActionResult> UpdateAudiences(IList<Audience> audiences)
        {
            var actioningUserId = GetActioningUserId();

            try
            {
                var result = await _updateAudiencesCommand.ExecuteAsync(audiences, actioningUserId);

                if (result.Outcome == ResultOutcome.Success)
                    return UpdatedSuccessResponse(result, result.Message);

                return ErrorResponse(result, result.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                return ErrorResponse(audiences);
            }
        }

        /// <summary>
        /// Deletes existing audiences by their IDs.
        /// </summary>
        /// <param name="audienceIds"></param>
        /// <returns></returns>
        /// <response code="200">Audience(s) successfully updated.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpDelete]
        public async Task<IActionResult> DeleteAudiences(IList<Guid> audienceIds)
        {
            var actioningUserId = GetActioningUserId();

            try
            {
                var result = await _deleteAudiencesCommand.ExecuteAsync(audienceIds, actioningUserId);

                if (result.Outcome == ResultOutcome.Success)
                    return DeletedSuccessResponse(result, result.Message);

                return ErrorResponse(result, result.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                return ErrorResponse(audienceIds);
            }
        }
    }
}