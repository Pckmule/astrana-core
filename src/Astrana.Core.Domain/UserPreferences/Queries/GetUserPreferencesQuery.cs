/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Repositories.Countries;
using Astrana.Core.Data.Repositories.Languages;
using Astrana.Core.Data.Repositories.UserAccounts;
using Astrana.Core.Domain.Models.Countries;
using Astrana.Core.Domain.Models.Languages;
using Astrana.Core.Utilities;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.Domain.UserPreferences.Queries
{
    public class GetUserPreferencesQuery : IGetUserPreferencesQuery
    {
        private readonly ILogger<GetUserPreferencesQuery> _logger;

        private readonly IUserAccountRepository<Guid> _userAccountRepository;
        private readonly ILanguageRepository<Guid> _languageRepository;
        private readonly ICountryRepository<Guid> _countryRepository;

        public GetUserPreferencesQuery(ILogger<GetUserPreferencesQuery> logger, 
            IUserAccountRepository<Guid> userAccountRepository, 
            ILanguageRepository<Guid> languageRepository,
            ICountryRepository<Guid> countryRepository)
        {
            _logger = logger;

            _userAccountRepository = userAccountRepository;
            _languageRepository = languageRepository;
            _countryRepository = countryRepository;
        }

        public async Task<Models.Preferences.UserPreferencesDto> ExecuteAsync(Guid userAccountId, Guid actioningUserId)
        {
            var userAccount = await _userAccountRepository.GetUserAccountByIdAsync(userAccountId);

            var language = await _languageRepository.GetLanguageByCodeAsync(userAccount.LanguageCode);
            var country = await _countryRepository.GetCountryByCodeAsync(userAccount.CountryCode);

            var preferences = new Models.Preferences.UserPreferencesDto
            {
                UserAccountId = userAccount.UserAccountId,
                Language = new LanguageLite(language),
                Country = new CountryLite(country)
            };

            _logger.LogTrace($"Executed {nameof(GetUserPreferencesQuery).SplitOnUpperCase()}");

            return preferences;
        }
    }
}