/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Validation.Contracts;
using Astrana.Core.Validation.Enums;

namespace Astrana.Core.Validation
{
    public class ValidationResult : IValidationResult
    {
        private readonly string _message;
        private readonly ValidationOutcome _outcome;

        public ValidationResult(List<ValidationResult>? failedValidations = null, string message = "", ValidationOutcome outcome = ValidationOutcome.Default)
        {
            FailedValidations = failedValidations ?? new List<ValidationResult>();

            _message = message;
            _outcome = outcome;
        }
        
        public List<ValidationResult> FailedValidations { get; }

        public long FailureCount => FailedValidations.Count;

        public bool IsSuccess => !FailedValidations.Any() && _outcome != ValidationOutcome.Failed;

        public string Message
        {
            get
            {
                if(!string.IsNullOrWhiteSpace(_message))
                    return _message;

                if (FailureCount > 0)
                    return $"Prerequisites are unsatisfied with {FailureCount} validation failures.";

                return "Prerequisites are satisfied.";
            }
        }
    }
}
