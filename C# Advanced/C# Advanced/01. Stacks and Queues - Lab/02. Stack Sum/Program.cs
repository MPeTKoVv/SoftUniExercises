using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>();

            foreach (var item in numbers)
            {
                stack.Push(item);
            }

            string[] commands = Console.ReadLine().Split();
            string command = commands[0];


            while (command.ToLower() != "end")
            {

                if (command.ToLower() == "add")
                {
                    int num1 = int.Parse(commands[1]);
                    int num2 = int.Parse(commands[2]);

                    stack.Push(num1);
                    stack.Push(num2);
                }
                else if (command.ToLower() == "remove")
                {
                    int numsThatWillBeRemoved = int.Parse(commands[1]);

                    if (stack.Count >= numsThatWillBeRemoved)
                    {
                        for (int i = 0; i < numsThatWillBeRemoved; i++)
                        {
                            stack.Pop();
                        }
                    }
                }

                commands = Console.ReadLine().Split();
                command = commands[0];
            }

            int sum = stack.Sum();

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
