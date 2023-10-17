/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Repositories.Links;
using Astrana.Core.Domain.Models.Links.Constants;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Enums;
using Astrana.Core.Domain.Models.System.Enums;
using Astrana.Core.Extensions;
using Microsoft.Extensions.Logging;
using MRB = Astrana.Core.Domain.ResultMessageBuilder;

namespace Astrana.Core.Domain.Links.Commands.DeleteLinks
{
    public class DeleteLinksCommand : IDeleteLinksCommand
    {
        private readonly ILogger<DeleteLinksCommand> _logger;
        private readonly ILinkRepository<Guid> _linkRepository;

        public DeleteLinksCommand(ILogger<DeleteLinksCommand> logger, ILinkRepository<Guid> linkRepository)
        {
            _logger = logger;
            _linkRepository = linkRepository;
        }

        public async Task<DeleteResult<List<Guid>>> ExecuteAsync(IList<Guid> linksToDeleteIds, Guid actioningUserId)
        {
            if (!linksToDeleteIds.Any())
            {
                var message = MRB.NoneProvidedMessage(CrudAction.Remove, ModelProperties.Link.NamePluralForm);

                _logger.LogWarning(message);

                return new DeleteFailResult<List<Guid>>(new List<Guid>(), 0, message);
            }

            var validatedLinksToRemoveIds = linksToDeleteIds.Where(o => o.IsValidForUpdateOrDelete()).ToList();
            if (!validatedLinksToRemoveIds.Any())
            {
                var message = MRB.NoneValidMessage(CrudAction.Remove, ModelProperties.Link.NamePluralForm);

                _logger.LogWarning(message);

                return new DeleteFailResult<List<Guid>>(new List<Guid>(), 0, message);
            }

            var result = await _linkRepository.DeleteAsync(validatedLinksToRemoveIds, actioningUserId);

            if (result.Outcome == ResultOutcome.Success)
                return new DeleteSuccessResult<List<Guid>>(result.Data, result.Count, MRB.DeleteSuccessResultMessage(ModelProperties.Link.NameSingularForm, ModelProperties.Link.NamePluralForm, result.Count));
            
            return new DeleteFailResult<List<Guid>>(result.Data, 0, result.Message, result.ResultCode);
        }
    }
}