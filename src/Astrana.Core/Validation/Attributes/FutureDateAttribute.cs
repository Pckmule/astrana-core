/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using System.ComponentModel.DataAnnotations;
using DataAnnotationsValidationResult = System.ComponentModel.DataAnnotations.ValidationResult;

namespace Astrana.Core.Validation.Attributes
{
    /// <summary>
    /// Specifies the minimum value for a date/time allowed in a property.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
    public class FutureDateAttribute : ValidationAttribute
    {
        private readonly DateTimeOffset _minimumDate;

        public FutureDateAttribute(string date = "")
        {
            if (string.IsNullOrWhiteSpace(date))
                date = DateTimeOffset.UtcNow.ToString();

            _minimumDate = DateTimeOffset.Parse(date);

            if (string.IsNullOrEmpty(ErrorMessage))
                ErrorMessage = $"Date must be before or on {date}";
        }

        protected override DataAnnotationsValidationResult? IsValid(object value, ValidationContext validationContext)
        {
            var d = (DateTimeOffset)value;

            return d <= _minimumDate ? new DataAnnotationsValidationResult(ErrorMessage) : DataAnnotationsValidationResult.Success;
        }
    }
}
