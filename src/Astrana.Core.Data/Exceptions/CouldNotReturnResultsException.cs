using Astrana.Core.Validation.Exceptions;
using System.Runtime.Serialization;

namespace Astrana.Core.Data.Exceptions
{
    /// <summary>
    /// Represents an error that makes it impossible to return results.
    /// </summary>
    [Serializable]
    
    public class CouldNotReturnResultsException : ValidationException
    {
        public CouldNotReturnResultsException(string message, Exception inner) : base(message, inner) { }

        protected CouldNotReturnResultsException(SerializationInfo info, StreamingContext context) : base(info, context) { }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
        }
    }
}
