/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Repositories.Audiences;
using Astrana.Core.Domain.Images.Commands.SaveRemoteImage;
using Astrana.Core.Domain.Models.Audiences;
using Astrana.Core.Domain.Models.Audiences.Constants;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Enums;
using Astrana.Core.Domain.Models.System.Enums;
using Microsoft.Extensions.Logging;
using MRB = Astrana.Core.Domain.ResultMessageBuilder;

namespace Astrana.Core.Domain.Audiences.Commands.CreateAudiences
{
    public class CreateAudiencesCommand : ICreateAudiencesCommand
    {
        private readonly ILogger<CreateAudiencesCommand> _logger;

        private readonly IAudienceRepository<Guid> _audienceRepository;
        private readonly ISaveRemoteImageCommand _saveRemoteImageCommand;

        public CreateAudiencesCommand(ILogger<CreateAudiencesCommand> logger, IAudienceRepository<Guid> audienceRepository, ISaveRemoteImageCommand saveRemoteImageCommand)
        {
            _logger = logger;

            _audienceRepository = audienceRepository;
            _saveRemoteImageCommand = saveRemoteImageCommand;
        }

        public async Task<AddResult<List<Audience>>> ExecuteAsync(IList<AudienceToAdd> audiencesToAdd, Guid actioningUserId)
        {
            if (!audiencesToAdd.Any())
            {
                var message = MRB.NoneProvidedMessage(CrudAction.Add, ModelProperties.Audience.NamePluralForm);

                _logger.LogWarning(message);

                return new AddFailResult<List<Audience>>(new List<Audience>(), 0, message);
            }

            var validatedAudiencesToAdd = audiencesToAdd.Where(o => o.IsValid).ToList();
            if (!validatedAudiencesToAdd.Any())
            {
                var message = MRB.NoneValidMessage(CrudAction.Add, ModelProperties.Audience.NamePluralForm);

                _logger.LogWarning(message);

                return new AddFailResult<List<Audience>>(new List<Audience>(), 0, message);
            }

            var result = await _audienceRepository.CreateAsync(validatedAudiencesToAdd, actioningUserId);

            if (result.Outcome == ResultOutcome.Success)
                return new AddSuccessResult<List<Audience>>(result.Data, result.Count, MRB.CreateSuccessResultMessage(ModelProperties.Audience.NameSingularForm, ModelProperties.Audience.NamePluralForm, result.Count));
            
            return new AddFailResult<List<Audience>>(result.Data, result.Count, result.Message, result.ResultCode);
        }
    }
}
