using System;


namespace DailyReport
{
    class Program
    {
        static void Main()
        {
            // Print two lines to console
            Console.WriteLine("The Tech Academy \nStudent Daily Report");

            // Ask user questions and save answers to variables with appropriate data type
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            //Console.WriteLine(userName);

            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
            //Console.WriteLine(courseName);

            Console.WriteLine("What page number?");
            string pageNum = Console.ReadLine();
            int pageNumber = Convert.ToInt32(pageNum);
           
            Console.WriteLine("Do you need help with anything?  Please answer \"true\" or \"false\"");
            string needHelp = Console.ReadLine();
            bool doesNeedHelp = Convert.ToBoolean(needHelp);

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string posVibes = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string hours = Console.ReadLine();
            int hoursStudied = Convert.ToInt32(hours);

            Console.WriteLine("Thank you for your answers.  An instructor will respond to this shortly.  Have a great day!");
            Console.ReadLine();

        }
    }
}
