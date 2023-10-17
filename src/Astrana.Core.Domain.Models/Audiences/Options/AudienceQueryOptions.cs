/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Options;
using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Models.Audiences.Options
{
    public class AudienceQueryOptions<TRecordId, TOwnerUserId> : QueryOptions<TRecordId, TOwnerUserId>, IAudienceQueryOptions
        where TRecordId : struct
        where TOwnerUserId : struct
    {
        [JsonConstructor]
        public AudienceQueryOptions() { }

        public AudienceQueryOptions(List<TRecordId> ids) : base(ids) { }
    }
}
