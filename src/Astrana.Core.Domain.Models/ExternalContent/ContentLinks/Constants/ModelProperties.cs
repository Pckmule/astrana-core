/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Utilities;

namespace Astrana.Core.Domain.Models.ExternalContent.ContentLinks.Constants
{
    public static class ModelProperties
    {
        public static class ContentLink
        {
            public static readonly string NameUnique = nameof(ContentLink).SplitOnUpperCase();
            public static readonly string NameSingularForm = nameof(ContentLink).SplitOnUpperCase();
            public static readonly string NamePluralForm = $"{nameof(ContentLink)}s".SplitOnUpperCase();

            public const int IdMinLength = 1;
            public const int IdMaxLength = int.MaxValue;

            public const int MinimumUrlLength = 1;
            public const int MaximumUrlLength = 500;

            public const int MinimumTextLength = 1;
            public const int MaximumTextLength = 250;

            public const int MinimumRelLength = 0;
            public const int MaximumRelLength = 250;
        }
    }
}
