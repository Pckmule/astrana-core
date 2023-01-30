/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Repositories.UserAccounts;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.UserAccounts;
using Astrana.Core.Domain.Models.UserAccounts.Options;
using Astrana.Core.Utilities;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.Domain.UserAccounts.Queries
{
    public class GetUserAccountsQuery : IGetUserAccountsQuery
    {
        private readonly ILogger<GetUserAccountsQuery> _logger;
        private readonly IUserAccountRepository<Guid> _userAccountRepository;

        public GetUserAccountsQuery(ILogger<GetUserAccountsQuery> logger, IUserAccountRepository<Guid> userAccountRepository)
        {
            _logger = logger;
            _userAccountRepository = userAccountRepository;
        }

        public async Task<GetResult<UserAccountQueryOptions<Guid, Guid>, UserAccount, Guid, Guid>> ExecuteAsync(Guid actioningUserId, UserAccountQueryOptions<Guid, Guid> queryOptions)
        {
            var result = await _userAccountRepository.GetUserAccountsAsync(queryOptions);
            
            _logger.LogTrace($"Executed {nameof(GetUserAccountsQuery).SplitOnUpperCase()}");

            return new GetResult<UserAccountQueryOptions<Guid, Guid>, UserAccount, Guid, Guid>(result.Data, queryOptions, result.ResultSetCount, result.Message);
        }
    }
}