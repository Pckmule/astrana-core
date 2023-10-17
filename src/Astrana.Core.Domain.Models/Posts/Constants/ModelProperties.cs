/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Utilities;

namespace Astrana.Core.Domain.Models.Posts.Constants
{
    public static class ModelProperties
    {
        public static class Post
        {
            public static readonly string NameUnique = nameof(Post).SplitOnUpperCase();
            public static readonly string NameSingularForm = nameof(Post).SplitOnUpperCase();
            public static readonly string NamePluralForm = $"{nameof(Post)}s".SplitOnUpperCase();

            public const int IdMinLength = 0;
            public const int IdMaxLength = int.MaxValue;

            public const int MinimumTextLength = 0;
            public const int MaximumTextLength = 1000;
        }

        public static class PostAttachment
        {
            public static readonly string NameUnique = nameof(PostAttachment).SplitOnUpperCase();
            public static readonly string NameSingularForm = nameof(PostAttachment).SplitOnUpperCase();
            public static readonly string NamePluralForm = $"{nameof(PostAttachment)}s".SplitOnUpperCase();

            public const int MinimumContentIdLength = 1;
            public const int MaximumContentIdLength = 100;

            public const int MinimumAddressLength = 1;
            public const int MaximumAddressLength = 2000;

            public const int MaximumTitleLength = 200;
            public const int MaximumCaptionLength = 200;
        }
    }
}
