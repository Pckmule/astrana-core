/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Comments;
using Astrana.Core.Domain.Models.Comments.Contracts;
using Astrana.Core.Domain.Models.Comments.Options;
using Astrana.Core.Domain.Models.Results.Contracts;

namespace Astrana.Core.Data.Repositories.Comments
{
    public interface ICommentRepository<TUserId> where TUserId : struct
    {
        Task<ICountResult> GetCommentsCountAsync(CommentQueryOptions<Guid, TUserId>? queryOptions = null);

        Task<IGetResult<Comment>> GetCommentsAsync(CommentQueryOptions<Guid, TUserId>? queryOptions = null);

        Task<Comment?> GetCommentByIdAsync(Guid id);
        
        Task<IAddResult<List<Comment>>> CreateAsync(IEnumerable<Comment> requestedAdditions, TUserId actioningUserId, bool returnRecords = true);

        Task<IUpdateResult<List<Comment>>> UpdateAsync(IEnumerable<IComment> requestedUpdates, TUserId actioningUserId, bool returnRecords = true);
        
        Task<IDeleteResult<List<Guid>>> DeleteAsync(IEnumerable<Guid> validatedCommentsToRemoveIds, Guid actioningUserId);
    }
}
