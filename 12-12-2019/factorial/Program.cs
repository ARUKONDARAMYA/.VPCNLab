using System;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number: ");
            int n = int.Parse(Console.ReadLine());

            int ans = 1;
            for(int i = 1; i <= n; i++)
                ans *= i;

            Console.WriteLine($"{n}! = {ans}");
        }
    }
}
