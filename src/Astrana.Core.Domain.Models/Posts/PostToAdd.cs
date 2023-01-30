/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Posts.Constants;
using Astrana.Core.Domain.Models.Posts.Contracts;
using Astrana.Core.Validation;
using System.ComponentModel.DataAnnotations;

namespace Astrana.Core.Domain.Models.Posts
{
    public class PostToAdd : BaseDomainModel, IPostToAdd
    {
        public PostToAdd()
        {
            NameUnique = ModelProperties.Post.NameUnique;
            NameSingularForm = ModelProperties.Post.NameSingularForm;
            NamePluralForm = ModelProperties.Post.NamePluralForm;
        }

        [Required]
        [MinLength(ModelProperties.Post.MinimumTextLength)]
        [MaxLength(ModelProperties.Post.MaximumTextLength)]
        public string Text { get; set; } = "";

        public PostAttachmentToAdd? Attachment { get; set; }

        public override EntityValidationResult Validate()
        {
            return this.ValidateDomainModel();
        }
    }
}
