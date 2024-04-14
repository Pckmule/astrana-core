/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Notifications.Contracts;
using Astrana.Core.Domain.Models.Notifications.Enums;
using Astrana.Core.Framework.Model;

namespace Astrana.Core.Domain.Models.Notifications.DomainTransferObjects
{
    public sealed class AddNotificationDto: INotification, IDomainTransferObject
    {
        public NotificationType? Type { get; set; }

        public string? Message { get; set; }

        public NotificationSourceType? SourceType { get; set; }

        public string? SourceId { get; set; }
    }
}