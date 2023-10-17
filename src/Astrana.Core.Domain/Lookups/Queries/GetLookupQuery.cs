﻿using Astrana.Core.Domain.Countries.Queries;
using Astrana.Core.Domain.Feelings.Queries;
using Astrana.Core.Domain.Languages.Queries;
using Astrana.Core.Domain.Lookups.Convertors;
using Astrana.Core.Domain.Models.Lookups;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.Domain.Lookups.Queries
{
    public class GetLookupQuery : IGetLookupQuery
    {
        private readonly ILogger<GetLookupQuery> _logger;

        private readonly IGetLanguagesQuery _getLanguagesQuery;
        private readonly IGetCountriesQuery _getCountriesQuery;
        private readonly IGetFeelingsQuery _getFeelingsQuery;

        public GetLookupQuery(ILogger<GetLookupQuery> logger, IGetLanguagesQuery getLanguagesQuery, IGetCountriesQuery getCountriesQuery, IGetFeelingsQuery getFeelingsQuery)
        {
            _logger = logger;

            _getLanguagesQuery = getLanguagesQuery;
            _getCountriesQuery = getCountriesQuery;
            _getFeelingsQuery = getFeelingsQuery;
        }

        public async Task<Lookup?> ExecuteAsync(Guid actioningUserId, string lookupName)
        {
            var enumType = LookupRegistrations.Get().FirstOrDefault(x => x.Name.ToLower() == lookupName.ToLower());

            if (enumType != null)
                return EnumToLookupConvertor.ConvertToLookup(enumType);

            switch(lookupName.ToLower())
            {
                case "languages":
                    return ModelToLookupOptionConvertor.ConvertToLookup("Languages", "languages", null, (await _getLanguagesQuery.ExecuteAsync(actioningUserId)).Data);

                case "countries":
                    return ModelToLookupOptionConvertor.ConvertToLookup("Countries", "countries", null, (await _getCountriesQuery.ExecuteAsync(actioningUserId)).Data);

                case "feelings":
                    return ModelToLookupOptionConvertor.ConvertToLookup("Feelings", "feelings", null, (await _getFeelingsQuery.ExecuteAsync(actioningUserId)).Data);
            }

            return null;
        }
    }
}