/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Lookups.Contracts;

namespace Astrana.Core.Domain.Models.Lookups
{
    public class Lookup: ILookup
    {
        public Lookup(string label, string translationCode = "", string? iconAddress = null, List<LookupOption>? options = null)
        {
            Label = label;
            TrxCode = translationCode;
            IconAddress = iconAddress;
            Options = options ?? new List<LookupOption>();
        }

        public string Label { get; set; }

        public string TrxCode { get; set; }

        public string? IconAddress { get; set; }

        public List<LookupOption> Options { get; set; }
    }
}