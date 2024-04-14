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

        private static readonly IReadOnlyList<SystemSettingCategory> Definitions = new List<SystemSettingCategory>
        {
            new()
            {
                SystemSettingCategoryId = new Guid("7dc564b5-9cc9-459e-987a-695fbfcab4a0"),
                Name = Names.AccessControl,
                NameTrxCode = GetTrxCode(Names.AccessControl),
                Description = "Settings relating to rights and permissions for system access.",
                DescriptionTrxCode = "setting_category_description_" + Names.AccessControl.Replace(" ", "_").ToLower()
            }
        };

        public static List<SystemSettingCategory> Register(List<SystemSettingCategory> settingCategories)
        {
            settingCategories.AddRange(Definitions);

            return settingCategories;
        }

        public static SystemSettingCategory? FindByName(string name)
        {
            return Definitions.FirstOrDefault(o => o.Name == name);
        }

        private static string GetTrxCode(string name)
        {
            return "system_setting_category_" + name.Replace(" ", "_").ToLower();
        }
    }
}
