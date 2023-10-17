/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.NewContentWorkflowStages.Enums;
using Astrana.Core.Framework.Model;

namespace Astrana.Core.Domain.Models.NewContentWorkflowStages.DomainTransferObjects
{
    public sealed class NewContentWorkflowStageDto : IDomainTransferObject
    {
        public Guid? Id { get; set; }

        public string? ContentEntityId { get; set; }

        public string? ContentEntityTypeId { get; set; }

        public NewContentStage? Stage { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public DateTimeOffset? CreatedTimestamp { get; set; }

        public DateTimeOffset? LastModifiedTimestamp { get; set; }
    }
}