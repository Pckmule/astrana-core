/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.IdentityAccessManagement.Managers.SignIn;
using Astrana.Core.Domain.IdentityAccessManagement.Managers.User;
using Astrana.Core.Domain.Models.IdentityAccessManagement.Models;
using Astrana.Core.Domain.Models.Results.Enums;
using Astrana.Core.Domain.Models.Results.Extensions;
using Astrana.Core.Domain.Models.UserProfiles.Options;
using Astrana.Core.Domain.UserPreferences.Queries;
using Astrana.Core.Domain.UserProfiles.Queries;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.API.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class UserController : BaseController<UserController>
    {
        private readonly ILogger<UserController> _logger;
        private readonly IConfiguration _configuration;

        private readonly ISignInManager _signInManager;
        private readonly IUserManager _userManager;

        private readonly IGetUserProfileQuery _getUserProfileQuery;
        private readonly IGetUserPreferencesQuery _getUserPreferencesQuery;

        public UserController(IConfiguration configuration, ILogger<UserController> logger, ISignInManager signInManager, IUserManager userManager, 
            IGetUserProfileQuery getUserProfileQuery,
            IGetUserPreferencesQuery getUserPreferencesQuery) : base(logger, signInManager)
        {
            _configuration = configuration;
            _logger = logger;

            _signInManager = signInManager;
            _userManager = userManager;

            _getUserProfileQuery = getUserProfileQuery;
            _getUserPreferencesQuery = getUserPreferencesQuery;
        }

        /// <summary>
        /// Authenticates user credentials and returns an Authorization Token when successful.
        /// </summary>
        /// <param name="request"></param>
        /// <response code="200">Authentication was successful.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="401">Authentication failed.</response>
        /// <response code="500">Something went wrong.</response>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost("Authenticate")]
        public async Task<IActionResult> Authenticate(LoginRequest request)
        {            
            try
            {
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
        public async Task<IActionResult> RegisterAccount(ApplicationUserToAdd request)
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
        public async Task<IActionResult> InitiateResetPassword(InitiateResetPasswordRequest initiateResetPasswordRequest)
        {
            var actioningUserId = GetActioningUserId(true);

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
        public async Task<IActionResult> ResetPassword(ResetPasswordRequest resetPasswordRequest)
        {
            var actioningUserId = GetActioningUserId(true);

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
    }
}