using System;

namespace _03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] arr2 = new string[n];
            string[] arr1 = new string[n];

            for (int i = 0; i < n; i++)
            {
                string[] currentArr = Console.ReadLine().Split(' ');

                if (i % 2 != 0)
                {
                    arr1[i] = currentArr[1];
                    arr2[i] = currentArr[0];
                }
                else
                {
                    arr1[i] = currentArr[0];
                    arr2[i] = currentArr[1];
                }
            }

            Console.WriteLine(string.Join(" ", arr1));
            Console.WriteLine(string.Join(" ", arr2));
        }
    }
}
