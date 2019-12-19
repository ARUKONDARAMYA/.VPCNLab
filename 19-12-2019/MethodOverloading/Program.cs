using System;

namespace MethodOverloading
{
    class Calculate1
    {
        public static int add(int a, int b)
        {
            return a + b;
        }

        public static int add(int a, int b, int c)
        {
            return a + b + c;
        }

    }

    class Calculate2
    {
        public static int add(int a, int b)
        {
            return a + b;
        }

        public static float add(float a, float b)
        {
            return a + b;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Calculate1.add(10, 15) = {Calculate1.add(10, 15)}");
            Console.WriteLine($"Calculate1.add(10, 15, 20) = {Calculate1.add(10, 15, 20)}");
            Console.WriteLine($"Calculate2.add(2, 3) = {Calculate2.add(2, 3)}");
            Console.WriteLine($"Calculate2.add(2.747f, 3.141f) = {Calculate2.add(2.747f, 3.141f)}");
        }
    }
}
