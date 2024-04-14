/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Utilities;

namespace Astrana.Core.Domain.Models.Audiences.Constants
{
    public static class ModelProperties
    {
        public static class Audience
        {
            public static readonly string NameUnique = nameof(Audience).SplitOnUpperCase();
            public static readonly string NameSingularForm = nameof(Audience).SplitOnUpperCase();
            public static readonly string NamePluralForm = $"{nameof(Audience)}s".SplitOnUpperCase();

            public const int MinimumNameLength = 1;
            public const int MaximumNameLength = 30;

            public const int MinimumNameTrxCodeLength = 1;
            public const int MaximumNameTrxCodeLength = 100;

            public const int MinimumDescriptionLength = 0;
            public const int MaximumDescriptionLength = 250;

            public const int MinimumDescriptionTrxCodeLength = 0;
            public const int MaximumDescriptionTrxCodeLength = 100;
        }
    }
}
