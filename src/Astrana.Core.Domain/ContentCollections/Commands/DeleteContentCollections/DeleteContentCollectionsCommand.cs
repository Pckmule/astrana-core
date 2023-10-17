/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Repositories.ContentCollections;
using Astrana.Core.Domain.Models.ContentCollections.Constants;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Enums;
using Astrana.Core.Domain.Models.System.Enums;
using Astrana.Core.Extensions;
using Microsoft.Extensions.Logging;
using MRB = Astrana.Core.Domain.ResultMessageBuilder;

namespace Astrana.Core.Domain.ContentCollections.Commands.DeleteContentCollections
{
    public class DeleteContentCollectionsCommand : IDeleteContentCollectionsCommand
    {
        private readonly ILogger<DeleteContentCollectionsCommand> _logger;
        private readonly IContentCollectionRepository<Guid> _contentCollectionRepository;

        public DeleteContentCollectionsCommand(ILogger<DeleteContentCollectionsCommand> logger, IContentCollectionRepository<Guid> contentCollectionRepository)
        {
            _logger = logger;
            _contentCollectionRepository = contentCollectionRepository;
        }

        public async Task<DeleteResult<List<Guid>>> ExecuteAsync(IList<Guid> contentCollectionsToDeleteIds, Guid actioningUserId)
        {
            if (!contentCollectionsToDeleteIds.Any())
            {
                var message = MRB.NoneProvidedMessage(CrudAction.Remove, ModelProperties.ContentCollection.NamePluralForm);

                _logger.LogWarning(message);

                return new DeleteFailResult<List<Guid>>(new List<Guid>(), 0, message);
            }

            var validatedContentCollectionsToRemoveIds = contentCollectionsToDeleteIds.Where(o => o.IsValidForUpdateOrDelete()).ToList();
            if (!validatedContentCollectionsToRemoveIds.Any())
            {
                var message = MRB.NoneValidMessage(CrudAction.Remove, ModelProperties.ContentCollection.NamePluralForm);

                _logger.LogWarning(message);

                return new DeleteFailResult<List<Guid>>(new List<Guid>(), 0, message);
            }

            var result = await _contentCollectionRepository.DeleteAsync(validatedContentCollectionsToRemoveIds, actioningUserId);

            if (result.Outcome == ResultOutcome.Success)
                return new DeleteSuccessResult<List<Guid>>(result.Data, result.Count, MRB.DeleteSuccessResultMessage(ModelProperties.ContentCollection.NameSingularForm, ModelProperties.ContentCollection.NamePluralForm, result.Count));
            
            return new DeleteFailResult<List<Guid>>(result.Data, 0, result.Message, result.ResultCode);
        }
    }
}