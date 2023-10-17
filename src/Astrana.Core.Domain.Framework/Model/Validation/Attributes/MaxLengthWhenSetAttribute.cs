/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using System.ComponentModel.DataAnnotations;

namespace Astrana.Core.Framework.Model.Validation.Attributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
    public class MaxLengthWhenSetAttribute : MaxLengthAttribute
    {
        public MaxLengthWhenSetAttribute(int length) : base(length) { }

        public override bool IsValid(object? value)
        {
            if (value == null)
                return true;

            return base.IsValid(value);
        }
    }
}
