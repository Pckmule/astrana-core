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
    public class PostAttachmentToAdd : BaseDomainModel, IPostAttachmentToAdd
    {
        [Required]
        [MinLength(ModelProperties.PostAttachment.MinimumAddressLength)]
        [MaxLength(ModelProperties.PostAttachment.MaximumAddressLength)]
        public string Address { get; set; } = "";

        [MaxLength(ModelProperties.PostAttachment.MaximumTitleLength)]
        public string? Title { get; set; }

        [MaxLength(ModelProperties.PostAttachment.MaximumCaptionLength)]
        public string? Caption { get; set; }

        public override EntityValidationResult Validate()
        {
            return this.ValidateDomainModel();
        }
    }
}
