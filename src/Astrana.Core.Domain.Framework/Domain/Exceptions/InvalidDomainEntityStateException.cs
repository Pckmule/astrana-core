/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using System.Runtime.Serialization;

namespace Astrana.Core.Domain.IdentityAccessManagement.Exceptions
{
    [Serializable]
    public class InvalidDomainEntityStateException : ApplicationException
    {
        public InvalidDomainEntityStateException(string domainEntityName, Exception? innerException = null) : base($"{domainEntityName} state is invalid.", innerException) { }

        protected InvalidDomainEntityStateException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}