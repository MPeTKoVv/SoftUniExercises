using System;

namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int CAPACITY = 255;

            int cnt = int.Parse(Console.ReadLine());
            int totalPouredWater = 0;


            for (int i = 0; i < cnt; i++)
            {
                int litters = int.Parse((Console.ReadLine()));

                if (litters <= CAPACITY - totalPouredWater)
                {
                    totalPouredWater += litters;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }

            }

            Console.WriteLine(totalPouredWater);
        }
    }
}
