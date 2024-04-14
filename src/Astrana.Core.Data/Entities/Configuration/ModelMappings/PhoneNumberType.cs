/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using PhoneNumberTypeDataEntity = Astrana.Core.Data.Entities.Configuration.PhoneNumberType;
using PhoneNumberTypeDomainEntity = Astrana.Core.Domain.Models.PhoneNumberTypes.PhoneNumberType;

namespace Astrana.Core.Data.Entities.Configuration.ModelMappings
{
    public static class PhoneNumberType
    {
        public static PhoneNumberTypeDomainEntity MapToDomainModel(PhoneNumberTypeDataEntity audienceDataEntity)
        {
            var domainModel = new PhoneNumberTypeDomainEntity
            {
                PhoneNumberTypeId = audienceDataEntity.PhoneNumberTypeId,

                Name = audienceDataEntity.Name,
                Code = audienceDataEntity.Code,

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
