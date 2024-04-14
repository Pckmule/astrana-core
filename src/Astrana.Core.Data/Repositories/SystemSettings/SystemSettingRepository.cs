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
using SystemSettingCategory = Astrana.Core.Data.Entities.Configuration.SystemSettingCategory;

namespace Astrana.Core.Data.Repositories.SystemSettings
{
    public class SystemSettingRepository : BaseRepository<SystemSettingRepository, Guid>, ISystemSettingRepository<Guid>
    {
        public SystemSettingRepository(ILogger<SystemSettingRepository> logger, ApplicationDbContext context) : base(logger, context)
        {
        }

        /// <summary>
        /// Builds up an IQueryable according to the specified filter criteria to query System Setting Categories.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        private IQueryable<SystemSettingCategory> BuildSettingCategoriesQuery(SystemSettingCategoryQueryOptions<Guid, Guid>? options = null)
        {
            options ??= new SystemSettingCategoryQueryOptions<Guid, Guid>();

            var query = databaseSession.SystemSettingsCategories.AsQueryable();

            // Add Filters
            if (options.Ids.Any())
                query = query.Where(o => options.Ids.Contains(o.SystemSettingCategoryId));

            if (options.ExcludeIds.Any())
                query = query.Where(o => !options.ExcludeIds.Contains(o.SystemSettingCategoryId));

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
        /// Returns a count of System Setting Categories according to the specified filter criteria.
        /// </summary>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        public async Task<ICountResult> GetSystemSettingCategoriesCountAsync(SystemSettingCategoryQueryOptions<Guid, Guid>? queryOptions = null)
        {
            queryOptions ??= new SystemSettingCategoryQueryOptions<Guid, Guid>();

            queryOptions.PagingDisabled = true;

            return new CountResult(await BuildSettingCategoriesQuery(queryOptions).CountAsync());
        }

        /// <summary>
        /// Returns a list of System Setting Categories according to the specified filter criteria.
        /// </summary>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        public async Task<IGetResult<DM.SystemSettings.SystemSettingCategory>> GetSystemSettingCategoriesAsync(SystemSettingCategoryQueryOptions<Guid, Guid>? queryOptions = null)
        {
            queryOptions ??= new SystemSettingCategoryQueryOptions<Guid, Guid>();

            var queryResults = await BuildSettingCategoriesQuery(queryOptions).ToListAsync();

            int resultSetCount;
            if (queryOptions.PagingDisabled)
            {
                var countResultSetQueryOptions = queryOptions.Clone();
                countResultSetQueryOptions.PagingDisabled = true;

                resultSetCount = await BuildSettingCategoriesQuery(queryOptions).CountAsync();
            }
            else
                resultSetCount = queryResults.Count;

            var systemSettings = queryResults.Select(Data.Entities.Configuration.ModelMappings.SystemSettingCategory.MapToDomainModel).ToList();

            logger.LogInformation(string.Format(MessageRetrievedEntity, nameof(SystemSettingCategory)), queryOptions);

            return CreateGetResultWithPagination(systemSettings, queryOptions, resultSetCount);
        }

        /// <summary>
        /// Builds up an IQueryable according to the specified filter criteria to query System Settings.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        private IQueryable<SystemSetting> BuildSettingsQuery(SystemSettingQueryOptions<Guid, Guid>? options = null)
        {
            options ??= new SystemSettingQueryOptions<Guid, Guid>();

            var query = databaseSession.SystemSettings.AsQueryable();

            // Add Filters
            if (options.Ids.Any())
                query = query.Where(o => options.Ids.Contains(o.SystemSettingId));

            if (options.ExcludeIds.Any())
                query = query.Where(o => !options.ExcludeIds.Contains(o.SystemSettingId));

            if (options.Names.Any())
                query = query.Where(o => options.Names.Contains(o.Name));

            if (options.CategoryIds.Any())
                query = query.Where(o => options.CategoryIds.Contains(o.SettingCategory.SystemSettingCategoryId.ToString()));

            if (options is { IncludeUserSettable: true, IncludeSystemSettable: false })
                query = query.Where(o => o.UserMaySet);

            if (options is { IncludeUserSettable: false, IncludeSystemSettable: true })
                query = query.Where(o => !o.UserMaySet);

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

            return new CountResult(await BuildSettingsQuery(queryOptions).CountAsync());
        }

        /// <summary>
        /// Returns a list of System Settings according to the specified filter criteria.
        /// </summary>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        public async Task<IGetResult<DM.SystemSettings.SystemSetting>> GetSystemSettingsAsync(SystemSettingQueryOptions<Guid, Guid>? queryOptions = null)
        {
            queryOptions ??= new SystemSettingQueryOptions<Guid, Guid>();
        
            var queryResults = await BuildSettingsQuery(queryOptions).ToListAsync();

            int resultSetCount;
            if (queryOptions.PagingDisabled)
            {
                var countResultSetQueryOptions = queryOptions.Clone();
                countResultSetQueryOptions.PagingDisabled = true;

                resultSetCount = await BuildSettingsQuery(queryOptions).CountAsync();
            }
            else
                resultSetCount = queryResults.Count;

            var systemSettings = queryResults.Select(Data.Entities.Configuration.ModelMappings.SystemSetting.MapToDomainModel).ToList();

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
                    var existingSystemSettingEntity = await databaseSession.SystemSettings.FirstOrDefaultAsync(o => o.SystemSettingId == update.SystemSettingId);

                    if (existingSystemSettingEntity == null)
                        continue;

                    // Update entity fields
                    
                    existingSystemSettingEntity.DefaultValue = update.DefaultValue.ToUpperInvariant().Trim();
                    existingSystemSettingEntity.Value = update.Value.ToUpperInvariant().Trim();
                                        
                    existingSystemSettingEntity.LastModifiedBy = actioningUserId;
                    existingSystemSettingEntity.LastModifiedTimestamp = now;

                    // Save changes to records.
                    databaseSession.SystemSettings.Update(existingSystemSettingEntity);

                    await databaseSession.SaveChangesAsync();

                    countUpdated++;

                    updatedSystemSettingIds.Add(existingSystemSettingEntity.SystemSettingId);
                }

                logger.LogInformation(string.Format(MessageSuccessfullyUpdatedEntity, updatedSystemSettingIds.Count, nameof(DM.SystemSettings.SystemSetting) + "(s)"));

                // Return the current records.
                if (returnRecords)
                    return new UpdateSuccessResult<List<DM.SystemSettings.SystemSetting>>((await GetSystemSettingsAsync(new SystemSettingQueryOptions<Guid, Guid>(updatedSystemSettingIds))).Data, countUpdated);

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
