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
    public class GetUserProfileDetailsQuery : IGetUserProfileDetailsQuery
    {
        private readonly ILogger<GetUserProfileDetailsQuery> _logger;
        private readonly IUserProfileRepository<Guid> _userProfileRepository;

        public GetUserProfileDetailsQuery(ILogger<GetUserProfileDetailsQuery> logger, IUserProfileRepository<Guid> userProfileRepository)
        {
            _logger = logger;
            _userProfileRepository = userProfileRepository;
        }

        public async Task<GetResult<UserProfileDetailQueryOptions<Guid, Guid>, UserProfileDetail, Guid, Guid>> ExecuteAsync(Guid actioningUserId, UserProfileDetailQueryOptions<Guid, Guid>? options = null)
        {
            options ??= new UserProfileDetailQueryOptions<Guid, Guid>();

            var result = await _userProfileRepository.GetUserProfileDetailsAsync(options);
            
            _logger.LogTrace($"Executed {nameof(GetUserProfileDetailsQuery).SplitOnUpperCase()}");

            return new GetResult<UserProfileDetailQueryOptions<Guid, Guid>, UserProfileDetail, Guid, Guid>(result.Data, options, result.ResultSetCount, result.Message);
        }
    }
}