/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.ContentCollections.Commands.UpdateContentCollections;
using Astrana.Core.Domain.Models.Albums;
using Astrana.Core.Domain.Models.Albums.Constants;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Enums;
using Microsoft.Extensions.Logging;
using MRB = Astrana.Core.Domain.ResultMessageBuilder;

namespace Astrana.Core.Domain.Albums.Commands.UpdateAlbums
{
    public class UpdateAlbumsCommand : IUpdateAlbumsCommand
    {
        private readonly ILogger<UpdateAlbumsCommand> _logger;
        private readonly IUpdateContentCollectionsCommand _updateContentCollectionsCommand;

        public UpdateAlbumsCommand(ILogger<UpdateAlbumsCommand> logger, IUpdateContentCollectionsCommand updateContentCollectionsCommand)
        {
            _logger = logger;
            _updateContentCollectionsCommand = updateContentCollectionsCommand;
        }

        public async Task<UpdateResult<List<Album>>> ExecuteAsync(IList<Album> albumsToUpdate, Guid actioningUserId)
        {
            var result = await _updateContentCollectionsCommand.ExecuteAsync(albumsToUpdate.Select(ModelMappings.ToContentCollection).ToList(), actioningUserId);

            if (result.Outcome == ResultOutcome.Success)
                return new UpdateSuccessResult<List<Album>>(result.Data.Select(ModelMappings.ToAlbum).ToList(), result.Count, MRB.CreateSuccessResultMessage(ModelProperties.Album.NameSingularForm, ModelProperties.Album.NamePluralForm, result.Count));

            return new UpdateFailResult<List<Album>>(result.Data.Select(ModelMappings.ToAlbum).ToList(), result.Count, result.Message, result.ResultCode);
        }
    }
}