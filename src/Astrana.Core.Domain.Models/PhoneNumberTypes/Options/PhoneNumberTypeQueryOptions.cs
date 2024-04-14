/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Options;
using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Models.PhoneNumberTypes.Options
{
    public class PhoneNumberTypeQueryOptions<TRecordId, TOwnerUserId> : QueryOptions<TRecordId, TOwnerUserId>, IPhoneNumberTypeQueryOptions
        where TRecordId : struct
        where TOwnerUserId : struct
    {
        [JsonConstructor]
        public PhoneNumberTypeQueryOptions() { }

        public PhoneNumberTypeQueryOptions(List<TRecordId> ids) : base(ids) { }
    }
}
