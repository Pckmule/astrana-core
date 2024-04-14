/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Audiences.Constants;
using Astrana.Core.Domain.Models.Audiences.Contracts;
using Astrana.Core.Framework.Domain;
using Astrana.Core.Framework.Model;
using Astrana.Core.Framework.Model.Validation;
using System.ComponentModel.DataAnnotations;

namespace Astrana.Core.Domain.Models.Audiences
{
    public class Audience : DomainEntity, IAudience, IAuditable<Guid>, IDeactivatable<Guid>
    {
        public Audience()
        {
            NameUnique = ModelProperties.Audience.NameUnique;
            NameSingularForm = ModelProperties.Audience.NameSingularForm;
            NamePluralForm = ModelProperties.Audience.NamePluralForm;
        }

        public Guid AudienceId { get; set; }

        [Required]
        [MinLength(ModelProperties.Audience.MinimumNameLength)]
        [MaxLength(ModelProperties.Audience.MaximumNameLength)]
        public string Name { get; set; }

        [Required]
        [MinLength(ModelProperties.Audience.MinimumNameTrxCodeLength)]
        [MaxLength(ModelProperties.Audience.MaximumNameTrxCodeLength)]
        public string NameTrxCode { get; set; }

        [Required]
        [MinLength(ModelProperties.Audience.MinimumDescriptionLength)]
        [MaxLength(ModelProperties.Audience.MaximumDescriptionLength)]
        public string Description { get; set; }

        [Required]
        [MinLength(ModelProperties.Audience.MinimumDescriptionTrxCodeLength)]
        [MaxLength(ModelProperties.Audience.MaximumDescriptionTrxCodeLength)]
        public string DescriptionTrxCode { get; set; }

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