/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data;
using Astrana.Core.Data.Entities.Workflow;
using Astrana.Core.Data.Exceptions;
using Astrana.Core.Data.Repositories;
using Astrana.Core.Domain.Models.Notifications.Contracts;
using Astrana.Core.Domain.Models.Notifications.DomainTransferObjects;
using Astrana.Core.Domain.Models.Notifications.Options;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Contracts;
using Astrana.Core.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using DM = Astrana.Core.Domain.Models;

namespace Astrana.Core.Domain.Notifications.Repositories
{
    public class NotificationRepository : BaseRepository<NotificationRepository, Guid>, INotificationRepository<Guid>
    {
        public NotificationRepository(ILogger<NotificationRepository> logger, ApplicationDbContext context) : base(logger, context)
        {
        }

        /// <summary>
        /// Builds up an IQueryable according to the specified filter criteria.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        private IQueryable<Notification> BuildQuery(NotificationQueryOptions<Guid, Guid>? options = null)
        {
            options ??= new NotificationQueryOptions<Guid, Guid>();

            var query = databaseSession.Notifications.AsQueryable();

            // Add Filters
            if (options.Ids.Any())
                query = query.Where(o => options.Ids.Contains(o.NotificationId));

            if (options.ExcludeIds.Any())
                query = query.Where(o => !options.ExcludeIds.Contains(o.NotificationId));

            if (options.NotificationTypes != null && options.NotificationTypes.Any())
                query = query.Where(o => options.NotificationTypes.Contains(o.Type));

            if (options.CreatedBefore.HasValue)
                query = query.Where(o => o.CreatedTimestamp < options.CreatedBefore.Value);

            if (options.CreatedAfter.HasValue)
                query = query.Where(o => o.CreatedTimestamp > options.CreatedAfter.Value);

            // Add Ordering
            query = query.OrderByDescending(o => o.CreatedTimestamp);

            // Add Paging
            if (options is { PagingDisabled: false, PageSize: { }, CurrentPage: { } })
                query = query.Skip(options.PageSize.Value * (options.CurrentPage.Value - 1)).Take(options.PageSize.Value);

            return query;
        }

        /// <summary>
        /// Returns a count of Notifications according to the specified filter criteria.
        /// </summary>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        public async Task<ICountResult> GetNotificationsCountAsync(NotificationQueryOptions<Guid, Guid>? queryOptions = null)
        {
            queryOptions ??= new NotificationQueryOptions<Guid, Guid>();

            queryOptions.PagingDisabled = true;

            return new CountResult(await BuildQuery(queryOptions).CountAsync());
        }

        /// <summary>
        /// Returns a list of Notifications according to the specified filter criteria.
        /// </summary>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        public async Task<IGetResult<DM.Notifications.Notification>> GetNotificationsAsync(NotificationQueryOptions<Guid, Guid>? queryOptions = null)
        {
            queryOptions ??= new NotificationQueryOptions<Guid, Guid>();

            var queryResults = await BuildQuery(queryOptions).ToListAsync();

            int resultSetCount;
            if (queryOptions.PagingDisabled)
            {
                var countResultSetQueryOptions = queryOptions.Clone();
                countResultSetQueryOptions.PagingDisabled = true;

                resultSetCount = await BuildQuery(queryOptions).CountAsync();
            }
            else
                resultSetCount = queryResults.Count;

            var notifications = queryResults.Select(Data.Entities.Workflow.ModelMappings.Notification.MapToDomainModel).ToList();

            logger.LogInformation(string.Format(MessageRetrievedEntity, nameof(Notification)), queryOptions);

            return CreateGetResultWithPagination(notifications, queryOptions, resultSetCount);
        }

        /// <summary>
        /// Finds and returns a Notification by it's Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<DM.Notifications.Notification?> GetNotificationByIdAsync(Guid id)
        {
            return (await GetNotificationsAsync(new NotificationQueryOptions<Guid, Guid>(new List<Guid> { id }))).Data.FirstOrDefault();
        }

