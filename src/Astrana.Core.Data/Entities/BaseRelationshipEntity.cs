using Astrana.Core.Data.Contracts;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Astrana.Core.Data.Entities
{
    public abstract class BaseRelationshipEntity<TUserId> : IAuditableEntity<TUserId> where TUserId : struct
    {
        [Required, Column(Order = 99996)]
        public TUserId CreatedBy { get; set; }

        [Required, Column(Order = 99997)]
        public TUserId LastModifiedBy { get; set; }

        [Required, Column(Order = 99998)]
        public DateTimeOffset CreatedTimestamp { get; set; } = DateTime.UtcNow;

        [Required, Column(Order = 99999)]
        public DateTimeOffset LastModifiedTimestamp { get; set; } = DateTime.UtcNow;
    }
}
