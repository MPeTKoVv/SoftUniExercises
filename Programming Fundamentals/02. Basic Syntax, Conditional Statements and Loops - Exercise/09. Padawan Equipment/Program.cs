using System;

namespace _09.PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double johnsMoney = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double saberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double saberCount = students;
            double robeCount = students;
            double beltCount = students;

            saberCount += Math.Ceiling(saberCount * 0.1);
            beltCount -= Math.Floor(beltCount / 6);

            double totalPrice = saberPrice * saberCount + robeCount * robePrice + beltCount * beltPrice;

            double neededMoney = Math.Abs(totalPrice - johnsMoney);

            if (johnsMoney >= totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {neededMoney:f2}lv more.");
            }
        }
    }
}
