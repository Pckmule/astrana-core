/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.ContentCollections.Commands.CreateContentCollections;
using Astrana.Core.Domain.Models.Albums;
using Astrana.Core.Domain.Models.Albums.Constants;
using Astrana.Core.Domain.Models.Albums.DomainTransferObjects;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Enums;
using Microsoft.Extensions.Logging;
using MRB = Astrana.Core.Domain.ResultMessageBuilder;

namespace Astrana.Core.Domain.Albums.Commands.CreateAlbums
{
    public class CreateAlbumsCommand : ICreateAlbumsCommand
    {
        private readonly ILogger<CreateAlbumsCommand> _logger;
        private readonly ICreateContentCollectionsCommand _createContentCollectionsCommand;

        public CreateAlbumsCommand(ILogger<CreateAlbumsCommand> logger, ICreateContentCollectionsCommand createContentCollectionsCommand)
        {
            _logger = logger;
            _createContentCollectionsCommand = createContentCollectionsCommand;
        }

        public async Task<AddResult<List<Album>>> ExecuteAsync(IList<AddAlbumDto> albumsToAddDtos, Guid actioningUserId)
        {
            var result = await _createContentCollectionsCommand.ExecuteAsync(albumsToAddDtos.Select(ModelMappings.ToAddContentCollectionDto).ToList(), actioningUserId);
            
            if (result.Outcome == ResultOutcome.Success)
                return new AddSuccessResult<List<Album>>(result.Data.Select(ModelMappings.ToAlbum).ToList(), result.Count, MRB.CreateSuccessResultMessage(ModelProperties.Album.NameSingularForm, ModelProperties.Album.NamePluralForm, result.Count));

            return new AddFailResult<List<Album>>(result.Data.Select(ModelMappings.ToAlbum).ToList(), result.Count, result.Message, result.ResultCode);
        }
    }
}
