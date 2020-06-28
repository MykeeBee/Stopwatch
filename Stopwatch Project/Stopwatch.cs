using System;

namespace Stopwatch
{
    class Stopwatch
    {
        public string state = "WAITING";
        public DateTime start;
        public TimeSpan totalTime;

        public void Run()
        {
            var input = Console.ReadLine().ToUpper();

            while (input == "START" || input == "STOP")
            {
                if (input == "START")
                {
                    Start();
                }
                else if (input == "STOP")
                {
                    Stop();
                }

                input = Console.ReadLine().ToUpper();
            }
        }

        public void Start()
        {
            try
            {
                state = "RUNNING";

                start = DateTime.Now;

                State();
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Stopwatch is already running");
            }
        }

        public void Stop()
        {
            try
            {
                state = "WAITING";

                var end = DateTime.Now;

                var duration = end - start;

                totalTime += duration;

                Console.WriteLine("the timer ran for " + duration + " and has run for a total time of " + totalTime);

                State();

            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Stopwatch is already waiting");
            }
        }

        public void State()
        {
            Console.WriteLine("timer is " + state);
        }
    }
}