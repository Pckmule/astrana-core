/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using System.Runtime.Serialization;

namespace Astrana.Core.Domain.IdentityAccessManagement.Exceptions
{
    [Serializable]
    public class ApplicationUserNotFoundException : ApplicationException
    {
        public ApplicationUserNotFoundException(string message = "Application User not found.", Exception? innerException = null) : base(message, innerException) { }

        protected ApplicationUserNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
