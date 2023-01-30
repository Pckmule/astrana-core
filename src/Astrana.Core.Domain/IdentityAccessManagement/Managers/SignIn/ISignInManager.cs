using Astrana.Core.Domain.Models.Results;
using System.IdentityModel.Tokens.Jwt;

namespace Astrana.Core.Domain.IdentityAccessManagement.Managers.SignIn
{
    public interface ISignInManager
    {
        Task<AuthenticateResult> AuthenticateAsync(string? username, string? plainTextPassword);

        JwtSecurityToken ReadAuthToken(string token);
    }
}