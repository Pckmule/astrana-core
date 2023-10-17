/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.AstranaLink.Enums;

namespace Astrana.Core.Domain.AstranaLink.Builders
{
    public static class AstranaLinkBuilder
    {
        public static string Build(Uri address, AstranaPage page)
        {
            var path = address.Host + (address.Port != 80 ? ":" + address.Port : "");

            if (page == AstranaPage.Profile)
                path += "/profile";

            if (page == AstranaPage.NewsFeed)
                path += "/newsfeed";

            if (page == AstranaPage.PeerList)
                path += "/peers";

            if (page == AstranaPage.Settings)
                path += "/settings";

            return new Uri($"https://{path}").ToString();
        }

        public static string Build(string address, AstranaPage page)
        {
            return Build(new Uri(address), page);
        }
    }
}
