using Astrana.Core.Domain.Posts.Repositories;
using Astrana.Core.Domain.Models.ExternalFeeds;
using Astrana.Core.Domain.Models.ExternalFeeds.Options;
using Astrana.Core.Domain.Models.Posts.Options;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Utilities;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.Domain.ExternalFeeds.Queries
{
    public class GetRssFeedQuery : IGetRssFeedQuery
    {
        private readonly ILogger<GetRssFeedQuery> _logger;
        private readonly IPostRepository<Guid> _postRepository;

        public GetRssFeedQuery(ILogger<GetRssFeedQuery> logger, IPostRepository<Guid> postRepository)
        {
            _logger = logger;
            _postRepository = postRepository;
        }

        public async Task<GetResult<RssFeedQueryOptions<Guid, Guid>, RssFeed, Guid, Guid>> ExecuteAsync(Guid actioningUserId, RssFeedQueryOptions<Guid, Guid>? options = null)
        {
            options ??= new RssFeedQueryOptions<Guid, Guid>();

            var postOptions = new PostQueryOptions<Guid, Guid>();

            // var result = await _postRepository.GetPostsAsync(postOptions);

            var result = new List<RssFeed>();

            _logger.LogTrace($"Executed {nameof(GetRssFeedQuery).SplitOnUpperCase()}");

            return new GetResult<RssFeedQueryOptions<Guid, Guid>, RssFeed, Guid, Guid>(null, options, 1, "result.Message");
        }

        private static async Task<string> GetRssFeedContentAsync(Uri url)
        {
            try
            {
                var client = new HttpClient();

                client.DefaultRequestHeaders.UserAgent.ParseAdd(Constants.Application.UserAgentString);

                using var response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                // ignored
            }

            return string.Empty;
        }
    }
}