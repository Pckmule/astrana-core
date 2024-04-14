/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Lookups.Contracts;

namespace Astrana.Core.Domain.Models.Lookups
{
    public class LookupOption: ILookupOption
    {
        public LookupOption(string value, string? label, string? labelTranslationCode = null, string? iconName = null, string? iconAddress = null)
        {
            Value = value;
            Label = string.IsNullOrEmpty(label) ? value : label;
            TrxCode = labelTranslationCode;
            IconName = iconName;
            IconAddress = iconAddress;
        }

        public string Value { get; set; }
        
        public string? Label { get; set; }
        
        public string? TrxCode { get; set; }

        public string? IconName { get; set; }

        public string? IconAddress { get; set; }
    }
}