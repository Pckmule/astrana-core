﻿/*
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

namespace Astrana.Core.Domain.Peers.Commands.AcceptPeerConnectionRequests
{
    public class AcceptPeerConnectionRequestsCommand : IAcceptPeerConnectionRequestsCommand
    {
        private readonly ILogger<AcceptPeerConnectionRequestsCommand> _logger;

        private readonly IPeerRepository<Guid> _peerRepository;

        public AcceptPeerConnectionRequestsCommand(ILogger<AcceptPeerConnectionRequestsCommand> logger, IPeerRepository<Guid> peerRepository)
        {
            _logger = logger;

            _peerRepository = peerRepository;
        }

        public async Task<UpdateResult<List<PeerConnectionRequestReceived>>> ExecuteAsync(IList<Guid> peerConnectionRequestIdsToAccept, Guid actioningUserId)
        {
            if (!peerConnectionRequestIdsToAccept.Any())
            {
                var message = MRB.NoneProvidedMessage(CrudAction.Update, ModelProperties.PeerConnectionRequestReceived.NamePluralForm);

                _logger.LogWarning(message);

                return new UpdateFailResult<List<PeerConnectionRequestReceived>>(new List<PeerConnectionRequestReceived>(), 0, message);
            }

            var validatedPeerConnectionRequestIdsToAccept = peerConnectionRequestIdsToAccept.Where(o => o.IsValidForUpdateOrDelete()).ToList();
            if (!validatedPeerConnectionRequestIdsToAccept.Any())
            {
                var message = MRB.NoneValidMessage(CrudAction.Update, ModelProperties.PeerConnectionRequestReceived.NamePluralForm);

                _logger.LogWarning(message);

                return new UpdateFailResult<List<PeerConnectionRequestReceived>>(new List<PeerConnectionRequestReceived>(), 0, message);
            }

            // TODO: Add logic to check that the status hasn't already been set

            var result = await _peerRepository.AcceptPeerConnectionRequestsAsync(validatedPeerConnectionRequestIdsToAccept, actioningUserId);

            if (result.Outcome == ResultOutcome.Success)
                return new UpdateSuccessResult<List<PeerConnectionRequestReceived>>(result.Data, result.Count, MRB.UpdateSuccessResultMessage(ModelProperties.PeerConnectionRequestReceived.NameSingularForm, ModelProperties.PeerConnectionRequestReceived.NamePluralForm, result.Count));
            
            return new UpdateFailResult<List<PeerConnectionRequestReceived>>(result.Data, 0, result.Message, result.ResultCode);
        }
    }
}