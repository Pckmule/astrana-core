/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using TimeZoneDataEntity = Astrana.Core.Data.Entities.Configuration.TimeZone;
using TimeZoneDomainEntity = Astrana.Core.Domain.Models.TimeZones.TimeZone;

namespace Astrana.Core.Data.Entities.Configuration.ModelMappings
{
    public static class TimeZone
    {
        public static TimeZoneDomainEntity MapToDomainModel(TimeZoneDataEntity timeZoneDataEntity)
        {
            var domainModel = new TimeZoneDomainEntity
            {
                TimeZoneId = timeZoneDataEntity.TimeZoneId,

                Name = timeZoneDataEntity.Name,
                NameTrxCode = timeZoneDataEntity.NameTrxCode,
                
                Abbreviation = timeZoneDataEntity.Abbreviation,
                CorrespondingUtcZone = timeZoneDataEntity.CorrespondingUtcZone,
                DaylightSavingApplies = timeZoneDataEntity.DaylightSavingApplies,

                Countries = timeZoneDataEntity.Countries.Select(Country.MapToDomainModel).ToHashSet(),

                CreatedBy = timeZoneDataEntity.CreatedBy,
                CreatedTimestamp = timeZoneDataEntity.CreatedTimestamp,

                LastModifiedBy = timeZoneDataEntity.LastModifiedBy,
                LastModifiedTimestamp = timeZoneDataEntity.LastModifiedTimestamp
            };

            return domainModel;
        }
    }
}
