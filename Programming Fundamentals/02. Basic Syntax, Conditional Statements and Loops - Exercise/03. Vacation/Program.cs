using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();

            double pricePerOnePerson = 0;
            double discount = 0;

            switch (day)
            {
                case "Friday":
                    switch (type)
                    {
                        case "Students":
                            pricePerOnePerson = 8.45;
                            break;
                        case "Business":
                            pricePerOnePerson = 10.9;
                            break;
                        case "Regular":
                            pricePerOnePerson = 15;
                            break;
                    }
                    break;
                case "Saturday":
                    switch (type)
                    {
                        case "Students":
                            pricePerOnePerson = 9.8;
                            break;
                        case "Business":
                            pricePerOnePerson = 15.6;
                            break;
                        case "Regular":
                            pricePerOnePerson = 20;
                            break;
                    }
                    break;
                case "Sunday":
                    switch (type)
                    {
                        case "Students":
                            pricePerOnePerson = 10.46;
                            break;
                        case "Business":
                            pricePerOnePerson = 16;
                            break;
                        case "Regular":
                            pricePerOnePerson = 22.5;
                            break;
                    }
                    break;
            }

            switch (type)
            {
                case "Students":
                    if (countOfPeople >= 30)
                    {
                        discount = 15;
                    }
                    break;
                case "Business":
                    if (countOfPeople >= 100)
                    {
                        countOfPeople -= 10;
                    }
                    break;
                case "Regular":
                    if (countOfPeople >= 10 && countOfPeople <= 20)
                    {
                        discount = 5;
                    }
                    break;
            }

            double price = pricePerOnePerson * countOfPeople * (100 - discount) / 100;

            Console.WriteLine($"Total price: {price:f2}");

        }
    }
}
