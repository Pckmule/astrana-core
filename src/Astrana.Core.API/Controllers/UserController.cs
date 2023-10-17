/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Configuration.Extensions;
using Astrana.Core.Constants;
using Astrana.Core.Data.Repositories.Peers;
using Astrana.Core.Domain.AstranaApi.Services;
using Astrana.Core.Domain.IdentityAccessManagement.Managers.SignIn;
using Astrana.Core.Domain.IdentityAccessManagement.Managers.User;
using Astrana.Core.Domain.Models.IdentityAccessManagement.Models;
using Astrana.Core.Domain.Models.Images;
using Astrana.Core.Domain.Models.Images.Options;
using Astrana.Core.Domain.Models.Options;
using Astrana.Core.Domain.Models.Posts.Options;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Enums;
using Astrana.Core.Domain.Models.Results.Extensions;
using Astrana.Core.Domain.Models.System.Enums;
using Astrana.Core.Domain.Models.UserProfiles;
using Astrana.Core.Domain.Models.UserProfiles.Options;
using Astrana.Core.Domain.Peers.Queries;
using Astrana.Core.Domain.ProfileCoverPicture.Commands.AddProfileCoverPicture;
using Astrana.Core.Domain.ProfilePicture.Commands.AddProfilePicture;
using Astrana.Core.Domain.UserPreferences.Queries;
using Astrana.Core.Domain.UserProfiles.Commands.CreateUserProfileDetails;
using Astrana.Core.Domain.UserProfiles.Commands.DeleteUserProfileDetails;
using Astrana.Core.Domain.UserProfiles.Commands.UpdateUserProfileDetails;
using Astrana.Core.Domain.UserProfiles.Commands.UpdateUserProfileIntroduction;
using Astrana.Core.Domain.UserProfiles.Queries;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.API.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class UserController : BaseController<UserController>
    {
        private readonly ILogger<UserController> _logger;
        private readonly IConfiguration _configuration;

        private readonly ISignInManager _signInManager;
        private readonly IUserManager _userManager;

        private readonly IPeerRepository<Guid> _peerRepository;

        private readonly IGetUserProfileQuery _getUserProfileQuery;
        private readonly IGetUserPreferencesQuery _getUserPreferencesQuery;
        private readonly IAddProfilePictureCommand _addProfilePictureCommand;
        private readonly IAddProfileCoverPictureCommand _addProfileCoverPictureCommand;
        private readonly IUpdateUserProfileIntroductionCommand _updateUserProfileIntroductionCommand;
        
        private readonly IGetUserProfileDetailsQuery _getUserProfileDetailsQuery;
        private readonly ICreateUserProfileDetailsCommand _createUserProfileDetailsCommand;
        private readonly IUpdateUserProfileDetailsCommand _updateUserProfileDetailsCommand;
        private readonly IDeleteUserProfileDetailsCommand _deleteUserProfileDetailsCommand;
        private readonly IGetInstancePeerSummaryQuery _getInstancePeerSummaryQuery;

        private readonly IGetProfilePhotosQuery _getProfilePhotosQuery;

        public UserController(ILogger<UserController> logger, 
            IConfiguration configuration,
            ISignInManager signInManager, 
            IUserManager userManager, 
            IPeerRepository<Guid> peerRepository, 
            IGetUserProfileQuery getUserProfileQuery,
            IGetUserPreferencesQuery getUserPreferencesQuery,
            IAddProfilePictureCommand addProfilePictureCommand,
            IAddProfileCoverPictureCommand addProfileCoverPictureCommand,
            IUpdateUserProfileIntroductionCommand updateUserProfileIntroductionCommand,
            IGetUserProfileDetailsQuery getUserProfileDetailsQuery, 
            ICreateUserProfileDetailsCommand createUserProfileDetailsCommand, 
            IUpdateUserProfileDetailsCommand updateUserProfileDetailsCommand, 
            IDeleteUserProfileDetailsCommand deleteUserProfileDetailsCommand,
            IGetInstancePeerSummaryQuery getInstancePeerSummaryQuery,
            IGetProfilePhotosQuery getProfilePhotosQuery
            ) : base(logger, signInManager)
        {
            _logger = logger;
            _configuration = configuration;

            _signInManager = signInManager;
            _userManager = userManager;

            _peerRepository = peerRepository;

            _getUserProfileQuery = getUserProfileQuery;
            _getUserPreferencesQuery = getUserPreferencesQuery;

            _addProfilePictureCommand = addProfilePictureCommand;
            _addProfileCoverPictureCommand = addProfileCoverPictureCommand;

            _updateUserProfileIntroductionCommand = updateUserProfileIntroductionCommand;

            _getUserProfileDetailsQuery = getUserProfileDetailsQuery;
            _createUserProfileDetailsCommand = createUserProfileDetailsCommand;
            _updateUserProfileDetailsCommand = updateUserProfileDetailsCommand;
            _deleteUserProfileDetailsCommand = deleteUserProfileDetailsCommand;
            _getInstancePeerSummaryQuery = getInstancePeerSummaryQuery;

            _getProfilePhotosQuery = getProfilePhotosQuery;
        }

        /// <summary>
        /// Authenticates user credentials and returns an Authorization Token when successful.
        /// </summary>
        /// <param name="request"></param>
        /// <response code="200">Authentication was successful.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="401">Authentication failed.</response>
        /// <response code="428">Precondition must be met.</response>
        /// <response code="500">Something went wrong.</response>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost("Authenticate")]
        public async Task<IActionResult> AuthenticateAsync(LoginRequest request)
        {
            try
            {
                if (_configuration.IsSetupModeEnabled())
                {
                    return PreconditionRequiredResponse("Unavailable until the instance setup is completed.");
                }

                var result = await _signInManager.AuthenticateAsync(request.Username, request.Password);

                if (result.Outcome == ResultOutcome.Success)
                    return AuthenticationSuccessResponse(result.Token);
                
                return Unauthorized("Authentication Failed.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                return ErrorResponse();
            }
        }

        /// <summary>
        /// Creates a new User Account
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <response code="201">User Account(s) successfully created.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [AllowAnonymous]
        [HttpPut("Register")]
        public async Task<IActionResult> RegisterAccountAsync(ApplicationUserToAdd request)
        {
            try
            {
                var result = await _userManager.CreateUserAsync(request, Guid.Parse(Core.Constants.SystemUser.Id));

                if(result.Outcome == ResultOutcome.Success)
                    return CreatedSuccessResponse(result, result.Message);

                return ValidationResponse(result.Message, result.Errors.Select(o => o.ToApiResponseFailedItem()).ToList());
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                return ErrorResponse(request);
            }
        }

        /// <summary>
        /// Initiates the password reset process for a specified user account.
        /// </summary>
        /// <param name="initiateResetPasswordRequest"></param>
        /// <returns></returns>
        /// <response code="202">Successfully initiated password reset process.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [AllowAnonymous]
        [HttpPost("ResetPassword/Initiate")]
        public async Task<IActionResult> InitiateResetPasswordAsync(InitiateResetPasswordRequest initiateResetPasswordRequest)
        {
            var actioningUserId = GetActioningUserId(ActioningUserOptions.Anonymous);

            try
            {
                var result = await _userManager.InitiatePasswordResetAsync(initiateResetPasswordRequest, actioningUserId);

                if (result.Outcome == ResultOutcome.Success)
                    return Accepted();
                
                return ErrorResponse(result, result.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                return ErrorResponse(initiateResetPasswordRequest);
            }
        }

        /// <summary>
        /// Sets the new password for the user account associated with the supplied verification token.
        /// </summary>
        /// <param name="resetPasswordRequest"></param>
        /// <returns></returns>
        /// <response code="200">Successfully reset password.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [AllowAnonymous]
        [HttpPost("ResetPassword")]
        public async Task<IActionResult> ResetPasswordAsync(ResetPasswordRequest resetPasswordRequest)
        {
            var actioningUserId = GetActioningUserId(ActioningUserOptions.Anonymous);

            try
            {
                var result = await _userManager.ResetPasswordAsync(resetPasswordRequest.ValidationToken, resetPasswordRequest.NewPassword, actioningUserId);

                if (result.Outcome == ResultOutcome.Success)
                    return UpdatedSuccessResponse(result, result.Message);
                
                return ErrorResponse(result, result.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                return ErrorResponse(resetPasswordRequest);
            }
        }

        /// <summary>
        /// Gets the Instance User Peer Summary.
        /// </summary>
        /// <returns></returns>
        /// <response code="200">Instance User Peer Summary successfully retrieved.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpGet("Instance")]
        public async Task<IActionResult> GetInstancePeerSummaryAsync()
        {
            var actioningUserId = GetActioningUserId();

            var result = await _getInstancePeerSummaryQuery.ExecuteAsync(actioningUserId);

            return UnpagedGetResponse(result, "");
        }

        /// <summary>
        /// Gets the Instance User Profile.
        /// </summary>
        /// <returns></returns>
        /// <response code="200">Instance User Profile successfully retrieved.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpGet("Profile")]
        public async Task<IActionResult> GetProfileAsync()
        {
            var actioningUserId = GetActioningUserId();

            var result = await _getUserProfileQuery.ExecuteAsync(actioningUserId, new UserProfileQueryOptions<Guid, Guid>());

            return UnpagedGetResponse(result.Data.FirstOrDefault(), result.Message);
        }

        /// <summary>
        /// Returns the User Profile Introduction.
        /// </summary>
        /// <returns></returns>
        /// <response code="200">User Profile Detail(s) successfully retrieved.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpGet("Profile/Introduction")]
        public async Task<IActionResult> GetUserProfileIntroductionAsync(Guid? peerId = null)
        {
            var actioningUserId = GetActioningUserId();

            //if (peerId.HasValue)
            //{
            //    var peer = await _peerRepository.GetPeerByIdAsync(peerId.Value);

            //    var peerApi = new AstranaApiClient();
            //        peerApi.SetAuthorizationToken(peer.PeerAccessToken);

            //    var peerApiResult = await peerApi.GetAsync<List<UserProfile>>(peer.Address, "user", "profile/introduction", queryOptions.ToQueryStringList());

            //    if (peerApiResult.IsSuccess)
            //    {
            //        var peerResult = ConvertToGetResult<PostQueryOptions<long, Guid>, long, Guid, UserProfile>(peerApiResult, queryOptions);

            //        return UnpagedGetResponse(peerResult, peerApiResult.Message);
            //    }

            //    return ErrorResponse(peerApiResult.Message);
            //}

            var result = await _getUserProfileQuery.ExecuteAsync(actioningUserId, new UserProfileQueryOptions<Guid, Guid>());

            return UnpagedGetResponse(result.Data.FirstOrDefault()?.Introduction ?? "", result.Message);
        }

        /// <summary>
        /// Updates an existing User Profile's introduction by Profile ID.
        /// </summary>
        /// <param name="userProfileId"></param>
        /// <param name="introduction"></param>
        /// <returns></returns>
        /// <response code="200">User Profile Introduction successfully updated.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpPost("Profile/Introduction")]
        public async Task<IActionResult> UpdateUserProfileIntroductionAsync(Guid userProfileId, string introduction)
        {
            var actioningUserId = GetActioningUserId();

            try
            {
                var result = await _updateUserProfileIntroductionCommand.ExecuteAsync(userProfileId, introduction, actioningUserId);

                if (result.Outcome == ResultOutcome.Success)
                    return UpdatedSuccessResponse(result, result.Message);

                return ErrorResponse(result, result.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                return ErrorResponse(introduction);
            }
        }


        /// <summary>
        /// Returns a paged set of User Profile Details according to the options provided.
        /// </summary>
        /// <param name="createdAfter"></param>
        /// <param name="createdBefore"></param>
        /// <param name="createdById"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        /// <response code="200">User Profile Detail(s) successfully retrieved.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpGet("Profile/Details")]
        public async Task<IActionResult> GetUserProfileDetailsAsync(DateTime? createdAfter = null, DateTime? createdBefore = null, Guid? createdById = null, int page = Pagination.DefaultPage, int pageSize = Pagination.DefaultPageSize)
        {
            var actioningUserId = GetActioningUserId();

            var queryOptions = new UserProfileDetailQueryOptions<Guid, Guid>
            {
                OwnerUserIds = createdById.HasValue ? new List<Guid> { createdById.Value } : new List<Guid>(),

                CreatedAfter = createdAfter,
                CreatedBefore = createdBefore,

                PageSize = pageSize,
                CurrentPage = page
            };

            var result = await _getUserProfileDetailsQuery.ExecuteAsync(actioningUserId, queryOptions);

            return PagedGetResponse(result, page, pageSize, result.Message);
        }

        /// <summary>
        /// Gets a User Profile Detail by it's ID if it exists.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <response code="200">User Profile Detail successfully retrieved.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpGet("Profile/Details/{id}")]
        public async Task<IActionResult> GetUserProfileDetailByIdAsync(Guid id)
        {
            var actioningUserId = GetActioningUserId();

            var queryOptions = new UserProfileDetailQueryOptions<Guid, Guid>
            {
                Ids = new List<Guid> { id }
            };

            var result = await _getUserProfileDetailsQuery.ExecuteAsync(actioningUserId, queryOptions);

            return UnpagedGetResponse(result.Data.FirstOrDefault(), result.Message);
        }

        /// <summary>
        /// Creates new User Profile Detail.
        /// </summary>
        /// <param name="userProfileDetails"></param>
        /// <returns></returns>
        /// <response code="201">User Profile Detail(s) successfully created.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpPut("Profile/Details")]
        public async Task<IActionResult> CreateUserProfileDetailsAsync(IList<UserProfileDetailToAdd> userProfileDetails)
        {
            var actioningUserId = GetActioningUserId();

            try
            {
                var result = await _createUserProfileDetailsCommand.ExecuteAsync(userProfileDetails, actioningUserId);

                if (result.Outcome == ResultOutcome.Success)
                {
                    return CreatedSuccessResponse(result, result.Message);
                }

                return ErrorResponse(result, result.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                return ErrorResponse(userProfileDetails);
            }
        }

        /// <summary>
        /// Updates existing User Profile Detail.
        /// </summary>
        /// <param name="userProfileDetails"></param>
        /// <returns></returns>
        /// <response code="200">User Profile Detail(s) successfully updated.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpPost("Profile/Details")]
        public async Task<IActionResult> UpdateUserProfileDetails(IList<UserProfileDetail> userProfileDetails)
        {
            var actioningUserId = GetActioningUserId();

            try
            {
                var result = await _updateUserProfileDetailsCommand.ExecuteAsync(userProfileDetails, actioningUserId);

                if (result.Outcome == ResultOutcome.Success)
                    return UpdatedSuccessResponse(result, result.Message);

                return ErrorResponse(result, result.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                return ErrorResponse(userProfileDetails);
            }
        }

        /// <summary>
        /// Deletes existing User Profile Details by their IDs.
        /// </summary>
        /// <param name="userProfileDetailIds"></param>
        /// <returns></returns>
        /// <response code="200">User Profile Detail(s) successfully updated.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpDelete("Profile/Details")]
        public async Task<IActionResult> DeleteUserProfileDetailsAsync(IList<Guid> userProfileDetailIds)
        {
            var actioningUserId = GetActioningUserId();

            try
            {
                var result = await _deleteUserProfileDetailsCommand.ExecuteAsync(userProfileDetailIds, actioningUserId);

                if (result.Outcome == ResultOutcome.Success)
                    return DeletedSuccessResponse(result, result.Message);

                return ErrorResponse(result, result.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                return ErrorResponse(userProfileDetailIds);
            }
        }

        /// <summary>
        /// Returns a paged set of profile photos.
        /// </summary>
        /// <param name="createdAfter"></param>
        /// <param name="createdBefore"></param>
        /// <param name="createdById"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        [HttpGet("Profile/Photos")]
        public async Task<IActionResult> GetProfilePhotosAsync(DateTime? createdAfter = null, DateTime? createdBefore = null, Guid? createdById = null, int page = Pagination.DefaultPage, int pageSize = Pagination.DefaultPageSize, string? orderBy = null, OrderByDirection orderByDirection = OrderByDirection.Default)
        {
            var actioningUserId = GetActioningUserId();

            var queryOptions = new ImageQueryOptions<Guid, Guid>
            {
                OwnerUserIds = createdById.HasValue ? new List<Guid> { createdById.Value } : new List<Guid>(),

                CreatedAfter = createdAfter,
                CreatedBefore = createdBefore,

                PageSize = pageSize,
                CurrentPage = page,

                OrderByDirection = orderByDirection,
                OrderBy = orderBy
            };

            var result = await _getProfilePhotosQuery.ExecuteAsync(actioningUserId, queryOptions);

            return PagedGetResponse(result, page, pageSize, result.Message);
        }

        /// <summary>
        /// Returns a paged set of featured profile photos.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="orderBy"></param>
        /// <param name="orderByDirection"></param>
        /// <returns></returns>
        [HttpGet("Profile/Photos/Featured")]
        public async Task<IActionResult> GetProfileFeaturedPhotosAsync(int page = Pagination.DefaultPage, int pageSize = Pagination.DefaultPageSize, string? orderBy = null, OrderByDirection orderByDirection = OrderByDirection.Default)
        {
            var actioningUserId = GetActioningUserId();

            var instanceUser = _userManager.GetInstanceUserAsync();

            var queryOptions = new ImageQueryOptions<Guid, Guid>
            {
                PageSize = pageSize,
                CurrentPage = page,

                OrderByDirection = orderByDirection,
                OrderBy = orderBy
            };

            var result = await _getProfilePhotosQuery.ExecuteAsync(actioningUserId, queryOptions);

            return PagedGetResponse(result, page, pageSize, result.Message);
        }

        /// <summary>
        /// Gets the Instance User Preferences.
        /// </summary>
        /// <returns></returns>
        /// <response code="200">Instance User Preferences successfully retrieved.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpGet("Preferences")]
        public async Task<IActionResult> GetPreferencesAsync()
        {
            var actioningUserId = GetActioningUserId();

            var result = await _getUserPreferencesQuery.ExecuteAsync(actioningUserId, actioningUserId);

            return UnpagedGetResponse(result);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        [HttpPost("Profile/Picture")]
        public async Task<IActionResult> UpdateProfilePicture([FromForm] IFormFile file)
        {
            var actioningUserId = GetActioningUserId();

            var instanceUser = await _userManager.GetInstanceUserAsync();

            if(instanceUser == null)
                return ErrorResponse("Instance user not found.");

            var result = await _addProfilePictureCommand.ExecuteAsync(instanceUser.ProfileId, file, actioningUserId);

            if (result.Outcome == ResultOutcome.Success)
                return UpdatedSuccessResponse(new UpdateResult<Image>(result.Outcome, result.Data, result.Count, result.Message, result.ResultCode), result.Message);

            return ErrorResponse(result.Data, result.Message);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="files"></param>
        /// <returns></returns>
        [HttpPost("Profile/CoverPicture")]
        public async Task<IActionResult> UpdateCoverPicture([FromForm] IFormFile file)
        {
            var actioningUserId = GetActioningUserId();

            var instanceUser = await _userManager.GetInstanceUserAsync();

            if(instanceUser == null)
                return ErrorResponse("Instance user not found.");

            var result = await _addProfileCoverPictureCommand.ExecuteAsync(instanceUser.ProfileId, file, actioningUserId);

            if (result.Outcome == ResultOutcome.Success)
                return UpdatedSuccessResponse(new UpdateResult<Image>(result.Outcome, result.Data, result.Count, result.Message, result.ResultCode), result.Message);

            return ErrorResponse(result.Data, result.Message);
        }
    }
}