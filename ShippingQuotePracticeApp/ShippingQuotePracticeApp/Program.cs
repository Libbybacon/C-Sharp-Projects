using System;


namespace ShippingQuotePracticeApp
{
    class Program
    {
        static void Main()
        {
            // Get package weight from user and determine whether or not it is too big to ship
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below:\nHow much does your package weigh?");
            decimal packageWeight = Convert.ToDecimal (Console.ReadLine());
            // If the package weight is greater than 50, print error message and exit program
            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.  Have a good day.");
                Console.Read();
                Environment.Exit(0);        
            }
            // If package weight is less than 50, prompt user for size dimensions
            else
            {
                Console.WriteLine("What is the package width?");
                decimal packageWidth = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Package height?");
                decimal packageHeight = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Package length?");
                decimal packageLength = Convert.ToDecimal(Console.ReadLine());

                decimal sumDimensions = packageWidth + packageHeight + packageLength;
                decimal totalSize = packageWidth * packageHeight * packageLength;

                // Check if sum of package dimensions is less than 50
                if (sumDimensions > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                // Calculate and display shipping quote
                else
                {
                    decimal quote = totalSize * packageWeight / 100;
                    Console.WriteLine("The estimated price to ship this package is: $" + quote);
                    Console.ReadLine();
                }
            }
            

        }
    }
}
