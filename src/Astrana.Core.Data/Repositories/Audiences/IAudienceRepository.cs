/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Audiences;
using Astrana.Core.Domain.Models.Audiences.Contracts;
using Astrana.Core.Domain.Models.Audiences.Options;
using Astrana.Core.Domain.Models.Results.Contracts;

namespace Astrana.Core.Data.Repositories.Audiences
{
    public interface IAudienceRepository<TUserId> where TUserId : struct
    {
        Task<ICountResult> GetAudiencesCountAsync(AudienceQueryOptions<Guid, TUserId>? queryOptions = null);

        Task<IGetResult<Audience>> GetAudiencesAsync(AudienceQueryOptions<Guid, TUserId> queryOptions = null);

        Task<Audience?> GetAudienceByIdAsync(Guid id);
        
        Task<IAddResult<List<Audience>>> CreateAsync(IEnumerable<IAudienceToAdd> requestedAdditions, TUserId actioningUserId, bool returnRecords = true);

        Task<IUpdateResult<List<Audience>>> UpdateAsync(IEnumerable<Audience> requestedUpdates, TUserId actioningUserId, bool returnRecords = true);

        Task<IDeleteResult<List<Guid>>> DeleteAsync(IEnumerable<Guid> validatedAudiencesToRemoveIds, Guid actioningUserId);
    }
}
