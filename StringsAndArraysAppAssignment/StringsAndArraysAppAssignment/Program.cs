using System;
using System.Collections.Generic;

// Assignment for C# Course Convering Arrays, Strings, and Iterations:

class Program
{
    static void Main(string[] args)
    {
        ////Create a one-dimensional array of strings.  
        //string[] adjectives = {"purple ", "angry ", "proud ", "funny ", "old ", "smelly ", "delicious "};

        ////Ask user to input some text
        //Console.WriteLine("Please enter a noun:");
        //string userNoun = Console.ReadLine();

        ////Create a loop that iterates through each string in the array and adds user's text input to end of each string
        ////Loop where the comparison that's used to determine whether to continue iterating the loop is a "<" operator
        //for (int i = 0; i < adjectives.Length; i++)
        //{
        //    adjectives[i] = adjectives[i] + userNoun;
        //}
        ////Create a loop that prints off each string in the array on a separate line
        //foreach (string adjective in adjectives)
        //{
        //    Console.WriteLine(adjective);
        //}



        ////List of strings where each item in list is unique
        //List<string> colors = new List<string>()
        //{ "red", "orange", "yellow", "green", "blue", "purple", "pink", "brown", "black", "white" };

        ////Ask user to input text to search for in the list
        //Console.WriteLine("\n\nWhat is your favorite color?");
        //string userFav = Console.ReadLine();

        ////Loop that iterates through list and displays index of list containing matching text
        //foreach (string color in colors)
        //    if (color == userFav)
        //    {
        //        Console.WriteLine("Great choice! " + userFav + " is located at index " + colors.IndexOf(userFav));
             
        //        //Code to stop loop from executing once a match has been found
        //        break;
        //    }
        //    // Code that checks if user entered text that isn't on the list and lets them know if that's the case
        //    else
        //    {
        //        Console.WriteLine("I'm sorry, that color is not on my list.");
        //    }



        //Create a list of strings that has at least two identical strings in the list.  
        //Ask user to select text to search for in the list.
        List<string> pets = new List<string>()
        { "dog", "cat", "fish", "dog", "bird", "dog", "dog", "cat", "bird", "cat", "fish"};
        Console.WriteLine("\n\nWhat kind of pet do you have?");
        string userPet = Console.ReadLine();

        //Create a loop that iterates through the list and displays the indices of the list that contain matching text
        //Add code to the loop to check if user entered text not found on list, and display error message if so
        List<string> petIndices = new List<string>();
        foreach (string pet in pets)
            if (pet == userPet)
            {
                int petIndex = pets.IndexOf(userPet);
                Console.WriteLine(petIndex);
                //petIndices.Add(petIndex);
                //Console.WriteLine(petIndices);
            }
        if (petIndices.Count > 0)
        {
            Console.WriteLine("\"" + userPet + "\"" + " can be found at the following indices in the list of user pets: " + petIndices.ToString());
        }
        

        Console.ReadLine();


        


        

    }
}

