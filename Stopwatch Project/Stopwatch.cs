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
                if (state == "RUNNING")
                    throw new InvalidOperationException("Stopwatch is already running");
            }
            catch (Exception)
            {
            }
            finally
            {
                state = "RUNNING";

                start = DateTime.Now;

                State();
            }
        }

        public void Stop()
        {
            try
            {
                if (state == "WAITING")
                    throw new InvalidOperationException("Stopwatch is already waiting");
                
            }
            catch (Exception)
            {
            }
            finally
            {
                state = "WAITING";

                var end = DateTime.Now;

                var duration = end - start;

                totalTime += duration;

                Console.WriteLine("the timer ran for " + duration + " and has run for a total time of " + totalTime);

                State();
            }
        }

        public void State()
        {
            Console.WriteLine("timer is " + state);
        }
    }
}