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
