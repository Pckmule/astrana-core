/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using System.Text;

namespace Astrana.Core.Utilities
{
    public static class NamingUtility
    {
        public static string AddEnvironmentPrefix(this string name, string separator = "-")
        {
            if (string.IsNullOrWhiteSpace(name))
                return name;

            if (EnvironmentUtility.IsDevelopmentEnvironment())
                return $"dev{separator}{name}";

            if (EnvironmentUtility.IsTestingEnvironment())
                return $"test{separator}{name}";

            return name;
        }

        public static string ToCamelCase(this string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return text;

            var textParts = text.SplitOnUpperCase().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var sb = new StringBuilder();
            for (var i = 0; i < textParts.Length; i++)
            {
                sb.Append(i == 0 ? textParts[i].ToLower() : textParts[i].ToTitleCase());
            }

            return sb.ToString();
        }
    }
}
