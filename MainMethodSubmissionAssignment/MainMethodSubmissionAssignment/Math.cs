using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodSubmissionAssignment
{
    public class Math
    {
        

        //Create a method that will take in an integer and perform a math operation
        public int Operation(int num1, int num2)
        {
            int product = num1 * num2;
            return product;
        }

        //Create second method with the same name that will take in a decimal,
        //create a different math operation for it, return answer as integer
        public decimal Operation(decimal num)
        {
            int square = Convert.ToInt32(num * num);
            return square;
        }

        //Create a third method with the same name that will take in a string,
        //convert it to an integer if possible, do a different math operation on it,
        //return answer as int
        public int Operation(string num)
        {
            int half = Convert.ToInt32(num) / 2;
            return half;
        }
    }
}
