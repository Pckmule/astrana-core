/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DomainModelProperties = Astrana.Core.Domain.Models.Countries.Constants.ModelProperties;

#nullable disable

namespace Astrana.Core.Data.Entities.Configuration
{
    [Table("Countries", Schema = SchemaNames.Configuration)]
    public class Country
    {
        [Key, Column(Order = 0)]
        public long CountryId { get; set; }
        
        [MinLength(DomainModelProperties.Country.MinimumNameLength)]
        public string Name { get; set; }
        
        [MinLength(DomainModelProperties.Country.MinimumNameTrxCodeLength)]
        public string NameTrxCode { get; set; }
        
        [MinLength(DomainModelProperties.Country.MinimumOfficialNameLength)]
        public string OfficialName { get; set; }
        
        [MinLength(DomainModelProperties.Country.MinimumOfficialNameTrxCodeLength)]
        public string OfficialNameTrxCode { get; set; }
        
        [MinLength(DomainModelProperties.Country.MinimumTwoLetterCodeLength)]
        public string TwoLetterCode { get; set; }
        
        [MinLength(DomainModelProperties.Country.MinimumThreeLetterCodeLength)]
        public string ThreeLetterCode { get; set; }

        public int? NumberCode { get; set; }

        public ICollection<TimeZone> TimeZones { get; set; } = new List<TimeZone>();

        public DateTimeOffset? DeactivatedTimestamp { get; set; }

        public string DeactivatedReason { get; set; } = null;

        public Guid? DeactivatedBy { get; set; }

        public Guid CreatedBy { get; set; }

        public Guid LastModifiedBy { get; set; }

        public DateTimeOffset CreatedTimestamp { get; set; }

        public DateTimeOffset LastModifiedTimestamp { get; set; }
    }
}
