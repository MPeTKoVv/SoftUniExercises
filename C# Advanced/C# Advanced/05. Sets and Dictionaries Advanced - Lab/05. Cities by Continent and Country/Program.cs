using System;
using System.Collections.Generic;

namespace _05._Cities_by_Continent_and_Country
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> continentCountryCity = new Dictionary<string, Dictionary<string, List<string>>>();

            int cnt = int.Parse(Console.ReadLine());

            for (int i = 0; i < cnt; i++)
            {
                string[] command = Console.ReadLine().Split(' ');
                string continent = command[0];
                string country = command[1];
                string city = command[2];

                if (!continentCountryCity.ContainsKey(continent))
                {
                    continentCountryCity.Add(continent, new Dictionary<string, List<string>>());
                }

                if (!continentCountryCity[continent].ContainsKey(country))
                {
                    continentCountryCity[continent].Add(country, new List<string>());
                }

                continentCountryCity[continent][country].Add(city);
            }

            foreach (var item in continentCountryCity)
            {
                Console.WriteLine($"{item.Key}:");

                foreach (KeyValuePair<string, List<string>> item1 in item.Value)
                {
                    Console.WriteLine($"  {item1.Key} -> {string.Join(", ", item1.Value)}");
                }
            }
        }
    }
}
