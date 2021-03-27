using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructPracticeAssignment
{
    class Program
    {
        //Create struct called Number
        public struct Number
        {
            //Give it property 'Amount' of type decimal
            public decimal Amount;
        }

        static void Main(string[] args)
        {
            //Create object of data type Number and assign amount to it
            Number number1;
            number1.Amount = 3;
            Console.WriteLine("The amount of number1 = " + number1.Amount);
            Console.ReadLine();
        }
    }
}
