/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using System.ComponentModel.DataAnnotations;

namespace Astrana.Core.Framework.Model.Validation.Attributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
    public class NotEmptyAttribute : ValidationAttribute
    {
        public const string DefaultErrorMessage = "{0} may not be empty";

        public NotEmptyAttribute() : base(DefaultErrorMessage) { }

        public override bool IsValid(object? value)
        {
            if (value is null)
                return true;

            switch (value)
            {
                case Guid guid:
                    return guid != Guid.Empty;

                case string str:
                    return !string.IsNullOrEmpty(str);

                default:
                    return true;
            }
        }
    }

}
