/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Repositories.Posts;
using Astrana.Core.Domain.Models.Posts;
using Astrana.Core.Domain.Models.Posts.Options;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Utilities;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.Domain.Posts.Queries
{
    public class GetPostsQuery : IGetPostsQuery
    {
        private readonly ILogger<GetPostsQuery> _logger;
        private readonly IPostRepository<Guid> _postRepository;

        public GetPostsQuery(ILogger<GetPostsQuery> logger, IPostRepository<Guid> postRepository)
        {
            _logger = logger;
            _postRepository = postRepository;
        }

        public async Task<GetResult<PostQueryOptions<long, Guid>, Post, long, Guid>> ExecuteAsync(Guid actioningUserId, PostQueryOptions<long, Guid>? options = null)
        {
            options ??= new PostQueryOptions<long, Guid>();

            var result = await _postRepository.GetPostsAsync(options);

            _logger.LogTrace($"Executed {nameof(GetPostsQuery).SplitOnUpperCase()}");

            return new GetResult<PostQueryOptions<long, Guid>, Post, long, Guid>(result.Data, options, result.ResultSetCount, result.Message);
        }
    }
}