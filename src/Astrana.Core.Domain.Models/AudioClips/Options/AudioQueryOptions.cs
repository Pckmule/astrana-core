/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using System.Text.Json.Serialization;
using Astrana.Core.Domain.Models.Options;

namespace Astrana.Core.Domain.Models.AudioClips.Options
{
    public class AudioQueryOptions<TRecordId, TOwnerUserId> : QueryOptions<TRecordId, TOwnerUserId>, IAudioQueryOptions
        where TRecordId : struct
        where TOwnerUserId : struct
    {
        [JsonConstructor]
        public AudioQueryOptions() { }

        public AudioQueryOptions(List<TRecordId> ids) : base(ids) { }
    }
}
