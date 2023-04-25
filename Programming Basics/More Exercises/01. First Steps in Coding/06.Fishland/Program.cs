using System;

namespace _06.Fishland
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double skumriqPrice = double.Parse(Console.ReadLine());
            double tsatsaPrice = double.Parse(Console.ReadLine());
            double palamudKg = double.Parse(Console.ReadLine());
            double safridKg = double.Parse(Console.ReadLine());
            double midiKg = double.Parse(Console.ReadLine());
            double palamudPrice = 1.6 * skumriqPrice;
            double safridPrice = 1.8 * tsatsaPrice;
            double midiPrice = 7.5;
            double account = palamudKg * palamudPrice + safridKg * safridPrice + midiKg * midiPrice;
            Console.WriteLine($"{account:f2}");
        }
    }
}
