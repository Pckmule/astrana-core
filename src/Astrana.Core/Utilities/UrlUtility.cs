/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

namespace Astrana.Core.Utilities
{
    public static class UrlUtility
    {
        public static string AddUrlScheme(this string urlAddress, string scheme)
        {
            if (string.IsNullOrWhiteSpace(urlAddress))
                throw new ArgumentNullException(nameof(urlAddress));

            if (string.IsNullOrWhiteSpace(scheme))
                throw new ArgumentNullException(nameof(scheme));

            return !urlAddress.StartsWith($"{scheme.ToLower()}://", StringComparison.OrdinalIgnoreCase) ? $"{scheme.ToLower()}://{urlAddress}" : urlAddress;
        }

        public static string AddHttpsScheme(this string urlAddress)
        {
            return AddUrlScheme(urlAddress, "https");
        }
    }
}
