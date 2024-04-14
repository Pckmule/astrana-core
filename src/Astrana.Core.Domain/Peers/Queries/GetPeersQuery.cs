using Astrana.Core.Data.Repositories.Peers;
using Astrana.Core.Domain.Models.Peers.DomainTransferObjects;
using Astrana.Core.Domain.Models.Peers.Options;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Utilities;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.Domain.Peers.Queries
{
    public class GetPeersQuery : IGetPeersQuery
    {
        private readonly ILogger<GetPeersQuery> _logger;
        private readonly IPeerRepository<Guid> _peerRepository;

        public GetPeersQuery(ILogger<GetPeersQuery> logger, IPeerRepository<Guid> peerRepository)
        {
            _logger = logger;
            _peerRepository = peerRepository;
        }

        public async Task<GetResult<PeerQueryOptions<Guid, Guid>, PeerDto, Guid, Guid>> ExecuteAsync(Guid actioningUserId, PeerQueryOptions<Guid, Guid>? options = null, bool includeStatistics = false)
        {
            options ??= new PeerQueryOptions<Guid, Guid>();

            var result = await _peerRepository.GetPeersAsync(options);

            var peerDtos = result.Data.Select(o => o.ToDomainTransferObject(true, true)).ToList();

            if (includeStatistics)
            {
                foreach (var peer in peerDtos)
                {
                    var peerCount = (int)(await _peerRepository.GetPeersCountAsync()).Count;
                    var mutualPeerCount = 0;

                    peer.Statistics = new PeerStatisticsDto
                    {
                        PeerCount = peerCount,
                        MutualPeerCount = mutualPeerCount,
                        ConnectionDate = peer.CreatedTimestamp?.Date
                    };
                }
            }

            _logger.LogTrace($"Executed {nameof(GetPeersQuery).SplitOnUpperCase()}");

            return new GetResult<PeerQueryOptions<Guid, Guid>, PeerDto, Guid, Guid>(peerDtos, options, result.ResultSetCount, result.Message);
        }
    }
}