/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Notifications.Enums;
using Astrana.Core.Framework.Model;

namespace Astrana.Core.Domain.Models.Notifications.DomainTransferObjects
{
    public sealed class NotificationStatusDto: IDomainTransferObject
    {
        public Guid? Id { get; set; }

        public NotificationType? Type { get; set; }

    }
}