using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int MyProperty { get; set; }
        public int Balance { get; set; }

        public void Deal (List<Card> Hand) //dealer class the ability to deal, takes in parameter a list of cards, or a hand
        {
            Hand.Add(Deck.Cards.First()); //hand is list, added card to hand, and first() is a method available to list which takes very first item in that list
            Console.WriteLine(Deck.Cards.First().ToString() + "\n");
            Deck.Cards.RemoveAt(0); //taking first item out of deck after its printed to console and giving to hand
        }
    }
}
