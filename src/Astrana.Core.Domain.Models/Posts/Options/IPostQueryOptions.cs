/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Attachments.Enums;
using Astrana.Core.Domain.Models.Tags.Enums;

namespace Astrana.Core.Domain.Models.Posts.Options
{
    public interface IPostQueryOptions
    {
        List<string> Tags { get; set; }

        TagFilterMode TagsFilterMode { get; set; }

        List<AttachmentType>? AttachmentTypes { get; set; }
    }
}