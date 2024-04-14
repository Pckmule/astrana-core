/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using AudienceDataEntity = Astrana.Core.Data.Entities.Configuration.Audience;
using AudienceDomainEntity = Astrana.Core.Domain.Models.Audiences.Audience;

namespace Astrana.Core.Data.Entities.Configuration.ModelMappings
{
    public static class Audience
    {
        public static AudienceDomainEntity MapToDomainModel(AudienceDataEntity audienceDataEntity)
        {
            var domainModel = new AudienceDomainEntity
            {
                AudienceId = audienceDataEntity.AudienceId,

                Name = audienceDataEntity.Name,
                NameTrxCode = audienceDataEntity.NameTrxCode,

                Description = audienceDataEntity.Description,
                DescriptionTrxCode = audienceDataEntity.DescriptionTrxCode,

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
