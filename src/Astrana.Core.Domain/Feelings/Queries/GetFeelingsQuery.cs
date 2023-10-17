using Astrana.Core.Data.Repositories.Feelings;
using Astrana.Core.Domain.Models.Feelings;
using Astrana.Core.Domain.Models.Feelings.Options;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Utilities;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.Domain.Feelings.Queries
{
    public class GetFeelingsQuery : IGetFeelingsQuery
    {
        private readonly ILogger<GetFeelingsQuery> _logger;
        private readonly IFeelingRepository<Guid> _feelingRepository;

        public GetFeelingsQuery(ILogger<GetFeelingsQuery> logger, IFeelingRepository<Guid> feelingRepository)
        {
            _logger = logger;
            _feelingRepository = feelingRepository;
        }

        public async Task<GetResult<FeelingsQueryOptions<Guid, Guid>, Feeling, Guid, Guid>> ExecuteAsync(Guid actioningUserId, FeelingsQueryOptions<Guid, Guid>? options = null)
        {
            options ??= new FeelingsQueryOptions<Guid, Guid>();

            var result = await _feelingRepository.GetFeelingsAsync(options);

            _logger.LogTrace($"Executed {nameof(GetFeelingsQuery).SplitOnUpperCase()}");

            return new GetResult<FeelingsQueryOptions<Guid, Guid>, Feeling, Guid, Guid>(result.Data, options, result.ResultSetCount, result.Message);
        }
    }
}