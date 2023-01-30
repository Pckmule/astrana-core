/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Utilities;

namespace Astrana.Core.Domain.Models.IdentityAccessManagement.Constants
{
    public static class ModelProperties
    {
        public static class ApplicationUser
        {
            public static readonly string NameUnique = nameof(ApplicationUser).SplitOnUpperCase();
            public static readonly string NameSingularForm = nameof(ApplicationUser).SplitOnUpperCase();
            public static readonly string NamePluralForm = $"{nameof(ApplicationUser)}s".SplitOnUpperCase();

            public const short MinimumCountryCodeLength = Core.Constants.Internationalization.MinimumCountryCodeLength;
            public const short MaximumCountryCodeLength = Core.Constants.Internationalization.MaximumCountryCodeLength;

            public const short MinimumLanguageCodeLength = Core.Constants.Internationalization.MinimumLanguageCodeLength;
            public const short MaximumLanguageCodeLength = Core.Constants.Internationalization.MaximumLanguageCodeLength;

            public const int MinimumUsernameLength = Core.Constants.ApplicationUser.MinimumUsernameLength;
            public const int MaximumUsernameLength = Core.Constants.ApplicationUser.MaximumUsernameLength;

            public const int MinimumFirstNameLength = Core.Constants.ApplicationUser.MinimumFirstNameLength;
            public const int MaximumFirstNameLength = Core.Constants.ApplicationUser.MaximumFirstNameLength;

            public const int MinimumMiddleNamesLength = Core.Constants.ApplicationUser.MinimumMiddleNamesLength;
            public const int MaximumMiddleNamesLength = Core.Constants.ApplicationUser.MaximumMiddleNamesLength;

            public const int MinimumLastNameLength = Core.Constants.ApplicationUser.MinimumLastNameLength;
            public const int MaximumLastNameLength = Core.Constants.ApplicationUser.MaximumLastNameLength;

            public const int MinimumEmailAddressLength = Core.Constants.ApplicationUser.MinimumEmailAddressLength;
            public const int MaximumEmailAddressLength = Core.Constants.ApplicationUser.MaximumEmailAddressLength;

            public const int MinimumPhoneCountryCodeISOLength = Core.Constants.Internationalization.MinimumPhoneCountryCodeISOLength;
            public const int MaximumPhoneCountryCodeISOLength = Core.Constants.Internationalization.MaximumPhoneCountryCodeISOLength;

            public const int MinimumPhoneNumberLength = Core.Constants.ApplicationUser.MinimumPhoneNumberLength;
            public const int MaximumPhoneNumberLength = Core.Constants.ApplicationUser.MaximumPhoneNumberLength;

        }

        public static class InitiateResetPasswordRequest
        {
            public static readonly string NameUnique = nameof(InitiateResetPasswordRequest).SplitOnUpperCase();
            public static readonly string NameSingularForm = nameof(InitiateResetPasswordRequest).SplitOnUpperCase();
            public static readonly string NamePluralForm = $"{nameof(InitiateResetPasswordRequest)}s".SplitOnUpperCase();

            public const int MinimumUsernameLength = Core.Constants.ApplicationUser.MinimumUsernameLength;
            public const int MaximumUsernameLength = Core.Constants.ApplicationUser.MaximumUsernameLength;
        }

        public static class LoginRequest
        {
            public static readonly string NameUnique = nameof(LoginRequest).SplitOnUpperCase();
            public static readonly string NameSingularForm = nameof(LoginRequest).SplitOnUpperCase();
            public static readonly string NamePluralForm = $"{nameof(LoginRequest)}s".SplitOnUpperCase();

            public const int MinimumUsernameLength = Core.Constants.ApplicationUser.MinimumUsernameLength;
            public const int MaximumUsernameLength = Core.Constants.ApplicationUser.MaximumUsernameLength;

            public const int MinimumPasswordLength = Core.Constants.Idp.MinimumPasswordLength;
            public const int MaximumPasswordLength = Core.Constants.Idp.MaximumPasswordLength;
        }

        public static class RegisterUserAccountRequest
        {
            public static readonly string NameUnique = nameof(RegisterUserAccountRequest).SplitOnUpperCase();
            public static readonly string NameSingularForm = nameof(RegisterUserAccountRequest).SplitOnUpperCase();
            public static readonly string NamePluralForm = $"{nameof(RegisterUserAccountRequest)}s".SplitOnUpperCase();

            public const short MinimumCountryCodeLength = Core.Constants.Internationalization.MinimumCountryCodeLength;
            public const short MaximumCountryCodeLength = Core.Constants.Internationalization.MaximumCountryCodeLength;

            public const short MinimumLanguageCodeLength = Core.Constants.Internationalization.MinimumLanguageCodeLength;
            public const short MaximumLanguageCodeLength = Core.Constants.Internationalization.MaximumLanguageCodeLength;

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
        }

        public static class ResetPasswordRequest
        {
            public static readonly string NameUnique = nameof(ResetPasswordRequest).SplitOnUpperCase();
            public static readonly string NameSingularForm = nameof(ResetPasswordRequest).SplitOnUpperCase();
            public static readonly string NamePluralForm = $"{nameof(ResetPasswordRequest)}s".SplitOnUpperCase();

            public const int MinimumValidationTokenLength = 1;
            public const int MaximumValidationTokenLength = 200; // TODO: Set real value

            public const int MinimumNewPasswordLength = Core.Constants.Idp.MinimumPasswordLength;
            public const int MaximumNewPasswordLength = Core.Constants.Idp.MaximumPasswordLength;
        }
    }
}
