/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Repositories.Peers;
using Astrana.Core.Data.Repositories.SystemSettings;
using Astrana.Core.Domain.AstranaApi.Services;
using Astrana.Core.Domain.IdentityAccessManagement.Exceptions;
using Astrana.Core.Domain.IdentityAccessManagement.Managers.Idp;
using Astrana.Core.Domain.IdentityAccessManagement.Managers.User;
using Astrana.Core.Domain.Models.AstranaApi;
using Astrana.Core.Domain.Models.Peers;
using Astrana.Core.Domain.Models.Peers.Constants;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Enums;
using Astrana.Core.Domain.Models.System.Enums;
using Astrana.Core.Domain.Models.SystemSettings.Options;
using Astrana.Core.Framework.Model.Validation;
using Astrana.Core.Framework.Model.Validation.Enums;
using Microsoft.Extensions.Logging;
using MRB = Astrana.Core.Domain.ResultMessageBuilder;
using SystemSettingDefinitions = Astrana.Core.Domain.Models.System.Constants.SettingDefinitions;

namespace Astrana.Core.Domain.Peers.Commands.SubmitPeerConnectionRequests
{
    public class SubmitPeerConnectionRequestCommand : ISubmitPeerConnectionRequestCommand
    {
        private readonly ILogger<SubmitPeerConnectionRequestCommand> _logger;
        
        private readonly IIdpManager _idpManager;
        private readonly IUserManager _userManager;

        private readonly IAstranaApiCaller _astranaApiCaller;
        private readonly ISystemSettingRepository<Guid> _systemSettingRepository;
        private readonly IPeerRepository<Guid> _peerRepository;

        private readonly List<string> _loopBackHosts = new() { "localhost" };

        public SubmitPeerConnectionRequestCommand(
            ILogger<SubmitPeerConnectionRequestCommand> logger, 
            IIdpManager idpManager, 
            IUserManager userManager,
            IAstranaApiCaller astranaApiCaller,
            ISystemSettingRepository<Guid> systemSettingRepository,
            IPeerRepository<Guid> peerRepository)
        {
            _logger = logger;

            _idpManager = idpManager;
            _userManager = userManager;

            _astranaApiCaller = astranaApiCaller;
            _systemSettingRepository = systemSettingRepository;
            _peerRepository = peerRepository;
        }
        
        public async Task<AddResult<PeerConnectionRequestSubmitted>> ExecuteAsync(Guid actioningUserId, Uri targetPeerAddress, string? note = null)
        {
            var inputValidationResult = ValidateInput(targetPeerAddress);

            if (!inputValidationResult.IsSuccess)
                return new AddFailResult<PeerConnectionRequestSubmitted>(null, 0, inputValidationResult.GetFirstFailureMessage());

            if (targetPeerAddress.Scheme != Uri.UriSchemeHttps)
            {
                targetPeerAddress = BuildPeerAddress(targetPeerAddress.Host, targetPeerAddress.Port);
            }

            var submittedPeerConnectionRequests = await _peerRepository.GetSubmittedPeerConnectionRequestsAsync();

            if (submittedPeerConnectionRequests.Data.Any(o => new Uri(o.Address) == targetPeerAddress))
                return new AddSuccessResult<PeerConnectionRequestSubmitted>(submittedPeerConnectionRequests.Data.First(o => new Uri(o.Address) == targetPeerAddress), 1, "Peer Connection Request Already Submitted");
            
            var instancePeerAddress = await GetInstancePeerAddress();
            var instancePeerAddressValidationResult = ValidateInstancePeerAddress(targetPeerAddress, instancePeerAddress);

            if (!instancePeerAddressValidationResult.IsSuccess)
                return new AddFailResult<PeerConnectionRequestSubmitted>(null, 0, instancePeerAddressValidationResult.GetFirstFailureMessage());

            var peerConnectionRequestToSubmit = await BuildRequestPayload(instancePeerAddress, note);

            var createResult = await _peerRepository.CreateSubmittedPeerConnectionRequestsAsync(new List<PeerConnectionRequestSubmittedToAdd?> { peerConnectionRequestToSubmit }, actioningUserId);

            if (createResult.Outcome != ResultOutcome.Success)
                return new AddFailResult<PeerConnectionRequestSubmitted>(null, 0, createResult.Message, createResult.ResultCode);
            
            // TODO: Add logic to check that the status hasn't already been set
            
            var queueResult = await QueueForProcessing(targetPeerAddress.ToString(), peerConnectionRequestToSubmit);

            if (queueResult.IsSuccess)
                return new AddSuccessResult<PeerConnectionRequestSubmitted>(createResult.Data.First(), createResult.Count, MRB.UpdateSuccessResultMessage(ModelProperties.PeerConnectionRequestSubmitted.NameSingularForm, ModelProperties.PeerConnectionRequestSubmitted.NamePluralForm, createResult.Count));

            return new AddFailResult<PeerConnectionRequestSubmitted>(null, 0, queueResult.Message, queueResult.StatusCode);
        }

