/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Constants;
using Astrana.Core.Data.Repositories.Peers;
using Astrana.Core.Domain.AstranaApi.Services;
using Astrana.Core.Domain.IdentityAccessManagement.Managers.SignIn;
using Astrana.Core.Domain.Models.Attachments.Enums;
using Astrana.Core.Domain.Models.ContentCollections.Options;
using Astrana.Core.Domain.Models.Posts;
using Astrana.Core.Domain.Models.Posts.DomainTransferObjects;
using Astrana.Core.Domain.Models.Posts.Options;
using Astrana.Core.Domain.Models.Results.Enums;
using Astrana.Core.Domain.Models.System.Enums;
using Astrana.Core.Domain.Posts.Commands.Handlers.CreatePosts;
using Astrana.Core.Domain.Posts.Commands.Handlers.DeletePosts;
using Astrana.Core.Domain.Posts.Commands.Handlers.UpdatePosts;
using Astrana.Core.Domain.Posts.Queries;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ApiConstants = Astrana.Core.Constants.Api;

namespace Astrana.Core.API.Controllers
{
    [ApiController]
    public class PostsController : BaseController<PostsController>
    {
        private readonly ILogger<PostsController> _logger;

        private readonly IPeerRepository<Guid> _peerRepository;

        private readonly IDiscoverPostsQuery _discoverPostsQuery;

        private readonly IGetPostsQuery _getPostsQuery;
        private readonly ICreatePostsCommandHandler _createPostsCommand;
        private readonly IUpdatePostsCommandHandler _updatePostsCommand;
        private readonly IDeletePostsCommandHandler _deletePostsCommand;

        public PostsController(ILogger<PostsController> logger, ISignInManager signInManager, IPeerRepository<Guid> peerRepository, IDiscoverPostsQuery discoverPostsQuery, IGetPostsQuery getPostsQuery, ICreatePostsCommandHandler addPostsCommand, IUpdatePostsCommandHandler updatePostsCommand, IDeletePostsCommandHandler deletePostsCommand) : base(logger, signInManager)
        {
            _logger = logger;

            _peerRepository = peerRepository;

            _discoverPostsQuery = discoverPostsQuery;
            
            _getPostsQuery = getPostsQuery;
            _createPostsCommand = addPostsCommand;
            _updatePostsCommand = updatePostsCommand;
            _deletePostsCommand = deletePostsCommand;
        }

        /// <summary>
        /// Returns a paged set of posts according to the options provided.
        /// </summary>
        /// <param name="createdAfter"></param>
        /// <param name="createdBefore"></param>
        /// <param name="createdById"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="attachmentTypes"></param>
        /// <param name="orderBy"></param>
        /// <param name="orderByDirection"></param>
        /// <param name="peerProfileId"></param>
        /// <returns></returns>
        /// <response code="200">Post(s) successfully retrieved.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpGet]
        public async Task<IActionResult> GetAsync([FromQuery] AttachmentType[]? attachmentTypes = null, DateTime ? createdAfter = null, DateTime? createdBefore = null, Guid? createdById = null, int page = Pagination.DefaultPage, int pageSize = Pagination.DefaultPageSize, string? orderBy = null, OrderByDirection orderByDirection = OrderByDirection.Default, Guid? peerProfileId = null)
        {
            var actioningUserId = GetActioningUserId();

            var queryOptions = new PostQueryOptions<long, Guid>
            {
                OwnerUserIds = createdById.HasValue ? new List<Guid> { createdById.Value } : new List<Guid>(),

                AttachmentTypes = attachmentTypes?.Distinct().ToList(),

                CreatedAfter = createdAfter,
                CreatedBefore = createdBefore,

                PageSize = pageSize,
                CurrentPage = page,

                OrderByDirection = orderByDirection,
                OrderBy = orderBy
            };

            if (peerProfileId.HasValue)
            {
                var peerId = await _peerRepository.GetPeerIdByPeerProfileIdAsync(peerProfileId.Value);

                var peer = await _peerRepository.GetPeerByProfileIdAsync(peerId);

                if(peer == null)
                    return ErrorResponse("Peer Not Found");

                var peerApi = new AstranaApiClient();
                    peerApi.SetAuthorizationToken(peer.PeerAccessToken);

                var peerApiResult = await peerApi.GetAsync<List<Post>>(peer.Address, "posts", "", queryOptions.ToQueryStringList());

                if (peerApiResult.IsSuccess)
                {
                    var peerResult = ConvertToGetResult<PostQueryOptions<long, Guid>, long, Guid, Post>(peerApiResult, queryOptions);

                    return PagedGetResponse2(peerResult, peerResult.Data.Select(o => o.ToDomainTransferObject(includeAuditData: true)).ToList(), page, pageSize, peerApiResult.Message);
                }

                return ErrorResponse(peerApiResult.Message);
            }

            var result = await _getPostsQuery.ExecuteAsync(actioningUserId, queryOptions);

            return PagedGetResponse2(result, result.Data.Select(o => o.ToDomainTransferObject(includeAuditData: true)).ToList(), queryOptions.CurrentPage.Value, queryOptions.PageSize.Value, result.Message);
        }

