/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Exceptions;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Contracts;
using Astrana.Core.Domain.Models.SystemSettings.Contracts;
using Astrana.Core.Domain.Models.SystemSettings.Options;
using Astrana.Core.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using DM = Astrana.Core.Domain.Models;
using SystemSetting = Astrana.Core.Data.Entities.Configuration.SystemSetting;

namespace Astrana.Core.Data.Repositories.SystemSettings
{
    public class SystemSettingRepository : BaseRepository<SystemSettingRepository, Guid>, ISystemSettingRepository<Guid>
    {
        public SystemSettingRepository(ILogger<SystemSettingRepository> logger, ApplicationDbContext context) : base(logger, context)
        {
        }

        /// <summary>
        /// Builds up an IQueryable according to the specified filter criteria.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        private IQueryable<SystemSetting> BuildQuery(SystemSettingQueryOptions<Guid, Guid>? options = null)
        {
            options ??= new SystemSettingQueryOptions<Guid, Guid>();

            var query = databaseSession.Settings.AsQueryable();

            // Add Filters
            if (options.Ids.Any())
                query = query.Where(o => options.Ids.Contains(o.Id));

            if (options.ExcludeIds.Any())
                query = query.Where(o => !options.ExcludeIds.Contains(o.Id));

            if (options.Names.Any())
                query = query.Where(o => options.Names.Contains(o.Name));

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
        /// Returns a count of System Settings according to the specified filter criteria.
        /// </summary>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        public async Task<ICountResult> GetSystemSettingsCountAsync(SystemSettingQueryOptions<Guid, Guid>? queryOptions = null)
        {
            queryOptions ??= new SystemSettingQueryOptions<Guid, Guid>();

            queryOptions.PagingDisabled = true;

            return new CountResult(await BuildQuery(queryOptions).CountAsync());
        }

        /// <summary>
        /// Returns a list of System Settings according to the specified filter criteria.
        /// </summary>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        public async Task<IGetResult<DM.SystemSettings.SystemSetting>> GetSystemSettingsAsync(SystemSettingQueryOptions<Guid, Guid>? queryOptions = null)
        {
            queryOptions ??= new SystemSettingQueryOptions<Guid, Guid>();
        
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

            var systemSettings = queryResults.Select(systemSetting =>
                ModelMapper.MapModel<DM.SystemSettings.SystemSetting, SystemSetting>(systemSetting)).ToList();

            logger.LogInformation(string.Format(MessageRetrievedEntity, nameof(SystemSetting)), queryOptions);

            return CreateGetResultWithPagination(systemSettings, queryOptions, resultSetCount);
        }

        public async Task<DM.SystemSettings.SystemSetting?> GetSystemSettingByNameAsync(string settingName)
        {
            return (await GetSystemSettingsAsync(new SystemSettingQueryOptions<Guid, Guid>
            {
                Names = new List<string> { settingName }

            })).Data.FirstOrDefault();
        }

        /// <summary>
        /// Updates existing System Settings in the Data Source.
        /// </summary>
        /// <param name="requestedUpdates"></param>
        /// <param name="actioningUserId"></param>
        /// <param name="returnRecords"></param>
        /// <returns></returns>
        public async Task<IUpdateResult<List<DM.SystemSettings.SystemSetting>>> UpdateAsync(IEnumerable<ISystemSetting> requestedUpdates, Guid actioningUserId, bool returnRecords = true)
        {
            ValidateActioningUserId(actioningUserId);

            var countUpdated = 0;
            var updatedSystemSettingIds = new List<Guid>();

            try
            {
                var now = DateTime.UtcNow;

                foreach (var update in requestedUpdates)
                {
                    var existingSystemSettingEntity = await databaseSession.Settings.FirstOrDefaultAsync(o => o.Id == update.SystemSettingId);

                    if (existingSystemSettingEntity == null)
                        continue;

                    // Update entity fields
                    
                    existingSystemSettingEntity.DefaultValue = update.DefaultValue.ToUpperInvariant().Trim();
                    existingSystemSettingEntity.Value = update.Value.ToUpperInvariant().Trim();
                                        
                    existingSystemSettingEntity.LastModifiedBy = actioningUserId;
                    existingSystemSettingEntity.LastModifiedTimestamp = now;

                    // Save changes to records.
                    databaseSession.Settings.Update(existingSystemSettingEntity);

                    await databaseSession.SaveChangesAsync();

                    countUpdated++;

                    updatedSystemSettingIds.Add(existingSystemSettingEntity.Id);
                }

                logger.LogInformation(string.Format(MessageSuccessfullyUpdatedEntity, updatedSystemSettingIds.Count, nameof(Domain.Models.SystemSettings.SystemSetting) + "(s)"));

                // Return the current records.
                if (returnRecords)
                    return new UpdateSuccessResult<List<DM.SystemSettings.SystemSetting>>((await GetSystemSettingsAsync(new SystemSettingQueryOptions<Guid, Guid> { Ids = updatedSystemSettingIds })).Data, countUpdated);

                return new UpdateSuccessResult<List<DM.SystemSettings.SystemSetting>>(new List<DM.SystemSettings.SystemSetting>(), countUpdated);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);

                throw new CannotUpdateRecordsException(ex);
            }
        }
    }
}
