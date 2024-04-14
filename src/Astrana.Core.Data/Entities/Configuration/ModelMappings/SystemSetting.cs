/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using SystemSettingDataEntity = Astrana.Core.Data.Entities.Configuration.SystemSetting;
using SystemSettingDomainEntity = Astrana.Core.Domain.Models.SystemSettings.SystemSetting;

namespace Astrana.Core.Data.Entities.Configuration.ModelMappings
{
    public static class SystemSetting
    {
        public static SystemSettingDomainEntity MapToDomainModel(SystemSettingDataEntity audienceDataEntity)
        {
            var domainModel = new SystemSettingDomainEntity
            {
                SystemSettingId = audienceDataEntity.SystemSettingId,

                Name = audienceDataEntity.Name,
                NameTrxCode = audienceDataEntity.NameTrxCode,

                DataType = audienceDataEntity.DataType,

                ShortDescription = audienceDataEntity.ShortDescription,
                ShortDescriptionTrxCode = audienceDataEntity.ShortDescriptionTrxCode,

                HelpText = audienceDataEntity.HelpText,
                HelpTextTrxCode = audienceDataEntity.HelpTextTrxCode,

                DefaultValue = audienceDataEntity.DefaultValue,
                Value = audienceDataEntity.Value,
                ValueChoicesLookupName = audienceDataEntity.ValueChoicesLookupName,

                MaximumValues = audienceDataEntity.MaximumValues,
                MinimumValues = audienceDataEntity.MinimumValues,

                MinimumValueLength = audienceDataEntity.MinimumValueLength,
                MaximumValueLength = audienceDataEntity.MaximumValueLength,

                UserMaySet = audienceDataEntity.UserMaySet,

                CreatedBy = audienceDataEntity.CreatedBy,
                CreatedTimestamp = audienceDataEntity.CreatedTimestamp,

                LastModifiedBy = audienceDataEntity.LastModifiedBy,
                LastModifiedTimestamp = audienceDataEntity.LastModifiedTimestamp
            };

            return domainModel;
        }
    }
}
