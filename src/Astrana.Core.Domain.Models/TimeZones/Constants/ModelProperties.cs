/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Utilities;

namespace Astrana.Core.Domain.Models.TimeZones.Constants
{
    public static class ModelProperties
    {
        public static class TimeZone
        {
            public static readonly string NameUnique = nameof(TimeZone).SplitOnUpperCase();
            public static readonly string NameSingularForm = nameof(TimeZone).SplitOnUpperCase();
            public static readonly string NamePluralForm = $"{nameof(TimeZone)}s".SplitOnUpperCase();

            public const int MinimumNameLength = 1;
            public const int MaximumNameLength = 100;

            public const int MinimumNameTrxCodeLength = 1;
            public const int MaximumNameTrxCodeLength = 100;

            public const int MinimumAbbreviationLength = 1;
            public const int MaximumAbbreviationLength = 6;

            public const int MinimumCorrespondingUtcZoneLength = 1;
            public const int MaximumCorrespondingUtcZoneLength = 5;
        }
    }
}
