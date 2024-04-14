/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.MainFeed;
using Astrana.Core.Domain.Models.MainFeed.Options;
using Astrana.Core.Domain.Models.Results;

namespace Astrana.Core.Domain.MainFeed.Queries
{
    public interface IGetMainFeedQuery
    {
        Task<GetResult<MainFeedQueryOptions<long, Guid>, FeedContentItem, long, Guid>> ExecuteAsync(Guid actioningUserId, MainFeedQueryOptions<long, Guid> options = null);
    }
}