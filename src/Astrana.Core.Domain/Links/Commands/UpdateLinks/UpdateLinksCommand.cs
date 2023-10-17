/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Repositories.Links;
using Astrana.Core.Domain.Models.Links;
using Astrana.Core.Domain.Models.Links.Constants;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Enums;
using Astrana.Core.Domain.Models.System.Enums;
using Microsoft.Extensions.Logging;
using MRB = Astrana.Core.Domain.ResultMessageBuilder;

namespace Astrana.Core.Domain.Links.Commands.UpdateLinks
{
    public class UpdateLinksCommand : IUpdateLinksCommand
    {
        private readonly ILogger<UpdateLinksCommand> _logger;
        private readonly ILinkRepository<Guid> _linkRepository;

        public UpdateLinksCommand(ILogger<UpdateLinksCommand> logger, ILinkRepository<Guid> linkRepository)
        {
            _logger = logger;
            _linkRepository = linkRepository;
        }

        public async Task<UpdateResult<List<Link>>> ExecuteAsync(IList<Link> linksToUpdate, Guid actioningUserId)
        {
            if (!linksToUpdate.Any())
            {
                var message = MRB.NoneProvidedMessage(CrudAction.Update, ModelProperties.Link.NamePluralForm);

                _logger.LogWarning(message);

                return new UpdateFailResult<List<Link>>(new List<Link>(), 0, message);
            }

            var validatedLinksToUpdate = linksToUpdate.Where(o => o.IsValid).ToList();
            if (!validatedLinksToUpdate.Any())
            {
                var message = MRB.NoneValidMessage(CrudAction.Update, ModelProperties.Link.NamePluralForm);

                _logger.LogWarning(message);

                return new UpdateFailResult<List<Link>>(new List<Link>(), 0, message);
            }

            var result = await _linkRepository.UpdateAsync(validatedLinksToUpdate, actioningUserId);

            if (result.Outcome == ResultOutcome.Success)
                return new UpdateSuccessResult<List<Link>>(result.Data, result.Count, MRB.UpdateSuccessResultMessage(ModelProperties.Link.NameSingularForm, ModelProperties.Link.NamePluralForm, result.Count));
            
            return new UpdateFailResult<List<Link>>(result.Data, 0, result.Message, result.ResultCode);
        }
    }
}