/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Framework.SystemEvents.MessageTypes;

namespace Astrana.Core.Domain.Posts.Commands
{
    public class UpdatePostCommand : Command
    {
        public UpdatePostCommand(long postId, string text)
        {
            PostId = postId;
            Text = text;
        }

        public long PostId { get; private set; }

        public string Text { get; private set; }
    }
}
