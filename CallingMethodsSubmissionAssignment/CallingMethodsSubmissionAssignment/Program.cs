using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask user for a number to perform math operations on
            Console.WriteLine("Please enter a number to do math operations on: ");
            int userNum = Convert.ToInt32(Console.ReadLine());

            // Call each method in turn, passing user input to the method.  Display returned int
            int sum = Math.AddTwo(userNum);
            Console.WriteLine(userNum + " plus two equals: " + sum);

            int product = Math.MultiplyByTwo(userNum);
            Console.WriteLine(userNum + " times two equals: " + product);

            int quotient = Math.DivideByTwo(userNum);
            Console.WriteLine(userNum + " divided by two equals: " + quotient);

            Console.ReadLine();
        }
    }
}
