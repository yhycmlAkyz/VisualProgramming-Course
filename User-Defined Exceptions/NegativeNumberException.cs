using System;

namespace ExceptionHandlingApp
{
    public class NegativeNumberException : Exception
    {
        public NegativeNumberException()
            : base("Illegal operation for a negative number") { }

        public NegativeNumberException(string message)
            : base(message) { }

        public NegativeNumberException(string message, Exception inner)
            : base(message, inner) { }
    }
}