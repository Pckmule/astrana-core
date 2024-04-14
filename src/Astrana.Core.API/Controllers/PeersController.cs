/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Constants;
using Astrana.Core.Domain.AstranaApi.Commands.CreateApiAccessToken;
using Astrana.Core.Domain.IdentityAccessManagement.Managers.SignIn;
using Astrana.Core.Domain.Models.Peers;
using Astrana.Core.Domain.Models.Peers.Enums;
using Astrana.Core.Domain.Models.Peers.InputModels;
using Astrana.Core.Domain.Models.Peers.Options;
using Astrana.Core.Domain.Models.Results.Enums;
using Astrana.Core.Domain.Peers.Commands.AcceptPeerConnectionRequests;
using Astrana.Core.Domain.Peers.Commands.CreatePeerConnectionRequests;
using Astrana.Core.Domain.Peers.Commands.RejectPeerConnectionRequests;
using Astrana.Core.Domain.Peers.Commands.SubmitPeerConnectionRequests;
using Astrana.Core.Domain.Peers.Queries;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.API.Controllers
{
    [ApiController]
    public class PeersController : BaseController<PeersController>
    {
        private readonly ILogger<PeersController> _logger;

        private readonly ICreateReceivedPeerConnectionRequestsCommand _createReceivedPeerConnectionRequestsCommand;
        private readonly ISubmitPeerConnectionRequestCommand _submitPeerConnectionRequestCommand;
        private readonly IAcceptPeerConnectionRequestsCommand _acceptPeerConnectionRequestsCommand;
        private readonly IRejectPeerConnectionRequestsCommand _rejectPeerConnectionRequestsCommand;

        private readonly IGetReceivedPeerConnectionRequestsQuery _getReceivedPeerConnectionRequestsQuery;
        private readonly IGetSubmittedPeerConnectionRequestsQuery _getSubmittedPeerConnectionRequestsQuery;
        private readonly IGetPeersQuery _getPeersQuery;
        private readonly IGetPeerSummaryQuery _getPeerSummaryQuery;
        private readonly IGetPeerProfileQuery _getPeerProfileQuery;
        private readonly ICreateApiAccessTokenCommand _createApiAccessTokenCommand;

        public PeersController(
            ILogger<PeersController> logger, 
            ISignInManager signInManager,
            ICreateReceivedPeerConnectionRequestsCommand createReceivedPeerConnectionRequestsCommand,
            ISubmitPeerConnectionRequestCommand submitPeerConnectionRequestCommand,
            IAcceptPeerConnectionRequestsCommand acceptPeerConnectionRequestsCommand,
            IRejectPeerConnectionRequestsCommand rejectPeerConnectionRequestsCommand,
            IGetReceivedPeerConnectionRequestsQuery getReceivedPeerConnectionRequestsQuery,
            IGetSubmittedPeerConnectionRequestsQuery getSubmittedPeerConnectionRequestsQuery,
            IGetPeersQuery getPeersQuery,
            IGetPeerSummaryQuery getPeerSummaryQuery,
            IGetPeerProfileQuery getPeerProfileQuery,
            ICreateApiAccessTokenCommand createApiAccessTokenCommand) : base(logger, signInManager)
        {
            _logger = logger;

            _createReceivedPeerConnectionRequestsCommand = createReceivedPeerConnectionRequestsCommand;
            _submitPeerConnectionRequestCommand = submitPeerConnectionRequestCommand;
            _acceptPeerConnectionRequestsCommand = acceptPeerConnectionRequestsCommand;
            _rejectPeerConnectionRequestsCommand = rejectPeerConnectionRequestsCommand;

            _getReceivedPeerConnectionRequestsQuery = getReceivedPeerConnectionRequestsQuery;
            _getSubmittedPeerConnectionRequestsQuery = getSubmittedPeerConnectionRequestsQuery;

            _getPeersQuery = getPeersQuery;
            _getPeerSummaryQuery = getPeerSummaryQuery;
            _getPeerProfileQuery = getPeerProfileQuery;

            _createApiAccessTokenCommand = createApiAccessTokenCommand;
        }

        /// <summary>
        /// Creates peer connection requests.
        /// </summary>
        /// <param name="request"></param>
        /// <response code="200">Peer Connection Request(s) was successfully created.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="401">Creating Peer Connection Request(s) failed.</response>
        /// <response code="500">Something went wrong.</response>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPut("Connect/Requests")]
        public async Task<IActionResult> CreatePeerConnectionRequests(PeerConnectionRequestReceivedInputModel request)
        {
            var actioningUserId = GetActioningUserId(ActioningUserOptions.Anonymous);

            try
            {
                var result = await _createReceivedPeerConnectionRequestsCommand.ExecuteAsync(new List<PeerConnectionRequestReceived> { new PeerConnectionRequestReceived(request)  }, actioningUserId);

                if (result.Outcome == ResultOutcome.Success)
                    return CreatedSuccessResponse(result, result.Message);

                return ErrorResponse(result, result.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                return ErrorResponse(request);
            }
        }

        /// <summary>
        /// Sets peer connection requests as accepted.
        /// </summary>
        /// <param name="peerConnectionRequestIds"></param>
        /// <response code="200">Peer Connection Request(s) was successfully accepted.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="401">Accepting Peer Connection Request(s) failed.</response>
        /// <response code="500">Something went wrong.</response>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost("Connect/Requests/Accept")]
        public async Task<IActionResult> AcceptPeerConnectionRequests(List<Guid> peerConnectionRequestIds)
        {
            var actioningUserId = GetActioningUserId(ActioningUserOptions.Anonymous);

            try
            {
                var result = await _acceptPeerConnectionRequestsCommand.ExecuteAsync(peerConnectionRequestIds, actioningUserId);

                if (result.Outcome == ResultOutcome.Success)
                    return UpdatedSuccessResponse(result, result.Message);

                return ErrorResponse(result, result.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                return ErrorResponse(peerConnectionRequestIds);
            }
        }

        /// <summary>
        /// Sets peer connection requests as rejected.
        /// </summary>
        /// <param name="peerConnectionRequestIds"></param>
        /// <response code="200">Peer Connection Request(s) was successfully rejected.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="401">Rejecting Peer Connection Request(s) failed.</response>
        /// <response code="500">Something went wrong.</response>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost("Connect/Requests/Reject")]
        public async Task<IActionResult> RejectPeerConnectionRequests(List<Guid> peerConnectionRequestIds)
        {
            var actioningUserId = GetActioningUserId(ActioningUserOptions.Anonymous);

            try
            {
                var result = await _rejectPeerConnectionRequestsCommand.ExecuteAsync(peerConnectionRequestIds, actioningUserId);

                if (result.Outcome == ResultOutcome.Success)
                    return UpdatedSuccessResponse(result, result.Message);

                return ErrorResponse(result, result.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                return ErrorResponse(peerConnectionRequestIds);
            }
        }

        /// <summary>
        /// Returns a paged set of peer connection requests according to the options provided.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        /// <response code="200">Received Connection Request(s) successfully retrieved.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpGet("Connect/Requests")]
        public async Task<IActionResult> GetPeerConnectionRequestsAsync(PeerConnectionRequestStatus? status, int page = Pagination.DefaultPage, int pageSize = Pagination.DefaultPageSize)
        {
            var actioningUserId = GetActioningUserId();

            var queryOptions = new ReceivedPeerConnectionRequestQueryOptions<Guid, Guid>
            {
                PageSize = pageSize,
                CurrentPage = page,
                Status = status
            };

            var result = await _getReceivedPeerConnectionRequestsQuery.ExecuteAsync(actioningUserId, queryOptions);

            return PagedGetResponse(result, page, pageSize, result.Message);
        }

        /// <summary>
        /// Submits a peer connection request to the specified Peer address.
        /// </summary>
        /// <param name="peerAddress"></param>
        /// <param name="note"></param>
        /// <response code="200">Peer Connection Request was successfully submitted.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="401">Submitting Peer Connection Request failed.</response>
        /// <response code="500">Something went wrong.</response>
        /// <returns></returns>
        [HttpPut("Connect/Requests/Submit")]
        public async Task<IActionResult> SubmitPeerConnectionRequest(ConnectToPeerInputModel request)
        {
            var actioningUserId = GetActioningUserId(ActioningUserOptions.Anonymous);

            try
            {
                var result = await _submitPeerConnectionRequestCommand.ExecuteAsync(actioningUserId, new Uri(request.PeerAddress), request.Note);

                if (result.Outcome == ResultOutcome.Success)
                    return CreatedSuccessResponse(result, result.Message);

                return ErrorResponse(result, result.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                return ErrorResponse();
            }
        }

        /// <summary>
        /// Returns a paged set of submitted peer connection requests according to the options provided.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        /// <response code="200">Submitted Connection Request(s) successfully retrieved.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpGet("Connect/Requests/Submitted")]
        public async Task<IActionResult> GetSubmittedPeerConnectionRequestsAsync(int page = Pagination.DefaultPage, int pageSize = Pagination.DefaultPageSize)
        {
            var actioningUserId = GetActioningUserId();

            var queryOptions = new SubmittedPeerConnectionRequestQueryOptions<Guid, Guid>
            {
                PageSize = pageSize,
                CurrentPage = page
            };

            var result = await _getSubmittedPeerConnectionRequestsQuery.ExecuteAsync(actioningUserId, queryOptions);

            return PagedGetResponse(result, page, pageSize, result.Message);
        }

        /// <summary>
        /// Returns a paged set of peers according to the options provided.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        /// <response code="200">Peer(s) successfully retrieved.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpGet]
        public async Task<IActionResult> GetPeersAsync(int page = Pagination.DefaultPage, int pageSize = Pagination.DefaultPageSize, bool includeStatistics = false)
        {
            var actioningUserId = GetActioningUserId();

            var queryOptions = new PeerQueryOptions<Guid, Guid>
            {
                PageSize = pageSize,
                CurrentPage = page
            };

            var result = await _getPeersQuery.ExecuteAsync(actioningUserId, queryOptions, includeStatistics);
            
            return PagedGetResponse2(result, result.Data, page, pageSize, result.Message);
        }

        /// <summary>
        /// Returns a Peer Profile by Peer Id.
        /// </summary>
        /// <param name="peerId"></param>
        /// <returns></returns>
        /// <response code="200">Peer profile successfully retrieved.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpGet("{peerId}/Profile")]
        public async Task<IActionResult> GetPeerProfileAsync(Guid peerId)
        {
            var actioningUserId = GetActioningUserId();

            try
            {
                var result = await _getPeerProfileQuery.ExecuteAsync(peerId, actioningUserId);

                if (result == null)
                    return NotFound();

                return UnpagedGetResponse(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                return ErrorResponse(peerId);
            }
        }

        /// <summary>
        /// Returns a Peer Profile by Peer Id.
        /// </summary>
        /// <param name="peerId"></param>
        /// <param name="includeStatistics"></param>
        /// <returns></returns>
        /// <response code="200">Peer profile successfully retrieved.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpGet("{peerId}/Summary")]
        public async Task<IActionResult> GetPeerSummaryAsync(Guid peerId, bool includeStatistics = false)
        {
            var actioningUserId = GetActioningUserId();

            try
            {
                var result = await _getPeerSummaryQuery.ExecuteAsync(actioningUserId, peerId, includeStatistics);

                if (result == null)
                    return NotFound();

                return UnpagedGetResponse(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                return ErrorResponse(peerId);
            }
        }

        /// <summary>
        /// Returns a refreshed API Access Token for a connected Peer
        /// </summary>
        /// <param name="peerId"></param>
        /// <response code="200">API Access Token was successfully refreshed.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="401">Refreshing API Access Token failed.</response>
        /// <response code="500">Something went wrong.</response>
        /// <returns></returns>
        [HttpPost("Access/Refresh")]
        public async Task<IActionResult> RefreshPeerApiAccessToken(Guid peerId)
        {
            var actioningUserId = GetActioningUserId(ActioningUserOptions.Anonymous);

            try
            {
                var result = await _createApiAccessTokenCommand.ExecuteAsync(peerId, actioningUserId);

                if (result.Outcome == ResultOutcome.Success)
                    return AuthenticationSuccessResponse(result.Data.Token);

                return ErrorResponse(result, result.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                return ErrorResponse(peerId);
            }
        }
    }
}