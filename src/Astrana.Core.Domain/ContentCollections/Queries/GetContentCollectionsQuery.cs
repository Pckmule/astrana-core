/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Repositories.ContentCollections;
using Astrana.Core.Domain.Models.AstranaApi.Contracts;
using Astrana.Core.Domain.Models.ContentCollections;
using Astrana.Core.Domain.Models.ContentCollections.Options;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.System.Enums;
using Astrana.Core.Utilities;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.Domain.ContentCollections.Queries
{
    public class GetContentCollectionsQuery : IGetContentCollectionsQuery
    {
        private readonly ILogger<GetContentCollectionsQuery> _logger;
        private readonly IAstranaApiInfo _astranaApiInfo;
        private readonly IContentCollectionRepository<Guid> _contentCollectionRepository;

        public GetContentCollectionsQuery(ILogger<GetContentCollectionsQuery> logger, IAstranaApiInfo astranaApiInfo, IContentCollectionRepository<Guid> contentCollectionRepository)
        {
            _logger = logger;
            _astranaApiInfo = astranaApiInfo;
            _contentCollectionRepository = contentCollectionRepository;
        }

        public async Task<GetResult<ContentCollectionQueryOptions<Guid, Guid>, ContentCollection, Guid, Guid>> ExecuteAsync(Guid actioningUserId, ContentCollectionQueryOptions<Guid, Guid>? options = null)
        {
            options ??= new ContentCollectionQueryOptions<Guid, Guid>();

            var result = await _contentCollectionRepository.GetContentCollectionsAsync(options);

            foreach (var contentItem in result.Data.SelectMany(contentCollection => contentCollection.ContentItems))
            {
                if (contentItem.Link != null && contentItem.Link?.PreviewImage != null && contentItem.Link.PreviewImage.Location.StartsWith('/'))
                {
                    contentItem.Link.PreviewImage.Location = _astranaApiInfo.GetProxyEndpoint(AstranaContentType.Image, contentItem.Link.PreviewImage.Location);
                }

                if (contentItem.Image != null && contentItem.Image.Location.StartsWith('/'))
                {
                    contentItem.Image.Location = _astranaApiInfo.GetProxyEndpoint(AstranaContentType.Image, contentItem.Image.Location);
                }

                if (contentItem.Video != null && contentItem.Video.Location.StartsWith('/'))
                {
                    contentItem.Video.Location = _astranaApiInfo.GetProxyEndpoint(AstranaContentType.Video, contentItem.Video.Location);
                }

                if (contentItem.Audio != null && contentItem.Audio.Location.StartsWith('/'))
                {
                    contentItem.Audio.Location = _astranaApiInfo.GetProxyEndpoint(AstranaContentType.Audio, contentItem.Audio.Location);
                }
            }

            _logger.LogTrace($"Executed {nameof(GetContentCollectionsQuery).SplitOnUpperCase()}");

            return new GetResult<ContentCollectionQueryOptions<Guid, Guid>, ContentCollection, Guid, Guid>(result.Data, options, result.ResultSetCount, result.Message);
        }
    }
}