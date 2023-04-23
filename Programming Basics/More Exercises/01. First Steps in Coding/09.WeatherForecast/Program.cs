using System;

namespace _09.WeatherForecast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string strinG = Console.ReadLine();

            if (strinG == "sunny")
            {
                Console.WriteLine("It's warm outside!");
            }
            else
            {
                Console.WriteLine("It's cold outside!");
            }

        }
    }
}
