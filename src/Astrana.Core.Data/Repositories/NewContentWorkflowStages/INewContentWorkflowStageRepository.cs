/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.NewContentWorkflowStages;
using Astrana.Core.Domain.Models.NewContentWorkflowStages.Contracts;
using Astrana.Core.Domain.Models.NewContentWorkflowStages.Options;
using Astrana.Core.Domain.Models.Results.Contracts;

namespace Astrana.Core.Data.Repositories.NewContentWorkflowStages
{
    public interface INewContentWorkflowStageRepository<TUserId> where TUserId : struct
    {
        Task<ICountResult> GetNewContentWorkflowStagesCountAsync(NewContentWorkflowStageQueryOptions<Guid, TUserId>? queryOptions = null);

        Task<IGetResult<NewContentWorkflowStage>> GetNewContentWorkflowStagesAsync(NewContentWorkflowStageQueryOptions<Guid, TUserId>? queryOptions = null);

        Task<NewContentWorkflowStage?> GetNewContentWorkflowStageByIdAsync(Guid id);
        
        Task<IAddResult<List<NewContentWorkflowStage>>> CreateAsync(IEnumerable<NewContentWorkflowStage> requestedAdditions, TUserId actioningUserId, bool returnRecords = true);

        Task<IUpdateResult<List<NewContentWorkflowStage>>> UpdateAsync(IEnumerable<INewContentWorkflowStage> requestedUpdates, TUserId actioningUserId, bool returnRecords = true);
        
        Task<IDeleteResult<List<Guid>>> DeleteAsync(IEnumerable<Guid> validatedNewContentWorkflowStagesToRemoveIds, Guid actioningUserId);
    }
}
