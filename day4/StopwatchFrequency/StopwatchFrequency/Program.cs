using System;
using System.Diagnostics;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Supports High Resolution StopWatch? {0}", Stopwatch.IsHighResolution);
            Console.WriteLine("Stopwatch Frequency? {0}", Stopwatch.Frequency);

            // Pause
            Console.ReadLine();
        }
    }
}