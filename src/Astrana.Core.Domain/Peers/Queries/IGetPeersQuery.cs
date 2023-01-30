using Astrana.Core.Domain.Models.Peers;
using Astrana.Core.Domain.Models.Peers.Options;
using Astrana.Core.Domain.Models.Results;

namespace Astrana.Core.Domain.Peers.Queries
{
    public interface IGetPeersQuery
    {
        Task<GetResult<PeerQueryOptions<Guid, Guid>, Peer, Guid, Guid>> ExecuteAsync(Guid actioningUserId, PeerQueryOptions<Guid, Guid> options = null);
    }
}