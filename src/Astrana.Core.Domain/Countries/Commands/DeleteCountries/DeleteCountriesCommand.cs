/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Repositories.Countries;
using Astrana.Core.Domain.Models.Countries.Constants;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Enums;
using Astrana.Core.Domain.Models.System.Enums;
using Astrana.Core.Extensions;
using Microsoft.Extensions.Logging;
using MRB = Astrana.Core.Domain.ResultMessageBuilder;

namespace Astrana.Core.Domain.Countries.Commands.DeleteCountries
{
    public class DeleteCountriesCommand : IDeleteCountriesCommand
    {
        private readonly ILogger<DeleteCountriesCommand> _logger;
        private readonly ICountryRepository<Guid> _countryRepository;

        public DeleteCountriesCommand(ILogger<DeleteCountriesCommand> logger, ICountryRepository<Guid> countryRepository)
        {
            _logger = logger;
            _countryRepository = countryRepository;
        }

        public async Task<DeleteResult<List<long>>> ExecuteAsync(IList<long> countriesToDeleteIds, Guid actioningUserId)
        {
            if (!countriesToDeleteIds.Any())
            {
                var message = MRB.NoneProvidedMessage(CrudAction.Remove, ModelProperties.Country.NamePluralForm);

                _logger.LogWarning(message);

                return new DeleteFailResult<List<long>>(new List<long>(), 0, message);
            }

            var validatedCountriesToRemoveIds = countriesToDeleteIds.Where(o => o.IsValidForUpdateOrDelete()).ToList();
            if (!validatedCountriesToRemoveIds.Any())
            {
                var message = MRB.NoneValidMessage(CrudAction.Remove, ModelProperties.Country.NamePluralForm);

                _logger.LogWarning(message);

                return new DeleteFailResult<List<long>>(new List<long>(), 0, message);
            }

            var result = await _countryRepository.DeleteAsync(validatedCountriesToRemoveIds, actioningUserId);

            if (result.Outcome == ResultOutcome.Success)
                return new DeleteSuccessResult<List<long>>(result.Data, result.Count, MRB.DeleteSuccessResultMessage(ModelProperties.Country.NameSingularForm, ModelProperties.Country.NamePluralForm, result.Count));
            
            return new DeleteFailResult<List<long>>(result.Data, 0, result.Message, result.ResultCode);
        }
    }
}