/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Constants;
using Astrana.Core.Domain.Models.NewContentWorkflowStages.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Astrana.Core.Data.Entities.Workflow
{
    [Table("NewContentWorkflowStage", Schema = SchemaNames.Workflow)]
    public class NewContentWorkflowStage
    {
        [Key, Column(Order = 0)]
        public Guid NewContentWorkflowStageId { get; set; }

        public string ContentEntityId { get; set; }

        public string ContentEntityTypeId { get; set; }

        public NewContentStage Stage { get; set; }

        public Guid CreatedBy { get; set; }

        public Guid LastModifiedBy { get; set; }

        public DateTimeOffset CreatedTimestamp { get; set; }

        public DateTimeOffset LastModifiedTimestamp { get; set; }
    }
}
