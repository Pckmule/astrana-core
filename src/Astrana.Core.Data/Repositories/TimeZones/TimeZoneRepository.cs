/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Exceptions;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Contracts;
using Astrana.Core.Domain.Models.TimeZones.Contracts;
using Astrana.Core.Domain.Models.TimeZones.Options;
using Astrana.Core.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using DM = Astrana.Core.Domain.Models;
using TimeZone = Astrana.Core.Data.Entities.Configuration.TimeZone;

namespace Astrana.Core.Data.Repositories.TimeZones
{
    public class TimeZoneRepository : BaseRepository<TimeZoneRepository, Guid>, ITimeZoneRepository<Guid>
    {
        public TimeZoneRepository(ILogger<TimeZoneRepository> logger, ApplicationDbContext context) : base(logger, context) { }

        /// <summary>
        /// Builds up an IQueryable according to the specified filter criteria.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        private IQueryable<TimeZone> BuildQuery(TimeZonesQueryOptions<Guid, Guid>? options = null)
        {
            options ??= new TimeZonesQueryOptions<Guid, Guid>();

            var query = databaseSession.TimeZones.AsQueryable();

            // Add Filters
            if (options.Ids.Any())
                query = query.Where(o => options.Ids.Contains(o.TimeZoneId));

            if (options.ExcludeIds.Any())
                query = query.Where(o => !options.ExcludeIds.Contains(o.TimeZoneId));

            if (options.TwoLetterCountryCodes.Any())
                query = query.Where(o => o.Countries.Any(c => options.TwoLetterCountryCodes.Contains(c.TwoLetterCode)));

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
        /// Returns a count of timeZones according to the specified filter criteria.
        /// </summary>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        public async Task<ICountResult> GetTimeZonesCountAsync(TimeZonesQueryOptions<Guid, Guid>? queryOptions = null)
        {
            queryOptions ??= new TimeZonesQueryOptions<Guid, Guid>();

            queryOptions.PagingDisabled = true;

            return new CountResult(await BuildQuery(queryOptions).CountAsync());
        }

        /// <summary>
        /// Returns a list of timeZones according to the specified filter criteria.
        /// </summary>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        public async Task<IGetResult<DM.TimeZones.TimeZone>> GetTimeZonesAsync(TimeZonesQueryOptions<Guid, Guid>? queryOptions = null)
        {
            queryOptions ??= new TimeZonesQueryOptions<Guid, Guid>();

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

            var timeZones = queryResults.Select(Data.Entities.Configuration.ModelMappings.TimeZone.MapToDomainModel).ToList();

            logger.LogInformation(string.Format(MessageRetrievedEntity, nameof(TimeZone)), queryOptions);

            return CreateGetResultWithPagination(timeZones, queryOptions, resultSetCount);
        }

        /// <summary>
        /// Finds and returns a Time Zones by it's Country.
        /// </summary>
        /// <param name="countryTwoLetterCode"></param>
        /// <returns></returns>
        public async Task<IGetResult<DM.TimeZones.TimeZone>> GetTimeZonesByCountryAsync(string countryTwoLetterCode)
        {
            return await GetTimeZonesAsync(new TimeZonesQueryOptions<Guid, Guid> { TwoLetterCountryCodes = new List<string> { countryTwoLetterCode } });
        }

        /// <summary>
        /// Finds and returns a timeZone by it's Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<DM.TimeZones.TimeZone?> GetTimeZoneByIdAsync(Guid id)
        {
            return (await GetTimeZonesAsync(new TimeZonesQueryOptions<Guid, Guid>(new List<Guid> { id }))).Data.FirstOrDefault();
        }

        /// <summary>
        /// Adds new timeZones to the Data Source.
        /// </summary>
        /// <param name="requestedAdditions"></param>
        /// <param name="actioningUserId"></param>
        /// <param name="returnRecords"></param>
        /// <returns></returns>
        public async Task<IAddResult<List<DM.TimeZones.TimeZone>>> CreateAsync(IEnumerable<ITimeZoneToAdd> requestedAdditions, Guid actioningUserId, bool returnRecords = true)
        {
            ValidateActioningUserId(actioningUserId);

            var countAdded = 0;
            var newTimeZoneIds = new List<Guid>();

            try
            {
                var now = DateTime.UtcNow;

                foreach (var addition in requestedAdditions)
                {
                    var newTimeZoneEntity = ModelMapper.MapModel<TimeZone, ITimeZoneToAdd>(addition);

                    if (newTimeZoneEntity == null)
                        continue;

                    newTimeZoneEntity.CreatedBy = actioningUserId;
                    newTimeZoneEntity.CreatedTimestamp = now;

                    newTimeZoneEntity.LastModifiedBy = actioningUserId;
                    newTimeZoneEntity.LastModifiedTimestamp = now;

                    // Save records.
                    databaseSession.TimeZones.Add(newTimeZoneEntity);
                    await databaseSession.SaveChangesAsync();

                    countAdded++;

                    newTimeZoneIds.Add(newTimeZoneEntity.TimeZoneId);
                }

                logger.LogInformation(string.Format(MessageSuccessfullyCreatedEntity, newTimeZoneIds.Count, nameof(TimeZone) + "(s)"));

                // Return the current records.
                if (returnRecords)
                    return new AddSuccessResult<List<DM.TimeZones.TimeZone>>((await GetTimeZonesAsync(new TimeZonesQueryOptions<Guid, Guid>(newTimeZoneIds))).Data, countAdded);

                return new AddSuccessResult<List<DM.TimeZones.TimeZone>>(new List<DM.TimeZones.TimeZone>(), countAdded);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);

                throw new CannotCreateRecordsException(ex);
            }
        }

