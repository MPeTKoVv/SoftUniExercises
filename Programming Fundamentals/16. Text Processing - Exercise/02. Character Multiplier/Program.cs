using System;

namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine(CharMultiplier(input[0], input[1]));
        }

        public static int CharMultiplier(string str1, string str2)
        {
            int sum = 0;

            string shorterStr = "";
            string longerStr = "";

            if (str1.Length > str2.Length)
            {
                longerStr = str1;
                shorterStr = str2;
            }
            else
            {
                shorterStr = str1;
                longerStr = str2;
            }

            int index = 0;

            for (int i = 0; i < shorterStr.Length; i++)
            {
                sum += str1[i] * str2[i];
                index++;
            }
            for (int i = index; i < longerStr.Length; i++)
            {
                sum += longerStr[i];
            }

            return sum;
        }
    }
}