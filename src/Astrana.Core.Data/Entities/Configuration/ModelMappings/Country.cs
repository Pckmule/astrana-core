/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using CountryDataEntity = Astrana.Core.Data.Entities.Configuration.Country;
using CountryDomainEntity = Astrana.Core.Domain.Models.Countries.Country;

namespace Astrana.Core.Data.Entities.Configuration.ModelMappings
{
    public static class Country
    {
        public static CountryDomainEntity MapToDomainModel(CountryDataEntity countryDataEntity)
        {
            var domainModel = new CountryDomainEntity
            {
                CountryId = countryDataEntity.CountryId,

                Name = countryDataEntity.Name,
                NameTrxCode = countryDataEntity.NameTrxCode,

                TwoLetterCode = countryDataEntity.TwoLetterCode,
                ThreeLetterCode = countryDataEntity.ThreeLetterCode,

                DeactivatedReason = countryDataEntity.DeactivatedReason,
                DeactivatedBy = countryDataEntity.DeactivatedBy,
                DeactivatedTimestamp = countryDataEntity.DeactivatedTimestamp,

                CreatedBy = countryDataEntity.CreatedBy,
                CreatedTimestamp = countryDataEntity.CreatedTimestamp,

                LastModifiedBy = countryDataEntity.LastModifiedBy,
                LastModifiedTimestamp = countryDataEntity.LastModifiedTimestamp
            };

            return domainModel;
        }
    }
}
