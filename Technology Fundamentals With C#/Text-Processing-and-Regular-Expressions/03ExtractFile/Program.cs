using System;

namespace _03ExtractFile
{
    public class Program
    {
        public static void Main()
        {
            string pathToFile = Console.ReadLine();
            int startIndexOfFile = pathToFile.LastIndexOf('\\')+1;
            string file = pathToFile.Substring(startIndexOfFile);
            string[] splitFile = file.Split(".");

            Console.WriteLine($"File name: {splitFile[0]}");
            Console.WriteLine($"File extension: {splitFile[1]}");
        }
    }
}
