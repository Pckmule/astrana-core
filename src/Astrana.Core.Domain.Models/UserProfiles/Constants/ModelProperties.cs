/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Constants;
using Astrana.Core.Utilities;

namespace Astrana.Core.Domain.Models.UserProfiles.Constants
{
    public static class ModelProperties
    {
        public static class UserProfile
        {
            public static readonly string NameUnique = nameof(UserProfile).SplitOnUpperCase();
            public static readonly string NameSingularForm = nameof(UserProfile).SplitOnUpperCase();
            public static readonly string NamePluralForm = $"{nameof(UserProfile)}s".SplitOnUpperCase();

            public const int MinimumFirstNameLength = ApplicationUser.MinimumFirstNameLength;
            public const int MaximumFirstNameLength = ApplicationUser.MaximumFirstNameLength;

            public const int MinimumMiddleNamesLength = ApplicationUser.MinimumMiddleNamesLength;
            public const int MaximumMiddleNamesLength = ApplicationUser.MaximumMiddleNamesLength;

            public const int MinimumLastNameLength = ApplicationUser.MinimumLastNameLength;
            public const int MaximumLastNameLength = ApplicationUser.MaximumLastNameLength;

            public const int MinimumIntroductionLength = 0;
            public const int MaximumIntroductionLength = 100;
        }
    }
}
