/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Entities.Peers;
using Astrana.Core.Data.Exceptions;
using Astrana.Core.Domain.Models.Options.Enums;
using Astrana.Core.Domain.Models.Peers.Contracts;
using Astrana.Core.Domain.Models.Peers.Enums;
using Astrana.Core.Domain.Models.Peers.Options;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Contracts;
using Astrana.Core.Domain.Models.Results.Enums;
using Astrana.Core.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using DM = Astrana.Core.Domain.Models;

namespace Astrana.Core.Data.Repositories.Peers
{
    public class PeerRepository : BaseRepository<PeerRepository, Guid>, IPeerRepository<Guid>
    {
        public PeerRepository(ILogger<PeerRepository> logger, ApplicationDbContext context) : base(logger, context)
        {
        }

        /// <summary>
        /// Builds up an IQueryable that returns Peers according to the specified filter criteria.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        private IQueryable<Peer> BuildPeersQuery(PeerQueryOptions<Guid, Guid>? options = null)
        {
            options ??= new PeerQueryOptions<Guid, Guid>();

            var query = ctx.Peers.AsQueryable();

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
        /// Returns a count of Peers according to the specified filter criteria.
        /// </summary>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        public async Task<ICountResult> GetPeersCountAsync(PeerQueryOptions<Guid, Guid>? queryOptions = null)
        {
            queryOptions ??= new PeerQueryOptions<Guid, Guid>();

            queryOptions.PagingDisabled = true;

            return new CountResult(await BuildPeersQuery(queryOptions).CountAsync());
        }

        /// <summary>
        /// Returns a list of Peers according to the specified filter criteria.
        /// </summary>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        public async Task<IGetResult<DM.Peers.Peer>> GetPeersAsync(PeerQueryOptions<Guid, Guid>? queryOptions = null)
        {
            queryOptions ??= new PeerQueryOptions<Guid, Guid>();

            var queryResults = await BuildPeersQuery(queryOptions).ToListAsync();

            int resultSetCount;
            if (queryOptions.PagingDisabled)
            {
                var countResultSetQueryOptions = queryOptions.Clone();
                countResultSetQueryOptions.PagingDisabled = true;

                resultSetCount = await BuildPeersQuery(queryOptions).CountAsync();
            }
            else
                resultSetCount = queryResults.Count;

            var peers = queryResults.Select(peer => ModelMapper.MapModel<DM.Peers.Peer, Peer>(peer)).ToList();

            logger.LogInformation(string.Format(MessageRetrievedEntity, nameof(Peer)), queryOptions);

            return CreateGetResultWithPagination(peers, queryOptions, resultSetCount);
        }

        /// <summary>
        /// Finds and returns a Peer by it's Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<DM.Peers.Peer?> GetPeerByIdAsync(Guid id)
        {
            return (await GetPeersAsync(new PeerQueryOptions<Guid, Guid>(new List<Guid> { id }))).Data.FirstOrDefault();
        }

        /// <summary>
        /// Adds new Peers to the Data Source.
        /// </summary>
        /// <param name="requestedAdditions"></param>
        /// <param name="actioningUserId"></param>
        /// <param name="returnRecords"></param>
        /// <returns></returns>
        public async Task<IAddResult<List<DM.Peers.Peer>>> CreatePeersAsync(IEnumerable<IPeerToAdd> requestedAdditions, Guid actioningUserId, bool returnRecords = true)
        {
            ValidateActioningUserId(actioningUserId);

            var countAdded = 0;
            var newPeerIds = new List<Guid>();

            try
            {
                var now = DateTime.UtcNow;

                foreach (var addition in requestedAdditions)
                {
                    var newPeerEntity = ModelMapper.MapModel<Peer, IPeerToAdd>(addition);

                    newPeerEntity.CreatedBy = actioningUserId;
                    newPeerEntity.CreatedTimestamp = now;

                    newPeerEntity.LastModifiedBy = actioningUserId;
                    newPeerEntity.LastModifiedTimestamp = now;

                    // Save records.
                    ctx.Peers.Add(newPeerEntity);
                    await ctx.SaveChangesAsync();

                    countAdded++;

                    newPeerIds.Add(newPeerEntity.Id);
                }

                logger.LogInformation(string.Format(MessageSuccessfullyCreatedEntity, newPeerIds.Count, nameof(Peer) + "(s)"));

                // Return the current records.
                if (returnRecords)
                    return new AddSuccessResult<List<DM.Peers.Peer>>((await GetPeersAsync(new PeerQueryOptions<Guid, Guid> { Ids = newPeerIds })).Data, countAdded);
                
                return new AddSuccessResult<List<DM.Peers.Peer>>(new List<DM.Peers.Peer>(), countAdded);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);

                throw new CannotCreateRecordsException(ex);
            }
        }

