/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using FeelingDataEntity = Astrana.Core.Data.Entities.Content.Feeling;
using FeelingDomainEntity = Astrana.Core.Domain.Models.Feelings.Feeling;

namespace Astrana.Core.Data.Entities.Content.ModelMappings
{
    public static class Feeling
    {
        public static FeelingDomainEntity MapToDomainModel(FeelingDataEntity feelingDataEntity)
        {
            var domainModel = new FeelingDomainEntity
            {
                FeelingId = feelingDataEntity.FeelingId,

                Name = feelingDataEntity.Name,
                NameTrxCode = feelingDataEntity.NameTrxCode,
                
                IconName = feelingDataEntity.IconName,
                
                UnicodeIcon = feelingDataEntity.UnicodeIcon,
                ShortCode = feelingDataEntity.ShortCode,

                CreatedBy = feelingDataEntity.CreatedBy,
                CreatedTimestamp = feelingDataEntity.CreatedTimestamp,

                LastModifiedBy = feelingDataEntity.LastModifiedBy,
                LastModifiedTimestamp = feelingDataEntity.LastModifiedTimestamp,

                DeactivatedBy = feelingDataEntity.DeactivatedBy,
                DeactivatedTimestamp = feelingDataEntity.DeactivatedTimestamp,
                DeactivatedReason = feelingDataEntity.DeactivatedReason
            };

            return domainModel;
        }
    }
}
