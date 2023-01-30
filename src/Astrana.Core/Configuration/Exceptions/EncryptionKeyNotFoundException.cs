/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using System.Runtime.Serialization;

namespace Astrana.Core.Configuration.Exceptions
{
    [Serializable]
    public class EncryptionKeyNotFoundException : ApplicationException
    {
        public EncryptionKeyNotFoundException(string message = "Encryption key not found.", Exception innerException = null) : base(message, innerException) { }

        protected EncryptionKeyNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
