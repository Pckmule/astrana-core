/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Notifications;
using Astrana.Core.Domain.Models.Notifications.Options;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Notifications.Repositories;
using Astrana.Core.Utilities;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.Domain.Notifications.Queries
{
    public class GetNotificationsQuery : IGetNotificationsQuery
    {
        private readonly ILogger<GetNotificationsQuery> _logger;
        private readonly INotificationRepository<Guid> _notificationRepository;

        public GetNotificationsQuery(ILogger<GetNotificationsQuery> logger, INotificationRepository<Guid> notificationRepository)
        {
            _logger = logger;

            _notificationRepository = notificationRepository;
        }

        public async Task<GetResult<NotificationQueryOptions<Guid, Guid>, Notification, Guid, Guid>> ExecuteAsync(Guid actioningUserId, NotificationQueryOptions<Guid, Guid>? options = null)
        {
            options ??= new NotificationQueryOptions<Guid, Guid>();

            var result = await _notificationRepository.GetNotificationsAsync(options);

            _logger.LogTrace($"Executed {nameof(GetNotificationsQuery).SplitOnUpperCase()}");

            return new GetResult<NotificationQueryOptions<Guid, Guid>, Notification, Guid, Guid>(result.Data, options, result.ResultSetCount, result.Message);
        }
    }
}