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
            //Call Math method 'Operation', pass in user's numbers as arguments and display result
            Console.WriteLine("Please enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Please enter a second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            
            int product = Math.Operation(num1, num2);
            
            Console.WriteLine(num1 + " times " + num2 + " equals: " + product);
            

            //Call second Math method 'Operation', pass in user's decimal value as argument, return int.
            Console.WriteLine("Please enter a decimal value: ");
            decimal num3 = Convert.ToDecimal(Console.ReadLine());

            int square = (int)Math.Operation(num3);

            Console.WriteLine(num3 + " squared equals: " + square);

            //Call third Math method 'Operation', pass in user's string value as argument, return int.
            Console.WriteLine("Please enter a number: ");
            string num = Console.ReadLine();

            int half = Convert.ToInt32(num) / 2;

            Console.WriteLine("Half of " + num + " is: " + half);
            Console.ReadLine();
        }
    }
}
