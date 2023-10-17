/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.ApiAccessTokens.Constants;
using Astrana.Core.Domain.Models.ApiAccessTokens.Contracts;
using System.ComponentModel.DataAnnotations;
using Astrana.Core.Framework.Domain;
using Astrana.Core.Framework.Model.Validation;

namespace Astrana.Core.Domain.Models.ApiAccessTokens
{
    public class ApiAccessTokenToAdd : DomainEntity, IApiAccessTokenToAdd
    {
        public ApiAccessTokenToAdd()
        {
            NameUnique = ModelProperties.ApiAccessToken.NameUnique;
            NameSingularForm = ModelProperties.ApiAccessToken.NameSingularForm;
            NamePluralForm = ModelProperties.ApiAccessToken.NamePluralForm;
        }

        [Required]
        [MinLength(ModelProperties.ApiAccessToken.MinimumTokenLength)]
        [MaxLength(ModelProperties.ApiAccessToken.MaximumTokenLength)]
        public string Token { get; set; } = "";
        
        public override EntityValidationResult Validate()
        {
            return this.ValidateDomainModel();
        }
    }
}
