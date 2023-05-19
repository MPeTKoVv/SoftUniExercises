using System;

namespace _03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fileDirectory = Console.ReadLine().Split("\\");

            string[] file = fileDirectory[fileDirectory.Length - 1].Split('.');

            string fileName = file[0];
            string fileExtension = file[1];

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}
