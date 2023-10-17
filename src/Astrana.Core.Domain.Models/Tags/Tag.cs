/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Tags.Constants;
using Astrana.Core.Domain.Models.Tags.Contracts;
using Astrana.Core.Framework.Domain;
using Astrana.Core.Framework.Model;
using Astrana.Core.Framework.Model.Validation;
using System.ComponentModel.DataAnnotations;

namespace Astrana.Core.Domain.Models.Tags
{
    public sealed class Tag : DomainEntity, ITag, IAuditable<Guid>, IDeactivatable<Guid>
    {
        public Tag()
        {
            NameUnique = ModelProperties.Tag.NameUnique;
            NameSingularForm = ModelProperties.Tag.NameSingularForm;
            NamePluralForm = ModelProperties.Tag.NamePluralForm;
        }

        [Required]
        public Guid TagId { get; set; }

        [Required]
        [MinLength(ModelProperties.Tag.MinimumTextLength)]
        [MaxLength(ModelProperties.Tag.MaximumTextLength)]
        public string Text { get; set; } = "";

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