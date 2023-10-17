using Astrana.Core.Data.Repositories.Audiences;
using Astrana.Core.Domain.Models.Audiences;
using Astrana.Core.Domain.Models.Audiences.Options;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Utilities;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.Domain.Audiences.Queries
{
    public class GetAudiencesQuery : IGetAudiencesQuery
    {
        private readonly ILogger<GetAudiencesQuery> _logger;
        private readonly IAudienceRepository<Guid> _languageRepository;

        public GetAudiencesQuery(ILogger<GetAudiencesQuery> logger, IAudienceRepository<Guid> languageRepository)
        {
            _logger = logger;
            _languageRepository = languageRepository;
        }

        public async Task<GetResult<AudienceQueryOptions<Guid, Guid>?, Audience, Guid, Guid>> ExecuteAsync(Guid actioningUserId, AudienceQueryOptions<Guid, Guid>? options = null)
        {
            options ??= new AudienceQueryOptions<Guid, Guid>();

            var result = await _languageRepository.GetAudiencesAsync(options);

            _logger.LogTrace($"Executed {nameof(GetAudiencesQuery).SplitOnUpperCase()}");

            return new GetResult<AudienceQueryOptions<Guid, Guid>?, Audience, Guid, Guid>(result.Data, options, result.ResultSetCount, result.Message);
        }
    }
}