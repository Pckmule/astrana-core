/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.ExternalContentSubscriptions;
using Astrana.Core.Domain.Models.ExternalContentSubscriptions.Contracts;
using Astrana.Core.Domain.Models.ExternalContentSubscriptions.Options;
using Astrana.Core.Domain.Models.Results.Contracts;

namespace Astrana.Core.Data.Repositories.ExternalContentSubscriptions
{
    public interface IExternalContentSubscriptionRepository<TUserId> where TUserId : struct
    {
        Task<ICountResult> GetExternalContentSubscriptionsCountAsync(ExternalContentSubscriptionQueryOptions<Guid, TUserId>? queryOptions = null);

        Task<IGetResult<ExternalSubscription>> GetExternalContentSubscriptionsAsync(ExternalContentSubscriptionQueryOptions<Guid, TUserId>? queryOptions = null);

        Task<ExternalSubscription?> GetExternalContentSubscriptionByIdAsync(Guid id);
        
        Task<IAddResult<List<ExternalSubscription>>> CreateAsync(IEnumerable<IExternalSubscriptionToAdd> requestedAdditions, TUserId actioningUserId, bool returnRecords = true);

        Task<IUpdateResult<List<ExternalSubscription>>> UpdateAsync(IEnumerable<IExternalSubscription> requestedUpdates, TUserId actioningUserId, bool returnRecords = true);
        
        Task<IDeleteResult<List<Guid>>> DeleteAsync(IEnumerable<Guid> validatedExternalContentSubscriptionsToRemoveIds, Guid actioningUserId);
    }
}
