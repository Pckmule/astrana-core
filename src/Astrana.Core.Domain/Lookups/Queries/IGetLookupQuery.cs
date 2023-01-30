using Astrana.Core.Domain.Models.Lookups;

namespace Astrana.Core.Domain.Lookups.Queries
{
    public interface IGetLookupQuery
    {
        Task<Lookup> ExecuteAsync(Guid actioningUserId, string lookupName);
    }
}