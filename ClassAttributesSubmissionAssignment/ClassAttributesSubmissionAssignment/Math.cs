using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAttributesSubmissionAssignment
{
    public class Math
    {
        //Create void method that outputs an int
        //Method divides data passed to it by 2
        public void Divide(int num1)
        {
            int half = num1 / 2;
            Console.WriteLine("Your number divided by two is: " + half);
        }

        //Overload Divide method with one that has two parameters 
        
        public void Divide(int num1, int num2)
        {
            int quotient = num1 / num2;
         
            Console.WriteLine(num1 + " divided by " + num2 + " equals: " + quotient);
        }

        //Create a method with output parameters
        public void OutParameter(out int num3)
        {
            num3 = 6;
      
        }

        //Declare a class to be static
        public static class MyClass
        {

        }
    }
}
