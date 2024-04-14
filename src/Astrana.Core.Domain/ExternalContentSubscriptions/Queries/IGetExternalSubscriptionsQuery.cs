/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.ExternalContent.Subscriptions;
using Astrana.Core.Domain.Models.ExternalContent.Subscriptions.Options;
using Astrana.Core.Domain.Models.Results;

namespace Astrana.Core.Domain.ExternalContentSubscriptions.Queries
{
    public interface IGetExternalSubscriptionsQuery
    {
        Task<GetResult<ExternalContentSubscriptionQueryOptions<Guid, Guid>, ExternalContentSubscription, Guid, Guid>> ExecuteAsync(Guid actioningUserId, ExternalContentSubscriptionQueryOptions<Guid, Guid> options = null);
    }
}