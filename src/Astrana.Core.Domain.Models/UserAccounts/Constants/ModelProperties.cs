/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Utilities;

namespace Astrana.Core.Domain.Models.UserAccounts.Constants
{
    public static class ModelProperties
    {
        public static class UserAccount
        {
            public static readonly string NameUnique = nameof(UserAccount).SplitOnUpperCase();
            public static readonly string NameSingularForm = nameof(UserAccount).SplitOnUpperCase();
            public static readonly string NamePluralForm = $"{nameof(UserAccount)}s".SplitOnUpperCase();

            public const int MinimumUsernameLength = Core.Constants.ApplicationUser.MinimumUsernameLength;
            public const int MaximumUsernameLength = Core.Constants.ApplicationUser.MaximumUsernameLength;

            public const int MinimumPasswordLength = Core.Constants.Idp.MinimumPasswordLength;
            public const int MaximumPasswordLength = Core.Constants.Idp.MaximumPasswordLength;

            public const int MinimumFirstNameLength = Core.Constants.ApplicationUser.MinimumFirstNameLength;
            public const int MaximumFirstNameLength = Core.Constants.ApplicationUser.MaximumFirstNameLength;

            public const int MinimumLastNameLength = Core.Constants.ApplicationUser.MinimumLastNameLength;
            public const int MaximumLastNameLength = Core.Constants.ApplicationUser.MaximumLastNameLength;

            public const int MinimumEmailAddressLength = Core.Constants.ApplicationUser.MinimumEmailAddressLength;
            public const int MaximumEmailAddressLength = Core.Constants.ApplicationUser.MaximumEmailAddressLength;

            public const int MinimumPhoneNumberLength = 3;
            public const int MaximumPhoneNumberLength = 25;

            public const int MinimumPhoneCountryCodeISOLength = Core.Constants.Internationalization.MinimumPhoneCountryCodeISOLength;
            public const int MaximumPhoneCountryCodeISOLength = Core.Constants.Internationalization.MaximumPhoneCountryCodeISOLength;

            public const int MinimumCountryCodeLength = Core.Constants.Internationalization.MinimumCountryCodeLength;
            public const int MaximumCountryCodeLength = Core.Constants.Internationalization.MaximumCountryCodeLength;

            public const int MinimumLanguageCodeLength = Core.Constants.Internationalization.MinimumLanguageCodeLength;
            public const int MaximumLanguageCodeLength = Core.Constants.Internationalization.MaximumLanguageCodeLength;
        }
    }
}
