/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Astrana.Core.Extensions
{
    public static class EnumExtensions
    {
        public static string GetDescription(this Enum value)
        {
            var type = value.GetType();
            var name = Enum.GetName(type, value);

            if (name == null) 
                return value.ToString();

            var field = type.GetField(name);
                
            if (field == null) 
                return value.ToString();

            return Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) is DescriptionAttribute attr ? attr.Description : value.ToString();
        }

        public static string GetDisplayText(this Enum value)
        {
            var type = value.GetType();

            var name = Enum.GetName(type, value);

            if (name == null) 
                return value.GetDescription();

            var field = type.GetField(name);
            
            if (field == null) 
                return value.GetDescription();

            var attribute = Attribute.GetCustomAttribute(field, typeof(DisplayAttribute)) as DisplayAttribute;
            
            if (attribute != null)
            {
                return attribute.Name ?? "";
            }

            return value.GetDescription();
        }
    }
}
