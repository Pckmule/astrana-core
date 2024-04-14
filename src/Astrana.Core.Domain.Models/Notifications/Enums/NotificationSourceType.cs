/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Localization.Attributes;

namespace Astrana.Core.Domain.Models.Notifications.Enums
{
    [TranslationCode("notification_source_type")]
    public enum NotificationSourceType
    {
        [TranslationCode("peer")]
        Peer = 1
    }
}
