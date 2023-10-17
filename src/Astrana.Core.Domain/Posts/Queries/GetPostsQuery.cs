/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Files.Queries.GetFileInfo;
using Astrana.Core.Domain.Models.AstranaApi.Contracts;
using Astrana.Core.Domain.Models.Posts;
using Astrana.Core.Domain.Models.Posts.Options;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.System.Enums;
using Astrana.Core.Domain.Posts.Repositories;
using Astrana.Core.Utilities;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.Domain.Posts.Queries
{
    public class GetPostsQuery : IGetPostsQuery
    {
        private readonly ILogger<GetPostsQuery> _logger;
        private readonly IAstranaApiInfo _astranaApiInfo;
        private readonly IGetFileInfoQuery _getFileInfoQuery;
        private readonly IPostRepository<Guid> _postRepository;

        public GetPostsQuery(ILogger<GetPostsQuery> logger, IAstranaApiInfo astranaApiInfo, IGetFileInfoQuery getFileInfoQuery, IPostRepository<Guid> postRepository)
        {
            _logger = logger;

            _astranaApiInfo = astranaApiInfo;
            _getFileInfoQuery = getFileInfoQuery;
            _postRepository = postRepository;
        }

        public async Task<GetResult<PostQueryOptions<long, Guid>, Post, long, Guid>> ExecuteAsync(Guid actioningUserId, PostQueryOptions<long, Guid>? options = null)
        {
            options ??= new PostQueryOptions<long, Guid>();

            var result = await _postRepository.GetPostsAsync(options);

            if (result.HasData)
            {
                foreach (var post in result.Data)
                {
                    foreach (var attachment in post.Attachments)
                    {
                        if (attachment.Link?.PreviewImage != null && attachment.Link.PreviewImage.Location.StartsWith('/'))
                        {
                            attachment.Link.PreviewImage.Location = _astranaApiInfo.GetProxyEndpoint(AstranaContentType.Image, attachment.Link.PreviewImage.Location);
                        }

                        if (attachment.Image != null && attachment.Image.Location.StartsWith('/'))
                        {
                            attachment.Image.Location = _astranaApiInfo.GetProxyEndpoint(AstranaContentType.Image, attachment.Image.Location);
                        }

                        if (attachment.Video != null && attachment.Video.Location.StartsWith('/'))
                        {
                            attachment.Video.Location = _astranaApiInfo.GetProxyEndpoint(AstranaContentType.Video, attachment.Video.Location);
                        }

                        if (attachment.Audio != null && attachment.Audio.Location.StartsWith('/'))
                        {
                            attachment.Audio.Location = _astranaApiInfo.GetProxyEndpoint(AstranaContentType.Audio, attachment.Audio.Location);
                        }

                        if (attachment.ContentCollection != null && attachment.ContentCollection.ContentItems != null && attachment.ContentCollection.ContentItems.Count > 0)
                        {
                            foreach (var contentCollectionContentItem in attachment.ContentCollection.ContentItems)
                            {
                                if (attachment.Link?.PreviewImage != null && attachment.Link.PreviewImage.Location.StartsWith('/'))
                                {
                                    attachment.Link.PreviewImage.Location = _astranaApiInfo.GetProxyEndpoint(AstranaContentType.Image, attachment.Link.PreviewImage.Location);
                                }

                                if (contentCollectionContentItem.Image != null && contentCollectionContentItem.Image.Location.StartsWith('/'))
                                {
                                    contentCollectionContentItem.Image.Location = _astranaApiInfo.GetProxyEndpoint(AstranaContentType.Image, contentCollectionContentItem.Image.Location);
                                }

                                if (contentCollectionContentItem.Video != null && contentCollectionContentItem.Video.Location.StartsWith('/'))
                                {
                                    contentCollectionContentItem.Video.Location = _astranaApiInfo.GetProxyEndpoint(AstranaContentType.Video, contentCollectionContentItem.Video.Location);
                                }

                                if (contentCollectionContentItem.Audio != null && contentCollectionContentItem.Audio.Location.StartsWith('/'))
                                {
                                    contentCollectionContentItem.Audio.Location = _astranaApiInfo.GetProxyEndpoint(AstranaContentType.Audio, contentCollectionContentItem.Audio.Location);
                                }
                            }
                        }
                    }
                }
            }

            _logger.LogTrace($"Executed {nameof(GetPostsQuery).SplitOnUpperCase()}");

            return new GetResult<PostQueryOptions<long, Guid>, Post, long, Guid>(result.Data, options, result.ResultSetCount, result.Message);
        }
    }
}