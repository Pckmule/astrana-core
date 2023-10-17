/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.ContentCollections;
using Astrana.Core.Domain.Models.Attachments.Enums;
using Astrana.Core.Domain.Models.Feelings;
using Astrana.Core.Domain.Models.Images;
using Astrana.Core.Domain.Models.Links;

namespace Astrana.Core.Domain.Models.Posts.Contracts
{
    public interface IPostAttachmentToAdd
    {
        AttachmentType Type { get; set; }

        string ContentId { get; set; }

        Guid ImageId { get; set; }

        Guid ContentCollectionId { get; set; }

        Guid FeelingId { get; set; }

        Guid GifId { get; set; }

        string Address { get; set; }

        string? Title { get; set; }

        string? Caption { get; set; }

        public LinkToAdd? Link { get; set; }

        public Image? Image { get; set; }

        public ContentCollection? ContentCollection { get; set; }

        public Feeling? Feeling { get; set; }

        public Image? Gif { get; set; }
    }
}