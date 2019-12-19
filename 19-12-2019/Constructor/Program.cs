using System;

namespace Constructor
{
    class DefExample
    {
        public int a, b;

        public DefExample()
        {
            a = 120;
            b = 200;
        }
    }

    class ParaExample
    {
        public int sum;

        public ParaExample(int a, int b)
        {
            sum = a + b;
        }
    }

    class StaticExample
    {
        static StaticExample()
        {
            Console.WriteLine("Static Constructor");
        }
    }

    class CopyExample
    {
        public int a, b;

        public CopyExample(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public CopyExample(CopyExample copyExample)
        {
            this.a = copyExample.a;
            this.b = copyExample.b;
        }
    }

    class ConstructorExample
    {
        private ConstructorExample()
        {
            Console.WriteLine("Private Constructor");
        }

        static void Main(string[] args)
        {
            DefExample de = new DefExample();
            Console.WriteLine($"Default Constructor: a = {de.a}, b = {de.b}");

            ParaExample pe = new ParaExample(5, 10);
            Console.WriteLine($"Parameter Constructor: sum = {pe.sum}");

            StaticExample se = new StaticExample();

            CopyExample ce = new CopyExample(8, 16);
            CopyExample ce1 = new CopyExample(ce);
            Console.WriteLine($"Copy Constructor: a = {ce1.a}, b = {ce1.b}");

            ConstructorExample e = new ConstructorExample();
        }
    }
}
