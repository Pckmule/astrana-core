/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Attachments.Enums;
using Astrana.Core.Domain.Models.Posts.Constants;
using Astrana.Core.Domain.Models.Posts.Contracts;
using System.ComponentModel.DataAnnotations;
using Astrana.Core.Domain.Models.ContentCollections;
using Astrana.Core.Domain.Models.Feelings;
using Astrana.Core.Domain.Models.Images;
using Astrana.Core.Domain.Models.Links;
using Astrana.Core.Framework.Domain;
using Astrana.Core.Framework.Model.Validation;

namespace Astrana.Core.Domain.Models.Posts
{
    public class PostAttachmentToAdd : DomainEntity, IPostAttachmentToAdd
    {
        [Required]
        public AttachmentType Type { get; set; }

        // [MinLength(ModelProperties.PostAttachment.MinimumContentIdLength)]
        [MaxLength(ModelProperties.PostAttachment.MaximumContentIdLength)]
        public string ContentId { get; set; }

        public Guid ImageId { get; set; }

        public Guid ContentCollectionId { get; set; }

        public Guid FeelingId { get; set; }

        public Guid GifId { get; set; }

        // [MinLength(ModelProperties.PostAttachment.MinimumAddressLength)]
        [MaxLength(ModelProperties.PostAttachment.MaximumAddressLength)]
        public string Address { get; set; }

        [MaxLength(ModelProperties.PostAttachment.MaximumTitleLength)]
        public string? Title { get; set; }

        [MaxLength(ModelProperties.PostAttachment.MaximumCaptionLength)]
        public string? Caption { get; set; }

        public LinkToAdd? Link { get; set; }

        public Image? Image { get; set; }

        public ContentCollection? ContentCollection { get; set; }

        public Feeling? Feeling { get; set; }

        public Image? Gif { get; set; }

        public override EntityValidationResult Validate()
        {
            return this.ValidateDomainModel();
        }
    }
}
