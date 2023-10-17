using Astrana.Core.Domain.Models.Audiences;
using Astrana.Core.Domain.Models.Audiences.Options;
using Astrana.Core.Domain.Models.Results;

namespace Astrana.Core.Domain.Audiences.Queries
{
    public interface IGetAudiencesQuery
    {
        Task<GetResult<AudienceQueryOptions<Guid, Guid>?, Audience, Guid, Guid>> ExecuteAsync(Guid actioningUserId, AudienceQueryOptions<Guid, Guid>? options = null);
    }
}