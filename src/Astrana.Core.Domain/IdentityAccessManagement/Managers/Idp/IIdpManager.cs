using Astrana.Core.Domain.Models.IdentityAccessManagement.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;

namespace Astrana.Core.Domain.IdentityAccessManagement.Managers.Idp
{
    public interface IIdpManager
    {
        JwtSecurityToken ReadAuthToken(string token);

        string GenerateAccessToken(ApplicationUser user, int expiryHours = 24);

        string GetIdpIssuer();

        string GetIdpAudience();

        string GetIdpDomain();

        SymmetricSecurityKey GetIdpIssuerSigningKey();
    }
}