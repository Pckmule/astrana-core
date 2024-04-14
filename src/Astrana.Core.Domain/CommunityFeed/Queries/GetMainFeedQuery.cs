using Astrana.Core.Domain.Models.MainFeed;
using Astrana.Core.Domain.Models.MainFeed.Options;
using Astrana.Core.Domain.Models.Posts.Options;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Posts.Repositories;
using Astrana.Core.Utilities;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.Domain.MainFeed.Queries
{
    public class GetMainFeedQuery : IGetMainFeedQuery
    {
        private readonly ILogger<GetMainFeedQuery> _logger;
        private readonly IPostRepository<Guid> _postRepository;

        public GetMainFeedQuery(ILogger<GetMainFeedQuery> logger, IPostRepository<Guid> postRepository)
        {
            _logger = logger;
            _postRepository = postRepository;
        }

        public async Task<GetResult<MainFeedQueryOptions<long, Guid>, FeedContentItem, long, Guid>> ExecuteAsync(Guid actioningUserId, MainFeedQueryOptions<long, Guid>? options = null)
        {
            options ??= new MainFeedQueryOptions<long, Guid>();

            var postOptions = new PostQueryOptions<long,Guid>();

            var result = await _postRepository.GetPostsAsync(postOptions);

            _logger.LogTrace($"Executed {nameof(GetMainFeedQuery).SplitOnUpperCase()}");

            return new GetResult<MainFeedQueryOptions<long, Guid>, FeedContentItem, long, Guid>(null, options, result.ResultSetCount, result.Message);
        }
    }
}