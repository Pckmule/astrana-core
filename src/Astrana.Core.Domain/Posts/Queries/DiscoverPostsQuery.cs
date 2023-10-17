/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Posts.Options;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Posts.Repositories;
using Astrana.Core.Utilities;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.Domain.Posts.Queries
{
    public class DiscoverPostsQuery : IDiscoverPostsQuery
    {
        private readonly ILogger<DiscoverPostsQuery> _logger;
        private readonly IPostRepository<Guid> _postRepository;

        public DiscoverPostsQuery(ILogger<DiscoverPostsQuery> logger, IPostRepository<Guid> postRepository)
        {
            _logger = logger;
            _postRepository = postRepository;
        }

        public async Task<CountResult> ExecuteAsync(Guid actioningUserId, PostQueryOptions<long, Guid>? options = null)
        {
            options ??= new PostQueryOptions<long, Guid>();

            var result = await _postRepository.GetPostsCountAsync(options);

            _logger.LogTrace($"Executed {nameof(DiscoverPostsQuery).SplitOnUpperCase()}");

            return (CountResult)result;
        }
    }
}