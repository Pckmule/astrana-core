/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using AgeCalculator;
using Astrana.Core.Data.Repositories.Peers;
using Astrana.Core.Domain.Models.Peers.DomainTransferObjects;
using Astrana.Core.Domain.Models.Peers.Options;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Utilities;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.Domain.Peers.Queries
{
    public class GetReceivedPeerConnectionRequestsQuery : IGetReceivedPeerConnectionRequestsQuery
    {
        private readonly ILogger<GetReceivedPeerConnectionRequestsQuery> _logger;
        private readonly IPeerRepository<Guid> _peerRepository;

        public GetReceivedPeerConnectionRequestsQuery(ILogger<GetReceivedPeerConnectionRequestsQuery> logger, IPeerRepository<Guid> peerRepository)
        {
            _logger = logger;
            _peerRepository = peerRepository;
        }

        public async Task<GetResult<ReceivedPeerConnectionRequestQueryOptions<Guid, Guid>, PeerConnectionRequestReceivedDto, Guid, Guid>> ExecuteAsync(Guid actioningUserId, ReceivedPeerConnectionRequestQueryOptions<Guid, Guid>? options = null)
        {
            options ??= new ReceivedPeerConnectionRequestQueryOptions<Guid, Guid>();

            var result = await _peerRepository.GetReceivedPeerConnectionRequestsAsync(options);

            var peerConnectionRequestReceivedDtos = new List<PeerConnectionRequestReceivedDto>();

            foreach (var peerConnectionRequestReceived in result.Data)
            {
                peerConnectionRequestReceivedDtos.Add(new()
                {
                    Id = peerConnectionRequestReceived.Id,
                    Address = peerConnectionRequestReceived.Address,
                    PeerSummary = new ()
                    {
                        FirstName = peerConnectionRequestReceived.FirstName,
                        LastName = peerConnectionRequestReceived.LastName
                        // TODO: //ProfilePicture = 
                    },
                    Status = peerConnectionRequestReceived.Status,
                    Note = peerConnectionRequestReceived.Note,
                    CreatedTimestamp = peerConnectionRequestReceived.CreatedTimestamp
                });
            }

            _logger.LogTrace($"Executed {nameof(GetReceivedPeerConnectionRequestsQuery).SplitOnUpperCase()}");

            return new GetResult<ReceivedPeerConnectionRequestQueryOptions<Guid, Guid>, PeerConnectionRequestReceivedDto, Guid, Guid>(peerConnectionRequestReceivedDtos, options, result.ResultSetCount, result.Message);
        }
    }
}