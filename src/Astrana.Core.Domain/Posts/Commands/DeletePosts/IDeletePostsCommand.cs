using Astrana.Core.Domain.Models.Results;

namespace Astrana.Core.Domain.Posts.Commands.DeletePosts
{
    public interface IDeletePostsCommand
    {
        Task<DeleteResult<List<long>>> ExecuteAsync(IList<long> postsToDeleteIds, Guid actioningUserId);
    }
}