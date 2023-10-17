/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.ExternalContentSubscriptions;
using Astrana.Core.Domain.Models.Results;

namespace Astrana.Core.Domain.ExternalContentSubscriptions.Commands.UpdateExternalSubscriptions
{
    public interface IUpdateExternalSubscriptionsCommand
    {
        Task<UpdateResult<List<ExternalSubscription>>> ExecuteAsync(IList<ExternalSubscription> linksToUpdate, Guid actioningUserId);
    }
}