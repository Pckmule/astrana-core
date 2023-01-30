using Astrana.Core.Data.Repositories.Countries;
using Astrana.Core.Domain.Models.Countries;
using Astrana.Core.Domain.Models.Countries.Options;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Utilities;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.Domain.Countries.Queries
{
    public class GetCountriesQuery : IGetCountriesQuery
    {
        private readonly ILogger<GetCountriesQuery> _logger;
        private readonly ICountryRepository<Guid> _countryRepository;

        public GetCountriesQuery(ILogger<GetCountriesQuery> logger, ICountryRepository<Guid> countryRepository)
        {
            _logger = logger;
            _countryRepository = countryRepository;
        }

        public async Task<GetResult<CountryQueryOptions<long, Guid>, Country, long, Guid>> ExecuteAsync(Guid actioningUserId, CountryQueryOptions<long, Guid>? options = null)
        {
            options ??= new CountryQueryOptions<long, Guid>();

            var result = await _countryRepository.GetCountriesAsync(options);

            _logger.LogTrace($"Executed {nameof(GetCountriesQuery).SplitOnUpperCase()}");

            return new GetResult<CountryQueryOptions<long, Guid>, Country, long, Guid>(result.Data, options, result.ResultSetCount, result.Message);
        }
    }
}