/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

namespace Astrana.Core.Domain.Models.Results
{
    public class WorkflowResult
    {
        public WorkflowResult() { }

        public WorkflowResult(Guid workflowId, int stageId, int statusId, List<WorkflowResultError> errors = null)
        {
            WorkflowId = workflowId;
            StageId = stageId;
            StatusId = statusId;
            Errors = errors;
        }

        public Guid WorkflowId { get; set; }

        public int StageId { get; set; }

        public int StatusId { get; set; }

        public List<WorkflowResultError> Errors { get; set; } = new();
    }

    public class WorkflowResult<TData> : WorkflowResult
    {
        public TData Data { get; set; }
    }
}
