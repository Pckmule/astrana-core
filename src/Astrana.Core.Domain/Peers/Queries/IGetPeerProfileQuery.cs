using Astrana.Core.Domain.Models.Peers;

namespace Astrana.Core.Domain.Peers.Queries
{
    public interface IGetPeerProfileQuery
    {
        Task<PeerProfile> ExecuteAsync(Guid peerId, Guid actioningUserId);
    }
}