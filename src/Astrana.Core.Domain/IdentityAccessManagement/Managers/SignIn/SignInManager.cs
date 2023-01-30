/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.IdentityAccessManagement.Managers.Idp;
using Astrana.Core.Domain.IdentityAccessManagement.Managers.User;
using Astrana.Core.Domain.Models.Results;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.IdentityModel.Tokens.Jwt;

namespace Astrana.Core.Domain.IdentityAccessManagement.Managers.SignIn
{
    public class SignInManager : ISignInManager
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<ISignInManager> _logger;

        private readonly IIdpManager _idpManager;
        private readonly IUserManager _userManager;

        public SignInManager(IConfiguration configuration, ILogger<ISignInManager> logger, IIdpManager idpManager, IUserManager userManager)
        {
            _configuration = configuration;
            _logger = logger;

            _idpManager = idpManager;
            _userManager = userManager;
        }

        public async Task<AuthenticateResult> AuthenticateAsync(string? username, string? plainTextPassword)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(plainTextPassword))
                return new AuthenticateFailResult("Credentials not supplied.");

            var user = await _userManager.FindUserByCredentialsAsync(username, plainTextPassword, Guid.Parse(Constants.SystemUser.Id));

            if (user == null)
                return new AuthenticateFailResult("No user found.");
            
            _logger.LogDebug($"Found user with username: {username}.");

            return new AuthenticateSuccessResult(_idpManager.GenerateAccessToken(user), "Authentication Outcome");
        }

        public JwtSecurityToken ReadAuthToken(string token)
        {
            return _idpManager.ReadAuthToken(token);
        }
    }
}