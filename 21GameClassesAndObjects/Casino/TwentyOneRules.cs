using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casino;

namespace Casino.TwentyOne

{
    class TwentyOneRules
    {
        //Create private dictionary that assigns values to each of the Faces
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>()
        {
            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1,
        };

        //Method to show possible values of hand (there will be 2 if there is an ace)
        private static int[] GetAllPossibleHandValues(List<Card> Hand)
        {
            //Find how many aces are in the hand
            int aceCount = Hand.Count(x => x.Face == Face.Ace);

            //Create new empty array that can hold possible hand value results
            int[] result = new int[aceCount + 1];

            //Find lowest possible sum of values of cards in hand (Ace = 1)
            int value = Hand.Sum(x => _cardValues[x.Face]);
            result[0] = value;

            //If there is only one ace
            if (result.Length == 1)
            {
                return result;
            }

            //If there are two aces
            for (int i = 1; i < result.Length; i++)
            {
                value += (i * 10);
                result[i] = value;
            }
            return result;
        }

        //Method to check for blackjack, takes in a hand
        public static bool CheckForBlackJack(List<Card> Hand)
        {
            //Int array of possible values
            int[] possibleValues = GetAllPossibleHandValues(Hand);
            //Check for max value
            int value = possibleValues.Max();
            //If max value is 21
            if (value == 21) return true;
            else return false;
        }

        //Method to check for bust
        public static bool IsBusted(List<Card> Hand)
        {
            //Lambda expression to check for minimum value of hand
            int value = GetAllPossibleHandValues(Hand).Min();
            if (value > 21) return true;
            else return false;
        }

        //Method to check whether Dealer should stay
        public static bool ShouldDealerStay(List<Card> Hand)
        {
            //Check possible hand values
            int[] possibleHandValues = GetAllPossibleHandValues(Hand);
            //See if one possible hand value is between 16 and 22
            foreach (int value in possibleHandValues)
            {
                //If so, Dealer should stay
                if (value > 16 && value <22)
                {
                    return true;
                }
            }
            return false;
        }

        //Method to compare player and dealer hands.  Returns nullable bool
        public static bool? CompareHands(List<Card> PlayerHand, List<Card> DealerHand)
        {
            //Get int arrays of possible player and dealer hand results
            int[] playerResults = GetAllPossibleHandValues(PlayerHand);
            int[] dealerResults = GetAllPossibleHandValues(DealerHand);

            //Find highest possible hand values for player and dealer that are less than 21
            int playerScore = playerResults.Where(x => x < 22).Max();
            int dealerScore = dealerResults.Where(x => x < 22).Max();

            //Compare scores
            if (playerScore > dealerScore) return true;
            else if (playerScore < dealerScore) return false;
            else return null;

        }

    }
}
