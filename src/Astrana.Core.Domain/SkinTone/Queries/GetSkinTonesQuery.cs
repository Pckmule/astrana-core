using Astrana.Core.Data.Repositories.Feelings;
using Astrana.Core.Domain.Models.Feelings;
using Astrana.Core.Domain.Models.Options;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Utilities;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.Domain.SkinTone.Queries
{
    public class GetSkinTonesQuery : IGetSkinTonesQuery
    {
        private readonly ILogger<GetSkinTonesQuery> _logger;
        private readonly IFeelingRepository<Guid> _feelingRepository;

        public GetSkinTonesQuery(ILogger<GetSkinTonesQuery> logger, IFeelingRepository<Guid> feelingRepository)
        {
            _logger = logger;
            _feelingRepository = feelingRepository;
        }

        public async Task<GetResult<QueryOptions<Guid, Guid>, Feeling, Guid, Guid>> ExecuteAsync(Guid actioningUserId)
        {
            var result = await _feelingRepository.GetFeelingsAsync();

            _logger.LogTrace($"Executed {nameof(SkinTone).SplitOnUpperCase()}");

            return new GetResult<QueryOptions<Guid, Guid>, Feeling, Guid, Guid>(result.Data, new QueryOptions<Guid, Guid>(), result.ResultSetCount, result.Message);
        }
    }
}