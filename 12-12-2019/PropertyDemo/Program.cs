using System;

namespace PropertyDemo
{
    class Temperature
    {
        float c;
        public float f
        {
            set
            {
                c = (value - 32) * (5 / 9.0f);
            }

            get
            {
                return c * 1.8f + 32;
            }
        }

        public float k
        {
            set
            {
                c = value - 273.15f;
            }

            get
            {
                return c + 273.15f;
            }
        }

        public override String ToString()
        {
            return $"{f} °F = {c} °C = {k} K";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Temperature temp = new Temperature();
            temp.f = 104;
            Console.WriteLine(temp);
        }
    }
}
