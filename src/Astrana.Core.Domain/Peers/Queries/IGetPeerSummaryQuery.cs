using Astrana.Core.Domain.Models.Peers.DomainTransferObjects;

namespace Astrana.Core.Domain.Peers.Queries
{
    public interface IGetPeerSummaryQuery
    {
        Task<PeerSummaryDto> ExecuteAsync(Guid peerId, Guid actioningUserId);
    }
}