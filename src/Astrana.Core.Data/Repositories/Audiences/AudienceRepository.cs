/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Entities.Configuration;
using Astrana.Core.Data.Exceptions;
using Astrana.Core.Domain.Models.Audiences.Contracts;
using Astrana.Core.Domain.Models.Audiences.Options;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Contracts;
using Astrana.Core.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using DM = Astrana.Core.Domain.Models;

namespace Astrana.Core.Data.Repositories.Audiences
{
    public class AudienceRepository : BaseRepository<AudienceRepository, Guid>, IAudienceRepository<Guid>
    {
        public AudienceRepository(ILogger<AudienceRepository> logger, ApplicationDbContext context) : base(logger, context)
        {
        }

        /// <summary>
        /// Builds up an IQueryable according to the specified filter criteria.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        private IQueryable<Audience> BuildQuery(AudienceQueryOptions<Guid, Guid>? options = null)
        {
            options ??= new AudienceQueryOptions<Guid, Guid>();

            var query = databaseSession.Audiences.AsQueryable();

            // Add Filters
            if (options.Ids.Any())
                query = query.Where(o => options.Ids.Contains(o.AudienceId));

            if (options.ExcludeIds.Any())
                query = query.Where(o => !options.ExcludeIds.Contains(o.AudienceId));

            if (options.CreatedBefore.HasValue)
                query = query.Where(o => o.CreatedTimestamp < options.CreatedBefore.Value);

            if (options.CreatedAfter.HasValue)
                query = query.Where(o => o.CreatedTimestamp > options.CreatedAfter.Value);

            if (!options.IncludeDeactivated)
                query = query.Where(o => !o.DeactivatedTimestamp.HasValue);

            // Add Ordering
            query = query.OrderByDescending(o => o.CreatedTimestamp);

            // Add Paging
            if (options is { PagingDisabled: false, PageSize: { }, CurrentPage: { } })
                query = query.Skip(options.PageSize.Value * (options.CurrentPage.Value - 1)).Take(options.PageSize.Value);

            return query;
        }

        /// <summary>
        /// Returns a count of audiences according to the specified filter criteria.
        /// </summary>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        public async Task<ICountResult> GetAudiencesCountAsync(AudienceQueryOptions<Guid, Guid>? queryOptions = null)
        {
            queryOptions ??= new AudienceQueryOptions<Guid, Guid>();

            queryOptions.PagingDisabled = true;

            return new CountResult(await BuildQuery(queryOptions).CountAsync());
        }

        /// <summary>
        /// Returns a list of audiences according to the specified filter criteria.
        /// </summary>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        public async Task<IGetResult<DM.Audiences.Audience>> GetAudiencesAsync(AudienceQueryOptions<Guid, Guid>? queryOptions = null)
        {
            queryOptions ??= new AudienceQueryOptions<Guid, Guid>();

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

            var countries = queryResults.Select(Data.Entities.Configuration.ModelMappings.Audience.MapToDomainModel).ToList();

            logger.LogInformation(string.Format(MessageRetrievedEntity, nameof(Audience)), queryOptions);

            return CreateGetResultWithPagination(countries, queryOptions, resultSetCount);
        }

        /// <summary>
        /// Finds and returns an audience by it's ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<DM.Audiences.Audience?> GetAudienceByIdAsync(Guid id)
        {
            return (await GetAudiencesAsync(new AudienceQueryOptions<Guid, Guid>(new List<Guid> { id }))).Data.FirstOrDefault();
        }
        
        /// <summary>
        /// Adds new audiences to the Data Source.
        /// </summary>
        /// <param name="requestedAdditions"></param>
        /// <param name="actioningUserId"></param>
        /// <param name="returnRecords"></param>
        /// <returns></returns>
        public async Task<IAddResult<List<DM.Audiences.Audience>>> CreateAsync(IEnumerable<IAudienceToAdd> requestedAdditions, Guid actioningUserId, bool returnRecords = true)
        {
            ValidateActioningUserId(actioningUserId);

            var countAdded = 0;
            var newAudienceIds = new List<Guid>();

            try
            {
                foreach (var addition in requestedAdditions)
                {
                    var newAudienceEntity =  ModelMapper.MapModel<Audience, IAudienceToAdd>(addition);

                    if (newAudienceEntity == null)
                        continue;
                    
                    // Save records.
                    databaseSession.Audiences.Add(newAudienceEntity);
                    await databaseSession.SaveChangesAsync();

                    countAdded++;

                    newAudienceIds.Add(newAudienceEntity.AudienceId);
                }

                logger.LogInformation(string.Format(MessageSuccessfullyCreatedEntity, newAudienceIds.Count, nameof(Audience) + "(s)"));

                // Return the current records.
                if (returnRecords)
                    return new AddSuccessResult<List<DM.Audiences.Audience>>((await GetAudiencesAsync(new AudienceQueryOptions<Guid, Guid>(newAudienceIds))).Data, countAdded);

                return new AddSuccessResult<List<DM.Audiences.Audience>>(new List<DM.Audiences.Audience>(), countAdded);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);

                throw new CannotCreateRecordsException(ex);
            }
        }

        /// <summary>
        /// Updates existing audiences in the Data Source.
        /// </summary>
        /// <param name="requestedUpdates"></param>
        /// <param name="actioningUserId"></param>
        /// <param name="returnRecords"></param>
        /// <returns></returns>
        public async Task<IUpdateResult<List<DM.Audiences.Audience>>> UpdateAsync(IEnumerable<DM.Audiences.Audience> requestedUpdates, Guid actioningUserId, bool returnRecords = true)
        {
            ValidateActioningUserId(actioningUserId);

            var countUpdated = 0;
            var updatedAudienceIds = new List<Guid>();

            try
            {
                var now = DateTime.UtcNow;

                foreach (var update in requestedUpdates)
                {
                    var existingAudienceEntity = await databaseSession.Audiences.FirstOrDefaultAsync(o => o.AudienceId == update.AudienceId);

                    if (existingAudienceEntity == null)
                        continue;

                    // Update entity fields

                    existingAudienceEntity.Name = update.Name.Trim();
                    existingAudienceEntity.Description = update.Description.Trim();

                    existingAudienceEntity.LastModifiedBy = actioningUserId;
                    existingAudienceEntity.LastModifiedTimestamp = now;

                    // Save changes to records.
                    databaseSession.Audiences.Update(existingAudienceEntity);

                    await databaseSession.SaveChangesAsync();

                    countUpdated++;

                    updatedAudienceIds.Add(existingAudienceEntity.AudienceId);
                }

                logger.LogInformation(string.Format(MessageSuccessfullyUpdatedEntity, updatedAudienceIds.Count, nameof(Audience) + "(s)"));

                // Return the current records.
                if (returnRecords)
                    return new UpdateSuccessResult<List<DM.Audiences.Audience>>((await GetAudiencesAsync(new AudienceQueryOptions<Guid, Guid>(updatedAudienceIds))).Data, countUpdated);

                return new UpdateSuccessResult<List<DM.Audiences.Audience>>(new List<DM.Audiences.Audience>(), countUpdated);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);

                throw new CannotUpdateRecordsException(ex);
            }
        }

        public Task<IDeleteResult<List<Guid>>> DeleteAsync(IEnumerable<Guid> validatedAudiencesToRemoveIds, Guid actioningUserId)
        {
            throw new NotImplementedException();
        }
    }
}
