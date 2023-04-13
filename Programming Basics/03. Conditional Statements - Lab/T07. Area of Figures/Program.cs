using System;

namespace T07._Area_of_Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figure=Console.ReadLine();
            if (figure=="square")
            {
                double side1=double.Parse(Console.ReadLine());
                double area = Math.Pow(side1,2);
                Console.WriteLine($"{area:f3}");
            }
            else if (figure== "rectangle")
            {
                double side1 = double.Parse(Console.ReadLine());
                double side2 = double.Parse(Console.ReadLine());
                double area = side1 * side2;
                Console.WriteLine($"{area:f3}");
            }
            else if (figure== "circle")
            {
                double radius=double.Parse(Console.ReadLine());
                double area = Math.PI * Math.Pow(radius, 2);
                Console.WriteLine($"{area:f3}");
            }
            else if (figure== "triangle")
            {
                double sidea=double.Parse(Console.ReadLine());
                double ha=double.Parse(Console.ReadLine());
                double area = (sidea * ha) / 2;
                Console.WriteLine($"{area:f3}");

            }
        }
    }
}
