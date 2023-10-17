using PeerDataEntity = Astrana.Core.Data.Entities.Peers.Peer;
using PeerDomainEntity = Astrana.Core.Domain.Models.Peers.Peer;

namespace Astrana.Core.Data.Entities.Peers.ModelMappings
{
    public static class Peer
    {
        public static PeerDomainEntity? MapToDomainModel(PeerDataEntity? peerDataEntity)
        {
            if (peerDataEntity == null)
                return null;

            var domainModel = new PeerDomainEntity
            {
                PeerId = peerDataEntity.PeerId,

                VirtualProfileId = peerDataEntity.VirtualProfileId,

                FirstName = peerDataEntity.FirstName,
                LastName = peerDataEntity.LastName,
                Age = peerDataEntity.Age,
                Sex = peerDataEntity.Sex,
                Address = peerDataEntity.Address,
                Note = peerDataEntity.Note,
                PeerAccessToken = peerDataEntity.PeerAccessToken,
                IsMuted = peerDataEntity.IsMuted,
                
                CreatedBy = peerDataEntity.CreatedBy,
                CreatedTimestamp = peerDataEntity.CreatedTimestamp,

                LastModifiedBy = peerDataEntity.LastModifiedBy,
                LastModifiedTimestamp = peerDataEntity.LastModifiedTimestamp,

                DeactivatedBy = peerDataEntity.DeactivatedBy,
                DeactivatedTimestamp = peerDataEntity.DeactivatedTimestamp,
                DeactivatedReason = peerDataEntity.DeactivatedReason
            };

            return domainModel;
        }
    }
}
