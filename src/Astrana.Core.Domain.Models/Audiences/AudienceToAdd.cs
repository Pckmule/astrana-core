/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using System.ComponentModel.DataAnnotations;
using Astrana.Core.Domain.Models.Audiences.Constants;
using Astrana.Core.Domain.Models.Audiences.Contracts;
using Astrana.Core.Framework.Domain;
using Astrana.Core.Framework.Model.Validation;

namespace Astrana.Core.Domain.Models.Audiences
{
    public class AudienceToAdd : DomainEntity, IAudienceToAdd
    {
        public AudienceToAdd()
        {
            NameUnique = ModelProperties.Audience.NameUnique;
            NameSingularForm = ModelProperties.Audience.NameSingularForm;
            NamePluralForm = ModelProperties.Audience.NamePluralForm;
        }

        [Required]
        [MinLength(ModelProperties.Audience.MinimumNameLength)]
        [MaxLength(ModelProperties.Audience.MaximumNameLength)]
        public string Name { get; set; }

        [Required]
        [MinLength(ModelProperties.Audience.MinimumDescriptionLength)]
        [MaxLength(ModelProperties.Audience.MaximumDescriptionLength)]
        public string Description { get; set; }
        
        public override EntityValidationResult Validate()
        {
            return this.ValidateDomainModel();
        }
    }
}