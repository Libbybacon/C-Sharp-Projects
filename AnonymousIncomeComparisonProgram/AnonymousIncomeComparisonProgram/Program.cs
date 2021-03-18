using System;


namespace AnonymousIncomeComparisonProgram
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program\nPerson 1:");
            Console.WriteLine("What is your hourly rate?");
            string hourlyWageRate = Console.ReadLine();
            int hourlyRate = Convert.ToInt32(hourlyWageRate);
            Console.WriteLine("How many hours do you work per week?");
            string weeklyHours = Console.ReadLine();
            int hoursPerWeek = Convert.ToInt32(weeklyHours);
            int weekSalary = hourlyRate * hoursPerWeek;
            int annualSalary = weekSalary * 52;

            Console.WriteLine("Person 2:");
            Console.WriteLine("What is your hourly rate?");
            string hourlyWageRate2 = Console.ReadLine();
            int hourlyRate2 = Convert.ToInt32(hourlyWageRate2);
            Console.WriteLine("How many hours do you work per week?");
            string weeklyHours2 = Console.ReadLine();
            int hoursPerWeek2 = Convert.ToInt32(weeklyHours2);
            int weekSalary2 = hourlyRate2 * hoursPerWeek2;
            int annualSalary2 = weekSalary2 * 52;

            bool salaryComparison = annualSalary2 > annualSalary;

            Console.WriteLine("Annual salary of person 1: " + annualSalary);
            Console.WriteLine("Annual salary of person 2: " + annualSalary2);
            Console.WriteLine("Does person 1 earn more annually than person 2? :" + salaryComparison);
            Console.ReadLine();




        }
    }
}
