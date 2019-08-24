using System;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ListenSocket listener = new ListenSocket(11111);
        }
    }
}
