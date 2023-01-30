/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

namespace Astrana.Core.Constants
{
    public static class ErrorCodes
    {
        public const string Default = "0x0";

        public const string OnlyOneAllowed = "0x1";
        public const string UniqueValueRequired = "0x2";

        public const string PrerequisitesNotSatisfied = "0x3";

        public const string CannotConnect = "0x400";
        public const string CannotConnect_NetworkError = "0x401";
        public const string CannotConnect_AuthenticationFailed = "0x402";
    }
}
