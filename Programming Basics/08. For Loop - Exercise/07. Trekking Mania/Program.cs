using System;

namespace _07._Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amountOfGroups = int.Parse(Console.ReadLine());
            double hikingMusala = 0;
            double hikingMonbat = 0;
            double hikingKilimandjaro = 0;
            double hikingK2 = 0;
            double hikingEverest = 0;
            double totalPeople = 0;
            for (int counter = 1; counter <= amountOfGroups; counter++)
            {
                double peopleInGroup = double.Parse(Console.ReadLine());
                if (peopleInGroup <= 5)
                {
                    hikingMusala += peopleInGroup;
                    totalPeople += peopleInGroup;
                }
                else if (peopleInGroup <= 12)
                {
                    hikingMonbat += peopleInGroup;
                    totalPeople += peopleInGroup;
                }

                else if (peopleInGroup <= 25)
                {
                    hikingKilimandjaro += peopleInGroup;
                    totalPeople += peopleInGroup;
                }
                else if (peopleInGroup <= 40)
                {
                    hikingK2 += peopleInGroup;
                    totalPeople += peopleInGroup;
                }
                else
                {
                    hikingEverest += peopleInGroup;
                    totalPeople += peopleInGroup;
                }

            }
            Console.WriteLine($"{hikingMusala / totalPeople * 100:f2}%");
            Console.WriteLine($"{hikingMonbat / totalPeople * 100:f2}%");
            Console.WriteLine($"{hikingKilimandjaro / totalPeople * 100:f2}%");
            Console.WriteLine($"{hikingK2 / totalPeople * 100:f2}%");
            Console.WriteLine($"{hikingEverest / totalPeople * 100:f2}%");
        }
    }
}
