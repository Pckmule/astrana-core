using Astrana.Core.Domain.Models.Peers;
using Astrana.Core.Domain.Models.Results;

namespace Astrana.Core.Domain.Peers.Commands.CreatePeerConnectionRequests
{
    public interface ICreateReceivedPeerConnectionRequestsCommand
    {
        Task<AddResult<List<PeerConnectionRequestReceived>>> ExecuteAsync(IList<PeerConnectionRequestReceivedToAdd> peerConnectionRequestsToAdd, Guid actioningUserId);
    }
}
