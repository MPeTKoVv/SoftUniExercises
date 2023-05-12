using System.Security.Cryptography.X509Certificates;

namespace _03._Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cnt = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i < cnt; i++)
            {
                string[] info = Console.ReadLine().Split("_").ToArray();
                string typeList = info[0];
                string name = info[1];
                string time = info[2];

                Song song = new Song
                {
                    TypeList = typeList,
                    Name = name,
                    Time = time,
                };

                songs.Add(song);
            }

            string command = Console.ReadLine();

            if (command == "all")
            {
                foreach (var song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (var song in songs)
                {
                    if (song.TypeList == command)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }

    public class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
}