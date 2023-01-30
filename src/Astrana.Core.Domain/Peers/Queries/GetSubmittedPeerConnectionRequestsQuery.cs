/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Repositories.Peers;
using Astrana.Core.Domain.Models.Peers;
using Astrana.Core.Domain.Models.Peers.Options;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Utilities;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.Domain.Peers.Queries
{
    public class GetSubmittedPeerConnectionRequestsQuery : IGetSubmittedPeerConnectionRequestsQuery
    {
        private readonly ILogger<GetSubmittedPeerConnectionRequestsQuery> _logger;
        private readonly IPeerRepository<Guid> _peerRepository;

        public GetSubmittedPeerConnectionRequestsQuery(ILogger<GetSubmittedPeerConnectionRequestsQuery> logger, IPeerRepository<Guid> peerRepository)
        {
            _logger = logger;
            _peerRepository = peerRepository;
        }

        public async Task<GetResult<SubmittedPeerConnectionRequestQueryOptions<Guid, Guid>, PeerConnectionRequestSubmitted, Guid, Guid>> ExecuteAsync(Guid actioningUserId, SubmittedPeerConnectionRequestQueryOptions<Guid, Guid>? options = null)
        {
            options ??= new SubmittedPeerConnectionRequestQueryOptions<Guid, Guid>();

            var result = await _peerRepository.GetSubmittedPeerConnectionRequestsAsync(options);

            _logger.LogTrace($"Executed {nameof(GetSubmittedPeerConnectionRequestsQuery).SplitOnUpperCase()}");

            return new GetResult<SubmittedPeerConnectionRequestQueryOptions<Guid, Guid>, PeerConnectionRequestSubmitted, Guid, Guid>(result.Data, options, result.ResultSetCount, result.Message);
        }
    }
}