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
            deck = Shuffle(deck);
        
            foreach(Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }
        public static Deck Shuffle(Deck deck)           //Deck is type of data returning, Shuffle is name of function, takes paramter of type Deck
        {
            List<Card> TempList = new List<Card>();     //temporary list to store shuffled items 
            Random random = new Random();

            while (deck.Cards.Count>0)                  //while loop to shuffle deck
            {
                int randomIndex = random.Next(0, deck.Cards.Count);
                TempList.Add(deck.Cards[randomIndex]);
                deck.Cards.RemoveAt(randomIndex);
            }                                           
            deck.Cards = TempList;
            return deck;                                //returns shuffled deck
        }
    }
}
