using Astrana.Core.Domain.Models.Notifications;
using Astrana.Core.Domain.Models.Notifications.DomainTransferObjects;
using Astrana.Core.Domain.Models.Results;

namespace Astrana.Core.Domain.Notifications.Commands.Handlers.UpdateNotifications
{
    public interface IUpdateNotificationsCommandHandler
    {
        Task<UpdateResult<List<Notification>>> ExecuteAsync(IList<NotificationStatusDto> notificationsToUpdate, Guid actioningUserId);
    }
}