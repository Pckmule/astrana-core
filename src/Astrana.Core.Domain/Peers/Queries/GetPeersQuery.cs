using Astrana.Core.Data.Repositories.Peers;
using Astrana.Core.Domain.Models.Peers;
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

        public async Task<GetResult<PeerQueryOptions<Guid, Guid>, Peer, Guid, Guid>> ExecuteAsync(Guid actioningUserId, PeerQueryOptions<Guid, Guid>? options = null)
        {
            options ??= new PeerQueryOptions<Guid, Guid>();

            var result = await _peerRepository.GetPeersAsync(options);

            _logger.LogTrace($"Executed {nameof(GetPeersQuery).SplitOnUpperCase()}");

            return new GetResult<PeerQueryOptions<Guid, Guid>, Peer, Guid, Guid>(result.Data, options, result.ResultSetCount, result.Message);
        }
    }
}