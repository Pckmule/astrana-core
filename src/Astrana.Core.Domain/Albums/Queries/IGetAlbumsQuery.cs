/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Albums;
using Astrana.Core.Domain.Models.Albums.Options;
using Astrana.Core.Domain.Models.Results;

namespace Astrana.Core.Domain.Albums.Queries
{
    public interface IGetAlbumsQuery
    {
        Task<GetResult<AlbumQueryOptions<Guid, Guid>, Album, Guid, Guid>> ExecuteAsync(Guid actioningUserId, AlbumQueryOptions<Guid, Guid> options = null);
    }
}