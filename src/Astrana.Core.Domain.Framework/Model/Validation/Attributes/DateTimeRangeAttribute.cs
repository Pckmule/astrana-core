/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using System.ComponentModel.DataAnnotations;
using DataAnnotationsValidationResult = System.ComponentModel.DataAnnotations.ValidationResult;

namespace Astrana.Core.Framework.Model.Validation.Attributes
{
    /// <summary>
    /// Specifies the minimum constraints for a date/time allowed in a property.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
    public class DateTimeRangeAttribute : ValidationAttribute
    {
        private readonly DateTimeOffset _minimumDate;
        private readonly DateTimeOffset _maximumDate;

        public DateTimeRangeAttribute(string minimumDate, string maximumDate)
        {
            _minimumDate = DateTimeOffset.Parse(minimumDate);
            _maximumDate = DateTimeOffset.Parse(maximumDate);

            if (string.IsNullOrEmpty(ErrorMessage))
                ErrorMessage = $"Date must be after or on {minimumDate} and before or on {maximumDate}";
        }

        protected override DataAnnotationsValidationResult? IsValid(object value, ValidationContext validationContext)
        {
            var d = (DateTimeOffset)value;

            if (d < _minimumDate || d > _maximumDate)
                return new DataAnnotationsValidationResult(ErrorMessage);

            return DataAnnotationsValidationResult.Success;
        }
    }
}
