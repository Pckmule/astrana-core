/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Localization.Attributes;

namespace Astrana.Core.Domain.Models.Notifications.Enums
{
    [TranslationCode("notification_type")]
    public enum NotificationType
    {
        [TranslationCode("new_peer_connection_request")]
        NewPeerConnectionRequest = 1,

        [TranslationCode("new_peer_connection_request")]
        AcceptNewPeerConnectionRequest = 2,
        
        [TranslationCode("new_comment")]
        NewComment = 3,

        [TranslationCode("new_reaction")]
        NewReaction = 4
    }
}
