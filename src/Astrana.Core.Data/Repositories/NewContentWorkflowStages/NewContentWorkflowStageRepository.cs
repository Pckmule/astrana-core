/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Entities.Workflow;
using Astrana.Core.Data.Exceptions;
using Astrana.Core.Domain.Models.NewContentWorkflowStages.Contracts;
using Astrana.Core.Domain.Models.NewContentWorkflowStages.Options;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Contracts;
using Astrana.Core.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using DM = Astrana.Core.Domain.Models;

namespace Astrana.Core.Data.Repositories.NewContentWorkflowStages
{
    public class NewContentWorkflowStageRepository : BaseRepository<NewContentWorkflowStageRepository, Guid>, INewContentWorkflowStageRepository<Guid>
    {
        public NewContentWorkflowStageRepository(ILogger<NewContentWorkflowStageRepository> logger, ApplicationDbContext context) : base(logger, context)
        {
        }

        /// <summary>
        /// Builds up an IQueryable according to the specified filter criteria.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        private IQueryable<NewContentWorkflowStage> BuildQuery(NewContentWorkflowStageQueryOptions<Guid, Guid>? options = null)
        {
            options ??= new NewContentWorkflowStageQueryOptions<Guid, Guid>();

            var query = databaseSession.NewContentWorkflowStages.AsQueryable();

            // Add Filters
            if (options.Ids.Any())
                query = query.Where(o => options.Ids.Contains(o.NewContentWorkflowStageId));

            if (options.ExcludeIds.Any())
                query = query.Where(o => !options.ExcludeIds.Contains(o.NewContentWorkflowStageId));

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
        /// Returns a count of NewContentWorkflowStages according to the specified filter criteria.
        /// </summary>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        public async Task<ICountResult> GetNewContentWorkflowStagesCountAsync(NewContentWorkflowStageQueryOptions<Guid, Guid>? queryOptions = null)
        {
            queryOptions ??= new NewContentWorkflowStageQueryOptions<Guid, Guid>();

            queryOptions.PagingDisabled = true;

            return new CountResult(await BuildQuery(queryOptions).CountAsync());
        }

        /// <summary>
        /// Returns a list of NewContentWorkflowStages according to the specified filter criteria.
        /// </summary>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        public async Task<IGetResult<DM.NewContentWorkflowStages.NewContentWorkflowStage>> GetNewContentWorkflowStagesAsync(NewContentWorkflowStageQueryOptions<Guid, Guid>? queryOptions = null)
        {
            queryOptions ??= new NewContentWorkflowStageQueryOptions<Guid, Guid>();

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

            var newContentWorkflowStages = queryResults.Select(newContentWorkflowStage => ModelMapper.MapModel<DM.NewContentWorkflowStages.NewContentWorkflowStage, NewContentWorkflowStage>(newContentWorkflowStage)).ToList();

            logger.LogInformation(string.Format(MessageRetrievedEntity, nameof(NewContentWorkflowStage)), queryOptions);

            return CreateGetResultWithPagination(newContentWorkflowStages, queryOptions, resultSetCount);
        }

        /// <summary>
        /// Finds and returns a NewContentWorkflowStage by it's Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<DM.NewContentWorkflowStages.NewContentWorkflowStage?> GetNewContentWorkflowStageByIdAsync(Guid id)
        {
            return (await GetNewContentWorkflowStagesAsync(new NewContentWorkflowStageQueryOptions<Guid, Guid>(new List<Guid> { id }))).Data.FirstOrDefault();
        }

        /// <summary>
        /// Adds new NewContentWorkflowStages to the Data Source.
        /// </summary>
        /// <param name="requestedAdditions"></param>
        /// <param name="actioningUserId"></param>
        /// <param name="returnRecords"></param>
        /// <returns></returns>
        public async Task<IAddResult<List<DM.NewContentWorkflowStages.NewContentWorkflowStage>>> CreateAsync(IEnumerable<DM.NewContentWorkflowStages.NewContentWorkflowStage> requestedAdditions, Guid actioningUserId, bool returnRecords = true)
        {
            ValidateActioningUserId(actioningUserId);

            var countAdded = 0;
            var newNewContentWorkflowStageIds = new List<Guid>();

            try
            {
                var now = DateTime.UtcNow;

                foreach (var addition in requestedAdditions)
                {
                    var newNewContentWorkflowStageEntity = ModelMapper.MapModel<NewContentWorkflowStage, DM.NewContentWorkflowStages.NewContentWorkflowStage>(addition);
                    
                    newNewContentWorkflowStageEntity.CreatedBy = actioningUserId;
                    newNewContentWorkflowStageEntity.CreatedTimestamp = now;

                    newNewContentWorkflowStageEntity.LastModifiedBy = actioningUserId;
                    newNewContentWorkflowStageEntity.LastModifiedTimestamp = now;

                    // Save records.
                    databaseSession.NewContentWorkflowStages.Add(newNewContentWorkflowStageEntity);
                    await databaseSession.SaveChangesAsync();

                    countAdded++;

                    newNewContentWorkflowStageIds.Add(newNewContentWorkflowStageEntity.NewContentWorkflowStageId);
                }

                logger.LogInformation(string.Format(MessageSuccessfullyCreatedEntity, newNewContentWorkflowStageIds.Count, nameof(NewContentWorkflowStage) + "(s)"));

                // Return the current records.
                if (returnRecords)
                    return new AddSuccessResult<List<DM.NewContentWorkflowStages.NewContentWorkflowStage>>((await GetNewContentWorkflowStagesAsync(new NewContentWorkflowStageQueryOptions<Guid, Guid>(newNewContentWorkflowStageIds))).Data, countAdded);
                
                return new AddSuccessResult<List<DM.NewContentWorkflowStages.NewContentWorkflowStage>>(new List<DM.NewContentWorkflowStages.NewContentWorkflowStage>(), countAdded);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);

                throw new CannotCreateRecordsException(ex);
            }
        }

