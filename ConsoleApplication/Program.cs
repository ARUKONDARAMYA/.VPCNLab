using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number: ");
            int n = int.Parse(Console.ReadLine());
            int f = 1;

            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0)
                    f++;

            f = f * 2 - ((n % Math.Sqrt(n) == 0) ? 1 : 0);

            Console.WriteLine($"{n} has {f} factors");
        }
    }
}
