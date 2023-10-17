/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.AudioClips;
using Astrana.Core.Domain.Models.AudioClips.Contracts;
using Astrana.Core.Domain.Models.AudioClips.Options;
using Astrana.Core.Domain.Models.Results.Contracts;

namespace Astrana.Core.Data.Repositories.Audios
{
    public interface IAudioRepository<TUserId> where TUserId : struct
    {
        Task<ICountResult> GetAudiosCountAsync(AudioQueryOptions<Guid, TUserId>? queryOptions = null);

        Task<IGetResult<Audio>> GetAudiosAsync(AudioQueryOptions<Guid, TUserId> queryOptions = null);

        Task<Audio?> GetAudioByIdAsync(Guid id);

        Task<IAddResult<List<Audio>>> CreateAsync(IEnumerable<IAudioToAdd> requestedAdditions, TUserId actioningUserId, bool returnRecords = true);

        Task<IUpdateResult<List<Audio>>> UpdateAsync(IEnumerable<Audio> requestedUpdates, TUserId actioningUserId, bool returnRecords = true);

        Task<IDeleteResult<List<Guid>>> DeleteAsync(IEnumerable<Guid> validatedAudiosToRemoveIds, Guid actioningUserId);
    }
}
