
using System;

namespace P06.Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceNylon = 1.5;
            double pricePaint = 14.5;
            double priceThinner = 5.0;
            double bags = 0.4;

            int nylon = int.Parse(Console.ReadLine());
            int paint= int.Parse(Console.ReadLine());
            int thinner= int.Parse(Console.ReadLine()); 
            int hours=int.Parse(Console.ReadLine());

            double finalprice = (priceNylon * (2+nylon) + (pricePaint * 1.1*paint) + priceThinner * thinner + bags) + 0.3 * (priceNylon * (2 + nylon) + (pricePaint * 1.1 * paint) + priceThinner * thinner + bags) * hours;
            Console.WriteLine(finalprice);

        }
    }
}
