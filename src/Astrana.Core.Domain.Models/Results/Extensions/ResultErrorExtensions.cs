/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.AstranaApi.Responses;
using Astrana.Core.Domain.Models.Results.Contracts;

namespace Astrana.Core.Domain.Models.Results.Extensions
{
    public static class ResultErrorExtensions
    {
        public static ApiResponseFailedItem ToApiResponseFailedItem(this IResultError result)
        {
            return new ApiResponseFailedItem(result.Reason, result.TargetId);
        }

        public static ApiResponseFailedItem ToApiResponseFailedItem(this ResultError result)
        {
            return new ApiResponseFailedItem(result.Reason, result.TargetId);
        }
    }
}
