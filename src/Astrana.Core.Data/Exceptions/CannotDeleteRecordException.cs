using Astrana.Core.Framework.Model.Validation.Exceptions;
using System.Runtime.Serialization;

namespace Astrana.Core.Data.Exceptions
{
    [Serializable]
    public class CannotDeleteRecordsException : ValidationException
    {
        public CannotDeleteRecordsException(Exception inner, string message = "Could not delete records.") : base(message, inner) { }
        
        protected CannotDeleteRecordsException(SerializationInfo info, StreamingContext context) : base(info, context) { }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
        }
    }
}
