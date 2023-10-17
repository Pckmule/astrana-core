/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Repositories.NewContentWorkflowStages;
using Astrana.Core.Domain.Models.NewContentWorkflowStages.Constants;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Enums;
using Astrana.Core.Domain.Models.System.Enums;
using Astrana.Core.Extensions;
using Microsoft.Extensions.Logging;
using MRB = Astrana.Core.Domain.ResultMessageBuilder;

namespace Astrana.Core.Domain.NewContentWorkflowStages.Commands.DeleteNewContentWorkflowStages
{
    public class DeleteNewContentWorkflowStagesCommand : IDeleteNewContentWorkflowStagesCommand
    {
        private readonly ILogger<DeleteNewContentWorkflowStagesCommand> _logger;
        private readonly INewContentWorkflowStageRepository<Guid> _newContentWorkflowStageRepository;

        public DeleteNewContentWorkflowStagesCommand(ILogger<DeleteNewContentWorkflowStagesCommand> logger, INewContentWorkflowStageRepository<Guid> newContentWorkflowStageRepository)
        {
            _logger = logger;
            _newContentWorkflowStageRepository = newContentWorkflowStageRepository;
        }

        public async Task<DeleteResult<List<Guid>>> ExecuteAsync(IList<Guid> newContentWorkflowStagesToDeleteIds, Guid actioningUserId)
        {
            if (!newContentWorkflowStagesToDeleteIds.Any())
            {
                var message = MRB.NoneProvidedMessage(CrudAction.Remove, ModelProperties.NewContentWorkflowStage.NamePluralForm);

                _logger.LogWarning(message);

                return new DeleteFailResult<List<Guid>>(new List<Guid>(), 0, message);
            }

            var validatedNewContentWorkflowStagesToRemoveIds = newContentWorkflowStagesToDeleteIds.Where(o => o.IsValidForUpdateOrDelete()).ToList();
            if (!validatedNewContentWorkflowStagesToRemoveIds.Any())
            {
                var message = MRB.NoneValidMessage(CrudAction.Remove, ModelProperties.NewContentWorkflowStage.NamePluralForm);

                _logger.LogWarning(message);

                return new DeleteFailResult<List<Guid>>(new List<Guid>(), 0, message);
            }

            var result = await _newContentWorkflowStageRepository.DeleteAsync(validatedNewContentWorkflowStagesToRemoveIds, actioningUserId);

            if (result.Outcome == ResultOutcome.Success)
                return new DeleteSuccessResult<List<Guid>>(result.Data, result.Count, MRB.DeleteSuccessResultMessage(ModelProperties.NewContentWorkflowStage.NameSingularForm, ModelProperties.NewContentWorkflowStage.NamePluralForm, result.Count));
            
            return new DeleteFailResult<List<Guid>>(result.Data, 0, result.Message, result.ResultCode);
        }
    }
}