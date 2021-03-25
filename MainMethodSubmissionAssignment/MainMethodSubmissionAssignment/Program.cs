using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Math myMath = new Math();

            //Call Math method 'Operation', pass in user's numbers as arguments and display result
            Console.WriteLine("Please enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Please enter a second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            
            int product = myMath.Operation(num1, num2);
            
            Console.WriteLine(num1 + " times " + num2 + " equals: " + product);
            

            //Call second Math method 'Operation', pass in user's decimal value as argument, return int.
            Console.WriteLine("Please enter a decimal value: ");
            decimal num3 = Convert.ToDecimal(Console.ReadLine());

            int square = (int)myMath.Operation(num3);

            Console.WriteLine(num3 + " squared equals: " + square);

            //Call third Math method 'Operation', pass in user's string value as argument, return int.
            Console.WriteLine("Please enter a number: ");
            string num = Console.ReadLine();

            int half = myMath.Operation(num);

            Console.WriteLine("Half of " + num + " is: " + half);
            Console.ReadLine();
        }
    }
}
