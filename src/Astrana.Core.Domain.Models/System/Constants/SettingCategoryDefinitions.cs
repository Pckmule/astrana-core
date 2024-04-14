/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.SystemSettings;

namespace Astrana.Core.Domain.Models.System.Constants
{
    public static class SettingCategoryDefinitions
    {
        public static class Names
        {
            public const string Instance = "Instance";
            public const string Security = "Security";
            public const string Localization = "Localization";
            public const string Personalization = "Personalization";
        }

        private static readonly IReadOnlyList<SystemSettingCategory> Definitions = new List<SystemSettingCategory>
        {
            new()
            {
                SystemSettingCategoryId = new Guid("f71b0459-44ab-499e-b5d7-afca31ab19b5"),
                Name = Names.Instance,
                NameTrxCode = GetTrxCode(Names.Instance),
                Description = "Instance settings.",
                DescriptionTrxCode = GetTrxCode(Names.Instance, "description")
            },

            new()
            {
                SystemSettingCategoryId = new Guid("edcbb17e-d9ee-481d-b79c-340858cff353"),
                Name = Names.Security,
                NameTrxCode = GetTrxCode(Names.Security),
                Description = "Security settings.",
                DescriptionTrxCode = GetTrxCode(Names.Security, "description")
            },

            new()
            {
                SystemSettingCategoryId = new Guid("e031d3cb-b5f7-4267-b373-d70996e70828"),
                Name = Names.Localization,
                NameTrxCode = GetTrxCode(Names.Localization),
                Description = "Localization settings.",
                DescriptionTrxCode = GetTrxCode(Names.Localization, "description")
            },

            new()
            {
                SystemSettingCategoryId = new Guid("083ea747-18db-4048-9a8f-96aa6ded38c4"),
                Name = Names.Personalization,
                NameTrxCode = GetTrxCode(Names.Personalization),
                Description = "Personalization settings.",
                DescriptionTrxCode = GetTrxCode(Names.Personalization, "description")
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

        private static string GetTrxCode(string name, string? prefix = null)
        {
            return "system_setting_category_" + (string.IsNullOrWhiteSpace(prefix) ? "" : prefix + "_") + name.Replace(" ", "_").ToLower();
        }
    }
}
