using System;

namespace _06._Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine(GetRectangleArea(width, height));
        }

        private static double GetRectangleArea(double width, double height)
        {
            double area = width * height;

            return area;
        }
    }
}
