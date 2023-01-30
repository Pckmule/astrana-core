using Astrana.Core.Domain.Models.Results;

namespace Astrana.Core.Domain.Countries.Commands.DeleteCountries
{
    public interface IDeleteCountriesCommand
    {
        Task<DeleteResult<List<long>>> ExecuteAsync(IList<long> countriesToDeleteIds, Guid actioningUserId);
    }
}