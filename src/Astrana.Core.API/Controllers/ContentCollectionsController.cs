/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Constants;
using Astrana.Core.Data.Repositories.Peers;
using Astrana.Core.Domain.AstranaApi.Services;
using Astrana.Core.Domain.ContentCollections.Commands.CreateContentCollections;
using Astrana.Core.Domain.ContentCollections.Commands.DeleteContentCollections;
using Astrana.Core.Domain.ContentCollections.Commands.UpdateContentCollections;
using Astrana.Core.Domain.ContentCollections.Queries;
using Astrana.Core.Domain.IdentityAccessManagement.Managers.SignIn;
using Astrana.Core.Domain.Models.AstranaApi.Responses;
using Astrana.Core.Domain.Models.ContentCollections;
using Astrana.Core.Domain.Models.ContentCollections.DomainTransferObjects;
using Astrana.Core.Domain.Models.ContentCollections.Enums;
using Astrana.Core.Domain.Models.ContentCollections.Options;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Enums;
using Astrana.Core.Domain.Models.System.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.API.Controllers
{
    [ApiController]
    public class ContentCollectionsController : BaseController<ContentCollectionsController>
    {
        private readonly ILogger<ContentCollectionsController> _logger;

        private readonly IPeerRepository<Guid> _peerRepository;

        private readonly IGetContentCollectionsQuery _getContentCollectionsQuery;

        private readonly ICreateContentCollectionsCommand _createContentCollectionsCommand;
        private readonly IUpdateContentCollectionsCommand _updateContentCollectionsCommand;
        private readonly IDeleteContentCollectionsCommand _deleteContentCollectionsCommand;

        public ContentCollectionsController(ILogger<ContentCollectionsController> logger, ISignInManager signInManager, IPeerRepository<Guid> peerRepository, IGetContentCollectionsQuery getContentCollectionsQuery, ICreateContentCollectionsCommand createContentCollectionsCommand, IUpdateContentCollectionsCommand updateContentCollectionsCommand, IDeleteContentCollectionsCommand deleteContentCollectionsCommand) : base(logger, signInManager)
        {
            _logger = logger;

            _peerRepository = peerRepository;

            _getContentCollectionsQuery = getContentCollectionsQuery;

            _createContentCollectionsCommand = createContentCollectionsCommand;
            _updateContentCollectionsCommand = updateContentCollectionsCommand;
            _deleteContentCollectionsCommand = deleteContentCollectionsCommand;
        }

        /// <summary>
        /// Returns a paged set of content collections according to the options provided.
        /// </summary>
        /// <param name="includeContentItems"></param>
        /// <param name="collectionType"></param>
        /// <param name="createdAfter"></param>
        /// <param name="createdBefore"></param>
        /// <param name="createdById"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="orderBy"></param>
        /// <param name="orderByDirection"></param>
        /// <param name="peerId"></param>
        /// <returns></returns>
        /// <response code="200">Content Collection(s) successfully retrieved.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpGet]
        public async Task<IActionResult> GetAsync(bool? includeContentItems = null, ContentCollectionType? collectionType = null, DateTime? createdAfter = null, DateTime? createdBefore = null, Guid? createdById = null, int page = Pagination.DefaultPage, int pageSize = Pagination.DefaultPageSize, string? orderBy = null, OrderByDirection orderByDirection = OrderByDirection.Default, Guid? peerId = null)
        {
            var actioningUserId = GetActioningUserId();

            var queryOptions = new ContentCollectionQueryOptions<Guid, Guid>
            {
                OwnerUserIds = createdById.HasValue ? new List<Guid> { createdById.Value } : new List<Guid>(),

                CreatedAfter = createdAfter,
                CreatedBefore = createdBefore,

                PageSize = pageSize,
                CurrentPage = page,

                OrderByDirection = orderByDirection,
                OrderBy = orderBy
            };

            if (includeContentItems.HasValue)
                queryOptions.IncludeCollectionItems = includeContentItems.Value;

            if (collectionType.HasValue)
                queryOptions.CollectionType = collectionType.Value;

            if (peerId.HasValue)
            {
                var peer = await _peerRepository.GetPeerByIdAsync(peerId.Value);

                var peerApi = new AstranaApiClient();
                    peerApi.SetAuthorizationToken(peer.PeerAccessToken);

                var peerApiResult = await peerApi.GetAsync<List<ContentCollection>>(peer.Address, "contentcollections", "", queryOptions.ToQueryStringList());

                if (peerApiResult.IsSuccess)
                {
                    var peerResult = ConvertToGetResult<ContentCollectionQueryOptions<Guid, Guid>, Guid, Guid, ContentCollection>(peerApiResult, queryOptions);

                    return PagedGetResponse(peerResult, page, pageSize, peerApiResult.Message);
                }

                return ErrorResponse(peerApiResult.Message);
            }

            var result = await _getContentCollectionsQuery.ExecuteAsync(actioningUserId, queryOptions);

            return PagedGetResponse(result, page, pageSize, result.Message);
        }
        
        
        /// <summary>
        /// Gets a content collection by it's ID if it exists.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="includeContentItems"></param>
        /// <returns></returns>
        /// <response code="200">Content Collection successfully retrieved.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetContentCollectionByIdAsync(Guid id, bool? includeContentItems = null)
        {
            var actioningUserId = GetActioningUserId();

            var queryOptions = new ContentCollectionQueryOptions<Guid, Guid>
            {
                Ids = new List<Guid> { id }
            };

            if (includeContentItems.HasValue)
                queryOptions.IncludeCollectionItems = includeContentItems.Value;

            var result = await _getContentCollectionsQuery.ExecuteAsync(actioningUserId, queryOptions);

            return UnpagedGetResponse(result.Data.FirstOrDefault(), result.Message);
        }

        /// <summary>
        /// Creates new content collections.
        /// </summary>
        /// <param name="contentCollections"></param>
        /// <returns></returns>
        /// <response code="201">Content Collection(s) successfully created.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpPut]
        public async Task<IActionResult> CreateContentCollections(IList<AddContentCollectionDto> contentCollections)
        {
            var actioningUserId = GetActioningUserId();

            try
            {
                var result = await _createContentCollectionsCommand.ExecuteAsync(contentCollections, actioningUserId);
                
                if (result.Outcome == ResultOutcome.Success)
                {
                    return CreatedSuccessResponse2(result.Data.Select(o => o.ToDomainTransferObject()).ToList(), result.Message);
                }

                return ErrorResponse(result, result.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                return ErrorResponse(contentCollections);
            }
        }

        /// <summary>
        /// Updates existing content collections.
        /// </summary>
        /// <param name="contentCollections"></param>
        /// <returns></returns>
        /// <response code="200">Content Collection(s) successfully updated.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpPost]
        public async Task<IActionResult> UpdateContentCollections(IList<ContentCollection> contentCollections)
        {
            var actioningUserId = GetActioningUserId();

            try
            {
                var result = await _updateContentCollectionsCommand.ExecuteAsync(contentCollections, actioningUserId);

                if (result.Outcome == ResultOutcome.Success)
                    return UpdatedSuccessResponse(result, result.Message);

                return ErrorResponse(result, result.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                return ErrorResponse(contentCollections);
            }
        }

        /// <summary>
        /// Deletes existing content collections by their IDs.
        /// </summary>
        /// <param name="contentCollectionIds"></param>
        /// <returns></returns>
        /// <response code="200">Content Collection(s) successfully updated.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpDelete]
        public async Task<IActionResult> DeleteContentCollections(IList<Guid> contentCollectionIds)
        {
            var actioningUserId = GetActioningUserId();

            try
            {
                var result = await _deleteContentCollectionsCommand.ExecuteAsync(contentCollectionIds, actioningUserId);

                if (result.Outcome == ResultOutcome.Success)
                    return DeletedSuccessResponse(result, result.Message);

                return ErrorResponse(result, result.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                return ErrorResponse(contentCollectionIds);
            }
        }
    }
}