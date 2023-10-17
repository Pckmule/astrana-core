/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using System.ComponentModel.DataAnnotations;
using Astrana.Core.Domain.Models.ExternalContentSubscriptions.Constants;
using Astrana.Core.Domain.Models.ExternalContentSubscriptions.Contracts;
using Astrana.Core.Domain.Models.Images;
using Astrana.Core.Framework.Domain;
using Astrana.Core.Framework.Model.Validation;

namespace Astrana.Core.Domain.Models.ExternalContentSubscriptions
{
    public class ExternalSubscriptionToAdd : DomainEntity, IExternalSubscriptionToAdd
    {
        public ExternalSubscriptionToAdd()
        {
            NameUnique = ModelProperties.ExternalContentSubscription.NameUnique;
            NameSingularForm = ModelProperties.ExternalContentSubscription.NameSingularForm;
            NamePluralForm = ModelProperties.ExternalContentSubscription.NamePluralForm;
        }
        
        public Uri Url { get; set; }

        [Required]
        [MinLength(ModelProperties.ExternalContentSubscription.MinimumTitleLength)]
        [MaxLength(ModelProperties.ExternalContentSubscription.MaximumTitleLength)]
        public string? Title { get; set; }

        [Required]
        [MinLength(ModelProperties.ExternalContentSubscription.MinimumDescriptionLength)]
        [MaxLength(ModelProperties.ExternalContentSubscription.MaximumDescriptionLength)]
        public string? Description { get; set; }

        public string? Locale { get; set; }

        public string? CharSet { get; set; }
        
        public string? AccessToken { get; set; }

        public ImageToAdd? PreviewImage { get; set; }

        public Guid? PreviewImageId { get; set; }

        public override EntityValidationResult Validate()
        {
            return this.ValidateDomainModel();
        }
    }
}
