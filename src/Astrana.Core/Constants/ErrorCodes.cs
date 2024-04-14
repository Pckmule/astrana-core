/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

// ReSharper disable InconsistentNaming

namespace Astrana.Core.Constants
{
    public static class ErrorCodes
    {
        public const string Default = "0x0";

        public const string ActionAborted = "0x1";
        public const string DuplicateKey = "0x2";
        public const string OnlyOneAllowed = "0x3";
        public const string UniqueValueRequired = "0x4";

        public const string PrerequisitesNotSatisfied = "0x301";
        public const string ConditionsNotMet = "0x302";

        public const string CannotConnect = "0x400";
        public const string CannotConnect_NetworkError = "0x401";
        public const string CannotConnect_AuthenticationFailed = "0x402";
    }
}
