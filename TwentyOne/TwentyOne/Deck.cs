using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck
    {                                         
        public Deck()                                                                                 //constructors always go at top of class before properties
        {
              Cards = new List<Card>();                                                               //Cards is referring to property of class, Deck
              List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };    //first create list that contains suits                              
              List<string> Faces = new List<string>()
              {
                    "Two", "Three", "Four", "Five", "Six", "Seven", "Eight",                          //create second list with faces
                    "Nine", "Ten", "Jack", "Queen", "King", "Ace"  
              };
              
              foreach (string face in Faces)                                                          //create nested loop to filter through 52 cards
              {
                    foreach (string suit in Suits)
                    {
                        Card card = new Card();                                                       //create new card
                        card.Suit = suit;
                        card.Face = face;
                        Cards.Add(card);
                    }
              }

        }
        public List<Card> Cards { get; set; }    //property
    }
}
