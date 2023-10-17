/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Entities.Content;
using Astrana.Core.Data.Exceptions;
using Astrana.Core.Data.Repositories.Audios;
using Astrana.Core.Domain.Models.AudioClips.Contracts;
using Astrana.Core.Domain.Models.AudioClips.Options;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Contracts;
using Astrana.Core.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using DM = Astrana.Core.Domain.Models;

namespace Astrana.Core.Data.Repositories.AudioClips
{
    public class AudioRepository : BaseRepository<AudioRepository, Guid>, IAudioRepository<Guid>
    {
        public AudioRepository(ILogger<AudioRepository> logger, ApplicationDbContext context) : base(logger, context)
        {
        }

        /// <summary>
        /// Builds up an IQueryable according to the specified filter criteria.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        private IQueryable<Audio> BuildQuery(AudioQueryOptions<Guid, Guid>? options = null)
        {
            options ??= new AudioQueryOptions<Guid, Guid>();

            var query = databaseSession.Audios.AsQueryable();

            // Add Filters
            if (options.Ids.Any())
                query = query.Where(o => options.Ids.Contains(o.AudioId));

            if (options.ExcludeIds.Any())
                query = query.Where(o => !options.ExcludeIds.Contains(o.AudioId));

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
        /// Returns a count of Audio according to the specified filter criteria.
        /// </summary>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        public async Task<ICountResult> GetAudiosCountAsync(AudioQueryOptions<Guid, Guid>? queryOptions = null)
        {
            queryOptions ??= new AudioQueryOptions<Guid, Guid>();

            queryOptions.PagingDisabled = true;

            return new CountResult(await BuildQuery(queryOptions).CountAsync());
        }

        /// <summary>
        /// Returns a list of Audio according to the specified filter criteria.
        /// </summary>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        public async Task<IGetResult<DM.AudioClips.Audio>> GetAudiosAsync(AudioQueryOptions<Guid, Guid>? queryOptions = null)
        {
            queryOptions ??= new AudioQueryOptions<Guid, Guid>();

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

            var countries = queryResults.Select(country => ModelMapper.MapModel<DM.AudioClips.Audio, Audio>(country)).ToList();

            logger.LogInformation(string.Format(MessageRetrievedEntity, nameof(Audio)), queryOptions);

            return CreateGetResultWithPagination(countries, queryOptions, resultSetCount);
        }
        
        /// <summary>
        /// Finds and returns a Audio by it's Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<DM.AudioClips.Audio?> GetAudioByIdAsync(Guid id)
        {
            return (await GetAudiosAsync(new AudioQueryOptions<Guid, Guid>(new List<Guid> { id }))).Data.FirstOrDefault();
        }
        
        /// <summary>
        /// Adds new Audio to the Data Source.
        /// </summary>
        /// <param name="requestedAdditions"></param>
        /// <param name="actioningUserId"></param>
        /// <param name="returnRecords"></param>
        /// <returns></returns>
        public async Task<IAddResult<List<DM.AudioClips.Audio>>> CreateAsync(IEnumerable<IAudioToAdd> requestedAdditions, Guid actioningUserId, bool returnRecords = true)
        {
            ValidateActioningUserId(actioningUserId);

            var countAdded = 0;
            var newAudioIds = new List<Guid>();

            try
            {
                var now = DateTime.UtcNow;

                foreach (var addition in requestedAdditions)
                {
                    var newAudioEntity = ModelMapper.MapModel<Audio, IAudioToAdd>(addition);

                    if (newAudioEntity == null)
                        continue;

                    newAudioEntity.CreatedBy = actioningUserId;
                    newAudioEntity.CreatedTimestamp = now;

                    newAudioEntity.LastModifiedBy = actioningUserId;
                    newAudioEntity.LastModifiedTimestamp = now;

                    // Save records.
                    databaseSession.Audios.Add(newAudioEntity);
                    await databaseSession.SaveChangesAsync();

                    countAdded++;

                    newAudioIds.Add(newAudioEntity.AudioId);
                }

                logger.LogInformation(string.Format(MessageSuccessfullyCreatedEntity, newAudioIds.Count, nameof(Audio) + "(s)"));

                // Return the current records.
                if (returnRecords)
                    return new AddSuccessResult<List<DM.AudioClips.Audio>>((await GetAudiosAsync(new AudioQueryOptions<Guid, Guid>() { Ids = newAudioIds })).Data, countAdded);

                return new AddSuccessResult<List<DM.AudioClips.Audio>>(new List<DM.AudioClips.Audio>(), countAdded);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);

                throw new CannotCreateRecordsException(ex);
            }
        }

        /// <summary>
        /// Updates existing Audio in the Data Source.
        /// </summary>
        /// <param name="requestedUpdates"></param>
        /// <param name="actioningUserId"></param>
        /// <param name="returnRecords"></param>
        /// <returns></returns>
        public async Task<IUpdateResult<List<DM.AudioClips.Audio>>> UpdateAsync(IEnumerable<DM.AudioClips.Audio> requestedUpdates, Guid actioningUserId, bool returnRecords = true)
        {
            ValidateActioningUserId(actioningUserId);

            var countUpdated = 0;
            var updatedAudioIds = new List<Guid>();

            try
            {
                var now = DateTime.UtcNow;

                foreach (var update in requestedUpdates)
                {
                    var existingAudioEntity = await databaseSession.Audios.FirstOrDefaultAsync(o => o.AudioId == update.AudioId);

                    if (existingAudioEntity == null)
                        continue;

                    // Update entity fields

                    existingAudioEntity.LastModifiedBy = actioningUserId;
                    existingAudioEntity.LastModifiedTimestamp = now;

                    // Save changes to records.
                    databaseSession.Audios.Update(existingAudioEntity);

                    await databaseSession.SaveChangesAsync();

                    countUpdated++;

                    updatedAudioIds.Add(existingAudioEntity.AudioId);
                }

                logger.LogInformation(string.Format(MessageSuccessfullyUpdatedEntity, updatedAudioIds.Count, nameof(Audio) + "(s)"));

                // Return the current records.
                if (returnRecords)
                    return new UpdateSuccessResult<List<DM.AudioClips.Audio>>((await GetAudiosAsync(new AudioQueryOptions<Guid, Guid>() { Ids = updatedAudioIds })).Data, countUpdated);

                return new UpdateSuccessResult<List<DM.AudioClips.Audio>>(new List<DM.AudioClips.Audio>(), countUpdated);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);

                throw new CannotUpdateRecordsException(ex);
            }
        }

        public Task<IDeleteResult<List<Guid>>> DeleteAsync(IEnumerable<Guid> validatedAudioToRemoveIds, Guid actioningUserId)
        {
            throw new NotImplementedException();
        }
    }
}
