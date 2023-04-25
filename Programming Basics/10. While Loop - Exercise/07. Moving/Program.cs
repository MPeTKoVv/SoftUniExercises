using System;

namespace _07._Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int freeSpace = width * lenght * height;
            int neededSpace = 0;
            bool isItDone = false;
            while (freeSpace > 0)
            {
                string boxAmount = Console.ReadLine();
                if (boxAmount == "Done")
                {
                    isItDone = true;
                    break;
                }

                freeSpace -= int.Parse(boxAmount);

                if (freeSpace < 0)
                {
                    neededSpace = Math.Abs(freeSpace);
                }

            }

            if (isItDone)
            {
                Console.WriteLine($"{freeSpace} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {neededSpace} Cubic meters more.");
            }
        }
    }
}
