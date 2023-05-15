using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _07.OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            while (true)
            {
                string[] tokens = Console.ReadLine().Split(' ').ToArray();

                if (tokens[0] == "End")
                {
                    break;
                }

                string name = tokens[0];
                string id = tokens[1];
                int age = int.Parse(tokens[2]);

                Person person = new Person(name, id, age);

                if (people.Any(p => p.Id == id))
                {
                    var personToDetele = people.Find(p => p.Id == id);
                    people.Remove(personToDetele);
                }

                people.Add(person);
            }

            people = people.OrderBy(p => p.Age).ToList();

            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
        }
    }

    public class Person
    {
        public Person(string name, string id, int age)
        {
            Name = name;
            Id = id;
            Age = age;
        }

        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} with ID: {Id} is {Age} years old.";
        }
    }
}