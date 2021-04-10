using System;
using System.Runtime.Serialization;

namespace Geometric_Figure
{
    public class NotTriangleException:Exception
    {
        public NotTriangleException()
        {
        }

        protected NotTriangleException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public NotTriangleException(string message) : base(message)
        {
        }

        public NotTriangleException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}