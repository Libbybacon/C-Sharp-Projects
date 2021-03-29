using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21GameClassesAndObjects
{
    class Practice

    {
        //Card constructor:
        //public Card()
        //{
        //    Suit = "Spades";
        //    Face = "Two";
        //}


        //  OVERRIDE OPERATORS  //

        //Using over-ridden operators to add/remove player
        //Game game = new TwentyOneGame();
        //game.Players = new List<Player>();
        //Player player = new Player();
        //player.Name = "Phoeny";
        //game += player;
        //game -= player;


        //  ENUM //

        //Card card = new Card();
        //card.Suit = Suit.Clubs;
        ////Cast enum to int to see what it's int value is
        //int underlyingValue = (int)(Suit.Clubs);
        //Console.WriteLine(underlyingValue);


        //   LAMBDA FUNCTIONS //

        ////lambda function to find how many aces are in deck
        //int count = deck.Cards.Count(x => x.Face ==Face.Ace);

        ////lambda function to create list of only king cards
        //List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();
        //foreach (Card card in newList)
        //{
        //    Console.WriteLine(card.Face);
        //}

        ////Lambda functions with int List
        //List<int> numberList = new List<int>() { 1, 2, 3, 400, 342, 23 };
        ////Sum all items in list
        //int sum = numberList.Sum();
        ////Add 5 to sum of numbers in list
        //int sum2 = numberList.Sum(x => x + 5);
        ////Find largest number in list
        //int sum3 = numberList.Max();
        ////Find all numbers over 20 in the list and then sum that list
        //int sum4 = numberList.Where(x => x > 20).Sum();
        //Console.WriteLine(sum);


        // IO //

        //string text = "Here is some text.";
        //File.WriteAllText(@"C:\Users\Libby\Documents\21Log.txt", text);
        //string text = File.ReadAllText(@"C:\Users\Libby\Documents\21Log.txt");

        // DATETEIME //

        //DateTime yearOfBirth = new DateTime(1995, 5, 23, 8, 32, 45);
        //DateTime yearOfGraduation = new DateTime(2013, 6, 1, 16, 34, 22);

        //TimeSpan ageAtGraduation = yearOfGraduation - yearOfBirth;
        //Console.WriteLine(ageAtGraduation);
        //    Console.ReadLine();

        // VAR //

        //var newDictionary = new Dictionary<string, string>();
        // vs. Dictionary<string,string> newDictionary = new Dictionary<string,string>();

        


    }
}
