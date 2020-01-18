using System;
using System.Collections;

namespace QueueDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Queue Program");

            Queue days = new Queue();
            days.Enqueue("Sunday");
            days.Enqueue("Monday");
            days.Enqueue("Tuesday");
            days.Enqueue("Wednesday");
            days.Enqueue("Thursday");
            days.Enqueue("Friday");
            days.Enqueue("Saturday");

            while (days.Count > 0)
                Console.WriteLine(days.Dequeue().ToString());
        }
    }
}
