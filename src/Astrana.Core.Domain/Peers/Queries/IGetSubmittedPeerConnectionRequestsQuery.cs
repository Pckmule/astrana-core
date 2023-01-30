using Astrana.Core.Domain.Models.Peers;
using Astrana.Core.Domain.Models.Peers.Options;
using Astrana.Core.Domain.Models.Results;

namespace Astrana.Core.Domain.Peers.Queries
{
    public interface IGetSubmittedPeerConnectionRequestsQuery
    {
        Task<GetResult<SubmittedPeerConnectionRequestQueryOptions<Guid, Guid>, PeerConnectionRequestSubmitted, Guid, Guid>> ExecuteAsync(Guid actioningUserId, SubmittedPeerConnectionRequestQueryOptions<Guid, Guid> options = null);
    }
}