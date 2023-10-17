﻿/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Results;

namespace Astrana.Core.Domain.UserProfiles.Commands.DeleteUserProfileDetails
{
    public interface IDeleteUserProfileDetailsCommand
    {
        Task<DeleteResult<List<Guid>>> ExecuteAsync(IList<Guid> userProfileDetailsToDeleteIds, Guid actioningUserId);
    }
}