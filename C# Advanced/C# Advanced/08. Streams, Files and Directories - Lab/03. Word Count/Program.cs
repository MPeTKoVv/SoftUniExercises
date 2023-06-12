using System.Diagnostics.Metrics;

namespace WordCount
{
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            using (StreamReader reader = new StreamReader(textFilePath))
            {
                var words = wordsFilePath.Split().ToList();

                foreach (var word in words)
                {
                    int counter = 0;

                    while (!reader.EndOfStream)
                    {
                        string[] curRow = reader.ReadLine().Split();

                        foreach (var curWord in curRow)
                        {
                            if (curWord == word)
                            {
                                counter++;
                            }
                        }
                    }

                    using (StreamWriter writer = new StreamWriter(outputFilePath))
                    {
                        writer.WriteLine($"{word} - {counter}");
                    }
                }
            }
        }
    }
}
