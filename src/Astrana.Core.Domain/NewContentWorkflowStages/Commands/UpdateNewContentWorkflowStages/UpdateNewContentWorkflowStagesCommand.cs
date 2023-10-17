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

namespace Astrana.Core.Domain.NewContentWorkflowStages.Commands.UpdateNewContentWorkflowStages
{
    public class UpdateNewContentWorkflowStagesCommand : IUpdateNewContentWorkflowStagesCommand
    {
        private readonly ILogger<UpdateNewContentWorkflowStagesCommand> _logger;
        private readonly INewContentWorkflowStageRepository<Guid> _newContentWorkflowStageRepository;

        public UpdateNewContentWorkflowStagesCommand(ILogger<UpdateNewContentWorkflowStagesCommand> logger, INewContentWorkflowStageRepository<Guid> newContentWorkflowStageRepository)
        {
            _logger = logger;
            _newContentWorkflowStageRepository = newContentWorkflowStageRepository;
        }

        public async Task<UpdateResult<List<NewContentWorkflowStage>>> ExecuteAsync(IList<NewContentWorkflowStage> newContentWorkflowStagesToUpdate, Guid actioningUserId)
        {
            if (!newContentWorkflowStagesToUpdate.Any())
            {
                var message = MRB.NoneProvidedMessage(CrudAction.Update, ModelProperties.NewContentWorkflowStage.NamePluralForm);

                _logger.LogWarning(message);

                return new UpdateFailResult<List<NewContentWorkflowStage>>(new List<NewContentWorkflowStage>(), 0, message);
            }

            var validatedNewContentWorkflowStagesToUpdate = newContentWorkflowStagesToUpdate.Where(o => o.IsValid).ToList();
            if (!validatedNewContentWorkflowStagesToUpdate.Any())
            {
                var message = MRB.NoneValidMessage(CrudAction.Update, ModelProperties.NewContentWorkflowStage.NamePluralForm);

                _logger.LogWarning(message);

                return new UpdateFailResult<List<NewContentWorkflowStage>>(new List<NewContentWorkflowStage>(), 0, message);
            }

            var result = await _newContentWorkflowStageRepository.UpdateAsync(validatedNewContentWorkflowStagesToUpdate, actioningUserId);

            if (result.Outcome == ResultOutcome.Success)
                return new UpdateSuccessResult<List<NewContentWorkflowStage>>(result.Data, result.Count, MRB.UpdateSuccessResultMessage(ModelProperties.NewContentWorkflowStage.NameSingularForm, ModelProperties.NewContentWorkflowStage.NamePluralForm, result.Count));
            
            return new UpdateFailResult<List<NewContentWorkflowStage>>(result.Data, 0, result.Message, result.ResultCode);
        }
    }
}