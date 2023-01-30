/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.ApiAccessTokens;
using Astrana.Core.Domain.Models.ApiAccessTokens.Contracts;
using Astrana.Core.Domain.Models.ApiAccessTokens.Options;
using Astrana.Core.Domain.Models.Results.Contracts;

namespace Astrana.Core.Data.Repositories.ApiAccessTokens
{
    public interface IApiAccessTokenRepository<TUserId> where TUserId : struct
    {
        Task<ICountResult> GetCountAsync(ApiAccessTokenQueryOptions<Guid, TUserId>? queryOptions = null);

        Task<IGetResult<ApiAccessToken>> GetAsync(ApiAccessTokenQueryOptions<Guid, TUserId>? queryOptions = null);

        Task<ApiAccessToken> GetByIdAsync(Guid recordId);

        Task<IAddResult<List<ApiAccessToken>>> CreateAsync(IEnumerable<IApiAccessTokenToAdd> requestedAdditions, TUserId actioningUserId, bool returnRecords = true);

        Task<IDeleteResult<List<Guid>>> DeleteAsync(IEnumerable<Guid> validatedApiAccessTokensToRemoveIds, Guid actioningUserId);
    }
}
