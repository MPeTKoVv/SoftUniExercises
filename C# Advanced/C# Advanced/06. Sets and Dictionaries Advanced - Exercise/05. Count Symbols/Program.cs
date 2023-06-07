using System;
using System.Collections.Generic;

namespace _05._Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<char, int> chCounts = new SortedDictionary<char, int>();

            char[] input = Console.ReadLine().ToCharArray();

            for (int i = 0; i < input.Length; i++)
            {
                if (!chCounts.ContainsKey(input[i]))
                {
                    chCounts.Add(input[i], 0);
                }
                chCounts[input[i]]++;
            }

            foreach (var item in chCounts)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