        /// <summary>
        /// Updates existing Peers in the Data Source.
        /// </summary>
        /// <param name="requestedUpdates"></param>
        /// <param name="actioningUserId"></param>
        /// <param name="returnRecords"></param>
        /// <returns></returns>
        public async Task<IUpdateResult<List<DM.Peers.Peer>>> UpdatePeersAsync(IEnumerable<IPeer> requestedUpdates, Guid actioningUserId, bool returnRecords = true)
        {
            ValidateActioningUserId(actioningUserId);

            var countUpdated = 0;
            var updatedPeerIds = new List<Guid>();

            try
            {
                var now = DateTime.UtcNow;

                foreach (var update in requestedUpdates)
                {
                    var existingPeerEntity = await ctx.Peers.FirstOrDefaultAsync(o => o.Id == update.Id);

                    if (existingPeerEntity == null)
                        continue;

                    // Update entity fields

                    existingPeerEntity.FirstName = update.FirstName.Trim();
                    existingPeerEntity.LastName = update.LastName.Trim();
                    existingPeerEntity.Address = update.Address.Trim();
                    existingPeerEntity.Note = update.Note.Trim();

                    existingPeerEntity.LastModifiedBy = actioningUserId;
                    existingPeerEntity.LastModifiedTimestamp = now;

                    // Save changes to records.
                    ctx.Peers.Update(existingPeerEntity);

                    await ctx.SaveChangesAsync();

                    countUpdated++;

                    updatedPeerIds.Add(existingPeerEntity.Id);
                }

                logger.LogInformation(string.Format(MessageSuccessfullyUpdatedEntity, updatedPeerIds.Count, nameof(Peer) + "(s)"));

                // Return the current records.
                if (returnRecords)
                    return new UpdateSuccessResult<List<DM.Peers.Peer>>((await GetPeersAsync(new PeerQueryOptions<Guid, Guid>() { Ids = updatedPeerIds })).Data, countUpdated);
                
                return new UpdateSuccessResult<List<DM.Peers.Peer>>(new List<DM.Peers.Peer>(), countUpdated);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);

                throw new CannotUpdateRecordsException(ex);
            }
        }

