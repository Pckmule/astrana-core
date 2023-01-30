using Astrana.Core.Data.Repositories.Languages;
using Astrana.Core.Domain.Models.Languages;
using Astrana.Core.Domain.Models.Languages.Options;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Utilities;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.Domain.Languages.Queries
{
    public class GetLanguagesQuery : IGetLanguagesQuery
    {
        private readonly ILogger<GetLanguagesQuery> _logger;
        private readonly ILanguageRepository<Guid> _languageRepository;

        public GetLanguagesQuery(ILogger<GetLanguagesQuery> logger, ILanguageRepository<Guid> languageRepository)
        {
            _logger = logger;
            _languageRepository = languageRepository;
        }

        public async Task<GetResult<LanguageQueryOptions<Guid, Guid>?, Language, Guid, Guid>> ExecuteAsync(Guid actioningUserId, LanguageQueryOptions<Guid, Guid>? options = null)
        {
            options ??= new LanguageQueryOptions<Guid, Guid>();

            var result = await _languageRepository.GetLanguagesAsync(options);

            _logger.LogTrace($"Executed {nameof(GetLanguagesQuery).SplitOnUpperCase()}");

            return new GetResult<LanguageQueryOptions<Guid, Guid>?, Language, Guid, Guid>(result.Data, options, result.ResultSetCount, result.Message);
        }
    }
}