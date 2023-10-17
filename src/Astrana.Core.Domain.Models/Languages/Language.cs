/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Languages.Constants;
using Astrana.Core.Domain.Models.Languages.Contracts;
using Astrana.Core.Domain.Models.Lookups.Attributes;
using Astrana.Core.Enums;
using Astrana.Core.Framework.Domain;
using Astrana.Core.Framework.Model;
using Astrana.Core.Framework.Model.Validation;
using System.ComponentModel.DataAnnotations;

namespace Astrana.Core.Domain.Models.Languages
{
    public class Language : DomainEntity, ILanguage, IAuditable<Guid>, IDeactivatable<Guid>
    {
        private string _code;
        private string _twoLetterCode;
        private string _threeLetterCode;

        public Language()
        {
            NameUnique = ModelProperties.Language.NameUnique;
            NameSingularForm = ModelProperties.Language.NameSingularForm;
            NamePluralForm = ModelProperties.Language.NamePluralForm;
        }

        public Guid LanguageId { get; set; }

        [Required]
        [MinLength(ModelProperties.Language.MinimumNameLength)]
        [MaxLength(ModelProperties.Language.MaximumNameLength)]
        [LookupOptionLabel]
        public string Name { get; set; }

        [Required]
        [MinLength(ModelProperties.Language.MinimumNameLength)]
        [MaxLength(ModelProperties.Language.MaximumNameLength)]
        [LookupOptionTranslationCode]
        public string NameTrxCode { get; set; }

        [Required]
        [MinLength(ModelProperties.Language.MinimumCodeLength)]
        [MaxLength(ModelProperties.Language.MaximumCodeLength)]
        [LookupOptionValue]
        public string Code
        {
            get => _code;
            set => _code = value.ToUpperInvariant();
        }

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

        [Required]
        public LanguageDirection Direction { get; set; }

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