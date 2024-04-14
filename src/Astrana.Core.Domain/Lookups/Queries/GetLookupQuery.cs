/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Countries.Queries;
using Astrana.Core.Domain.Feelings.Queries;
using Astrana.Core.Domain.Languages.Queries;
using Astrana.Core.Domain.Lookups.Convertors;
using Astrana.Core.Domain.Models.Lookups;
using Astrana.Core.Domain.TimeZones.Queries;
using Astrana.Core.Localization;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.Domain.Lookups.Queries
{
    public class GetLookupQuery : IGetLookupQuery
    {
        private readonly ILogger<GetLookupQuery> _logger;

        private readonly IGetLanguagesQuery _getLanguagesQuery;
        private readonly IGetCountriesQuery _getCountriesQuery;
        private readonly IGetTimeZonesQuery _getTimeZonesQuery;
        private readonly IGetFeelingsQuery _getFeelingsQuery;

        public GetLookupQuery(ILogger<GetLookupQuery> logger, 
            IGetLanguagesQuery getLanguagesQuery, 
            IGetCountriesQuery getCountriesQuery, 
            IGetTimeZonesQuery getTimeZonesQuery, 
            IGetFeelingsQuery getFeelingsQuery)
        {
            _logger = logger;

            _getLanguagesQuery = getLanguagesQuery;
            _getCountriesQuery = getCountriesQuery;
            _getTimeZonesQuery = getTimeZonesQuery;
            _getFeelingsQuery = getFeelingsQuery;
        }

        public async Task<LookupDto?> ExecuteAsync(Guid actioningUserId, string lookupName, string languageCode = null, string labelTemplate = null)
        {
            var enumType = LookupRegistrations.Get().FirstOrDefault(o => string.Equals(o.Name, lookupName, StringComparison.CurrentCultureIgnoreCase));

            if (enumType != null)
                return EnumToLookupConvertor.ConvertToLookup(enumType);

            LookupDto? lookup = null;

            switch(lookupName.ToLower())
            {
                case "languages":
                    lookup = ModelToLookupOptionConvertor.ConvertToLookup("Languages", "languages", null, null, (await _getLanguagesQuery.ExecuteAsync(actioningUserId)).Data);
                    break;

                case "countries":
                    lookup = ModelToLookupOptionConvertor.ConvertToLookup("Countries", "countries", null, null, (await _getCountriesQuery.ExecuteAsync(actioningUserId)).Data);
                    break;

                case "timezones":
                    lookup = ModelToLookupOptionConvertor.ConvertToLookup("Time Zones", "timezones", null, null, (await _getTimeZonesQuery.ExecuteAsync(actioningUserId)).Data, "(UTC {{CorrespondingUtcZone}}) - {{label}}");
                    break;

                case "feelings":
                    lookup = ModelToLookupOptionConvertor.ConvertToLookup("Feelings", "feelings", null, null, (await _getFeelingsQuery.ExecuteAsync(actioningUserId)).Data);
                    break;
            }

            if (lookup == null) 
                return lookup;

            if (!string.IsNullOrEmpty(languageCode))
            {
                var translator = new Translator(languageCode);

                foreach (var lookupOption in lookup.Options.Where(o => !string.IsNullOrWhiteSpace(o.TrxCode)).ToList())
                {
                    lookupOption.Label = translator.GetTranslation(lookupOption.TrxCode!);
                }
            }

            return lookup;
        }
    }
}