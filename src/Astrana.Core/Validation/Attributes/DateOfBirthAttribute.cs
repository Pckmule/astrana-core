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
    /// Specifies that only a valid date of birth is allowed in a property.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
    public class DateOfBirthAttribute : ValidationAttribute
    {
        private readonly int _minimumAge;
        private readonly int _maximumAge;

        private readonly DateTimeOffset _maximumDate;

        public DateOfBirthAttribute(string date = "", int minimumAge = 0, int maximumAge = int.MaxValue)
        {
            if (string.IsNullOrWhiteSpace(date))
                date = DateTimeOffset.UtcNow.ToString();

            _maximumDate = DateTimeOffset.Parse(date);

            _minimumAge = minimumAge;
            _maximumAge = maximumAge;

            if (string.IsNullOrEmpty(ErrorMessage))
                ErrorMessage = $"Date must be before or on {date}";
        }

        protected override DataAnnotationsValidationResult? IsValid(object value, ValidationContext validationContext)
        {
            var d = (DateTimeOffset)value;

            if (d > _maximumDate)
                return new DataAnnotationsValidationResult(ErrorMessage);

            return DataAnnotationsValidationResult.Success;
        }
    }
}
