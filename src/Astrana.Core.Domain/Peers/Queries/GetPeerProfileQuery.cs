using Astrana.Core.Data.Repositories.Peers;
using Astrana.Core.Domain.AstranaApi.Services;
using Astrana.Core.Domain.Models.Peers;
using Astrana.Core.Domain.Peers.Exceptions;
using Astrana.Core.Extensions;
using Astrana.Core.Utilities;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.Domain.Peers.Queries
{
    public class GetPeerProfileQuery : IGetPeerProfileQuery
    {
        private readonly ILogger<GetPeerProfileQuery> _logger;
        private readonly IAstranaApiCaller _astranaApiCaller;
        private readonly IPeerRepository<Guid> _peerRepository;

        public GetPeerProfileQuery(ILogger<GetPeerProfileQuery> logger, IAstranaApiCaller astranaApiCaller, IPeerRepository<Guid> peerRepository)
        {
            _logger = logger;

            _astranaApiCaller = astranaApiCaller;
            _peerRepository = peerRepository;
        }

        public async Task<PeerProfile?> ExecuteAsync(Guid peerId, Guid actioningUserId)
        {
            if (peerId.IsEmpty())
                throw new ArgumentException($"{nameof(peerId)} cannot be empty.");

            var peer = await _peerRepository.GetPeerByIdAsync(peerId);

            if (peer == null)
                throw new PermissionDeniedException("Not connected to Peer.");

            if (peer.DeactivatedTimestamp.HasValue)
                throw new PermissionDeniedException("Relationship to Peer has been deactivated.");

            _astranaApiCaller.SetAuthorizationToken(peer.PeerAccessToken);

            var peerProfile = (await _astranaApiCaller.GetAsync<PeerProfile>(peer.Address, "user", "profile")).GetContent().Data;

            _logger.LogTrace($"Executed {nameof(GetPeerProfileQuery).SplitOnUpperCase()}");

            return peerProfile;
        }
    }
}