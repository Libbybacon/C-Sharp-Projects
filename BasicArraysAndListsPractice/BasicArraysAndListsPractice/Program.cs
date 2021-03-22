using System;
using System.Collections.Generic;

//List Basics:
//List<int> intList = new List<int>();
//intList.Add(4);
//intList.Add(10);
//intList.Remove(10);
//Console.WriteLine(intList[0]);
//Console.ReadLine();

//List<string> stringList = new List<string>();
//stringList.Add("Hello");
//stringList.Add("Libby");
//stringList.Remove("Hello");
//Console.WriteLine(stringList[0]);
//Console.ReadLine();


 



class Program
{
    static void Main()
    {
        //Create one-dimensional Array of strings with 10 indices
        string[] stringArray = { "ant", "bat", "cat", "dog", "eagle", "fox", "grizzly", "hen", "iguana", "jaguar" };
       
        //Ask user to choose a number:
        Console.WriteLine("Enter a number between 0 and 10 to find the corresponding animal from an array of strings:");
        int stringIndex = Convert.ToInt32(Console.ReadLine());

        //Make sure number is valid
        if (stringIndex >=0 && stringIndex<=10)
        {
            Console.WriteLine("Your number corresponds with \"" + stringArray[stringIndex] + "\" from the array of animals.");
            Console.ReadLine();
        }
        //Or display error message
        else
        {
            Console.WriteLine("Sorry, you entered an invalid index number for this array.");
            Console.ReadLine();
        }

        //Create integer array with 10 indices
        int[] intArray = { 2, 5, 25, 566, 785, 34, 98, 32, 108, 45, 7 };
        Console.WriteLine("Please enter a number between 0 and 10 in order to find the corresponding number in an array of integers:");
       int intIndex = Convert.ToInt32(Console.ReadLine());

        //Make sure user's number falls in correct range
        if(intIndex<=10 && intIndex>=0)
        {
            Console.WriteLine("The value of the number at index " + intIndex + " is: "+ intArray[intIndex]);
            Console.ReadLine();

        }
        //Otherwise print error message
        else
        {
            Console.WriteLine("Sorry, you entered an invalid index number for this array.");
            Console.ReadLine();
        }

        //Create list of strings
        List<string> stringList = new List<string>{ "apple", "banana", "cake", "danish", "egg", "fajita", "grape", "hummus", "icing", "jelly"};

        //Prompt user for input
        Console.WriteLine("Please enter a number between 0 and 10 in order to find the corresponding type of food in an array of strings:");
        int listIndex = Convert.ToInt32(Console.ReadLine());

        //Make sure user's number falls in correct range
        if (listIndex <= 10 && listIndex >= 0)
        {
            Console.WriteLine("The value of the number at index " + listIndex + " is: " + stringList[listIndex]);
            Console.ReadLine();

        }
        //Otherwise print error message
        else
        {
            Console.WriteLine("Sorry, you entered an invalid index number for this array.");
            Console.ReadLine();
        }

    }
}

