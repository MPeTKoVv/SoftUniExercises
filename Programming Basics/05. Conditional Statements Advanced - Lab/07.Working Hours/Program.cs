﻿using System;

namespace _07.Working_Hours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();
            if (hour >= 10 && hour <= 18)
            {
                switch (day)
                {
                    case "Monday":
                        Console.WriteLine("open");
                        break;
                    case "Tuesday":
                        Console.WriteLine("open");
                        break;
                    case "Wednesday":
                        Console.WriteLine("open");
                        break;
                    case "Thursday":
                        Console.WriteLine("open");
                        break;
                    case "Friday":
                        Console.WriteLine("open");
                        break;
                    case "Saturday":
                        Console.WriteLine("open");
                        break;
                    default:
                        Console.WriteLine("closed");
                        break;
                }
            }
            else
            {
                Console.WriteLine("closed");
            }
        }
    }
}
