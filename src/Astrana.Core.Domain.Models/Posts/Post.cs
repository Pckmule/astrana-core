/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Posts.Constants;
using Astrana.Core.Domain.Models.Posts.Contracts;
using Astrana.Core.Domain.Models.System.Contracts;
using Astrana.Core.Validation;
using System.ComponentModel.DataAnnotations;

namespace Astrana.Core.Domain.Models.Posts
{
    public sealed class Post : BaseDomainModel, IPost, IEditableEntity<long>, IAuditable<Guid>, IDeactivatable<Guid>
    {
        public Post()
        {
            NameUnique = ModelProperties.Post.NameUnique;
            NameSingularForm = ModelProperties.Post.NameSingularForm;
            NamePluralForm = ModelProperties.Post.NamePluralForm;
        }

        [Required]
        [Range(ModelProperties.Post.IdMinLength, ModelProperties.Post.IdMaxLength)]
        public long Id { get; set; }

        [Required]
        [MinLength(ModelProperties.Post.MinimumTextLength)]
        [MaxLength(ModelProperties.Post.MaximumTextLength)]
        public string Text { get; set; } = "";

        public PostAttachment? Attachment { get; set; }

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