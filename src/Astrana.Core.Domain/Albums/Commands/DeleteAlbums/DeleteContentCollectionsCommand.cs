/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.ContentCollections.Commands.DeleteContentCollections;
using Astrana.Core.Domain.Models.Results;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.Domain.Albums.Commands.DeleteAlbums
{
    public class DeleteAlbumsCommand : IDeleteAlbumsCommand
    {
        private readonly ILogger<DeleteAlbumsCommand> _logger;
        private readonly IDeleteContentCollectionsCommand _deleteContentCollections;

        public DeleteAlbumsCommand(ILogger<DeleteAlbumsCommand> logger, IDeleteContentCollectionsCommand deleteContentCollections)
        {
            _logger = logger;
            _deleteContentCollections = deleteContentCollections;
        }

        public async Task<DeleteResult<List<Guid>>> ExecuteAsync(IList<Guid> albumsToDeleteIds, Guid actioningUserId)
        {
            return await _deleteContentCollections.ExecuteAsync(albumsToDeleteIds, actioningUserId);
        }
    }
}