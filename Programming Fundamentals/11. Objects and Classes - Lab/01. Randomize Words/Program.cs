namespace _01._Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();

            Random rnd = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                int rndIndex = rnd.Next(0, input.Length);

                string currWord = input[i];
                input[i] = input[rndIndex];
                input[rndIndex] = currWord;
            }

            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
        }
    }
}