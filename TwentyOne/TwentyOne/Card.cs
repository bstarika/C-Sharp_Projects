using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Card
    {
        public Card()                      //constructor method() is always name of the class
        {                                  //represents default values
            Suit = "Spades";                
            Face = "Two";

        }
        public string Suit { get; set; }    //only two things you can do with an object property
        public string Face { get; set; }    //the card class has a property of data type string called Suit, and Face
                                            //and you can get this property or set this property. By making it public, it is available
                                            //to other parts of the program
    }
}
