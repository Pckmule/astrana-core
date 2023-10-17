/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.ContentCollections.Queries;
using Astrana.Core.Domain.Models.Albums;
using Astrana.Core.Domain.Models.Albums.Options;
using Astrana.Core.Domain.Models.ContentCollections.Enums;
using Astrana.Core.Domain.Models.ContentCollections.Options;
using Astrana.Core.Domain.Models.Results;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.Domain.Albums.Queries
{
    public class GetAlbumsQuery : IGetAlbumsQuery
    {
        private readonly ILogger<GetAlbumsQuery> _logger;
        private readonly IGetContentCollectionsQuery _getContentCollectionsQuery;

        public GetAlbumsQuery(ILogger<GetAlbumsQuery> logger, IGetContentCollectionsQuery getContentCollectionsQuery)
        {
            _logger = logger;
            _getContentCollectionsQuery = getContentCollectionsQuery;
        }

        public async Task<GetResult<AlbumQueryOptions<Guid, Guid>, Album, Guid, Guid>> ExecuteAsync(Guid actioningUserId, AlbumQueryOptions<Guid, Guid>? options = null)
        {
            var contentCollectionOptions = options == null ? new ContentCollectionQueryOptions<Guid, Guid>() : new ContentCollectionQueryOptions<Guid, Guid>
            {
                Tags = options.Tags,
                TagsFilterMode = options.TagsFilterMode,
                IncludeCollectionItems = options.IncludeCollectionItems,
                CollectionType = ContentCollectionType.Album
            };

            var result = await _getContentCollectionsQuery.ExecuteAsync(actioningUserId, contentCollectionOptions);

            return new GetResult<AlbumQueryOptions<Guid, Guid>, Album, Guid, Guid>(result.Data.Select(ModelMappings.ToAlbum).ToList(), options, result.ResultSetCount, result.Message);
        }
    }
}