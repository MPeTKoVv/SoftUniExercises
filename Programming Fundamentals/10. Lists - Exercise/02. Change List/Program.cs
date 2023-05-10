using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string[] input = Console.ReadLine().Split(' ').ToArray();

            while (input[0] != "end")
            {
                if (input[0] == "Delete")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (int.Parse(input[1]) == numbers[i])
                        {
                            numbers.Remove(numbers[i]);
                        }
                    }

                }
                else if (input[0] == "Insert")
                {
                    numbers.Insert(int.Parse(input[2]), int.Parse(input[1]));
                }

                input = Console.ReadLine().Split(' ').ToArray();
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
