using System;
using System.Collections.Generic;

namespace _04._Even_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cnt = int.Parse(Console.ReadLine());

            Dictionary<int, int> numbers = new Dictionary<int, int>();

            for (int i = 0; i < cnt; i++)
            {
                int currNum = int.Parse(Console.ReadLine());

                if (!numbers.ContainsKey(currNum))
                {
                    numbers.Add(currNum, 0);
                }

                numbers[currNum]++;
            }

            foreach (var item in numbers)
            {
                if (item.Value % 2 == 0)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}
