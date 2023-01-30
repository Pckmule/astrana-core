/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Validation;
using Astrana.Core.Validation.Contracts;

namespace Astrana.Core.Domain.Models.Results.Extensions
{
    public static class EntityValidationResultExtensions
    {
        public static ResultError ToResultError(this IEntityValidationResult result)
        {
            return new ResultError(result.ValidatedEntityName, result.Message);
        }

        public static ResultError ToResultError(this EntityValidationResult result)
        {
            return new ResultError(result.ValidatedEntityName, result.Message);
        }
    }
}
