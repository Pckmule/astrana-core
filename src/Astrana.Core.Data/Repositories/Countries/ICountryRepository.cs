/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Countries;
using Astrana.Core.Domain.Models.Countries.Contracts;
using Astrana.Core.Domain.Models.Countries.Options;
using Astrana.Core.Domain.Models.Results.Contracts;

namespace Astrana.Core.Data.Repositories.Countries
{
    public interface ICountryRepository<TUserId> where TUserId : struct
    {
        Task<ICountResult> GetCountriesCountAsync(CountryQueryOptions<long, TUserId>? queryOptions = null);

        Task<IGetResult<Country>> GetCountriesAsync(CountryQueryOptions<long, TUserId>? queryOptions = null);

        Task<Country?> GetCountryByIdAsync(long id);

        Task<Country?> GetCountryByCodeAsync(string code);

        Task<IAddResult<List<Country>>> CreateAsync(IEnumerable<ICountryToAdd> requestedAdditions, TUserId actioningUserId, bool returnRecords = true);

        Task<IUpdateResult<List<Country>>> UpdateAsync(IEnumerable<Country> requestedUpdates, TUserId actioningUserId, bool returnRecords = true);

        Task<IDeleteResult<List<long>>> DeleteAsync(IEnumerable<long> validatedCountriesToRemoveIds, Guid actioningUserId);
    }
}