        /// <summary>
        /// Updates existing NewContentWorkflowStages in the Data Source.
        /// </summary>
        /// <param name="requestedUpdates"></param>
        /// <param name="actioningUserId"></param>
        /// <param name="returnRecords"></param>
        /// <returns></returns>
        public async Task<IUpdateResult<List<DM.NewContentWorkflowStages.NewContentWorkflowStage>>> UpdateAsync(IEnumerable<INewContentWorkflowStage> requestedUpdates, Guid actioningUserId, bool returnRecords = true)
        {
            ValidateActioningUserId(actioningUserId);

            var countUpdated = 0;
            var updatedNewContentWorkflowStageIds = new List<Guid>();

            try
            {
                var now = DateTime.UtcNow;

                foreach (var update in requestedUpdates)
                {
                    var existingNewContentWorkflowStageEntity = await databaseSession.NewContentWorkflowStages.FirstOrDefaultAsync(o => o.NewContentWorkflowStageId == update.NewContentWorkflowStageId);

                    if (existingNewContentWorkflowStageEntity == null)
                        continue;

                    // Update entity fields

                    existingNewContentWorkflowStageEntity.ContentEntityId = update.ContentEntityId.Trim();
                    existingNewContentWorkflowStageEntity.ContentEntityTypeId = update.ContentEntityTypeId.Trim();
                    
                    existingNewContentWorkflowStageEntity.LastModifiedBy = actioningUserId;
                    existingNewContentWorkflowStageEntity.LastModifiedTimestamp = now;

                    // Save changes to records.
                    databaseSession.NewContentWorkflowStages.Update(existingNewContentWorkflowStageEntity);

                    await databaseSession.SaveChangesAsync();

                    countUpdated++;

                    updatedNewContentWorkflowStageIds.Add(existingNewContentWorkflowStageEntity.NewContentWorkflowStageId);
                }

                logger.LogInformation(string.Format(MessageSuccessfullyUpdatedEntity, updatedNewContentWorkflowStageIds.Count, nameof(NewContentWorkflowStage) + "(s)"));

                // Return the current records.
                if (returnRecords)
                    return new UpdateSuccessResult<List<DM.NewContentWorkflowStages.NewContentWorkflowStage>>((await GetNewContentWorkflowStagesAsync(new NewContentWorkflowStageQueryOptions<Guid, Guid>(updatedNewContentWorkflowStageIds))).Data, countUpdated);
                
                return new UpdateSuccessResult<List<DM.NewContentWorkflowStages.NewContentWorkflowStage>>(new List<DM.NewContentWorkflowStages.NewContentWorkflowStage>(), countUpdated);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);

                throw new CannotUpdateRecordsException(ex);
            }
        }

        public Task<IDeleteResult<List<Guid>>> DeleteAsync(IEnumerable<Guid> validatedNewContentWorkflowStagesToRemoveIds, Guid actioningUserId)
        {
            throw new NotImplementedException();
        }
    }
}
