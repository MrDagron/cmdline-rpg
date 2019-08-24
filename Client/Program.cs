using System;
using cmdline_rpg.test_folder;

namespace cmdline_game
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