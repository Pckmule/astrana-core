/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.UserProfiles;

namespace Astrana.Core.Domain.UserProfiles.Commands.UpdateUserProfileIntroduction
{
    public interface IUpdateUserProfileIntroductionCommand
    {
        Task<UpdateResult<UserProfile>> ExecuteAsync(Guid userProfileId, string updatedUserProfileIntroduction, Guid actioningUserId);
    }
}