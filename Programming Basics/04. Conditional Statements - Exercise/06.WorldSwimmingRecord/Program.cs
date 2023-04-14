using System;

namespace _06.WorldSwimmingRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double secondsRecord = double.Parse(Console.ReadLine());
            double metreLenght = double.Parse(Console.ReadLine());
            double secondsPerOneMetre = double.Parse(Console.ReadLine());

            double retardationIn15Metre = Math.Floor(metreLenght / 15);
            double retardationInSeconds = retardationIn15Metre * 12.5;

            double hisTime = metreLenght * secondsPerOneMetre + retardationInSeconds;
            double notEnoughTime = hisTime - secondsRecord;

            if (hisTime < secondsRecord) { Console.WriteLine($"Yes, he succeeded! The new world record is {hisTime:f2} seconds."); }
            else if (hisTime >= secondsRecord) { Console.WriteLine($"No, he failed! He was {notEnoughTime:f2} seconds slower."); }
        }
    }
}
