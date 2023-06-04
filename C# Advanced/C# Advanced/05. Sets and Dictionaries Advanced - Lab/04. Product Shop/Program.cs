using System;
using System.Collections.Generic;

namespace _04._Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> shopAndProducts = new SortedDictionary<string, Dictionary<string, double>>();

            while (true)
            {
                string[] command = Console.ReadLine().Split(", ");

                string shop = command[0];

                if (shop == "Revision")
                {
                    break;
                }

                string currProduct = command[1];
                double currPrice = double.Parse(command[2]);

                if (!shopAndProducts.ContainsKey(shop))
                {
                    shopAndProducts.Add(shop, new Dictionary<string, double>());
                }

                shopAndProducts[shop].Add(currProduct, currPrice);
            }

            foreach (var item in shopAndProducts)
            {
                Console.WriteLine($"{item.Key}->");

                foreach (KeyValuePair<string, double> productAndPrice in item.Value)
                {
                    Console.WriteLine($"Product: {productAndPrice.Key}, Price: {productAndPrice.Value}");
                }
            }
        }
    }
}
