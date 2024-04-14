/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Notifications;
using Astrana.Core.Domain.Models.Notifications.Options;
using Astrana.Core.Domain.Models.Results;

namespace Astrana.Core.Domain.Notifications.Queries
{
    public interface IGetNotificationsQuery
    {
        Task<GetResult<NotificationQueryOptions<Guid, Guid>, Notification, Guid, Guid>> ExecuteAsync(Guid actioningUserId, NotificationQueryOptions<Guid, Guid> options = null);
    }
}