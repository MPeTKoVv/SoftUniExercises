using System;

namespace _11._Fruit_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());
            double price = 0;

            switch (dayOfWeek)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":

                    switch (fruit)
                    {
                        case "banana":
                            price += 2.5*amount;
                            Console.WriteLine($"{price:f2}");
                            break;
                        case "apple":
                            price += 1.2 * amount;
                            Console.WriteLine($"{price:f2}");
                            break;
                        case "orange":
                            price += 0.85 * amount;
                            Console.WriteLine($"{price:f2}");
                            break;
                        case "grapefruit":
                            price += 1.45 * amount;
                            Console.WriteLine($"{price:f2}");
                            break;
                        case "kiwi":
                            price += 2.7 * amount;
                            Console.WriteLine($"{price:f2}");
                            break;
                        case "pineapple":
                            price += 5.5 * amount;
                            Console.WriteLine($"{price:f2}");
                            break;
                        case "grapes":
                            price += 3.85 * amount;
                            Console.WriteLine($"{price:f2}");
                            break;

                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;

                case "Saturday":
                case "Sunday":
                    switch (fruit)
                    {
                        case "banana":
                            price += 2.7 * amount;
                            Console.WriteLine($"{price:f2}");
                            break;
                        case "apple":
                            price += 1.25 * amount;
                            Console.WriteLine($"{price:f2}");
                            break;
                        case "orange":
                            price += 0.9 * amount;
                            Console.WriteLine($"{price:f2}");
                            break;
                        case "grapefruit":
                            price += 1.6 * amount;
                            Console.WriteLine($"{price:f2}");
                            break;
                        case "kiwi":
                            price += 3 * amount;
                            Console.WriteLine($"{price:f2}");
                            break;
                        case "pineapple":
                            price += 5.6 * amount;
                            Console.WriteLine($"{price:f2}");
                            break;
                        case "grapes":
                            price += 4.2 * amount;
                            Console.WriteLine($"{price:f2}");
                            break;
                            

                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                default:

                    Console.WriteLine("error");
                    break;
            }
        }
    }
}
