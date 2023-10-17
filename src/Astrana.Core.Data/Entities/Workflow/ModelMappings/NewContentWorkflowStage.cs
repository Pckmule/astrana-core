using NewContentWorkflowStageDataEntity = Astrana.Core.Data.Entities.Workflow.NewContentWorkflowStage;
using NewContentWorkflowStageDomainEntity = Astrana.Core.Domain.Models.NewContentWorkflowStages.NewContentWorkflowStage;

namespace Astrana.Core.Data.Entities.Workflow.ModelMappings
{
    public static class NewContentWorkflowStage
    {
        public static NewContentWorkflowStageDomainEntity MapToDomainModel(NewContentWorkflowStageDataEntity newContentWorkflowStageDataEntity)
        {
            if (newContentWorkflowStageDataEntity == null)
                return null;

            var domainModel = new NewContentWorkflowStageDomainEntity
            {
                NewContentWorkflowStageId = newContentWorkflowStageDataEntity.NewContentWorkflowStageId,

                ContentEntityId = newContentWorkflowStageDataEntity.ContentEntityId,
                ContentEntityTypeId = newContentWorkflowStageDataEntity.ContentEntityTypeId,
                Stage = newContentWorkflowStageDataEntity.Stage,
                
                CreatedBy = newContentWorkflowStageDataEntity.CreatedBy,
                CreatedTimestamp = newContentWorkflowStageDataEntity.CreatedTimestamp,

                LastModifiedBy = newContentWorkflowStageDataEntity.LastModifiedBy,
                LastModifiedTimestamp = newContentWorkflowStageDataEntity.LastModifiedTimestamp
            };
            
            return domainModel;
        }
    }
}
