using Astrana.Core.Domain.Models.Posts;
using Astrana.Core.Domain.Models.Results;

namespace Astrana.Core.Domain.Posts.Commands.CreatePosts
{
    public interface ICreatePostsCommand
    {
        Task<AddResult<List<Post>>> ExecuteAsync(IList<PostToAdd> postsToAdd, Guid actioningUserId);
    }
}
