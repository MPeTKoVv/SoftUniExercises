using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using static _06._Vehicle_Catalogue.Program;

namespace _06._Vehicle_Catalogue
{
    public enum VehicleType
    {
        Car,
        Truck
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            while (true)
            {
                string[] tokens = Console.ReadLine().Split(" ").ToArray();

                if (tokens[0] == "End")
                {
                    break;
                }

                string type = tokens[0];

                VehicleType vehicleType;

                bool isVehcileTypaParseSuccessful = Enum.TryParse(type, true, out vehicleType);
                if (isVehcileTypaParseSuccessful)
                {
                    string model = tokens[1];
                    string color = tokens[2];
                    int horsepower = int.Parse(tokens[3]);
                    var curVehicle = new Vehicle(vehicleType, model, color, horsepower);
                    vehicles.Add(curVehicle);
                }
            }

            while (true)
            {
                string model = Console.ReadLine();

                if (model == "Close the Catalogue")
                {
                    break;
                }

                var vehicle = vehicles.Find(v => v.Model == model);

                Console.WriteLine(vehicle.ToString());
            }

            double averageCarsHorsepower = (double)vehicles.Where(v => v.Type == VehicleType.Car).Sum(v => v.Horsepower) / vehicles.Where(v => v.Type == VehicleType.Car).Count();
            double averageTrucksHorsepower = (double)vehicles.Where(v => v.Type == VehicleType.Truck).Sum(v => v.Horsepower) / vehicles.Where(v => v.Type == VehicleType.Truck).Count();


            Console.WriteLine($"Cars have average horsepower of: {averageCarsHorsepower:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageTrucksHorsepower:f2}.");
        }
    }

    public class Vehicle
    {
        public Vehicle(VehicleType type, string model, string color, int horsepower)
        {
            Type = type;
            Model = model;
            Color = color;
            Horsepower = horsepower;
        }

        public VehicleType Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Type: {Type}");
            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"Color: {Color}");
            sb.AppendLine($"Horsepower: {Horsepower}");

            return sb.ToString().Trim();
        }
    }
}
