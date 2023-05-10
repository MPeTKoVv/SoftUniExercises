using System;
using System.Collections.Generic;

namespace _03._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();

            int commands = int.Parse(Console.ReadLine());


            for (int i = 0; i < commands; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                if (input[2] == "going!")
                {
                    if (names.Contains(input[0]))
                    {
                        Console.WriteLine($"{input[0]} is already in the list!");
                    }
                    else
                    {
                        names.Add(input[0]);
                    }
                }
                else
                {
                    if (names.Contains(input[0]))
                    {
                        names.Remove(input[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{input[0]} is not in the list!");
                    }
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, names));
        }
    }
}
