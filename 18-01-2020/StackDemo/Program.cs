using System;
using System.Collections;

namespace StackDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack Program");

            Stack days = new Stack();
            days.Push("Sunday");
            days.Push("Monday");
            days.Push("Tuesday");
            days.Push("Wednesday");
            days.Push("Thursday");
            days.Push("Friday");
            days.Push("Saturday");

            while (days.Count > 0)
                Console.WriteLine(days.Pop().ToString());
        }
    }
}
