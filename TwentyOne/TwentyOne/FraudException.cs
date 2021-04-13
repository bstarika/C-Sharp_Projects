using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class FraudException : Exception //created two constructors, one of them overloading the other and having them implement the exact same implementation that exists for exception
    {
        public FraudException()
            : base() { }
        public FraudException(string message) //takes in arguement, message
            : base(message) { } 
    }
}
