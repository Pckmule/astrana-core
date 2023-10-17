/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Constants;
using Astrana.Core.Domain.Albums.Commands.CreateAlbums;
using Astrana.Core.Domain.Albums.Commands.DeleteAlbums;
using Astrana.Core.Domain.Albums.Commands.UpdateAlbums;
using Astrana.Core.Domain.Albums.Queries;
using Astrana.Core.Domain.IdentityAccessManagement.Managers.SignIn;
using Astrana.Core.Domain.Models.Albums;
using Astrana.Core.Domain.Models.Albums.DomainTransferObjects;
using Astrana.Core.Domain.Models.Albums.Options;
using Astrana.Core.Domain.Models.Results.Enums;
using Astrana.Core.Domain.Models.System.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.API.Controllers
{
    [ApiController]
    public class AlbumsController : BaseController<AlbumsController>
    {
        private readonly ILogger<AlbumsController> _logger;

        private readonly IGetAlbumsQuery _getAlbumsQuery;

        private readonly ICreateAlbumsCommand _createAlbumsCommand;
        private readonly IUpdateAlbumsCommand _updateAlbumsCommand;
        private readonly IDeleteAlbumsCommand _deleteAlbumsCommand;

        public AlbumsController(ILogger<AlbumsController> logger, ISignInManager signInManager, IGetAlbumsQuery getAlbumsQuery, ICreateAlbumsCommand createAlbumsCommand, IUpdateAlbumsCommand updateAlbumsCommand, IDeleteAlbumsCommand deleteAlbumsCommand) : base(logger, signInManager)
        {
            _logger = logger;

            _getAlbumsQuery = getAlbumsQuery;
            _createAlbumsCommand = createAlbumsCommand;
            _updateAlbumsCommand = updateAlbumsCommand;
            _deleteAlbumsCommand = deleteAlbumsCommand;
        }

        /// <summary>
        /// Returns a paged set of albums according to the options provided.
        /// </summary>
        /// <param name="includeContentItems"></param>
        /// <param name="createdAfter"></param>
        /// <param name="createdBefore"></param>
        /// <param name="createdById"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="orderBy"></param>
        /// <param name="orderByByDirection"></param>
        /// <returns></returns>
        /// <response code="200">Album(s) successfully retrieved.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpGet]
        public async Task<IActionResult> GetAsync(bool? includeContentItems = null, DateTime? createdAfter = null, DateTime? createdBefore = null, Guid? createdById = null, int page = Pagination.DefaultPage, int pageSize = Pagination.DefaultPageSize, string? orderBy = null, OrderByDirection orderByByDirection = OrderByDirection.Default)
        {
            var actioningUserId = GetActioningUserId();

            var queryOptions = new AlbumQueryOptions<Guid, Guid>
            {
                OwnerUserIds = createdById.HasValue ? new List<Guid> { createdById.Value } : new List<Guid>(),

                CreatedAfter = createdAfter,
                CreatedBefore = createdBefore,

                PageSize = pageSize,
                CurrentPage = page,

                OrderByDirection = orderByByDirection,
                OrderBy = orderBy
            };

            if (includeContentItems.HasValue)
                queryOptions.IncludeCollectionItems = includeContentItems.Value;

            var result = await _getAlbumsQuery.ExecuteAsync(actioningUserId, queryOptions);

            return PagedGetResponse(result, page, pageSize, result.Message);
        }

        /// <summary>
        /// Gets a album by it's ID if it exists.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="includeContentItems"></param>
        /// <returns></returns>
        /// <response code="200">Album successfully retrieved.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAlbumByIdAsync(Guid id, bool? includeContentItems = null)
        {
            var actioningUserId = GetActioningUserId();

            var queryOptions = new AlbumQueryOptions<Guid, Guid>
            {
                Ids = new List<Guid> { id }
            };

            if (includeContentItems.HasValue)
                queryOptions.IncludeCollectionItems = includeContentItems.Value;

            var result = await _getAlbumsQuery.ExecuteAsync(actioningUserId, queryOptions);

            return UnpagedGetResponse(result.Data.FirstOrDefault(), result.Message);
        }

        /// <summary>
        /// Creates new albums.
        /// </summary>
        /// <param name="albums"></param>
        /// <returns></returns>
        /// <response code="201">Album(s) successfully created.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpPut]
        public async Task<IActionResult> CreateAlbums(IList<AddAlbumDto> albums)
        {
            var actioningUserId = GetActioningUserId();

            try
            {
                var result = await _createAlbumsCommand.ExecuteAsync(albums, actioningUserId);
                
                if (result.Outcome == ResultOutcome.Success)
                {
                    return CreatedSuccessResponse2(result.Data.Select(o => o.ToDomainTransferObject()).ToList(), result.Message);
                }

                return ErrorResponse(result, result.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                return ErrorResponse(albums);
            }
        }

        /// <summary>
        /// Updates existing albums.
        /// </summary>
        /// <param name="albums"></param>
        /// <returns></returns>
        /// <response code="200">Album(s) successfully updated.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpPost]
        public async Task<IActionResult> UpdateAlbums(IList<Album> albums)
        {
            var actioningUserId = GetActioningUserId();

            try
            {
                var result = await _updateAlbumsCommand.ExecuteAsync(albums, actioningUserId);

                if (result.Outcome == ResultOutcome.Success)
                    return UpdatedSuccessResponse(result, result.Message);

                return ErrorResponse(result, result.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                return ErrorResponse(albums);
            }
        }

        /// <summary>
        /// Deletes existing albums by their IDs.
        /// </summary>
        /// <param name="albumIds"></param>
        /// <returns></returns>
        /// <response code="200">Album(s) successfully updated.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpDelete]
        public async Task<IActionResult> DeleteAlbums(IList<Guid> albumIds)
        {
            var actioningUserId = GetActioningUserId();

            try
            {
                var result = await _deleteAlbumsCommand.ExecuteAsync(albumIds, actioningUserId);

                if (result.Outcome == ResultOutcome.Success)
                    return DeletedSuccessResponse(result, result.Message);

                return ErrorResponse(result, result.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                return ErrorResponse(albumIds);
            }
        }
    }
}