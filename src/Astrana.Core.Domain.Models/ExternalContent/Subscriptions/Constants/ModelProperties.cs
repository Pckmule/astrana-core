/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Utilities;

namespace Astrana.Core.Domain.Models.ExternalContent.Subscriptions.Constants
{
    public static class ModelProperties
    {
        public static class ExternalContentSubscription
        {
            public static readonly string NameUnique = nameof(ExternalContentSubscription).SplitOnUpperCase();
            public static readonly string NameSingularForm = nameof(ExternalContentSubscription).SplitOnUpperCase();
            public static readonly string NamePluralForm = $"{nameof(ExternalContentSubscription)}s".SplitOnUpperCase();

            public const int IdMinLength = 1;
            public const int IdMaxLength = int.MaxValue;

            public const int MinimumUrlLength = 1;
            public const int MaximumUrlLength = 500;

            public const int MinimumTitleLength = 1;
            public const int MaximumTitleLength = 250;

            public const int MinimumSubTitleLength = 0;
            public const int MaximumSubTitleLength = 250;

            public const int MinimumDescriptionLength = 0;
            public const int MaximumDescriptionLength = 750;

            public const int MinimumWebsiteUrlLength = 0;
            public const int MaximumWebsiteUrlLength = 500;

            public const int MinimumCopyrightLength = 0;
            public const int MaximumCopyrightLength = 500;

            public const int MinimumLocaleLength = 0;
            public const int MaximumLocaleLength = 10;

            public const int MinimumLanguageLength = 0;
            public const int MaximumLanguageLength = 10;

            public const int MinimumCharSetLength = 0;
            public const int MaximumCharSetLength = 10;

            public const int MinimumAccessTokenLength = 0;
            public const int MaximumAccessTokenLength = 500;
        }
    }
}
