/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Constants;
using Astrana.Core.Domain.Comments.Commands.CreateComments;
using Astrana.Core.Domain.Comments.Commands.DeleteComments;
using Astrana.Core.Domain.Comments.Commands.UpdateComments;
using Astrana.Core.Domain.Comments.Queries;
using Astrana.Core.Domain.IdentityAccessManagement.Managers.SignIn;
using Astrana.Core.Domain.Models.Comments;
using Astrana.Core.Domain.Models.Comments.DomainTransferObjects;
using Astrana.Core.Domain.Models.Comments.Options;
using Astrana.Core.Domain.Models.Results.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.API.Controllers
{
    [ApiController]
    public class CommentsController : BaseController<CommentsController>
    {
        private readonly ILogger<CommentsController> _logger;

        private readonly IGetCommentsQuery _getCommentsQuery;

        private readonly ICreateCommentsCommand _createCommentsCommand;
        private readonly IUpdateCommentsCommand _updateCommentsCommand;
        private readonly IDeleteCommentsCommand _deleteCommentsCommand;
        
        public CommentsController(ILogger<CommentsController> logger, ISignInManager signInManager, IGetCommentsQuery getCommentsQuery, ICreateCommentsCommand createCommentsCommand, IUpdateCommentsCommand updateCommentsCommand, IDeleteCommentsCommand deleteCommentsCommand) : base(logger, signInManager)
        {
            _logger = logger;
         
            _getCommentsQuery = getCommentsQuery;
            _createCommentsCommand = createCommentsCommand;
            _updateCommentsCommand = updateCommentsCommand;
            _deleteCommentsCommand = deleteCommentsCommand;
        }

        /// <summary>
        /// Returns a paged set of comments according to the options provided.
        /// </summary>
        /// <param name="createdAfter"></param>
        /// <param name="createdBefore"></param>
        /// <param name="createdById"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        /// <response code="200">Comment(s) successfully retrieved.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpGet]
        public async Task<IActionResult> GetAsync(DateTime? createdAfter = null, DateTime? createdBefore = null, Guid? createdById = null, int page = Pagination.DefaultPage, int pageSize = Pagination.DefaultPageSize)
        {
            var actioningUserId = GetActioningUserId();

            var queryOptions = new CommentQueryOptions<Guid, Guid>
            {
                OwnerUserIds = createdById.HasValue ? new List<Guid> { createdById.Value } : new List<Guid>(),

                CreatedAfter = createdAfter,
                CreatedBefore = createdBefore,

                PageSize = pageSize,
                CurrentPage = page
            };

            var result = await _getCommentsQuery.ExecuteAsync(actioningUserId, queryOptions);

            return PagedGetResponse(result, page, pageSize, result.Message);
        }

        /// <summary>
        /// Gets a comment by it's ID if it exists.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <response code="200">Comment successfully retrieved.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCommentByIdAsync(Guid id)
        {
            var actioningUserId = GetActioningUserId();

            var queryOptions = new CommentQueryOptions<Guid, Guid>
            {
                Ids = new List<Guid> { id }
            };

            var result = await _getCommentsQuery.ExecuteAsync(actioningUserId, queryOptions);

            return UnpagedGetResponse(result.Data.FirstOrDefault(), result.Message);
        }

        /// <summary>
        /// Creates new comments.
        /// </summary>
        /// <param name="comments"></param>
        /// <returns></returns>
        /// <response code="201">Comment(s) successfully created.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpPut]
        public async Task<IActionResult> CreateComments(IList<CommentDto> comments)
        {
            var actioningUserId = GetActioningUserId();

            try
            {
                var result = await _createCommentsCommand.ExecuteAsync(comments, actioningUserId);

                if (result.Outcome == ResultOutcome.Success)
                {
                    return CreatedSuccessResponse(result, result.Message);
                }

                return ErrorResponse(result, result.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                return ErrorResponse(comments);
            }
        }

        /// <summary>
        /// Updates existing comments.
        /// </summary>
        /// <param name="comments"></param>
        /// <returns></returns>
        /// <response code="200">Comment(s) successfully updated.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpPost]
        public async Task<IActionResult> UpdateComments(IList<CommentDto> comments)
        {
            var actioningUserId = GetActioningUserId();

            try
            {
                var result = await _updateCommentsCommand.ExecuteAsync(comments, actioningUserId);

                if (result.Outcome == ResultOutcome.Success)
                    return UpdatedSuccessResponse(result, result.Message);

                return ErrorResponse(result, result.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                return ErrorResponse(comments);
            }
        }

        /// <summary>
        /// Deletes existing comments by their IDs.
        /// </summary>
        /// <param name="commentIds"></param>
        /// <returns></returns>
        /// <response code="200">Comment(s) successfully updated.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpDelete]
        public async Task<IActionResult> DeleteComments(IList<Guid> commentIds)
        {
            var actioningUserId = GetActioningUserId();

            try
            {
                var result = await _deleteCommentsCommand.ExecuteAsync(commentIds, actioningUserId);

                if (result.Outcome == ResultOutcome.Success)
                    return DeletedSuccessResponse(result, result.Message);

                return ErrorResponse(result, result.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                return ErrorResponse(commentIds);
            }
        }
    }
}