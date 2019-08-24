using System;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a port you want to listen to:");
            int port = Int32.Parse(Console.ReadLine());
            ListenSocket listener = new ListenSocket(port);
        }
    }
}
