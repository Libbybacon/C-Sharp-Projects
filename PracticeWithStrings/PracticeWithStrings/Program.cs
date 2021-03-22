using System;
using System.Text;


namespace PracticeWithStrings
{
    class Program
    {
        static void Main()
        {
            // Collect input from user to create a new email address for them
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("\nWhat is your middle initial?");
            string middleInit = Console.ReadLine();

            Console.WriteLine("\nWhat is your last name?");
            string lastName = Console.ReadLine();

            Console.WriteLine("\nYour new email address is: " + firstName + middleInit.ToUpper() + lastName + "@newEmail.com");
            Console.ReadLine();

            // Create StringBuilder than can have up to 200 characters
            StringBuilder sb = new StringBuilder("This is the beginning of the string builder-built string...", 200);

            // Add more sentences
            sb.Append("This is the second sentence of the String Builder. ");
            sb.Append("Wow!  This is a whole other third sentence? ");
            sb.Append("Ok this is the end.  I did it woohoo.");
            Console.WriteLine(sb);
            Console.ReadLine();



        }
    }
}
