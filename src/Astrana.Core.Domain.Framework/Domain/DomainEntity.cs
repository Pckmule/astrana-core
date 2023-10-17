/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Framework.Model;
using Astrana.Core.Framework.Model.Validation;
using System.Text.Json.Serialization;

namespace Astrana.Core.Framework.Domain
{
    public abstract class DomainEntity : DomainEntity<Guid, object> { }

    public abstract class DomainEntity<TDomainTransferObject> : DomainEntity<Guid, TDomainTransferObject> 
        where TDomainTransferObject : new() { } // IDomainTransferObject, 

    public abstract class DomainEntity<TEntityId, TDomainTransferObject> : IValidatable 
        where TDomainTransferObject : new() // IDomainTransferObject,
    {
        protected DomainEntity()
        {
            NameUnique = GetType().Name;
            NameSingularForm = GetType().Name;
            NamePluralForm = GetType().Name + "s";

            Id = default!;
        }

        public virtual TEntityId Id { get; protected set; }

        [JsonIgnore]
        public string? NameUnique { get; set; }

        [JsonIgnore]
        public string? NameSingularForm { get; set; }

        [JsonIgnore]
        public string? NamePluralForm { get; set; }

        // ReSharper disable once InconsistentNaming
        public virtual TDomainTransferObject ToDomainTransferObject(bool includeId = true, bool includeAuditData = false)
        {
            // TODO: Make this abstract
            return new TDomainTransferObject();
        }

        public override bool Equals(object? obj)
        {
            var other = obj as DomainEntity<TEntityId, TDomainTransferObject>;

            if (ReferenceEquals(other, null))
                return false;

            if (ReferenceEquals(this, other))
                return true;

            if (GetType() != other.GetType())
                return false;

            if (typeof(TEntityId) == typeof(int))
            {
                var id = Id as int?;
                var otherId = other.Id as int?;

                if (id == 0 || otherId == 0)
                    return false;

                return id == otherId;
            }

            if (typeof(TEntityId) == typeof(long))
            {
                var id = Id as long?;
                var otherId = other.Id as long?;

                if (id == 0 || otherId == 0)
                    return false;

                return id == otherId;
            }

            if (typeof(TEntityId) == typeof(Guid))
            {
                var id = Id as Guid?;
                var otherId = other.Id as Guid?;

                if (id == Guid.Empty || otherId == Guid.Empty)
                    return false;

                return id == otherId;
            }

            return false;
        }

        public static bool operator ==(DomainEntity<TEntityId, TDomainTransferObject> a, DomainEntity<TEntityId, TDomainTransferObject> b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;

            return a.Equals(b);
        }

        public static bool operator !=(DomainEntity<TEntityId, TDomainTransferObject> a, DomainEntity<TEntityId, TDomainTransferObject> b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return (GetType().ToString() + Id).GetHashCode();
        }

        public virtual EntityValidationResult Validate()
        {
            throw new NotImplementedException();
        }

        [JsonIgnore]
        public bool IsValid => Validate().IsSuccess;
    }
}
