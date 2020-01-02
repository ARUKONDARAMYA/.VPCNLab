using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedTuple
{
    class Program
    {
        static void Main(string[] args)
        {
            var nt = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10, 11, 12));

            Console.WriteLine("Tuple Elements: ");
            Console.WriteLine(nt.Item1);
            Console.WriteLine(nt.Item2);
            Console.WriteLine(nt.Item3);
            Console.WriteLine(nt.Item4);
            Console.WriteLine(nt.Item5);
            Console.WriteLine(nt.Item6);
            Console.WriteLine(nt.Item7);

            Console.WriteLine(nt.Rest);
            Console.WriteLine(nt.Rest.Item1.Item1);
            Console.WriteLine(nt.Rest.Item1.Item2);
            Console.WriteLine(nt.Rest.Item1.Item3);
            Console.WriteLine(nt.Rest.Item1.Item4);
            Console.WriteLine(nt.Rest.Item1.Item5);
        }
    }
}
