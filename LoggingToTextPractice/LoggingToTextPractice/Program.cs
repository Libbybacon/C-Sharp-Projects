using System;
using System.IO;


namespace LoggingToTextPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            string number = Console.ReadLine();
            //Log text to file
            File.WriteAllText(@"C:\Users\Libby\Documents\21Log.txt", number);
            //Read text from file and display in console
            string getNumber = File.ReadAllText(@"C:\Users\Libby\Documents\21Log.txt");
            Console.WriteLine(getNumber);
            Console.ReadLine();
        }
    }
}
