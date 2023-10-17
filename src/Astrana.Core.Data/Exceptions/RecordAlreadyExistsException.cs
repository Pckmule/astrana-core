using Astrana.Core.Framework.Model.Validation.Exceptions;
using System.Runtime.Serialization;

namespace Astrana.Core.Data.Exceptions
{
    [Serializable]
    public class RecordAlreadyExistsException : ValidationException
    {
        public RecordAlreadyExistsException(string message, Exception inner) : base(message, inner) { }

        private RecordAlreadyExistsException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
