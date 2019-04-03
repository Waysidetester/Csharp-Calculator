using System;

namespace Calculator
{
    public class InvalidInputException : Exception
    {
        public InvalidInputException() : base("The input received was Invalid")
        {}
    }
}
