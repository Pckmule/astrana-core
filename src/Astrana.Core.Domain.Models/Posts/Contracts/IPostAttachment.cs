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
    public interface IPostAttachment
    {
        AttachmentType Type { get; set; }

        string? Title { get; set; }

        string? Caption { get; set; }

        Link? Link { get; set; }

        Guid? LinkId { get; set; }

        Image? Image { get; set; }

        Guid? ImageId { get; set; }

        ContentCollection? ContentCollection { get; set; }

        Guid? ContentCollectionId { get; set; }

        Feeling? Feeling { get; set; }

        Guid? FeelingId { get; set; }

        Image? Gif { get; set; }

        Guid? GifId { get; set; }
    }
}