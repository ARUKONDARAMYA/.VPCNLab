using System;

namespace DelegateDemo
{
    public delegate void SimpleDelegate();

    class Program
    {
        public static void myFunc()
        {
            Console.WriteLine("Delegate Success");
        }

        static void Main(string[] args)
        {
            SimpleDelegate simpleDelegate = new SimpleDelegate(myFunc);
            simpleDelegate();
        }
    }
}