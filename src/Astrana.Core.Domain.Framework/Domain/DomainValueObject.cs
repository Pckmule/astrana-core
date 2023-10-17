/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

namespace Astrana.Core.Framework.Domain
{
    public abstract class DomainValueObject<TValueObject> where TValueObject : DomainValueObject<TValueObject>
    {
        public override bool Equals(object obj)
        {
            var valueObject = obj as TValueObject;

            return !ReferenceEquals(valueObject, null) && EqualsCore(valueObject);
        }

        protected abstract bool EqualsCore(TValueObject other);

        public override int GetHashCode()
        {
            return GetHashCodeCore();
        }

        protected abstract int GetHashCodeCore();

        public static bool operator ==(DomainValueObject<TValueObject> a, DomainValueObject<TValueObject> b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;

            return a.Equals(b);
        }

        public static bool operator !=(DomainValueObject<TValueObject> a, DomainValueObject<TValueObject> b)
        {
            return !(a == b);
        }
    }
}
