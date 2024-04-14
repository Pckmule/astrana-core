/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.ExternalContent.Subscriptions;
using Astrana.Core.Domain.Models.ExternalContent.Subscriptions.Options;
using Astrana.Core.Domain.Models.Results.Contracts;

namespace Astrana.Core.Data.Repositories.ExternalContentSubscriptions
{
    public interface IExternalContentSubscriptionRepository<TUserId> where TUserId : struct
    {
        Task<ICountResult> GetExternalContentSubscriptionsCountAsync(ExternalContentSubscriptionQueryOptions<Guid, TUserId>? queryOptions = null);

        Task<IGetResult<ExternalContentSubscription>> GetExternalContentSubscriptionsAsync(ExternalContentSubscriptionQueryOptions<Guid, TUserId>? queryOptions = null);

        Task<ExternalContentSubscription?> GetExternalContentSubscriptionByIdAsync(Guid id);
        
        Task<IAddResult<List<ExternalContentSubscription>>> CreateAsync(IEnumerable<ExternalContentSubscription> requestedAdditions, TUserId actioningUserId, bool returnRecords = true);

        Task<IUpdateResult<List<ExternalContentSubscription>>> UpdateAsync(IEnumerable<ExternalContentSubscription> requestedUpdates, TUserId actioningUserId, bool returnRecords = true);
        
        Task<IDeleteResult<List<Guid>>> DeleteAsync(IEnumerable<Guid> validatedExternalContentSubscriptionsToRemoveIds, Guid actioningUserId);
    }
}
