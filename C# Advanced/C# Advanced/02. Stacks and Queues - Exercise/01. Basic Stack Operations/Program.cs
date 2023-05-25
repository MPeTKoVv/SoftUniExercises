using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] commands = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int pushes = commands[0];
            int pops = commands[1];
            int searchedNum = commands[2];

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < pushes; i++)
            {
                stack.Push(input[i]);
            }
            for (int i = 0; i < pops; i++)
            {
                stack.Pop();
            }

            if (stack.Count == 0)
            {
                Console.WriteLine(0);
                return;
            }

            int smallestElement = int.MaxValue;

            foreach (int item in stack)
            {
                if (item == searchedNum)
                {
                    Console.WriteLine("true");
                    return;
                }
                if (item < smallestElement)
                {
                    smallestElement = item;
                }
            }
            Console.WriteLine(smallestElement);

        }
    }
}
