/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Posts.Contracts;
using Astrana.Core.Framework.Model;

namespace Astrana.Core.Domain.Models.Posts.DomainTransferObjects
{
    public sealed class PostToAddDto: IPost, IDomainTransferObject
    {
        public string? Text { get; set; }

        public List<PostAttachment>? Attachments { get; set; }
    }
}