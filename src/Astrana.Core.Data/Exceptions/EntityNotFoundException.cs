/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using System.Runtime.Serialization;

namespace Astrana.Core.Data.Exceptions
{
    [Serializable]
    public class EntityNotFoundException : ApplicationException
    {
        public EntityNotFoundException(string message = "Date Entity not found.", Exception? innerException = null) : base(message, innerException) { }

        protected EntityNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
