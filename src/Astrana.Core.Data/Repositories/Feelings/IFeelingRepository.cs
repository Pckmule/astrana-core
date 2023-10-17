/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Feelings;
using Astrana.Core.Domain.Models.Feelings.Contracts;
using Astrana.Core.Domain.Models.Feelings.Options;
using Astrana.Core.Domain.Models.Results.Contracts;

namespace Astrana.Core.Data.Repositories.Feelings
{
    public interface IFeelingRepository<TUserId> where TUserId : struct
    {
        Task<ICountResult> GetFeelingsCountAsync(FeelingsQueryOptions<Guid, TUserId>? queryOptions = null);

        Task<IGetResult<Feeling>> GetFeelingsAsync(FeelingsQueryOptions<Guid, TUserId>? queryOptions = null);

        Task<Feeling?> GetFeelingByIdAsync(Guid id);

        Task<IAddResult<List<Feeling>>> CreateAsync(IEnumerable<IFeelingToAdd> requestedAdditions, TUserId actioningUserId, bool returnRecords = true);

        Task<IUpdateResult<List<Feeling>>> UpdateAsync(IEnumerable<Feeling> requestedUpdates, TUserId actioningUserId, bool returnRecords = true);

        Task<IDeleteResult<List<Guid>>> DeleteAsync(IEnumerable<Guid> validatedFeelingsToRemoveIds, Guid actioningUserId);
    }
}
