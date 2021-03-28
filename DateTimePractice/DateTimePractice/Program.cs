using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print current date and time
            DateTime timeNow = DateTime.Now;
            Console.WriteLine(timeNow);
            //Get number from user
            Console.WriteLine("Please enter a number: ");
            int hours = Convert.ToInt32(Console.ReadLine());
            //Display time 'hours' hours from now
            DateTime timeInXHours = timeNow.AddHours(hours);
            Console.WriteLine("The time in {0} hours is: " + timeInXHours, hours);
            Console.ReadLine();
        }
    }
}
