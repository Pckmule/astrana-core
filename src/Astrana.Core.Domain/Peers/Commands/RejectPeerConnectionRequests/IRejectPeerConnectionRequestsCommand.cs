using Astrana.Core.Domain.Models.Peers;
using Astrana.Core.Domain.Models.Results;

namespace Astrana.Core.Domain.Peers.Commands.RejectPeerConnectionRequests
{
    public interface IRejectPeerConnectionRequestsCommand
    {
        Task<UpdateResult<List<PeerConnectionRequestReceived>>> ExecuteAsync(IList<Guid> peerConnectionRequestIdsToReject, Guid actioningUserId);
    }
}