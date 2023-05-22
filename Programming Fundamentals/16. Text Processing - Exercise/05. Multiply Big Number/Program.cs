using System;
using System.Text;

namespace _05._Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            int num = int.Parse(Console.ReadLine());

            if (num == 0)
            {
                Console.WriteLine(0);
                return;
            }

            StringBuilder sb = new StringBuilder();
            int reminder = 0;

            for (int i = number.Length - 1; i >= 0; i--)
            {
                char lastNum = number[i];

                int lastNumAsDigit = int.Parse(lastNum.ToString());

                int sum = num * lastNumAsDigit + reminder;

                sb.Append(sum % 10);

                reminder = sum / 10;
            }

            if (reminder != 0)
            {
                sb.Append(reminder);
            }

            StringBuilder reversedSb = new StringBuilder();

            for (int i = sb.Length - 1; i >= 0; i--)
            {
                reversedSb.Append(sb[i]);
            }

            Console.WriteLine(reversedSb);
        }
    }
}