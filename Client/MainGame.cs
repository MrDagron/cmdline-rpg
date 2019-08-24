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
            int test = 0;
            while(!m_bExitGameLoop)
            {
                if(test++ >= 10) ExitGameLoop(true);
                Console.WriteLine("Running Loop Iteration " + test);
            }
            return true;
        }
    }
}