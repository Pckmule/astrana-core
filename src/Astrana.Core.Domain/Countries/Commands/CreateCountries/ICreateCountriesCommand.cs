/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Countries;
using Astrana.Core.Domain.Models.Results;

namespace Astrana.Core.Domain.Countries.Commands.CreateCountries
{
    public interface ICreateCountriesCommand
    {
        Task<AddResult<List<Country>>> ExecuteAsync(IList<CountryToAdd> countriesToAdd, Guid actioningUserId);
    }
}
