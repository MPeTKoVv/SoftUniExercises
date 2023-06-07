using System;
using System.Collections.Generic;

namespace _06._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cnt = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> clothes = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < cnt; i++)
            {
                string[] colorAndClothes = Console.ReadLine().Split(" -> ");
                string[] currClothes = colorAndClothes[1].Split(",");

                string color = colorAndClothes[0];

                if (!clothes.ContainsKey(color))
                {
                    clothes.Add(color, new Dictionary<string, int>());
                }

                foreach (var item in currClothes)
                {
                    if (!clothes[color].ContainsKey(item))
                    {
                        clothes[color].Add(item, 0);
                    }
                    clothes[color][item]++;
                }
            }

            string[] foundedColorAndClothe = Console.ReadLine().Split();

            string foundedColor = foundedColorAndClothe[0];
            string foundedClothe = foundedColorAndClothe[1];

            foreach (var color in clothes)
            {
                Console.WriteLine($"{color.Key} clothes:");

                if (color.Key == foundedColor)
                {
                    foreach (var clothe in color.Value)
                    {
                        if (clothe.Key == foundedClothe)
                        {
                            Console.WriteLine($"* {clothe.Key} - {clothe.Value} (found!)");
                        }
                        else
                        {
                            Console.WriteLine($"* {clothe.Key} - {clothe.Value}");
                        }
                    }
                }
                else
                {
                    foreach (var clothe in color.Value)
                    {
                        Console.WriteLine($"* {clothe.Key} - {clothe.Value}");

                    }
                }
            }
        }
    }
}
