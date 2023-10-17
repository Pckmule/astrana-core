using Astrana.Core.Framework.Model.Validation.Exceptions;
using System.Runtime.Serialization;

namespace Astrana.Core.Data.Exceptions
{
    [Serializable]
    public class CannotUpdateRecordsException : ValidationException
    {
        public CannotUpdateRecordsException(Exception inner, string message = "Could not update records.") : base(message, inner) { }
        
        protected CannotUpdateRecordsException(SerializationInfo info, StreamingContext context) : base(info, context) { }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
        }
    }
}
