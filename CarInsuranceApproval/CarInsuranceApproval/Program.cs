using System;


namespace CarInsuranceApproval
{
    class Program
    {
        static void Main()
        {
            // Prompt user with questions about driving status to determine whether they are qualified for insurance
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? please answer true or false.");
            bool DUI = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            int speedTix = Convert.ToInt32(Console.ReadLine());

            bool qualified = age > 15 && DUI == false && speedTix <= 3;
            Console.WriteLine("This driver is qualified: " + qualified);
            Console.ReadLine();


        }
    }
}
