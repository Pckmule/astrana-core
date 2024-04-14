using Astrana.Core.Domain.Models.MainFeed;
using Astrana.Core.Domain.Models.MainFeed.Options;
using Astrana.Core.Domain.Models.Results;

namespace Astrana.Core.Domain.MainFeed.Commands.ComposeFeed
{
    public interface IComposeFeedCommand
    {
        Task<GetResult<MainFeedQueryOptions<Guid, Guid>, FeedContentItem, Guid, Guid>> ExecuteAsync(MainFeedQueryOptions<Guid, Guid> options, Guid actioningUserId);
    }
}