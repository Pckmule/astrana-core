/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.ExternalContent.Subscriptions.Constants;
using Astrana.Core.Domain.Models.ExternalContent.Subscriptions.Contracts;
using Astrana.Core.Framework.Domain;
using Astrana.Core.Framework.Model.Validation;
using System.ComponentModel.DataAnnotations;

namespace Astrana.Core.Domain.Models.ExternalContent.Subscriptions
{
    public class ExternalContentSubscriptionToAdd : DomainEntity, IExternalContentSubscriptionToAdd
    {
        public ExternalContentSubscriptionToAdd()
        {
            NameUnique = ModelProperties.ExternalContentSubscription.NameUnique;
            NameSingularForm = ModelProperties.ExternalContentSubscription.NameSingularForm;
            NamePluralForm = ModelProperties.ExternalContentSubscription.NamePluralForm;
        }

        [Required]
        public Uri Url { get; set; }
        
        public string? AccessToken { get; set; }
        
        public override EntityValidationResult Validate()
        {
            return this.ValidateDomainModel();
        }
    }
}
