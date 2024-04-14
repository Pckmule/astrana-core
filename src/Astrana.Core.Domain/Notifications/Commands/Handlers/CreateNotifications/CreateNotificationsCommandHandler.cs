/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.IdentityAccessManagement.Exceptions;
using Astrana.Core.Domain.Links.Commands.CreateLinks;
using Astrana.Core.Domain.Models.Attachments.Enums;
using Astrana.Core.Domain.Models.Links;
using Astrana.Core.Domain.Models.Notifications;
using Astrana.Core.Domain.Models.Notifications.Constants;
using Astrana.Core.Domain.Models.Notifications.DomainTransferObjects;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Enums;
using Astrana.Core.Domain.Models.System.Enums;
using Astrana.Core.Domain.Notifications.Repositories;
using Microsoft.Extensions.Logging;
using MRB = Astrana.Core.Domain.ResultMessageBuilder;

namespace Astrana.Core.Domain.Notifications.Commands.Handlers.CreateNotifications
{
    public class CreateNotificationsCommandHandler : ICreateNotificationsCommandHandler
    {
        private readonly ILogger<CreateNotificationsCommandHandler> _logger;

        private readonly INotificationRepository<Guid> _notificationRepository;

        private readonly ICreateLinksCommand _createLinksCommand;

        public CreateNotificationsCommandHandler(ILogger<CreateNotificationsCommandHandler> logger, INotificationRepository<Guid> notificationRepository, ICreateLinksCommand createLinksCommand)
        {
            _logger = logger;

            _notificationRepository = notificationRepository;
            _createLinksCommand = createLinksCommand;
        }

        public async Task<AddResult<List<Notification>>> ExecuteAsync(IList<AddNotificationDto> notificationsToAddDtos, Guid actioningUserId)
        {
            if (!notificationsToAddDtos.Any())
            {
                var message = MRB.NoneProvidedMessage(CrudAction.Add, ModelProperties.Notification.NamePluralForm);

                _logger.LogWarning(message);

                return new AddFailResult<List<Notification>>(new List<Notification>(), 0, message);
            }

            try
            {
                var notificationsToAdd = notificationsToAddDtos.Select(o => new Notification(o)).ToList();
                
                var result = await _notificationRepository.CreateAsync(notificationsToAdd, actioningUserId);

                if (result.Outcome == ResultOutcome.Success)
                    return new AddSuccessResult<List<Notification>>(result.Data, result.Count, MRB.CreateSuccessResultMessage(ModelProperties.Notification.NameSingularForm, ModelProperties.Notification.NamePluralForm, result.Count));

                return new AddFailResult<List<Notification>>(result.Data, result.Count, result.Message, result.ResultCode);
            }
            catch (InvalidDomainEntityStateException ex)
            {
                var message = MRB.NoneValidMessage(CrudAction.Add, ModelProperties.Notification.NamePluralForm);

                _logger.LogWarning(message);

                return new AddFailResult<List<Notification>>(new List<Notification>(), 0, message);
            }
            catch(Exception)
            {
                return new AddFailResult<List<Notification>>(null);
            }
        }
        
    }
}
