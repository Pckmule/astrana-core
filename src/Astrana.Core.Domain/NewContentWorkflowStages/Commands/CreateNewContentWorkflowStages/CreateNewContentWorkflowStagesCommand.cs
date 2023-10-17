/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Repositories.NewContentWorkflowStages;
using Astrana.Core.Domain.Models.NewContentWorkflowStages;
using Astrana.Core.Domain.Models.NewContentWorkflowStages.Constants;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Enums;
using Astrana.Core.Domain.Models.System.Enums;
using Microsoft.Extensions.Logging;
using MRB = Astrana.Core.Domain.ResultMessageBuilder;

namespace Astrana.Core.Domain.NewContentWorkflowStages.Commands.CreateNewContentWorkflowStages
{
    public class CreateNewContentWorkflowStagesCommand : ICreateNewContentWorkflowStagesCommand
    {
        private readonly ILogger<CreateNewContentWorkflowStagesCommand> _logger;

        private readonly INewContentWorkflowStageRepository<Guid> _newContentWorkflowStageRepository;

        public CreateNewContentWorkflowStagesCommand(ILogger<CreateNewContentWorkflowStagesCommand> logger, INewContentWorkflowStageRepository<Guid> newContentWorkflowStageRepository)
        {
            _logger = logger;

            _newContentWorkflowStageRepository = newContentWorkflowStageRepository;
        }

        public async Task<AddResult<List<NewContentWorkflowStage>>> ExecuteAsync(IList<NewContentWorkflowStage> newContentWorkflowStagesToAdd, Guid actioningUserId)
        {
            if (!newContentWorkflowStagesToAdd.Any())
            {
                var message = MRB.NoneProvidedMessage(CrudAction.Add, ModelProperties.NewContentWorkflowStage.NamePluralForm);

                _logger.LogWarning(message);

                return new AddFailResult<List<NewContentWorkflowStage>>(new List<NewContentWorkflowStage>(), 0, message);
            }

            var validatedNewContentWorkflowStagesToAdd = newContentWorkflowStagesToAdd.Where(o => o.IsValid).ToList();
            if (!validatedNewContentWorkflowStagesToAdd.Any())
            {
                var message = MRB.NoneValidMessage(CrudAction.Add, ModelProperties.NewContentWorkflowStage.NamePluralForm);

                _logger.LogWarning(message);

                return new AddFailResult<List<NewContentWorkflowStage>>(new List<NewContentWorkflowStage>(), 0, message);
            }

            var result = await _newContentWorkflowStageRepository.CreateAsync(validatedNewContentWorkflowStagesToAdd, actioningUserId);

            if (result.Outcome == ResultOutcome.Success)
                return new AddSuccessResult<List<NewContentWorkflowStage>>(result.Data, result.Count, MRB.CreateSuccessResultMessage(ModelProperties.NewContentWorkflowStage.NameSingularForm, ModelProperties.NewContentWorkflowStage.NamePluralForm, result.Count));
            
            return new AddFailResult<List<NewContentWorkflowStage>>(result.Data, result.Count, result.Message, result.ResultCode);
        }
    }
}
