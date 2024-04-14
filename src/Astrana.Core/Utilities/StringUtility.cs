/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using System.Globalization;
using System.Text.RegularExpressions;

namespace Astrana.Core.Utilities
{
    public static class StringUtility
    {
        public static string SplitOnUpperCase(this string text, string separator = " ")
        {
            if (string.IsNullOrWhiteSpace(text))
                return text;

            return string.Join(separator, Regex.Split(text, @"(?<!^)(?=[A-Z])")).Trim();
        }

        public static string ToTitleCase(this string text)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text.Trim().ToLower());
        }

        public static string? NullIfEmpty(this string? value)
        {
            return string.IsNullOrWhiteSpace(value) ? null : value;
        }

        public static string? EmptyIfSame(this string? value, string? compareValue)
        {
            return value == compareValue ? string.Empty : value;
        }

        public static string? DefaultIfEmpty(this string? value, string? fallbackValue1, string? fallbackValue2 = "")
        {
            var fallbackValue = string.IsNullOrWhiteSpace(fallbackValue1) ? fallbackValue2 : fallbackValue1;

            return string.IsNullOrWhiteSpace(value) ? fallbackValue : value;
        }
    }
}
