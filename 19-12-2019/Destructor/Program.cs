using System;

namespace Destructor
{
    class MyClass
    {
        public MyClass()
        {
            Console.WriteLine("An Instance Created");
        }

        ~MyClass()
        {
            Console.WriteLine("An Instance Destroyed");
        }
    }

    class Program
    {
        static void Create()
        {
            MyClass mc = new MyClass();
        }

        static void Main(string[] args)
        {
            Create();
            GC.Collect();
        }
    }
}
