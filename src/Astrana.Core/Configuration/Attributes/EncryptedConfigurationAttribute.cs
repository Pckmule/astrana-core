/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

namespace Astrana.Core.Configuration.Attributes
{
    /// <summary>
    /// Indicates that a property is considered to contain data that should be encrypted at rest and in transit.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class EncryptedConfigurationAttribute : Attribute
    {
        public EncryptedConfigurationAttribute() { }
    }
}
