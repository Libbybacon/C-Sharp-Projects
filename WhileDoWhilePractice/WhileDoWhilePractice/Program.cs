using System;


namespace WhileAndDoWhilePractice
{
    class Program
    {
        static void Main()
        {
            // While loop that basically just counts up to the number the user chooses
            Console.WriteLine("Please enter a number between 1 and 50:");
            int num = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (i < num)
            {
                Console.WriteLine("You did not pick the number " + i.ToString());
                    i++;
            }
            Console.WriteLine("You picked the number " + num.ToString() + "!!!\n");

            //Do While statement that counts down to from 50 to the chosen number
            Console.WriteLine("Please enter another number between 1 and 50:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int count = 50;
            do
            {
                Console.WriteLine(count.ToString() + " is not your number.");
                count--;
            } while (count > num2);
            Console.WriteLine(num2.ToString() + " is your number!!");
            Console.Read();



        }
    }
}