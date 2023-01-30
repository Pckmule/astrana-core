/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Utilities;

namespace Astrana.Core.Domain.Models.Tags.Constants
{
    public static class ModelProperties
    {
        public static class Tag
        {
            public static readonly string NameUnique = nameof(Tag).SplitOnUpperCase();
            public static readonly string NameSingularForm = nameof(Tag).SplitOnUpperCase();
            public static readonly string NamePluralForm = $"{nameof(Tag)}s".SplitOnUpperCase();
            
            public const int MinimumTextLength = 1;
            public const int MaximumTextLength = 50;
        }
    }
}
