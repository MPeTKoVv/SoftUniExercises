using System;

namespace _01._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());
            int totalSeats = rows * colums;
            double price = 0;
            switch (type)
            {
                case "Premiere":
                    price = 12;
                    break;
                case "Normal":
                    price = 7.5;
                    break;
                case "Discount":
                    price = 5;
                    break;
            }
            double totalPrice = price * totalSeats;
            Console.WriteLine($"{totalPrice:f2} leva");
        }
    }
}
