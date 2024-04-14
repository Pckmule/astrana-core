using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.TimeZones.Options;
using TimeZone = Astrana.Core.Domain.Models.TimeZones.TimeZone;

namespace Astrana.Core.Domain.TimeZones.Queries
{
    public interface IGetTimeZonesQuery
    {
        Task<GetResult<TimeZonesQueryOptions<Guid, Guid>, TimeZone, Guid, Guid>> ExecuteAsync(Guid actioningUserId, TimeZonesQueryOptions<Guid, Guid> options = null);
    }
}