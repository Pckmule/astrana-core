/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

#pragma warning disable CS1591

namespace Astrana.Core.API.Constants
{
    public static class ApiResponseMessages
    {
        public const string DefaultPreconditionResponseMessage = "The request was not processed because it is contingent on one or more unmet conditions.";
        public const string DefaultValidationResponseMessage = "The request was not processed because it was invalid.";
        public const string DefaultErrorResponseMessage = "An error occurred.";
        public const string DefaultFailureResponseMessage = "The requested action did not execute successfully.";
    }
}
