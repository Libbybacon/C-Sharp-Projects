using System;
using System.Collections.Generic;

// Assignment for C# Course Convering Arrays, Strings, and Iterations:

class Program
{
    static void Main(string[] args)
    {
        //Create a one-dimensional array of strings.  
        string[] adjectives = { "purple ", "angry ", "proud ", "funny ", "old ", "smelly ", "delicious " };

        //Ask user to input some text
        Console.WriteLine("Please enter a noun:");
        string userNoun = Console.ReadLine();

        //Create a loop that iterates through each string in the array and adds user's text input to end of each string
        //Loop where the comparison that's used to determine whether to continue iterating the loop is a "<" operator
        for (int i = 0; i < adjectives.Length; i++)
        {
            adjectives[i] = adjectives[i] + userNoun;
        }
        //Create a loop that prints off each string in the array on a separate line
        foreach (string adjective in adjectives)
        {
            Console.WriteLine(adjective);
        }



        //List of strings where each item in list is unique
        List<string> colors = new List<string>()
        { "red", "orange", "yellow", "green", "blue", "purple", "pink", "brown", "black", "white" };

        //Ask user to input text to search for in the list
        Console.WriteLine("\n\nWhat is your favorite color?");
        string userFav = Console.ReadLine();

        //Loop that iterates through list and displays index of list containing matching text
        bool found = false;
        while (found == false)
        {
            if (colors.Contains(userFav))
            {
                Console.WriteLine("Great choice, " + userFav + " is located at index " + colors.IndexOf(userFav));
                //Add code to loop that stops it from executing once match is found
                found = true;
            }
            // Code that checks if user entered text that isn't on the list and lets them know if that's the case
            else if (!colors.Contains(userFav))
            {
                Console.WriteLine("I'm sorry, that color is not on my list.");
            }
        }

        //Create a list of strings that has at least two identical strings in the list.  
        List<string> pets = new List<string>()
        { "dog", "cat", "fish", "dog", "bird", "dog", "dog", "cat", "bird", "cat", "fish"};

        //Ask user to enter text to search for in the list.
        Console.WriteLine("\n\nWhat kind of pet do you have?");
        string userPet = Console.ReadLine();

        //Create a loop that iterates through the list and displays the indices of the list that contain matching text
        
        List<int> petIndices = new List<int>();
        int counter = 0;
        int index = 0;
        foreach (string pet in pets)
        {
            if (userPet == pet)
            {
                petIndices.Add(index);
                counter ++;
            }
            index++;
        }
        //Add code to the loop to check if user entered text not found on list, and display error message if so
        if (counter == 0)
        {
            Console.WriteLine("Sorry, that item is not in the list.");
        }
        else if (counter > 0)
        {
            Console.WriteLine("\"" + userPet + "\"" + " was found at the following indices: ");
            petIndices.ForEach(Console.WriteLine);
            

        }

        //Create a foreach loop that evaluates each item in the list and displays a message showing string
        //and whether or not it has already appeared in the list
        Console.WriteLine("\n\n");
        List<string> inList = new List<string>();
        foreach (string pet in pets) 
        {
            if (inList.Contains(pet))
            {
                Console.WriteLine("\"" + pet + "\"" + " has already appeared in this list.\n");
            }
            else
            {
                Console.WriteLine("\"" + pet + "\"" + " has not appeared in the list before.\n");
                inList.Add(pet);
            }

        }

        Console.ReadLine();


        


        

    }
}

