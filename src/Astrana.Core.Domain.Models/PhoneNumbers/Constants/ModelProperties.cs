/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Utilities;

namespace Astrana.Core.Domain.Models.PhoneNumbers.Constants
{
    public static class ModelProperties
    {
        public static class PhoneNumber
        {
            public static readonly string NameUnique = nameof(PhoneNumber).SplitOnUpperCase();
            public static readonly string NameSingularForm = nameof(PhoneNumber).SplitOnUpperCase();
            public static readonly string NamePluralForm = $"{nameof(PhoneNumber)}s".SplitOnUpperCase();

            public const int MinimumNumberLength = 6;
            public const int MaximumNumberLength = 500;
        }
    }
}
