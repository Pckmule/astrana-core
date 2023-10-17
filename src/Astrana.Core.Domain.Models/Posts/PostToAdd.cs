/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Posts.Constants;
using Astrana.Core.Domain.Models.Posts.Contracts;
using System.ComponentModel.DataAnnotations;
using Astrana.Core.Framework.Domain;
using Astrana.Core.Framework.Model.Validation;
using Astrana.Core.Framework.Model.Validation.Attributes;

namespace Astrana.Core.Domain.Models.Posts
{
    public class PostToAdd : DomainEntity, IPostToAdd
    {
        public PostToAdd()
        {
            NameUnique = ModelProperties.Post.NameUnique;
            NameSingularForm = ModelProperties.Post.NameSingularForm;
            NamePluralForm = ModelProperties.Post.NamePluralForm;
        }

        [RequiredOnCondition(nameof(Attachments), Condition.ItemCountLessThan, 1)]
        [MinLength(ModelProperties.Post.MinimumTextLength)]
        [MaxLength(ModelProperties.Post.MaximumTextLength)]
        public string Text { get; set; } = "";

        public List<PostAttachmentToAdd> Attachments { get; set; } = new();

        public override EntityValidationResult Validate()
        {
            return this.ValidateDomainModel();
        }
    }
}
