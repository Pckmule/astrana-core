using Astrana.Core.Domain.Models.Peers.DomainTransferObjects;

namespace Astrana.Core.Domain.Peers.Queries
{
    public interface IGetPeerSummaryQuery
    {
        Task<PeerSummaryDto> ExecuteAsync(Guid actioningUserId, Guid peerId, bool includeStatistics = false);
    }
}