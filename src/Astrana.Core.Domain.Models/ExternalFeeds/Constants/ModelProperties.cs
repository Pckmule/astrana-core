/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Utilities;

namespace Astrana.Core.Domain.Models.ExternalFeeds.Constants
{
    public static class ModelProperties
    {
        public static class RssFeed
        {
            public static readonly string NameUnique = nameof(RssFeed).SplitOnUpperCase();
            public static readonly string NameSingularForm = nameof(RssFeed).SplitOnUpperCase();
            public static readonly string NamePluralForm = $"{nameof(RssFeed)}s".SplitOnUpperCase();

            public const int MinimumPeerUuidLength = 1;
            public const int MaximumPeerUuidLength = 50;

            public const int MinimumFullNameLength = Core.Constants.ApplicationUser.MinimumFirstNameLength + Core.Constants.ApplicationUser.MinimumLastNameLength;
            public const int MaximumFullNameLength = Core.Constants.ApplicationUser.MaximumFirstNameLength + Core.Constants.ApplicationUser.MaximumLastNameLength;

            public const int MinimumTextLength = Posts.Constants.ModelProperties.Post.MinimumTextLength;
            public const int MaximumTextLength = Posts.Constants.ModelProperties.Post.MaximumTextLength;
        }
    }
}
