/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Utilities;

namespace Astrana.Core.Domain.Models.SkinTones.Constants
{
    public static class ModelProperties
    {
        public static class SkinTone
        {
            public static readonly string NameUnique = nameof(SkinTone).SplitOnUpperCase();
            public static readonly string NameSingularForm = nameof(SkinTone).SplitOnUpperCase();
            public static readonly string NamePluralForm = $"{nameof(SkinTone)}s".SplitOnUpperCase();

            public const int MinimumNameLength = 1;
            public const int MaximumNameLength = 50;

            public const int MinimumNameTrxCodeLength = 1;
            public const int MaximumNameTrxCodeLength = 100;

            public const int MinimumColorCodeLength = 1;
            public const int MaximumColorCodeLength = 7;

            public const int MinimumDescriptionLength = 1;
            public const int MaximumDescriptionLength = 50;

            public const int MinimumDescriptionTrxCodeLength = 1;
            public const int MaximumDescriptionTrxCodeLength = 100;
        }
    }
}
