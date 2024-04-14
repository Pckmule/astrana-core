/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Notifications.Enums;
using Astrana.Core.Framework.Model;

namespace Astrana.Core.Domain.Models.Notifications.DomainTransferObjects
{
    public sealed class NotificationDto: IDomainTransferObject
    {
        public Guid? Id { get; set; }

        public NotificationType? Type { get; set; }

        public string? Message { get; set; }

        public NotificationSourceType? SourceType { get; set; }

        public string? SourceId { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public DateTimeOffset? CreatedTimestamp { get; set; }

        public DateTimeOffset? LastModifiedTimestamp { get; set; }

        public DateTimeOffset? DeactivatedTimestamp { get; set; }

        public string? DeactivatedReason { get; set; }

        public Guid? DeactivatedBy { get; set; }

    }
}