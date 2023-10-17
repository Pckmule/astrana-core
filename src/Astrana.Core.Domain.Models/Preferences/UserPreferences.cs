/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Countries;
using Astrana.Core.Domain.Models.Languages;
using Astrana.Core.Domain.Models.Preferences.Constants;
using Astrana.Core.Domain.Models.Preferences.Contracts;
using System.ComponentModel.DataAnnotations;
using Astrana.Core.Framework.Domain;
using Astrana.Core.Framework.Model.Validation;

namespace Astrana.Core.Domain.Models.Preferences
{
    public sealed class UserPreferences : DomainEntity, IUserPreferences
    {
        public UserPreferences()
        {
            NameUnique = ModelProperties.UserPreferences.NameUnique;
            NameSingularForm = ModelProperties.UserPreferences.NameSingularForm;
            NamePluralForm = ModelProperties.UserPreferences.NamePluralForm;
        }

        [Required]
        public Guid UserAccountId { get; set; }

        [Required]
        public LanguageLite? Language { get; set; }

        [Required]
        public CountryLite? Country { get; set; }

        public override EntityValidationResult Validate()
        {
            return this.ValidateDomainModel();
        }
    }
}