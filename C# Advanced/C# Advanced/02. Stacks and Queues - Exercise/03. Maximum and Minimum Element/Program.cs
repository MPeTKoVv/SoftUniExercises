using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {

                int[] command = Console.ReadLine().Split().Select(int.Parse).ToArray();

                int token = command[0];

                if (token == 1)
                {
                    stack.Push(command[1]);
                }
                else if (stack.Count == 0)
                {
                    continue;
                }
                else if (token == 2)
                {
                    stack.Pop();
                }
                else if (token == 3)
                {
                    Console.WriteLine(stack.Max());
                }
                else if (token == 4)
                {
                    Console.WriteLine(stack.Min());
                }

            }

            Console.WriteLine(String.Join(", ", stack));
        }
    }
}
