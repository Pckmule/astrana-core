/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

namespace Astrana.Core.Domain.Models.Comments.Contracts
{
    public interface IComment
    {
        Guid CommentId { get; set; }

        string Text { get; set; }

        string ContentId { get; set; }

        Guid PeerId { get; set; }
    }
}