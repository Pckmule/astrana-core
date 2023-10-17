/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Utilities;

namespace Astrana.Core.Domain.Models.Comments.Constants
{
    public static class ModelProperties
    {
        public static class Comment
        {
            public static readonly string NameUnique = nameof(Comment).SplitOnUpperCase();
            public static readonly string NameSingularForm = nameof(Comment).SplitOnUpperCase();
            public static readonly string NamePluralForm = $"{nameof(Comment)}s".SplitOnUpperCase();

            public const int MinimumTextLength = 1;
            public const int MaximumTextLength = 1000;
        }
    }
}
