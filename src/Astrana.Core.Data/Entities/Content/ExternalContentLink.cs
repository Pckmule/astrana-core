/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ModelProperties = Astrana.Core.Domain.Models.ExternalContent.ContentLinks.Constants.ModelProperties;

#nullable disable

namespace Astrana.Core.Data.Entities.Content
{
    [Table("ExternalContentLinks", Schema = SchemaNames.Content)]
    public class ExternalContentLink
    {
        [Key, Column(Order = 0)]
        public Guid ExternalContentLinkId { get; set; }

        [Required]
        [MinLength(ModelProperties.ContentLink.MinimumUrlLength)]
        [MaxLength(ModelProperties.ContentLink.MaximumUrlLength)]
        [Column(Order = 1)]
        public Uri Href { get; set; }

        [Required]
        [MinLength(ModelProperties.ContentLink.MinimumTextLength)]
        [MaxLength(ModelProperties.ContentLink.MaximumTextLength)]
        [Column(Order = 2)]
        public string Text { get; set; }

        [MinLength(ModelProperties.ContentLink.MinimumRelLength)]
        [MaxLength(ModelProperties.ContentLink.MaximumRelLength)]
        [Column(Order = 3)]
        public string Rel { get; set; }
        
        [Required, Column(Order = 99996)]
        public Guid CreatedBy { get; set; }

        [Required, Column(Order = 99997)]
        public Guid LastModifiedBy { get; set; }

        [Required, Column(Order = 99998)]
        public DateTimeOffset CreatedTimestamp { get; set; }

        [Required, Column(Order = 99999)]
        public DateTimeOffset LastModifiedTimestamp { get; set; }
    }
}
