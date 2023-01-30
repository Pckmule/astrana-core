/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.System.Enums;
using Astrana.Core.Domain.Models.SystemSettings;

namespace Astrana.Core.Domain.Models.IdentityAccessManagement.Constants
{
    public static class SettingDefinitions
    {
        public static class Names
        {
            public const string MultiFactorAuthentication = "Multi-factor Authentication";
        }

        public static List<SystemSetting> Register(List<SystemSetting> settings)
        {
            settings.Add(new SystemSetting
            {
                Name = Names.MultiFactorAuthentication,
                DataType = SystemDataType.Boolean,
                DefaultValue = "0",
                ShortDescription = "Turn multi-factor authentication on/off.",
                HelpText = null,
                UserMaySet = true
            });

            return settings;
        }
    }
}
