/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Utilities;

namespace Astrana.Core.Domain.Models.Feelings.Constants
{
    public static class ModelProperties
    {
        public static class Feeling
        {
            public static readonly string NameUnique = nameof(Feeling).SplitOnUpperCase();
            public static readonly string NameSingularForm = nameof(Feeling).SplitOnUpperCase();
            public static readonly string NamePluralForm = $"{nameof(Feeling)}s".SplitOnUpperCase();

            public const int MinimumNameLength = 1;
            public const int MaximumNameLength = 50;

            public const int MinimumNameTrxCodeLength = 1;
            public const int MaximumNameTrxCodeLength = 100;

            public const int MinimumIconNameLength = 1;
            public const int MaximumIconNameLength = 30;

            public const int MinimumUnicodeIconLength = 1;
            public const int MaximumUnicodeIconLength = 10;

            public const int MinimumShortCodeLength = 1;
            public const int MaximumShortCodeLength = 20;
        }
    }
}
