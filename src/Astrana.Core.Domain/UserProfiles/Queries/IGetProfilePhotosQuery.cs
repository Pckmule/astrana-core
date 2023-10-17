/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Images;
using Astrana.Core.Domain.Models.Images.Options;
using Astrana.Core.Domain.Models.Results;

namespace Astrana.Core.Domain.UserProfiles.Queries
{
    public interface IGetProfilePhotosQuery
    {
        Task<GetResult<ImageQueryOptions<Guid, Guid>, Image, Guid, Guid>> ExecuteAsync(Guid actioningUserId, ImageQueryOptions<Guid, Guid> options = null);
    }
}