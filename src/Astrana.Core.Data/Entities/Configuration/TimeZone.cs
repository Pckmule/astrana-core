/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DomainModelProperties = Astrana.Core.Domain.Models.TimeZones.Constants.ModelProperties;

#nullable disable

namespace Astrana.Core.Data.Entities.Configuration
{
    [Table("TimeZones", Schema = SchemaNames.Configuration)]
    public class TimeZone
    {
        [Key, Column(Order = 0)]
        public Guid TimeZoneId { get; set; }

        [MinLength(DomainModelProperties.TimeZone.MinimumNameLength)]
        public string Name { get; set; }

        [MinLength(DomainModelProperties.TimeZone.MinimumNameTrxCodeLength)]
        public string NameTrxCode { get; set; }

        [MinLength(DomainModelProperties.TimeZone.MinimumAbbreviationLength)]
        public string Abbreviation { get; set; }

        [MinLength(DomainModelProperties.TimeZone.MinimumCorrespondingUtcZoneLength)]
        public string CorrespondingUtcZone { get; set; }

        public ICollection<Country> Countries { get; set; } = new HashSet<Country>();

        public bool DaylightSavingApplies { get; set; }

        public Guid CreatedBy { get; set; }

        public Guid LastModifiedBy { get; set; }

        public DateTimeOffset CreatedTimestamp { get; set; }

        public DateTimeOffset LastModifiedTimestamp { get; set; }
    }
}