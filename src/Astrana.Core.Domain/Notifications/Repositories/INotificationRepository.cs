/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Notifications;
using Astrana.Core.Domain.Models.Notifications.DomainTransferObjects;
using Astrana.Core.Domain.Models.Notifications.Options;
using Astrana.Core.Domain.Models.Results.Contracts;

namespace Astrana.Core.Domain.Notifications.Repositories
{
    public interface INotificationRepository<TUserId> where TUserId : struct
    {
        Task<ICountResult> GetNotificationsCountAsync(NotificationQueryOptions<Guid, TUserId>? queryOptions = null);

        Task<IGetResult<Notification>> GetNotificationsAsync(NotificationQueryOptions<Guid, TUserId>? queryOptions = null);

        Task<Notification?> GetNotificationByIdAsync(Guid id);
        
        Task<IAddResult<List<Notification>>> CreateAsync(IList<Notification> notificationsToAdd, TUserId actioningUserId, bool returnRecords = true);

        Task<IUpdateResult<List<Notification>>> UpdateReadStatusAsync(IEnumerable<NotificationStatusDto> requestedUpdates, TUserId actioningUserId, bool returnRecords = true);
    }
}
