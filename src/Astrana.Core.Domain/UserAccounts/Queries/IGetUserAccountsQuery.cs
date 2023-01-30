/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.UserAccounts;
using Astrana.Core.Domain.Models.UserAccounts.Options;

namespace Astrana.Core.Domain.UserAccounts.Queries
{
    public interface IGetUserAccountsQuery
    {
        Task<GetResult<UserAccountQueryOptions<Guid, Guid>, UserAccount, Guid, Guid>> ExecuteAsync(Guid actioningUserId, UserAccountQueryOptions<Guid, Guid> queryOptions);
    }
}