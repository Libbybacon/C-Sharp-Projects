using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethodSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate class
            Math myMath = new Math();
            int num1 = 2;
            int num2 = 6;

            //Call method passing in two numbers
            myMath.Square(5, 3);

            //Call method specifying parameters by name
            myMath.Square(num1, num2);

        }
    }
}
