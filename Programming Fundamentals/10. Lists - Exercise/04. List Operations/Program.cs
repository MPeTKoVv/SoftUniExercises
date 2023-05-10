using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] tokens = command.Split();
                string action = tokens[0];

                if (action == "Add")
                {
                    int num = int.Parse(tokens[1]);
                    numbers.Add(num);
                }
                else if (action == "Insert")
                {
                    int index = int.Parse(tokens[2]);

                    if (index > numbers.Count - 1 || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        int num = int.Parse(tokens[1]);
                        numbers.Insert(index, num);
                    }
                }
                else if (action == "Remove")
                {
                    int index = int.Parse(tokens[1]);

                    if (index > numbers.Count - 1 || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.RemoveAt(index);
                    }
                }
                else if (action == "Shift")
                {
                    int count = int.Parse(tokens[2]);

                    if (tokens[1] == "left")
                    {


                        for (int i = 0; i < count; i++)
                        {
                            numbers.Add(numbers[0]);
                            numbers.RemoveAt(0);
                        }
                    }
                    else if (tokens[1] == "right")
                    {


                        for (int i = 0; i < count; i++)
                        {
                            numbers.Insert(0, numbers[numbers.Count - 1]);
                            numbers.RemoveAt(numbers.Count - 1);
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
