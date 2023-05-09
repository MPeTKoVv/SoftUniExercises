using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstInput = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondInput = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> result = new List<int>();

            int biggerCount = Math.Max(firstInput.Count, secondInput.Count);

            for (int i = 0; i < biggerCount; i++)
            {
                if (firstInput.Count > i)
                {
                    result.Add(firstInput[i]);
                }

                if (secondInput.Count > i)
                {
                    result.Add(secondInput[i]);
                }
            }

            Console.WriteLine(String.Join(" ", result));
        }
    }
}
