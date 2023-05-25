using System;
using System.Collections.Generic;

namespace _6._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> names = new Queue<string>();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Paid")
                {
                    Console.WriteLine(string.Join(Environment.NewLine, names));
                    names.Clear();
                    continue;
                }
                else if (command == "End")
                {
                    Console.WriteLine($"{names.Count} people remaining.");
                    return;
                }

                names.Enqueue(command);
            }
        }
    }
}
