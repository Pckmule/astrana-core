/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using SkinToneDataEntity = Astrana.Core.Data.Entities.Configuration.SkinTone;
using SkinToneDomainEntity = Astrana.Core.Domain.Models.SkinTones.SkinTone;

namespace Astrana.Core.Data.Entities.Configuration.ModelMappings
{
    public static class SkinTone
    {
        public static SkinToneDomainEntity MapToDomainModel(SkinToneDataEntity skinToneDataEntity)
        {
            var domainModel = new SkinToneDomainEntity
            {
                SkinToneId = skinToneDataEntity.SkinToneId,

                Name = skinToneDataEntity.Name,
                NameTrxCode = skinToneDataEntity.NameTrxCode,

                ColorCode = skinToneDataEntity.ColorCode,

                Description = skinToneDataEntity.Description,
                DescriptionTrxCode = skinToneDataEntity.DescriptionTrxCode,

                CreatedBy = skinToneDataEntity.CreatedBy,
                CreatedTimestamp = skinToneDataEntity.CreatedTimestamp,

                LastModifiedBy = skinToneDataEntity.LastModifiedBy,
                LastModifiedTimestamp = skinToneDataEntity.LastModifiedTimestamp
            };

            return domainModel;
        }
    }
}
