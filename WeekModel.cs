using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentTesting
{
    //Make a public class to hold Week data, including each week's list of teams/games
    public class Week
        {
            public int weekNumber { get; set; }
            public List<Game> weekGames { get; set; }
        }
}
