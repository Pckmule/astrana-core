/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using TopLevelDomainDataEntity = Astrana.Core.Data.Entities.Configuration.TopLevelDomain;
using TopLevelDomainDomainEntity = Astrana.Core.Domain.Models.TopLevelDomains.TopLevelDomain;

namespace Astrana.Core.Data.Entities.Configuration.ModelMappings
{
    public static class TopLevelDomain
    {
        public static TopLevelDomainDomainEntity MapToDomainModel(TopLevelDomainDataEntity audienceDataEntity)
        {
            var domainModel = new TopLevelDomainDomainEntity
            {
                TopLevelDomainId = audienceDataEntity.TopLevelDomainId,

                Domain = audienceDataEntity.Domain,
                
                Country = Country.MapToDomainModel(audienceDataEntity.Country),
                
                IsImplemented = audienceDataEntity.IsImplemented,

                DeactivatedReason = audienceDataEntity.DeactivatedReason,
                DeactivatedBy = audienceDataEntity.DeactivatedBy,
                DeactivatedTimestamp = audienceDataEntity.DeactivatedTimestamp,

                CreatedBy = audienceDataEntity.CreatedBy,
                CreatedTimestamp = audienceDataEntity.CreatedTimestamp,

                LastModifiedBy = audienceDataEntity.LastModifiedBy,
                LastModifiedTimestamp = audienceDataEntity.LastModifiedTimestamp
            };

            return domainModel;
        }
    }
}
