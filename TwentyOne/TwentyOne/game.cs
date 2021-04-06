using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class game
    {                                             //inheritance
        public List<string> Players { get; set; } //type in propr tab tab
        public string Name { get; set; }
        public string Dealer { get; set; }

        public void ListPlayers()
        {
            foreach (string player in Players) //looping through players property
            {
                Console.WriteLine(player);
            }
        }
    }
}
