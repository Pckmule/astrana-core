/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Constants;
using Astrana.Core.Domain.Models.Notifications.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DomainModelProperties = Astrana.Core.Domain.Models.Notifications.Constants.ModelProperties;

#nullable disable

namespace Astrana.Core.Data.Entities.Workflow
{
    [Table("Notifications", Schema = SchemaNames.Workflow)]
    public class Notification
    {
        [Key, Column(Order = 0)]
        public Guid NotificationId { get; set; }
        
        public NotificationType Type { get; set; }

        [MinLength(DomainModelProperties.Notification.MinimumMessageLength)]
        public string Message { get; set; }
        
        public NotificationSourceType SourceType { get; set; }

        [MinLength(DomainModelProperties.Notification.MinimumSourceIdLength)]
        public string SourceId { get; set; }
        
        public bool IsRead { get; set; }

        public Guid CreatedBy { get; set; }

        public Guid LastModifiedBy { get; set; }

        public DateTimeOffset CreatedTimestamp { get; set; }

        public DateTimeOffset LastModifiedTimestamp { get; set; }
    }
}
