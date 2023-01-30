/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Validation.Enums;

namespace Astrana.Core.Validation.Contracts
{
    public interface IEntityValidationResult
    {
        string ValidatedEntityName { get; }

        ValidatedEntityType ValidatedEntityType { get; }

        List<EntityValidationResult> FailedValidations { get; }

        long FailureCount { get; }

        bool IsSuccess { get; }

        bool IsFailed => !IsSuccess;
        
        string Message { get; }
    }
}