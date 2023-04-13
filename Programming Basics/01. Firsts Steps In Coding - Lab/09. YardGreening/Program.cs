using System;

namespace Т09._Yard_Greening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double area=double.Parse(Console.ReadLine());
            double price = 7.61;
            double discount = 0.18 * (area * price);
            double finalprice=(0.82*(area*price));
            Console.WriteLine("The final price is: {0:0.##} lv.",finalprice);
            Console.WriteLine("The discount is: {0:0.##} lv.", discount);
        }
    }
}
