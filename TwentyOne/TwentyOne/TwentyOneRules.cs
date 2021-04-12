using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneRules //create a business logic layer. A layer is essentially a class that exists without knowledge of other classes
                                //has functions or features to it that will contain the rules of the game
                                //it is a static class: dont have to create an object.
                                //contains methods that we can call that contains logistics for game
    {
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>()  //private reserved for class, static so you don't have to create TwentyOneRules object (helper methods to perform logic inside of game)
        {                                                                               //naming convention in private classes is using an underscore _
                                                                                        //create a dictionary with key/value pairs and instatiate it with all objects
                                                                                        //dictionary chosen over enum as enum cannot be assigned same values 
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
            [Face.Ace] = 1                                                              //player determines if ace equals 1 or 11, will be defined below
        };
        //create method that will check for blackjack
        //method will get all blackjack values and return integer array
        private static int[] GetAllPossibleHandValues(List<Card> Hand)
        {
            int aceCount = Hand.Count(x => x.Face == Face.Ace);                        //LAMBDA expression 
            int[] result = new int[aceCount + 1];                                      //array passes in value of how many aces there are
            int value = Hand.Sum(x => _cardValues[x.Face]);                            //get value of lowest possible value there is where Ace has default value of 1,
            result[0] = value;                                                         //use LAMBDA expression that looks up card value in dictionary and sum it
            if (result.Length == 1)                                                    //if there are no aces then you know there is only ONE possible value
            {
                return result;
            }
            for (int i = 1; i < result.Length; i++)                                    //for loop will iterate through putting in different values of ace
            {
                value += (1 * 10);                                                     //same thing as writing value = value + (1 * 10), for each ace we take its value + 1 x 10
                result[i] = value;
            }
            return result;
        }


        public static bool CheckForBlackJack(List<Card> Hand)
        {
            int[] possibleValues = GetAllPossibleHandValues(Hand);                    //create integer array of possible values and use method above 
            int value = possibleValues.Max();                                         //check for largest value after two cards have been passed
            if (value == 21) return true;                                             //blackjack!
            else return false;
        }

        public static bool IsBusted(List<Card> Hand)                                  //method for when player goes over 21
        {
            int value = GetAllPossibleHandValues(Hand).Min();                         //dont care if max value busted, if minumum value busts then we know all values bust
            if (value > 21) return true;
            else return false;
        }

        public static bool ShouldDealerStay(List<Card> Hand)                          //new method to determine if dealer is staying, pass in card
        {
            int[] possibleHandValues = GetAllPossibleHandValues(Hand);                //get possible hand values 
            foreach (int value in possibleHandValues)                                 //checks dealers cards for total 16-21 as dealer would have to stay
            {
                if (value > 16 && value < 22)
                {
                    return true;
                }
            }
            return false;                                                              //dealer should not stay
        }
        public static bool? CompareHands(List<Card> PlayerHand, List<Card> DealerHand) //new method to determine who is closest to 21
        {
            int[] playerResults = GetAllPossibleHandValues(PlayerHand);                //array
            int[] dealerResults = GetAllPossibleHandValues(DealerHand);                //array

            int playerScore = playerResults.Where(x => x < 22).Max();                  //lists player results where results are less than 22, and show largest value
            int dealerScore = dealerResults.Where(x => x < 22).Max();                  //comparing highest possible score without busting
            if (playerScore > dealerScore) return true;
            else if (playerScore < dealerScore) return false;
            else return null;                                                          //this is if they TIE
        }

        //find value in each array thats less than 21
    }
}
