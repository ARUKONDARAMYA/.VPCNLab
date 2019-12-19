using System;

namespace WonderWorksMagicShow
{
    class Program
    {
        static void Main(string[] args)
        {
            float total_people = 0;
            float total_rating = 0.0f;

            for(int i = 1; i < 4; i++)
            {
                Console.WriteLine($"Enter the number of people who watched show {i}");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine($"Enter rating fo show {i}");
                float r = float.Parse(Console.ReadLine());

                total_people += n;
                total_rating += n * r;
            }

            Console.WriteLine($"The overall average for show in {total_rating / total_people}");
        }
    }
}
