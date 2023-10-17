/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.NewContentWorkflowStages.Enums;

namespace Astrana.Core.Domain.Models.NewContentWorkflowStages.Contracts
{
    public interface INewContentWorkflowStageToAdd
    {
        string ContentEntityId { get; set; }

        string ContentEntityType { get; set; }

        NewContentStage Stage { get; set; }
    }
}
