using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21GameClassesAndObjects
{
    public class Deck
    {
        public Deck()
        {
            //Instantiate list of cards
            Cards = new List<Card>();
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four", "Five", "Six", "Seven",
                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };

            //For each item in the Faces list
            foreach (string face in Faces)
            {
                //Combine it with each item from the Suits list and add that new card to the list Cards
                foreach (string suit in Suits)
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);
                }
            }
        }
        public List<Card> Cards { get; set; }

        //Method to shuffle deck, takes in times parameter for how many times to shuffle
        public void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                //New list to hold values of shuffled cards
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                //Go through deck, pick random card based on index, add that card to the templist
                //and remove it from deck until all cards have been removed
                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                //Set list of Cards equal to the values in the TempList
                Cards = TempList;
            }
        }
    }
}
