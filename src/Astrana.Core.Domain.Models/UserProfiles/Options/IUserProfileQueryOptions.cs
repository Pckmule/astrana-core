using Astrana.Core.Domain.Models.UserProfiles.Enums;

namespace Astrana.Core.Domain.Models.UserProfiles.Options
{
    public interface IUserProfileQueryOptions
    {
        List<Guid> AccountIds { get; set; }

        List<string> FirstNames { get; set; }

        List<string> LastNames { get; set; }

        List<Gender> Genders { get; set; }
    }
}