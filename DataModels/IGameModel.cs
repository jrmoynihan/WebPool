using System;

namespace ComponentTesting
{
    public interface IGameModel
    {
        Team homeTeam { get; set; }
        Team awayTeam { get; set; }
        DateTime gameTime { get; set; }
        int gameNum { get; set; }
        double spread { get; set; }
    }
}