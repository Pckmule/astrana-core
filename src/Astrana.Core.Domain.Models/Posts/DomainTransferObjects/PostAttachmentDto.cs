/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Attachments.Enums;
using Astrana.Core.Domain.Models.AudioClips.DomainTransferObjects;
using Astrana.Core.Domain.Models.ContentCollections.DomainTransferObjects;
using Astrana.Core.Domain.Models.Feelings.DomainTransferObjects;
using Astrana.Core.Domain.Models.Images.DomainTransferObjects;
using Astrana.Core.Domain.Models.Links.DomainTransferObjects;
using Astrana.Core.Domain.Models.Videos.DomainTransferObjects;
using Astrana.Core.Framework.Model;

namespace Astrana.Core.Domain.Models.Posts.DomainTransferObjects
{
    public class PostAttachmentDto : IDomainTransferObject
    {
        public Guid? Id { get; set; }

        public AttachmentType? Type { get; set; }

        public LinkDto? Link { get; set; }

        public Guid? LinkId { get; set; }

        public ImageDto? Image { get; set; }

        public Guid? ImageId { get; set; }

        public VideoDto? Video { get; set; }

        public Guid? VideoId { get; set; }

        public AudioDto? Audio { get; set; }

        public Guid? AudioId { get; set; }

        public ContentCollectionDto? ContentCollection { get; set; }

        public Guid? ContentCollectionId { get; set; }

        public FeelingDto? Feeling { get; set; }

        public Guid? FeelingId { get; set; }

        public ImageDto? Gif { get; set; }

        public Guid? GifId { get; set; }

        [Obsolete]
        public string? Address { get; set; }

        public string? Title { get; set; }

        public string? Caption { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public DateTimeOffset? CreatedTimestamp { get; set; }

        public DateTimeOffset? LastModifiedTimestamp { get; set; }
    }
}
