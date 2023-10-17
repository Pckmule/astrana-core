/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Contracts;
using Astrana.Core.Domain.Models.Options;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Exceptions;
using Astrana.Core.Utilities;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.Data.Repositories
{
    public abstract class BaseRepository<TRepository, TUserId> : IDisposable
        where TRepository : class
        where TUserId : struct
    {
        private bool _isDisposed;

        protected readonly ILogger<TRepository> logger;

        public ModelMapper.ModelMapper ModelMapper = new(new ModelMappings().Mappings);

        // protected readonly DataSourceSettings settings;
        protected readonly ApplicationDbContext databaseSession;

        public const string MessageRetrievedEntity = "Retrieved {0}.";
        public const string MessageSuccessfullyCreatedEntity = "Successfully created {0} new {1}.";
        public const string MessageSuccessfullyUpdatedEntity = "Successfully updated {0} new {1}.";
        public const string MessageSuccessfullyDeletedEntity = "Successfully deleted {0} new {1}.";

        protected BaseRepository(ILogger<TRepository> repositoryLogger, ApplicationDbContext context)
        {
            logger = repositoryLogger;
            databaseSession = context;
        }

        protected string GetEnvironmentPrefix()
        {
            return EnvironmentUtility.GetEnvironmentShortName();
        }

        public void ValidateActioningUserId(TUserId actioningUserId)
        {
            if (typeof(TUserId) != typeof(Guid)) 
                return;

            if (actioningUserId.ToString() == Guid.Empty.ToString())
                throw new InvalidUserException();
        }

        private static void SetAuditMetadataForEntity(IAuditableEntity<Guid> auditableEntity, Guid actioningUserId, DateTime? timestamp = null, bool createAndModified = true)
        {
            timestamp ??= DateTime.UtcNow;

            if (createAndModified)
            {
                auditableEntity.CreatedBy = actioningUserId;
                auditableEntity.CreatedTimestamp = timestamp.Value;
            }

            auditableEntity.LastModifiedBy = actioningUserId;
            auditableEntity.LastModifiedTimestamp = timestamp.Value;
        }

        protected void SetAuditMetadataForCreate(IAuditableEntity<Guid> auditableEntity, Guid actioningUserId, DateTime? timestamp = null)
        {
            SetAuditMetadataForEntity(auditableEntity, actioningUserId, timestamp);
        }

        protected void SetAuditMetadataForModify(ref IAuditableEntity<Guid> auditableEntity, Guid actioningUserId, DateTime? timestamp = null)
        {
            SetAuditMetadataForEntity(auditableEntity, actioningUserId, timestamp, false);
        }

        protected GetResult<QueryOptions<TRecordId, TOwnerUserId>, TData, TRecordId, TOwnerUserId> CreateGetResultWithPagination<TData, TRecordId, TOwnerUserId>(List<TData> data, QueryOptions<TRecordId, TOwnerUserId> queryOptions, int resultSetCount, string? message = null)
            where TRecordId : struct
            where TOwnerUserId : struct
        {
            return new GetResult<QueryOptions<TRecordId, TOwnerUserId>, TData, TRecordId, TOwnerUserId>(data, queryOptions, resultSetCount, message);
        }

        protected virtual void Dispose(bool disposing)
        {
            logger.LogTrace($"Disposing { typeof(TRepository).Name}");

            if (_isDisposed)
                return;

            if (disposing)
                databaseSession.Dispose();

            _isDisposed = true;

            logger.LogTrace($"Disposed {typeof(TRepository).Name}");
        }

        ~BaseRepository()
        {
            logger.LogTrace($"Destructing {typeof(TRepository).Name}");

            Dispose(false);

            logger.LogTrace($"Destructed {typeof(TRepository).Name}");
        }

        public virtual void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
