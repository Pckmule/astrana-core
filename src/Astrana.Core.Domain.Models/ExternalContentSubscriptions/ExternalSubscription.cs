/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using System.ComponentModel.DataAnnotations;
using Astrana.Core.Domain.Models.ExternalContentSubscriptions.Constants;
using Astrana.Core.Domain.Models.ExternalContentSubscriptions.Contracts;
using Astrana.Core.Domain.Models.Images;
using Astrana.Core.Domain.Models.System.Contracts;
using Astrana.Core.Framework.Domain;
using Astrana.Core.Framework.Model;
using Astrana.Core.Framework.Model.Validation;

namespace Astrana.Core.Domain.Models.ExternalContentSubscriptions
{
    public sealed class ExternalSubscription : DomainEntity, IExternalSubscription, IAuditable<Guid>, IDeactivatable<Guid>
    {
        public ExternalSubscription()
        {
            NameUnique = ModelProperties.ExternalContentSubscription.NameUnique;
            NameSingularForm = ModelProperties.ExternalContentSubscription.NameSingularForm;
            NamePluralForm = ModelProperties.ExternalContentSubscription.NamePluralForm;
        }

        [Required]
        [Range(ModelProperties.ExternalContentSubscription.IdMinLength, ModelProperties.ExternalContentSubscription.IdMaxLength)]
        public Guid LinkId { get; set; }

        [Required]
        [MinLength(ModelProperties.ExternalContentSubscription.MinimumUrlLength)]
        [MaxLength(ModelProperties.ExternalContentSubscription.MaximumUrlLength)]
        public Uri Url { get; set; }

        [Required]
        [MinLength(ModelProperties.ExternalContentSubscription.MinimumTitleLength)]
        [MaxLength(ModelProperties.ExternalContentSubscription.MaximumTitleLength)]
        public string Title { get; set; }

        [Required]
        [MinLength(ModelProperties.ExternalContentSubscription.MinimumDescriptionLength)]
        [MaxLength(ModelProperties.ExternalContentSubscription.MaximumDescriptionLength)]
        public string? Description { get; set; }

        public string? Locale { get; set; }

        public string? CharSet { get; set; }

        public string? AccessToken { get; set; }

        public Image PreviewImage { get; set; }

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