/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Utilities;

namespace Astrana.Core.Domain.Models.Reactions.Constants
{
    public static class ModelProperties
    {
        public static class Reaction
        {
            public static readonly string NameUnique = nameof(Reaction).SplitOnUpperCase();
            public static readonly string NameSingularForm = nameof(Reaction).SplitOnUpperCase();
            public static readonly string NamePluralForm = $"{nameof(Reaction)}s".SplitOnUpperCase();
            
            public const int MinimumNameLength = 1;
            public const int MaximumNameLength = 50;

            public const int MinimumNameTrxCodeLength = 1;
            public const int MaximumNameTrxCodeLength = 100;

            public const int MinimumIconNameLength = 1;
            public const int MaximumIconNameLength = 30;

            public const int MinimumUnicodeIconLength = 1;
            public const int MaximumUnicodeIconLength = 10;
        }
    }
}