        /// <summary>
        /// Updates existing timeZones in the Data Source.
        /// </summary>
        /// <param name="requestedUpdates"></param>
        /// <param name="actioningUserId"></param>
        /// <param name="returnRecords"></param>
        /// <returns></returns>
        public async Task<IUpdateResult<List<DM.TimeZones.TimeZone>>> UpdateAsync(IEnumerable<DM.TimeZones.TimeZone> requestedUpdates, Guid actioningUserId, bool returnRecords = true)
        {
            ValidateActioningUserId(actioningUserId);

            var countUpdated = 0;
            var updatedTimeZoneIds = new List<Guid>();

            try
            {
                var now = DateTime.UtcNow;

                foreach (var update in requestedUpdates)
                {
                    var existingTimeZoneEntity = await databaseSession.TimeZones.FirstOrDefaultAsync(o => o.TimeZoneId == update.TimeZoneId);

                    if (existingTimeZoneEntity == null)
                        continue;

                    // Update entity fields

                    existingTimeZoneEntity.Name = update.Name.Trim();
                                        
                    existingTimeZoneEntity.LastModifiedBy = actioningUserId;
                    existingTimeZoneEntity.LastModifiedTimestamp = now;

                    // Save changes to records.
                    databaseSession.TimeZones.Update(existingTimeZoneEntity);

                    await databaseSession.SaveChangesAsync();

                    countUpdated++;

                    updatedTimeZoneIds.Add(existingTimeZoneEntity.TimeZoneId);
                }

                logger.LogInformation(string.Format(MessageSuccessfullyUpdatedEntity, updatedTimeZoneIds.Count, nameof(TimeZone) + "(s)"));

                // Return the current records.
                if (returnRecords)
                    return new UpdateSuccessResult<List<DM.TimeZones.TimeZone>>((await GetTimeZonesAsync(new TimeZonesQueryOptions<Guid, Guid>(updatedTimeZoneIds))).Data, countUpdated);

                return new UpdateSuccessResult<List<DM.TimeZones.TimeZone>>(new List<DM.TimeZones.TimeZone>(), countUpdated);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);

                throw new CannotUpdateRecordsException(ex);
            }
        }

        public Task<IDeleteResult<List<Guid>>> DeleteAsync(IEnumerable<Guid> validatedTimeZonesToRemoveIds, Guid actioningUserId)
        {
            throw new NotImplementedException();
        }
    }
}
