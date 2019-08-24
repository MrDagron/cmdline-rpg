using System;

namespace cmdline_game
{
    public class MainGame
    {
        private bool m_bExitGameLoop = false;
        public void ExitGameLoop(bool shouldExit)
        {
            m_bExitGameLoop = shouldExit;
        }
       public bool GameLoop()
        {
            while(!m_bExitGameLoop)
            {
                switch(MainMenu())
                {
                case 1:
                    Console.WriteLine("Game Started!");
                    break;
                case 2:
                    Console.WriteLine("Enter Server IP Address");
                    string ip = Console.ReadLine();
                    Console.WriteLine("Enter Server Port");
                    int port = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Connected to " + ip + ":" + port);
                    ClientSocket sock = new ClientSocket(ip, port);
                    Console.WriteLine("Connected to server!");
                    break;
                case 3:
                    Console.WriteLine("Exiting the game!");
                    ExitGameLoop(true);
                    break;
                }
            }
            Console.WriteLine("Thanks for playing!");
            return true;
        }
        int MainMenu()
        {
            string menu = "Welcome! Please select a number:\n"
            + "1) Start Game\n"
            + "2) Connnect to Server\n"
            + "3) Exit Game\n";
            Console.Write(menu);
            int selection = Int32.Parse(Console.ReadLine());
            switch(selection)
            {
                case 1:
                    return 1;
                case 2:
                    return 2;
                case 3:
                    return 3;
                default:
                    return 0;
            }
        }
    }
}