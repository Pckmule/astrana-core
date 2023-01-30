/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using System.ComponentModel.DataAnnotations;

namespace Astrana.Core.Validation.Attributes
{
    public class MinLengthWhenSetAttribute : MinLengthAttribute
    {
        public MinLengthWhenSetAttribute(int length) : base(length) { }

        public override bool IsValid(object? value)
        {
            if (value == null) 
                return false;
            
            return base.IsValid(value);
        }
    }
}
