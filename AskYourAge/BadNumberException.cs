using System;
using System.Collections.Generic;
using System.Text;

namespace AskYourAge
{
    public class BadNumberException : Exception
    {
        public BadNumberException()
            : base() { }
        public BadNumberException(string message)
            : base(message) { }
    }
}
