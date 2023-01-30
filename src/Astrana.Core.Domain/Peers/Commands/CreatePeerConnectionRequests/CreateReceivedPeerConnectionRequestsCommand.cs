/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Repositories.Peers;
using Astrana.Core.Domain.Models.Peers;
using Astrana.Core.Domain.Models.Peers.Constants;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Enums;
using Astrana.Core.Domain.Models.System.Enums;
using Astrana.Core.Extensions;
using Microsoft.Extensions.Logging;
using MRB = Astrana.Core.Domain.ResultMessageBuilder;

namespace Astrana.Core.Domain.Peers.Commands.CreatePeerConnectionRequests
{
    public class CreateReceivedPeerConnectionRequestsCommand : ICreateReceivedPeerConnectionRequestsCommand
    {
        private readonly ILogger<CreateReceivedPeerConnectionRequestsCommand> _logger;
        private readonly IPeerRepository<Guid> _peerRepository;

        public CreateReceivedPeerConnectionRequestsCommand(ILogger<CreateReceivedPeerConnectionRequestsCommand> logger, IPeerRepository<Guid> peerRepository)
        {
            _logger = logger;

            _peerRepository = peerRepository;
        }

        public async Task<AddResult<List<PeerConnectionRequestReceived>>> ExecuteAsync(IList<PeerConnectionRequestReceivedToAdd> peerConnectionRequestsToAdd, Guid actioningUserId)
        {
            if (!peerConnectionRequestsToAdd.Any())
            {
                var message = MRB.NoneProvidedMessage(CrudAction.Add, ModelProperties.PeerConnectionRequestReceived.NamePluralForm);

                _logger.LogWarning(message);

                return new AddFailResult<List<PeerConnectionRequestReceived>>(new List<PeerConnectionRequestReceived>(), 0, message);
            }

            var validatedPeerConnectionRequestsToAdd = peerConnectionRequestsToAdd.Where(o => o.IsValid).ToList();
            if (!validatedPeerConnectionRequestsToAdd.Any())
            {
                var message = MRB.NoneValidMessage(CrudAction.Add, ModelProperties.PeerConnectionRequestReceived.NamePluralForm);

                _logger.LogWarning(message);

                return new AddFailResult<List<PeerConnectionRequestReceived>>(new List<PeerConnectionRequestReceived>(), 0, message);
            }

            // TODO: Add logic to check that a connection request doesn't already exist

            var result = await _peerRepository.CreateReceivedPeerConnectionRequestsAsync(validatedPeerConnectionRequestsToAdd, actioningUserId.UseSystemUserIdIfUserIsAnonymous());

            if (result.Outcome == ResultOutcome.Success)
                return new AddSuccessResult<List<PeerConnectionRequestReceived>>(result.Data, result.Count, MRB.CreateSuccessResultMessage(ModelProperties.PeerConnectionRequestReceived.NameSingularForm, ModelProperties.PeerConnectionRequestReceived.NamePluralForm, result.Count));
            
            return new AddFailResult<List<PeerConnectionRequestReceived>>(result.Data, result.Count, result.Message, result.ResultCode);
        }
    }
}
