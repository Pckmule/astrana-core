using Astrana.Core.Domain.Models.Notifications;
using Astrana.Core.Domain.Models.Notifications.DomainTransferObjects;
using Astrana.Core.Domain.Models.Results;

namespace Astrana.Core.Domain.Notifications.Commands.Handlers.CreateNotifications
{
    public interface ICreateNotificationsCommandHandler
    {
        Task<AddResult<List<Notification>>> ExecuteAsync(IList<AddNotificationDto> notificationsToAddDtos, Guid actioningUserId);
    }
}
