/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Repositories.NewContentWorkflowStages;
using Astrana.Core.Domain.Models.NewContentWorkflowStages;
using Astrana.Core.Domain.Models.NewContentWorkflowStages.Options;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Utilities;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.Domain.NewContentWorkflowStages.Queries
{
    public class GetNewContentWorkflowStagesQuery : IGetNewContentWorkflowStagesQuery
    {
        private readonly ILogger<GetNewContentWorkflowStagesQuery> _logger;
        private readonly INewContentWorkflowStageRepository<Guid> _newContentWorkflowStageRepository;

        public GetNewContentWorkflowStagesQuery(ILogger<GetNewContentWorkflowStagesQuery> logger, INewContentWorkflowStageRepository<Guid> newContentWorkflowStageRepository)
        {
            _logger = logger;
            _newContentWorkflowStageRepository = newContentWorkflowStageRepository;
        }

        public async Task<GetResult<NewContentWorkflowStageQueryOptions<Guid, Guid>, NewContentWorkflowStage, Guid, Guid>> ExecuteAsync(Guid actioningUserId, NewContentWorkflowStageQueryOptions<Guid, Guid>? options = null)
        {
            options ??= new NewContentWorkflowStageQueryOptions<Guid, Guid>();

            var result = await _newContentWorkflowStageRepository.GetNewContentWorkflowStagesAsync(options);
            
            _logger.LogTrace($"Executed {nameof(GetNewContentWorkflowStagesQuery).SplitOnUpperCase()}");

            return new GetResult<NewContentWorkflowStageQueryOptions<Guid, Guid>, NewContentWorkflowStage, Guid, Guid>(result.Data, options, result.ResultSetCount, result.Message);
        }
    }
}