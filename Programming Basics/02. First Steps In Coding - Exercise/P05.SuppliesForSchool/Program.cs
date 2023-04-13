using System;

namespace P05.SuppliesForSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pricePacketOfPens = 5.8;
            double pricePacketOfMarkers = 7.2;
            double pricePreparation = 1.2;

            int packetsOfPens = int.Parse(Console.ReadLine());
            int packetsOfMarkers = int.Parse(Console.ReadLine());
            int preparation = int.Parse(Console.ReadLine());
            int percentDiscound=int.Parse(Console.ReadLine());
            double finalprice = (pricePacketOfPens * packetsOfPens + pricePacketOfMarkers * packetsOfMarkers + pricePreparation * preparation) - ((pricePacketOfPens * packetsOfPens + pricePacketOfMarkers * packetsOfMarkers + pricePreparation * preparation) * (percentDiscound*0.01));
            Console.WriteLine(finalprice);

        }
    }
}
