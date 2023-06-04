using System;

namespace _7._Knight_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            if (size <= 3)
            {
                Console.WriteLine(0);
                return;
            }

            char[,] matrix = new char[size, size];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] currArray = Console.ReadLine().ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currArray[col];
                }
            }

            int knightsRemoved = 0;

            while (true)
            {
                int cntMostAttacking = 0;
                int rowMostAttacking = 0;
                int colMostAttacking = 0;

                for (int row = 0; row < size; row++)
                {
                    for (int col = 0; col < size; col++)
                    {
                        if (matrix[row, col] == 'K')
                        {
                            int attackedKnights = CntAttackedKnights(row, col, matrix, size);

                            if (attackedKnights > cntMostAttacking)
                            {
                                cntMostAttacking = attackedKnights;
                                rowMostAttacking = row;
                                colMostAttacking = col;
                            }
                        }
                    }
                }

                if (cntMostAttacking == 0)
                {
                    break;
                }
                else
                {
                    matrix[rowMostAttacking, colMostAttacking] = '0';
                    knightsRemoved++;
                }



            }
            Console.WriteLine(knightsRemoved);

            static int CntAttackedKnights(int row, int col, char[,] matrix, int size)
            {
                int attackedKnights = 0;

                //left-up
                if (IsCellValid(row - 1, col - 2, size))
                {
                    if (matrix[row - 1, col - 2] == 'K')
                    {
                        attackedKnights++;
                    }
                }

                //left-down
                if (IsCellValid(row + 1, col - 2, size))
                {
                    if (matrix[row + 1, col - 2] == 'K')
                    {
                        attackedKnights++;
                    }
                }

                //right-up
                if (IsCellValid(row + 1, col + 2, size))
                {
                    if (matrix[row + 1, col + 2] == 'K')
                    {
                        attackedKnights++;
                    }
                }

                //right-down
                if (IsCellValid(row - 1, col + 2, size))
                {
                    if (matrix[row - 1, col + 2] == 'K')
                    {
                        attackedKnights++;
                    }
                }

                //up-left
                if (IsCellValid(row - 2, col - 1, size))
                {
                    if (matrix[row - 2, col - 1] == 'K')
                    {
                        attackedKnights++;
                    }
                }


                //up-right
                if (IsCellValid(row - 2, col + 1, size))
                {
                    if (matrix[row - 2, col + 1] == 'K')
                    {
                        attackedKnights++;
                    }
                }


                //down-left
                if (IsCellValid(row + 2, col - 1, size))
                {
                    if (matrix[row + 2, col - 1] == 'K')
                    {
                        attackedKnights++;
                    }
                }


                //down-right
                if (IsCellValid(row + 2, col + 1, size))
                {
                    if (matrix[row + 2, col + 1] == 'K')
                    {
                        attackedKnights++;
                    }
                }

                return attackedKnights;
            }

            static bool IsCellValid(int row, int col, int size)
            {
                return row >= 0 && col >= 0 && row < size && col < size;
            }
        }
    }
}