        private static Uri BuildPeerAddress(string host, int? portNumber = null)
        {
            return new Uri("https://" + host + ":" + portNumber);
        }

        private static ValidationResult ValidateInput(Uri? targetPeerAddress)
        {
            var failures = new List<ValidationResult>();

            if (targetPeerAddress == null || string.IsNullOrEmpty(targetPeerAddress.ToString()))
            {
                var message = MRB.NoneProvidedMessage(CrudAction.Create, ModelProperties.PeerConnectionRequestSubmitted.NamePluralForm);

                failures.Add(new ValidationResult(message: message, outcome: ValidationOutcome.Failed));
            }
            else
            {
                if (targetPeerAddress.Scheme != Uri.UriSchemeHttp && targetPeerAddress.Scheme != Uri.UriSchemeHttps)
                {
                    failures.Add(new ValidationResult(message: "Peer address must use the HTTPS protocol.", outcome: ValidationOutcome.Failed));
                }
            }

            return new ValidationResult(failures);
        }

        private ValidationResult ValidateInstancePeerAddress(Uri targetPeerAddress, Uri instancePeerAddress)
        {
            var failures = new List<ValidationResult>();

            //if (_loopBackHosts.Any(o => o == instancePeerAddress.Host.ToLower()))
            //    failures.Add(new ValidationResult(message: "A domain name must be setup first.", outcome: ValidationOutcome.Failed));

            //if (instancePeerAddress == targetPeerAddress)
            //    failures.Add(new ValidationResult(message: "Cannot connect instance to  itself.", outcome: ValidationOutcome.Failed));
            
            return new ValidationResult(failures);
        }

        private async Task<PeerConnectionRequestSubmittedToAdd> BuildRequestPayload(Uri instancePeerAddress, string? note = null)
        {
            var instanceUser = await _userManager.GetInstanceUserAsync();

            if (instanceUser == null)
                throw new ApplicationUserNotFoundException("Instance user not found.");

            var peerConnectionRequestToSubmit = new PeerConnectionRequestSubmittedToAdd
            {
                FirstName = instanceUser.FirstName,
                LastName = instanceUser.LastName ?? "",

                Address = instancePeerAddress.ToString(),
                PeerPreviewAccessToken = _idpManager.GenerateAccessToken(instanceUser, 48),

                Note = note
            };
            return peerConnectionRequestToSubmit;
        }

        private async Task<Uri> GetInstancePeerAddress()
        {
            var systemSettings = (await _systemSettingRepository.GetSystemSettingsAsync(new SystemSettingQueryOptions<Guid, Guid> { Names = new List<string> { SystemSettingDefinitions.Names.HostName, SystemSettingDefinitions.Names.HostPortNumber } })).Data;

            var hostName = systemSettings.First(o => o.Name == SystemSettingDefinitions.Names.HostName).ValueOrDefault;
            var hostPortNumber = systemSettings.First(o => o.Name == SystemSettingDefinitions.Names.HostPortNumber).ValueOrDefault;

            return BuildPeerAddress(hostName, !string.IsNullOrWhiteSpace(hostPortNumber) ? int.Parse(hostPortNumber) : null);
        }

        private async Task<ApiCallerResult<object>> QueueForProcessing(string targetPeerAddress, PeerConnectionRequestSubmittedToAdd peerConnectionRequestToSubmit)
        {
            // TODO: Move this out to be handled by a scheduled process

            return await _astranaApiCaller.PutAsync<object>(targetPeerAddress, "peers", "connect/requests", peerConnectionRequestToSubmit);

        }
    }
}