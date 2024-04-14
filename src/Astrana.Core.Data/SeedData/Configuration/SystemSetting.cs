/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Constants;
using Microsoft.EntityFrameworkCore;
using SystemSetting = Astrana.Core.Data.Entities.Configuration.SystemSetting;
using SystemSettingDomainModel = Astrana.Core.Domain.Models.SystemSettings.SystemSetting;

namespace Astrana.Core.Data.SeedData.Configuration
{
    public static class SystemSettingSeedData
    {
        public static IReadOnlyList<SystemSetting> GetSystemSettings()
        {
            var systemSettings = new List<SystemSettingDomainModel>();

            Domain.Models.System.Constants.SettingDefinitions.Register(systemSettings);
            Domain.Models.IdentityAccessManagement.Constants.SettingDefinitions.Register(systemSettings);

            return systemSettings.Select(o => new SystemSetting
            {
                SystemSettingId = o.Id,

                Name = o.Name,
                NameTrxCode = o.NameTrxCode,
                
                DataType = o.DataType,

                DefaultValue = o.DefaultValue,
                Value = o.Value,
                ValueChoicesLookupName = o.ValueChoicesLookupName,

                ShortDescription = o.ShortDescription,
                ShortDescriptionTrxCode = o.ShortDescriptionTrxCode,

                HelpText = o.HelpText,
                HelpTextTrxCode = o.HelpTextTrxCode,

                MinimumValueLength = o.MinimumValueLength,
                MaximumValueLength = o.MaximumValueLength,

                MinimumValues = o.MinimumValues,
                MaximumValues = o.MaximumValues,
                
                UserMaySet = o.UserMaySet,
                
                SettingCategoryId = o.SystemSettingCategoryId,

                CreatedBy = SystemUser.IdGuid,
                CreatedTimestamp = new DateTimeOffset(2023, 11, 21, 0, 0, 0, new TimeSpan()),
                LastModifiedBy = SystemUser.IdGuid,
                LastModifiedTimestamp = new DateTimeOffset(2023, 11, 21, 0, 0, 0, new TimeSpan())

            }).ToList();
        }

        public static SystemSetting? FindById(Guid entityId)
        {
            return GetSystemSettings().FirstOrDefault(o => o.SystemSettingId == entityId);
        }

        public static void AddSystemSettingData(this ModelBuilder model)
        {
            model.Entity<SystemSetting>().HasData(GetSystemSettings());
        }
    }
}
