using System;

namespace _06._Cake
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int size = a * b;
            int neededPieces = 0;
            int leftPieces;
            bool isStopped = false;
            leftPieces = size;
            while (leftPieces >= 0)
            {

                string currentPiece = Console.ReadLine();
                if (currentPiece == "STOP")
                {
                    isStopped = true;
                    break;
                }

                if (int.Parse(currentPiece) > leftPieces)
                {
                    neededPieces = int.Parse(currentPiece) - leftPieces;
                }

                leftPieces -= int.Parse(currentPiece);
            }
            if (isStopped)
            {
                Console.WriteLine($"{leftPieces} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {neededPieces} pieces more.");
            }
        }
    }
}
