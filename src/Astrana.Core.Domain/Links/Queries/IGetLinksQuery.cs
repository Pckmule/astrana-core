/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Links;
using Astrana.Core.Domain.Models.Links.Options;
using Astrana.Core.Domain.Models.Results;

namespace Astrana.Core.Domain.Links.Queries
{
    public interface IGetLinksQuery
    {
        Task<GetResult<LinkQueryOptions<Guid, Guid>, Link, Guid, Guid>> ExecuteAsync(Guid actioningUserId, LinkQueryOptions<Guid, Guid> options = null);
    }
}