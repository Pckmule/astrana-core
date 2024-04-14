/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

namespace Astrana.Core.Domain.Models.Lookups.Attributes
{
    /// <summary>
    /// Indicates the property value should be used for the icon address of a lookup option.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public sealed class LookupOptionIconAddressAttribute : Attribute
    {
        public readonly string FallbackValue;

        /// <param name="fallbackValue">The value to use if the property/field value is empty.</param>
        public LookupOptionIconAddressAttribute(string fallbackValue)
        {
            FallbackValue = fallbackValue;
        }
    }
}
