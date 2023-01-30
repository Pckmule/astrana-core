/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Posts;
using Astrana.Core.Domain.Models.Posts.Contracts;
using Astrana.Core.Domain.Models.Posts.Options;
using Astrana.Core.Domain.Models.Results.Contracts;

namespace Astrana.Core.Data.Repositories.Posts
{
    public interface IPostRepository<TUserId> where TUserId : struct
    {
        Task<ICountResult> GetPostsCountAsync(PostQueryOptions<long, TUserId>? queryOptions = null);

        Task<IGetResult<Post>> GetPostsAsync(PostQueryOptions<long, TUserId>? queryOptions = null);

        Task<Post?> GetPostByIdAsync(long id);
        
        Task<IAddResult<List<Post>>> CreateAsync(IEnumerable<IPostToAdd> requestedAdditions, TUserId actioningUserId, bool returnRecords = true);

        Task<IUpdateResult<List<Post>>> UpdateAsync(IEnumerable<IPost> requestedUpdates, TUserId actioningUserId, bool returnRecords = true);
        
        Task<IDeleteResult<List<long>>> DeleteAsync(IEnumerable<long> validatedPostsToRemoveIds, Guid actioningUserId);
    }
}
