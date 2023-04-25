using System;

namespace _05._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int firstDigit = 1; firstDigit < 10; firstDigit++)
            {
                for (int secondDigit = 1; secondDigit < 10; secondDigit++)
                {
                    for (int thirdDigit = 1; thirdDigit < 10; thirdDigit++)
                    {
                        for (int fourthDigit = 1; fourthDigit < 10; fourthDigit++)
                        {
                            if (num % firstDigit == 0 && num % secondDigit == 0 && num % thirdDigit == 0 && num % fourthDigit == 0)
                            {
                                Console.Write(firstDigit * 1000 + secondDigit * 100 + thirdDigit * 10 + fourthDigit + " ");
                            }
                        }
                    }
                }
            }
        }
    }
}
