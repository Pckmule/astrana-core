/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Framework.SystemEvents.MessageTypes;

namespace Astrana.Core.Domain.Notifications.Commands
{
    public class CreateNotificationCommand : Command
    {
        public CreateNotificationCommand(string text)
        {
            Text = text;
        }

        public string Text { get; private set; }
    }
}
