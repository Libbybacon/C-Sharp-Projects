using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsSubmissionAssignment
{
    class Program
    {
        public enum DayOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday

        }

        static void Main(string[] args)
        {

            //Prompt user to enter the current day of the week
            Console.WriteLine("What day of the week is it?");
            string day = Console.ReadLine();
            DayOfWeek dayOfWeek;
            //Use try/catch statement to make sure user enters an actual day of the week
            try
            {
                //Assign user input value to DayOfWeek enum type
                dayOfWeek = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), day);
                Console.WriteLine("Today is: " + day);
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            Console.ReadLine();
            

        }
    }
}
