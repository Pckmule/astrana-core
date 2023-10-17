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
        }

        public static List<SystemSettingCategory> Register(List<SystemSettingCategory> settings)
        {
            settings.Add(new SystemSettingCategory
            {
                Name = Names.Instance,
                Description = "Instance settings."
            });

            return settings;
        }
    }
}
