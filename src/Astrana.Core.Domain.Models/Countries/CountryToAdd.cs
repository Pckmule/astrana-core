/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Countries.Constants;
using Astrana.Core.Domain.Models.Countries.Contracts;
using Astrana.Core.Domain.Models.Languages;
using Astrana.Core.Validation;
using System.ComponentModel.DataAnnotations;

namespace Astrana.Core.Domain.Models.Countries
{
    public class CountryToAdd : BaseDomainModel, ICountryToAdd
    {
        public CountryToAdd()
        {
            NameUnique = ModelProperties.Country.NameUnique;
            NameSingularForm = ModelProperties.Country.NameSingularForm;
            NamePluralForm = ModelProperties.Country.NamePluralForm;
        }

        [Required]
        [MinLength(ModelProperties.Country.MinimumNameLength)]
        [MaxLength(ModelProperties.Country.MaximumNameLength)]
        public string Name { get; set; }

        [MinLength(ModelProperties.Country.MinimumNameTrxCodeLength)]
        [MaxLength(ModelProperties.Country.MaximumNameTrxCodeLength)]
        public string NameTrxCode { get; set; }

        [Required]
        [MinLength(ModelProperties.Country.MinimumTwoLetterCodeLength)]
        [MaxLength(ModelProperties.Country.MaximumTwoLetterCodeLength)]
        public string TwoLetterCode { get; set; }

        [MinLength(ModelProperties.Country.MinimumThreeLetterCodeLength)]
        [MaxLength(ModelProperties.Country.MaximumThreeLetterCodeLength)]
        public string ThreeLetterCode { get; set; }

        [Required]
        public List<LanguageToAdd> Languages { get; set; } = new();

        public override EntityValidationResult Validate()
        {
            return this.ValidateDomainModel();
        }
    }
}