        /// <summary>
        /// Returns a paged set of posts metadata according to the options provided.
        /// </summary>
        /// <param name="createdAfter"></param>
        /// <param name="createdBefore"></param>
        /// <param name="createdById"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        [HttpHead("discover")]
        public async Task<IActionResult> DiscoverPostsAsync(DateTime? createdAfter = null, DateTime? createdBefore = null, Guid? createdById = null, int page = Pagination.DefaultPage, int pageSize = Pagination.DefaultPageSize)
        {
            var actioningUserId = GetActioningUserId();

            var queryOptions = new PostQueryOptions<long, Guid>
            {
                OwnerUserIds = createdById.HasValue ? new List<Guid> { createdById.Value } : new List<Guid>(),

                CreatedAfter = createdAfter,
                CreatedBefore = createdBefore,

                PageSize = pageSize,
                CurrentPage = page
            };

            var result = await _discoverPostsQuery.ExecuteAsync(actioningUserId, queryOptions);

            Response.Headers.Add(ApiConstants.HeaderNames.Astrana.TotalCount, result.Count.ToString());

            return Ok();
        }

        /// <summary>
        /// Gets a post by it's ID if it exists.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <response code="200">Post successfully retrieved.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPostByIdAsync(long id)
        {
            var actioningUserId = GetActioningUserId();

            var queryOptions = new PostQueryOptions<long, Guid>
            {
                Ids = new List<long> { id }
            };

            var result = await _getPostsQuery.ExecuteAsync(actioningUserId, queryOptions);

            return UnpagedGetResponse(result.Data.FirstOrDefault(), result.Message);
        }

        /// <summary>
        /// Creates new posts.
        /// </summary>
        /// <param name="posts"></param>
        /// <returns></returns>
        /// <response code="201">Post(s) successfully created.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpPut]
        public async Task<IActionResult> CreatePosts(IList<PostDto> posts)
        {
            var actioningUserId = GetActioningUserId();

            try
            {
                var result = await _createPostsCommand.ExecuteAsync(posts, actioningUserId);

                if (result.Outcome == ResultOutcome.Success)
                    return CreatedSuccessResponse(result, result.Message);

                return ErrorResponse(result, result.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                return ErrorResponse(posts);
            }
        }

        /// <summary>
        /// Updates existing posts.
        /// </summary>
        /// <param name="posts"></param>
        /// <returns></returns>
        /// <response code="200">Post(s) successfully updated.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpPost]
        public async Task<IActionResult> UpdatePosts(IList<Post> posts)
        {
            var actioningUserId = GetActioningUserId();

            try
            {
                var result = await _updatePostsCommand.ExecuteAsync(posts, actioningUserId);

                if (result.Outcome == ResultOutcome.Success)
                    return UpdatedSuccessResponse(result, result.Message);

                return ErrorResponse(result, result.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                return ErrorResponse(posts);
            }
        }

        /// <summary>
        /// Deletes existing posts by their IDs.
        /// </summary>
        /// <param name="postIds"></param>
        /// <returns></returns>
        /// <response code="200">Post(s) successfully updated.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpDelete]
        public async Task<IActionResult> DeletePosts(IList<long> postIds)
        {
            var actioningUserId = GetActioningUserId();

            try
            {
                var result = await _deletePostsCommand.ExecuteAsync(postIds, actioningUserId);

                if (result.Outcome == ResultOutcome.Success)
                    return DeletedSuccessResponse(result, result.Message);

                return ErrorResponse(result, result.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                return ErrorResponse(postIds);
            }
        }
    }
}