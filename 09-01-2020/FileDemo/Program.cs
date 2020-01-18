using System;
using System.IO;

namespace FileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            String path1 = @"..\..\example.txt";

            if (!File.Exists(path1))
                Console.WriteLine("File does not exist");   
            else
            {
                String[] lines = File.ReadAllLines(path1);
                Console.WriteLine("Reading All Lines:");

                for (int i = 0; i < lines.Length; i++)
                    Console.WriteLine($"\t {lines[i]}");

                Console.WriteLine("\nReading All text:");
                String text = File.ReadAllText(path1);
                Console.WriteLine(text);
            }

            String path2 = @"..\..\example2.txt";
            if (!File.Exists(path2))
                File.Copy(path1, path2);
            else
            {
                File.Delete(path2);
                Console.WriteLine("\nPrevious file deleted and new one created");
                File.Copy(path1, path2);
            }
        }
    }
}
