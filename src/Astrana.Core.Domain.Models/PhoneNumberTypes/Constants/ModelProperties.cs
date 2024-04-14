/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Utilities;

namespace Astrana.Core.Domain.Models.PhoneNumberTypes.Constants
{
    public static class ModelProperties
    {
        public static class PhoneNumberType
        {
            public static readonly string NameUnique = nameof(PhoneNumberType).SplitOnUpperCase();
            public static readonly string NameSingularForm = nameof(PhoneNumberType).SplitOnUpperCase();
            public static readonly string NamePluralForm = $"{nameof(PhoneNumberType)}s".SplitOnUpperCase();
            
            public const int MinimumNameLength = 2;
            public const int MaximumNameLength = 20;

            public const int MinimumCodeLength = 2;
            public const int MaximumCodeLength = 20;
        }
    }
}
