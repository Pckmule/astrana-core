using Astrana.Core.Domain.Models.Feelings;
using Astrana.Core.Domain.Models.Feelings.Options;
using Astrana.Core.Domain.Models.Results;

namespace Astrana.Core.Domain.Feelings.Queries
{
    public interface IGetFeelingsQuery
    {
        Task<GetResult<FeelingsQueryOptions<Guid, Guid>, Feeling, Guid, Guid>> ExecuteAsync(Guid actioningUserId, FeelingsQueryOptions<Guid, Guid> options = null);
    }
}