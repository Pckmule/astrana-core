using Astrana.Core.Domain.Models.Peers.DomainTransferObjects;

namespace Astrana.Core.Domain.Peers.Queries
{
    public interface IGetInstancePeerSummaryQuery
    {
        Task<PeerSummaryDto> ExecuteAsync(Guid actioningUserId, bool includeStatistics = false);
    }
}