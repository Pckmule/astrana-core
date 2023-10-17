/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using System.Collections.ObjectModel;
using Astrana.Core.Data.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astrana.Core.Data.Entities.Content;
using Astrana.Core.Data.Entities.Peers;
using Index = Microsoft.EntityFrameworkCore.IndexAttribute;
using DomainModelProperties = Astrana.Core.Domain.Models.Audiences.Constants.ModelProperties;

#nullable disable

namespace Astrana.Core.Data.Entities.Configuration
{
    [Table("Audiences", Schema = SchemaNames.Configuration)]
    [Index(nameof(Name), IsUnique = true)]
    public class Audience : BaseDeactivatableEntity<Guid, Guid>
    {
        [Required]
        [MinLength(DomainModelProperties.Audience.MinimumNameLength)]
        [MaxLength(DomainModelProperties.Audience.MaximumNameLength)]
        [Column(Order = 1)]
        public string Name { get; set; }

        [Required]
        [MinLength(DomainModelProperties.Audience.MinimumDescriptionLength)]
        [MaxLength(DomainModelProperties.Audience.MaximumDescriptionLength)]
        [Column(Order = 2)]
        public string Description { get; set; }

        [Column(Order = 3)]
        public Collection<Peer> PeersIncluded { get; set; }

        [Column(Order = 4)]
        public Collection<Peer> PeersExcluded { get; set; }

        [Column(Order = 5)]
        public short? MinimumAge { get; set; }

        [Column(Order = 6)]
        public short? MaximumAge { get; set; }

        [Column(Order = 7)]
        public Collection<Country> Countries { get; set; }

        [Column(Order = 8)]
        public Collection<Tag> Tags { get; set; }
    }
}
