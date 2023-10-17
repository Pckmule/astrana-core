/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.ExternalFeeds;
using Astrana.Core.Domain.Models.ExternalFeeds.Options;
using Astrana.Core.Domain.Models.Results;

namespace Astrana.Core.Domain.ExternalFeeds.Queries
{
    public interface IGetRssFeedQuery
    {
        Task<GetResult<RssFeedQueryOptions<Guid, Guid>, RssFeed, Guid, Guid>> ExecuteAsync(Guid actioningUserId, RssFeedQueryOptions<Guid, Guid> options = null);
    }
}