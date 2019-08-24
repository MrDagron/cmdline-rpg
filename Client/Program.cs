using System;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            MainGame game =  new MainGame();
            game.GameLoop();
        }
    }
}