using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAttributesSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate Math class
            Math myMath = new Math();
            int num1, num2;

            //Get number from user
            Console.WriteLine("Please enter a number: ");
            int.TryParse(Console.ReadLine(), out num1);

            //Call method on user input
            myMath.Divide(num1);

            //Get second number from user
            Console.WriteLine("\nPlease enter a second number: ");
            int.TryParse(Console.ReadLine(), out num2);


            //Call other Divide method on user input
            myMath.Divide(num1, num2);

            //Call out parameter method
            int num3;
            myMath.OutParameter(out num3);
            Console.Write(num3);
            Console.ReadLine();








        }
    }
}
