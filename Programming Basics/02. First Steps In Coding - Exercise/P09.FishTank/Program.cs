using System;

namespace P09.FishTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double litersOfWater = (0.001 * length * width * height) - (0.01 * percent * 0.001 * length * width * height);
            Console.WriteLine(litersOfWater);
        }
    }
}
