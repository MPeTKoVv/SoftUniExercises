using System;
using System.Collections.Generic;

namespace _07._Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> numbers = new HashSet<string>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(", ");
                string command = input[0];

                if (command == "END")
                {
                    break;
                }

                string number = input[1];

                if (command == "IN")
                {
                    numbers.Add(number);
                }
                else if (command == "OUT")
                {
                    numbers.Remove(number);
                }
            }

            if (numbers.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                Console.WriteLine(String.Join(Environment.NewLine, numbers));
            }
        }
    }
}
