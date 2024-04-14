/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using System.Text;

namespace Astrana.Core.Extensions
{
    public static class StringBuilderExtensions
    {
        public static void AppendIfNotEmptyOrWhitespace(this StringBuilder sb, string text)
        {
            if (!string.IsNullOrWhiteSpace(text))
                sb.Append(text);
        }

        public static void AppendIfNotNullOrEmpty(this StringBuilder sb, string text)
        {
            if (!string.IsNullOrEmpty(text))
                sb.Append(text);
        }
    }
}