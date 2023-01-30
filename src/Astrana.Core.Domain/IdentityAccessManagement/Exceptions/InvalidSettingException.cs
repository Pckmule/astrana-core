/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using System.Runtime.Serialization;

namespace Astrana.Core.Domain.IdentityAccessManagement.Exceptions
{
    [Serializable]
    public class InvalidSettingException : ApplicationException
    {
        public InvalidSettingException(string settingName, Exception? innerException = null) : base($"{settingName} setting is invalid", innerException) { }

        protected InvalidSettingException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
