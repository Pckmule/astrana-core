/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Repositories.ContentCollections;
using Astrana.Core.Domain.Models.ContentCollections;
using Astrana.Core.Domain.Models.ContentCollections.Constants;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Enums;
using Astrana.Core.Domain.Models.System.Enums;
using Microsoft.Extensions.Logging;
using MRB = Astrana.Core.Domain.ResultMessageBuilder;

namespace Astrana.Core.Domain.ContentCollections.Commands.UpdateContentCollections
{
    public class UpdateContentCollectionsCommand : IUpdateContentCollectionsCommand
    {
        private readonly ILogger<UpdateContentCollectionsCommand> _logger;
        private readonly IContentCollectionRepository<Guid> _contentCollectionRepository;

        public UpdateContentCollectionsCommand(ILogger<UpdateContentCollectionsCommand> logger, IContentCollectionRepository<Guid> contentCollectionRepository)
        {
            _logger = logger;
            _contentCollectionRepository = contentCollectionRepository;
        }

        public async Task<UpdateResult<List<ContentCollection>>> ExecuteAsync(IList<ContentCollection> contentCollectionsToUpdate, Guid actioningUserId)
        {
            if (!contentCollectionsToUpdate.Any())
            {
                var message = MRB.NoneProvidedMessage(CrudAction.Update, ModelProperties.ContentCollection.NamePluralForm);

                _logger.LogWarning(message);

                return new UpdateFailResult<List<ContentCollection>>(new List<ContentCollection>(), 0, message);
            }

            var validatedContentCollectionsToUpdate = contentCollectionsToUpdate.Where(o => o.IsValid).ToList();
            if (!validatedContentCollectionsToUpdate.Any())
            {
                var message = MRB.NoneValidMessage(CrudAction.Update, ModelProperties.ContentCollection.NamePluralForm);

                _logger.LogWarning(message);

                return new UpdateFailResult<List<ContentCollection>>(new List<ContentCollection>(), 0, message);
            }

            var result = await _contentCollectionRepository.UpdateAsync(validatedContentCollectionsToUpdate, actioningUserId);

            if (result.Outcome == ResultOutcome.Success)
                return new UpdateSuccessResult<List<ContentCollection>>(result.Data, result.Count, MRB.UpdateSuccessResultMessage(ModelProperties.ContentCollection.NameSingularForm, ModelProperties.ContentCollection.NamePluralForm, result.Count));
            
            return new UpdateFailResult<List<ContentCollection>>(result.Data, 0, result.Message, result.ResultCode);
        }
    }
}