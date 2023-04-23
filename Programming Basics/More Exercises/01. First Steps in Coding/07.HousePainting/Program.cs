using System;

namespace _07.HousePainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double walls=(x+y)*2*x-2*1.2-2*1.5*1.5;
            double greenPaint1L = 3.4;
            double redPaint1L = 4.3;
            double roof = (h * x / 2 + x * y)*2;
            double needenGreenPaint = walls / greenPaint1L;
            double needenRedPaint = roof / redPaint1L;
            Console.WriteLine($"{needenGreenPaint:f2}");
            Console.WriteLine($"{needenRedPaint:f2}");

        }
    }
}
