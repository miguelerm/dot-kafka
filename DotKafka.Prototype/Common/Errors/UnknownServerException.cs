using System;

namespace DotKafka.Prototype.Common.Errors
{
    public class UnknownServerException : ApiException
    {
        public UnknownServerException() { }

        public UnknownServerException(string message) : base(message) { }

        public UnknownServerException(string message, Exception inner) : base(message, inner) { }
    }
}