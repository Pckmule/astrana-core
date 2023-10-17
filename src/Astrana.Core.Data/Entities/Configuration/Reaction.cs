/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ModelProperties = Astrana.Core.Domain.Models.Reactions.Constants.ModelProperties;

#nullable disable

namespace Astrana.Core.Data.Entities.Configuration
{
    [Table("Reactions", Schema = SchemaNames.Configuration)]
    public class Reaction : BaseDeactivatableEntity<Guid, Guid>
    {
        [Required]
        [MinLength(ModelProperties.Reaction.MinimumNameLength)]
        [MaxLength(ModelProperties.Reaction.MaximumNameLength)]
        [Column(Order = 1)]
        public string Name { get; set; }

        [Required]
        [MinLength(ModelProperties.Reaction.MinimumNameTrxCodeLength)]
        [MaxLength(ModelProperties.Reaction.MaximumNameTrxCodeLength)]
        [Column(Order = 2)]
        public string NameTrxCode { get; set; }

        [Required]
        [MinLength(ModelProperties.Reaction.MinimumIconNameLength)]
        [MaxLength(ModelProperties.Reaction.MaximumIconNameLength)]
        [Column(Order = 3)]
        public string IconName { get; set; }

        [Required]
        [MinLength(ModelProperties.Reaction.MinimumUnicodeIconLength)]
        [MaxLength(ModelProperties.Reaction.MaximumUnicodeIconLength)]
        [Column(Order = 4)]
        public string UnicodeIcon { get; set; }
    }
}
