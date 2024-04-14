/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DomainModelProperties = Astrana.Core.Domain.Models.Peers.Constants.ModelProperties;

#nullable disable

namespace Astrana.Core.Data.Entities.Peers
{
    [Table("PeerCircles", Schema = SchemaNames.Default)]
    public class PeerCircle
    {
        [Key, Column(Order = 0)]
        public Guid PeerCircleId { get; set; }

        [MinLength(DomainModelProperties.PeerCircle.MinimumNameLength)]
        public string Name { get; set; }
        
        [MinLength(DomainModelProperties.PeerCircle.MinimumNameTrxCodeLength)]
        public string NameTrxCode { get; set; }

        [MinLength(DomainModelProperties.PeerCircle.MinimumDescriptionLength)]
        public string Description { get; set; }

        [MinLength(DomainModelProperties.PeerCircle.MinimumDescriptionTrxCodeLength)]
        public string DescriptionTrxCode { get; set; }

        public ICollection<Peer> Peers { get; set; } = new List<Peer>();

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
