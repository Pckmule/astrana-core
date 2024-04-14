/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

namespace Astrana.Core.Attributes
{
    /// <summary>
    /// Indicates the name of the icon image that is associated the Property/Attribute/Enum.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Enum)]
    public class IconNameAttribute : Attribute
    {
        public readonly string? Name;

        public IconNameAttribute(string? name = null)
        {
            Name = name;
        }
    }
}
