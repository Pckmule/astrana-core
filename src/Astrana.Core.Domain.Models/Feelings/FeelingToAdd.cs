/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Feelings.Constants;
using Astrana.Core.Domain.Models.Feelings.Contracts;
using System.ComponentModel.DataAnnotations;
using Astrana.Core.Framework.Domain;
using Astrana.Core.Framework.Model.Validation;

namespace Astrana.Core.Domain.Models.Feelings
{
    public class FeelingToAdd : DomainEntity, IFeelingToAdd
    {
        public FeelingToAdd()
        {
            NameUnique = ModelProperties.Feeling.NameUnique;
            NameSingularForm = ModelProperties.Feeling.NameSingularForm;
            NamePluralForm = ModelProperties.Feeling.NamePluralForm;
        }

        [Required]
        [MinLength(ModelProperties.Feeling.MinimumNameLength)]
        [MaxLength(ModelProperties.Feeling.MaximumNameLength)]
        public string Name { get; set; }

        [Required]
        [MinLength(ModelProperties.Feeling.MinimumNameTrxCodeLength)]
        [MaxLength(ModelProperties.Feeling.MaximumNameTrxCodeLength)]
        public string NameTrxCode { get; set; }

        [Required]
        [MinLength(ModelProperties.Feeling.MinimumIconNameLength)]
        [MaxLength(ModelProperties.Feeling.MaximumIconNameLength)]
        public string IconName { get; set; }

        [Required]
        [MinLength(ModelProperties.Feeling.MinimumUnicodeIconLength)]
        [MaxLength(ModelProperties.Feeling.MaximumUnicodeIconLength)]
        public string UnicodeIcon { get; set; }

        [Required]
        [MinLength(ModelProperties.Feeling.MinimumShortCodeLength)]
        [MaxLength(ModelProperties.Feeling.MaximumShortCodeLength)]
        public string ShortCode { get; set; }

        public override EntityValidationResult Validate()
        {
            return this.ValidateDomainModel();
        }
    }
}
