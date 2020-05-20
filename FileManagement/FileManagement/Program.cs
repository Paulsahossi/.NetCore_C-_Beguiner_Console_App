using System;
using System.IO;

namespace FileManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "/Users/pawlus/Desktop/MyFile.txt";
            //File.WriteAllText(filePath, $"Line 1{Environment.NewLine}Line 2");

            //Console.WriteLine(File.ReadAllText(filePath));

            string[] lines = File.ReadAllLines(filePath);
            Console.WriteLine(lines[0]);
        }
    }
}
