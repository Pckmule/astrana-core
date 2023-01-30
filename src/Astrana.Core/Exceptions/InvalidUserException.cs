/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using System.Runtime.Serialization;

namespace Astrana.Core.Exceptions
{
    [Serializable]
    public class InvalidUserException : ApplicationException
    {
        public InvalidUserException(string message = "User is invalid.", Exception? innerException = null) : base(message, innerException) { }

        protected InvalidUserException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
