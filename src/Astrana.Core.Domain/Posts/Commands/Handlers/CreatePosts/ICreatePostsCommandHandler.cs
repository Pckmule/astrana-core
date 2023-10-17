using Astrana.Core.Domain.Models.Posts;
using Astrana.Core.Domain.Models.Posts.DomainTransferObjects;
using Astrana.Core.Domain.Models.Results;

namespace Astrana.Core.Domain.Posts.Commands.Handlers.CreatePosts
{
    public interface ICreatePostsCommandHandler
    {
        Task<AddResult<List<Post>>> ExecuteAsync(IList<PostDto> postsToAddDtos, Guid actioningUserId);
    }
}
