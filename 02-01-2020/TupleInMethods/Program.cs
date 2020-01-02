using System;

namespace TupleInMethods
{
    class Program
    {
        static Tuple<int, string, string> getDetails()
        {
            return Tuple.Create(1, "Steve", "Jobs");
        }

        static void showDetails(Tuple<int, string, string> tup)
        {
            Console.WriteLine($"ID: {tup.Item1}");
            Console.WriteLine($"Name: {tup.Item2} {tup.Item3}");
        }

        static void Main(string[] args)
        {
            var tup = getDetails();
            showDetails(tup);
        }
    }
}