        /// <summary>
        /// Soft deletes Peers
        /// </summary>
        /// <param name="peersIds"></param>
        /// <param name="actioningUserId"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<IDeleteResult<List<Guid>>> DeletePeersAsync(IEnumerable<Guid> peersIds, Guid actioningUserId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Builds up an IQueryable that returns Received Peer Connection Requests according to the specified filter criteria.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        private IQueryable<PeerConnectionRequestReceived> BuildReceivedPeerConnectionRequestsQuery(ReceivedPeerConnectionRequestQueryOptions<Guid, Guid>? options = null)
        {
            options ??= new ReceivedPeerConnectionRequestQueryOptions<Guid, Guid>();

            var query = ctx.PeerConnectionRequestsReceived.AsQueryable();

            // Add Filters
            if (options.Ids.Any() || options.IdsMatchMode == QueryOptionsMatchMode.Strict)
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
        /// Returns a count of Received Peer Connection Requests according to the specified filter criteria.
        /// </summary>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        public async Task<ICountResult> GetReceivedPeerConnectionRequestsCountAsync(ReceivedPeerConnectionRequestQueryOptions<Guid, Guid>? queryOptions = null)
        {
            queryOptions ??= new ReceivedPeerConnectionRequestQueryOptions<Guid, Guid>();

            queryOptions.PagingDisabled = true;

            return new CountResult(await BuildReceivedPeerConnectionRequestsQuery(queryOptions).CountAsync());
        }

        /// <summary>
        /// Returns a list of Received Peer Connection Requests according to the specified filter criteria.
        /// </summary>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        public async Task<IGetResult<DM.Peers.PeerConnectionRequestReceived>> GetReceivedPeerConnectionRequestsAsync(ReceivedPeerConnectionRequestQueryOptions<Guid, Guid>? queryOptions = null)
        {
            queryOptions ??= new ReceivedPeerConnectionRequestQueryOptions<Guid, Guid>();

            var queryResults = await BuildReceivedPeerConnectionRequestsQuery(queryOptions).ToListAsync();

            int resultSetCount;
            if (queryOptions.PagingDisabled)
            {
                var countResultSetQueryOptions = queryOptions.Clone();
                countResultSetQueryOptions.PagingDisabled = true;

                resultSetCount = await BuildReceivedPeerConnectionRequestsQuery(queryOptions).CountAsync();
            }
            else
                resultSetCount = queryResults.Count;

            var peerConnectionRequests = queryResults.Select(peerConnectionRequest => ModelMapper.MapModel<DM.Peers.PeerConnectionRequestReceived, PeerConnectionRequestReceived>(peerConnectionRequest)).ToList();

            logger.LogInformation(string.Format(MessageRetrievedEntity, nameof(PeerConnectionRequestReceived)), queryOptions);

            return CreateGetResultWithPagination(peerConnectionRequests, queryOptions, resultSetCount);
        }

        /// <summary>
        /// Adds new Received Peer Connection Requests to the Data Source.
        /// </summary>
        /// <param name="requestedAdditions"></param>
        /// <param name="actioningUserId"></param>
        /// <param name="returnRecords"></param>
        /// <returns></returns>
        public async Task<IAddResult<List<DM.Peers.PeerConnectionRequestReceived>>> CreateReceivedPeerConnectionRequestsAsync(IEnumerable<IPeerConnectionRequestReceivedToAdd> requestedAdditions, Guid actioningUserId, bool returnRecords = true)
        {
            ValidateActioningUserId(actioningUserId);

            var countAdded = 0;
            var newPeerConnectionRequestIds = new List<Guid>();

            try
            {
                var now = DateTime.UtcNow;

                foreach (var addition in requestedAdditions)
                {
                    var newPeerConnectionRequestEntity = ModelMapper.MapModel<PeerConnectionRequestReceived, IPeerConnectionRequestReceivedToAdd>(addition);

                    if (newPeerConnectionRequestEntity == null)
                        continue;

                    newPeerConnectionRequestEntity.CreatedBy = actioningUserId;
                    newPeerConnectionRequestEntity.CreatedTimestamp = now;

                    newPeerConnectionRequestEntity.LastModifiedBy = actioningUserId;
                    newPeerConnectionRequestEntity.LastModifiedTimestamp = now;

                    // Save records.
                    ctx.PeerConnectionRequestsReceived.Add(newPeerConnectionRequestEntity);
                    await ctx.SaveChangesAsync();

                    countAdded++;

                    newPeerConnectionRequestIds.Add(newPeerConnectionRequestEntity.Id);
                }

                logger.LogInformation(string.Format(MessageSuccessfullyCreatedEntity, newPeerConnectionRequestIds.Count, nameof(PeerConnectionRequestReceived) + "(s)"));

                // Return the current records.
                if (returnRecords)
                    return new AddSuccessResult<List<DM.Peers.PeerConnectionRequestReceived>>((await GetReceivedPeerConnectionRequestsAsync(new ReceivedPeerConnectionRequestQueryOptions<Guid, Guid> { Ids = newPeerConnectionRequestIds, IdsMatchMode = QueryOptionsMatchMode.Strict})).Data, countAdded);

                return new AddSuccessResult<List<DM.Peers.PeerConnectionRequestReceived>>(new List<DM.Peers.PeerConnectionRequestReceived>(), countAdded);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);

                throw new CannotCreateRecordsException(ex);
            }
        }

