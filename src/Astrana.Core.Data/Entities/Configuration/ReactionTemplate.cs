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
    [Table("ReactionTemplates", Schema = SchemaNames.Configuration)]
    public class ReactionTemplate
    {
        [Key, Column(Order = 0)]
        public Guid ReactionTemplateId { get; set; }

        [MinLength(ModelProperties.Reaction.MinimumNameLength)]
        public string Name { get; set; }

        [MinLength(ModelProperties.Reaction.MinimumNameTrxCodeLength)]
        public string NameTrxCode { get; set; }

        [MinLength(ModelProperties.Reaction.MinimumIconNameLength)]
        public string IconName { get; set; }

        [MinLength(ModelProperties.Reaction.MinimumUnicodeIconLength)]
        public string UnicodeIcon { get; set; }

        public DateTimeOffset? DeactivatedTimestamp { get; set; }

        public string DeactivatedReason { get; set; } = null;
        
        public Guid? DeactivatedBy { get; set; }

        public Guid CreatedBy { get; set; }

        public Guid LastModifiedBy { get; set; }

        public DateTimeOffset CreatedTimestamp { get; set; }

        public DateTimeOffset LastModifiedTimestamp { get; set; }
    }
}
