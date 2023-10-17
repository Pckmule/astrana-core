/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.ContentCollections;
using Astrana.Core.Domain.Models.ContentCollections.Options;
using Astrana.Core.Domain.Models.Results.Contracts;

namespace Astrana.Core.Data.Repositories.ContentCollections
{
    public interface IContentCollectionRepository<TUserId> where TUserId : struct
    {
        Task<ICountResult> GetContentCollectionsCountAsync(ContentCollectionQueryOptions<Guid, TUserId>? queryOptions = null);

        Task<IGetResult<ContentCollection>> GetContentCollectionsAsync(ContentCollectionQueryOptions<Guid, TUserId>? queryOptions = null);

        Task<ContentCollection?> GetContentCollectionByIdAsync(Guid id);
        
        Task<IAddResult<List<ContentCollection>>> CreateAsync(IEnumerable<ContentCollection> newContentCollectionsToCreate, TUserId actioningUserId, bool returnRecords = true);

        Task<IUpdateResult<List<ContentCollection>>> UpdateAsync(IEnumerable<ContentCollection> requestedUpdates, TUserId actioningUserId, bool returnRecords = true);
        
        Task<IDeleteResult<List<Guid>>> DeleteAsync(IEnumerable<Guid> validatedContentCollectionsToRemoveIds, Guid actioningUserId);
    }
}
