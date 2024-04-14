using Astrana.Core.Domain.Models.Feelings;
using Astrana.Core.Domain.Models.Options;
using Astrana.Core.Domain.Models.Results;

namespace Astrana.Core.Domain.SkinTone.Queries
{
    public interface IGetSkinTonesQuery
    {
        Task<GetResult<QueryOptions<Guid, Guid>, Feeling, Guid, Guid>> ExecuteAsync(Guid actioningUserId);
    }
}