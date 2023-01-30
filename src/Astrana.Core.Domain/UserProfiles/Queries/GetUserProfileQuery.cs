/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Repositories.UserProfiles;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.UserProfiles;
using Astrana.Core.Domain.Models.UserProfiles.Options;
using Astrana.Core.Utilities;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.Domain.UserProfiles.Queries
{
    public class GetUserProfileQuery : IGetUserProfileQuery
    {
        private readonly ILogger<GetUserProfileQuery> _logger;
        private readonly IUserProfileRepository<Guid> _userProfileRepository;

        public GetUserProfileQuery(ILogger<GetUserProfileQuery> logger, IUserProfileRepository<Guid> userProfileRepository)
        {
            _logger = logger;
            _userProfileRepository = userProfileRepository;
        }

        public async Task<GetResult<UserProfileQueryOptions<Guid, Guid>, UserProfile, Guid, Guid>> ExecuteAsync(Guid actioningUserId, UserProfileQueryOptions<Guid, Guid> queryOptions)
        {
            var result = await _userProfileRepository.GetUserProfilesAsync(queryOptions);
            
            _logger.LogTrace($"Executed {nameof(GetUserProfileQuery).SplitOnUpperCase()}");

            return new GetResult<UserProfileQueryOptions<Guid, Guid>, UserProfile, Guid, Guid>(result.Data, queryOptions, result.ResultSetCount, result.Message);
        }
    }
}