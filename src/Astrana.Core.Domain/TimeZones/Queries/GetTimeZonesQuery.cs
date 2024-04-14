using Astrana.Core.Data.Repositories.TimeZones;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.TimeZones.Options;
using Astrana.Core.Utilities;
using Microsoft.Extensions.Logging;
using TimeZone = Astrana.Core.Domain.Models.TimeZones.TimeZone;

namespace Astrana.Core.Domain.TimeZones.Queries
{
    public class GetTimeZonesQuery : IGetTimeZonesQuery
    {
        private readonly ILogger<GetTimeZonesQuery> _logger;
        private readonly ITimeZoneRepository<Guid> _feelingRepository;

        public GetTimeZonesQuery(ILogger<GetTimeZonesQuery> logger, ITimeZoneRepository<Guid> feelingRepository)
        {
            _logger = logger;
            _feelingRepository = feelingRepository;
        }

        public async Task<GetResult<TimeZonesQueryOptions<Guid, Guid>, TimeZone, Guid, Guid>> ExecuteAsync(Guid actioningUserId, TimeZonesQueryOptions<Guid, Guid>? options = null)
        {
            options ??= new TimeZonesQueryOptions<Guid, Guid>();

            var result = await _feelingRepository.GetTimeZonesAsync(options);

            _logger.LogTrace($"Executed {nameof(GetTimeZonesQuery).SplitOnUpperCase()}");

            return new GetResult<TimeZonesQueryOptions<Guid, Guid>, TimeZone, Guid, Guid>(result.Data, options, result.ResultSetCount, result.Message);
        }
    }
}