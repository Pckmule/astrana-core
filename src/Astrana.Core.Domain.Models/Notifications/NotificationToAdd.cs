/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Notifications.Constants;
using Astrana.Core.Domain.Models.Notifications.Contracts;
using Astrana.Core.Domain.Models.Notifications.Enums;
using Astrana.Core.Framework.Domain;
using Astrana.Core.Framework.Model.Validation;
using System.ComponentModel.DataAnnotations;

namespace Astrana.Core.Domain.Models.Notifications
{
    public class NotificationToAdd : DomainEntity, INotificationToAdd
    {
        public NotificationToAdd()
        {
            NameUnique = ModelProperties.Notification.NameUnique;
            NameSingularForm = ModelProperties.Notification.NameSingularForm;
            NamePluralForm = ModelProperties.Notification.NamePluralForm;
        }

        [Required]
        public NotificationType Type { get; set; }

        [Required]
        public string Message { get; set; }

        public override EntityValidationResult Validate()
        {
            return this.ValidateDomainModel();
        }
    }
}
