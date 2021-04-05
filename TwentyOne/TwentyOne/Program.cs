using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck = Shuffle(deck);                                  //optional parameter, can change to deck=Shuffle(deck, 3); or any amount of times you want deck shuffled   

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }
        public static Deck Shuffle(Deck deck, int times = 1)        //Deck is type of data returning, Shuffle is name of function, takes parameter of type Deck
        {                                                           //to create an optional paramter, add a default value (int times = 1)
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();             //temporary list to store shuffled items 
                Random random = new Random();

                while (deck.Cards.Count > 0)                        //while loop to shuffle deck
                {
                    int randomIndex = random.Next(0, deck.Cards.Count);
                    TempList.Add(deck.Cards[randomIndex]);
                    deck.Cards.RemoveAt(randomIndex);
                }
                deck.Cards = TempList;
            }
            return deck;                                //returns shuffled deck
        }
        //public static Deck Shuffle(Deck deck, int times) //method to shuffle deck x amount of times
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}
    }
}
