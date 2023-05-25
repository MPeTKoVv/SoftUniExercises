using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
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

            Queue<int> stack = new Queue<int>();

            for (int i = 0; i < pushes; i++)
            {
                stack.Enqueue(input[i]);
            }
            for (int i = 0; i < pops; i++)
            {
                stack.Dequeue();
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
