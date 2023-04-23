using System;

namespace _05.TrainingLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            h = h - 1;
            double desks = Math.Floor(w / 1.2) * Math.Floor(h / 0.7)-3;

            Console.WriteLine(desks);
        }
    }
}
