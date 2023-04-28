using System;

namespace _07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string output = Console.ReadLine();
            double money = 0;

            while (output != "Start")
            {
                double outputAsNum = double.Parse(output);

                if (outputAsNum == 0.1 || outputAsNum == 0.2 || outputAsNum == 0.5 || outputAsNum == 1 || outputAsNum == 2)
                {
                    money += double.Parse(output);
                    output = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"Cannot accept {outputAsNum}");
                    output = Console.ReadLine();
                }
            }

            output = Console.ReadLine();

            while (output != "End")
            {
                string product = output;

                if (product == "Nuts")
                {
                    if (money >= 2)
                    {
                        Console.WriteLine($"Purchased {product.ToLower()}");
                        money -= 2;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Water")
                {
                    if (money >= 0.7)
                    {
                        Console.WriteLine($"Purchased {product.ToLower()}");
                        money -= 0.7;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Crisps")
                {
                    if (money >= 1.5)
                    {
                        Console.WriteLine($"Purchased {product.ToLower()}");
                        money -= 1.5;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Soda")
                {
                    if (money >= 0.8)
                    {
                        Console.WriteLine($"Purchased {product.ToLower()}");
                        money -= 0.8;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Coke")
                {
                    if (money >= 1)
                    {
                        Console.WriteLine($"Purchased {product.ToLower()}");
                        money -= 1;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }

                output = Console.ReadLine();
            }

            double leftMoney = money;
            Console.WriteLine($"Change: {leftMoney:f2}");
        }
    }
}
