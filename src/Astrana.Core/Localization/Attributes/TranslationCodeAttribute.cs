/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

namespace Astrana.Core.Localization.Attributes
{
    /// <summary>
    /// Indicates the translation code to use to lookup the translated text for the property.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Enum)]
    public class TranslationCodeAttribute : Attribute
    {
        public readonly string TrxCode;

        public TranslationCodeAttribute(string translationCode) 
        {
            TrxCode = translationCode;
        }
    }
}
