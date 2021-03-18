using System;


namespace MathOperationsPracticeApp
{
    class Program
    {
        static void Main()
        {
            // Practicing with math operations

            Console.WriteLine("Please enter a number:");
            string userNum = Console.ReadLine();
            int userNumber = Convert.ToInt32(userNum);
            int times50 = userNumber * 50;
            Console.WriteLine("Your number times 50 = " + times50.ToString());
            Console.ReadLine();

            Console.WriteLine("Please enter a number:");
            string userNum1 = Console.ReadLine();
            int userNumber1 = Convert.ToInt32(userNum1);
            int add25 = userNumber1 + 25;
            Console.WriteLine("Your number plus 25 = " + add25.ToString());
            Console.ReadLine();

            Console.WriteLine("Please enter a number:");
            string userNum2 = Console.ReadLine();
            int userNumber2 = Convert.ToInt32(userNum2);
            float divideBy12Point5 = userNumber2 / (float)12.5;
            Console.WriteLine("Your number divided by 12.5 = " + divideBy12Point5.ToString());
            Console.ReadLine();

            Console.WriteLine("Please enter a number:");
            string userNum3 = Console.ReadLine();
            int userNumber3 = Convert.ToInt32(userNum3);
            bool isGreaterThan50 = userNumber3 > 50;
            Console.WriteLine("Your number is greater than 50: " + isGreaterThan50);
            Console.ReadLine();

            Console.WriteLine("Please enter a number:");
            string userNum4 = Console.ReadLine();
            int userNumber4 = Convert.ToInt32(userNum4);
            int remainder = userNumber4 % 7;
            Console.WriteLine("The remainder of your number divided by 7 is: " + remainder);
            Console.ReadLine();










        }
    }
}
