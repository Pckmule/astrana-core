/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Results;

namespace Astrana.Core.Domain.Albums.Commands.DeleteAlbums
{
    public interface IDeleteAlbumsCommand
    {
        Task<DeleteResult<List<Guid>>> ExecuteAsync(IList<Guid> albumsToDeleteIds, Guid actioningUserId);
    }
}