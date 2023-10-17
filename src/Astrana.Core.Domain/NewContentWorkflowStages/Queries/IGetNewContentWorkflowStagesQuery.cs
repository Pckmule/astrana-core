/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.NewContentWorkflowStages;
using Astrana.Core.Domain.Models.NewContentWorkflowStages.Options;
using Astrana.Core.Domain.Models.Results;

namespace Astrana.Core.Domain.NewContentWorkflowStages.Queries
{
    public interface IGetNewContentWorkflowStagesQuery
    {
        Task<GetResult<NewContentWorkflowStageQueryOptions<Guid, Guid>, NewContentWorkflowStage, Guid, Guid>> ExecuteAsync(Guid actioningUserId, NewContentWorkflowStageQueryOptions<Guid, Guid> options = null);
    }
}