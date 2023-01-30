/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Exceptions;
using Astrana.Core.Data.Repositories.ApiAccessTokens;
using Astrana.Core.Data.Repositories.Peers;
using Astrana.Core.Domain.Models.ApiAccessTokens;
using Astrana.Core.Domain.Models.ApiAccessTokens.Constants;
using Astrana.Core.Domain.Models.Peers.Options;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.System.Enums;
using Astrana.Core.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Astrana.Core.Domain.Models.Results.Enums;
using MRB = Astrana.Core.Domain.ResultMessageBuilder;

namespace Astrana.Core.Domain.AstranaApi.Commands.CreateApiAccessToken
{
    public class CreateApiAccessTokenCommand : ICreateApiAccessTokenCommand
    {
        private readonly ILogger<CreateApiAccessTokenCommand> _logger;
        private readonly IConfiguration _configuration;

        private readonly IPeerRepository<Guid> _peerRepository;
        private readonly IApiAccessTokenRepository<Guid> _apiAccessTokenRepository;

        public CreateApiAccessTokenCommand(ILogger<CreateApiAccessTokenCommand> logger, IConfiguration configuration, IPeerRepository<Guid> peerRepository, IApiAccessTokenRepository<Guid> apiAccessTokenRepository)
        {
            _logger = logger;
            _configuration = configuration;

            _peerRepository = peerRepository;
            _apiAccessTokenRepository = apiAccessTokenRepository;
        }

        public async Task<AddResult<ApiAccessToken>> ExecuteAsync(Guid peerId, Guid actioningUserId)
        {
            if (!peerId.IsValidForUpdateOrDelete())
            {
                var message = MRB.NoneProvidedMessage(CrudAction.Add, ModelProperties.ApiAccessToken.NamePluralForm);

                _logger.LogWarning(message);

                return new AddFailResult<ApiAccessToken>(null, 0, message);
            }

            var peer = (await _peerRepository.GetPeersAsync(new PeerQueryOptions<Guid, Guid>
            {
                Ids = new List<Guid> { peerId }

            })).Data.FirstOrDefault();

            if (peer == null)
                throw new EntityNotFoundException($"Peer with ID = {peerId} not found.");

            var apiAccessTokenToAdd = new ApiAccessTokenToAdd
            {
                Token = GenerateToken(peerId.ToString(), peer.FirstName, peer.LastName)
            };

            if (!apiAccessTokenToAdd.IsValid)
            {
                var message = MRB.NoneValidMessage(CrudAction.Add, ModelProperties.ApiAccessToken.NamePluralForm);

                _logger.LogWarning(message);

                return new AddFailResult<ApiAccessToken>(null, 0, message);
            }

            var result = await _apiAccessTokenRepository.CreateAsync(new List<ApiAccessTokenToAdd> { apiAccessTokenToAdd }, actioningUserId);

            if (result.Outcome == ResultOutcome.Success)
                return new AddSuccessResult<ApiAccessToken>(result.Data.FirstOrDefault(), result.Count, MRB.CreateSuccessResultMessage(ModelProperties.ApiAccessToken.NameSingularForm, ModelProperties.ApiAccessToken.NamePluralForm, result.Count));
            
            return new AddFailResult<ApiAccessToken>(null, result.Count, result.Message, result.ResultCode);
        }

        private string GenerateToken(string subject, string firstName, string? lastName = null)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_configuration["Authentication:SecretForKey"] ?? string.Empty));
            var signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var tokenClaims = new List<Claim>
            {
                new("sub", subject),
                new("first_name", firstName),
                new("last_name", lastName ?? string.Empty)
            };

            var jwtSecurityToken = new JwtSecurityToken(
                _configuration["Authentication:Issuer"],
                _configuration["Authentication:Audience"],
                tokenClaims,
                DateTime.UtcNow,
                DateTime.UtcNow.AddHours(1),
                signingCredentials
            );

            return new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
        }
    }
}
