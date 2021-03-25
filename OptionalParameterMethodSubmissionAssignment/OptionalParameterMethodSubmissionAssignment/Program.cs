using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameterMethodSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate class "Math"
            Math myMath = new Math();
            //Declare variables
            int num1;
            int num2;
            int product;

            //Ask user to input a number:
            Console.WriteLine("Please enter a number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            //Ask user for second, optional, number:
            Console.WriteLine("Please enter a second number (optional): ");
            
            //Check if user entered number:
            if (int.TryParse(Console.ReadLine(), out num2))
            {
                //If user enters second number:
                product = myMath.Multiply(num1, num2);
                Console.WriteLine(num1 + " times " + num2 + " equals: " + product);
            }

            else
            {
                //If user does not enter second number:
                product = myMath.Multiply(num1);
                Console.WriteLine(num1 + " times two equals: " + product);
            }
            Console.ReadLine();





        }
    }
}