        /// <summary>
        /// Adds new Notifications to the Data Source.
        /// </summary>
        /// <param name="notificationsToAdd"></param>
        /// <param name="actioningUserId"></param>
        /// <param name="returnRecords"></param>
        /// <returns></returns>
        public async Task<IAddResult<List<DM.Notifications.Notification>>> CreateAsync(IList<DM.Notifications.Notification> notificationsToAdd, Guid actioningUserId, bool returnRecords = true)
        {
            ValidateActioningUserId(actioningUserId);

            var countAdded = 0;
            var newEntityIds = new List<Guid>();

            try
            {
                foreach (var notificationToAdd in notificationsToAdd)
                {
                    var newNotificationEntity = new Notification
                    {
                        Type = notificationToAdd.Type,
                        Message = notificationToAdd.Message,
                        SourceId = notificationToAdd.SourceId,
                        SourceType = notificationToAdd.SourceType
                    };

                    newNotificationEntity.CreatedBy = actioningUserId;
                    newNotificationEntity.LastModifiedBy = actioningUserId;

                    // Save records.
                    databaseSession.Notifications.Add(newNotificationEntity);
                    await databaseSession.SaveChangesAsync();

                    countAdded++;

                    newEntityIds.Add(newNotificationEntity.NotificationId);
                }

                logger.LogInformation(string.Format(MessageSuccessfullyCreatedEntity, newEntityIds.Count, nameof(Notification) + "(s)"));

                // Return the current records.
                if (returnRecords)
                    return new AddSuccessResult<List<DM.Notifications.Notification>>((await GetNotificationsAsync(new NotificationQueryOptions<Guid, Guid>(newEntityIds))).Data, countAdded);
                
                return new AddSuccessResult<List<DM.Notifications.Notification>>(new List<DM.Notifications.Notification>(), countAdded);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);

                throw new CannotCreateRecordsException(ex);
            }
        }

        /// <summary>
        /// Updates existing Notifications in the Data Source.
        /// </summary>
        /// <param name="requestedUpdates"></param>
        /// <param name="actioningUserId"></param>
        /// <param name="returnRecords"></param>
        /// <returns></returns>
        public async Task<IUpdateResult<List<DM.Notifications.Notification>>> UpdateReadStatusAsync(IEnumerable<NotificationStatusDto> requestedUpdates, Guid actioningUserId, bool returnRecords = true)
        {
            ValidateActioningUserId(actioningUserId);

            var countUpdated = 0;
            var updatedNotificationIds = new List<Guid>();

            try
            {
                var now = DateTime.UtcNow;

                foreach (var update in requestedUpdates)
                {
                    //var existingNotificationEntity = await ctx.Notifications.FirstOrDefaultAsync(o => o.Id == update.Id);

                    //if (existingNotificationEntity == null)
                    //    continue;

                    //// Update entity fields

                    //existingNotificationEntity.Text = update.Text.Trim();

                    //existingNotificationEntity.LastModifiedBy = actioningUserId;
                    //existingNotificationEntity.LastModifiedTimestamp = now;

                    //// Save changes to records.
                    //ctx.Notifications.Update(existingNotificationEntity);

                    //await ctx.SaveChangesAsync();

                    //countUpdated++;

                    //updatedNotificationIds.Add(existingNotificationEntity.Id);
                }

                logger.LogInformation(string.Format(MessageSuccessfullyUpdatedEntity, updatedNotificationIds.Count, nameof(Notification) + "(s)"));

                // Return the current records.
                if (returnRecords)
                    return new UpdateSuccessResult<List<DM.Notifications.Notification>>((await GetNotificationsAsync(new NotificationQueryOptions<Guid, Guid>(updatedNotificationIds))).Data, countUpdated);
                
                return new UpdateSuccessResult<List<DM.Notifications.Notification>>(new List<DM.Notifications.Notification>(), countUpdated);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);

                throw new CannotUpdateRecordsException(ex);
            }
        }

        public Task<IDeleteResult<List<Guid>>> DeleteAsync(IEnumerable<Guid> validatedNotificationsToRemoveIds, Guid actioningUserId)
        {
            throw new NotImplementedException();
        }
    }
}
