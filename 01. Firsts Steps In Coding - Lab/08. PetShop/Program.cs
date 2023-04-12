using System;

namespace Т08._Pet_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int PacketsOfDogFood=int.Parse(Console.ReadLine());
            int PacketsOfCatFood=int.Parse(Console.ReadLine());
            double DogFood = 2.5;
            double CatFood = 4;
            Console.WriteLine(PacketsOfDogFood * DogFood + PacketsOfCatFood * CatFood+" lv.");
        }
    }
}
