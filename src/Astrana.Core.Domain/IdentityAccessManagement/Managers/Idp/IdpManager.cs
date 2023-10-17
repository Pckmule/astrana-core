/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Repositories.SystemSettings;
using Astrana.Core.Domain.IdentityAccessManagement.Exceptions;
using Astrana.Core.Domain.Models.IdentityAccessManagement.Models;
using Astrana.Core.Domain.Models.System.Constants;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Astrana.Core.Domain.IdentityAccessManagement.Managers.Idp
{
    public class IdpManager : IIdpManager
    {
        private readonly ILogger<IIdpManager> _logger;
        private readonly ISystemSettingRepository<Guid> _systemSettingRepository;

        public IdpManager(ILogger<IIdpManager> logger, ISystemSettingRepository<Guid> systemSettingRepository)
        {
            _logger = logger;

            _systemSettingRepository = systemSettingRepository;
        }

        public string GenerateAccessToken(ApplicationUser user, int expiryHours = 24)
        {
            var securityKey = GetIdpIssuerSigningKey();
            var signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var tokenClaims = new List<Claim>
            {
                new("sub", user.Id.ToString()),
                new("first_name", user.FirstName),
                new("last_name", user.LastName ?? string.Empty)
            };

            var now = DateTime.UtcNow;

            var jwtSecurityToken = new JwtSecurityToken(
                GetIdpIssuer(),
                GetIdpAudience(),
                tokenClaims,
                now,
                now.AddHours(expiryHours),
                signingCredentials
            );

            return new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
        }

        public JwtSecurityToken ReadAuthToken(string token)
        {
            if (string.IsNullOrWhiteSpace(token))
                return null;

            return (JwtSecurityToken)new JwtSecurityTokenHandler().ReadToken(token);
        }

        public string GetIdpIssuer()
        {
            var domain = GetIdpDomain();
            var port = GetIdpPortNumber();

            var uri = $"https://{domain}";

            if (!string.IsNullOrWhiteSpace(port))
                uri += $":{port}";

            return new Uri(uri).ToString();
        }

        public string GetIdpAudience()
        {
            return GetIdpIssuer();
        }

        public string GetIdpDomain()
        {
            var setting = _systemSettingRepository.GetSystemSettingByNameAsync(SettingDefinitions.Names.HostName).Result?.ValueOrDefault;

            if (string.IsNullOrWhiteSpace(setting))
                throw new InvalidSettingException(SettingDefinitions.Names.HostName);

            return setting;
        }

        public string GetIdpPortNumber()
        {
            return _systemSettingRepository.GetSystemSettingByNameAsync(SettingDefinitions.Names.HostPortNumber).Result?.ValueOrDefault ?? string.Empty;
        }

        public SymmetricSecurityKey GetIdpIssuerSigningKey()
        {
            var setting = _systemSettingRepository.GetSystemSettingByNameAsync(SettingDefinitions.Names.IdpIssuerSigningKeySecret).Result?.ValueOrDefault;

            if (string.IsNullOrWhiteSpace(setting))
                throw new InvalidSettingException(SettingDefinitions.Names.IdpIssuerSigningKeySecret);

            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(setting));
        }
    }
}