using System;

namespace _09._Ski_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string premises = Console.ReadLine();
            string grade = Console.ReadLine();
            double discount = 1;
            double roomForOnePersonPrice = 18;
            double apartmentPrice = 25;
            double presidentApartmentPrice = 35;
            double price = 0;
            double premisesPrice;

            if (premises == "room for one person")
            {
                premisesPrice = roomForOnePersonPrice;
            }
            else if (premises == "apartment")
            {
                premisesPrice = apartmentPrice;
            }
            else
            {
                premisesPrice = presidentApartmentPrice;
            }


            if (days > 15)
            {
                if (premises == "apartment")
                {
                    discount = 0.5;
                }
                else if (premises == "president apartment")
                {
                    discount = 0.8;
                }
            }
            else if (days > 10)
            {
                if (premises == "apartment")
                {
                    discount = 0.65;
                }
                else if (premises == "president apartment")
                {
                    discount = 0.85;
                }
            }
            else
            {
                if (premises == "apartment")
                {
                    discount = 0.7;
                }
                else if (premises == "president apartment")
                {
                    discount = 0.9;
                }
            }
            price = premisesPrice * (days - 1) * discount;
            if (grade == "positive")
            {
                discount = 1.25;
            }
            else if (grade == "negative")
            {
                discount = 0.9;
            }
            price *= discount;
            Console.WriteLine($"{price:f2}");
        }
    }
}
