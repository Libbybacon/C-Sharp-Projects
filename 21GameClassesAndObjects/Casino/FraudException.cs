using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class FraudException : Exception
    {
        //Create two constructors that implement same implementation that exists for Exception
        public FraudException()
            : base() { }

        public FraudException(string message)
            : base(message) { }
    }
}
