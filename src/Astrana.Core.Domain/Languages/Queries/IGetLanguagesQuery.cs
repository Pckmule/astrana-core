using Astrana.Core.Domain.Models.Languages;
using Astrana.Core.Domain.Models.Languages.Options;
using Astrana.Core.Domain.Models.Results;

namespace Astrana.Core.Domain.Languages.Queries
{
    public interface IGetLanguagesQuery
    {
        Task<GetResult<LanguageQueryOptions<Guid, Guid>?, Language, Guid, Guid>> ExecuteAsync(Guid actioningUserId, LanguageQueryOptions<Guid, Guid>? options = null);
    }
}