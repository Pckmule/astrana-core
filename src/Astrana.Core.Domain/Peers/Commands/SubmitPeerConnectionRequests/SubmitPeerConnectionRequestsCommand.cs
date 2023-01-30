/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Repositories.Peers;
using Astrana.Core.Domain.AstranaApi.Services;
using Astrana.Core.Domain.IdentityAccessManagement.Exceptions;
using Astrana.Core.Domain.IdentityAccessManagement.Managers.Idp;
using Astrana.Core.Domain.IdentityAccessManagement.Managers.User;
using Astrana.Core.Domain.Models.Peers;
using Astrana.Core.Domain.Models.Peers.Constants;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Enums;
using Astrana.Core.Domain.Models.System.Enums;
using Microsoft.Extensions.Logging;
using MRB = Astrana.Core.Domain.ResultMessageBuilder;

namespace Astrana.Core.Domain.Peers.Commands.SubmitPeerConnectionRequests
{
    public class SubmitPeerConnectionRequestsCommand : ISubmitPeerConnectionRequestsCommand
    {
        private readonly ILogger<SubmitPeerConnectionRequestsCommand> _logger;
        
        private readonly IIdpManager _idpManager;
        private readonly IUserManager _userManager;

        private readonly IAstranaApiCaller _astranaApiCaller;
        private readonly IPeerRepository<Guid> _peerRepository;

        public SubmitPeerConnectionRequestsCommand(ILogger<SubmitPeerConnectionRequestsCommand> logger, IIdpManager idpManager, IUserManager userManager, IAstranaApiCaller astranaApiCaller, IPeerRepository<Guid> peerRepository)
        {
            _logger = logger;

            _idpManager = idpManager;
            _userManager = userManager;

            _astranaApiCaller = astranaApiCaller;
            _peerRepository = peerRepository;
        }

        public async Task<AddResult<PeerConnectionRequestSubmitted>> ExecuteAsync(PeerConnectionRequestSubmittedToAdd? peerConnectionRequestToSubmit, Guid actioningUserId)
        {
            if (peerConnectionRequestToSubmit == null)
            {
                var message = MRB.NoneProvidedMessage(CrudAction.Update, ModelProperties.PeerConnectionRequestSubmitted.NamePluralForm);

                _logger.LogWarning(message);

                return new AddFailResult<PeerConnectionRequestSubmitted>(null, 0, message);
            }

            var instanceUser = await _userManager.GetInstanceUserAsync();

            if (instanceUser == null)
                throw new ApplicationUserNotFoundException("Instance user not found.");

            peerConnectionRequestToSubmit.PeerPreviewAccessToken = _idpManager.GenerateAccessToken(instanceUser, 48);

            if (!peerConnectionRequestToSubmit.IsValid)
            {
                var message = MRB.NoneValidMessage(CrudAction.Create, ModelProperties.PeerConnectionRequestSubmitted.NamePluralForm);

                _logger.LogWarning(message);

                return new AddFailResult<PeerConnectionRequestSubmitted>(null, 0, message);
            }

            // TODO: Add logic to check that the status hasn't already been set

            var result = await _peerRepository.CreateSubmittedPeerConnectionRequestsAsync(new List<PeerConnectionRequestSubmittedToAdd?> { peerConnectionRequestToSubmit }, actioningUserId);

            if (result.Outcome != ResultOutcome.Success)
                return new AddFailResult<PeerConnectionRequestSubmitted>(null, 0, result.Message, result.ResultCode);

            var peerConnectionRequestSubmitted  = result.Data.First();

            var apiCallResult = await _astranaApiCaller.PutAsync<object>(result.Data.First().Address, "peers", "connect/requests", new PeerConnectionRequestReceivedToAdd
            {
                FirstName = peerConnectionRequestSubmitted.FirstName,
                LastName = peerConnectionRequestSubmitted.LastName,
                Address = peerConnectionRequestSubmitted.Address,
                Note = peerConnectionRequestSubmitted.Note,
                PeerPreviewAccessToken = peerConnectionRequestSubmitted.PeerPreviewAccessToken
            });

            if(apiCallResult.IsSuccess)
                return new AddSuccessResult<PeerConnectionRequestSubmitted>(peerConnectionRequestSubmitted, result.Count, MRB.UpdateSuccessResultMessage(ModelProperties.PeerConnectionRequestSubmitted.NameSingularForm, ModelProperties.PeerConnectionRequestSubmitted.NamePluralForm, result.Count));
                
            return new AddFailResult<PeerConnectionRequestSubmitted>(null, 0, apiCallResult.Message, apiCallResult.StatusCode);

        }
    }
}