/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Entities.AccessManagement;
using Astrana.Core.Data.Exceptions;
using Astrana.Core.Domain.Models.ApiAccessTokens.Contracts;
using Astrana.Core.Domain.Models.ApiAccessTokens.Options;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Contracts;
using Astrana.Core.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using DM = Astrana.Core.Domain.Models;

namespace Astrana.Core.Data.Repositories.ApiAccessTokens
{
    public class ApiAccessTokenRepository : BaseRepository<ApiAccessTokenRepository, Guid>, IApiAccessTokenRepository<Guid>
    {
        public ApiAccessTokenRepository(ILogger<ApiAccessTokenRepository> logger, ApplicationDbContext context) : base(logger, context)
        {
        }

        /// <summary>
        /// Builds up an IQueryable according to the specified filter criteria.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        private IQueryable<ApiAccessToken> BuildQuery(ApiAccessTokenQueryOptions<Guid, Guid>? options = null)
        {
            options ??= new ApiAccessTokenQueryOptions<Guid, Guid>();

            var query = databaseSession.ApiAccessTokens.AsQueryable();

            // Add Filters
            if (options.Ids.Any())
                query = query.Where(o => options.Ids.Contains(o.ApiAccessTokenId));

            if (options.ExcludeIds.Any())
                query = query.Where(o => !options.ExcludeIds.Contains(o.ApiAccessTokenId));

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
        /// Returns a count of Api Access Tokens according to the specified filter criteria.
        /// </summary>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        public async Task<ICountResult> GetCountAsync(ApiAccessTokenQueryOptions<Guid, Guid>? queryOptions = null)
        {
            queryOptions ??= new ApiAccessTokenQueryOptions<Guid, Guid>();

            queryOptions.PagingDisabled = true;

            return new CountResult(await BuildQuery(queryOptions).CountAsync());
        }

        /// <summary>
        /// Returns a list of Api Access Tokens according to the specified filter criteria.
        /// </summary>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        public async Task<IGetResult<DM.ApiAccessTokens.ApiAccessToken>> GetAsync(ApiAccessTokenQueryOptions<Guid, Guid>? queryOptions = null)
        {
            queryOptions ??= new ApiAccessTokenQueryOptions<Guid, Guid>();

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

            var apiAccessTokens = queryResults.Select(Data.Entities.AccessManagement.ModelMappings.ApiAccessToken.MapToDomainModel).ToList();

            logger.LogInformation(string.Format(MessageRetrievedEntity, nameof(ApiAccessToken)), queryOptions);

            return CreateGetResultWithPagination(apiAccessTokens, queryOptions, resultSetCount);
        }

        /// <summary>
        /// Finds and returns an Api Access Token by it's record ID.
        /// </summary>
        /// <param name="recordId"></param>
        /// <returns></returns>
        public async Task<DM.ApiAccessTokens.ApiAccessToken> GetByIdAsync(Guid recordId)
        {
            return (await GetAsync(new ApiAccessTokenQueryOptions<Guid, Guid>(new List<Guid> { recordId }))).Data.FirstOrDefault();
        }

        /// <summary>
        /// Adds new API Access Tokens to the Data Source.
        /// </summary>
        /// <param name="requestedAdditions"></param>
        /// <param name="actioningUserId"></param>
        /// <param name="returnRecords"></param>
        /// <returns></returns>
        public async Task<IAddResult<List<DM.ApiAccessTokens.ApiAccessToken>>> CreateAsync(IEnumerable<IApiAccessTokenToAdd> requestedAdditions, Guid actioningUserId, bool returnRecords = true)
        {
            ValidateActioningUserId(actioningUserId);

            var countAdded = 0;
            var newApiAccessTokenIds = new List<Guid>();

            try
            {
                var now = DateTime.UtcNow;

                foreach (var addition in requestedAdditions)
                {
                    var newApiAccessTokenEntity = ModelMapper.MapModel<ApiAccessToken, IApiAccessTokenToAdd>(addition);

                    newApiAccessTokenEntity.CreatedBy = actioningUserId;
                    newApiAccessTokenEntity.CreatedTimestamp = now;

                    newApiAccessTokenEntity.LastModifiedBy = actioningUserId;
                    newApiAccessTokenEntity.LastModifiedTimestamp = now;

                    // Save records.
                    databaseSession.ApiAccessTokens.Add(newApiAccessTokenEntity);
                    await databaseSession.SaveChangesAsync();

                    countAdded++;

                    newApiAccessTokenIds.Add(newApiAccessTokenEntity.ApiAccessTokenId);
                }

                logger.LogInformation(string.Format(MessageSuccessfullyCreatedEntity, newApiAccessTokenIds.Count, nameof(ApiAccessToken) + "(s)"));

                // Return the current records.
                if (returnRecords)
                    return new AddSuccessResult<List<DM.ApiAccessTokens.ApiAccessToken>>((await GetAsync(new ApiAccessTokenQueryOptions<Guid, Guid>(newApiAccessTokenIds))).Data, countAdded);
                
                return new AddSuccessResult<List<DM.ApiAccessTokens.ApiAccessToken>>(new List<DM.ApiAccessTokens.ApiAccessToken>(), countAdded);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);

                throw new CannotCreateRecordsException(ex);
            }
        }
        
        public Task<IDeleteResult<List<Guid>>> DeleteAsync(IEnumerable<Guid> validatedApiAccessTokensToRemoveIds, Guid actioningUserId)
        {
            throw new NotImplementedException();
        }
    }
}
