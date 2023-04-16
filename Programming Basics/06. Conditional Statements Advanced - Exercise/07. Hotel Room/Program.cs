using System;

namespace _07._Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int overNights = int.Parse(Console.ReadLine());
            double apartmentPrice = 0;
            double studioPrice = 0;
            double totalApartmentPrice = 0;
            double totalStudioPrice = 0;
            double studioDiscount = 1;
            double apartmentDiscount = 1;

            if (month == "May" || month == "October")
            {
                apartmentPrice = 65;
                studioPrice = 50;
                if (overNights > 14)
                {
                    studioDiscount = 0.7;
                    apartmentDiscount = 0.9;
                }
                else if (overNights > 7)
                {
                    studioDiscount = 0.95;
                }
            }
            else if (month == "June" || month == "September")
            {
                apartmentPrice = 68.7;
                studioPrice = 75.2;
                if (overNights > 14)
                {
                    studioDiscount = 0.8;
                    apartmentDiscount = 0.9;
                }
            }
            else
            {
                apartmentPrice = 77;
                studioPrice = 76;
                if (overNights > 14)
                {
                    apartmentDiscount = 0.9;
                }
            }
            totalApartmentPrice = overNights * apartmentPrice * apartmentDiscount;
            totalStudioPrice = overNights * studioPrice * studioDiscount;
            Console.WriteLine($"Apartment: {totalApartmentPrice:f2} lv.");
            Console.WriteLine($"Studio: {totalStudioPrice:f2} lv.");
        }
    }
}
