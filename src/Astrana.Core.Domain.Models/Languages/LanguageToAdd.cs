/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Languages.Constants;
using Astrana.Core.Domain.Models.Languages.Contracts;
using Astrana.Core.Validation;
using System.ComponentModel.DataAnnotations;

namespace Astrana.Core.Domain.Models.Languages
{
    public class LanguageToAdd : BaseDomainModel, ILanguageToAdd
    {
        private string _twoLetterCode = "";
        private string _threeLetterCode = "";

        public LanguageToAdd()
        {
            NameUnique = ModelProperties.Language.NameUnique;
            NameSingularForm = ModelProperties.Language.NameSingularForm;
            NamePluralForm = ModelProperties.Language.NamePluralForm;
        }

        [Required]
        [MinLength(ModelProperties.Language.MinimumNameLength)]
        [MaxLength(ModelProperties.Language.MaximumNameLength)]
        public string EnglishName { get; set; }

        [Required]
        [MinLength(ModelProperties.Language.MinimumNameLength)]
        [MaxLength(ModelProperties.Language.MaximumNameLength)]
        public string Name { get; set; }

        [Required]
        [MinLength(ModelProperties.Language.MinimumTwoLetterCodeLength)]
        [MaxLength(ModelProperties.Language.MaximumTwoLetterCodeLength)]
        public string TwoLetterCode
        {
            get => _twoLetterCode;
            set => _twoLetterCode = value.ToUpperInvariant();
        }

        [MinLength(ModelProperties.Language.MinimumThreeLetterCodeLength)]
        [MaxLength(ModelProperties.Language.MaximumThreeLetterCodeLength)]
        public string ThreeLetterCode
        {
            get => _threeLetterCode;
            set => _threeLetterCode = value.ToUpperInvariant();
        }

        public override EntityValidationResult Validate()
        {
            return this.ValidateDomainModel();
        }
    }
}