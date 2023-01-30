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

        public GetLookupQuery(ILogger<GetLookupQuery> logger, IGetLanguagesQuery getLanguagesQuery)
        {
            _logger = logger;
            _getLanguagesQuery = getLanguagesQuery;
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
                    return ModelToLookupOptionConvertor.ConvertToLookup("Countries", "countries", null, (await _getLanguagesQuery.ExecuteAsync(actioningUserId)).Data);
            }

            return null;
        }
    }
}