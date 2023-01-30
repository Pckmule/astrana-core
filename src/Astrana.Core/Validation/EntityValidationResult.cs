/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Validation.Contracts;
using Astrana.Core.Validation.Enums;

namespace Astrana.Core.Validation
{
    public sealed class EntityValidationResult : IEntityValidationResult
    {
        private readonly string _message;
        private readonly ValidationOutcome _outcome;

        public EntityValidationResult(string validatedEntityName, ValidatedEntityType validatedEntityType, List<EntityValidationResult>? failedValidations = null, string message = "", ValidationOutcome outcome = ValidationOutcome.Default, string validatedParentEntityName = "")
        {
            ValidatedEntityName = string.IsNullOrWhiteSpace(validatedParentEntityName) ? validatedEntityName : $"{validatedParentEntityName}.{validatedEntityName}";
            ValidatedEntityType = validatedEntityType;
            
            FailedValidations = failedValidations ?? new List<EntityValidationResult>();

            _message = message;
            _outcome = outcome;
        }

        public string ValidatedEntityName { get; }

        public ValidatedEntityType ValidatedEntityType { get; }

        public List<EntityValidationResult> FailedValidations { get; }

        public long FailureCount => FailedValidations.Count;

        public bool IsSuccess => !FailedValidations.Any() && _outcome != ValidationOutcome.Failed;

        public bool IsFailed => !IsSuccess;

        public string Message
        {
            get
            {
                if(!string.IsNullOrWhiteSpace(_message))
                    return _message;

                if (FailureCount > 0)
                    return $"Validation failed with {FailureCount} validation failures.";

                return $"{ValidatedEntityType}:{ValidatedEntityName} is valid.";
            }
        }
    }
}