        /// <summary>
        /// Sets the status of existing Received Peer Connection Requests to Accepted in the Data Source.
        /// </summary>
        /// <param name="requestedUpdateId"></param>
        /// <param name="actioningUserId"></param>
        /// <param name="returnRecords"></param>
        /// <returns></returns>
        public async Task<IUpdateResult<List<DM.Peers.PeerConnectionRequestReceived>>> AcceptPeerConnectionRequestAsync(Guid requestedUpdateId, Guid actioningUserId, bool returnRecords = true)
        {
            ValidateActioningUserId(actioningUserId);

            var countUpdated = 0;
            var updatedPeerConnectionRequestIds = new List<Guid>();

            try
            {
                var now = DateTime.UtcNow;

                var existingPeerConnectionRequestEntity = await ctx.PeerConnectionRequestsReceived.FirstOrDefaultAsync(o => o.Id == requestedUpdateId);

                if (existingPeerConnectionRequestEntity == null)
                    throw new EntityNotFoundException();

                if (existingPeerConnectionRequestEntity.Status != PeerConnectionRequestStatus.Default)
                {
                    return new UpdateSuccessResult<List<DM.Peers.PeerConnectionRequestReceived>>(new List<DM.Peers.PeerConnectionRequestReceived>(), countUpdated);
                }

                await using (var transaction = await ctx.Database.BeginTransactionAsync())
                {
                    // Update entity fields

                    existingPeerConnectionRequestEntity.Status = PeerConnectionRequestStatus.Accepted;

                    existingPeerConnectionRequestEntity.LastModifiedBy = actioningUserId;
                    existingPeerConnectionRequestEntity.LastModifiedTimestamp = now;

                    // Save changes to records.
                    ctx.PeerConnectionRequestsReceived.Update(existingPeerConnectionRequestEntity);

                    await ctx.SaveChangesAsync();

                    // Build Peer record.
                    var newPeerEntity = new Peer
                    {
                        FirstName = existingPeerConnectionRequestEntity.FirstName,
                        LastName = existingPeerConnectionRequestEntity.LastName,
                        Address = existingPeerConnectionRequestEntity.Address,
                        Note = existingPeerConnectionRequestEntity.Note,
                        PeerAccessToken = existingPeerConnectionRequestEntity.PeerPreviewAccessToken
                    };

                    newPeerEntity.CreatedBy = actioningUserId;
                    newPeerEntity.CreatedTimestamp = now;

                    newPeerEntity.LastModifiedBy = actioningUserId;
                    newPeerEntity.LastModifiedTimestamp = now;

                    // Save Peer record.
                    ctx.Peers.Add(newPeerEntity);
                    await ctx.SaveChangesAsync();

                    await transaction.CommitAsync();

                    countUpdated++;

                    updatedPeerConnectionRequestIds.Add(existingPeerConnectionRequestEntity.Id);

                    logger.LogInformation(string.Format(MessageSuccessfullyUpdatedEntity,
                        updatedPeerConnectionRequestIds.Count, nameof(PeerConnectionRequestReceived) + "(s)"));

                    // Return the current record.
                    if (returnRecords)
                        return new UpdateSuccessResult<List<DM.Peers.PeerConnectionRequestReceived>>((await GetReceivedPeerConnectionRequestsAsync(new ReceivedPeerConnectionRequestQueryOptions<Guid, Guid> { Ids = updatedPeerConnectionRequestIds, IdsMatchMode = QueryOptionsMatchMode.Strict })).Data, countUpdated, "Successfully accepted peer connection request(s).");

                    return new UpdateSuccessResult<List<DM.Peers.PeerConnectionRequestReceived>>(new List<DM.Peers.PeerConnectionRequestReceived>(), countUpdated, "Successfully accepted peer connection request(s).");
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);

                throw new CannotUpdateRecordsException(ex);
            }
        }

