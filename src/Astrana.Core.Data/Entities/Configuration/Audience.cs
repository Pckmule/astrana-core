/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Constants;
using Astrana.Core.Data.Entities.Content;
using Astrana.Core.Data.Entities.Peers;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DomainModelProperties = Astrana.Core.Domain.Models.Audiences.Constants.ModelProperties;

#nullable disable

namespace Astrana.Core.Data.Entities.Configuration
{
    [Table("Audiences", Schema = SchemaNames.Configuration)]
    public class Audience
    {
        [Key, Column(Order = 0)]
        public Guid AudienceId { get; set; }

        [MinLength(DomainModelProperties.Audience.MinimumNameLength)]
        public string Name { get; set; }

        [MinLength(DomainModelProperties.Audience.MinimumNameTrxCodeLength)]
        public string NameTrxCode { get; set; }

        [MinLength(DomainModelProperties.Audience.MinimumDescriptionLength)]
        public string Description { get; set; }

        [MinLength(DomainModelProperties.Audience.MinimumDescriptionTrxCodeLength)]
        public string DescriptionTrxCode { get; set; }

        public ICollection<Peer> PeersIncluded { get; set; } = new HashSet<Peer>();

        public ICollection<Peer> PeersExcluded { get; set; } = new HashSet<Peer>();

        public short? MinimumAge { get; set; }

        public short? MaximumAge { get; set; }

        public ICollection<Country> Countries { get; set; } = new HashSet<Country>();

        public ICollection<Tag> Tags { get; set; } = new HashSet<Tag>();

        public bool IsUserDefined { get; set; }

        public DateTimeOffset? DeactivatedTimestamp { get; set; }

        public string DeactivatedReason { get; set; } = null;

        public Guid? DeactivatedBy { get; set; }

        public Guid CreatedBy { get; set; }

        public Guid LastModifiedBy { get; set; }

        public DateTimeOffset CreatedTimestamp { get; set; }

        public DateTimeOffset LastModifiedTimestamp { get; set; }
    }
}
