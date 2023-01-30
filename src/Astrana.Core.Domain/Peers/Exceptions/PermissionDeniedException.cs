/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using System.Runtime.Serialization;

namespace Astrana.Core.Domain.Peers.Exceptions
{
    [Serializable]
    public class PermissionDeniedException : ApplicationException
    {
        public PermissionDeniedException(string reason = "Permission denied.", Exception? innerException = null) : base(reason, innerException) { }

        protected PermissionDeniedException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
