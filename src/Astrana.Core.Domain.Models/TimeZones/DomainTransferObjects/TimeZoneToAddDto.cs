/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Countries;
using Astrana.Core.Framework.Model;

namespace Astrana.Core.Domain.Models.TimeZones.DomainTransferObjects
{
    public sealed class TimeZoneToAddDto : IDomainTransferObject
    {
        public string? Name { get; set; }

        public string? NameTrxCode { get; set; }

        public string? Abbreviation { get; set; }

        public string? CorrespondingUtcZone { get; set; }

        public HashSet<Country>? Countries { get; set; }

        public bool? DaylightSavingApplies { get; set; }
    }
}