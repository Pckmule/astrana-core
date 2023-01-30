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

namespace Astrana.Core.Domain.Countries.Commands.UpdateCountries
{
    public class UpdateCountriesCommand : IUpdateCountriesCommand
    {
        private readonly ILogger<UpdateCountriesCommand> _logger;
        private readonly ICountryRepository<Guid> _countryRepository;

        public UpdateCountriesCommand(ILogger<UpdateCountriesCommand> logger, ICountryRepository<Guid> countryRepository)
        {
            _logger = logger;
            _countryRepository = countryRepository;
        }

        public async Task<UpdateResult<List<Country>>> ExecuteAsync(IList<Country> countriesToUpdate, Guid actioningUserId)
        {
            if (!countriesToUpdate.Any())
            {
                var message = MRB.NoneProvidedMessage(CrudAction.Update, ModelProperties.Country.NamePluralForm);

                _logger.LogWarning(message);

                return new UpdateFailResult<List<Country>>(new List<Country>(), 0, message);
            }

            var validatedCountriesToUpdate = countriesToUpdate.Where(o => o.IsValid).ToList();
            if (!validatedCountriesToUpdate.Any())
            {
                var message = MRB.NoneValidMessage(CrudAction.Update, ModelProperties.Country.NamePluralForm);

                _logger.LogWarning(message);

                return new UpdateFailResult<List<Country>>(new List<Country>(), 0, message);
            }

            var result = await _countryRepository.UpdateAsync(validatedCountriesToUpdate, actioningUserId);

            if (result.Outcome == ResultOutcome.Success)
                return new UpdateSuccessResult<List<Country>>(result.Data, result.Count, MRB.UpdateSuccessResultMessage(ModelProperties.Country.NameSingularForm, ModelProperties.Country.NamePluralForm, result.Count));
            
            return new UpdateFailResult<List<Country>>(result.Data, 0, result.Message, result.ResultCode);
        }
    }
}