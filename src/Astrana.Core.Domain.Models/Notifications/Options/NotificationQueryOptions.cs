/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Notifications.Enums;
using Astrana.Core.Domain.Models.Options;
using Astrana.Core.Utilities;
using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Models.Notifications.Options
{
    public class NotificationQueryOptions<TRecordId, TOwnerUserId> : QueryOptions<TRecordId, TOwnerUserId>, INotificationQueryOptions
        where TRecordId : struct
        where TOwnerUserId : struct
    {
        [JsonConstructor]
        public NotificationQueryOptions() { }

        public NotificationQueryOptions(List<TRecordId> ids) : base(ids) { }

        public List<NotificationType>? NotificationTypes { get; set; }

        public override List<string> ToQueryStringList()
        {
            var propertyValues = base.ToQueryStringList();

            propertyValues.AddRange(NotificationTypes.Select(notificationType => $"{nameof(NotificationTypes).ToCamelCase()}={notificationType}"));

            return propertyValues;
        }

        public override string ToString()
        {
            var baseString = base.ToString();

            var propertyValues = new List<string>();

            propertyValues.AddRange(NotificationTypes.Select(notificationType => $"{nameof(NotificationTypes).ToCamelCase()}={notificationType}"));

            return string.Join(StringSeparator, baseString, string.Join(StringSeparator, propertyValues));
        }
    }
}
