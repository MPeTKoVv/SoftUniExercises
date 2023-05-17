using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionary <string, Dictionary<double, int>> totalProducts = new Dictionary<string, Dictionary<double,int>>();

            //string[] product = Console.ReadLine().Split(' ').ToArray();

            //while (product[0] != "buy")
            //{
            //    string productName = product[0];
            //    double price = double.Parse(product[1]);
            //    int quantity = int.Parse(product[2]);


            //    if (!totalProducts.ContainsKey(productName))
            //    {
            //        totalProducts.Add(productName, new Dictionary<double, int>());

            //    }
            //}

            var orders = new Dictionary<string, double>();
            var newOrders = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input != "buy")
            {
                var cmd = input.Split();

                string productName = cmd[0];
                double productPrice = double.Parse(cmd[1]);
                int productQuantity = int.Parse(cmd[2]);

                if (!orders.ContainsKey(productName))
                {
                    orders.Add(productName, productPrice);
                    newOrders.Add(productName, productQuantity);
                }
                else if (orders.ContainsKey(productName))
                {
                    orders[productName] = productPrice;
                    newOrders[productName] += productQuantity;
                }

                input = Console.ReadLine();
            }

            foreach (var order in orders)
            {
                foreach (var newOrder in newOrders)
                {
                    if (order.Key == newOrder.Key)
                    {
                        Console.WriteLine($"{order.Key} -> {order.Value * newOrder.Value:f2}");
                    }
                }
            }
        }
    }
}
