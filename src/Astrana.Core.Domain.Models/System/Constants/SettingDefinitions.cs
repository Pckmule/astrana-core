/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.System.Enums;
using Astrana.Core.Domain.Models.SystemSettings;

namespace Astrana.Core.Domain.Models.System.Constants
{
    public static class SettingDefinitions
    {
        public static class Names
        {
            public const string RegionalFormat = "Regional Format";
            public const string LanguageCode = "Language Code";
            public const string TimeZone = "Time Zone";

            public const string HostName = "Host Name";
            public const string HostPortNumber = "Host Port Number";
            public const string IdpIssuerSigningKeySecret = "Idp Issuer Signing Key Secret";
        }

        public static List<SystemSetting> Register(List<SystemSetting> settings)
        {
            settings.Add(new SystemSetting
            {
                Name = Names.RegionalFormat,
                DataType = SystemDataType.Text,
                DefaultValue = "AU",
                ShortDescription = "Formats for dates, times and numbers.",
                HelpText = null,
                UserMaySet = true
            });

            settings.Add(new SystemSetting
            {
                Name = Names.LanguageCode,
                DataType = SystemDataType.Text,
                DefaultValue = "EN",
                ShortDescription = "The language code of the Astrana instance user.",
                HelpText = null,
                UserMaySet = true
            });

            settings.Add(new SystemSetting
            {
                Name = Names.TimeZone,
                DataType = SystemDataType.Text,
                DefaultValue = TimeZoneInfo.Local.StandardName,
                ShortDescription = "The time zone of the Astrana instance user.",
                HelpText = null,
                UserMaySet = true
            });

            settings.Add(new SystemSetting
            {
                Name = Names.HostName,
                DataType = SystemDataType.Text,
                DefaultValue = "localhost",
                ShortDescription = "The address of the Astrana instance.",
                HelpText = null,
                UserMaySet = true
            });

            settings.Add(new SystemSetting
            {
                Name = Names.HostPortNumber,
                DataType = SystemDataType.Text,
                DefaultValue = "",
                ShortDescription = "The host port number of the Astrana instance.",
                HelpText = null,
                UserMaySet = true
            });

            settings.Add(new SystemSetting
            {
                Name = Names.IdpIssuerSigningKeySecret,
                DataType = SystemDataType.Text,
                DefaultValue = "",
                Value = "69473DFCE4E2D15A343495F3612FBD2C69473DFCE4E2D15A343495F3612FBD2C", // TODO: Generate on Setup
                ShortDescription = "The secret used for generating the Idp Issuer Signing Key for the Astrana instance.",
                HelpText = null,
                UserMaySet = true
            });

            return settings;
        }
    }
}
