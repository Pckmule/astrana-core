/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Repositories.ContentCollections;
using Astrana.Core.Domain.Models.ContentCollections;
using Astrana.Core.Domain.Models.ContentCollections.Constants;
using Astrana.Core.Domain.Models.ContentCollections.DomainTransferObjects;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Enums;
using Astrana.Core.Domain.Models.System.Enums;
using Microsoft.Extensions.Logging;
using MRB = Astrana.Core.Domain.ResultMessageBuilder;

namespace Astrana.Core.Domain.ContentCollections.Commands.CreateContentCollections
{
    public class CreateContentCollectionsCommand : ICreateContentCollectionsCommand
    {
        private readonly ILogger<CreateContentCollectionsCommand> _logger;
        private readonly IContentCollectionRepository<Guid> _contentCollectionRepository;

        public CreateContentCollectionsCommand(ILogger<CreateContentCollectionsCommand> logger, IContentCollectionRepository<Guid> contentCollectionRepository)
        {
            _logger = logger;
            _contentCollectionRepository = contentCollectionRepository;
        }

        public async Task<AddResult<List<ContentCollection>>> ExecuteAsync(IList<AddContentCollectionDto> contentCollectionsToAddDtos, Guid actioningUserId)
        {
            if (!contentCollectionsToAddDtos.Any())
            {
                var message = MRB.NoneProvidedMessage(CrudAction.Add, ModelProperties.ContentCollection.NamePluralForm);

                _logger.LogWarning(message);

                return new AddFailResult<List<ContentCollection>>(new List<ContentCollection>(), 0, message);
            }

            var contentCollectionsToAdd = contentCollectionsToAddDtos.Select(o => new ContentCollection(o)).ToList();

            var validatedContentCollectionsToAdd = contentCollectionsToAdd.Where(o => o.IsValid).ToList();
            if (!validatedContentCollectionsToAdd.Any())
            {
                var message = MRB.NoneValidMessage(CrudAction.Add, ModelProperties.ContentCollection.NamePluralForm);

                _logger.LogWarning(message);

                return new AddFailResult<List<ContentCollection>>(new List<ContentCollection>(), 0, message);
            }

            var result = await _contentCollectionRepository.CreateAsync(validatedContentCollectionsToAdd, actioningUserId);

            if (result.Outcome == ResultOutcome.Success)
                return new AddSuccessResult<List<ContentCollection>>(result.Data, result.Count, MRB.CreateSuccessResultMessage(ModelProperties.ContentCollection.NameSingularForm, ModelProperties.ContentCollection.NamePluralForm, result.Count));

            return new AddFailResult<List<ContentCollection>>(result.Data, result.Count, result.Message, result.ResultCode);
        }
    }
}
