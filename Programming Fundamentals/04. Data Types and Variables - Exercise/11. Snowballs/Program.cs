using System;
using System.Numerics;

namespace _11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger madeSnowballs = int.Parse(Console.ReadLine());
            BigInteger highestSnowballSnow = int.MinValue;
            BigInteger highestSnowballTime = int.MinValue;
            BigInteger highestSnowballQuality = int.MinValue;
            BigInteger highestSnowballValue = int.MinValue;

            for (int i = 0; i < madeSnowballs; i++)
            {
                BigInteger snowballSnow = int.Parse(Console.ReadLine());
                BigInteger snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);

                if (snowballValue >= highestSnowballValue)
                {
                    highestSnowballSnow = snowballSnow;
                    highestSnowballTime = snowballTime;
                    highestSnowballQuality = snowballQuality;
                    highestSnowballValue = snowballValue;
                }
            }

            Console.WriteLine($"{highestSnowballSnow} : {highestSnowballTime} = {highestSnowballValue} ({highestSnowballQuality})");
        }
    }
}
