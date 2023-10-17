/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Repositories.Audiences;
using Astrana.Core.Domain.Models.Audiences.Constants;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Enums;
using Astrana.Core.Domain.Models.System.Enums;
using Astrana.Core.Extensions;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.Domain.Audiences.Commands.DeleteAudiences
{
    public class DeleteAudiencesCommand : IDeleteAudiencesCommand
    {
        private readonly ILogger<DeleteAudiencesCommand> _logger;
        private readonly IAudienceRepository<Guid> _audienceRepository;

        public DeleteAudiencesCommand(ILogger<DeleteAudiencesCommand> logger, IAudienceRepository<Guid> audienceRepository)
        {
            _logger = logger;
            _audienceRepository = audienceRepository;
        }

        public async Task<DeleteResult<List<Guid>>> ExecuteAsync(IList<Guid> audiencesToDeleteIds, Guid actioningUserId)
        {
            if (!audiencesToDeleteIds.Any())
            {
                var message = ResultMessageBuilder.NoneProvidedMessage(CrudAction.Remove, ModelProperties.Audience.NamePluralForm);

                _logger.LogWarning(message);

                return new DeleteFailResult<List<Guid>>(new List<Guid>(), 0, message);
            }

            var validatedAudiencesToRemoveIds = audiencesToDeleteIds.Where(o => o.IsValidForUpdateOrDelete()).ToList();
            if (!validatedAudiencesToRemoveIds.Any())
            {
                var message = ResultMessageBuilder.NoneValidMessage(CrudAction.Remove, ModelProperties.Audience.NamePluralForm);

                _logger.LogWarning(message);

                return new DeleteFailResult<List<Guid>>(new List<Guid>(), 0, message);
            }

            var result = await _audienceRepository.DeleteAsync(validatedAudiencesToRemoveIds, actioningUserId);

            if (result.Outcome == ResultOutcome.Success)
                return new DeleteSuccessResult<List<Guid>>(result.Data, result.Count, ResultMessageBuilder.DeleteSuccessResultMessage(ModelProperties.Audience.NameSingularForm, ModelProperties.Audience.NamePluralForm, result.Count));

            return new DeleteFailResult<List<Guid>>(result.Data, 0, result.Message, result.ResultCode);
        }
    }
}