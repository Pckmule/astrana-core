/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.NewContentWorkflowStages.Constants;
using Astrana.Core.Domain.Models.NewContentWorkflowStages.Contracts;
using Astrana.Core.Domain.Models.NewContentWorkflowStages.Enums;
using Astrana.Core.Framework.Domain;
using Astrana.Core.Framework.Model.Validation;
using System.ComponentModel.DataAnnotations;

namespace Astrana.Core.Domain.Models.NewContentWorkflowStages
{
    public class NewContentWorkflowStageToAdd : DomainEntity, INewContentWorkflowStageToAdd
    {
        public NewContentWorkflowStageToAdd()
        {
            NameUnique = ModelProperties.NewContentWorkflowStage.NameUnique;
            NameSingularForm = ModelProperties.NewContentWorkflowStage.NameSingularForm;
            NamePluralForm = ModelProperties.NewContentWorkflowStage.NamePluralForm;
        }

        [Required]
        public string ContentEntityId { get; set; }

        [Required]
        public string ContentEntityType { get; set; }

        [Required]
        public NewContentStage Stage { get; set; }

        public override EntityValidationResult Validate()
        {
            return this.ValidateDomainModel();
        }
    }
}
