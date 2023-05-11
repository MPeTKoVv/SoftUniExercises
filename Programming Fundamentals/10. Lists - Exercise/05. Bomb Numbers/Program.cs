using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int[] bombInput = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int bombNumber = bombInput[0];
            int power = bombInput[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombNumber)
                {
                    numbers[i] = 0;

                    int count = i;

                    for (int j = Math.Max(0, count - power); j <= Math.Min(power + i, numbers.Count - 1); j++)
                    {
                        numbers[j] = 0;
                    }
                }
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
