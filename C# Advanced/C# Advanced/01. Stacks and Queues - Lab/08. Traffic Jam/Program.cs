using System;
using System.Collections.Generic;

namespace _8._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int greenCarsToPass = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            Queue<string> cars = new Queue<string>();

            int totalPassedCars = 0;

            while (command != "end")
            {
                if (command == "green")
                {
                    for (int i = 0; i < greenCarsToPass; i++)
                    {
                        if (cars.Count > 0)
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            totalPassedCars++;
                        }
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"{totalPassedCars} cars passed the crossroads.");
        }
    }
}
