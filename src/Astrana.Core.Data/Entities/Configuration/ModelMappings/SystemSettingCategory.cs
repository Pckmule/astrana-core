/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using SystemSettingCategoryDataEntity = Astrana.Core.Data.Entities.Configuration.SystemSettingCategory;
using SystemSettingCategoryDomainEntity = Astrana.Core.Domain.Models.SystemSettings.SystemSettingCategory;

namespace Astrana.Core.Data.Entities.Configuration.ModelMappings
{
    public static class SystemSettingCategory
    {
        public static SystemSettingCategoryDomainEntity MapToDomainModel(SystemSettingCategoryDataEntity audienceDataEntity)
        {
            var domainModel = new SystemSettingCategoryDomainEntity
            {
                SystemSettingCategoryId = audienceDataEntity.SystemSettingCategoryId,

                Name = audienceDataEntity.Name,
                NameTrxCode = audienceDataEntity.NameTrxCode,

                Description = audienceDataEntity.Description,
                DescriptionTrxCode = audienceDataEntity.DescriptionTrxCode,

                // LastModifiedBy = audienceDataEntity.LastModifiedBy,
                // LastModifiedTimestamp = audienceDataEntity.LastModifiedTimestamp
            };

            return domainModel;
        }
    }
}
