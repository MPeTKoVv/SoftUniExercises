﻿using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>[\w]+)>[^|$%.]*\|(?<quantity>[\d]+)\|[^|$%.]*?(?<price>[\d]+.?[\d]+)?\$";

            string input = Console.ReadLine();

            double totalPrice = 0;

            while (input != "end of shift")
            {
                Regex regex = new Regex(pattern);

                bool IsValid = regex.IsMatch(input);

                if (IsValid)
                {
                    string customer = regex.Match(input).Groups["customer"].Value;
                    string product = regex.Match(input).Groups["product"].Value;
                    int quantity = int.Parse(regex.Match(input).Groups["quantity"].Value);
                    double price = double.Parse(regex.Match(input).Groups["price"].Value);

                    double totalPriceForCurrentProduct = price * quantity;
                    totalPrice += totalPriceForCurrentProduct;

                    Console.WriteLine($"{customer}: {product} - {totalPriceForCurrentProduct:f2}");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {totalPrice:f2}");
        }
    }
}
