using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Ask user for age
                Console.WriteLine("Please enter your age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                if(age <= 0)
                {
                    throw new ArgumentException();
                }

                //Display year user was born
                DateTime now = DateTime.Now;
                int thisYear = now.Year;
                int yearBorn = thisYear - age;
                Console.WriteLine("You were born in the year: " + yearBorn);
            }

            //Display error message if user enters 0 or negative numbers
            catch(ArgumentException)
            {
                Console.WriteLine("Please enter an age greater than 0.");
            }

            //Display general message if an exception was caused by anything else
            catch (Exception)
            {
                Console.WriteLine("I'm sorry, your entry is invalid.");
            }
            Console.ReadLine();



        }
    }
}


