using System.IdentityModel.Tokens.Jwt;

namespace Astrana.Core.Domain.IdentityAccessManagement.Utilities
{
    public static class JsonWebTokenUtility
    {
        public static long GetTokenExpirationTime(string token)
        {
            var tokenExp = new JwtSecurityTokenHandler().ReadJwtToken(token).Claims.First(claim => claim.Type.Equals("exp")).Value;

            return long.Parse(tokenExp);
        }

        public static bool CheckTokenIsValid(string token)
        {
            var tokenTicks = GetTokenExpirationTime(token);
            var tokenDate = DateTimeOffset.FromUnixTimeSeconds(tokenTicks).UtcDateTime;

            return tokenDate >= DateTime.UtcNow;
        }
    }
}
