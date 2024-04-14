/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using LocationDataEntity = Astrana.Core.Data.Entities.Content.Location;
using LocationDomainEntity = Astrana.Core.Domain.Models.Locations.Location;

namespace Astrana.Core.Data.Entities.Content.ModelMappings
{
    public static class Location
    {
        public static LocationDomainEntity MapToDomainModel(LocationDataEntity locationDataEntity)
        {
            var domainModel = new LocationDomainEntity
            {
                LocationId = locationDataEntity.LocationId,

                Name = locationDataEntity.Name,

                CreatedBy = locationDataEntity.CreatedBy,
                CreatedTimestamp = locationDataEntity.CreatedTimestamp,

                LastModifiedBy = locationDataEntity.LastModifiedBy,
                LastModifiedTimestamp = locationDataEntity.LastModifiedTimestamp
            };

            return domainModel;
        }
    }
}
