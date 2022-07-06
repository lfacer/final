using System;
using Unit06.Game.Directing;
using Unit06.Game.Services;

/// TEST COMMENT JUNE 6th

namespace Unit06
{
    public class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director(SceneManager.VideoService);
            director.StartGame();
        }
    }
}
