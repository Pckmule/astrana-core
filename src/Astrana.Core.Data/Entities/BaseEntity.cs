/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Contracts;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Astrana.Core.Data.Entities
{
    public abstract class BaseEntity<TPrimaryKeyId, TUserId> : IEntity<TPrimaryKeyId>, IAuditableEntity<TUserId>
        where TPrimaryKeyId : struct
        where TUserId : struct
    {
        [Key, Column(Order = 0)]
        public virtual TPrimaryKeyId Id { get; set; }

        [Required, Column(Order = 99996)]
        public TUserId CreatedBy { get; set; }

        [Required, Column(Order = 99997)]
        public TUserId LastModifiedBy { get; set; }

        [Required, Column(Order = 99998)]
        public DateTimeOffset CreatedTimestamp { get; set; } = DateTimeOffset.UtcNow;

        [Required, Column(Order = 99999)]
        public DateTimeOffset LastModifiedTimestamp { get; set; } = DateTimeOffset.UtcNow;
    }
}
