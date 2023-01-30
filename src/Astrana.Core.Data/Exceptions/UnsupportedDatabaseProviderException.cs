﻿/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using System.Runtime.Serialization;

namespace Astrana.Core.Data.Exceptions
{
    [Serializable]
    public class UnsupportedDatabaseProviderException : ApplicationException
    {
        public UnsupportedDatabaseProviderException(string message) : base(message) { }

        public UnsupportedDatabaseProviderException(string message, Exception inner) : base(message, inner) { }

        protected UnsupportedDatabaseProviderException(SerializationInfo info, StreamingContext context) : base(info, context) { }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
        }
    }
}