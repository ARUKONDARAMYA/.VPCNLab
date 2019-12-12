using System;

namespace StaticClassDemo
{
    class StaticClass
    {
        public static string str;

        public static void print()
        {
            Console.WriteLine(str);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            StaticClass.str = "This is a String inside a static class";
            StaticClass.print();
        }
    }
}
