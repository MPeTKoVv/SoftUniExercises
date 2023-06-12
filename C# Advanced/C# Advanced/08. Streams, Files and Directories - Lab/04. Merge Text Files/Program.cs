namespace MergeFiles
{
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            using (StreamReader readerFromFile1 = new StreamReader(firstInputFilePath))
            {
                using (StreamReader readerFromFile2 = new StreamReader(secondInputFilePath))
                {
                    using (StreamWriter writer = new StreamWriter(outputFilePath))
                    {
                        while (!readerFromFile1.EndOfStream || !readerFromFile2.EndOfStream)
                        {
                            if (!readerFromFile1.EndOfStream)
                            {
                                writer.WriteLine(readerFromFile1.ReadLine());
                            }
                            if (!readerFromFile2.EndOfStream)
                            {
                                writer.WriteLine(readerFromFile2.ReadLine());
                            }
                        }
                    }
                }
            }
        }
    }
}
