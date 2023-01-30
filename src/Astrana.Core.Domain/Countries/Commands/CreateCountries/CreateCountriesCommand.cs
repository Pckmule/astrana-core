/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Repositories.Countries;
using Astrana.Core.Domain.Models.Countries;
using Astrana.Core.Domain.Models.Countries.Constants;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Enums;
using Astrana.Core.Domain.Models.System.Enums;
using Microsoft.Extensions.Logging;
using MRB = Astrana.Core.Domain.ResultMessageBuilder;

namespace Astrana.Core.Domain.Countries.Commands.CreateCountries
{
    public class CreateCountriesCommand : ICreateCountriesCommand
    {
        private readonly ILogger<CreateCountriesCommand> _logger;
        private readonly ICountryRepository<Guid> _countryRepository;

        public CreateCountriesCommand(ILogger<CreateCountriesCommand> logger, ICountryRepository<Guid> countryRepository)
        {
            _logger = logger;
            _countryRepository = countryRepository;
        }

        public async Task<AddResult<List<Country>>> ExecuteAsync(IList<CountryToAdd> countriesToAdd, Guid actioningUserId)
        {
            if (!countriesToAdd.Any())
            {
                var message = MRB.NoneProvidedMessage(CrudAction.Add, ModelProperties.Country.NamePluralForm);

                _logger.LogWarning(message);

                return new AddFailResult<List<Country>>(new List<Country>(), 0, message);
            }

            var validatedCountriesToAdd = countriesToAdd.Where(o => o.IsValid).ToList();
            if (!validatedCountriesToAdd.Any())
            {
                var message = MRB.NoneValidMessage(CrudAction.Add, ModelProperties.Country.NamePluralForm);

                _logger.LogWarning(message);

                return new AddFailResult<List<Country>>(new List<Country>(), 0, message);
            }

            var result = await _countryRepository.CreateAsync(validatedCountriesToAdd, actioningUserId);

            if (result.Outcome == ResultOutcome.Success)
                return new AddSuccessResult<List<Country>>(result.Data, result.Count, MRB.CreateSuccessResultMessage(ModelProperties.Country.NameSingularForm, ModelProperties.Country.NamePluralForm, result.Count));
            
            return new AddFailResult<List<Country>>(result.Data, result.Count, result.Message, result.ResultCode);
        }
    }
}
