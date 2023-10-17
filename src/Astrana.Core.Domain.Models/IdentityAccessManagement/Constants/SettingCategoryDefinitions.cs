/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.SystemSettings;

namespace Astrana.Core.Domain.Models.IdentityAccessManagement.Constants
{
    public static class SettingCategoryDefinitions
    {
        public static class Names
        {
            public const string AccessControl = "Access Control";
        }

        public static List<SystemSettingCategory> Register(List<SystemSettingCategory> settingCategories)
        {
            settingCategories.Add(new SystemSettingCategory
            {
                Name = Names.AccessControl,
                NameTrxCode = "setting_category_" + Names.AccessControl.Replace(" ", "_").ToLower(),
                Description = "Settings relating to rights and permissions for system access.",
                DescriptionTrxCode = "setting_category_description_" + Names.AccessControl.Replace(" ", "_").ToLower()
            });

            return settingCategories;
        }
    }
}
