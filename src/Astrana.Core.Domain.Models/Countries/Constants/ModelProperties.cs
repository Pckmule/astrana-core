/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Utilities;

namespace Astrana.Core.Domain.Models.Countries.Constants
{
    public static class ModelProperties
    {
        public static class Country
        {
            public static readonly string NameUnique = nameof(Country).SplitOnUpperCase();
            public static readonly string NameSingularForm = nameof(Country).SplitOnUpperCase();
            public static readonly string NamePluralForm = $"{nameof(Country)}s".SplitOnUpperCase();

            public const int MinimumNameLength = 1;
            public const int MaximumNameLength = 100;

            public const int MinimumNameTrxCodeLength = 1;
            public const int MaximumNameTrxCodeLength = 100;

            public const int MinimumCountryCodeLength = 2;
            public const int MaximumCountryCodeLength = 3;

            public const int MinimumTwoLetterCodeLength = 2;
            public const int MaximumTwoLetterCodeLength = 2;

            public const int MinimumThreeLetterCodeLength = 3;
            public const int MaximumThreeLetterCodeLength = 3;

        }
    }
}
