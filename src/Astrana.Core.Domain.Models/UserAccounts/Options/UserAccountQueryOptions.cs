/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Options;
using Astrana.Core.Domain.Models.UserAccounts.Enums;
using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Models.UserAccounts.Options
{
    public class UserAccountQueryOptions<TRecordId, TOwnerUserId> : QueryOptions<TRecordId, TOwnerUserId>, IUserAccountQueryOptions
        where TRecordId : struct
        where TOwnerUserId : struct
    {
        [JsonConstructor]
        public UserAccountQueryOptions() { }

        public UserAccountQueryOptions(List<TRecordId> ids) : base(ids) { }

        public List<UserAccountType> AccountTypes { get; set; } = new();

        public List<string> Usernames { get; set; } = new();

    }
}
