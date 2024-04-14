using NotificationDataEntity = Astrana.Core.Data.Entities.Workflow.Notification;
using NotificationDomainEntity = Astrana.Core.Domain.Models.Notifications.Notification;

namespace Astrana.Core.Data.Entities.Workflow.ModelMappings
{
    public static class Notification
    {
        public static NotificationDomainEntity MapToDomainModel(NotificationDataEntity notificationDataEntity)
        {
            if (notificationDataEntity == null)
                return null;

            var domainModel = new NotificationDomainEntity
            {
                NotificationId = notificationDataEntity.NotificationId,

                Type = notificationDataEntity.Type,
                Message = notificationDataEntity.Message,
                
                SourceType = notificationDataEntity.SourceType,
                SourceId = notificationDataEntity.SourceId,

                CreatedBy = notificationDataEntity.CreatedBy,
                CreatedTimestamp = notificationDataEntity.CreatedTimestamp,

                LastModifiedBy = notificationDataEntity.LastModifiedBy,
                LastModifiedTimestamp = notificationDataEntity.LastModifiedTimestamp
            };
            
            return domainModel;
        }
    }
}
