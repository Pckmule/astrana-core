/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.UserProfiles;
using Astrana.Core.Domain.Models.UserProfiles.Options;

namespace Astrana.Core.Domain.UserProfiles.Queries
{
    public interface IGetUserProfileQuery
    {
        Task<GetResult<UserProfileQueryOptions<Guid, Guid>, UserProfile, Guid, Guid>> ExecuteAsync(Guid actioningUserId, UserProfileQueryOptions<Guid, Guid> queryOptions);
    }
}