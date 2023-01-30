/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Entities.Configuration;
using Astrana.Core.Data.Exceptions;
using Astrana.Core.Domain.Models.Countries.Contracts;
using Astrana.Core.Domain.Models.Countries.Options;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Contracts;
using Astrana.Core.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using DM = Astrana.Core.Domain.Models;

namespace Astrana.Core.Data.Repositories.Countries
{
    public class CountryRepository : BaseRepository<CountryRepository, Guid>, ICountryRepository<Guid>
    {
        public CountryRepository(ILogger<CountryRepository> logger, ApplicationDbContext context) : base(logger, context)
        {
        }

        /// <summary>
        /// Builds up an IQueryable according to the specified filter criteria.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        private IQueryable<Country> BuildQuery(CountryQueryOptions<long, Guid>? options = null)
        {
            options ??= new CountryQueryOptions<long, Guid>();

            var query = ctx.Countries.AsQueryable();

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
        /// Returns a count of Countries according to the specified filter criteria.
        /// </summary>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        public async Task<ICountResult> GetCountriesCountAsync(CountryQueryOptions<long, Guid>? queryOptions = null)
        {
            queryOptions ??= new CountryQueryOptions<long, Guid>();

            queryOptions.PagingDisabled = true;

            return new CountResult(await BuildQuery(queryOptions).CountAsync());
        }

        /// <summary>
        /// Returns a list of Countries according to the specified filter criteria.
        /// </summary>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        public async Task<IGetResult<DM.Countries.Country>> GetCountriesAsync(CountryQueryOptions<long, Guid>? queryOptions = null)
        {
            queryOptions ??= new CountryQueryOptions<long, Guid>();

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

            var countries = queryResults.Select(country => ModelMapper.MapModel<DM.Countries.Country, Country>(country)).ToList();

            logger.LogInformation(string.Format(MessageRetrievedEntity, nameof(Country)), queryOptions);

            return CreateGetResultWithPagination(countries, queryOptions, resultSetCount);
        }

        /// <summary>
        /// Finds and returns a Country by it's Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<DM.Countries.Country?> GetCountryByIdAsync(long id)
        {
            return (await GetCountriesAsync(new CountryQueryOptions<long, Guid>(new List<long> { id }))).Data.FirstOrDefault();
        }

        /// <summary>
        /// Finds and returns a Country by it's Code.
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public async Task<DM.Countries.Country?> GetCountryByCodeAsync(string code)
        {
            return (await GetCountriesAsync(new CountryQueryOptions<long, Guid>(new List<string> { code }))).Data.FirstOrDefault();
        }

        /// <summary>
        /// Adds new Countries to the Data Source.
        /// </summary>
        /// <param name="requestedAdditions"></param>
        /// <param name="actioningUserId"></param>
        /// <param name="returnRecords"></param>
        /// <returns></returns>
        public async Task<IAddResult<List<DM.Countries.Country>>> CreateAsync(IEnumerable<ICountryToAdd> requestedAdditions, Guid actioningUserId, bool returnRecords = true)
        {
            ValidateActioningUserId(actioningUserId);

            var countAdded = 0;
            var newCountryIds = new List<long>();

            try
            {
                var now = DateTime.UtcNow;

                foreach (var addition in requestedAdditions)
                {
                    var newCountryEntity = ModelMapper.MapModel<Country, ICountryToAdd>(addition);

                    if (newCountryEntity == null)
                        continue;

                    newCountryEntity.TwoLetterCode = newCountryEntity.TwoLetterCode.ToUpperInvariant();
                    newCountryEntity.ThreeLetterCode = newCountryEntity.ThreeLetterCode.ToUpperInvariant();

                    newCountryEntity.CreatedBy = actioningUserId;
                    newCountryEntity.CreatedTimestamp = now;

                    newCountryEntity.LastModifiedBy = actioningUserId;
                    newCountryEntity.LastModifiedTimestamp = now;

                    // Save records.
                    ctx.Countries.Add(newCountryEntity);
                    await ctx.SaveChangesAsync();

                    countAdded++;

                    newCountryIds.Add(newCountryEntity.Id);
                }

                logger.LogInformation(string.Format(MessageSuccessfullyCreatedEntity, newCountryIds.Count, nameof(Country) + "(s)"));

                // Return the current records.
                if (returnRecords)
                    return new AddSuccessResult<List<DM.Countries.Country>>((await GetCountriesAsync(new CountryQueryOptions<long, Guid>() { Ids = newCountryIds })).Data, countAdded);

                return new AddSuccessResult<List<DM.Countries.Country>>(new List<DM.Countries.Country>(), countAdded);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);

                throw new CannotCreateRecordsException(ex);
            }
        }

        /// <summary>
        /// Updates existing Countries in the Data Source.
        /// </summary>
        /// <param name="requestedUpdates"></param>
        /// <param name="actioningUserId"></param>
        /// <param name="returnRecords"></param>
        /// <returns></returns>
        public async Task<IUpdateResult<List<DM.Countries.Country>>> UpdateAsync(IEnumerable<DM.Countries.Country> requestedUpdates, Guid actioningUserId, bool returnRecords = true)
        {
            ValidateActioningUserId(actioningUserId);

            var countUpdated = 0;
            var updatedCountryIds = new List<long>();

            try
            {
                var now = DateTime.UtcNow;

                foreach (var update in requestedUpdates)
                {
                    var existingCountryEntity = await ctx.Countries.FirstOrDefaultAsync(o => o.Id == update.Id);

                    if (existingCountryEntity == null)
                        continue;

                    // Update entity fields

                    existingCountryEntity.Name = update.Name.Trim();
                    existingCountryEntity.TwoLetterCode = update.TwoLetterCode.ToUpperInvariant().Trim();
                    existingCountryEntity.ThreeLetterCode = update.ThreeLetterCode.ToUpperInvariant().Trim();
                                        
                    existingCountryEntity.LastModifiedBy = actioningUserId;
                    existingCountryEntity.LastModifiedTimestamp = now;

                    // Save changes to records.
                    ctx.Countries.Update(existingCountryEntity);

                    await ctx.SaveChangesAsync();

                    countUpdated++;

                    updatedCountryIds.Add(existingCountryEntity.Id);
                }

                logger.LogInformation(string.Format(MessageSuccessfullyUpdatedEntity, updatedCountryIds.Count, nameof(Country) + "(s)"));

                // Return the current records.
                if (returnRecords)
                    return new UpdateSuccessResult<List<DM.Countries.Country>>((await GetCountriesAsync(new CountryQueryOptions<long, Guid>() { Ids = updatedCountryIds })).Data, countUpdated);

                return new UpdateSuccessResult<List<DM.Countries.Country>>(new List<DM.Countries.Country>(), countUpdated);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);

                throw new CannotUpdateRecordsException(ex);
            }
        }

        public Task<IDeleteResult<List<long>>> DeleteAsync(IEnumerable<long> validatedCountriesToRemoveIds, Guid actioningUserId)
        {
            throw new NotImplementedException();
        }
    }
}
