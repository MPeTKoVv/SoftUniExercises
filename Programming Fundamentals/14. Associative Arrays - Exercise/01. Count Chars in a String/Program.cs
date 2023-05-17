using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            Dictionary<char, int> ocurrences = new Dictionary<char, int>();

            foreach (var item in input)
            {
                if (!ocurrences.ContainsKey(item) && item != ' ')
                {
                    ocurrences.Add(item, 0);
                }
                if (item != ' ')
                {
                    ocurrences[item]++;
                }
            }

            foreach (var item in ocurrences)
            {
                Console.WriteLine(String.Join(Environment.NewLine, $"{item.Key} -> {item.Value}"));
            }

        }
    }
}
