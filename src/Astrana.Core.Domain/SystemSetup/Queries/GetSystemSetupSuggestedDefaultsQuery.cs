/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Repositories.TimeZones;
using Astrana.Core.Domain.Models.SystemSetup.DomainTransferObjects;
using Astrana.Core.Utilities;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.Domain.SystemSetup.Queries
{
    public class GetSystemSetupSuggestedDefaultsQuery : IGetSystemSetupSuggestedDefaultsQuery
    {
        private readonly ILogger<GetSystemSetupSuggestedDefaultsQuery> _logger;
        
        private readonly ITimeZoneRepository<Guid> _timeZoneRepository;
        
        public GetSystemSetupSuggestedDefaultsQuery(ILogger<GetSystemSetupSuggestedDefaultsQuery> logger, ITimeZoneRepository<Guid> timeZoneRepository)
        {
            _logger = logger;
            
            _timeZoneRepository = timeZoneRepository;
        }

        public async Task<SystemSetupSuggestedDefaultsDto> ExecuteAsync(Guid actioningUserId)
        {
            var localeParts = Thread.CurrentThread.CurrentCulture.Name.Split("-", StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

            var languageCode = Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName;
            var countryCode = localeParts.Length > 1 ? localeParts[1].ToLower() : Constants.Internationalization.DefaultCountryTwoLetterCode;

            var timeZoneId = (await _timeZoneRepository.GetTimeZonesByCountryAsync(countryCode)).Data.FirstOrDefault()?.TimeZoneId.ToString();

            var defaults = new SystemSetupSuggestedDefaultsDto
            {
                LanguageCode = languageCode.ToUpper(),
                CountryCode = countryCode.ToUpper(),
                TimeZoneId = timeZoneId
            };

            _logger.LogTrace($"Executed {nameof(GetSystemSetupSuggestedDefaultsQuery).SplitOnUpperCase()}");

            return defaults;
        }
    }
}