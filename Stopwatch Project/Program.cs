using System;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("type \"start\" to start the timer and then \"stop\" to stop it running");

            var steve = new Stopwatch();
            steve.Run();
        }
    }
}