/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Albums;
using Astrana.Core.Domain.Models.Results;

namespace Astrana.Core.Domain.Albums.Commands.UpdateAlbums
{
    public interface IUpdateAlbumsCommand
    {
        Task<UpdateResult<List<Album>>> ExecuteAsync(IList<Album> albumsToUpdate, Guid actioningUserId);
    }
}