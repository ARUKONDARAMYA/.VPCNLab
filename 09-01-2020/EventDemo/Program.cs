using System;

namespace EventHandling
{
    class Program
    {
        public delegate void myDel(int a, int b);
        public static event myDel event1;
        public static event myDel event2;

        void sum(int x, int y)
        {
            Console.WriteLine($"This is method M1\nSum = {x + y}");
        }

        void product(int x, int y)
        {
            Console.WriteLine($"This is method M2\nProduct = {x * y}");
        }

        static void Main()
        {
            Program prog = new Program();
            event1 += new myDel(prog.sum);
            event2 += new myDel(prog.product);

            event1(3, 4);
            event2(3, 3);
        }
    }
}
