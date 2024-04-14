/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.TimeZones.Contracts;
using Astrana.Core.Domain.Models.TimeZones.Options;
using Astrana.Core.Domain.Models.Results.Contracts;
using TimeZone = Astrana.Core.Domain.Models.TimeZones.TimeZone;

namespace Astrana.Core.Data.Repositories.TimeZones
{
    public interface ITimeZoneRepository<TUserId> where TUserId : struct
    {
        Task<ICountResult> GetTimeZonesCountAsync(TimeZonesQueryOptions<Guid, TUserId>? queryOptions = null);

        Task<IGetResult<TimeZone>> GetTimeZonesAsync(TimeZonesQueryOptions<Guid, TUserId>? queryOptions = null);

        Task<IGetResult<TimeZone>> GetTimeZonesByCountryAsync(string countryTwoLetterCode);

        Task<TimeZone?> GetTimeZoneByIdAsync(Guid id);

        Task<IAddResult<List<TimeZone>>> CreateAsync(IEnumerable<ITimeZoneToAdd> requestedAdditions, TUserId actioningUserId, bool returnRecords = true);

        Task<IUpdateResult<List<TimeZone>>> UpdateAsync(IEnumerable<TimeZone> requestedUpdates, TUserId actioningUserId, bool returnRecords = true);

        Task<IDeleteResult<List<Guid>>> DeleteAsync(IEnumerable<Guid> validatedTimeZonesToRemoveIds, Guid actioningUserId);
    }
}
