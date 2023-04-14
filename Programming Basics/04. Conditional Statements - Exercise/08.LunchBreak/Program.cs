
using System;

namespace _08.LunchBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string series = Console.ReadLine();
            double episodeTime = double.Parse(Console.ReadLine());
            double breakTime = double.Parse(Console.ReadLine());
            double lunchTime = breakTime / 8;
            double restTime = breakTime / 4;

            breakTime -= (lunchTime + restTime);
            double leftTime = breakTime - episodeTime;
            double neededTime = Math.Abs(leftTime);

            if (breakTime >= episodeTime)
            {
                Console.WriteLine($"You have enough time to watch {series} and left with {Math.Ceiling(leftTime)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {series}, you need {Math.Ceiling(neededTime)} more minutes.");
            }
        }
    }
}
