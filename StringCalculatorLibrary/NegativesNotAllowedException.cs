using System;
using System.Collections.Generic;
using System.Text;

namespace StringCalculatorLibrary
{
    public class NegativesNotAllowedException : Exception
    {
        public NegativesNotAllowedException(string message)
            : base(message) { }

        public NegativesNotAllowedException() { }
    }
}
