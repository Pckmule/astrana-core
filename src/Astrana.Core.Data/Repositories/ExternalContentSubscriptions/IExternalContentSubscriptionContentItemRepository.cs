/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.ExternalContent.ContentItems;
using Astrana.Core.Domain.Models.ExternalContent.ContentItems.Options;
using Astrana.Core.Domain.Models.Results.Contracts;

namespace Astrana.Core.Data.Repositories.ExternalContentSubscriptions
{
    public interface IExternalContentSubscriptionContentItemRepository<TUserId> where TUserId : struct
    {
        Task<ICountResult> GetExternalContentSubscriptionContentItemsCountAsync(ExternalContentSubscriptionContentItemQueryOptions<Guid, TUserId>? queryOptions = null);

        Task<IGetResult<ExternalContentSubscriptionContentItem>> GetExternalContentSubscriptionContentItemsAsync(ExternalContentSubscriptionContentItemQueryOptions<Guid, TUserId>? queryOptions = null);

        Task<ExternalContentSubscriptionContentItem?> GetExternalContentSubscriptionContentItemByIdAsync(Guid id);
        
        Task<IAddResult<List<ExternalContentSubscriptionContentItem>>> CreateAsync(IEnumerable<ExternalContentSubscriptionContentItem> requestedAdditions, TUserId actioningUserId, bool returnRecords = true);

        Task<IUpdateResult<List<ExternalContentSubscriptionContentItem>>> UpdateAsync(IEnumerable<ExternalContentSubscriptionContentItem> requestedUpdates, TUserId actioningUserId, bool returnRecords = true);
        
        Task<IDeleteResult<List<Guid>>> DeleteAsync(IEnumerable<Guid> validatedExternalContentSubscriptionContentItemsToRemoveIds, Guid actioningUserId);
    }
}
