using Astrana.Core.Domain.Models.Peers.DomainTransferObjects;
using Astrana.Core.Domain.Models.Peers.Options;
using Astrana.Core.Domain.Models.Results;

namespace Astrana.Core.Domain.Peers.Queries
{
    public interface IGetReceivedPeerConnectionRequestsQuery
    {
        Task<GetResult<ReceivedPeerConnectionRequestQueryOptions<Guid, Guid>, PeerConnectionRequestReceivedDto, Guid, Guid>> ExecuteAsync(Guid actioningUserId, ReceivedPeerConnectionRequestQueryOptions<Guid, Guid> options = null);
    }
}