/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

namespace Astrana.Core.Constants
{
    public static class ApplicationUser
    {
        public const int MinimumUsernameLength = 1;
        public const int MaximumUsernameLength = 100;

        public const int MinimumFirstNameLength = 1;
        public const int MaximumFirstNameLength = 100;

        public const int MinimumMiddleNamesLength = 0;
        public const int MaximumMiddleNamesLength = 300;

        public const int MinimumLastNameLength = 1;
        public const int MaximumLastNameLength = 100;

        public const int MinimumEmailAddressLength = 6;
        public const int MaximumEmailAddressLength = 250;

        public const int MinimumPhoneNumberLength = 3;
        public const int MaximumPhoneNumberLength = 25;
    }
}
