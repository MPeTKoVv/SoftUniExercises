using System.Reflection;

namespace _07._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] tokens = input.Split('/').ToArray();

                string type = tokens[0];
                string brand = tokens[1];
                string model = tokens[2];

                if (type == "Car")
                {
                    int horsePower = int.Parse(tokens[3]);

                    Car car = new Car
                    {
                        Brand = brand,
                        Model = model,
                        HorsePower = horsePower
                    };

                    catalog.Cars.Add(car);
                }
                else if (type == "Truck")
                {
                    int weight = int.Parse(tokens[3]);

                    Truck truck = new Truck
                    {
                        Brand = brand,
                        Model = model,
                        Weight = weight,
                    };

                    catalog.Trucks.Add(truck);
                }
            }

            catalog.Cars = catalog.Cars.OrderBy(c => c.Brand).ToList();
            catalog.Trucks = catalog.Trucks.OrderBy(t => t.Brand).ToList();

            Console.WriteLine("Cars:");
            foreach (var car in catalog.Cars)
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }

            Console.WriteLine("Trucks:");
            foreach (var truck in catalog.Trucks)
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
        }
    }

    public class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }

    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }

    public class Catalog
    {
        public Catalog()
        {
            Trucks = new List<Truck>();
            Cars = new List<Car>();
        }

        public ICollection<Truck> Trucks { get; set; }
        public ICollection<Car> Cars { get; set; }
    }
}