using System;
using System.Runtime.Serialization;

namespace EasyMoolah.Model.Exceptions
{
    [Serializable]
    public class RemoveEntityValidationException : Exception
    {
        //
        // For guidelines regarding the creation of new exception types, see
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cpgenref/html/cpconerrorraisinghandlingguidelines.asp
        // and
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dncscol/html/csharp07192001.asp
        //

        public RemoveEntityValidationException()
        {
        }

        public RemoveEntityValidationException(string message) : base(message)
        {
        }

        public RemoveEntityValidationException(string message, Exception inner) : base(message, inner)
        {
        }

        protected RemoveEntityValidationException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}