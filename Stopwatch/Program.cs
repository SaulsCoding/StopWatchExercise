using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatchcal = new StopwatchCalculations();

            for (var i = 0; i < 2; i++)
            {
                stopwatchcal.Start();
                Thread.Sleep(1000);

                stopwatchcal.Stop();
                Console.WriteLine($"Duration {stopwatchcal.GetInterval()}");

                Console.WriteLine("Press Enter to run the stopwatch one more time.");
                Console.ReadLine();
            }
        }
    }
}
