using System;

namespace TupleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var tup = Tuple.Create(1, "Steve", "Jobs");
            Console.WriteLine("Tuple Elements: ");
            Console.WriteLine($"1st Element: {tup.Item1}");
            Console.WriteLine($"2nd Element: {tup.Item2}");
            Console.WriteLine($"3rd Element: {tup.Item3}");
        }
    }
}