        /// <summary>
        /// Sets the status of existing Received Peer Connection Requests to Accepted in the Data Source.
        /// </summary>
        /// <param name="requestedUpdateIds"></param>
        /// <param name="actioningUserId"></param>
        /// <param name="returnRecords"></param>
        /// <returns></returns>
        public async Task<IUpdateResult<List<DM.Peers.PeerConnectionRequestReceived>>> AcceptPeerConnectionRequestsAsync(IEnumerable<Guid> requestedUpdateIds, Guid actioningUserId, bool returnRecords = true)
        {
            ValidateActioningUserId(actioningUserId);

            var countUpdated = 0;
            var updatedPeerConnectionRequestIds = new List<Guid>();

            try
            {
                foreach (var updateId in requestedUpdateIds)
                {
                    var result = await AcceptPeerConnectionRequestAsync(updateId, actioningUserId);

                    if (result.Outcome == ResultOutcome.Success)
                        countUpdated++;
                }

                logger.LogInformation(string.Format(MessageSuccessfullyUpdatedEntity, updatedPeerConnectionRequestIds.Count, nameof(PeerConnectionRequestReceived) + "(s)"));

                // Return the current records.
                if (returnRecords)
                    return new UpdateSuccessResult<List<DM.Peers.PeerConnectionRequestReceived>>((await GetReceivedPeerConnectionRequestsAsync(new ReceivedPeerConnectionRequestQueryOptions<Guid, Guid> { Ids = updatedPeerConnectionRequestIds, IdsMatchMode = QueryOptionsMatchMode.Strict })).Data, countUpdated, "Successfully accepted peer connection request(s).");

                return new UpdateSuccessResult<List<DM.Peers.PeerConnectionRequestReceived>>(new List<DM.Peers.PeerConnectionRequestReceived>(), countUpdated, "Successfully accepted peer connection request(s).");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);

                throw new CannotUpdateRecordsException(ex);
            }
        }

        /// <summary>
        /// Sets the status of existing Received Peer Connection Requests to Rejected in the Data Source.
        /// </summary>
        /// <param name="requestedUpdateIds"></param>
        /// <param name="actioningUserId"></param>
        /// <param name="returnRecords"></param>
        /// <returns></returns>
        public async Task<IUpdateResult<List<DM.Peers.PeerConnectionRequestReceived>>> RejectPeerConnectionRequestsAsync(IEnumerable<Guid> requestedUpdateIds, Guid actioningUserId, bool returnRecords = true)
        {
            ValidateActioningUserId(actioningUserId);

            var countUpdated = 0;
            var updatedPeerConnectionRequestIds = new List<Guid>();

            try
            {
                var now = DateTime.UtcNow;

                foreach (var updateId in requestedUpdateIds)
                {
                    var existingPeerConnectionRequestEntity = await ctx.PeerConnectionRequestsReceived.FirstOrDefaultAsync(o => o.Id == updateId);

                    if (existingPeerConnectionRequestEntity == null)
                        continue;

                    if (existingPeerConnectionRequestEntity.Status != PeerConnectionRequestStatus.Default)
                    {
                        countUpdated++;
                        updatedPeerConnectionRequestIds.Add(existingPeerConnectionRequestEntity.Id);
                        
                        continue;
                    }

                    // Update entity fields

                    existingPeerConnectionRequestEntity.Status = PeerConnectionRequestStatus.Rejected;

                    existingPeerConnectionRequestEntity.LastModifiedBy = actioningUserId;
                    existingPeerConnectionRequestEntity.LastModifiedTimestamp = now;

                    // Save changes to records.
                    ctx.PeerConnectionRequestsReceived.Update(existingPeerConnectionRequestEntity);

                    await ctx.SaveChangesAsync();

                    countUpdated++;

                    updatedPeerConnectionRequestIds.Add(existingPeerConnectionRequestEntity.Id);
                }

                logger.LogInformation(string.Format(MessageSuccessfullyUpdatedEntity, updatedPeerConnectionRequestIds.Count, nameof(PeerConnectionRequestReceived) + "(s)"));

                // Return the current records.
                if (returnRecords)
                    return new UpdateSuccessResult<List<DM.Peers.PeerConnectionRequestReceived>>((await GetReceivedPeerConnectionRequestsAsync(new ReceivedPeerConnectionRequestQueryOptions<Guid, Guid> { Ids = updatedPeerConnectionRequestIds, IdsMatchMode = QueryOptionsMatchMode.Strict})).Data, countUpdated);

                return new UpdateSuccessResult<List<DM.Peers.PeerConnectionRequestReceived>>(new List<DM.Peers.PeerConnectionRequestReceived>(), countUpdated);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);

                throw new CannotUpdateRecordsException(ex);
            }
        }

        /// <summary>
        /// Soft deletes Received Peer Connection Requests
        /// </summary>
        /// <param name="receivedPeerConnectionRequestsIds"></param>
        /// <param name="actioningUserId"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<IDeleteResult<List<Guid>>> DeleteReceivedPeerConnectionRequestsAsync(IEnumerable<Guid> receivedPeerConnectionRequestsIds, Guid actioningUserId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Builds up an IQueryable that returns Submitted Peer Connection Requests according to the specified filter criteria.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        private IQueryable<PeerConnectionRequestSubmitted> BuildSubmittedPeerConnectionRequestsQuery(SubmittedPeerConnectionRequestQueryOptions<Guid, Guid>? options = null)
        {
            options ??= new SubmittedPeerConnectionRequestQueryOptions<Guid, Guid>();

            var query = ctx.PeerConnectionRequestsSubmitted.AsQueryable();

            // Add Filters
            if (options.Ids.Any() || options.IdsMatchMode == QueryOptionsMatchMode.Strict)
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
        /// Returns a count of Submitted Peer Connection Requests according to the specified filter criteria.
        /// </summary>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<ICountResult> GetSubmittedPeerConnectionRequestsCountAsync(SubmittedPeerConnectionRequestQueryOptions<Guid, Guid>? queryOptions = null)
        {
            queryOptions ??= new SubmittedPeerConnectionRequestQueryOptions<Guid, Guid>();

            queryOptions.PagingDisabled = true;

            return new CountResult(await BuildSubmittedPeerConnectionRequestsQuery(queryOptions).CountAsync());
        }

        /// <summary>
        /// Returns a list of Submitted Peer Connection Requests according to the specified filter criteria.
        /// </summary>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<IGetResult<DM.Peers.PeerConnectionRequestSubmitted>> GetSubmittedPeerConnectionRequestsAsync(SubmittedPeerConnectionRequestQueryOptions<Guid, Guid>? queryOptions = null)
        {
            queryOptions ??= new SubmittedPeerConnectionRequestQueryOptions<Guid, Guid>();

            var queryResults = await BuildSubmittedPeerConnectionRequestsQuery(queryOptions).ToListAsync();

            int resultSetCount;
            if (queryOptions.PagingDisabled)
            {
                var countResultSetQueryOptions = queryOptions.Clone();
                countResultSetQueryOptions.PagingDisabled = true;

                resultSetCount = await BuildSubmittedPeerConnectionRequestsQuery(queryOptions).CountAsync();
            }
            else
                resultSetCount = queryResults.Count;

            var peerConnectionRequests = queryResults.Select(peerConnectionRequest => ModelMapper.MapModel<DM.Peers.PeerConnectionRequestSubmitted, PeerConnectionRequestSubmitted>(peerConnectionRequest)).ToList();

            logger.LogInformation(string.Format(MessageRetrievedEntity, nameof(PeerConnectionRequestSubmitted)), queryOptions);

            return CreateGetResultWithPagination(peerConnectionRequests, queryOptions, resultSetCount);
        }

        /// <summary>
        /// Adds new Submitted Peer Connection Requests to the Data Source.
        /// </summary>
        /// <param name="requestedAdditions"></param>
        /// <param name="actioningUserId"></param>
        /// <param name="returnRecords"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<IAddResult<List<DM.Peers.PeerConnectionRequestSubmitted>>> CreateSubmittedPeerConnectionRequestsAsync(IEnumerable<IPeerConnectionRequestSubmittedToAdd?> requestedAdditions, Guid actioningUserId, bool returnRecords = true)
        {
            ValidateActioningUserId(actioningUserId);
            
            var countAdded = 0;
            var newPeerConnectionRequestIds = new List<Guid>();

            try
            {
                var now = DateTime.UtcNow;

                foreach (var addition in requestedAdditions)
                {
                    var newPeerConnectionRequestEntity = ModelMapper.MapModel<PeerConnectionRequestSubmitted, IPeerConnectionRequestSubmittedToAdd>(addition);

                    if (newPeerConnectionRequestEntity == null)
                        continue;

                    newPeerConnectionRequestEntity.CreatedBy = actioningUserId;
                    newPeerConnectionRequestEntity.CreatedTimestamp = now;

                    newPeerConnectionRequestEntity.LastModifiedBy = actioningUserId;
                    newPeerConnectionRequestEntity.LastModifiedTimestamp = now;

                    // Save records.
                    ctx.PeerConnectionRequestsSubmitted.Add(newPeerConnectionRequestEntity);
                    await ctx.SaveChangesAsync();

                    countAdded++;

                    newPeerConnectionRequestIds.Add(newPeerConnectionRequestEntity.Id);
                }

                logger.LogInformation(string.Format(MessageSuccessfullyCreatedEntity, newPeerConnectionRequestIds.Count, nameof(PeerConnectionRequestSubmitted) + "(s)"));

                // Return the current records.
                if (returnRecords)
                    return new AddSuccessResult<List<DM.Peers.PeerConnectionRequestSubmitted>>((await GetSubmittedPeerConnectionRequestsAsync(new SubmittedPeerConnectionRequestQueryOptions<Guid, Guid> { Ids = newPeerConnectionRequestIds, IdsMatchMode = QueryOptionsMatchMode.Strict })).Data, countAdded);

                return new AddSuccessResult<List<DM.Peers.PeerConnectionRequestSubmitted>>(new List<DM.Peers.PeerConnectionRequestSubmitted>(), countAdded);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);

                throw new CannotCreateRecordsException(ex);
            }
        }

        /// <summary>
        /// Soft deletes Submitted Peer Connection Requests
        /// </summary>
        /// <param name="submittedPeerConnectionRequestsIds"></param>
        /// <param name="actioningUserId"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<IDeleteResult<List<Guid>>> DeleteSubmittedPeerConnectionRequestsAsync(IEnumerable<Guid> submittedPeerConnectionRequestsIds, Guid actioningUserId)
        {
            throw new NotImplementedException();
        }
    }
}
