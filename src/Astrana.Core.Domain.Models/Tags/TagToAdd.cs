/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Tags.Constants;
using Astrana.Core.Domain.Models.Tags.Contracts;
using Astrana.Core.Validation;
using System.ComponentModel.DataAnnotations;

namespace Astrana.Core.Domain.Models.Tags
{
    public class TagToAdd : BaseDomainModel, ITagToAdd
    {
        public TagToAdd()
        {
            NameUnique = ModelProperties.Tag.NameUnique;
            NameSingularForm = ModelProperties.Tag.NameSingularForm;
            NamePluralForm = ModelProperties.Tag.NamePluralForm;
        }

        [Required]
        [MinLength(ModelProperties.Tag.MinimumTextLength)]
        [MaxLength(ModelProperties.Tag.MaximumTextLength)]
        public string Text { get; set; } = "";

        public override EntityValidationResult Validate()
        {
            return this.ValidateDomainModel();
        }
    }
}
