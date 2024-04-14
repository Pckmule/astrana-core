/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

namespace Astrana.Core.Attributes
{
    /// <summary>
    /// Indicates that a property is considered to be data that should be protected.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class ProtectedDataAttribute : Attribute
    {
        public ProtectedDataAttribute() { }
    }
}
