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

            public const string DefaultSkinTone = "Default Skin Tone";
        }

        public static List<SystemSetting> Register(List<SystemSetting> settings)
        {
            settings.Add(new SystemSetting
            {
                SystemSettingId = new Guid("f40d10d2-48a1-4771-b30e-abd65bc2b53d"),
                Name = Names.RegionalFormat,
                NameTrxCode = GetTrxCode(Names.RegionalFormat),
                DataType = SystemDataType.Lookup,
                DefaultValue = "AU",
                ShortDescription = "Formats for dates, times and numbers.",
                HelpText = null,
                UserMaySet = true,
                SystemSettingCategoryId = SettingCategoryDefinitions.FindByName(SettingCategoryDefinitions.Names.Instance)?.Id
            });

            settings.Add(new SystemSetting
            {
                SystemSettingId = new Guid("214315b5-6109-40ca-b23b-4419b4369de7"),
                Name = Names.LanguageCode,
                NameTrxCode = GetTrxCode(Names.LanguageCode),
                DataType = SystemDataType.Lookup,
                DefaultValue = "EN",
                ShortDescription = "The language code of the Astrana instance user.",
                HelpText = null,
                UserMaySet = true,
                SystemSettingCategoryId = SettingCategoryDefinitions.FindByName(SettingCategoryDefinitions.Names.Instance)?.Id
            });

            settings.Add(new SystemSetting
            {
                SystemSettingId = new Guid("5fcf50f5-2d8a-4085-82c0-b0a6316b129f"),
                Name = Names.TimeZone,
                NameTrxCode = GetTrxCode(Names.TimeZone),
                DataType = SystemDataType.Text,
                DefaultValue = TimeZoneInfo.Local.StandardName,
                ShortDescription = "The time zone of the Astrana instance user.",
                HelpText = null,
                UserMaySet = true,
                SystemSettingCategoryId = SettingCategoryDefinitions.FindByName(SettingCategoryDefinitions.Names.Instance)?.Id
            });

            settings.Add(new SystemSetting
            {
                SystemSettingId = new Guid("64bd6c09-bd2e-47d9-92c3-a215fd30f342"),
                Name = Names.HostName,
                NameTrxCode = GetTrxCode(Names.HostName),
                DataType = SystemDataType.Text,
                DefaultValue = "localhost",
                ShortDescription = "The address of the Astrana instance.",
                HelpText = null,
                UserMaySet = true,
                SystemSettingCategoryId = SettingCategoryDefinitions.FindByName(SettingCategoryDefinitions.Names.Instance)?.Id
            });

            settings.Add(new SystemSetting
            {
                SystemSettingId = new Guid("8cf6f718-c898-4605-8e60-ae085b569f1d"),
                Name = Names.HostPortNumber,
                NameTrxCode = GetTrxCode(Names.HostPortNumber),
                DataType = SystemDataType.Number,
                DefaultValue = "",
                ShortDescription = "The host port number of the Astrana instance.",
                HelpText = null,
                UserMaySet = true,
                SystemSettingCategoryId = SettingCategoryDefinitions.FindByName(SettingCategoryDefinitions.Names.Instance)?.Id
            });

            settings.Add(new SystemSetting
            {
                SystemSettingId = new Guid("68c8d22a-85fd-4ace-918f-33b9949ba7bb"),
                Name = Names.IdpIssuerSigningKeySecret,
                NameTrxCode = GetTrxCode(Names.IdpIssuerSigningKeySecret),
                DataType = SystemDataType.Text,
                DefaultValue = "",
                Value = "69473DFCE4E2D15A343495F3612FBD2C69473DFCE4E2D15A343495F3612FBD2C", // TODO: Generate on Setup
                ShortDescription = "The secret used for generating the Idp Issuer Signing Key for the Astrana instance.",
                HelpText = null,
                UserMaySet = false,
                SystemSettingCategoryId = SettingCategoryDefinitions.FindByName(SettingCategoryDefinitions.Names.Instance)?.Id
            });

            settings.Add(new SystemSetting
            {
                SystemSettingId = new Guid("0e5df38d-9b2a-4263-8dd2-624b3391e0dc"),
                Name = Names.DefaultSkinTone,
                NameTrxCode = GetTrxCode(Names.DefaultSkinTone),
                DataType = SystemDataType.Lookup,
                DefaultValue = "",
                Value = null,
                ShortDescription = "The skin tone that represents the instance user.",
                HelpText = null,
                UserMaySet = true,
                SystemSettingCategoryId = SettingCategoryDefinitions.FindByName(SettingCategoryDefinitions.Names.Instance)?.Id
            });

            return settings;
        }

        private static string GetTrxCode(string name)
        {
            return "system_setting_" + name.Replace(" ", "_").ToLower();
        }
    }
}
