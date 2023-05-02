using System;

namespace _09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int days = 0;
            int extractedAmount = 0;

            while (yield >= 100)
            {
                extractedAmount += yield;
                extractedAmount -= 26;
                yield -= 10;
                days++;

                if (yield<100)
                {
                    extractedAmount -= 26;
                }
            }

            Console.WriteLine(days);
            Console.WriteLine(extractedAmount);
        }
    }
}
