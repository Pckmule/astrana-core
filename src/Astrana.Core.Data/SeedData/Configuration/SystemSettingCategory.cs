/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Constants;
using Microsoft.EntityFrameworkCore;
using SystemSettingCategory = Astrana.Core.Data.Entities.Configuration.SystemSettingCategory;
using SystemSettingCategoryDomainModel = Astrana.Core.Domain.Models.SystemSettings.SystemSettingCategory;

namespace Astrana.Core.Data.SeedData.Configuration
{
    public static class SystemSettingCategorySeedData
    {
        public static IReadOnlyList<SystemSettingCategory> GetSystemSettingCategories()
        {
            var systemSettingCategories = new List<SystemSettingCategoryDomainModel>();

            Domain.Models.System.Constants.SettingCategoryDefinitions.Register(systemSettingCategories);
            Domain.Models.IdentityAccessManagement.Constants.SettingCategoryDefinitions.Register(systemSettingCategories);

            return systemSettingCategories.Select(o => new SystemSettingCategory
            {
                SystemSettingCategoryId = o.Id,
                Name = o.Name,
                NameTrxCode = o.NameTrxCode,
                Description = o.Description,
                DescriptionTrxCode =  o.DescriptionTrxCode,
                CreatedBy = SystemUser.IdGuid,
                CreatedTimestamp = new DateTimeOffset(2023, 11, 21, 0, 0, 0, new TimeSpan()),
                LastModifiedBy = SystemUser.IdGuid,
                LastModifiedTimestamp = new DateTimeOffset(2023, 11, 21, 0, 0, 0, new TimeSpan())

            }).ToList();
        }

        public static SystemSettingCategory? FindById(Guid entityId)
        {
            return GetSystemSettingCategories().FirstOrDefault(o => o.SystemSettingCategoryId == entityId);
        }

        public static void AddSystemSettingCategoryData(this ModelBuilder model)
        {
            model.Entity<SystemSettingCategory>().HasData(GetSystemSettingCategories());
        }
    }
}
