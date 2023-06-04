using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<double, int> number = new Dictionary<double, int>();

            double[] nums = Console.ReadLine().Split().Select(double.Parse).ToArray();

            foreach (double num in nums)
            {
                if (number.ContainsKey(num))
                {
                    number[num]++;
                }
                else
                {
                    number.Add(num, 1);
                }
            }

            foreach (var item in number)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
