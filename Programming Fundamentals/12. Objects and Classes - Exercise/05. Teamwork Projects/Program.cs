using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace _05._Teamwork_Projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();

            int teamsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < teamsCount; i++)
            {
                string[] tokens = Console.ReadLine().Split('-').ToArray();

                string creator = tokens[0];
                string teamName = tokens[1];

                if (teams.Any(t => t.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }
                else if (teams.Any(t => t.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }

                Team team = new Team(creator, teamName);

                teams.Add(team);
                Console.WriteLine(team.Created());
            }

            while (true)
            {
                string[] tokens = Console.ReadLine().Split("->").ToArray();

                string user = tokens[0];

                if (user == "end of assignment")
                {
                    break;
                }

                string teamName = tokens[1];


                if (!teams.Any(t => t.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }
                else if (teams.Any(t => t.Members.Contains(user)) || teams.Any(t => t.Creator == user))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                    continue;
                }

                teams.Find(t => t.Name == teamName).Members.Add(user);
            }

            var completedTeams = teams.Where(t => t.Members.Count > 0).OrderByDescending(t => t.Members.Count).ThenBy(t => t.Name).ToList();
            var disbanedTeams = teams.Where(t => t.Members.Count == 0).OrderBy(t => t.Name).ToList();

            foreach (var team in completedTeams)
            {
                Console.WriteLine($"{team.Name}");
                Console.WriteLine($"- {team.Creator}");

                foreach (var member in team.Members.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");

            foreach (var team in disbanedTeams)
            {
                Console.WriteLine($"{team.Name}");
            }
        }
    }

    internal class Team
    {
        public Team(string creator, string name)
        {
            Creator = creator;
            Name = name;
            Members = new List<string>();
        }

        public string Creator { get; set; }
        public string Name { get; set; }
        public List<string> Members { get; set; }

        public string Created()
        {
            return $"Team {Name} has been created by {Creator}!";
        }
    }
}