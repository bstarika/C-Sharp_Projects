using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class player
    {
        public List<Card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }

        public static game operator+ (game game, player player)        //overload an operator
        {
            game.Players.Add(player);
            return game;
        }
        public static game operator -(game game, player player)
        {
            game.Players.Remove(player);
            return game;
        }
    }
}
