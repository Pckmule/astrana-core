using Astrana.Core.Domain.Models.Countries;
using Astrana.Core.Domain.Models.Results;

namespace Astrana.Core.Domain.Countries.Commands.UpdateCountries
{
    public interface IUpdateCountriesCommand
    {
        Task<UpdateResult<List<Country>>> ExecuteAsync(IList<Country> countriesToUpdate, Guid actioningUserId);
    }
}