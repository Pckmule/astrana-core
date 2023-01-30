using Astrana.Core.Domain.Models.ApiAccessTokens;
using Astrana.Core.Domain.Models.Results;

namespace Astrana.Core.Domain.AstranaApi.Commands.CreateApiAccessToken
{
    public interface ICreateApiAccessTokenCommand
    {
        Task<AddResult<ApiAccessToken>> ExecuteAsync(Guid peerId, Guid actioningUserId);
    }
}
