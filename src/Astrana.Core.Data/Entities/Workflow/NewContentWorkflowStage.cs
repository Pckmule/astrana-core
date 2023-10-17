/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astrana.Core.Domain.Models.NewContentWorkflowStages.Enums;

#nullable disable

namespace Astrana.Core.Data.Entities.Workflow
{
    [Table("NewContentWorkflowStage", Schema = SchemaNames.Workflow)]
    public class NewContentWorkflowStage
    {
        [Key, Column(Order = 0)]
        public Guid NewContentWorkflowStageId { get; set; }

        [Required]
        [Column(Order = 1)]
        public string ContentEntityId { get; set; }

        [Required]
        [Column(Order = 2)]
        public string ContentEntityTypeId { get; set; }

        [Required]
        [Column(Order = 3)]
        public NewContentStage Stage { get; set; }

        [Required, Column(Order = 99996)]
        public Guid CreatedBy { get; set; }

        [Required, Column(Order = 99997)]
        public Guid LastModifiedBy { get; set; }

        [Required, Column(Order = 99998)]
        public DateTimeOffset CreatedTimestamp { get; set; } = DateTimeOffset.UtcNow;

        [Required, Column(Order = 99999)]
        public DateTimeOffset LastModifiedTimestamp { get; set; } = DateTimeOffset.UtcNow;
    }
}
