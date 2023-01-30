/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using System.ComponentModel.DataAnnotations;

namespace Astrana.Core.Validation.Attributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
    public class SecureWebAddressAttribute : DataTypeAttribute
    {
        public SecureWebAddressAttribute() : base(DataType.Url) { }

        public override bool IsValid(object? value)
        {
            if(value is not string valueAsString || string.IsNullOrWhiteSpace(valueAsString))
                return false;

            if (!Uri.TryCreate(valueAsString, new UriCreationOptions(), out var uri))
                return false;

            return uri.Scheme.ToLower() == "https";
        }
    }
}
