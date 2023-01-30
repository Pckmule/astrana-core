using Astrana.Core.Domain.Models.Options;
using Astrana.Core.Domain.Models.UserProfiles.Enums;
using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Models.UserProfiles.Options
{
    public class UserProfileQueryOptions<TRecordId, TOwnerUserId> : QueryOptions<TRecordId, TOwnerUserId>, IUserProfileQueryOptions
        where TRecordId : struct
        where TOwnerUserId : struct
    {
        [JsonConstructor]
        public UserProfileQueryOptions() { }

        public UserProfileQueryOptions(List<TRecordId> ids) : base(ids) { }

        public List<Guid> AccountIds { get; set; } = new();

        public List<string> FirstNames { get; set; } = new();

        public List<string> LastNames { get; set; } = new();

        public List<Gender> Genders { get; set; } = new();
    }
}
