using System;

namespace _06._Cinema_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            double seatsCnt = 0;
            string ticketType = "";
            double studentTicketsCnt = 0;
            double standartTicketsCnt = 0;
            double kidTicketsCnt = 0;
            double seats = 0;

            while (ticketType != "Finish")
            {
                int freeSeats = int.Parse(Console.ReadLine());
                ticketType = Console.ReadLine();

                while (ticketType == "End" || ticketType == "Finish")
                {
                    seatsCnt++;

                    if (ticketType == "student")
                    {
                        studentTicketsCnt++;
                    }
                    else if (ticketType == "standard")
                    {
                        standartTicketsCnt++;
                    }
                    else if (ticketType == "kid")
                    {
                        kidTicketsCnt++;
                    }
                    seats = seatsCnt;
                    ticketType = Console.ReadLine();

                }
                Console.WriteLine($"{movie} - {seats / freeSeats * 100:f2}% full.");
                if (ticketType == "Finish")
                {
                    break;
                }
                movie = Console.ReadLine();
                seatsCnt = 0;
            }

            double totalTickets = studentTicketsCnt + standartTicketsCnt + kidTicketsCnt;
            double percentOfStudentTickets = studentTicketsCnt / totalTickets * 100;
            double percentOfStandartTickets = standartTicketsCnt / totalTickets * 100;
            double percentOfKidTickets = kidTicketsCnt / totalTickets * 100;

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{percentOfStudentTickets:f2}% student tickets.");
            Console.WriteLine($"{percentOfStandartTickets:f2}% standard tickets.");
            Console.WriteLine($"{percentOfKidTickets:f2}% kids tickets.");
        }
    }
}

//using System;

//namespace _06._Cinema_Tickets
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string movie = Console.ReadLine();
//            double seatsCnt = 0;
//            string type = "";
//            double studentTicketsCnt = 0;
//            double standartTicketsCnt = 0;
//            double kidTicketsCnt = 0;
//            double seats = 0;
//            double sum = 0;

//            double studentTicketsCnt2 = 0;
//            double standartTicketsCnt2 = 0;
//            double kidTicketsCnt2 = 0;

//            while (movie != "Finish")
//            {
//                int freeSeats = int.Parse(Console.ReadLine());
//                type = Console.ReadLine();

//                while (type != "End")
//                {
//                    //if (type == "Finish" || type == "End")
//                    //{
//                    //    break;
//                    //}
//                    seatsCnt++;

//                    if (type == "student")
//                    {
//                        studentTicketsCnt++;
//                        studentTicketsCnt2++;
//                    }
//                    else if (type == "standard")
//                    {
//                        standartTicketsCnt++;
//                        standartTicketsCnt2++;
//                    }
//                    else if (type == "kid")
//                    {
//                        kidTicketsCnt++;
//                        kidTicketsCnt2++;
//                    }

//                    sum = studentTicketsCnt + standartTicketsCnt + kidTicketsCnt;

//                    if (sum >= freeSeats)
//                    {
//                        break;
//                    }

//                    type = Console.ReadLine();

//                }
//                Console.WriteLine($"{movie} - {seatsCnt / freeSeats * 100:f2}% full.");

//                seatsCnt = 0;
//                studentTicketsCnt = 0;
//                standartTicketsCnt = 0;
//                kidTicketsCnt = 0;
//                sum = 0;

//                movie = Console.ReadLine();
//            }

//            double totalTickets = studentTicketsCnt2 + standartTicketsCnt2 + kidTicketsCnt2;
//            double percentOfStudentTickets = studentTicketsCnt2 / totalTickets * 100;
//            double percentOfStandartTickets = standartTicketsCnt2 / totalTickets * 100;
//            double percentOfKidTickets = kidTicketsCnt2 / totalTickets * 100;

//            Console.WriteLine($"Total tickets: {totalTickets}");
//            Console.WriteLine($"{percentOfStudentTickets:f2}% student tickets.");
//            Console.WriteLine($"{percentOfStandartTickets:f2}% standard tickets.");
//            Console.WriteLine($"{percentOfKidTickets:f2}% kids tickets.");
//        }
//    }
//}