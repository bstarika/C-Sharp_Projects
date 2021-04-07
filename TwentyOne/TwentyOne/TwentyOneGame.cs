using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneGame : game //to inherit class, use ":"
    {
        public override void Play()  //use overide keyword to "satisfy contract to define this method() from abract class"
        {
            throw new NotImplementedException(); 
        }
        public override void ListPlayers()
        {
            Console.WriteLine("21 Players: ");
            base.ListPlayers();
        }
    }
}
