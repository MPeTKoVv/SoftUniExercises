using System;

namespace _02.TriangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double ha = double.Parse(Console.ReadLine());
            double area = a * ha / 2;
            Console.WriteLine($"{ area:f2}");
        }
    }
}
