using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentTesting
{

    //Make a public class to align teams to a game-row
    public class Game
    {
        public int gameNum { get; set; }
        public Team homeTeam { get; set; }
        public Team awayTeam { get; set; }
        public double spread { get; set; }
        public DateTime gameTime { get; set; }
    }
}
