/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.SystemUpdates.DomainTransferObjects;
using Astrana.Core.Domain.Models.SystemUpdates.Options;

namespace Astrana.Core.Domain.SystemUpdates.Queries
{
    public interface IGetSystemUpdatesQuery
    {
        Task<GetResult<SystemUpdateQueryOptions<Guid, Guid>, SystemUpdateDto, Guid, Guid>> ExecuteAsync(Guid actioningUserId, SystemUpdateQueryOptions<Guid, Guid> options = null);
    }
}