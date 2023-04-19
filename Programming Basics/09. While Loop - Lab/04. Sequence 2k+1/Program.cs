using System;

namespace _04._Sequence_2k_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = 1;
            Console.WriteLine(k);

            while (2 * k + 1 <= n)
            {
                k = 2 * k + 1;
                Console.WriteLine(k);
            }
        }
    }
}
