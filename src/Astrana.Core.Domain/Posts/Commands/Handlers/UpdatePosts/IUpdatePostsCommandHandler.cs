using Astrana.Core.Domain.Models.Posts;
using Astrana.Core.Domain.Models.Results;

namespace Astrana.Core.Domain.Posts.Commands.Handlers.UpdatePosts
{
    public interface IUpdatePostsCommandHandler
    {
        Task<UpdateResult<List<Post>>> ExecuteAsync(IList<Post> postsToUpdate, Guid actioningUserId);
    }
}