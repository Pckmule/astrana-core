using Astrana.Core.Domain.Models.Results;

namespace Astrana.Core.Domain.Posts.Commands.Handlers.DeletePosts
{
    public interface IDeletePostsCommandHandler
    {
        Task<DeleteResult<List<long>>> ExecuteAsync(IList<long> postsToDeleteIds, Guid actioningUserId);
    }
}