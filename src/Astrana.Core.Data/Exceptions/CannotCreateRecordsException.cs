/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Validation.Exceptions;
using System.Runtime.Serialization;

namespace Astrana.Core.Data.Exceptions
{
    [Serializable]
    public class CannotCreateRecordsException : ValidationException
    {
        public CannotCreateRecordsException(Exception inner = null, string message = "Could not create records.") : base(message, inner) { }

        protected CannotCreateRecordsException(SerializationInfo info, StreamingContext context) : base(info, context) { }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
        }
    }
}
