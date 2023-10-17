/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Repositories.Audiences;
using Astrana.Core.Domain.Models.Audiences;
using Astrana.Core.Domain.Models.Audiences.Constants;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Enums;
using Astrana.Core.Domain.Models.System.Enums;
using Microsoft.Extensions.Logging;
using MRB = Astrana.Core.Domain.ResultMessageBuilder;

namespace Astrana.Core.Domain.Audiences.Commands.UpdateAudiences
{
    public class UpdateAudiencesCommand : IUpdateAudiencesCommand
    {
        private readonly ILogger<UpdateAudiencesCommand> _logger;
        private readonly IAudienceRepository<Guid> _audienceRepository;

        public UpdateAudiencesCommand(ILogger<UpdateAudiencesCommand> logger, IAudienceRepository<Guid> audienceRepository)
        {
            _logger = logger;
            _audienceRepository = audienceRepository;
        }

        public async Task<UpdateResult<List<Audience>>> ExecuteAsync(IList<Audience> audiencesToUpdate, Guid actioningUserId)
        {
            if (!audiencesToUpdate.Any())
            {
                var message = MRB.NoneProvidedMessage(CrudAction.Update, ModelProperties.Audience.NamePluralForm);

                _logger.LogWarning(message);

                return new UpdateFailResult<List<Audience>>(new List<Audience>(), 0, message);
            }

            var validatedAudiencesToUpdate = audiencesToUpdate.Where(o => o.IsValid).ToList();
            if (!validatedAudiencesToUpdate.Any())
            {
                var message = MRB.NoneValidMessage(CrudAction.Update, ModelProperties.Audience.NamePluralForm);

                _logger.LogWarning(message);

                return new UpdateFailResult<List<Audience>>(new List<Audience>(), 0, message);
            }

            var result = await _audienceRepository.UpdateAsync(validatedAudiencesToUpdate, actioningUserId);

            if (result.Outcome == ResultOutcome.Success)
                return new UpdateSuccessResult<List<Audience>>(result.Data, result.Count, MRB.UpdateSuccessResultMessage(ModelProperties.Audience.NameSingularForm, ModelProperties.Audience.NamePluralForm, result.Count));
            
            return new UpdateFailResult<List<Audience>>(result.Data, 0, result.Message, result.ResultCode);
        }
    }
}