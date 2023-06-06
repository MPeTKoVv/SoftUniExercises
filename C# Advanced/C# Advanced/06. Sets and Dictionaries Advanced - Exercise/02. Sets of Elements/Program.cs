using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nm = Console.ReadLine().Split().Select(int.Parse).ToArray();

            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            int n = nm[0];
            int m = nm[1];

            for (int i = 0; i < n; i++)
            {
                int currNum = int.Parse(Console.ReadLine());
                firstSet.Add(currNum);
            }

            for (int i = 0; i < m; i++)
            {
                int currNum = int.Parse(Console.ReadLine());
                secondSet.Add(currNum);
            }

            foreach (int item in firstSet)
            {
                if (secondSet.Contains(item))
                {
                    Console.Write($"{item} ");
                }
            }
        }
    }
}
