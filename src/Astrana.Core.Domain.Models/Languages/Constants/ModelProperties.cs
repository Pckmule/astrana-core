/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Utilities;

namespace Astrana.Core.Domain.Models.Languages.Constants
{
    public static class ModelProperties
    {
        public static class Language
        {
            public static readonly string NameUnique = nameof(Language).SplitOnUpperCase();
            public static readonly string NameSingularForm = nameof(Language).SplitOnUpperCase();
            public static readonly string NamePluralForm = $"{nameof(Language)}s".SplitOnUpperCase();

            public const int MinimumNameLength = 1;
            public const int MaximumNameLength = 25;

            public const int MinimumNameTrxCodeLength = 1;
            public const int MaximumNameTrxCodeLength = 100;

            public const int MinimumLanguageCodeLength = 2;
            public const int MaximumLanguageCodeLength = 5;

            public const int MinimumTwoLetterCodeLength = 2;
            public const int MaximumTwoLetterCodeLength = 2;

            public const int MinimumThreeLetterCodeLength = 3;
            public const int MaximumThreeLetterCodeLength = 3;

        }
    }
}
