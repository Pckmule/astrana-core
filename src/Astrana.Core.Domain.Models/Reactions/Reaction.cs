/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Reactions.Constants;
using Astrana.Core.Domain.Models.Reactions.Contracts;
using Astrana.Core.Framework.Domain;
using Astrana.Core.Framework.Model;
using Astrana.Core.Framework.Model.Validation;
using System.ComponentModel.DataAnnotations;

namespace Astrana.Core.Domain.Models.Reactions
{
    public sealed class Reaction : DomainEntity, IReaction, IAuditable<Guid>, IDeactivatable<Guid>
    {
        public Reaction()
        {
            NameUnique = ModelProperties.Reaction.NameUnique;
            NameSingularForm = ModelProperties.Reaction.NameSingularForm;
            NamePluralForm = ModelProperties.Reaction.NamePluralForm;
        }

        [Required]
        public Guid ReactionId { get; set; }

        [Required]
        [MinLength(ModelProperties.Reaction.MinimumNameLength)]
        [MaxLength(ModelProperties.Reaction.MaximumNameLength)]
        public string Name { get; set; }

        [Required]
        [MinLength(ModelProperties.Reaction.MinimumNameTrxCodeLength)]
        [MaxLength(ModelProperties.Reaction.MaximumNameTrxCodeLength)]
        public string NameTrxCode { get; set; }
        
        [Required]
        [MinLength(ModelProperties.Reaction.MinimumIconNameLength)]
        [MaxLength(ModelProperties.Reaction.MaximumIconNameLength)]
        public string IconName { get; set; }

        [Required]
        [MinLength(ModelProperties.Reaction.MinimumUnicodeIconLength)]
        [MaxLength(ModelProperties.Reaction.MaximumUnicodeIconLength)]
        public string UnicodeIcon { get; set; }

        [Required]
        public Guid CreatedBy { get; set; }

        [Required]
        public Guid LastModifiedBy { get; set; }

        [Required]
        public DateTimeOffset CreatedTimestamp { get; set; }

        [Required]
        public DateTimeOffset LastModifiedTimestamp { get; set; }

        public DateTimeOffset? DeactivatedTimestamp { get; set; }

        public string? DeactivatedReason { get; set; }

        public Guid? DeactivatedBy { get; set; }

        public override EntityValidationResult Validate()
        {
            return this.ValidateDomainModel();
        }
    }
}