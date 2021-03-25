using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameterMethodSubmissionAssignment
{
    public class Math
    {
        //Create a method that takes two ints as parameters
        //Make one of them optional
        //Have the method do a math operation and return in result
        public int Multiply(int num1, int num2 = 2)
        {
            int product = num1 * num2;
            return product;

        }

    }
}
