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
    /// Specifies the maximum value for a date/time allowed in a property.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
    public class PastDateAttribute : ValidationAttribute
    {
        private readonly DateTimeOffset _maximumDate;

        public PastDateAttribute(string date = "")
        {
            if (string.IsNullOrWhiteSpace(date))
                date = DateTimeOffset.UtcNow.ToString();

            _maximumDate = DateTimeOffset.Parse(date);

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
