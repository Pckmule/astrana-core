﻿/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Entities.Configuration;
using Astrana.Core.Data.Exceptions;
using Astrana.Core.Domain.Models.Languages.Contracts;
using Astrana.Core.Domain.Models.Languages.Options;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Contracts;
using Astrana.Core.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using DM = Astrana.Core.Domain.Models;

namespace Astrana.Core.Data.Repositories.Languages
{
    public class LanguageRepository : BaseRepository<LanguageRepository, Guid>, ILanguageRepository<Guid>
    {
        public LanguageRepository(ILogger<LanguageRepository> logger, ApplicationDbContext context) : base(logger, context)
        {
        }

        /// <summary>
        /// Builds up an IQueryable according to the specified filter criteria.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        private IQueryable<Language> BuildQuery(LanguageQueryOptions<Guid, Guid>? options = null)
        {
            options ??= new LanguageQueryOptions<Guid, Guid>();

            var query = ctx.Languages.AsQueryable();

            // Add Filters
            if (options.Ids.Any())
                query = query.Where(o => options.Ids.Contains(o.Id));

            if (options.CreatedBefore.HasValue)
                query = query.Where(o => o.CreatedTimestamp < options.CreatedBefore.Value);

            if (options.CreatedAfter.HasValue)
                query = query.Where(o => o.CreatedTimestamp > options.CreatedAfter.Value);

            if (!options.IncludeDeactivated)
                query = query.Where(o => !o.DeactivatedTimestamp.HasValue);

            // Add Ordering
            query = query.OrderByDescending(o => o.CreatedTimestamp);

            // Add Paging
            if (!options.PagingDisabled && options.PageSize.HasValue && options.CurrentPage.HasValue)
                query = query.Skip(options.PageSize.Value * (options.CurrentPage.Value - 1)).Take(options.PageSize.Value);

            return query;
        }

        /// <summary>
        /// Returns a count of Languages according to the specified filter criteria.
        /// </summary>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        public async Task<ICountResult> GetLanguagesCountAsync(LanguageQueryOptions<Guid, Guid>? queryOptions = null)
        {
            queryOptions ??= new LanguageQueryOptions<Guid, Guid>();

            queryOptions.PagingDisabled = true;

            return new CountResult(await BuildQuery(queryOptions).CountAsync());
        }

        /// <summary>
        /// Returns a list of Languages according to the specified filter criteria.
        /// </summary>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        public async Task<IGetResult<DM.Languages.Language>> GetLanguagesAsync(LanguageQueryOptions<Guid, Guid>? queryOptions = null)
        {
            queryOptions ??= new LanguageQueryOptions<Guid, Guid>();

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

            var countries = queryResults.Select(country => ModelMapper.MapModel<DM.Languages.Language, Language>(country)).ToList();

            logger.LogInformation(string.Format(MessageRetrievedEntity, nameof(Language)), queryOptions);

            return CreateGetResultWithPagination(countries, queryOptions, resultSetCount);
        }

        /// <summary>
        /// Finds and returns a Language by it's Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<DM.Languages.Language?> GetLanguageByIdAsync(Guid id)
        {
            return (await GetLanguagesAsync(new LanguageQueryOptions<Guid, Guid>(new List<Guid> { id }))).Data.FirstOrDefault();
        }

        /// <summary>
        /// Finds and returns a Language by it's Code.
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public async Task<DM.Languages.Language?> GetLanguageByCodeAsync(string code)
        {
            return (await GetLanguagesAsync(new LanguageQueryOptions<Guid, Guid>(new List<string> { code }))).Data.FirstOrDefault();
        }

