using Astrana.Core.Domain.Models.Countries;
using Astrana.Core.Domain.Models.Countries.Options;
using Astrana.Core.Domain.Models.Results;

namespace Astrana.Core.Domain.Countries.Queries
{
    public interface IGetCountriesQuery
    {
        Task<GetResult<CountryQueryOptions<long, Guid>, Country, long, Guid>> ExecuteAsync(Guid actioningUserId, CountryQueryOptions<long, Guid> options = null);
    }
}