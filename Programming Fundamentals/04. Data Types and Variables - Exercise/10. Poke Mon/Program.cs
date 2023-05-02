using System;

namespace _10._Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine()); //n
            int distance = int.Parse(Console.ReadLine()); //m
            int exhaustionFactor = int.Parse(Console.ReadLine()); //y

            int originalPowerValue = power;
            int countOfTargets = 0;

            while (power >= distance)
            {
                power -= distance;
                countOfTargets++;

                if (power * 2 == originalPowerValue && exhaustionFactor > 0)
                {
                    power /= exhaustionFactor;
                }
            }

            Console.WriteLine(power);
            Console.WriteLine(countOfTargets);
        }
    }
}
