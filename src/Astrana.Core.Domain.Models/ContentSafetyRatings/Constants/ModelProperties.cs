/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Utilities;

namespace Astrana.Core.Domain.Models.ContentSafetyRatings.Constants
{
    public static class ModelProperties
    {
        public static class ContentSafetyRating
        {
            public static readonly string NameUnique = nameof(ContentSafetyRating).SplitOnUpperCase();
            public static readonly string NameSingularForm = nameof(ContentSafetyRating).SplitOnUpperCase();
            public static readonly string NamePluralForm = $"{nameof(ContentSafetyRating)}s".SplitOnUpperCase();

            public const int MinimumNameLength = 1;
            public const int MaximumNameLength = 100;

            public const int MinimumDescriptionLength = 1;
            public const int MaximumDescriptionLength = 500;
        }
    }
}
