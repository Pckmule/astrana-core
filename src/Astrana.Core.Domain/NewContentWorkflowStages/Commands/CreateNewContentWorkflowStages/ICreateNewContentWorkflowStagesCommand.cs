/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.NewContentWorkflowStages;
using Astrana.Core.Domain.Models.Results;

namespace Astrana.Core.Domain.NewContentWorkflowStages.Commands.CreateNewContentWorkflowStages
{
    public interface ICreateNewContentWorkflowStagesCommand
    {
        Task<AddResult<List<NewContentWorkflowStage>>> ExecuteAsync(IList<NewContentWorkflowStage> newContentWorkflowStagesToAdd, Guid actioningUserId);
    }
}
