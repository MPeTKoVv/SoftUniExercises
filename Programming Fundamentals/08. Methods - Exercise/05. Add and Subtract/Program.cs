using System;

namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int addedResult = Add(firstNum, secondNum);

            int result = Subtract(addedResult, thirdNum);

            Console.WriteLine(result);
        }

        private static int Subtract(int sumOfTheFirstNumbs, int thirdNum)
        {
            int result = sumOfTheFirstNumbs - thirdNum;
            return result;
        }

        private static int Add(int firstNum, int secondNum)
        {
            int result = firstNum + secondNum;

            return result;
        }
    }
}
