using Astrana.Core.Domain.Models.Options;
using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Models.UserProfiles.Options
{
    public class UserProfileDetailQueryOptions<TRecordId, TOwnerUserId> : QueryOptions<TRecordId, TOwnerUserId>, IUserProfileDetailQueryOptions
        where TRecordId : struct
        where TOwnerUserId : struct
    {
        [JsonConstructor]
        public UserProfileDetailQueryOptions() { }

        public UserProfileDetailQueryOptions(List<TRecordId> ids) : base(ids) { }

        public List<string> Labels { get; set; } = new();
    }
}
