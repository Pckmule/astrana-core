/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Comments;
using Astrana.Core.Domain.Models.Comments.Options;
using Astrana.Core.Domain.Models.Results;

namespace Astrana.Core.Domain.Comments.Queries
{
    public interface IGetCommentsQuery
    {
        Task<GetResult<CommentQueryOptions<Guid, Guid>, Comment, Guid, Guid>> ExecuteAsync(Guid actioningUserId, CommentQueryOptions<Guid, Guid> options = null);
    }
}