using System;
using System.Collections.Generic;


namespace DivisionTryCatchAssignmentUpdated
{
    class Program
    {
        static void Main(string[] args)
        {
            // Put loop in try/catch block
            try
            {
                //Creat list of integers
                List<int> numbers = new List<int>()
            {4,67,12,100,25,30};

                //Ask user for a number to divide each number by in the list.
                Console.WriteLine("I have a secret list of integers.  Please enter a number by which to divide each of my list items.");
                int userNum = Convert.ToInt32(Console.ReadLine());

                //Write a loop that takes each integer in the list, divides it by the user's number, and displays the results.
                foreach (int number in numbers)
                {
                    int result = number / userNum;
                    Console.WriteLine("\nMy number: " + number + "\ndivided by your number: " + userNum + "\nequals: " + result);
                }

            }
            //Display messages for possible errors
            catch (DivideByZeroException)
            {
                Console.WriteLine("Please do not attempt to divide by zero!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a whole number.");
            }
            //Make program print a message to let you know the program has emerged from try/catch and will continue with the program
            Console.WriteLine("Program has emerged with great success from the try/catch block!!  Continuing...");
            Console.ReadLine();

        }
    }
}

        
    

