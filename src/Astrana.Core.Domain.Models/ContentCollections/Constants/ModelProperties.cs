/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Utilities;

namespace Astrana.Core.Domain.Models.ContentCollections.Constants
{
    public static class ModelProperties
    {
        public static class ContentCollection
        {
            public static readonly string NameUnique = nameof(ContentCollection).SplitOnUpperCase();
            public static readonly string NameSingularForm = nameof(ContentCollection).SplitOnUpperCase();
            public static readonly string NamePluralForm = $"{nameof(ContentCollection)}s".SplitOnUpperCase();

            public const int MinimumNameLength = 0;
            public const int MaximumNameLength = 250;

            public const int MinimumCaptionLength = 1;
            public const int MaximumCaptionLength = 500;

            public const int MinimumCopyrightLength = 1;
            public const int MaximumCopyrightLength = 500;
        }

        public static class ContentCollectionItem
        {
            public static readonly string NameUnique = nameof(ContentCollectionItem).SplitOnUpperCase();
            public static readonly string NameSingularForm = nameof(ContentCollectionItem).SplitOnUpperCase();
            public static readonly string NamePluralForm = $"{nameof(ContentCollectionItem)}s".SplitOnUpperCase();
        }
    }
}
