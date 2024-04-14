/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Notifications;
using Astrana.Core.Domain.Models.Notifications.Constants;
using Astrana.Core.Domain.Models.Notifications.DomainTransferObjects;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Enums;
using Astrana.Core.Domain.Models.System.Enums;
using Astrana.Core.Domain.Notifications.Repositories;
using Microsoft.Extensions.Logging;
using MRB = Astrana.Core.Domain.ResultMessageBuilder;

namespace Astrana.Core.Domain.Notifications.Commands.Handlers.UpdateNotifications
{
    public class UpdateNotificationsCommandHandler : IUpdateNotificationsCommandHandler
    {
        private readonly ILogger<UpdateNotificationsCommandHandler> _logger;
        private readonly INotificationRepository<Guid> _notificationRepository;

        public UpdateNotificationsCommandHandler(ILogger<UpdateNotificationsCommandHandler> logger, INotificationRepository<Guid> notificationRepository)
        {
            _logger = logger;
            _notificationRepository = notificationRepository;
        }

        public async Task<UpdateResult<List<Notification>>> ExecuteAsync(IList<NotificationStatusDto> notificationsToUpdate, Guid actioningUserId)
        {
            if (!notificationsToUpdate.Any())
            {
                var message = MRB.NoneProvidedMessage(CrudAction.Update, ModelProperties.Notification.NamePluralForm);

                _logger.LogWarning(message);

                return new UpdateFailResult<List<Notification>>(new List<Notification>(), 0, message);
            }

            var validatedNotificationsToUpdate = notificationsToUpdate.ToList(); // TODO: Add validation logic
            if (!validatedNotificationsToUpdate.Any())
            {
                var message = MRB.NoneValidMessage(CrudAction.Update, ModelProperties.Notification.NamePluralForm);

                _logger.LogWarning(message);

                return new UpdateFailResult<List<Notification>>(new List<Notification>(), 0, message);
            }

            var result = await _notificationRepository.UpdateReadStatusAsync(validatedNotificationsToUpdate, actioningUserId);

            if (result.Outcome == ResultOutcome.Success)
                return new UpdateSuccessResult<List<Notification>>(result.Data, result.Count, MRB.UpdateSuccessResultMessage(ModelProperties.Notification.NameSingularForm, ModelProperties.Notification.NamePluralForm, result.Count));

            return new UpdateFailResult<List<Notification>>(result.Data, 0, result.Message, result.ResultCode);
        }
    }
}