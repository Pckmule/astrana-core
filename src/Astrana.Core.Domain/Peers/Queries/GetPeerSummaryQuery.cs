using Astrana.Core.Data.Repositories.Peers;
using Astrana.Core.Domain.AstranaApi.Services;
using Astrana.Core.Domain.Models.Peers.DomainTransferObjects;
using Astrana.Core.Extensions;
using Astrana.Core.Utilities;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.Domain.Peers.Queries
{
    public class GetPeerSummaryQuery : IGetPeerSummaryQuery
    {
        private readonly ILogger<GetPeerSummaryQuery> _logger;
        private readonly IAstranaApiCaller _astranaApiCaller;
        private readonly IPeerRepository<Guid> _peerRepository;

        public GetPeerSummaryQuery(ILogger<GetPeerSummaryQuery> logger, IAstranaApiCaller astranaApiCaller, IPeerRepository<Guid> peerRepository)
        {
            _logger = logger;

            _astranaApiCaller = astranaApiCaller;
            _peerRepository = peerRepository;
        }

        public async Task<PeerSummaryDto> ExecuteAsync(Guid actioningUserId, Guid peerId, bool includeStatistics = false)
        {
            if (peerId.IsEmpty())
                throw new ArgumentException($"{nameof(peerId)} cannot be empty.");

            var peer = await _peerRepository.GetPeerByProfileIdAsync(peerId);

            if (peer == null)
                throw new Exception("Peer not found.");

            var peerAddress = new Uri("https://" + peer.Address);

            var peerSummary = new PeerSummaryDto
            {
                Id = peer.Id,
                ProfileId = peer.VirtualProfileId,

                Address = peerAddress.ToString(),

                FirstName = peer.FirstName,
                LastName = peer.LastName,

                Age = peer.Age,
                Sex = peer.Sex,

                // TODO: 
                // ProfileCoverPicture = peer.CoverPicturesCollection?.ContentItems?.FirstOrDefault()?.Image?.ToDomainTransferObject(),
                // ProfilePicture = peer.ProfilePicturesCollection?.ContentItems?.FirstOrDefault()?.Image?.ToDomainTransferObject()
            };

            if (includeStatistics)
            {
                var peerCount = (int)(await _peerRepository.GetPeersCountAsync()).Count;
                var mutualPeerCount = 0;

                peerSummary.Statistics = new PeerStatisticsDto
                {
                    PeerCount = peerCount,
                    MutualPeerCount = mutualPeerCount,
                    ConnectionDate = peer.CreatedTimestamp.Date
                };
            }

            _logger.LogTrace($"Executed {nameof(GetPeerSummaryQuery).SplitOnUpperCase()}");

            return peerSummary;
        }
    }
}