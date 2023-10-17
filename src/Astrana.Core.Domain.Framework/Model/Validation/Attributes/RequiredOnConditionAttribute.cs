/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using System.Collections;
using System.ComponentModel.DataAnnotations;
using DataAnnotationsValidationResult = System.ComponentModel.DataAnnotations.ValidationResult;

namespace Astrana.Core.Framework.Model.Validation.Attributes
{
    /// <summary>
    /// Specifies a condition under which a property is required.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
    public class RequiredOnConditionAttribute : ValidationAttribute
    {
        private const string DefaultErrorMessageFormatString = "The {0} property is required.";

        private readonly string _dependentPropertyName;
        private readonly Condition _condition;
        private readonly dynamic? _expectedValue;

        public RequiredOnConditionAttribute(string dependentPropertyName, Condition condition, object? expectedValue = null)
        {
            _dependentPropertyName = dependentPropertyName;
            _condition = condition;
            _expectedValue = expectedValue;

            ErrorMessage = DefaultErrorMessageFormatString;
        }

        protected override DataAnnotationsValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (validationContext == null)
            {
                return DataAnnotationsValidationResult.Success;
            }

            var property = validationContext.ObjectInstance.GetType().GetProperty(_dependentPropertyName);

            var dependentPropertyValue = property?.GetValue(validationContext.ObjectInstance, null);

            if (value == null)
            {
                switch (_condition)
                {
                    case Condition.Value when !dependentPropertyValue.Equals(_expectedValue):
                    case Condition.ValueNot when dependentPropertyValue.Equals(_expectedValue):
                        return new DataAnnotationsValidationResult(string.Format(ErrorMessageString, validationContext.DisplayName));
                }

                if (dependentPropertyValue is not ICollection collection)
                    return new DataAnnotationsValidationResult(string.Format(ErrorMessageString, validationContext.DisplayName));

                switch (_condition)
                {
                    case Condition.ItemCount when !collection.Count.Equals(_expectedValue):
                    case Condition.ItemCountNot when collection.Count.Equals(_expectedValue):
                    case Condition.ItemCountGreaterThan when collection.Count <= _expectedValue:
                    case Condition.ItemCountLessThan when collection.Count >= _expectedValue:
                        return new DataAnnotationsValidationResult(string.Format(ErrorMessageString, validationContext.DisplayName));
                }
            }

            return DataAnnotationsValidationResult.Success;
        }

        public override bool RequiresValidationContext => true;
    }

    public enum Condition
    {
        Value,
        ValueNot,
        ItemCount,
        ItemCountNot,
        ItemCountGreaterThan,
        ItemCountLessThan
    }
}
