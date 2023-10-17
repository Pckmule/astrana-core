/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

namespace Astrana.Core.Extensions
{
    public static class StringConversionExtensions
    {
        public static TEnum ToEnum<TEnum>(this string text) where TEnum : struct
        {
            if (string.IsNullOrWhiteSpace(text))
                return default;

            return Enum.TryParse(text, true, out TEnum result) ? result : default;
        }

        public static bool ToBool(this string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return default;

            text = text.ToLower();

            if(text == "yes" || text == "y" || text == "1")
                return true;

            return bool.TryParse(text, out bool result) ? result : default;
        }

        public static Dictionary<string, string> ToDictionary(this string text, string itemSeparator = ";", string keyPairSeparator = "=")
        {
            if (string.IsNullOrWhiteSpace(text))
                return new Dictionary<string, string>();

            var keyPairParts = text.Split(itemSeparator, StringSplitOptions.RemoveEmptyEntries);

            if(keyPairParts.Length == 0)
                return new Dictionary<string, string>();

            var dictionary = new Dictionary<string, string>();
            foreach(var pair in keyPairParts)
            {
                var keyValueParts = pair.Split(keyPairSeparator);

                dictionary.Add(keyValueParts[0], keyValueParts.Length > 1 ? keyValueParts[1] : "");
            }

            return dictionary;
        }

        public static List<string> ToTrimmedList(this string text, char separatorCharacter = ',')
        {
            return text.Split(separatorCharacter, StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries).ToList();
        }
    }
}