using Astrana.Core.Domain.Models.Posts;
using Astrana.Core.Domain.Models.Results;

namespace Astrana.Core.Domain.Posts.Commands.UpdatePosts
{
    public interface IUpdatePostsCommand
    {
        Task<UpdateResult<List<Post>>> ExecuteAsync(IList<Post> postsToUpdate, Guid actioningUserId);
    }
}