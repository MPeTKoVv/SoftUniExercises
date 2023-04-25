using System;

namespace _05._Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int coins = 0;
            decimal remainder = decimal.Parse(Console.ReadLine());
            while (remainder > 0)
            {
                if (remainder >= 2)
                {
                    coins++;
                    remainder -= 2;
                }
                else if (remainder >= 1)
                {
                    coins++;
                    remainder -= 1;
                }
                else if (remainder >= 0.5m)
                {
                    coins++;
                    remainder -= 0.5m;
                }
                else if (remainder >= 0.2m)
                {
                    coins++;
                    remainder -= 0.2m;
                }
                else if (remainder >= 0.1m)
                {
                    coins++;
                    remainder -= 0.1m;
                }
                else if (remainder >= 0.05m)
                {
                    coins++;
                    remainder -= 0.05m;
                }
                else if (remainder >= 0.02m)
                {
                    coins++;
                    remainder -= 0.02m;
                }
                else if (remainder >= 0.01m)
                {
                    coins++;
                    remainder -= 0.01m;
                }
            }
            Console.WriteLine(coins);
        }
    }
}
