using System;

namespace _03.Time_15Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour=int.Parse(Console.ReadLine());
            int minute=int.Parse(Console.ReadLine());
            minute += 15;

            if (minute >= 60)
            {
                hour += 1;
                minute = minute - 60;
            }

            if (hour >= 24)
            {
                hour -=24;
            }
            Console.WriteLine($"{hour}:{minute:d2}");
        }
    }
}
