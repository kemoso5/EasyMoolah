using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace EasyMoolah.Model.Exceptions.Merchant
{
    [Serializable]
    public class MerchantDomainException : Exception
    {
        //
        // For guidelines regarding the creation of new exception types, see
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cpgenref/html/cpconerrorraisinghandlingguidelines.asp
        // and
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dncscol/html/csharp07192001.asp
        //

        public MerchantDomainException()
        {
        }

        public MerchantDomainException(string message) : base(message)
        {
        }

        public MerchantDomainException(string message, Exception inner) : base(message, inner)
        {
        }

        protected MerchantDomainException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}
