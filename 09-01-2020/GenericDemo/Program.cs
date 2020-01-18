using System;

namespace GenericDemo
{
    class GenericClass
    {
        public bool Compare<T>(T a, T b)
        {
            if (a.Equals(b))
                return true;
            return false;
        }
    }

    class Program
    {
        static void Main()
        {
            GenericClass obj = new GenericClass();
            bool resf = obj.Compare<float>(2.5f, 3.6f);
            bool resi = obj.Compare<int>(2, 3);

            Console.WriteLine($"Float result = {resf} \nint result = {resi} ");
        }

    }
}
