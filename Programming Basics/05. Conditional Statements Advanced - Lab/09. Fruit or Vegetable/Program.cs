using System;

namespace _09._Fruit_or_Vegetable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruitOtVegetable=Console.ReadLine();
            switch (fruitOtVegetable)
            {
                case "banana":
                    Console.WriteLine("fruit");
                    break;
                case "apple":
                    Console.WriteLine("fruit");
                    break;
                case "kiwi":
                    Console.WriteLine("fruit");
                    break;
                case "cherry":
                    Console.WriteLine("fruit");
                    break;
                case "lemon":
                    Console.WriteLine("fruit");
                    break;
                case "grapes":
                    Console.WriteLine("fruit");
                    break;
                case "tomato":
                    Console.WriteLine("vegetable");
                    break;
                case "cucumber":
                    Console.WriteLine("vegetable");
                    break;
                case "pepper":
                    Console.WriteLine("vegetable");
                    break;
                case "carrot":
                    Console.WriteLine("vegetable");
                    break;
                    default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
