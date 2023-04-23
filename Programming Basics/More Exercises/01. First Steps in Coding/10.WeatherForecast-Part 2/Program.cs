using System;

namespace _10.WeatherForecast_Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double degree = double.Parse(Console.ReadLine());

            /*
            26.00 - 35.00   Hot
            20.1 - 25.9 Warm
            15.00 - 20.00   Mild
            12.00 - 14.9    Cool
            5.00 - 11.9 Cold
            */

            if (degree >= 26 && degree<=35)
            {
                Console.WriteLine("Hot");
            }
            else if (degree >= 20.1 && degree <= 25.9)
            {
                Console.WriteLine("Warm");
            }
            else if (degree >= 15 && degree <= 20)
            {
                Console.WriteLine("Mild");
            }
            else if (degree >= 12 && degree <= 14.9)
            {
                Console.WriteLine("Cool");
            }
            else if (degree >= 5 && degree <= 11.9)
            {
                Console.WriteLine("Cold");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
