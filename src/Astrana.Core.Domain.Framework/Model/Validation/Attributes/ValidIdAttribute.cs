/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using System.ComponentModel.DataAnnotations;

namespace Astrana.Core.Framework.Model.Validation.Attributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
    public class ValidIdAttribute : ValidationAttribute
    {
        public const string DefaultErrorMessage = "{0} must be valid";

        private readonly long? _minimumValue;
        private readonly long? _maximumValue;

        public ValidIdAttribute() : base(DefaultErrorMessage)
        {
            _minimumValue = null;
            _maximumValue = null;
        }

        public ValidIdAttribute(long minimumValue, long maximumValue) : base(DefaultErrorMessage)
        {
            _minimumValue = minimumValue;
            _maximumValue = maximumValue;
        }

        public override bool IsValid(object? value)
        {
            if (value is null)
                return false;
            
            switch (value)
            {
                case Guid id:
                    return true;

                case string id:
                    return !string.IsNullOrWhiteSpace(id) && (!_minimumValue.HasValue || id.Length >= _minimumValue) && (!_maximumValue.HasValue || id.Length <= _maximumValue);

                case long id:
                    return id > -1 && (!_minimumValue.HasValue || id >= _minimumValue) && (!_maximumValue.HasValue || id <= _maximumValue);

                case int id:
                    return id > -1 && (!_minimumValue.HasValue || id >= _minimumValue) && (!_maximumValue.HasValue || id <= _maximumValue);

                case short id:
                    return id > -1 && (!_minimumValue.HasValue || id >= _minimumValue) && (!_maximumValue.HasValue || id <= _maximumValue);

                default:
                    return false;
            }
        }
    }

}
