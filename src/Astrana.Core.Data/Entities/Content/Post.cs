/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DomainModelProperties = Astrana.Core.Domain.Models.Posts.Constants.ModelProperties;

#nullable disable

namespace Astrana.Core.Data.Entities.Content
{
    [Table("Posts", Schema = SchemaNames.Content)]
    public class Post : BaseDeactivatableEntity<long, Guid>
    {
        [Required]
        [MinLength(DomainModelProperties.Post.MinimumTextLength)]
        [MaxLength(DomainModelProperties.Post.MaximumTextLength)]
        [Column(Order = 1)]
        public string Text { get; set; }

        [Column(Order = 2)]
        public PostAttachment Attachment { get; set; }
    }
}
