using System;

namespace ShippingQuote
{
    class Program
    {
        static void Main()
        {   // Get package weight from user and determine whether or not it is too big to ship
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below:\nHow much does your package weigh?");
            int packageWeight = Convert.ToInt32(Console.ReadLine());
            string shippability = packageWeight > 50 ? "Package too heavy to be shipped via Package Express.  Have a good day." : "Package width:";
            
            // Get package dimensions from user
            Console.WriteLine(shippability);
            int packageWidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Package height?");
            int packageHeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Package length?");
            int packageLength = Convert.ToInt32(Console.ReadLine());

            decimal totalSize = packageWidth * packageHeight * packageLength;

            if (packageWidth > 50 || packageHeight > 50 || packageLength > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
            }
            else
            {
                decimal quote = totalSize * packageWeight / 100;
                Console.WriteLine("The estimated price to ship this package is : $" + quote);
                Console.ReadLine();
            }



        }
    }
}
