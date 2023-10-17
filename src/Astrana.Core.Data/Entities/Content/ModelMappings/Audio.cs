using AudioDataEntity = Astrana.Core.Data.Entities.Content.Audio;
using AudioDomainEntity = Astrana.Core.Domain.Models.AudioClips.Audio;

namespace Astrana.Core.Data.Entities.Content.ModelMappings
{
    public static class Audio
    {
        public static AudioDomainEntity? MapToDomainModel(AudioDataEntity? audioDataEntity)
        {
            if (audioDataEntity == null)
                return null;

            var domainModel = new AudioDomainEntity
            {
                AudioId = audioDataEntity.AudioId,

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
