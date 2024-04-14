namespace Astrana.Core.Data.Entities.Content.ModelMappings
{
    public static class AudioClip
    {
        public static Domain.Models.AudioClips.AudioClip? MapToDomainModel(Content.AudioClip? audioDataEntity)
        {
            if (audioDataEntity == null)
                return null;

            var domainModel = new Domain.Models.AudioClips.AudioClip
            {
                AudioClipId = audioDataEntity.AudioClipId,

                Location = audioDataEntity.Location,
                Caption = audioDataEntity.Caption,
                Copyright = audioDataEntity.Copyright,

                CreatedBy = audioDataEntity.CreatedBy,
                CreatedTimestamp = audioDataEntity.CreatedTimestamp,

                LastModifiedBy = audioDataEntity.LastModifiedBy,
                LastModifiedTimestamp = audioDataEntity.LastModifiedTimestamp,

                DeactivatedBy = audioDataEntity.DeactivatedBy,
                DeactivatedTimestamp = audioDataEntity.DeactivatedTimestamp,
                DeactivatedReason = audioDataEntity.DeactivatedReason
            };

            return domainModel;
        }
    }
}
