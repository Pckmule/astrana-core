/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Attributes;
using Astrana.Core.Domain.Models.Lookups;
using Astrana.Core.Localization.Attributes;
using Astrana.Core.Utilities;
using System.ComponentModel;
using System.Reflection;

namespace Astrana.Core.Domain.Lookups.Convertors
{
    public static class EnumToLookupConvertor
    {
        public static LookupDto ConvertToLookup(Type enumType)
        {
            var fields = enumType.GetFields();

            var lookupDisplayAttributes = GetAttributes<DisplayNameAttribute>(enumType);
            var lookupDescriptionAttributes = GetAttributes<DescriptionAttribute>(enumType);
            var lookupTranslationCodeAttribute = GetAttributes<TranslationCodeAttribute>(enumType);
            var lookupIconNameAttribute = GetAttributes<IconNameAttribute>(enumType);
            var lookupIconAddressAttribute = GetAttributes<IconAddressAttribute>(enumType);
            var lookupTrxCode = lookupTranslationCodeAttribute.Length > 0 ? lookupTranslationCodeAttribute[0].TrxCode : "";

            var lookupLabel = lookupDisplayAttributes.Length > 0 ? lookupDisplayAttributes[0].DisplayName : lookupDescriptionAttributes.Length > 0 ? lookupDescriptionAttributes[0].Description : enumType.Name.SplitOnUpperCase();
            var lookupIconName = lookupIconNameAttribute.Length > 0 ? lookupIconNameAttribute[0].Name : null;
            var lookupIconAddress = lookupIconAddressAttribute.Length > 0 ? lookupIconAddressAttribute[0].Address : null;

            var lookup = new LookupDto(lookupLabel, lookupTrxCode, lookupIconName, lookupIconAddress);

            foreach (var field in fields)
            {
                try
                {
                    var displayAttributes = GetAttributes<DisplayNameAttribute>(field);
                    var descriptionAttributes = GetAttributes<DescriptionAttribute>(field);
                    var translationCodeAttribute = GetAttributes<TranslationCodeAttribute>(field);
                    var iconNameAttribute = GetAttributes<IconNameAttribute>(field);
                    var iconAddressAttribute = GetAttributes<IconAddressAttribute>(field);

                    var label = displayAttributes.Length > 0 ? displayAttributes[0].DisplayName : descriptionAttributes.Length > 0 ? descriptionAttributes[0].Description : field.Name.SplitOnUpperCase();
                    var trxCode = translationCodeAttribute.Length > 0 ? translationCodeAttribute[0].TrxCode : null;
                    var value = Enum.Parse(enumType, field.Name).ToString();
                    var iconName = iconNameAttribute.Length > 0 ? iconNameAttribute[0].Name : null;
                    var iconAddress = iconAddressAttribute.Length > 0 ? iconAddressAttribute[0].Address : null;

                    lookup.Options.Add(new (value, label, trxCode, iconName, iconAddress));
                }
                catch (Exception)
                {
                    // ignored
                }
            }

            return lookup;
        }

        public static LookupDto ConvertToLookup<TEnum>() where TEnum : Enum
        {
            return ConvertToLookup(typeof(TEnum));
        }

        private static TAttribute[] GetAttributes<TAttribute>(MemberInfo enumType) where TAttribute : Attribute
        {
            return (TAttribute[])enumType.GetCustomAttributes(typeof(TAttribute), false);
        }
    }
}
