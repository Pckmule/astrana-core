/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using System.Runtime.Serialization;

namespace Astrana.Core.Localization.Exceptions
{
    [Serializable]
    public class TranslationsFileNotFoundException : ApplicationException
    {
        public TranslationsFileNotFoundException(string message = "Translations file not found.", Exception? innerException = null) : base(message, innerException) { }

        protected TranslationsFileNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
