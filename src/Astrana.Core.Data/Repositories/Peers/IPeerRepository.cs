/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Peers;
using Astrana.Core.Domain.Models.Peers.Contracts;
using Astrana.Core.Domain.Models.Peers.Options;
using Astrana.Core.Domain.Models.Results.Contracts;

namespace Astrana.Core.Data.Repositories.Peers
{
    public interface IPeerRepository<TUserId> where TUserId : struct
    {
        Task<ICountResult> GetPeersCountAsync(PeerQueryOptions<Guid, TUserId>? queryOptions = null);

        Task<IGetResult<Peer>> GetPeersAsync(PeerQueryOptions<Guid, TUserId>? queryOptions = null);

        Task<Peer> GetPeerByIdAsync(Guid id);

        Task<IAddResult<List<Peer>>> CreatePeersAsync(IEnumerable<IPeerToAdd> requestedAdditions, TUserId actioningUserId, bool returnRecords = true);

        Task<IUpdateResult<List<Peer>>> UpdatePeersAsync(IEnumerable<IPeer> requestedUpdates, TUserId actioningUserId, bool returnRecords = true);
        
        Task<IDeleteResult<List<Guid>>> DeletePeersAsync(IEnumerable<Guid> peersIds, Guid actioningUserId);

        Task<ICountResult> GetReceivedPeerConnectionRequestsCountAsync(ReceivedPeerConnectionRequestQueryOptions<Guid, TUserId>? queryOptions = null);

        Task<IGetResult<PeerConnectionRequestReceived>> GetReceivedPeerConnectionRequestsAsync(ReceivedPeerConnectionRequestQueryOptions<Guid, TUserId>? queryOptions = null);

        Task<IAddResult<List<PeerConnectionRequestReceived>>> CreateReceivedPeerConnectionRequestsAsync(IEnumerable<IPeerConnectionRequestReceivedToAdd> requestedAdditions, TUserId actioningUserId, bool returnRecords = true);

        Task<IUpdateResult<List<PeerConnectionRequestReceived>>> AcceptPeerConnectionRequestAsync(Guid requestedUpdateId, TUserId actioningUserId, bool returnRecords = true);

        Task<IUpdateResult<List<PeerConnectionRequestReceived>>> AcceptPeerConnectionRequestsAsync(IEnumerable<Guid> requestedUpdateIds, TUserId actioningUserId, bool returnRecords = true);

        Task<IUpdateResult<List<PeerConnectionRequestReceived>>> RejectPeerConnectionRequestsAsync(IEnumerable<Guid> requestedUpdateIds, TUserId actioningUserId, bool returnRecords = true);

        Task<IDeleteResult<List<Guid>>> DeleteReceivedPeerConnectionRequestsAsync(IEnumerable<Guid> receivedPeerConnectionRequestsIds, Guid actioningUserId);

        Task<ICountResult> GetSubmittedPeerConnectionRequestsCountAsync(SubmittedPeerConnectionRequestQueryOptions<Guid, TUserId>? queryOptions = null);

        Task<IGetResult<PeerConnectionRequestSubmitted>> GetSubmittedPeerConnectionRequestsAsync(SubmittedPeerConnectionRequestQueryOptions<Guid, TUserId>? queryOptions = null);

        Task<IAddResult<List<PeerConnectionRequestSubmitted>>> CreateSubmittedPeerConnectionRequestsAsync(IEnumerable<IPeerConnectionRequestSubmittedToAdd?> requestedAdditions, TUserId actioningUserId, bool returnRecords = true);

        Task<IDeleteResult<List<Guid>>> DeleteSubmittedPeerConnectionRequestsAsync(IEnumerable<Guid> submittedPeerConnectionRequestsIds, Guid actioningUserId);

    }
}