        /// <summary>
        /// Adds new Languages to the Data Source.
        /// </summary>
        /// <param name="requestedAdditions"></param>
        /// <param name="actioningUserId"></param>
        /// <param name="returnRecords"></param>
        /// <returns></returns>
        public async Task<IAddResult<List<DM.Languages.Language>>> CreateAsync(IEnumerable<ILanguageToAdd> requestedAdditions, Guid actioningUserId, bool returnRecords = true)
        {
            ValidateActioningUserId(actioningUserId);

            var countAdded = 0;
            var newLanguageIds = new List<Guid>();

            try
            {
                var now = DateTime.UtcNow;

                foreach (var addition in requestedAdditions)
                {
                    var newLanguageEntity = ModelMapper.MapModel<Language, ILanguageToAdd>(addition);

                    if (newLanguageEntity == null)
                        continue;

                    newLanguageEntity.TwoLetterCode = newLanguageEntity.TwoLetterCode.ToUpperInvariant();
                    newLanguageEntity.ThreeLetterCode = newLanguageEntity.ThreeLetterCode.ToUpperInvariant();

                    newLanguageEntity.CreatedBy = actioningUserId;
                    newLanguageEntity.CreatedTimestamp = now;

                    newLanguageEntity.LastModifiedBy = actioningUserId;
                    newLanguageEntity.LastModifiedTimestamp = now;

                    // Save records.
                    ctx.Languages.Add(newLanguageEntity);
                    await ctx.SaveChangesAsync();

                    countAdded++;

                    newLanguageIds.Add(newLanguageEntity.Id);
                }

                logger.LogInformation(string.Format(MessageSuccessfullyCreatedEntity, newLanguageIds.Count, nameof(Language) + "(s)"));

                // Return the current records.
                if (returnRecords)
                    return new AddSuccessResult<List<DM.Languages.Language>>((await GetLanguagesAsync(new LanguageQueryOptions<Guid, Guid>() { Ids = newLanguageIds })).Data, countAdded);

                return new AddSuccessResult<List<DM.Languages.Language>>(new List<DM.Languages.Language>(), countAdded);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);

                throw new CannotCreateRecordsException(ex);
            }
        }

        /// <summary>
        /// Updates existing Languages in the Data Source.
        /// </summary>
        /// <param name="requestedUpdates"></param>
        /// <param name="actioningUserId"></param>
        /// <param name="returnRecords"></param>
        /// <returns></returns>
        public async Task<IUpdateResult<List<DM.Languages.Language>>> UpdateAsync(IEnumerable<DM.Languages.Language> requestedUpdates, Guid actioningUserId, bool returnRecords = true)
        {
            ValidateActioningUserId(actioningUserId);

            var countUpdated = 0;
            var updatedLanguageIds = new List<Guid>();

            try
            {
                var now = DateTime.UtcNow;

                foreach (var update in requestedUpdates)
                {
                    var existingLanguageEntity = await ctx.Languages.FirstOrDefaultAsync(o => o.Id == update.Id);

                    if (existingLanguageEntity == null)
                        continue;

                    // Update entity fields

                    existingLanguageEntity.Name = update.Name.Trim();
                    existingLanguageEntity.TwoLetterCode = update.TwoLetterCode.ToUpperInvariant().Trim();
                    existingLanguageEntity.ThreeLetterCode = update.ThreeLetterCode.ToUpperInvariant().Trim();

                    existingLanguageEntity.LastModifiedBy = actioningUserId;
                    existingLanguageEntity.LastModifiedTimestamp = now;

                    // Save changes to records.
                    ctx.Languages.Update(existingLanguageEntity);

                    await ctx.SaveChangesAsync();

                    countUpdated++;

                    updatedLanguageIds.Add(existingLanguageEntity.Id);
                }

                logger.LogInformation(string.Format(MessageSuccessfullyUpdatedEntity, updatedLanguageIds.Count, nameof(Language) + "(s)"));

                // Return the current records.
                if (returnRecords)
                    return new UpdateSuccessResult<List<DM.Languages.Language>>((await GetLanguagesAsync(new LanguageQueryOptions<Guid, Guid>() { Ids = updatedLanguageIds })).Data, countUpdated);

                return new UpdateSuccessResult<List<DM.Languages.Language>>(new List<DM.Languages.Language>(), countUpdated);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);

                throw new CannotUpdateRecordsException(ex);
            }
        }

        public Task<IDeleteResult<List<Guid>>> DeleteAsync(IEnumerable<Guid> validatedLanguagesToRemoveIds, Guid actioningUserId)
        {
            throw new NotImplementedException();
        }
    }
}
