/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Posts;
using Astrana.Core.Domain.Models.Posts.Options;
using Astrana.Core.Domain.Models.Results;

namespace Astrana.Core.Domain.Posts.Queries
{
    public interface IGetPostsQuery
    {
        Task<GetResult<PostQueryOptions<long, Guid>, Post, long, Guid>> ExecuteAsync(Guid actioningUserId, PostQueryOptions<long, Guid> options = null);
    }
}