/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DomainModelProperties = Astrana.Core.Domain.Models.TopLevelDomains.Constants.ModelProperties;

#nullable disable

namespace Astrana.Core.Data.Entities.Configuration
{
    [Table("TopLevelDomains", Schema = SchemaNames.Configuration)]
    public class TopLevelDomain
    {
        [Key, Column(Order = 0)]
        public Guid TopLevelDomainId { get; set; }

        [MinLength(DomainModelProperties.TopLevelDomain.MinimumDomainLength)]
        public string Domain { get; set; }

        public long CountryId { get; set; }

        public Country Country { get; set; }

        public bool IsImplemented { get; set; }
        
        public DateTimeOffset? DeactivatedTimestamp { get; set; }

        public string DeactivatedReason { get; set; }

        public Guid? DeactivatedBy { get; set; }

        public Guid CreatedBy { get; set; }

        public Guid LastModifiedBy { get; set; }

        public DateTimeOffset CreatedTimestamp { get; set; }

        public DateTimeOffset LastModifiedTimestamp { get; set; }
    }
}
