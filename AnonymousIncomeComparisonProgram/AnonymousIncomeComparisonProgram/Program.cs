using System;


namespace AnonymousIncomeComparisonProgram
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program\nPerson 1:");
            Console.WriteLine("What is your hourly rate?");
            int hourlyRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many hours do you work per week?");
            int hoursPerWeek = Convert.ToInt32(Console.ReadLine());
            int weekSalary = hourlyRate * hoursPerWeek;
            int annualSalary = weekSalary * 52;

            Console.WriteLine("Person 2:");
            Console.WriteLine("What is your hourly rate?");
            int hourlyRate2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many hours do you work per week?");
            int hoursPerWeek2 = Convert.ToInt32(Console.ReadLine());
            int weekSalary2 = hourlyRate2 * hoursPerWeek2;
            int annualSalary2 = weekSalary2 * 52;

            bool salaryComparison = annualSalary > annualSalary2;

            Console.WriteLine("Annual salary of person 1: " + annualSalary);
            Console.WriteLine("Annual salary of person 2: " + annualSalary2);
            Console.WriteLine("Does person 1 earn more annually than person 2? :" + salaryComparison);
            Console.ReadLine();




        }
    }
}
