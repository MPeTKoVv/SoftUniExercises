using System;
using System.Collections.Generic;

namespace _08._SoftUni_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vipReservation = new HashSet<string>();
            HashSet<string> regularReservation = new HashSet<string>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "PARTY")
                {
                    break;
                }

                if (command.Length == 8 && char.IsDigit(command[0]))
                {
                    vipReservation.Add(command);
                }
                else if (command.Length == 8)
                {
                    regularReservation.Add(command);
                }
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "END")
                {
                    break;
                }

                if (vipReservation.Contains(command))
                {
                    vipReservation.Remove(command);
                }
                else if (regularReservation.Contains(command))
                {
                    regularReservation.Remove(command);
                }

            }

            Console.WriteLine(vipReservation.Count + regularReservation.Count);

            foreach (string reservation in vipReservation)
            {
                Console.WriteLine(reservation);
            }

            foreach (string reservation in regularReservation)
            {
                Console.WriteLine(reservation);
            }

            //Console.WriteLine(String.Join(Environment.NewLine, vipReservation));
            //Console.WriteLine(String.Join(Environment.NewLine, regularReservation));
        }
    }
}
